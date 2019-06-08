using System;
using System.Collections.Generic;

namespace YasnaSms
{
    public interface ISmsProcessor
    {
        #region راه اندازی اولیه
        /// <summary>
        /// کلید اختصاصی جهت ردیابی خطاها در دیاگ
        /// </summary>
        string ProcessorKey { get; }
        /// <summary>
        /// خطاهای ماژول شما به این ایمیل به صورت خودکار ارسال می شود
        /// </summary>
        string DeveloperEmail { get; } 
        /// <summary>
        /// نام شرکت شما
        /// </summary>
        /// <param name="lcid">شناسه زبان برای اینکه نام شرکت شما به زبان های مختلف بازگردانده شود</param>
        /// <returns>رشته ای که در بازگشت خواهیم داشت به محض استفاده از درایور شما در فرم مربوطه نمایان خواهد شد</returns>
        /// <remarks></remarks>
        string GetName(int lcid);
        /// <summary>
        /// آدرس وب سایت
        /// </summary>
        /// <returns></returns>
        string GetWebSite();
        /// <summary>
        /// تنظیم پارامتر های اولیه
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="sender"></param>
        void SetParameters(string username, string password, string sender); 
        #endregion

        #region ارسال

        /// <summary>
        /// ارسال پیامک تکی
        /// </summary>
        /// <param name="txt">متن پیامک</param>
        /// <param name="receiver">گیرنده</param>
        /// <param name="dt">زمان ارسال</param>
        /// <returns>شناسه پیگیری</returns>
        SendReturnObject SendSms(string txt, string receiver,DateTime dt);
        /// <summary>
        /// ارسال پیامک فلش تکی
        /// </summary>
        /// <param name="txt">متن پیامک</param>
        /// <param name="receiver">گیرنده</param>
        /// <returns>شناسه پیگیری</returns>
        SendReturnObject SendFlashSms(string txt, string receiver);
        /// <summary>
        /// ارسال گروهی
        /// </summary>
        /// <param name="txt">متن پیام</param>
        /// <param name="receivers">دریافت کنندگان</param>
        /// <returns></returns>
        SendReturnObject[] SendSmsList(string txt, string[] receivers);
        /// <summary>
        /// ارسال گروهی فلش
        /// </summary>
        /// <param name="txt">متن پیام</param>
        /// <param name="receivers">دریافت کنندگان</param>
        /// <returns></returns>
        SendReturnObject[] SendFlashSmsList(string txt, string[] receivers); 
        #endregion
     
        #region توابع 
        /// <summary>
        /// مانده اعتبار ریالی حساب کاربری
        /// </summary>
        /// <returns></returns>
        double GetCurrentCredit();
        /// <summary>
        /// کل پیامک های موجود در باکس کاربری
        /// </summary>
        /// <returns></returns>
        int GetTotalCount();
        /// <summary>
        /// پیامک های خوانده شده
        /// </summary>
        /// <returns></returns>
        int GetUnreadCount();
        /// <summary>
        /// گرفتن وضعیت ارسال پیامک
        /// </summary>
        /// <param name="id">شناسه پیامک</param>
        /// <returns>وضعیت</returns>
        /// 
        RetrievalStatus GetRetrievalStatus(string id);
        /// <summary>
        /// گرفتن وضعیت ارسال پیامک به صورت گروهی
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        RetrievalStatus[] GetRetrievalStatuses(string[] id);
        /// <summary>
        /// بررسی لیست سیاه مخابرات
        /// </summary>
        /// <param name="number">شماره</param>
        /// <returns></returns>
        bool IsNumberBlackList(string number);
        #endregion

        #region دیاگ
        event LogInternalException LogInternalException;
        event LogIntValue LogIntValue;
        event LogStringValue LogStringValue;
        event LogObjectValue LogObjectValue;
        event LogMessageValue LogMessageValue;
        event LogArrayValue LogArrayValue; 
        #endregion

        #region پشتیبانی
        /// <summary>
        /// پشتیبانی از پیامک فلش
        /// </summary>
        bool SupportFlashSms { get; }
        /// <summary>
        /// پشتیبانی از ارسال هم زمان
        /// </summary>
        bool SupportMultipleSend { get; }
        /// <summary>
        /// پشتیبانی از وضعیت ارسال
        /// </summary>
        bool SupportRetrieval { get; }
        /// <summary>
        /// کنترل بلک لیست مخابرات
        /// </summary>
        bool SupportBlackListCheck { get; }
        /// <summary>
        /// پشتیبانی از دریافت آنی وضعیت ارسال چند شماره
        /// </summary>
        bool SupportMultipleRetreive { get; }
        /// <summary>
        /// قابلیت بررسی تعداد پیام های دریافتی
        /// </summary>
        bool SupportInboxCheckCount { get; }
        /// <summary>
        /// پشتیبانی از ارسال برنامه ريزي شده
        /// </summary>
        bool SupportScheduledSms { get; }
        
        #endregion
    }
}
