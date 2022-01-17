public class FrotaRepository : IVeiculoRepository
{
    private readonly FrotaContext dbContext;

    public FrotaRepository(FrotaContext dbContext) => this.dbContext = dbContext;
    public void Add(Veichle veichle)
    {
        dbContext.veichle.Add(veichle);
        dbContext.SaveChanges();
    }

    public void Delete(Veichle veichle)
    {
        dbContext.veichle.Remove(veichle);
        dbContext.SaveChanges();
    }

    public IEnumerable<Veichle> GetAll() => dbContext.veichle.ToListAsync().Result;

    public Veichle GetById(Guid Id) => dbContext.veichle.SingleOrDefaultAsync().Result;

    public void Update(Veichle veichle)
    {
        dbContext.Entry(veichle).State = EntityState.Modified;
        dbContext.SaveChanges();
    }
}