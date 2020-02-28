using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BioFire_CodeChallenge;

namespace BioFire_CodeChallenge.Tests
{
    [TestClass]
    public class RectangleTests
    {
        [TestMethod]
        public void Test_Rectange_Normalized_Positive()
        {
            var p1 = new Tuple<int,int> (1, 5);
            var p2 = new Tuple<int, int>(2, 1);
            Rectangle r1 = new Rectangle(p1, p2);
            Assert.IsTrue(r1.LCoord.Item1 == 1);
            Assert.IsTrue(r1.LCoord.Item2 == 5);
            Assert.IsTrue(r1.RCoord.Item1 == 2);
            Assert.IsTrue(r1.RCoord.Item2 == 1);
            Assert.IsTrue(r1.IsValid == true);
        }

        [TestMethod]
        public void Test_Rectange_Normalized_Mixed()
        {
            var p1 = new Tuple<int, int>(-1, -5);
            var p2 = new Tuple<int, int>(2, -1);
            Rectangle r1 = new Rectangle(p1, p2);
            Assert.IsTrue(r1.LCoord.Item1 == -1);
            Assert.IsTrue(r1.LCoord.Item2 == -1);
            Assert.IsTrue(r1.RCoord.Item1 == 2);
            Assert.IsTrue(r1.RCoord.Item2 == -5);
            Assert.IsTrue(r1.IsValid == true);
        }

        [TestMethod]
        public void Test_Rectange_Normalized_Negative()
        {
            var p1 = new Tuple<int, int>(-20, -50);
            var p2 = new Tuple<int, int>(-40, -10);
            Rectangle r1 = new Rectangle(p1, p2);
            Assert.IsTrue(r1.LCoord.Item1 == -40);
            Assert.IsTrue(r1.LCoord.Item2 == -10);
            Assert.IsTrue(r1.RCoord.Item1 == -20);
            Assert.IsTrue(r1.RCoord.Item2 == -50);
            Assert.IsTrue(r1.IsValid == true);
        }


        [TestMethod]
        public void Test_Rectange_Normalized_Zero()
        {
            var p1 = new Tuple<int, int>(0, 0);
            var p2 = new Tuple<int, int>(0, 0);
            Rectangle r1 = new Rectangle(p1, p2);
            Assert.IsTrue(r1.LCoord.Item1 == 0);
            Assert.IsTrue(r1.LCoord.Item2 == 0);
            Assert.IsTrue(r1.RCoord.Item1 == 0);
            Assert.IsTrue(r1.RCoord.Item2 == 0);
            Assert.IsTrue(r1.IsValid == false);
        }

        [TestMethod]
        public void Test_Rectange_Normalized_Point()
        {
            var p1 = new Tuple<int, int>(1, 1);
            var p2 = new Tuple<int, int>(1, 1);
            Rectangle r1 = new Rectangle(p1, p2);
            Assert.IsTrue(r1.LCoord.Item1 == 1);
            Assert.IsTrue(r1.LCoord.Item2 == 1);
            Assert.IsTrue(r1.RCoord.Item1 == 1);
            Assert.IsTrue(r1.RCoord.Item2 == 1);
            Assert.IsTrue(r1.IsValid == false);
        }

        [TestMethod]
        public void Test_Rectange_Normalized_VLine()
        {
            var p1 = new Tuple<int, int>(1, 1);
            var p2 = new Tuple<int, int>(1, 5);
            Rectangle r1 = new Rectangle(p1, p2);
            Assert.IsTrue(r1.LCoord.Item1 == 1);
            Assert.IsTrue(r1.LCoord.Item2 == 5);
            Assert.IsTrue(r1.RCoord.Item1 == 1);
            Assert.IsTrue(r1.RCoord.Item2 == 1);
            Assert.IsTrue(r1.IsValid == false);
        }

        [TestMethod]
        public void Test_Rectange_Normalized_HLine()
        {
            var p1 = new Tuple<int, int>(1, 5);
            var p2 = new Tuple<int, int>(10, 5);
            Rectangle r1 = new Rectangle(p1, p2);
            Assert.IsTrue(r1.LCoord.Item1 == 1);
            Assert.IsTrue(r1.LCoord.Item2 == 5);
            Assert.IsTrue(r1.RCoord.Item1 == 10);
            Assert.IsTrue(r1.RCoord.Item2 == 5);
            Assert.IsTrue(r1.IsValid == false);
        }

        [TestMethod]
        public void Test_Rectange_resize()
        {
            var p1 = new Tuple<int, int>(1, 5);
            var p2 = new Tuple<int, int>(10, 5);
            Rectangle r1 = new Rectangle(p1, p2);
            p1 = new Tuple<int, int>(2, 10);
            p2 = new Tuple<int, int>(10, 11);
            r1.Resize(p1,p2);
            Assert.IsTrue(r1.LCoord.Item1 == 2);
            Assert.IsTrue(r1.LCoord.Item2 == 11);
            Assert.IsTrue(r1.RCoord.Item1 == 10);
            Assert.IsTrue(r1.RCoord.Item2 == 10);
            Assert.IsTrue(r1.IsValid == true);
        }

        [TestMethod]
        public void Test_Rectange_resize_InvalidToValid()
        {
            var p1 = new Tuple<int, int>(1, 1);
            var p2 = new Tuple<int, int>(1, 1);
            Rectangle r1 = new Rectangle(p1, p2);
            Assert.IsTrue(r1.IsValid == false);
            p1 = new Tuple<int, int>(2, 10);
            p2 = new Tuple<int, int>(10, 11);
            r1.Resize(p1, p2);
            Assert.IsTrue(r1.LCoord.Item1 == 2);
            Assert.IsTrue(r1.LCoord.Item2 == 11);
            Assert.IsTrue(r1.RCoord.Item1 == 10);
            Assert.IsTrue(r1.RCoord.Item2 == 10);
            Assert.IsTrue(r1.IsValid == true);
        }

        [TestMethod]
        public void Test_Rectange_resize_ValidToInvalid()
        {
            var p1 = new Tuple<int, int>(2, 10);
            var p2 = new Tuple<int, int>(10, 11);
            Rectangle r1 = new Rectangle(p1, p2);
            Assert.IsTrue(r1.IsValid == true);
            p1 = new Tuple<int, int>(1, 1);
            p2 = new Tuple<int, int>(1, 1);
            r1.Resize(p1, p2);
            Assert.IsTrue(r1.LCoord.Item1 == 1);
            Assert.IsTrue(r1.LCoord.Item2 == 1);
            Assert.IsTrue(r1.RCoord.Item1 == 1);
            Assert.IsTrue(r1.RCoord.Item2 == 1);
            Assert.IsTrue(r1.IsValid == false);
        }

        [TestMethod]
        public void Test_Rectange_MarkInvalid()
        {
            var p1 = new Tuple<int, int>(2, 10);
            var p2 = new Tuple<int, int>(10, 11);
            Rectangle r1 = new Rectangle(p1, p2);
            Assert.IsTrue(r1.IsValid == true);
            r1.MarkInvalid();
            Assert.IsTrue(r1.IsValid == false);
            Assert.IsNull(r1.LCoord);
            Assert.IsNull(r1.RCoord);
        }
    }
}
