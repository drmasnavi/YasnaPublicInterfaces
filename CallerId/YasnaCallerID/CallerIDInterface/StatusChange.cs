namespace YasnaCallerID.CallerIDInterface
{
    /// <summary>
    /// رخداد تغییر وضعیت خط
    /// </summary>
    /// <param name="sender">ارسال کننده</param>
    /// <param name="previousState">وضعیت پیشین خط</param>
    /// <remarks></remarks>
    public delegate void StatusChange(ILine sender, LineStatus previousState);
}

