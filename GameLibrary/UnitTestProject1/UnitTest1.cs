using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameLibrary;
using GameLibrary.Data;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            
            Logic logic = new Logic();
            var id = 1;
            var name = "game";
            var genre = "Action";
            var releaseDate = "28.5.2020";
            decimal price = 10;
            var library = new Library { Id = id, Name = name, Genre = genre, ReleaseDate = releaseDate, Price = price };

            //Act
            Library result = logic.Get(library.Id);
            //Assert
            Assert.AreSame(library, result);
        }
    }
}
