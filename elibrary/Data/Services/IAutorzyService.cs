using elibrary.Models;

namespace elibrary.Data.Services
{
    public interface IAutorzyService
    {
        Task<IEnumerable<Autor>> GetAll();

        Autor GetById(int id);

        void Add(Autor autor);

        Autor Update(int id, Autor newAutor);

        void Delete(int id);
    }
}
