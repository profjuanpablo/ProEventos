using Microsoft.EntityFrameworkCore;
using ProEventos.API.Models;

namespace ProEventos.API.Data
{
    public class DataContext : DbContext //Herdar do Microsoft EntityFrameWorkCore
    {
        public DataContext(DbContextOptions<DataContext> options): base (options){}
        
        //Criar o DBSET
        public DbSet<Evento> Eventos {get; set;}
    }
}