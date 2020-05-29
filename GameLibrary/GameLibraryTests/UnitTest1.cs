using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameLibrary;
namespace GameLibraryTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            Presentation logic = new Presentation();
            //Act
            var item =logic.GetAll();
            var result = $"Id: {item.Id} Name: {item.Name} Release Date: {item.ReleaseDate} Price: {item.Price}$ Genre: {item.Genre}";
            //Assert
        }
    }
}
