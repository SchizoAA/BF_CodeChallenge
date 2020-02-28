using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BioFire_CodeChallenge;


namespace BioFire_CodeChallenge.Tests
{
    /*
     *Part 3
     * Come up with a set of test cases for the function in Part 2.  You can represent these visually, as data, or as simple descriptions.
     */
     [TestClass]
    public class RectangleOperationsTests
    {
        private Rectangle r1 = new Rectangle(new Tuple<int, int>(0, 2), new Tuple<int, int>(2, 0));
        private Rectangle r2;
        private readonly RectangleOperations rectangleOperations = new RectangleOperations();

        [TestMethod]
        public void Test_RectangleOps_Overlap_TopL()
        {
            var p3 = new Tuple<int, int>(-1, 3);
            var p4 = new Tuple<int, int>(1, 1);
            r2 = new Rectangle(p3, p4);
            var overlap = rectangleOperations.GetRectangleOverlap(r1, r2);
            Assert.IsTrue(overlap.IsValid == true);
            Assert.AreEqual(0, overlap.LCoord.Item1);
            Assert.AreEqual(2, overlap.LCoord.Item2);
            Assert.AreEqual(1, overlap.RCoord.Item1);
            Assert.AreEqual(1, overlap.RCoord.Item2);
        }

        [TestMethod]
        public void Test_RectangleOps_Overlap_TopR()
        {
            var p3 = new Tuple<int, int>(1, 3);
            var p4 = new Tuple<int, int>(3, 1);
            r2 = new Rectangle(p3, p4);
            var overlap = rectangleOperations.GetRectangleOverlap(r1, r2);
            Assert.IsTrue(overlap.IsValid == true);
            Assert.AreEqual(1, overlap.LCoord.Item1);
            Assert.AreEqual(2, overlap.LCoord.Item2);
            Assert.AreEqual(2, overlap.RCoord.Item1);
            Assert.AreEqual(1, overlap.RCoord.Item2);
        }

        [TestMethod]
        public void Test_RectangleOps_Overlap_TopWhole()
        {
            var p3 = new Tuple<int, int>(-1, 3);
            var p4 = new Tuple<int, int>(3, 1);
            r2 = new Rectangle(p3, p4);
            var overlap = rectangleOperations.GetRectangleOverlap(r1, r2);
            Assert.IsTrue(overlap.IsValid == true);
            Assert.AreEqual(0, overlap.LCoord.Item1);
            Assert.AreEqual(2, overlap.LCoord.Item2);
            Assert.AreEqual(2, overlap.RCoord.Item1);
            Assert.AreEqual(1, overlap.RCoord.Item2);
        }

        [TestMethod]
        public void Test_RectangleOps_Overlap_BottomL()
        {
            var p3 = new Tuple<int, int>(-1, 1);
            var p4 = new Tuple<int, int>(1, -1);
            r2 = new Rectangle(p3, p4);
            var overlap = rectangleOperations.GetRectangleOverlap(r1, r2);
            Assert.IsTrue(overlap.IsValid == true);
            Assert.AreEqual(0, overlap.LCoord.Item1);
            Assert.AreEqual(1, overlap.LCoord.Item2);
            Assert.AreEqual(1, overlap.RCoord.Item1);
            Assert.AreEqual(0, overlap.RCoord.Item2);
        }

        [TestMethod]
        public void Test_RectangleOps_Overlap_BottomR()
        {
            var p3 = new Tuple<int, int>(1, 1);
            var p4 = new Tuple<int, int>(3, -1);
            r2 = new Rectangle(p3, p4);
            var overlap = rectangleOperations.GetRectangleOverlap(r1, r2);
            Assert.IsTrue(overlap.IsValid == true);
            Assert.AreEqual(1, overlap.LCoord.Item1);
            Assert.AreEqual(1, overlap.LCoord.Item2);
            Assert.AreEqual(2, overlap.RCoord.Item1);
            Assert.AreEqual(0, overlap.RCoord.Item2);
        }

        [TestMethod]
        public void Test_RectangleOps_Overlap_BottomWhole()
        {
            var p3 = new Tuple<int, int>(-1, 1);
            var p4 = new Tuple<int, int>(3, -1);
            r2 = new Rectangle(p3, p4);
            var overlap = rectangleOperations.GetRectangleOverlap(r1, r2);
            Assert.IsTrue(overlap.IsValid == true);
            Assert.AreEqual(0, overlap.LCoord.Item1);
            Assert.AreEqual(1, overlap.LCoord.Item2);
            Assert.AreEqual(2, overlap.RCoord.Item1);
            Assert.AreEqual(0, overlap.RCoord.Item2);
        }

        [TestMethod]
        public void Test_RectangleOps_Overlap_LeftWhole()
        {
            var p3 = new Tuple<int, int>(-1, 3);
            var p4 = new Tuple<int, int>(1, -1);
            r2 = new Rectangle(p3, p4);
            var overlap = rectangleOperations.GetRectangleOverlap(r1, r2);
            Assert.IsTrue(overlap.IsValid == true);
            Assert.AreEqual(0, overlap.LCoord.Item1);
            Assert.AreEqual(2, overlap.LCoord.Item2);
            Assert.AreEqual(1, overlap.RCoord.Item1);
            Assert.AreEqual(0, overlap.RCoord.Item2);
        }

        [TestMethod]
        public void Test_RectangleOps_Overlap_RightWhole()
        {
            var p3 = new Tuple<int, int>(1, 3);
            var p4 = new Tuple<int, int>(3, -1);
            r2 = new Rectangle(p3, p4);
            var overlap = rectangleOperations.GetRectangleOverlap(r1, r2);
            Assert.IsTrue(overlap.IsValid == true);
            Assert.AreEqual(1, overlap.LCoord.Item1);
            Assert.AreEqual(2, overlap.LCoord.Item2);
            Assert.AreEqual(2, overlap.RCoord.Item1);
            Assert.AreEqual(0, overlap.RCoord.Item2);
        }

        [TestMethod]
        public void Test_RectangleOps_Overlap_Inside()
        {
            var p3 = new Tuple<int, int>(-1, 3);
            var p4 = new Tuple<int, int>(3, -1);
            r2 = new Rectangle(p3, p4);
            var overlap = rectangleOperations.GetRectangleOverlap(r1, r2);
            Assert.IsTrue(overlap.IsValid == true);
            Assert.AreEqual(0, overlap.LCoord.Item1);
            Assert.AreEqual(2, overlap.LCoord.Item2);
            Assert.AreEqual(2, overlap.RCoord.Item1);
            Assert.AreEqual(0, overlap.RCoord.Item2);
        }

        [TestMethod]
        public void Test_RectangleOps_SharedSide_Horizontal()
        {
            var p3 = new Tuple<int, int>(2, 2);
            var p4 = new Tuple<int, int>(3, 0);
            r2 = new Rectangle(p3, p4);
            var overlap = rectangleOperations.GetRectangleOverlap(r1, r2);
            Assert.IsTrue(overlap.IsValid == false);
        }

        [TestMethod]
        public void Test_RectangleOps_SharedSide_Vertical()
        {
            var p3 = new Tuple<int, int>(0, 3);
            var p4 = new Tuple<int, int>(2, 2);
            r2 = new Rectangle(p3, p4);
            var overlap = rectangleOperations.GetRectangleOverlap(r1, r2);
            Assert.IsTrue(overlap.IsValid == false);
        }

        [TestMethod]
        public void Test_RectangleOps_NoOverlap()
        {
            var p3 = new Tuple<int, int>(3, 3);
            var p4 = new Tuple<int, int>(5, 1);
            r2 = new Rectangle(p3, p4);
            var overlap = rectangleOperations.GetRectangleOverlap(r1, r2);
            Assert.IsTrue(overlap.IsValid == false);
            Assert.IsNull(overlap.LCoord);
            Assert.IsNull(overlap.RCoord);
        }
    }
}
