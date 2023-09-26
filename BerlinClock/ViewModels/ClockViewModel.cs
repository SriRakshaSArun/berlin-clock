using BerlinClock.Commands;
using BerlinClock.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Input;

namespace BerlinClock.ViewModels
{
    public class ClockViewModel: ViewModelBase
    {
        private BerlinClockModel _berlinClockModel;
        private ObservableCollection<string> _colorCodes;
        private Timer aTimer;
        public DisplayTimeCommand ShowTimeCommand { get; set; }


        private string _firstRowHoursCode;
        public string FirstRowHoursCode
        {
            get
            {
                return _firstRowHoursCode;
            }
            set
            {
                _firstRowHoursCode = value;
                OnPropertyChanged(nameof(FirstRowHoursCode));
            }
        }

        private string _secondRowHoursCode;
        public string SecondRowHoursCode
        {
            get
            {
                return _secondRowHoursCode;
            }
            set
            {
                _secondRowHoursCode = value;
                OnPropertyChanged(nameof(SecondRowHoursCode));
            }
        }
        private string _thirdRowMinutesCode;
        public string ThirdRowMinutesCode
        {
            get
            {
                return _thirdRowMinutesCode;
            }
            set
            {
                _thirdRowMinutesCode = value;
                OnPropertyChanged(nameof(ThirdRowMinutesCode));
            }
        }
        private string _fourthRowMinutesCode;
        public string FourthRowMinutesCode
        {
            get
            {
                return _fourthRowMinutesCode;
            }
            set
            {
                _fourthRowMinutesCode = value;
                OnPropertyChanged(nameof(FourthRowMinutesCode));
            }
        }

        private string _currentTime;
        public string CurrentTime
        {
            get
            {
                return _currentTime;
            }
            set
            {
                _currentTime = value;
                OnPropertyChanged(nameof(CurrentTime));
            }
        }
        private string _secondsCode;
        public string SecondsCode
        {
            get
            {
                return _secondsCode;
            }
            set
            {
                _secondsCode = value;
                OnPropertyChanged(nameof(SecondsCode));
            }
        }
        #region Rectangle Row 1 Properties
        private string _row1rec1;
        public string Row1Rec1
        {
            get
            {
                return _row1rec1;
            }
            set
            {
                _row1rec1 = value;
                OnPropertyChanged(nameof(Row1Rec1));
            }
        }
        private string _row1rec2;
        public string Row1Rec2
        {
            get
            {
                return _row1rec2;
            }
            set
            {
                _row1rec2 = value;
                OnPropertyChanged(nameof(Row1Rec2));
            }
        }
        private string _row1rec3;
        public string Row1Rec3
        {
            get
            {
                return _row1rec3;
            }
            set
            {
                _row1rec3 = value;
                OnPropertyChanged(nameof(Row1Rec3));
            }
        }
        private string _row1rec4;
        public string Row1Rec4
        {
            get
            {
                return _row1rec4;
            }
            set
            {
                _row1rec4 = value;
                OnPropertyChanged(nameof(Row1Rec4));
            }
        }
        #endregion
        #region Rectangle Row 2 Properties
        private string _row2rec1;
        public string Row2Rec1
        {
            get
            {
                return _row2rec1;
            }
            set
            {
                _row2rec1 = value;
                OnPropertyChanged(nameof(Row2Rec1));
            }
        }
        private string _row2rec2;
        public string Row2Rec2
        {
            get
            {
                return _row2rec2;
            }
            set
            {
                _row2rec2 = value;
                OnPropertyChanged(nameof(Row2Rec2));
            }
        }
        private string _row2rec3;
        public string Row2Rec3
        {
            get
            {
                return _row2rec3;
            }
            set
            {
                _row2rec3 = value;
                OnPropertyChanged(nameof(Row2Rec3));
            }
        }
        private string _row2rec4;
        public string Row2Rec4
        {
            get
            {
                return _row2rec4;
            }
            set
            {
                _row2rec4 = value;
                OnPropertyChanged(nameof(Row2Rec4));
            }
        }
        #endregion
        #region Rectangle Row 3 Properties
        private string _row3rec1;
        public string Row3Rec1
        {
            get
            {
                return _row3rec1;
            }
            set
            {
                _row3rec1 = value;
                OnPropertyChanged(nameof(Row3Rec1));
            }
        }
        private string _row3rec2;
        public string Row3Rec2
        {
            get
            {
                return _row3rec2;
            }
            set
            {
                _row3rec2 = value;
                OnPropertyChanged(nameof(Row3Rec2));
            }
        }
        private string _row3rec3;
        public string Row3Rec3
        {
            get
            {
                return _row3rec3;
            }
            set
            {
                _row3rec3 = value;
                OnPropertyChanged(nameof(Row3Rec3));
            }
        }
        private string _row3rec4;
        public string Row3Rec4
        {
            get
            {
                return _row3rec4;
            }
            set
            {
                _row3rec4 = value;
                OnPropertyChanged(nameof(Row3Rec4));
            }
        }
        private string _row3rec5;
        public string Row3Rec5
        {
            get
            {
                return _row3rec5;
            }
            set
            {
                _row3rec5 = value;
                OnPropertyChanged(nameof(Row3Rec5));
            }
        }
        private string _row3rec6;
        public string Row3Rec6
        {
            get
            {
                return _row3rec6;
            }
            set
            {
                _row3rec6 = value;
                OnPropertyChanged(nameof(Row3Rec6));
            }
        }
        private string _row3rec7;
        public string Row3Rec7
        {
            get
            {
                return _row3rec7;
            }
            set
            {
                _row3rec7 = value;
                OnPropertyChanged(nameof(Row3Rec7));
            }
        }
        private string _row3rec8;
        public string Row3Rec8
        {
            get
            {
                return _row3rec8;
            }
            set
            {
                _row3rec8 = value;
                OnPropertyChanged(nameof(Row3Rec8));
            }
        }
        private string _row3rec9;
        public string Row3Rec9
        {
            get
            {
                return _row3rec9;
            }
            set
            {
                _row3rec9 = value;
                OnPropertyChanged(nameof(Row3Rec9));
            }
        }
        private string _row3rec10;
        public string Row3Rec10
        {
            get
            {
                return _row3rec10;
            }
            set
            {
                _row3rec10 = value;
                OnPropertyChanged(nameof(Row3Rec10));
            }
        }
        private string _row3rec11;
        public string Row3Rec11
        {
            get
            {
                return _row3rec11;
            }
            set
            {
                _row3rec11 = value;
                OnPropertyChanged(nameof(Row3Rec11));
            }
        }
        #endregion
        #region Rectangle Row 4 Properties
        private string _row4rec1;
        public string Row4Rec1
        {
            get
            {
                return _row4rec1;
            }
            set
            {
                _row4rec1 = value;
                OnPropertyChanged(nameof(Row4Rec1));
            }
        }
        private string _row4rec2;
        public string Row4Rec2
        {
            get
            {
                return _row4rec2;
            }
            set
            {
                _row4rec2 = value;
                OnPropertyChanged(nameof(Row4Rec2));
            }
        }
        private string _row4rec3;
        public string Row4Rec3
        {
            get
            {
                return _row4rec3;
            }
            set
            {
                _row4rec3 = value;
                OnPropertyChanged(nameof(Row4Rec3));
            }
        }
        private string _row4rec4;
        public string Row4Rec4
        {
            get
            {
                return _row4rec4;
            }
            set
            {
                _row4rec4 = value;
                OnPropertyChanged(nameof(Row4Rec4));
            }
        }
        #endregion

        public ClockViewModel()
        {
            _berlinClockModel = new BerlinClockModel();
            ShowTimeCommand = new DisplayTimeCommand(SetTimerClock);
        }
        private void GetLatestCodes()
        {
            this._colorCodes = _berlinClockModel.GetColorCodes();
            CurrentTime = this._colorCodes[5];
            AssignColorCodes(this._colorCodes);
        }
        private void AssignColorCodes(ObservableCollection<string> colorCodes)
        {
            var firstRowColorCodes = colorCodes[0];
            AssignFirstRowColorCodes(firstRowColorCodes);
            var secondRowColorCodes = colorCodes[1];
            AssignSecondRowColorCodes(secondRowColorCodes);
            var thirdRowColorCodes = colorCodes[2];
            AssignThirdRowColorCodes(thirdRowColorCodes);
            var fourthRowColorCodes = colorCodes[3];
            AssignFourthRowColorCodes(fourthRowColorCodes);
            var secondsColorCodes = colorCodes[4];
            AssignSecondsColorCodes(secondsColorCodes);
        }
        public void AssignFirstRowColorCodes(string firstRowColorCodes)
        {
            var firstRowCodes = firstRowColorCodes.ToCharArray();
            Row1Rec1 = firstRowCodes[0].ToString();
            Row1Rec2 = firstRowCodes[1].ToString();
            Row1Rec3 = firstRowCodes[2].ToString();
            Row1Rec4 = firstRowCodes[3].ToString();
        }
        public void AssignSecondRowColorCodes(string secondRowCodes)
        {
            var secondRowColorCodes = secondRowCodes.ToCharArray();
            Row2Rec1 = secondRowColorCodes[0].ToString();
            Row2Rec2 = secondRowColorCodes[1].ToString();
            Row2Rec3 = secondRowColorCodes[2].ToString();
            Row2Rec4 = secondRowColorCodes[3].ToString();
        }
        public void AssignThirdRowColorCodes(string thirdRowCodes)
        {
            var thirdRowColorCodes = thirdRowCodes.ToCharArray();
            Row3Rec1 = thirdRowColorCodes[0].ToString();
            Row3Rec2 = thirdRowColorCodes[1].ToString();
            Row3Rec3 = thirdRowColorCodes[2].ToString();
            Row3Rec4 = thirdRowColorCodes[3].ToString();
            Row3Rec5 = thirdRowColorCodes[4].ToString();
            Row3Rec6 = thirdRowColorCodes[5].ToString();
            Row3Rec7 = thirdRowColorCodes[6].ToString();
            Row3Rec8 = thirdRowColorCodes[7].ToString();
            Row3Rec9 = thirdRowColorCodes[8].ToString();
            Row3Rec10 = thirdRowColorCodes[9].ToString();
            Row3Rec11 = thirdRowColorCodes[10].ToString();
        }
        public void AssignFourthRowColorCodes(string fourthRowColorCodes)
        {
            var fourthRowCodes = fourthRowColorCodes.ToCharArray();
            Row4Rec1 = fourthRowCodes[0].ToString();
            Row4Rec2 = fourthRowCodes[1].ToString();
            Row4Rec3 = fourthRowCodes[2].ToString();
            Row4Rec4 = fourthRowCodes[3].ToString();
        }
        public void AssignSecondsColorCodes(string secondsColorCodes)
        {
            var secondsCodes = secondsColorCodes.ToCharArray();
            SecondsCode = secondsCodes[0].ToString();
        }
        private void SetTimerClock()
        {
            // Create a timer with a second interval.
            aTimer = new Timer(1000);
            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += OnEverySecondEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }
        private void OnEverySecondEvent(Object source, ElapsedEventArgs e)
        {
            GetLatestCodes();
        }

    }
}
