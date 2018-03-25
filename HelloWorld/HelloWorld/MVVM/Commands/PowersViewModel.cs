using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using HelloWorld.Annotations;
using Xamarin.Forms;

namespace HelloWorld.MVVM.Commands
{
    public class PowersViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public double BaseValue { private set; get; }
        private double _exponent, _power;

        public PowersViewModel(double baseValue)
        {
            this.BaseValue = baseValue;
            this._exponent = 0;
            this.IncreaseExponentCommand = new Command(this.ExecuteIncreaseExponent);
            this.DecreaseExponentCommand = new Command(this.ExecuteDescreaseExponent);
        }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void ExecuteIncreaseExponent()
        {
            Exponent += 1;
        }

        private void ExecuteDescreaseExponent()
        {
            Exponent -= 1;
        }

        public double Exponent
        {
            private set
            {
                if (_exponent != value)
                {
                    _exponent = value;
                    OnPropertyChanged();

                    Power = Math.Pow(BaseValue, _exponent);
                }
            }
            get => _exponent;
        }

        public double Power
        {
            private set
            {
                if (_power != value)
                {
                    _power = value;
                    OnPropertyChanged();
                }
            }
            get => _power;
        }

        public ICommand IncreaseExponentCommand { private set; get; }
        public ICommand DecreaseExponentCommand { private set; get; }
    }
}
