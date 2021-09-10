using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NotesProject.Data;

namespace NotesProject.Services
{
    interface Interface
    {
        List<NoteItem> GetItems();
        NoteItem GetItemById(int id);
        void SaveItem(NoteItem note);
        void DeleteItem(int id);
    }
}