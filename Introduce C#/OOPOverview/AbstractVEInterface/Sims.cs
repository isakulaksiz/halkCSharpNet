namespace AbstractVEInterface
{
    public class Sims
    {

    }

    public class Insan
    {
        public void Giy(IKiyafet kiyafet) { }
    }

    public interface IKiyafet
    {

    }
    public abstract class Kiyafet : IKiyafet
    {

    }

    public class Kazak : Kiyafet
    {

    }
    public class KirmiziKazak : Kazak
    {
    }


}
