using System;

namespace Arrays_WeaopnSystem_2026
{
    internal class Program
    {
        //loadedammo[]
        //currentweapon
        //fire()
        static string[] Weapon = {"Pistol", "Shotgun", "Rocket", "Rifle"};
        static int[] weaponCapacity = { 9, 5, 1, 50 }; //how much the weapon can hold at once
        static int[] weaponPower = { 2, 5, 8, 3 }; //how much damage the weapon does

        //
        static int[] loadedAmmo = { 0, 0, 0, 0 }; //amount of ammo inside weapon, current ammo
        static int[] reserveAmmo= { 0, 0, 0, 0 }; //ammo on player not in weapon
        static int currentWeapon;

        static void Main()
        {
            //Console.WriteLine("Hello world");

            //Pistol
            //SwitchWeapon(0);
            //Fire();
            //ShowWeaponHUD();
            //PickupAmmo(3);
            //ShowWeaponHUD();
            //ReloadAmmo();
            //ShowWeaponHUD();
            //Fire();
            //ShowWeaponHUD();

            //Console.ForegroundColor = ConsoleColor.Cyan;
            //Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            //Console.ForegroundColor = ConsoleColor.White;

            ////Shotgun
            SwitchWeapon(1);
            Fire();
            ShowWeaponHUD();
            PickupAmmo(40);
            ShowWeaponHUD();
            ReloadAmmo();
            ShowWeaponHUD();
            Fire();
            ShowWeaponHUD();

            //Console.ForegroundColor = ConsoleColor.Cyan;
            //Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            //Console.ForegroundColor = ConsoleColor.White;

            //////Rocket
            //SwitchWeapon(2);
            //Fire();
            //ShowWeaponHUD();
            //PickupAmmo(30);
            //ShowWeaponHUD();
            //ReloadAmmo();
            //ShowWeaponHUD();
            //Fire();
            //ShowWeaponHUD();

            //Console.ForegroundColor = ConsoleColor.Cyan;
            //Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            //Console.ForegroundColor = ConsoleColor.White;

            //////Rifle
            //SwitchWeapon(3);
            //Fire();
            //ShowWeaponHUD();
            //PickupAmmo(50);
            //ShowWeaponHUD();
            //ReloadAmmo();
            //ShowWeaponHUD();
            //Fire();
            //ShowWeaponHUD();

        }

        static void ShowWeaponHUD()
        {
            //
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n|Weapon|"+" "+ "|Loaded|" + "  " + "|Bagged|" + " " + "|Power|");
            Console.WriteLine("-----------------------------------");
            //for
            Console.WriteLine(" "+ Weapon[0] + "     " + loadedAmmo[0] + "/" + weaponCapacity[0] + "       " + reserveAmmo[0] + "       " + weaponPower[0]);
            Console.WriteLine(" "+ Weapon[1] + "    " + loadedAmmo[1] + "/" + weaponCapacity[1] + "       " + reserveAmmo[1] + "       " + weaponPower[1]);
            Console.WriteLine(" "+ Weapon[2] + "     " + loadedAmmo[2] + "/" + weaponCapacity[2] + "       " + reserveAmmo[2] + "       " + weaponPower[2]);
            Console.WriteLine(" "+ Weapon[3] + "      " + loadedAmmo[3] + "/" + weaponCapacity[3] + "      " + reserveAmmo[3] + "       " + weaponPower[3]);
            //
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Weapon Active");
            Console.WriteLine("-----------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" " + Weapon[currentWeapon] + "     " 
                + loadedAmmo[currentWeapon] + "/" + weaponCapacity[currentWeapon] + "       " 
                + reserveAmmo[currentWeapon] + "       " 
                + weaponPower[currentWeapon]);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-----------------------------------");

            Console.ForegroundColor = ConsoleColor.Gray;
        }

        static void Fire()
        {
            if (loadedAmmo[currentWeapon] == 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\nNo ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(Weapon[currentWeapon]);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(" Ammo");

                Console.ForegroundColor = ConsoleColor.Gray;

                //Reload();
                return;
            }

            loadedAmmo[currentWeapon]--;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\nFired ");

            Console.ForegroundColor= ConsoleColor.White;
            Console.WriteLine(Weapon[currentWeapon]);

            Console.ForegroundColor = ConsoleColor.Gray;


        }

        static void PickupAmmo(int addAmmo)
        {
            reserveAmmo[currentWeapon] += addAmmo;

            //
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
            //this isnt right
            //fix
            int ammountToLoad;
            int leftOvers;

            ammountToLoad = reserveAmmo[currentWeapon];

            loadedAmmo[currentWeapon] += ammountToLoad;

            ammountToLoad -= reserveAmmo[currentWeapon];

            //
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\nReloading ");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Weapon[currentWeapon]);
        }

        static void SwitchWeapon(int newWeapon)
        {
            //how to switch?

            //and after playing with the hud i realized it was way easier then i was thinking it was LOL
            currentWeapon = newWeapon;

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\nChanged Weapon: ");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Weapon[currentWeapon]);
        }
    }
}
