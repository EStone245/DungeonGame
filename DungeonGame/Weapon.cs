// Made by Ethan Stone
// 10/17/2024

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonGame
{
    public class Weapon
    {
        // private variables
        private String weaponName = "n/a";
        private int weaponDamage = 0;

        // public variables
        public String WeaponName
        {
            get { return this.weaponName; }
            set { this.weaponName = value; }
        }

        public int WeaponDamage
        {
            get { return this.weaponDamage; }
            set { this.weaponDamage = value; }
        }

        // constructors
        public Weapon()
        {
            // empty constructor
        }

        public Weapon(String aName, int aDamage)
        {
            this.WeaponName = aName;
            this.WeaponDamage = aDamage;
        }

        // methods
        public override string ToString()
        {
            string message = "";
            message = message + "Weapon Name: " + this.WeaponName + "\n";
            message = message + "Weapon Damage: " + this.WeaponDamage + "\n";
            return message;
        }
    }
}
