using System;
using System.Collections.Generic;
using System.Text;

namespace StopWatch
{
    class StopWatch
    {

        public TimeSpan CurrentTime { get; set; }
        public bool IsCounting { get; set; }
        private readonly TimeSpan _timeStep = TimeSpan.FromSeconds(1);
        private System.Threading.Timer timer;


        public StopWatch()
        {
            this.CurrentTime = new TimeSpan();
            IsCounting = false;
        }

        public void Start()
        {
            

            if(IsCounting == true)
                    throw new InvalidOperationException("Error");

            Console.WriteLine("Cuenta iniciada");
            timer = new System.Threading.Timer(
            e => Count(),
            null,
            TimeSpan.Zero,
            TimeSpan.FromSeconds(1));

            IsCounting = true;
        }

        public void Stop()
        {
            timer.Dispose();
            IsCounting = false;
            Console.WriteLine(CurrentTime);
        }

        private void Count()
        {
            CurrentTime = CurrentTime.Add(_timeStep);
        }

    }
}
