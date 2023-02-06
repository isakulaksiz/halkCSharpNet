namespace Polymorphism
{
    public class Cooker
    {
        public void Cook(Food food)
        {
            food.Prepare();
            food.Present();
        }
    }

    public class Food
    {


        public void Prepare()
        {
            Console.WriteLine($"{GetType().Name} yemeği pişti");
        }


        public virtual void Present()
        {
            Console.WriteLine($"{GetType().Name}, yanında pilav ile sunuldu");
        }

    }

    public class Meat : Food
    {

    }

    public class ChickenWings : Meat
    {

    }

    public class Soup : Food
    {
        public override void Present()
        {
            Console.WriteLine($"{GetType().Name}, çeşitli soslar ve ekmek ile sunuldu!");
        }
    }

    public class TomatoSoup : Soup
    {

    }

}
