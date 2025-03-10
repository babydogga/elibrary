using elibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace elibrary.Data.Services
{
    public class AutorzyService : IAutorzyService
    {
        private readonly AppDbContext _context;
        public AutorzyService(AppDbContext context)
        {
            _context = context;
        }

        public void Add(Autor autor)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Autor>> GetAll()
        {
            var result = await _context.Autorzy.ToListAsync();
            return result;
        }

        public Autor GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Autor Update(int id, Autor newAutor)
        {
            throw new NotImplementedException();
        }
    }
}
