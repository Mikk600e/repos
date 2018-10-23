using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinærtUr
{
    class ClockViewModel
    {
        BinaryClock binaryClock = new BinaryClock();

        public LedBit[] Hour10
        {
            get { return binaryClock.Hour10; }
        }
        public LedBit[] minute10
        {
            get { return binaryClock.Minute10; }
        }
        public LedBit[] Hour1
        {
            get { return binaryClock.Hour1; }
        }

        public void Demo()
        {
            binaryClock.ClockRun();
        }
    }
}
