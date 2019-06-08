namespace YasnaMana
{
    public interface IManaProcessor
    {
        void SetParameters(string username, string password, string sender);
        double GetCurrentCredit();
        int GetTotalCount();
        int GetUnreadCount();
    }
}
