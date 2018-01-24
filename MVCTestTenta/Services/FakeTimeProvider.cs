using MVCTestTenta.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCTestTenta.Services
{
    public class FakeTimeProvider : ITimeProvider
    {
        private DateTime _now = DateTime.Now; 
        public DateTime Now
        {
            get => _now;
            set => _now = value;
        }
    }
}
