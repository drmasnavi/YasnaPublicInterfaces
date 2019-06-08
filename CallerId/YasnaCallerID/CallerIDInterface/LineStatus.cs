namespace YasnaCallerID.CallerIDInterface
{
    /// <summary>
    /// وضعیت خط که می تواند سه حالت داشته باشد.:1- گوشی را گذاشته باشیم 2- گوشی را برداشته باشیم 3- در حال زنگ خوردن باشد
    /// </summary>
    /// <remarks></remarks>
    public enum LineStatus
    {
        HookOff = 1,
        HookOn = 2,
        Ringing = 3
    }
}

