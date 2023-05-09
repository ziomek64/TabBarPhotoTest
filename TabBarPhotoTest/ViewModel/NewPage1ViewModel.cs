using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TabBarPhotoTest.ViewModel
{
    class NewPage1ViewModel : INotifyPropertyChanged
    {


        public NewPage1ViewModel()
        {
            RefreshCommand = new Command(async () => await Refresh());
            
        }

        public event PropertyChangedEventHandler PropertyChanged;
        CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

        double fontSize = 14;

        void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public ICommand RefreshCommand { get; }
        public bool isBusy = false;

        public bool IsBusy
        {
            get => isBusy;
            set
            {
                if (value == isBusy)
                    return;

                isBusy = value;
                OnPropertyChanged();
            }
        }



        public string _avatar;

        public string Avatar
        {
            get => _avatar;
            set
            {
                if (_avatar == value)
                    return;

                _avatar = value;
                OnPropertyChanged();
            }
        }

        public string _banner;

        public string Banner
        {
            get => _banner;
            set
            {
                if (_banner == value)
                    return;

                _banner = value;
                OnPropertyChanged();
            }
        }

        async Task Refresh()
        {
            Avatar = "https://s4.anilist.co/file/anilistcdn/user/avatar/large/b5559348-jekjXFK3LX49.jpg";
            Banner = "https://s4.anilist.co/file/anilistcdn/user/banner/b5559348-kU5EdNn7M6qW.jpg";

            IsBusy = false;
        }
    }
}
