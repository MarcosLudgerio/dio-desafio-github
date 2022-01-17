namespace LocalizaFrota.Models
{
    public sealed class Singleton
    {
        public Guild Id { get; } => Guild.NewGuild();
        private static Singleton instance = null;

        private Singleton() { }

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }
    }
}