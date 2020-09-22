using System;
using System.Collections.Generic;
using System.Text;

namespace SClipper
{
    class WindowInformation
    {
        private string processName;
        private string windowTitle;
        private int processId;

        public WindowInformation(string processName, string windowTitle, int processId)
        {
            this.processName = processName;
            this.windowTitle = windowTitle;
            this.processId = processId;
        }

        public WindowInformation()
        {
            this.processName = "";
            this.windowTitle = "";
            this.processId = -1;
        }

        public string toString()
        {
            return String.Format("Process Id: {0}, Process Name: {1}, Window Title: {2}", this.processId, this.processName, this.windowTitle);
        }

        public string ProcessName
        {
            get
            {
                return processName;
            }
        }

        public string WindowTitle
        {

            get
            {
                return windowTitle;
            }
        }

        public int ProcessId
        {

            get
            {
                return processId;
            }
        }
    }
}
