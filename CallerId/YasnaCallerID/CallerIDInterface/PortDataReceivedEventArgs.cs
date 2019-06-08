using System;

namespace YasnaCallerID.CallerIDInterface
{
    /// <summary>
    /// آرگمان های دریافت داده بر روی درگاه
    /// </summary>
    /// <remarks></remarks>
    public class PortDataReceivedEventArgs : EventArgs
    {
        private readonly object _data;
        private readonly string _portName;
        private readonly string _portType;

        /// <summary>
        /// Initializes a new instance of the <see cref="PortDataReceivedEventArgs"/> class.
        /// </summary>
        /// <param name="portName">نام درگاه</param>
        /// <param name="portType">نوع درگاه</param>
        /// <param name="data">داده دریافتی</param>
        /// <remarks></remarks>
        public PortDataReceivedEventArgs(string portName, string portType, object data)
        {
            _portName = portName;
            _portType = portType;
            _data = data;
        }

        public object Data
        {
            get
            {
                return _data;
            }
        }

        public string PortName
        {
            get
            {
                return _portName;
            }
        }

        public string PortType
        {
            get
            {
                return _portType;
            }
        }
    }
}

