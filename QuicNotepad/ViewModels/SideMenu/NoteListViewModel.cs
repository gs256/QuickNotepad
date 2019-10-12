using System.Collections.Generic;

namespace QuicNotepad
{
    public class NoteListViewModel : ObservableObject
    {
        // List of the note items in the side menu
        public List<NoteItemViewModel> Items { get; set; }

    }
}
