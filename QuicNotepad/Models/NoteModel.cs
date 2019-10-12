namespace QuicNotepad
{
    public class NoteModel : ObservableObject
    {
        // Name of the note file
        private string name;
        public string Name
        {
            get { return name; }
            set { OnPropertyChanged(ref name, value); }
        }

        // Path to the note file
        private string path;
        public string Path
        {
            get { return name; }
            set { OnPropertyChanged(ref path, value); }
        }

        // Text of the note file
        private string text;
        public string Text
        {
            get { return name; }
            set { OnPropertyChanged(ref text, value); }
        }

        // Whether name or path empty
        public bool isEmpty
        {
            get
            {
                if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Path))
                    return true;
                else
                    return false;
            }
        } 

    }
}
