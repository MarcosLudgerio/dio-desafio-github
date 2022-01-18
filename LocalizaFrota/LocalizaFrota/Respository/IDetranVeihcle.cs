namespace LocalizaFrota.Respository
{
    public interface IDetranVeihcle
    {
        public Task AgendarVistoriaDetran(Guid veiculoId);
    }
}