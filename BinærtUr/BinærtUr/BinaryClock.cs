using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BinærtUr
{
    class BinaryClock
    {
        private LedBit[] hour10 = { new LedBit(), new LedBit() };

        public LedBit[] Hour10
        {
            get { return hour10; }
        }

        private LedBit[] hour1 = { new LedBit(), new LedBit(), new LedBit(), new LedBit() };

        public LedBit[] Hour1
        {
            get { return hour1; }
        }

        private LedBit[] minute10 = { new LedBit(), new LedBit(), new LedBit() };

        public LedBit[] Minute10
        {
            get { return minute10; }
        }

        private LedBit[] minute1 = { new LedBit(), new LedBit(), new LedBit(), new LedBit() };

        public LedBit[] Minute1
        {
            get { return minute1; }
        }

        private LedBit[] second10 = { new LedBit(), new LedBit(), new LedBit() };

        public LedBit[] Second10
        {
            get { return second10; }
        }

        private LedBit[] second1 = { new LedBit(), new LedBit(), new LedBit(), new LedBit() };

        public LedBit[] Second1
        {
            get { return second1; }
        }

        public async void ClockRun()
        {
            string[] binaryTimes = FillBinaries();
            Hour10[0].Bit = binaryTimes[0].Substring(3, 1) == "1";
            Hour10[1].Bit = binaryTimes[0].Substring(2, 1) == "1";
            Hour1[0].Bit = binaryTimes[1].Substring(3, 1) == "1";
            Hour1[1].Bit = binaryTimes[1].Substring(2, 1) == "1";
            Hour1[2].Bit = binaryTimes[1].Substring(1, 1) == "1";
            Hour1[3].Bit = binaryTimes[1].Substring(0, 1) == "1";
            Minute10[0].Bit = binaryTimes[2].Substring(3, 1) == "1";
            Minute10[1].Bit = binaryTimes[2].Substring(2, 1) == "1";
            Minute10[2].Bit = binaryTimes[2].Substring(1, 1) == "1";
            Minute1[0].Bit = binaryTimes[3].Substring(3, 1) == "1";
            Minute1[1].Bit = binaryTimes[3].Substring(2, 1) == "1";
            Minute1[2].Bit = binaryTimes[3].Substring(1, 1) == "1";
            Minute1[3].Bit = binaryTimes[3].Substring(0, 1) == "1";
            Second10[0].Bit = binaryTimes[4].Substring(3, 1) == "1";
            Second10[1].Bit = binaryTimes[4].Substring(2, 1) == "1";
            Second10[2].Bit = binaryTimes[4].Substring(1, 1) == "1";
            Second1[0].Bit = binaryTimes[5].Substring(3, 1) == "1";
            Second1[1].Bit = binaryTimes[5].Substring(2, 1) == "1";
            Second1[2].Bit = binaryTimes[5].Substring(1, 1) == "1";
            Second1[3].Bit = binaryTimes[5].Substring(0, 1) == "1";
                await PutTaskDelay();
            }

        private string[] FillBinaries()
        {
            string[] binaryTimes = new string[6];
            binaryTimes[0] = ConvertTimeToBinary(DateTime.Now.Hour / 10);
            binaryTimes[1] = ConvertTimeToBinary(DateTime.Now.Hour % 10);
            binaryTimes[2] = ConvertTimeToBinary(DateTime.Now.Minute / 10);
            binaryTimes[3] = ConvertTimeToBinary(DateTime.Now.Minute % 10);
            binaryTimes[4] = ConvertTimeToBinary(DateTime.Now.Second / 10);
            binaryTimes[5] = ConvertTimeToBinary(DateTime.Now.Second % 10);

            return binaryTimes;
        }
        private string ConvertTimeToBinary(int value)
        {
            string str = "";
            str += (value / 8).ToString();
            value = value % 8;
            str += (value / 4).ToString();
            value = value % 4;
            str += (value / 2).ToString();
            value = value % 2;
            str += (value / 1).ToString();

            return str;
        }

        private async Task PutTaskDelay()
        {
            await Task.Delay(500);
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

