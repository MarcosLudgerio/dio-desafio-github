namespace LocalizaFrota.Respository
{
    public class InMemoryRepository : VeiclheRepository
    {

        private readonly IList<Veichle> entities = new List<Veiculo>();
        public void Add(Veichle veichle)
        {
            entities.Add(veichle);
        }

        public void Delete(Veichle veichle) => entities.Remove(veichle);

        public IEnumerable<Veichle> GetAll() => entities.ToList();

        public Veichle GetById(Guid Id) => entities.SingleOrDefault(c => c.Id == Id);

        public void Update(Veichle veichle)
        {
            entities.Remove(GetById(veichle.Id));
            entities.Add(veichle);
        }
    }
}