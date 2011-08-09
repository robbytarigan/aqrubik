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
            cubes[ 0] = new Cube(Color.Blue  | Color.Orange | Color.Yellow);
            cubes[ 1] = new Cube(Color.Blue  | Color.None   | Color.Yellow);
            cubes[ 2] = new Cube(Color.Blue  | Color.Red    | Color.Yellow);
            cubes[ 3] = new Cube(Color.Blue  | Color.Orange | Color.None);
            cubes[ 4] = new Cube(Color.Blue  | Color.None   | Color.None); // Central Front
            cubes[ 5] = new Cube(Color.Blue  | Color.Red    | Color.None);
            cubes[ 6] = new Cube(Color.Blue  | Color.Orange | Color.White);
            cubes[ 7] = new Cube(Color.Blue  | Color.None   | Color.White);
            cubes[ 8] = new Cube(Color.Blue  | Color.Red    | Color.White);
            cubes[ 9] = new Cube(Color.None  | Color.Orange | Color.Yellow);
            cubes[10] = new Cube(Color.None  | Color.None   | Color.Yellow);   // Central Up
            cubes[11] = new Cube(Color.None  | Color.Red    | Color.Yellow);
            cubes[12] = new Cube(Color.None  | Color.Orange | Color.None); // Central Left
            cubes[13] = new Cube(Color.None  | Color.None   | Color.None); // Cube which will not move
            cubes[14] = new Cube(Color.None  | Color.Red    | Color.None); // Central Right
            cubes[15] = new Cube(Color.None  | Color.Orange | Color.White);
            cubes[16] = new Cube(Color.None  | Color.None   | Color.White); // Central Down
            cubes[17] = new Cube(Color.None  | Color.Red    | Color.White);
            cubes[18] = new Cube(Color.Green | Color.Orange | Color.Yellow);
            cubes[19] = new Cube(Color.Green | Color.None   | Color.Yellow);
            cubes[20] = new Cube(Color.Green | Color.Red    | Color.Yellow);
            cubes[21] = new Cube(Color.Green | Color.Orange | Color.None);
            cubes[22] = new Cube(Color.Green | Color.None   | Color.None); // Central Back
            cubes[23] = new Cube(Color.Green | Color.Red    | Color.None);
            cubes[24] = new Cube(Color.Green | Color.Orange | Color.White);
            cubes[25] = new Cube(Color.Green | Color.None   | Color.White);
            cubes[26] = new Cube(Color.Green | Color.Red    | Color.White);           
        }

        public Cube[] Cubes {
            get { return cubes; }
        }

        private static void Rotate(Cube[] sideCubes, Movement movement) {
            if (sideCubes == null)
                throw new ArgumentNullException("sideCubes");

            if (sideCubes.Length != 9)
                throw new ArgumentOutOfRangeException("sideCubes");

            /* Cubes picture:
             * 0 1 2
             * 3 4 5
             * 6 7 8
             */

            Cube tempCube;
            
            switch (movement) {
                case Movement.Quarter:
                    /* Become
                     * 6 3 0
                     * 7 4 1
                     * 8 5 2
                     */
                     tempCube = sideCubes[0];
                     sideCubes[0] = sideCubes[6];
                     sideCubes[6] = sideCubes[8];
                     sideCubes[8] = sideCubes[2];
                     sideCubes[2] = tempCube;
                     
                     tempCube = sideCubes[1];
                     sideCubes[1] = sideCubes[3];
                     sideCubes[3] = sideCubes[7];                     
                     sideCubes[7] = sideCubes[5];
                     sideCubes[5] = tempCube;                     
                     break;
                case Movement.Half:
                    /* Become
                     * 8 7 6
                     * 5 4 3
                     * 2 1 0
                     */
                     tempCube = sideCubes[0];
                     sideCubes[0] = sideCubes[8];
                     sideCubes[8] = sideCubes[0];
                    
                     tempCube = sideCubes[1];
                     sideCubes[1] = sideCubes[7];
                     sideCubes[7] = tempCube;

                     tempCube = sideCubes[2];
                     sideCubes[2] = sideCubes[6];
                     sideCubes[6] = tempCube;

                     tempCube = sideCubes[3];
                     sideCubes[3] = sideCubes[5];
                     sideCubes[5] = tempCube;
                     break;
                case Movement.Inverted:
                    /* Become
                     * 2 5 8
                     * 1 4 7
                     * 0 3 6
                     */
                    tempCube = sideCubes[0];
                     sideCubes[0] = sideCubes[2];
                     sideCubes[2] = sideCubes[8];
                     sideCubes[8] = sideCubes[6];
                     sideCubes[6] = tempCube;
                     
                     tempCube = sideCubes[1];
                     sideCubes[1] = sideCubes[5];
                     sideCubes[5] = sideCubes[7];                     
                     sideCubes[7] = sideCubes[3];
                     sideCubes[3] = tempCube;                     
                    break;
            }
            
        }

        public void Move(Face side, Movement movement) {
            switch (side) {
                case Face.Front: // 0, 1, 2, 3, 4, 5, 6, 7, 8
                    Rotate(new Cube[9] { cubes[0], cubes[1], cubes[2], cubes[3], cubes[4], cubes[5], cubes[6], cubes[7], cubes[8] }, movement);
                    break;
                case Face.Back : // 18, 19, 20, 21, 22, 23, 24, 25, 26
                    Rotate(new Cube[9] { cubes[18], cubes[19], cubes[20], cubes[21], cubes[22], cubes[23], cubes[24], cubes[25], cubes[26] }, movement);
                    break;
                case Face.Left : // 0, 3, 6, 9, 12, 15, 18, 21, 24
                    Rotate(new Cube[9] { cubes[0], cubes[3], cubes[6], cubes[9], cubes[12], cubes[15], cubes[18], cubes[21], cubes[24] }, movement);
                    break;
                case Face.Right: // 2, 5, 8, 11, 14, 17, 20, 23, 26
                    Rotate(new Cube[9] { cubes[2], cubes[5], cubes[8], cubes[11], cubes[14], cubes[17], cubes[20], cubes[23], cubes[26] }, movement);
                    break;
                case Face.Up   : // 0, 1, 2, 9, 10, 11, 18, 19, 20
                    Rotate(new Cube[9] { cubes[0], cubes[1], cubes[2], cubes[9], cubes[10], cubes[11], cubes[18], cubes[19], cubes[20] }, movement);
                    break;
                case Face.Down: // 6, 7, 8, 15, 16, 17, 24, 25, 26
                    Rotate(new Cube[9] { cubes[6], cubes[7], cubes[8], cubes[15], cubes[16], cubes[17], cubes[24], cubes[25], cubes[26] }, movement);
                    break;
            }
        }
    }
}
