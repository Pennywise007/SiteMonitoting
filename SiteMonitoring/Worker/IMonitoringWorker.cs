using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SiteMonitorings.Settings;

namespace SiteMonitorings.Worker
{
    public delegate bool FoundHandler(object sender, ListingInfo parameters);

    /// <summary>
    /// Interface for executing monitoring
    /// </summary>
    public interface IMonitoringWorker : IDisposable
    {
        /// <summary>
        /// Finishing execution
        /// <param> string is null if no error, otherwise contain error message</param>
        /// </summary>
        event EventHandler<string> WhenFinish;

        /// <summary> An error occurred during the execution </summary>
        event EventHandler<string> WhenError;

        /// <summary> Notification about new item found </summary>
        event FoundHandler WhenFound;

        bool Start(List<PageSettings> pageSettings, Mutex parametersChangingMutex, WorkMode mode);

        /// <summary> Interrupting </summary>
        void Interrupt();

        /// <returns>True if executing</returns>
        bool IsWorking();
    }
}
