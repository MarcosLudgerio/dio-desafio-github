namespace LocalizaFrota.Respository.EF
{
    public class FrotaContext : DbContext
    {
        public FrotaContext(DbContextOptions<FrotaContext> options)
          : base(options)
        {
        }

        public DbSet<Veichle> Veichle { get; set; }
    }
}