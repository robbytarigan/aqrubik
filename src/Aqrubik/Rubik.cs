namespace Aqrubik {
    #region Using
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    #endregion Using
    /// <summary>
    /// Represents a rubik which contains 27 cubes, which one in the core center and 6 on the center of six surfaces.
    /// </summary>
    public class Rubik {
        private Cube[] cubes = new Cube[27];    // Index represents the position of the 3 x 3 cube 0 is front left up to 26 is back right down

        public Rubik() {
            cubes[ 0] = new Cube(Color.Blue  | Color.Orange | Color.Yellow , Face.Front | Face.Left  | Face.Up);
            cubes[ 1] = new Cube(Color.Blue  | Color.None   | Color.Yellow , Face.Front | Face.None  | Face.Up); 
            cubes[ 2] = new Cube(Color.Blue  | Color.Red    | Color.Yellow , Face.Front | Face.Right | Face.Up);
            cubes[ 3] = new Cube(Color.Blue  | Color.Orange | Color.None   , Face.Front | Face.Left  | Face.None);
            cubes[ 4] = new Cube(Color.Blue  | Color.None   | Color.None   , Face.Front | Face.None  | Face.None); // Central Front
            cubes[ 5] = new Cube(Color.Blue  | Color.Red    | Color.None   , Face.Front | Face.Right | Face.None);
            cubes[ 6] = new Cube(Color.Blue  | Color.Orange | Color.White  , Face.Front | Face.Left  | Face.Down);
            cubes[ 7] = new Cube(Color.Blue  | Color.None   | Color.White  , Face.Front | Face.None  | Face.Down);
            cubes[ 8] = new Cube(Color.Blue  | Color.Red    | Color.White  , Face.Front | Face.Right | Face.Down);
            cubes[ 9] = new Cube(Color.None  | Color.Orange | Color.Yellow , Face.None  | Face.Left  | Face.Up);
            cubes[10] = new Cube(Color.None  | Color.None   | Color.Yellow , Face.None  | Face.None  | Face.Up);   // Central Up
            cubes[11] = new Cube(Color.None  | Color.Red    | Color.Yellow , Face.None  | Face.Right | Face.Up);  
            cubes[12] = new Cube(Color.None  | Color.Orange | Color.None   , Face.None  | Face.Left  | Face.None); // Central Left
            cubes[13] = new Cube(Color.None  | Color.None   | Color.None   , Face.None  | Face.None  | Face.None); // Cube which will not move
            cubes[14] = new Cube(Color.None  | Color.Red    | Color.None   , Face.None  | Face.Right | Face.None); // Central Right
            cubes[15] = new Cube(Color.None  | Color.Orange | Color.White  , Face.None  | Face.Left  | Face.Down); 
            cubes[16] = new Cube(Color.None  | Color.None   | Color.White  , Face.None  | Face.None  | Face.Down); // Central Down
            cubes[17] = new Cube(Color.None  | Color.Red    | Color.White  , Face.None  | Face.Right | Face.Down);
            cubes[18] = new Cube(Color.Green | Color.Orange | Color.Yellow , Face.Back  | Face.Left  | Face.Up);   
            cubes[19] = new Cube(Color.Green | Color.None   | Color.Yellow , Face.Back  | Face.None  | Face.Up);   
            cubes[20] = new Cube(Color.Green | Color.Red    | Color.Yellow , Face.Back  | Face.Right | Face.Up);  
            cubes[21] = new Cube(Color.Green | Color.Orange | Color.None   , Face.Back  | Face.Left  | Face.None); 
            cubes[22] = new Cube(Color.Green | Color.None   | Color.None   , Face.Back  | Face.None  | Face.None); // Central Back
            cubes[23] = new Cube(Color.Green | Color.Red    | Color.None   , Face.Back  | Face.Right | Face.None);
            cubes[24] = new Cube(Color.Green | Color.Orange | Color.White  , Face.Back  | Face.Left  | Face.Down);
            cubes[25] = new Cube(Color.Green | Color.None   | Color.White  , Face.Back  | Face.None  | Face.Down);
            cubes[26] = new Cube(Color.Green | Color.Red    | Color.White  , Face.Back  | Face.Right | Face.Down);           
        }

        public Cube[] Cubes {
            get { return cubes; }
        }

        public void Move(Face side, Movement movement) {
            switch (side) {
                case Face.Front: // 0, 1, 2, 3, 4, 5, 6, 7, 8
                    break;
                case Face.Back : // 18, 19, 20, 21, 22, 23, 24, 25, 26
                    break;
                case Face.Left : // 0, 3, 6, 9, 12, 15, 18, 21, 24
                    break;
                case Face.Right: // 2, 5, 8, 11, 14, 17, 20, 23, 26
                    break;
                case Face.Up   : // 0, 1, 2, 9, 10, 11, 18, 19, 20
                    break;
                case Face.Down: // 6, 7, 8, 15, 16, 17, 24, 25, 26
                    break;
            }
        }
    }
}
