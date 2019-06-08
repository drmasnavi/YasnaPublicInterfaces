using System;

namespace YasnaCallerID.CallerIDInterface
{
    /// <summary>
    /// یک خط از خطوط دستگاه کالرآیدی در یک مدل
    /// </summary>
    /// <remarks></remarks>
    public interface ILine
    {
        /// <summary>
        /// واقعه تغییر شماره که نرم افزار انتظار دارد توسط شما رخ دهد
        /// </summary>
        /// <remarks></remarks>
        event NumberChange NumberChanged;

        /// <summary>
        /// واقعه تغییر تعداد زنگ که نرم افزار انتظار دارد توسط شما رخ دهد
        /// </summary>
        /// <remarks></remarks>
        event RingCountsChange RingCountsChanged;

        /// <summary>
        /// واقعه تغییر حالت دستگاه که نرم افزار انتظار دارد توسط شما رخ دهد
        /// </summary>
        /// <remarks></remarks>
        event StatusChange StatusChanged;

        /// <summary>
        /// واقعه تغییر مقدار زمان مکالمه تماس خروجی
        /// </summary>
        event DurationChange DurationChanged;
        event DialedNumberChange DialedNumberChanged;
        /// <summary>
        /// ساعت و تاریخ آخرین بروزرسانی وضعیت خط
        /// </summary>
        /// <value>ساعت و تاریخ</value>
        /// <remarks></remarks>
        DateTime LastUpdate { get; set; }

        /// <summary>
        /// شماره خط
        /// </summary>
        /// <remarks></remarks>
        int LineNumber { get; }

        /// <summary>
        /// شماره تلفن بازگشتی از مخابرات پیش از ارسال به نرم افزار آنرا استاندارد نمایید که حتما با صفر آغاز شود
        /// </summary>
        /// <value>The number.</value>
        /// <remarks></remarks>
        string Number { get; set; }

        /// <summary>
        /// در صورتیکه تماس خروجی داشته باشیم مقدار گیری می کند
        /// </summary>
        string DialedNumber { get; set; }
        /// <summary>
        /// زمان مکالمه تماس خروجی
        /// </summary>
        int DurationSecs { get; set; }
        /// <summary>
        /// تعداد زنگ ها تا کنون پس از اتمام به صورت دستی صفر شود
        /// </summary>
        /// <value>The ring counts.</value>
        /// <remarks></remarks>
        int RingCounts { get; set; }

        /// <summary>
        /// وضعیت خط هم اکنون
        /// </summary>
        /// <value>وضعیت</value>
        /// <remarks></remarks>
        LineStatus Status { get; set; }
    }
}

