using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPhotoshop
{
    public abstract class ParametrizedFilter:IFilter
    {
        IParameters parameters;

        protected ParametrizedFilter(IParameters parameters)
        {
            this.parameters = parameters;
        }

        public ParameterInfo[] GetParameters()
        {
            return parameters.GetDesсription();
        }

        public Photo Process(Photo original, double[] values)
        {
            this.parameters.SetValues(values);
            return Process(original,parameters);
        }
        public abstract Photo Process(Photo original, IParameters parameters);
    }
}
