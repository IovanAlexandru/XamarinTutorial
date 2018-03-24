using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using HelloWorld.Annotations;
using Xamarin.Forms;

namespace HelloWorld.MVVM
{
    public class DateTimeViewModel : INotifyPropertyChanged
    {
        private DateTime dateTime = DateTime.Now;
        public event PropertyChangedEventHandler PropertyChanged;

        public DateTimeViewModel()
        {
            Device.StartTimer(TimeSpan.FromMilliseconds(15), OnTimerTick);
        }

        private bool OnTimerTick()
        {
            DateTime = DateTime.Now;
            return true;
        }

        public DateTime DateTime
        {
            private set
            {
                if (dateTime != value)
                {
                    this.dateTime = value;
                    //Fire event
                    OnPropertyChanged();
                }
            }
            get => dateTime;
        }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
