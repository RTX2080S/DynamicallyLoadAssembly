using PluginInterface;
using System;

namespace Plugin_Sum
{
    public class Sum : IPlugin
    {
        private double _LastResult;

        public string Name
        {
            get { return "Sum"; }
        }

        public string Description
        {
            get { return "Add 2 numbers"; }
        }

        public double GetLastResult
        {
            get { return _LastResult; }
        }

        public double Execute(double value1, double value2)
        {
            OnExecute?.Invoke(this, null);
            return _LastResult = value1 + value2;
        }

        public event EventHandler OnExecute;

        public void ExceptionTest(string input)
        {
            throw new Exception("Exception from Plugin_Sum, input = " + input);
        }
    }
}
