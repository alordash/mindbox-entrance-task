using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricCalculations.Shapes {
	public interface ICircle: IShape {
		public double Radius { get; set; }
	}
}
