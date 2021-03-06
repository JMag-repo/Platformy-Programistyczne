
namespace platformy_NET.MWM.ViewModel
{
    /// <summary>
    /// Klasa przedstawiająca główne okno programu
    /// </summary>
    class MainViewModel : ObservableObject
    {
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand LibraryViewCommand { get; set; }
        public RelayCommand StatisticsViewCommand { get; set; }
        public RelayCommand FeedViewCommand { get; set; }
        public RelayCommand ArtistViewCommand { get; set; }
        public RelayCommand AlbumViewCommand { get; set; }
        public RelayCommand SongViewCommand { get; set; }
        public HomeViewModel HomeVM { get; set; }
        public LibraryViewModel LibraryVM { get; set; }
        public FeedViewModel FeedVM { get; set; }
        public AlbumViewModel AlbumVM {get;set;}
        public ArtistViewModel ArtistVM { get; set; }
        public SongViewModel SongVM { get; set; }



        private object _currentView;
        /// <summary>
        /// Obiekt do zmiany widoku okna 
        /// </summary>
        public object CurrentView
        {
            get { return _currentView; }
            set { _currentView = value;
                OnPropertyChanged();}
        }
        /// <summary>
        /// Funkcja tworząca widoki w głownym oknie programu oraz komendy do zmieniania widoku
        /// </summary>
        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            LibraryVM = new LibraryViewModel();
            FeedVM = new FeedViewModel();
            ArtistVM = new ArtistViewModel();
            AlbumVM = new AlbumViewModel();
            SongVM = new SongViewModel();
            CurrentView = HomeVM;
            HomeViewCommand = new RelayCommand(o => { CurrentView = HomeVM; });
            LibraryViewCommand = new RelayCommand(o => { CurrentView = LibraryVM; });
            FeedViewCommand = new RelayCommand(o => { CurrentView = FeedVM; });
            ArtistViewCommand = new RelayCommand(o => { CurrentView = ArtistVM; });
            AlbumViewCommand = new RelayCommand(o => { CurrentView = AlbumVM; });
            SongViewCommand = new RelayCommand(o => { CurrentView = SongVM; });        }
    }
}
