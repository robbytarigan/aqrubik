namespace Aqrubik.Test {
    #region Using
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    #endregion Using
    [TestClass]
    public class WhenTwoRubiksInInitialPositionRotateQuarterTwoTimes {
        private static Rubik rubik = new Rubik();
        private static Rubik compareRubik = new Rubik();

        [ClassInitialize]
        public static void Initialise(TestContext context)  {
            rubik.Move(Face.Up, Movement.Quarter);
            rubik.Move(Face.Up, Movement.Quarter);

            compareRubik.Move(Face.Up, Movement.Half);
        }

        [TestMethod]
        public void ThenBothRubikHaveSamePositionForAllTheirCubes() {
            for (int i = 0; i < 27; i++) {
                Assert.AreEqual(compareRubik[i].Color, rubik[i].Color);
            }
        }
    }
}
