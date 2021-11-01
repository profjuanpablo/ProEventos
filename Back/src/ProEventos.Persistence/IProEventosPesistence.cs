using System.Threading.Tasks;
using ProEventos.Domain;

namespace ProEventos.Persistence
{
    public interface IProEventosPesistence
    {
        //todo e qualquer adicionar/updade/delete já está feito
        void add<T>(T entity) where T: class;
        void Update<T>(T entity) where T: class;
        void Delete<T>(T entity) where T: class;
        void DeleteRange<T>(T entity) where T: class;

        Task<bool> SaveChangesAsync();

        //Eventos
        Task<Evento[]> GetAllEventosByTemasAsync(string tema, bool includePalestrante);
        Task<Evento[]> GetAllEventosAsync(bool includePalestrante);

        Task<Evento> GetEventoByIdAsync(int EventoId, bool includePalestrante);


        //Palestrantes é muito  pra muitos

        
         Task<Palestrante[]> GetAllPalestrantesByNomeAsync(string Nome, bool includeEventos);
        Task<Palestrante[]> GetAllPalestrantesAsync( bool includeEventos);

        Task<Palestrante> GetPalestranteByIdAsync(int palestranteId, bool includeEventos);

    }
}