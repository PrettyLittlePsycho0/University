using System;
using System.Collections.Generic;

namespace Classapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VideoGameCharacter c1 = new VideoGameCharacter("abc", 1, 100, 25, 15, 0, 50, "Fire Slash");
            VideoGameCharacter c2 = new VideoGameCharacter("bvc", 3, 120, 30, 20, 200, 60, "Ice Storm");

            List<VideoGameCharacter> characters = new List<VideoGameCharacter>();
            characters.Add(c1);
            characters.Add(c2);

            c1.TakeDamage(30);
            c1.UsePotion("health");
            c1.LevelUp();
            c1.UsePotion("stamina");

            for (int i = 0; i < characters.Count; i++)
            {
                Console.WriteLine(characters[i].ToString());
                Console.WriteLine();
            }
        }
    }

    class VideoGameCharacter
    {
        public string CharacterName;
        public int Level;
        public int HealthPoints;
        public int AttackPower;
        public int DefensePower;
        public int ExperiencePoints;
        public int Stamina;
        public string SpecialAbility;

        public VideoGameCharacter(string name, int level, int hp, int atk, int def, int exp, int stamina, string ability)
        {
            CharacterName = name;
            Level = level;
            HealthPoints = hp;
            AttackPower = atk;
            DefensePower = def;
            ExperiencePoints = exp;
            Stamina = stamina;
            SpecialAbility = ability;
        }

        public void LevelUp()
        {
            Level = Level + 1;
            ExperiencePoints = 0;
        }

        public void TakeDamage(int damage)
        {
            int reduced = damage - DefensePower;
            if (reduced < 0)
            {
                reduced = 0;
            }
            HealthPoints = HealthPoints - reduced;
            if (HealthPoints < 0)
            {
                HealthPoints = 0;
            }
        }

        public void UsePotion(string type)
        {
            if (type == "health")
            {
                HealthPoints = HealthPoints + 30;
                if (HealthPoints > 100)
                {
                    HealthPoints = 100;
                }
            }
            else if (type == "stamina")
            {
                Stamina = Stamina + 20;
                if (Stamina > 100)
                {
                    Stamina = 100;
                }
            }
        }

        public int GetTotalPower()
        {
            return AttackPower + DefensePower;
        }

        public override string ToString()
        {
            return "Name: " + CharacterName + ", Level: " + Level + ", HP: " + HealthPoints + ", Attack: " + AttackPower + ", Defense: " + DefensePower + ", EXP: " + ExperiencePoints + ", Stamina: " + Stamina +", Ability: " + SpecialAbility + ", Total Power: " + GetTotalPower();
        }
    }
}
