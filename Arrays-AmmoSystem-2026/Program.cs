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
            //Console.WriteLine("Hello world");
            Console.ForegroundColor = ConsoleColor.Gray;

            currentWeapon = 0;
            Console.WriteLine("\nChanged Weapon: " + Weapon[currentWeapon]);
            ShowWeaponHUD();
            PickupAmmo(10);
            ShowWeaponHUD();

            currentWeapon = 1;
            Console.WriteLine("\nChanged Weapon: " + Weapon[currentWeapon]);
            ShowWeaponHUD();
            PickupAmmo(40);
            ShowWeaponHUD();

            currentWeapon = 2;
            Console.WriteLine("\nChanged Weapon: " + Weapon[currentWeapon]);
            ShowWeaponHUD();
            PickupAmmo(30);
            ShowWeaponHUD();

            currentWeapon = 3;
            Console.WriteLine("\nChanged Weapon: " + Weapon[currentWeapon]);
            ShowWeaponHUD();
            PickupAmmo(50);
            ShowWeaponHUD();

        }

        static void ShowWeaponHUD()
        {
            Console.WriteLine("\n|Weapon|"+" "+ "|Loaded|" + "  " + "|Bagged|" + " " + "|Power|");
            Console.WriteLine("-------------------------");
            Console.WriteLine(" "+ Weapon[0] + "     " + loadedAmmo[0] + "/" + weaponCapacity[0] + "       " + reserveAmmo[0] + "       " + weaponPower[0]);
            Console.WriteLine(" "+ Weapon[1] + "    " + loadedAmmo[1] + "/" + weaponCapacity[1] + "       " + reserveAmmo[1] + "       " + weaponPower[1]);
            Console.WriteLine(" "+ Weapon[2] + "     " + loadedAmmo[2] + "/" + weaponCapacity[2] + "       " + reserveAmmo[2] + "       " + weaponPower[2]);
            Console.WriteLine(" "+ Weapon[3] + "      " + loadedAmmo[3] + "/" + weaponCapacity[3] + "      " + reserveAmmo[3] + "       " + weaponPower[3]);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-------------------------");
            Console.WriteLine("Weapon Active");
            Console.WriteLine("-------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" " + Weapon[currentWeapon] + "     " 
                + loadedAmmo[currentWeapon] + "/" + weaponCapacity[currentWeapon] + "       " 
                + reserveAmmo[currentWeapon] + "       " 
                + weaponPower[currentWeapon]);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-------------------------");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        static void Fire(int dmg)
        {
            loadedAmmo[currentWeapon] -= dmg;
        }

        static void PickupAmmo(int addAmmo)
        {
            reserveAmmo[currentWeapon] += addAmmo;


            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\nPicked up ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(addAmmo + " " + Weapon[currentWeapon]);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" ammo");
            Console.ForegroundColor = ConsoleColor.Gray;
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
