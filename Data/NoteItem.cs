using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotesProject.Data
{
    public class NoteItem
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Contents { get; set; }
        public string Tags { get; set; }
        public bool IsDone { get; set; }
        public int Date { get; set; }
    }
}
