using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace Kits.CommonUtils
{
    public class AppManager : IDisposable
    {
        #region Imports

        [DllImport("Coredll.dll", SetLastError = true)]
        static extern IntPtr CreateEvent(IntPtr alwaysZero, bool manualReset, bool initialState, string name);
        [DllImport("Coredll.dll", SetLastError = true)]
        static extern int CloseHandle(IntPtr handle);

        #endregion
        public AppManager(string appName)
        {
            _eventHandle = CreateEvent(IntPtr.Zero, true, false, appName + "Event");
            _isFirstInstance = Marshal.GetLastWin32Error() == 0;
        }
        public void Dispose()
        {
            if (_eventHandle != IntPtr.Zero)
                CloseHandle(_eventHandle);
        }
        public bool IsFirstInstance
        {
            get { return _isFirstInstance; }
        }


        private bool _isFirstInstance;
        private IntPtr _eventHandle = IntPtr.Zero;
    }

}
