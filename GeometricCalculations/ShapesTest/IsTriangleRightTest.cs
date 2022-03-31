using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ShapesTest.Shapes;
using GeometricCalculations.Shapes;

namespace ShapesTest {
	[TestClass]
	public class IsTriangleRightTest {
		[TestMethod]
		public void Triangle_4_5_3_Is_Right() {
			var triangle = new Triangle(4, 5, 3);
			Assert.IsTrue(triangle.IsRight());
		}

		[TestMethod]
		public void Triangle_20_15_25_Is_Rigth() {
			var triangle = new Triangle(20, 15, 25);
			Assert.IsTrue(triangle.IsRight());
		}

		[TestMethod]
		public void Triangle_2_2_2_Is_Not_Rigth() {
			var triangle = new Triangle(2, 2, 2);
			Assert.IsFalse(triangle.IsRight());
		}

		[TestMethod]
		public void Triangle_9_1_8_Is_Not_Rigth() {
			var triangle = new Triangle(9, 1, 8);
			Assert.IsFalse(triangle.IsRight());
		}
	}
}
