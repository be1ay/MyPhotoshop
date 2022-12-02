using System;

namespace MyPhotoshop
{
	public interface IParameters
	{
  	    ParameterInfo[] GetDesñription();
        void SetValues(double[] values);
    }
}

