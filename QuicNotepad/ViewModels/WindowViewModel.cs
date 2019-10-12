using System.Windows;

namespace QuicNotepad
{
    public class WindowViewModel : ObservableObject
    {
        public WindowViewModel()
        {
            ToggleSidebarCommand = new RelayCommand(ToggleSidebar);
        }

        #region Properties

        // Main window instance
        private Window mainWnd = Application.Current.MainWindow;


        // Whether the side menu expanded or collapsed
        private bool sideMenuVisible = true; 
        public bool SideMenuVisible
        {
            get { return sideMenuVisible; }
            set { OnPropertyChanged(ref sideMenuVisible, value); }
        }

        // Height of an area which allows drag moving
        public int TitleHeight { get; set; } = 30;

        // Main window dimensions
        public int WindowHeight => outerMargin * 2; //540
        public int WindowWidth  => outerMargin * 2; //960

        // Thichness of a resize border
        private static int resizeBorder = 3;
        private Thickness resizeBorderThickness = new Thickness(resizeBorder + outerMargin);
        public Thickness ResizeBorderThickness
        {
            get { return mainWnd.WindowState == WindowState.Maximized ? new Thickness(0) : resizeBorderThickness; }
            set { OnPropertyChanged(ref resizeBorderThickness, value); }
        }

        // FIXME
        private static int outerMargin = 16;
        private Thickness outerMarginThickness = new Thickness(outerMargin);
        public Thickness OuterMarginThickness
        {
            get { return mainWnd.WindowState == WindowState.Maximized ? new Thickness(0) : outerMarginThickness; }
            set { OnPropertyChanged(ref outerMarginThickness, value); }
        }

        #endregion

        #region Commands

        // Expand or collapse the side menu
        public RelayCommand ToggleSidebarCommand { get; private set; }

        private void ToggleSidebar() => SideMenuVisible = !SideMenuVisible;



        #endregion

    }
}
