namespace YasnaCallerID.CallerIDInterface
{
    /// <summary>
    /// رخداد تعویض شماره تلفن بر روی خط
    /// </summary>
    /// <param name="sender">ارسال کننده</param>
    /// <param name="previousNumber">شماره تلفن پیشین بر روی این خط</param>
    /// <remarks></remarks>
    public delegate void NumberChange(ILine sender, string previousNumber);
}

