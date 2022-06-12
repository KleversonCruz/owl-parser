namespace OwlParser.Lib.Schemas.Bpmn.Diagram
{
    public static class Grid
    {
        public class Coordinates
        {
            public Coordinates(int x, int y)
            {
                X = x;
                Y = y;
            }
            public int X { get; set; }
            public int Y { get; set; }
        }

        public static Coordinates LeftTop => new(96, 188);
        public static Coordinates LeftMiddle => new(96, 188);
        public static Coordinates LeftBottom => new(96, 188);

        public static Coordinates CenterTop => new(321, 173);
        public static Coordinates CenterMiddle => new(321, 173);
        public static Coordinates CenterBottom => new(321, 173);

        public static Coordinates RightTop => new(654, 188);
        public static Coordinates RightMiddle => new(654, 188);
        public static Coordinates RightBottom => new(654, 188);
    }
}
