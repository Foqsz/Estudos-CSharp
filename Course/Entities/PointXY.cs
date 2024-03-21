namespace Course.Entities
{
    internal struct PointXY
    {
        public int X { get; set; }
        public int Y { get; set; }

        public PointXY(int x, int y) : this()
        {
            X = x;
            Y = y;
        }
    }
}
