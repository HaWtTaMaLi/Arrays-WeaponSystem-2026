using System;

namespace Arrays_WeaopnSystem_2026
{
    internal class Program
    {
        //loadedammo[]
        //currentweapon
        //fire()

        #region Weapon Sum
        /// <summary>
        /// The weapon selection to choose from
        /// </summary>
        #endregion
        static string[] Weapon = {"Pistol", "Shotgun", "Rocket", "Rifle"};
        #region Capacity Sum
        /// <summary>
        /// How much ammo the weapon can hold
        /// </summary>
        #endregion
        static int[] weaponCapacity = { 9, 5, 1, 50 }; //how much the weapon can hold at once
        #region Power Sum
        /// <summary>
        /// The ammount of damage the weapon does
        /// </summary>
        #endregion
        static int[] weaponPower = { 2, 5, 8, 3 }; //how much damage the weapon does
        static int[] bulletPerShot = { 1, 2, 1, 1 };

        //
        static int[] loadedAmmo = { 0, 0, 0, 0 }; //amount of ammo inside weapon, current ammo
        static int[] reserveAmmo = { 0, 0, 0, 0 }; //ammo on player not in weapon
        #region Current Sum
        /// <summary>
        /// The weapon you currently have equipt
        /// </summary>
        #endregion
        static int currentWeapon;

        static int maxAmmoHeld = 100;

        static void Main()
        {
            //Console.WriteLine("Hello world");

            #region Pistol
            SwitchWeapon(0);
            Fire();
            ShowWeaponHUD();
            Console.ReadKey();

            PickupAmmo(3);
            ShowWeaponHUD();
            Console.ReadKey();

            ReloadAmmo();
            ShowWeaponHUD();
            Console.ReadKey();

            Fire();
            ShowWeaponHUD();
            #endregion
            #region Next
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("\nPress any key for Shotgun....");
            Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
            Console.Clear();
            #endregion

            #region Shotgun
            SwitchWeapon(1);
            Fire();
            ShowWeaponHUD();
            Console.ReadKey();

            PickupAmmo(5);
            ShowWeaponHUD();
            Console.ReadKey();

            ReloadAmmo();
            ShowWeaponHUD();
            Console.ReadKey();

            Fire();
            ShowWeaponHUD();
            #endregion
            #region Next
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("\nPress any key for Rocket....");
            Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
            Console.Clear();
            #endregion

            #region Rocket
            SwitchWeapon(2);
            Fire();
            ShowWeaponHUD();
            Console.ReadKey();

            PickupAmmo(30);
            ShowWeaponHUD();
            Console.ReadKey();

            ReloadAmmo();
            ShowWeaponHUD();
            Console.ReadKey();

            Fire();
            ShowWeaponHUD();
            #endregion
            #region Next
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("\nPress any key for Rifle....");
            Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
            Console.Clear();
            #endregion

            #region Rifle
            SwitchWeapon(3);
            Fire();
            ShowWeaponHUD();
            Console.ReadKey();

            PickupAmmo(50);
            ShowWeaponHUD();
            Console.ReadKey();

            ReloadAmmo();
            ShowWeaponHUD();
            Console.ReadKey();

            Fire();
            ShowWeaponHUD();
            #endregion
            #region End
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("\nPress any key to exit....");
            Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
            Console.Clear();
            #endregion
        }

        static void ShowWeaponHUD()
        {
            #region Header
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n|Weapon|" + " " + "|Loaded|" + "  " + "|Bagged|" + " " + "|Power|");
            Console.WriteLine("-----------------------------------");
            #endregion
            Console.WriteLine(" " + Weapon[0].PadRight(10) + loadedAmmo[0] + "/" + weaponCapacity[0] + "".PadRight(8) + reserveAmmo[0] + "".PadRight(8) + weaponPower[0]);
            Console.WriteLine(" " + Weapon[1].PadRight(10) + loadedAmmo[1] + "/" + weaponCapacity[1] + "".PadRight(8) + reserveAmmo[1] + "".PadRight(8) + weaponPower[1]);
            Console.WriteLine(" " + Weapon[2].PadRight(10) + loadedAmmo[2] + "/" + weaponCapacity[2] + "".PadRight(8) + reserveAmmo[2] + "".PadRight(8) + weaponPower[2]);
            Console.WriteLine(" " + Weapon[3].PadRight(9) + loadedAmmo[3] + "/" + weaponCapacity[3] + "".PadRight(8) + reserveAmmo[3] + "".PadRight(8) + weaponPower[3]);
            #region Mid
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Weapon Active");
            Console.WriteLine("-----------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            #endregion
            Console.WriteLine(" " + Weapon[currentWeapon].PadRight(10)
                + loadedAmmo[currentWeapon] + "/" + weaponCapacity[currentWeapon] + "".PadRight(8)
                + reserveAmmo[currentWeapon] + "".PadRight(8)
                + weaponPower[currentWeapon]);
            #region Foot
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-----------------------------------");
            Console.ForegroundColor = ConsoleColor.Gray;
            #endregion
        }

        static void Fire()
        {
            //can you fire with an empty weapon?
            if (loadedAmmo[currentWeapon] == 0)
            {
                #region WriteLine
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\nNo ");

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(Weapon[currentWeapon]);

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(" Ammo");

                Console.ForegroundColor = ConsoleColor.Gray;
                #endregion
                return; //no
            }

            //if loaded ammo is not equal to fire rate then 
            if (loadedAmmo[currentWeapon] < bulletPerShot[currentWeapon])
            {
                #region WriteLine
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nYou need more ammo to shoot.");
                Console.ForegroundColor = ConsoleColor.Gray;
                #endregion
                return; //do nothing
            }

            //loaded ammo - the amount the current weapon can fire
            loadedAmmo[currentWeapon] -= bulletPerShot[currentWeapon];

            #region WriteLine
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\nFired ");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(Weapon[currentWeapon]);

            Console.ForegroundColor = ConsoleColor.Gray;
            #endregion
        }

        static void PickupAmmo(int addAmmo)
        {
            //if the added ammo is greater then max Ammo held
            if (addAmmo > maxAmmoHeld)
            {
                #region WriteLine
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(Weapon[currentWeapon]);

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(" ammo is full");

                Console.ForegroundColor = ConsoleColor.Gray;
                #endregion

                //set it to stay at max
                reserveAmmo[currentWeapon] = maxAmmoHeld;
                return;
            }

            //add ammo to reserves
            reserveAmmo[currentWeapon] += addAmmo;

            #region WriteLine
            //
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\nPicked up ");

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(addAmmo + " " + Weapon[currentWeapon]);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" ammo");

            Console.ForegroundColor = ConsoleColor.Gray;
            #endregion
        }

        static void ReloadAmmo()
        {
            //Can you reload a gun with no ammo?
            if (reserveAmmo[currentWeapon] == 0)
            {
                #region WriteLine
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("No ammo in bag, can't reload ");

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(Weapon[currentWeapon]);

                Console.ForegroundColor = ConsoleColor.Gray;
                #endregion
                return; //no
            }

            //store some values
            int reserveAmmount = reserveAmmo[currentWeapon];
            int reloadAmmount = weaponCapacity[currentWeapon] - loadedAmmo[currentWeapon];

            //if the reserved ammo is less then weapon capacity
            if (reserveAmmo[currentWeapon] < reloadAmmount)
            {
                //add ammount
                loadedAmmo[currentWeapon] += reserveAmmount;
                //remove ammount
                reserveAmmo[currentWeapon] -= reserveAmmount;
            }
            else
            {
                //if the reserve ammo is greater then weapon capacity
                //remove the weapon capacity number from ammount to load
                reserveAmmount -= weaponCapacity[currentWeapon];

                //remove the remaining number from reserved ammo
                reserveAmmo[currentWeapon] -= reloadAmmount;

                //add the weapon capacity number to loaded ammo
                loadedAmmo[currentWeapon] += reloadAmmount;

                #region Debug
                ////debug
                //Console.WriteLine("How much is being added back to bag? " + reserveAmmount);
                //Console.WriteLine("How much is being added to loaded? " + reloadAmmount);
                #endregion
            }

            #region WriteLine
            //
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\nReloading ");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Weapon[currentWeapon]);

            Console.ForegroundColor = ConsoleColor.Gray;
            #endregion
        }

        static void SwitchWeapon(int newWeapon)
        {
            //how to switch?
            //and after playing with the hud i realized it was way easier then i was thinking it was LOL
            currentWeapon = newWeapon;

            #region WriteLine
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\nChanged Weapon: ");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Weapon[currentWeapon]);
            #endregion
        }
    }
}