using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Demo.ViewModels
{

    public class StepsViewModel : INotifyPropertyChanged
    {
        private int _currentStep = 1;

        public string Step1Color => _currentStep >= 1 ? "Black" : "LightGray";
        public string Step1LineColor => _currentStep > 1 ? "Black" : "LightGray";

        public string Step2Color => _currentStep >= 2 ? "Black" : "LightGray";
        public string Step2LineColor => _currentStep > 2 ? "Black" : "LightGray";

        public string Step3Color => _currentStep >= 3 ? "Black" : "LightGray";
        public string Step3LineColor => _currentStep > 3 ? "Black" : "LightGray";

        public string Step4Color => _currentStep >= 4 ? "Black" : "LightGray";

        public ICommand NextStepCommand { get; }

        public event PropertyChangedEventHandler PropertyChanged;

        public StepsViewModel()
        {
            NextStepCommand = new Command(OnNextStep);
        }

        private void OnNextStep()
        {
            if (_currentStep < 4)
            {
                _currentStep++;
                OnPropertyChanged(nameof(Step1Color));
                OnPropertyChanged(nameof(Step1LineColor));
                OnPropertyChanged(nameof(Step2Color));
                OnPropertyChanged(nameof(Step2LineColor));
                OnPropertyChanged(nameof(Step3Color));
                OnPropertyChanged(nameof(Step3LineColor));
                OnPropertyChanged(nameof(Step4Color));
            }
        }

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}

