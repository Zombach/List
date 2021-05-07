namespace List.Node
{
    public class Link
    {
        public int Value { get; set; }
        public Link LinkNext { get; set; }

        public Link(int value)
        {
            Value = value;
            LinkNext = null;
        }
    }
}
