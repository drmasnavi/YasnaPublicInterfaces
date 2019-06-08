namespace YasnaSms
{
    public class SendReturnObject
    {
        public SendReturnObject(string message, SentStatus status, int retId)
        {
            Message = message;
            Status = status;
            RetrievalId = retId;
        }

        public SendReturnObject()
        {
        }

        public string Message { get; set; }

        public int RetrievalId { get; set; }

        public SentStatus Status { get; set; }
    }
}
