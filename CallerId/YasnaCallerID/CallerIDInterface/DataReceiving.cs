namespace YasnaCallerID.CallerIDInterface
{
    /// <summary>
    /// این واقعه توسط برنامه نویس زمانی که از درگاه سریال
    /// استفاده کند فراخوانی می شود بدین صورت که زمانیکه برنامه نویس 
    /// عملیات آغاز مانیتورینگ درگاه را در اختیار می گیرد
    /// این واقعه را پس از دریافت داده بر روی درگاه سریال به صورت دستی به شکل زیر صدا می زند
    /// این واقعه در بخش دیگری بر روی تک تک خطوط کالرآیدی فعال بوده و با صدا شدن مشابه مثال زیر منجر به تعیین حالت دستگاه می گردد.
    /// تعیین حالت به داده موجود در اطلاعات دریافت شده از درگاه سریال وابسته است.
    /// SetLinesState(args.Data as string);
    ///  var args = new PortDataReceivedEventArgs(PortName, "Serial", ReadLine());
    ///             PortDataReceived(args);
    /// </summary>
    /// <param name="args">The <see cref="YasnaCallerID.CallerIDInterface.PortDataReceivedEventArgs"/> instance containing the event data.</param>
    /// <remarks></remarks>
    public delegate void DataReceiving(PortDataReceivedEventArgs args);
}

