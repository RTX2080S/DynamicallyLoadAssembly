using PluginInterface;
using System;

namespace Plugin_Calculation
{
    public class Calculation : IPlugin
    {
        private double _LastResult;
        public void ExceptionTest(string input)
        {
            throw new NotImplementedException();
        }

        public double Execute(double value1, double value2)
        {
            if (OnExecute != null) OnExecute(this, null);
            return _LastResult = value1 - value2;
        }

        public double GetLastResult
        {
            get { return _LastResult; }
        }

        public string Name
        {
            get { return "Calculation"; }
        }

        public string Description
        {
            get { return "Calculation: Subtraction"; }
        }

        public event EventHandler OnExecute;
    }
}
