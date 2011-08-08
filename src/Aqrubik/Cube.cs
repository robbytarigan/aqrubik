namespace Aqrubik {
    #region Using
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    #endregion Using
    /// <summary>
    /// Represents one cube of the rubik.
    /// </summary>
    public class Cube {
        private readonly Color color;
        private Face position;

        public Cube(Color color, Face currentPosition) {
            this.color = color;
            this.position = currentPosition;
        }

        public Color Color { get { return color; }  }
        public Face Position { get { return position; } set { position = value; } }
    }
}
