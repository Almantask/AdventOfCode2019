using System;

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
