using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SiteMonitorings.UI;
using SiteMonitorings.Worker;
using Microsoft.Extensions.DependencyInjection;

namespace SiteMonitorings
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(BuildServiceProvider().GetRequiredService<MainForm>());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}\n{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Composition root.
        /// </summary>
        private static IServiceProvider BuildServiceProvider()
        {
            var serviceCollection = new ServiceCollection();

            serviceCollection.AddScoped<MainForm>();
            serviceCollection.AddTransient<IMonitoringWorker, Worker.MonitoringWorker>();

            return serviceCollection.BuildServiceProvider();
        }
    }
}
