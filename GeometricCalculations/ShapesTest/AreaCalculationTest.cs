using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using GeometricCalculations;
using GeometricCalculations.Shapes;

namespace ShapesTest {
	[TestClass]
	public class CircleAreaTest {
		[TestMethod]
		public void CircleAreaTest1() {
			var circle = new Circle(1);
			Assert.AreEqual(circle.CalculateArea(), Math.PI);
		}

		[TestMethod]
		public void CircleAreaTest2() {
			var circle = new Circle(10);
			Assert.AreEqual(circle.CalculateArea(), Math.PI * 100.0);
		}

		[TestMethod]
		public void CircleAreaTest3() {
			var circle = new Circle(1.0 / Math.Sqrt(Math.PI));
			Assert.AreEqual(circle.CalculateArea(), 1.0, 0.001);
		}
	}

	[TestClass]
	public class TriangleAreaTest {
		[TestMethod]
		public void TriangleAreaTest1() {
			var triangle = new Triangle(1, 1, 1);
			Assert.AreEqual(triangle.CalculateArea(), Math.Sqrt(3.0) / 4.0, 0.001);
		}

		[TestMethod]
		public void TriangleAreaTest2() {
			var triangle = new Triangle(3, 4, 5);
			Assert.AreEqual(triangle.CalculateArea(), 6);
		}

		[TestMethod]
		public void TriangleAreaTest3() {
			var triangle = new Triangle(10, 10, 5);
			Assert.AreEqual(triangle.CalculateArea(), 24.206145913796355, 0.001);
		}
	}

	[TestClass]
	public class UndefinedShapeTest {
		static double UndefinedShapeArea(Shape undefinedShape) {
			return undefinedShape.CalculateArea();
		}

		[TestMethod]
		public void CircleAsUndefinedShapeTest() {
			var circle = new Circle(2.0);
			var area = UndefinedShapeArea(circle);
			Assert.AreEqual(area, Math.PI * 4.0);
		}

		[TestMethod]
		public void TriangleAsUndefinedShapeTest() {
			var triangle = new Triangle(10.0, 8.0, 6.0);
			var area = UndefinedShapeArea(triangle);
			Assert.AreEqual(area, 24.0);
		}
	}
}
