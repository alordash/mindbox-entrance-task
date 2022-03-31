using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ShapesTest.Shapes;
using GeometricCalculations;
using GeometricCalculations.Shapes;

namespace ShapesTest.AreaTests {
	[TestClass]
	public class CircleAreaTest {
		[TestMethod]
		public void CircleAreaTest1() {
			var circle = new Circle(1.0);
			Assert.AreEqual(circle.CalculateArea(), Math.PI);
		}

		[TestMethod]
		public void CircleAreaTest2() {
			var circle = new Circle(10.0);
			Assert.AreEqual(circle.CalculateArea(), Math.PI * 100.0);
		}

		[TestMethod]
		public void CircleAreaTest3() {
			var circle = new Circle(1.0 / Math.Sqrt(Math.PI));
			Assert.AreEqual(circle.CalculateArea(), 1.0, 0.001);
		}
	}
}
