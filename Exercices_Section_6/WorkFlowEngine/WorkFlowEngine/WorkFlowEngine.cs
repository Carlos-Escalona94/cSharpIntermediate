using System.Collections.Generic;

namespace WorkFlowEngine
{
    public partial class WorkFlowEngine
    {

        private List<IActivity> _workFlow;

        public WorkFlowEngine()
        {
            _workFlow = new List<IActivity>();
        }

        public void Add(IActivity activity)
        {
            _workFlow.Add(activity);
        }

        public void Run()
        {
            foreach (var activity in _workFlow)
            {
                activity.Run();
            }
        }
    }
}
