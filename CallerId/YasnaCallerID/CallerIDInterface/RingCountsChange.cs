namespace YasnaCallerID.CallerIDInterface
{
    /// <summary>
    /// رخداد تعویض تعداد زنگ خور خط که می تواند کاربر را بخطی نسبت به خط دیگر حساس تر کند
    /// </summary>
    /// <param name="sender">ارسال کننده</param>
    /// <param name="previousRingCounts">تعداد زنگ پیشین</param>
    /// <remarks></remarks>
    public delegate void RingCountsChange(ILine sender, int previousRingCounts);
}

