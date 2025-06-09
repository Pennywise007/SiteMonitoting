using System.Collections.Generic;
using System.Xml.Serialization;
using System;

namespace WebTest.Settings
{
    [Serializable]
    public class ProgramSettings
    {
        [XmlAttribute] public int SettingsVersion = 1;

        public string Url;

        public List<PathInfo> XPaths = new List<PathInfo>();

        public string ElementXPath;
    }


    [Serializable]
    public class PathInfo
    {
        public string Path { get; set; }
    }
}
