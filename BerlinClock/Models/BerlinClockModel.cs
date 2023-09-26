using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.Models
{
    public class BerlinClockModel
    {
        string _currentClock;
        //string _currentClock = "08:05:00";
        private string[] _timeFormats;
        public BerlinClockModel()
        {

        }
        public ObservableCollection<string> GetColorCodes()
        {
            _currentClock = DateTime.Now.ToString("HH:mm:ss");
            this._timeFormats = _currentClock.Split(':');
            var returnColorCodes = new ObservableCollection<string>();
            var firstRowHoursCode = FirstRowHours(Convert.ToInt32(this._timeFormats[0]));
            returnColorCodes.Add(firstRowHoursCode);
            var secondRowHoursCode = SecondRowHours(Convert.ToInt32(this._timeFormats[0]));
            returnColorCodes.Add(secondRowHoursCode);
            var thirdMinutesRowCode = ThirdMinutesRow(Convert.ToInt32(this._timeFormats[1]));
            returnColorCodes.Add(thirdMinutesRowCode);
            var fourthMinutesRowCode= FourthMinutesRow(Convert.ToInt32(this._timeFormats[1]));
            returnColorCodes.Add(fourthMinutesRowCode);
            var secondsRowCode = SecondsLight(Convert.ToInt32(this._timeFormats[2]));
            returnColorCodes.Add(secondsRowCode);

            returnColorCodes.Add(_currentClock);
            return returnColorCodes;   
        }

        public string SecondsLight(int seconds)
        {
            if (seconds % 2 == 0)
                return "O";
            else
                return "Y";
        }
        public string FirstRowHours(int hours)
        {
            if (hours / 5 == 0)
                return "OOOO";
            else if (hours / 5 == 1)
                return "ROOO";
            else if (hours / 5 == 2)
                return "RROO";
            else if (hours / 5 == 3)
                return "RRRO";
            else if (hours / 5 == 4)
                return "RRRR";
            else
                return string.Empty;
        }
        public string SecondRowHours(int hours)
        {
            if (hours % 5 == 0)
                return "OOOO";
            else if (hours % 5 == 1)
                return "ROOO";
            else if (hours % 5 == 2)
                return "RROO";
            else if (hours % 5 == 3)
                return "RRRO";
            else if (hours % 5 == 4)
                return "RRRR";
            else
                return string.Empty;
        }

        public string ThirdMinutesRow(int minutes)
        {
            //Check
            var returnString = "";
            var signal = minutes / 5;
            for (int i = 1; i <= signal; i++)
            {
                if (i%3 == 0)
                    returnString = returnString + "R";
                else
                    returnString = returnString + "Y";
            }
            var noLights = 11 - signal;
            for (int i = 0; i < noLights; i++)
            {
                returnString = returnString + "O";
            }
            return returnString;
        }
        public string FourthMinutesRow(int minutes)
        {
            if (minutes % 5 == 0)
                return "OOOO";
            else if (minutes % 5 == 1)
                return "YOOO";
            else if (minutes % 5 == 2)
                return "YYOO";
            else if (minutes % 5 == 3)
                return "YYYO";
            else if (minutes % 5 == 4)
                return "YYYY";
            else
                return string.Empty;
        }
    }
}
