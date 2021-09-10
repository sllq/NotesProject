using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NotesProject.Data;

namespace NotesProject.Services
{
    public class NoteItemService : Interface
    {
        private readonly DbContexts.ApplicationDbContext _dbContext;
        public NoteItemService(DbContexts.ApplicationDbContext context)
        {
            _dbContext = context;
        }
        public void DeleteItem(int id)
        {
            var item = _dbContext.NoteItem.FirstOrDefault(x => x.ID == id);
            if (item != null)
            {
                _dbContext.NoteItem.Remove(item);
                _dbContext.SaveChanges();
            }
        }
        public NoteItem GetItemById(int id)
        {
            var item = _dbContext.NoteItem.SingleOrDefault(x => x.ID == id);
            return item;
        }
        public List<NoteItem> GetItems()
        {
            return _dbContext.NoteItem.ToList();
        }
        public void SaveItem(NoteItem note)
        {
            if (note.ID == 0) _dbContext.NoteItem.Add(note);
            else _dbContext.NoteItem.Update(note);
            _dbContext.SaveChanges();
        }
    }

}
