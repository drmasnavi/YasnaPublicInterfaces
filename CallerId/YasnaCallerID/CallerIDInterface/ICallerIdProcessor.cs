using System.Collections.Generic;

namespace YasnaCallerID.CallerIDInterface
{
    /// <summary>
    /// لیست دستگاه هایی که در درایور شما پشتیبانی می شوند
    /// </summary>
    /// <remarks></remarks>
    public interface ICallerIdProcessor
    {
        /// <summary>
        /// نام شرکت شما
        /// </summary>
        /// <param name="lcid">شناسه زبان برای اینکه نام شرکت شما به زبان های مختلف بازگردانده شود</param>
        /// <returns>رشته ای که در بازگشت خواهیم داشت به محض استفاده از درایور شما در فرم مربوطه نمایان خواهد شد</returns>
        /// <remarks></remarks>
        string GetName(int lcid);
        /// <summary>
        /// لیستی از انواع مدلهای شرکت شما نظیر 2 خط 4 خط و غیره
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>
        ICollection<ICallerIdDeviceProcessor> GetProcessors();
        /// <summary>
        /// این کلید در زمینه دیباگ ماژول شما بسیار راه گشا خواهد بود
        /// </summary>
        string ProcessorKey { get; }
        /// <summary>
        /// خطاهای ماژول شما به این ایمیل به صورت خودکار ارسال می شود
        /// </summary>
        string DeveloperEmail { get; }
    }
}

