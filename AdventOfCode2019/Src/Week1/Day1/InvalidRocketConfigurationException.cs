using System;
using System.Collections.Generic;
using System.Text;

namespace Week1.Day1
{
    public class InvalidRocketConfigurationException: Exception
    {
        public InvalidRocketConfigurationException(string message)
            :base(message)
        {
        }

        public InvalidRocketConfigurationException(string message, Exception ex)
    : base(message, ex)
        {
        }

       
    }
}
