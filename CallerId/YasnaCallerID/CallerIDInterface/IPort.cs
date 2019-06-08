

using YasnaCallerID.CallerIDInterface;

namespace YasnaCallerID.CallerIDInterface
{
    /// <summary>
    /// درگاه مورد استفاده برای مانیتورینگ دستگاه کالرآیدی
    /// </summary>
    /// <remarks></remarks>
    public interface IPort
    {
        /// <summary>
        /// رخ داد دریافت داده بر روی خط این رخ داد در بخش دیگری توسط برنامه نویس صدا زده می شود
        /// و نظر به اینکه کنترل خط با این واقعه پیوند خورده است این واقعه در این بخش نیز فراخوانی شده
        /// و شما می توانید با استفاده از پروتکل های دستگاه خود داده دریافتی بر روی درگاه سریال را برای مایکروسافت ترجمه کنید
        /// </summary>
        /// <remarks></remarks>
        event DataReceiving PortDataReceived;
        /// <summary>
        /// Log
        /// </summary>
        event LogObjectValue LogObjectValue;
        /// <summary>
        /// گوش دادن بخط
        /// زمانی که مشخصات درگاه سریال مورد استفاده خود را به طور کامل مشخص نمودید
        /// در متد مربوط به آغاز عملیات مانیتورینگ این متد را به صورت دستی فراخوانی می کنید.
        /// در بخش دیگری این متد نقش گشودن درگاه سریال را ایفا خواهد نمود که با آغاز عملیات مانیتورینگ 
        /// صدا زده خواهد شد.
        /// </summary>
        /// <remarks></remarks>
        /// <param name="port">درگاه</param>
        /// <param name="baudRate">نرخ داده</param>
        void StartListenning(string port,string baudRate);
        /// <summary>
        /// توقف گوش دادن بخط
        /// </summary>
        /// <remarks></remarks>
        void StopListenning();
    }
}

