namespace DILifeCycle.Models
{
    public class GuidService
    {
        public ISingletonGuidGenerator Singleton { get; set; }
        public ITransientGuidGenerator Transient { get; set; }
        public IScopedGuidGenerator Scoped { get; set; }

        public GuidService(ISingletonGuidGenerator singleton, ITransientGuidGenerator transient, IScopedGuidGenerator scoped)
        {
            Singleton = singleton;
            Transient = transient;
            Scoped = scoped;
        }
    }
}
