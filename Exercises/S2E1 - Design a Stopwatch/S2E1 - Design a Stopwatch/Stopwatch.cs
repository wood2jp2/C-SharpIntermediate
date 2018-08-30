using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2E1___Design_a_Stopwatch
{
    public class Stopwatch
    {
        private bool _isRunning { get; set; }
        private DateTime StartTime { get; set; }
        private DateTime EndTime { get; set; }

        public void Start()
        {
            if (_isRunning)
            {
                throw new InvalidOperationException();
            }

            _isRunning = true;
            StartTime = DateTime.Now;
        }

        public TimeSpan Stop()
        {

            if (!_isRunning)
            {
                throw new InvalidOperationException();
            }

            EndTime = DateTime.Now;

            var duration = EndTime - StartTime;

            return duration;
        }
    }
}
