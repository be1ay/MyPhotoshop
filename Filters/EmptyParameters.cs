using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPhotoshop
{
    internal class EmptyParameters : IParameters
    {
        public ParameterInfo[] GetDesсription()
        {
            return new ParameterInfo[0];
        }

        public void SetValues(double[] values)
        {
        }
    }
}
