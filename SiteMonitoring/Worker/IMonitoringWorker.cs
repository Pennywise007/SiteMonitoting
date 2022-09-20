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

        /// <summary> An error occurred during the execution </summary>
        event EventHandler<ListingInfo> WhenFound;

        void Start(List<PageSettings> pageSettings, Mutex parametersChangingMutex, WorkMode mode);

        /// <summary> Interrupting </summary>
        void Interrupt();

        /// <returns>True if executing</returns>
        bool IsWorking();
    }
}
