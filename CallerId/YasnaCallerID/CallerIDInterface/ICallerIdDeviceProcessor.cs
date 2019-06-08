using System;
using System.Collections.Generic;

namespace YasnaCallerID.CallerIDInterface
{
    /// <summary>
    /// مدلی از مدل های دستگاه کالرآیدی شرکت
    /// </summary>
    /// <remarks></remarks>
    public interface ICallerIdDeviceProcessor
    {
        /// <summary>
        /// نام مدل مثلا 2خط 4خط و غیره
        /// </summary>
        /// <param name="lcid">نام مدل را به زبان های مختلف  تعریف نمایید</param>
        /// <returns></returns>
        /// <remarks></remarks>
        string GetName(int lcid);
        /// <summary>
        /// رخ داد آغاز عملیات مانیتورینگ که پس از تعیین مدل و درگاه توسط برنامه صدا زده خواهد شد
        /// </summary>
        /// <remarks></remarks>
        void StartMonitoring(string port,string baudRate, IntPtr handle = default(IntPtr));
        /// <summary>
        /// پایان عملیات مانیتورینگ با بسته شدن نرم افزار صدا زده می شود که شما درگاهی را که باز نمودید ببندید
        /// </summary>
        /// <remarks></remarks>
        void StopMonitoring();
        bool IsHid { get; }
        void OnDeviceChange(int mMsg, IntPtr mWParam, IntPtr mLParam, ref bool handled);
        string DeviceProcessorKey { get; }

        /// <summary>
        /// لیست خطوط کالرآیدی
        /// </summary>
        /// <remarks></remarks>
        ICollection<ILine> Lines { get; }

        /// <summary>
        /// تعداد خطوط کالرآیدی
        /// </summary>
        /// <remarks></remarks>
        int LinesCount { get; }
        /// <summary>
        /// از این رخداد برای هندل کردن خطاهای خود و نمایش آن در دیاگ استفاده نمایید
        /// </summary>
        event LogInternalException LogInternalException;

        event LogIntValue LogIntValue;
        event LogStringValue LogStringValue;
        event LogObjectValue LogObjectValue;
        event LogMessageValue LogMessageValue;
    }
}

