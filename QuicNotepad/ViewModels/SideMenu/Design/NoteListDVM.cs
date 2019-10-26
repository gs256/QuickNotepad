using System.Collections.Generic;

namespace QuicNotepad
{
    public class NoteListDVM : NoteListViewModel
    {
        //
        public static NoteListDVM Singleton => new NoteListDVM();

        // Default constructor
        public NoteListDVM()
        {
            Items = new List<NoteItemViewModel>
            {
                new NoteItemViewModel(),
                new NoteItemViewModel(),
                new NoteItemViewModel(),
                new NoteItemViewModel(),
                new NoteItemViewModel(),
                new NoteItemViewModel(),
                new NoteItemViewModel(),
                new NoteItemViewModel(),
                new NoteItemViewModel(),
                new NoteItemViewModel(),
                new NoteItemViewModel(),
                new NoteItemViewModel(),
                new NoteItemViewModel(),
                new NoteItemViewModel(),
                new NoteItemViewModel(),
                new NoteItemViewModel(),
                new NoteItemViewModel(),
                new NoteItemViewModel(),
                new NoteItemViewModel(),
                new NoteItemViewModel(),
                new NoteItemViewModel(),
                new NoteItemViewModel(),
                new NoteItemViewModel(),
                new NoteItemViewModel(),
                new NoteItemViewModel(),
                new NoteItemViewModel()

            };
        }


    }
}
