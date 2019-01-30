using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Plutorover;



namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DirectionTest()
         {
            //Arrange
            Vector r = new Vector(0, 0);
            Vector north = new Vector(0, 100);



           double expected = 0.00;

            //Act
            double actual = Plutorover.Vector.AngleBetween(r, north);
            //Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]

        public void ForwardTest()
        {
            //Arrange
            Vector r = new Vector(0, 0);

            Vector expected = new Vector(0, 1);

            //Act
            Vector actual = Plutorover.Program.Forward(r);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void BackwardTest()
        {
            //Arrange
            
            Vector r = new Vector(0, 0);

            Vector expected = new Vector(0, -1);

            //Act
            Vector actual = Plutorover.Program.Backward(r);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void Right()
        {
            //Arrange
            Vector r = new Vector(0, 1);

            Vector expected =  new Vector(0, 1);

            //Act
            Vector actual = Plutorover.Program.Right(r);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void Left()
        {
            //Arrange
            Vector r = new Vector(0,1);

            Vector expected = new Vector(0,1);

            //Act
            Vector actual = Plutorover.Program.Left(r);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void NoCollision()
        {
            //Arrange
            Vector r = new Vector(5, 5);
           

            bool expected = false;

            //Act
           bool actual = Plutorover.Program.Collision(r);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void YesCollision()
        {
            //Arrange
            Vector r = new Vector(2, 2);
            

            bool expected = true;

            //Act
            bool actual = Plutorover.Program.Collision(r);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
