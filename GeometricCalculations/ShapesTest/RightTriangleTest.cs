using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ShapesTest.Shapes;
using GeometricCalculations.Shapes;

namespace ShapesTest {
	[TestClass]
	public class RightTriangleTest {
		[TestMethod]
		public void RightTriangleTest1() {
			var triangle = new Triangle(4, 5, 3);
			Assert.IsTrue(triangle.IsRight());
		}

		[TestMethod]
		public void RightTriangleTest2() {
			var triangle = new Triangle(20, 15, 25);
			Assert.IsTrue(triangle.IsRight());
		}

		[TestMethod]
		public void RightTriangleTest3() {
			var triangle = new Triangle(2, 2, 2);
			Assert.IsFalse(triangle.IsRight());
		}
	}
}
