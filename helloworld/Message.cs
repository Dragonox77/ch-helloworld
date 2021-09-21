using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloworld
{
    class Message
    {
        public string HelloMessage {
            get {
                DateTime now = DateTime.Now;
                if (now.DayOfWeek != DayOfWeek.Sunday && now.DayOfWeek != DayOfWeek.Saturday)
                {
                    if (now.Hour >= this._hourMatin && now.Hour < this._hourStartAprem)
                    {
                        return "Bon matin " + Environment.UserName;
                    }
                    if (now.Hour >= this._hourStartAprem && now.Hour < this._hourSoir)
                    {
                        return "Bon après midi " + Environment.UserName;

                    }
                }
                return "Bon WeekEnd " + Environment.UserName;
            }
        }
        private int _hourMatin;
        private int _hourStartAprem;
        private int _hourSoir;


        public Message(int hourMatin = 9, int HourStartAprem = 13, int hourSoir = 18)
        {
            this._hourMatin = hourMatin;
            this._hourStartAprem = HourStartAprem;
            this._hourSoir = hourSoir;
        }
    }
}
