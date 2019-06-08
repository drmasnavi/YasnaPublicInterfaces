using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YasnaScaleInterface
{
    public interface IScaleProcessor
    {
        string GetName(int lcid);
        string PortName { get; set; }
        string BaudRate { get; set; }
        void StartMonitoring();
        void StopMonitoring();

        event WeightReceivedDeligate WeightReceived;
        event LogInternalExceptionDeligate LogInternalException;
        event LogStringObjectDeligate LogStringObject;
    }
}
