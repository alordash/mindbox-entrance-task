using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ShapesTest.Shapes;
using GeometricCalculations;
using GeometricCalculations.Shapes;

namespace ShapesTest.AreaTests {
	[TestClass]
	public class CircleAreaTest {
		[TestMethod]
		public void Circle_Area_Equal_To_Pi_Test() {
			var circle = new Circle(1.0);
			Assert.AreEqual(circle.CalculateArea(), Math.PI);
		}

		[TestMethod]
		public void Circle_Area_Equal_To_100Pi_Test() {
			var circle = new Circle(10.0);
			Assert.AreEqual(circle.CalculateArea(), Math.PI * 100.0);
		}

		[TestMethod]
		public void Circle_Area_Equal_To_1_Test() {
			var circle = new Circle(1.0 / Math.Sqrt(Math.PI));
			Assert.AreEqual(circle.CalculateArea(), 1.0, 0.001);
		}
	}
}
