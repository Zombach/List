namespace List.Node
{
    public class DoubleLink
    {
        public int Value { get; set; }
        public DoubleLink LinkNext { get; set; }
        public DoubleLink LinkPrevious { get; set; }

        public DoubleLink()
        {
            LinkNext = null;
            LinkPrevious = null;
        }

        public DoubleLink(int value)
        {
            Value = value;
            LinkNext = null;
            LinkPrevious = null;
        }

        public DoubleLink(DoubleLink doubleLink)
        {
            Value = doubleLink.Value;
            LinkNext = doubleLink.LinkNext;
            LinkPrevious = doubleLink.LinkPrevious;
        }
    }
}
