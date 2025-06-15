using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;
using OpenQA.Selenium;
using SiteMonitorings.WebDriver;

namespace SiteMonitorings.Settings
{
    [Serializable]
    public class ProgramSettings
    {
        [XmlAttribute] public int SettingsVersion = 1;

        public WorkMode WorkMode = WorkMode.eMinutes_1;

        // Command for sending information about new element, each parameter from ParametersList will be added
        public string CommandLineOnNewElement = "sendInfo.exe";
        public string CommandLineOnError = null;

        public List<PageSettings> pageSettings = new List<PageSettings>();
        public int activePageIndex = 0;
    }

    [Serializable]
    public class ListingInfo
    {
        public readonly List<ParameterResult> Parameters = new List<ParameterResult>();
        public ListingInfo()
        {
        }
        public ListingInfo(List<ParameterResult> result)
        {
            Parameters = result;
        }
    }

    [Serializable]
    public class ExecutionInfo
    {
        public enum ExecutionType
        {
            eClick = 0,
            eEnterText,
            eWait,
            eInterruptIfExistAndText,
            eInterruptIfNotExistOrTextNotEqual,
        };
        public string path;
        public ExecutionType action = ExecutionType.eClick;
        public string value;
    }

    [Serializable]
    public class PageSettings
    {
        public string Name = "";

        public string SiteLink = "";
        public List<ElementInfo> PathToList = new List<ElementInfo>();
        public string ListingsElementNameInList = "";
        public List<ParameterInfo> ParametersList = new List<ParameterInfo>();

        public List<ListingInfo> AlreadySendedListings = new List<ListingInfo>();
        public List<ExecutionInfo> ExecutionInfo = new List<ExecutionInfo>();
    };

    [Serializable]
    public class ElementInfo
    {
        public enum ElementType
        {
            Class = 0,
            ClassContains,
            Link,
            Text,
            Attribute,
            XPath
        }

        public string Name { get; set; }
        public ElementType Type { get; set; } = ElementType.Class;

        public bool NeedFindElement()
        {
            return Name != "*" || Type != ElementType.Class;
        }

        public By GetBy()
        {
            return GetBy(Type, Name);
        }
        public static By GetBy(ElementType type, string name)
        {
            switch (type)
            {
                case ElementType.Class:
                    return By.XPath($".//*[@class='{name}']");
                case ElementType.ClassContains:
                    return By.XPath($".//*[contains(@class, '{name}')]");
                case ElementType.Link:
                    return ByAttribute.PartOfValue("href", name, "*");
                case ElementType.Text:
                    return ByText.Contains(name);
                case ElementType.Attribute:
                    return ByAttribute.Name(name);
                case ElementType.XPath:
                    return By.XPath(name);
                default:
                    throw new Exception("Unknownw element type");
            }
        }
        public static string GetContent(IWebElement element, ElementType type, string name)
        {
            switch (type)
            {
                case ElementType.Class:
                case ElementType.ClassContains:
                    throw new Exception("Parameter can't be a class");
                case ElementType.Link:
                    return element.GetElementLink();
                case ElementType.Text:
                    return element.GetElementText();
                case ElementType.Attribute:
                    return element.GetAttribute(name);
                default:
                    throw new Exception($"Unsupported element type {type} for get content");
            }
        }

        static public List<ElementInfo> ConvertToElementsInfo(string fullPath)
        {
            string[] separator = { "->" };
            var res = fullPath.Split(separator, StringSplitOptions.RemoveEmptyEntries);

            List<ElementInfo> list = new List<ElementInfo>();
            foreach (var element in res)
            {
                var text = element.Trim();
                Debug.Assert(!string.IsNullOrEmpty(text));
                if (text.StartsWith(".//") || text.StartsWith("//"))
                    list.Add(new ElementInfo { Name = text, Type = ElementInfo.ElementType.XPath });
                else
                    list.Add(new ElementInfo { Name = text, Type = ElementInfo.ElementType.ClassContains });
            }

            return list;
        }
    }

    [Serializable]
    public class ParameterInfo
    {
        // full path to element devided by ->. For example "listing_name->link" => class "listing_name" + element "link"
        public string FullPath { get; set; }

        public ElementInfo.ElementType Type { get; set; } = ElementInfo.ElementType.Link;

        public string ParameterName { get; set; }
    }

    [Serializable]
    public struct ParameterResult
    {
        public string ParameterName;
        public string Content;
    }

    // Helping class for getting the presentation of listing actions in lists
    public class ListPathInfoDetails
    {
        public ElementInfo.ElementType Type { get; set; }
        public string Presentation { get; set; }

        public static void SetupElementTypes(ref DataGridViewComboBoxColumn column, bool forElementSearch)
        {
            List<ListPathInfoDetails> list = new List<ListPathInfoDetails>();
            if (forElementSearch)
            {
                list.Add(new ListPathInfoDetails { Type = ElementInfo.ElementType.Class, Presentation = "Class" });
            }
            list.Add(new ListPathInfoDetails { Type = ElementInfo.ElementType.Link, Presentation = "Link" });
            list.Add(new ListPathInfoDetails { Type = ElementInfo.ElementType.Text, Presentation = "Text" });
            list.Add(new ListPathInfoDetails { Type = ElementInfo.ElementType.Attribute, Presentation = "Attribute" });
            list.Add(new ListPathInfoDetails { Type = ElementInfo.ElementType.XPath, Presentation = "XPath" });

            column.DataSource = new BindingList<ListPathInfoDetails>(list);
            column.DisplayMember = "Presentation";
            column.ValueMember = "Type";
        }
    }

    public enum WorkMode
    {
        eOnes = 0,
        eSeconds_1,
        eSeconds_30,
        eMinutes_1,
        eMinutes_5,
        eMinutes_10,
        eMinutes_15,
        eMinutes_30,
        eHour_1,
        eHour_5,
        eDay,
        eUntilInterrupt,
        eTestMode
    }

    // Helping class for getting the presentation of listing actions in lists
    public class WorkModeDetails
    {
        public WorkMode Mode { get; set; }
        public string Presentation { get; set; }

        public static void SetupWorkMode(ref MetroFramework.Controls.MetroComboBox combobox)
        {
            combobox.DataSource = new BindingList<WorkModeDetails>
            {
                new WorkModeDetails{ Mode = WorkMode.eOnes, Presentation = "Один раз" },
                new WorkModeDetails{ Mode = WorkMode.eSeconds_1, Presentation = "Раз в 1 секунду" },
                new WorkModeDetails{ Mode = WorkMode.eSeconds_30, Presentation = "Раз в 30 секунд" },
                new WorkModeDetails{ Mode = WorkMode.eMinutes_1, Presentation = "Раз в 1 минуту" },
                new WorkModeDetails{ Mode = WorkMode.eMinutes_5, Presentation = "Раз в 5 минут" },
                new WorkModeDetails{ Mode = WorkMode.eMinutes_10, Presentation = "Раз в 10 минут" },
                new WorkModeDetails{ Mode = WorkMode.eMinutes_15, Presentation = "Раз в 15 минут" },
                new WorkModeDetails{ Mode = WorkMode.eMinutes_30, Presentation = "Раз в 30 минут" },
                new WorkModeDetails{ Mode = WorkMode.eHour_1, Presentation = "Раз в час" },
                new WorkModeDetails{ Mode = WorkMode.eHour_5, Presentation = "Раз в 5 часов" },
                new WorkModeDetails{ Mode = WorkMode.eDay, Presentation = "Раз в 5 день" },
                new WorkModeDetails{ Mode = WorkMode.eUntilInterrupt, Presentation = "До отмены" }
            };
            combobox.DisplayMember = "Presentation";
            combobox.ValueMember = "Mode";
        }
    }
}
