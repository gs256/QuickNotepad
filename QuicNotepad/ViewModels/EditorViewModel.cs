namespace QuicNotepad
{
    public class EditorViewModel : ObservableObject
    {
        public EditorViewModel(NoteModel note)
        {
            Note = note;
        }

        public FormatModel Format { get; set; }
        public NoteModel Note { get; set; }


    }
}
