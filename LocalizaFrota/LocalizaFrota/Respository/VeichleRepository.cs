namespace LocalizaFrota.Models
{
    public interface VeiclheRepository
    {
        void Add(Veiclhe veiclhe);
        void Delete(Veiclhe veiclhe);
        void Update(Veiclhe veiclhe);
        Veiclhe GetById(Guid Id);
        IEnumerable<Veiclhe> GetAll();
    }
}
