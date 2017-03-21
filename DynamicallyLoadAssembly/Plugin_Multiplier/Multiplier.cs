using PluginInterface;
using System;

namespace Plugin_Multiplier
{
    public class Multiplier : IPlugin
    {
        double _LastResult;
        public string Name
        {
            get { return "Multiplier"; }
        }

        public string Description
        {
            get { return "Multiply 2 numbers."; }
        }

        public double GetLastResult
        {
            get { return _LastResult; }
        }

        public double Execute(double value1, double value2)
        {
            OnExecute?.Invoke(this, null);
            return _LastResult = value1 * value2;
        }

        public event EventHandler OnExecute;

        public void ExceptionTest(string input)
        {
            throw new CustomException("Custom Exception, input = " + input);
        }
    }

    public class CustomException : Exception
    {
        public CustomException() : base("Custom Exception.") { }
        public CustomException(string message) : base(message) { }
        public CustomException(string message, Exception innerException) : base(message, innerException) { }
    }
}
