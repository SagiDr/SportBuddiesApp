using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.Maui.Controls;

using SportBuddiesApp.Models;
using SportBuddiesApp.Services;

namespace SportBuddiesApp.ViewModels
{
    public class CreateGameViewModel
    {
        private string _gameType;
        private DateTime _gameDate;
        private TimeSpan _gameTime;
        private string _location;
        private string _gameMode;
        private string _gameVisibility;

        public CreateGameViewModel()
        {
            GameTypes = new ObservableCollection<string> { "Basketball", "Soccer", "Volleyball" };
            GameModes = new ObservableCollection<string> { "Casual", "Competitive" };
            GameVisibilities = new ObservableCollection<string> { "Public", "Private" };
            GameDate = DateTime.Now;
            GameTime = TimeSpan.Zero;
            _gameType = string.Empty;
            _location = string.Empty;
            _gameMode = string.Empty;
            _gameVisibility = string.Empty;
            CreateGameCommand = new Command(OnCreateGame);
            GetLocationCommand = new Command(async () => await GetLocationAsync());
        }

        public ObservableCollection<string> GameTypes { get; }
        public ObservableCollection<string> GameModes { get; }
        public ObservableCollection<string> GameVisibilities { get; }

        public string GameType
        {
            get => _gameType;
            set
            {
                _gameType = value;
                OnPropertyChanged();
            }
        }

        public DateTime GameDate
        {
            get => _gameDate;
            set
            {
                _gameDate = value;
                OnPropertyChanged();
            }
        }

        public TimeSpan GameTime
        {
            get => _gameTime;
            set
            {
                _gameTime = value;
                OnPropertyChanged();
            }
        }

        public string Location
        {
            get => _location;
            set
            {
                _location = value;
                OnPropertyChanged();
            }
        }

        public string GameMode
        {
            get => _gameMode;
            set
            {
                _gameMode = value;
                OnPropertyChanged();
            }
        }

        public string GameVisibility
        {
            get => _gameVisibility;
            set
            {
                _gameVisibility = value;
                OnPropertyChanged();
            }
        }

        public ICommand CreateGameCommand { get; }
        public ICommand GetLocationCommand { get; }

        private async Task GetLocationAsync()
        {
            try
            {
                var location = await Geolocation.GetLastKnownLocationAsync();

                if (location != null)
                {
                    Location = $"Latitude: {location.Latitude}, Longitude: {location.Longitude}";
                }
                else
                {
                    Location = "Unable to get location";
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Location = $"Error: {ex.Message}";
            }
        }

        private void OnCreateGame()
        {
            // TODO: Add logic to create the game with the provided details

            if (Application.Current?.MainPage != null)
            {
                Application.Current.MainPage.DisplayAlert("Game Created", "Your game has been created successfully!", "OK");
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
