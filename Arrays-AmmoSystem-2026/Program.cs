using System;

namespace Arrays_WeaopnSystem_2026
{
    internal class Program
    {
        //loadedammo[]
        //currentweapon
        //fire()
        static string[] Weapon = {"Pistol", "Shotgun", "Rocket", "Rifle"};
        static int[] weaponCapacity = { 9, 5, 1, 50 };
        static int[] weaponPower = { 2, 5, 8, 3 };

        //
        static int[] loadedAmmo = { 0, 0, 0, 0 }; //amount of ammo inside weapon, current ammo
        static int[] reserveAmmo= { 0, 0, 0, 0 }; //ammo on player not in weapon
        static int currentWeapon;

        static void Main()
        {
            currentWeapon = 0;
            //Console.WriteLine("Hello world");
            ShowWeaponHUD();
            PickupAmmo(10);

            ShowWeaponHUD();

        }

        static void ShowWeaponHUD()
        {
            Console.WriteLine("\n|Weapon|"+" "+ "|Loaded|");
            Console.WriteLine(Weapon[0] + "    " + loadedAmmo[0] + "/" + reserveAmmo[0]);
            Console.WriteLine(Weapon[1] + "   " + loadedAmmo[1] + "/" + reserveAmmo[1]);
            Console.WriteLine(Weapon[2] + "    " + loadedAmmo[2] + "/" + reserveAmmo[2]);
            Console.WriteLine(Weapon[3] + "     " + loadedAmmo[3] + "/" + reserveAmmo[3]);
            Console.WriteLine("~~~~~~");
            Console.WriteLine("Current Weapon: " + currentWeapon);
        }

        static void Fire(int dmg)
        {
            loadedAmmo[currentWeapon] -= dmg;
        }

        static void PickupAmmo(int addAmmo)
        {
            reserveAmmo[currentWeapon] += addAmmo;
        }

        static void ReloadAmmo()
        {
            //reserveAmmo[currentWeapon] + loadedAmmo[currentWeapon] of weaponCapacity[currentWeapon]
        }

        static void SwitchWeapon(int newWeapon)
        {
            //how to switch?
        }
    }
}
