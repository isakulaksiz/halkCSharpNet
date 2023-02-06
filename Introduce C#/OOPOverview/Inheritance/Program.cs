// See https://aka.ms/new-console-template for more information
using Inheritance;

Console.WriteLine("Hello, World!");
/*
 * 1. Silahın ağırlığına göre koşma hızı değişir. (Agirlik)
 * 2. Düşmanı etkisiz hale getirme hızı (Vuruş gücü) * 
 */

Player player = new Player();
Ak47 ak47 = new Ak47();
Weapon knife = new Weapon();
DesertEagle desertEagle = new DesertEagle();

player.Weapon = desertEagle;
player.Weapon = ak47;
player.Weapon = new Ak47();