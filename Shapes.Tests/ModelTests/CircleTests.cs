using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Models;

namespace Shapes.Tests
{
  [TestClass]
  public class CircleTests
  {

    [TestMethod]
    public void Circle_GetDiameter_DiameterOfCircle()
    {
      // Arrange
      Circle test1 = new Circle(4);
      // Act
      int result = test1.GetDiameter();
      // Assert
      Assert.AreEqual(result, 8);
    }

    [TestMethod]
    public void Circle_GetCircumference_CircumferenceOfCircle()
    {
        Circle test2 = new Circle(2);
        double result = test2.GetCircumference();
        Assert.AreEqual(result, 12.566370614359172);
    }



  }  
}