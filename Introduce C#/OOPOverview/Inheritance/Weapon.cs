namespace Inheritance
{
    public class Weapon
    {
        //Her weapon nesnesinin .............. vardır.

        public int Weight { get; set; }
        public int HitPoint { get; set; }

        public void Attack()
        {

        }

    }

    public class Gun : Weapon
    {
        public int MaxBullet { get; set; }
        public int ChargerCount { get; set; }

        public void ChangeCharger()
        {

        }

    }

    public class Rifle : Gun
    {
        public bool Zommable { get; set; }
    }

    public class Ak47 : Rifle
    {
        public string ChargerType { get; set; }
    }

    public class Pistol : Gun
    {

    }

    public class DesertEagle : Pistol
    {

    }

}
