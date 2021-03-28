namespace List
{
    public class DoubleLink
    {
        public int Value { get; set; }
        public DoubleLink LinkNext { get; set; }
        public DoubleLink LinkPrevious { get; set; }

        public DoubleLink(int value)
        {
            Value = Value;
            LinkNext = null;
            LinkPrevious = null;
        }
    }
}
