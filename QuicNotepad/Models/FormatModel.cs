using System.Windows;

namespace QuicNotepad
{
    public class FormatModel : ObservableObject
    {
        // Font size of the note editor
        private int fontSize = 16;
        public int FontSize
        {
            get { return fontSize; }
            set { OnPropertyChanged(ref fontSize, value); }
        }

        // Whether to wrap the text      FIXME!!!!!!!!!!!
        private TextWrapping wrap;
        public TextWrapping Wrap
        {
            get { return wrap; }
            set {
                OnPropertyChanged(ref wrap, value);
                
            }
        }

    }
}
