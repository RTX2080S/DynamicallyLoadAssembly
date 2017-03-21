using System;

namespace PluginInterface
{
    public interface IPlugin
    {
        string Name { get; }
        string Description { get; }

        double GetLastResult { get; }
        double Execute(double value1, double value2);

        event EventHandler OnExecute;

        void ExceptionTest(string input);
    }
}
