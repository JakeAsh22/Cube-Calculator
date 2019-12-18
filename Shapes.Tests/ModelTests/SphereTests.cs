using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Models;

namespace Shapes.Tests
{
  [TestClass]
  public class SphereTests
  {

    [TestMethod]
    public void Sphere_GetVolume_VolumeOf()
    {
      // Arrange
      Circle circle1 = new Circle(2);
      Sphere sphere1 = new Sphere(circle1);
      // Act
      double result = sphere1.GetVolume();
      // Assert
      Assert.AreEqual(result, 33.510321638291124);
    }

    [TestMethod]
    public void Sphere_GetSurfaceArea_SurfaceAreaOfSphere()
    {
      // Arrange
      Circle circleTest = new Circle(2);
      Sphere newSphere = new Sphere(circleTest);
      // Act
      double result = newSphere.GetSurfaceArea();
      // Assert
      Assert.AreEqual(result, 50.26548245743669);
    }

  }  
}