namespace QuicNotepad
{
    public class NoteItemDVM : NoteItemViewModel
    {
        // A singleton
        public static NoteItemDVM Singleton => new NoteItemDVM();

        //
        public NoteItemDVM()
        {
            NoteName = "ctor";
        }

    }
}
