using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricCalculations.Shapes {
	public interface ITriangle: IShape {
		public double SideA { get; set; }
		public double SideB { get; set; }
		public double SideC { get; set; }
	}
}
