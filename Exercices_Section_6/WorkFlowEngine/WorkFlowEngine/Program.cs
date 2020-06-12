using System;

namespace WorkFlowEngine
{

    class Program
    {
        static void Main(string[] args)
        {
            var workFlowEngine = new WorkFlowEngine();
            workFlowEngine.Add(new ReadFile());
            workFlowEngine.Add(new MoveObject());
            workFlowEngine.Run();
        }
    }
}
