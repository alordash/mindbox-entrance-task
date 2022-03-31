using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ShapesTest.Shapes;
using GeometricCalculations;
using GeometricCalculations.Shapes;

namespace ShapesTest.AreaTests {
	[TestClass]
	public class TriangleAreaTest {
		[TestMethod]
		public void TriangleAreaTest1() {
			var triangle = new Triangle(1.0, 1.0, 1.0);
			Assert.AreEqual(triangle.CalculateArea(), Math.Sqrt(3.0) / 4.0, 0.001);
		}

		[TestMethod]
		public void TriangleAreaTest2() {
			var triangle = new Triangle(3.0, 4.0, 5.0);
			Assert.AreEqual(triangle.CalculateArea(), 6.0);
		}

		[TestMethod]
		public void TriangleAreaTest3() {
			var triangle = new Triangle(10.0, 10.0, 5.0);
			Assert.AreEqual(triangle.CalculateArea(), 24.206145913796355, 0.001);
		}
	}
}
