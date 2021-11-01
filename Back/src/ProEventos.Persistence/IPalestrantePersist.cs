using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProEventos.Domain;

namespace ProEventos.Persistence
{
    public class  IProEventosPesist
    {
         Task<Palestrante[]> GetAllPalestrantesByNomeAsync(string Nome, bool includeEventos);
        Task<Palestrante[]> GetAllPalestrantesAsync( bool includeEventos);

        Task<Palestrante> GetPalestranteByIdAsync(int palestranteId, bool includeEventos);



        
    }
}