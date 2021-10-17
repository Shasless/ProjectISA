using projet.Core;

namespace projet.MVM.ViewWodel
{
    public class MainViewModel: ObservableObject
    {
        
        public RelayCommand HomeViewComand { get; set; }
        public RelayCommand CoinViewComand { get; set; }
        
        public RelayCommand GraphViewComand { get; set; }
        public HomeViewModel HomeVM { get; set; }
        public CoinViewModel CoinVM { get; set; }
        
        public GraphViewModel GraphVM { get; set; }
        
        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value; 
                
                OnPropertyChanged();
            }
        }
       

        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            CoinVM = new CoinViewModel();
            GraphVM = new GraphViewModel();

            _currentView = HomeVM;

            HomeViewComand = new RelayCommand(o => { CurrentView = HomeVM; });
            CoinViewComand = new RelayCommand(o => { CurrentView = CoinVM; });
            GraphViewComand = new RelayCommand(o => { CurrentView = GraphVM; });
        }
    }
}