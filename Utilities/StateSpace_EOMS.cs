﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public class StateSpace_EOMS:EOMS
    {
        public override Matrix<double> this[double t, Matrix<double> y]
        {
            get
            {
                Matrix<double> dy = new Matrix<double>(y.Size[1], y.Size[2]);
                dy[1,1] = y[2,1];
                dy[2,1] = -1 * y[2,1] - 4 * y[1,1];

                return dy;
            }
        }
    }
}
