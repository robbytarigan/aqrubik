namespace Aqrubik {
    /// <summary>
    /// Represents one cube of the rubik.
    /// </summary>
    public class Cube {
        private readonly Color color;
        //private Face position;

        public Cube(Color color) {
            this.color = color;
            //this.position = currentPosition;
        }

        public Color Color { get { return color; }  }
        //public Face Position { get { return position; } set { position = value; } }
    }
}
