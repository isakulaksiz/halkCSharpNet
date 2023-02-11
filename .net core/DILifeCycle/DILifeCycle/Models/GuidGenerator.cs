namespace DILifeCycle.Models
{
    /*
     * Dependency Injection ile bir instance oluşturmak için:
     * AddScoped()
     * AddSingleton()
     * AddTransient() metotları var....
     * 
     * Singleton: Yalnızca bir instance al....
     * Transient: Her ihtiyaç duyulduğunda FARKLI instance
     * Scope: Kullanılan obje ile simbiyotik ilişki içinde olan instance
     */

    public interface IGuidGenerator
    {
        Guid Guid { get; }
    }

    public interface ISingletonGuidGenerator : IGuidGenerator { }
    public interface ITransientGuidGenerator : IGuidGenerator { }
    public interface IScopedGuidGenerator : IGuidGenerator { }

    public class SingletonGuidGenerator : ISingletonGuidGenerator
    {
        public Guid Guid { get; private set; }

        public SingletonGuidGenerator()
        {
            Guid = Guid.NewGuid();
        }
    }

    public class TransientGuidGenerator : ITransientGuidGenerator
    {
        public Guid Guid { get; private set; }
        public TransientGuidGenerator()
        {
            Guid = Guid.NewGuid();
        }
    }

    public class ScopedGuidGenerator : IScopedGuidGenerator
    {
        public Guid Guid { get; private set; }
        public ScopedGuidGenerator()
        {
            Guid = Guid.NewGuid();
        }
    }
}
