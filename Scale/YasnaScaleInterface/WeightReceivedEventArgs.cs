namespace YasnaScaleInterface
{
    public class WeightReceivedEventArgs
    {
        public WeightReceivedEventArgs(decimal weight)
        {
            Weight = weight;
        }

        public decimal Weight { get; }
    }
}