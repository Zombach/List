namespace List
{
    public class LinkNode
    {
        public int Value { get; set; }
        public LinkNode LinkNext { get; set; }

        public LinkNode(int value)
        {
            Value = value;
            LinkNext = null;
        }
    }
}
