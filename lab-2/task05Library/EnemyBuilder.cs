using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task05Library
{
    public class EnemyBuilder : ICharacterBuilder
    {
        private Hero enemy = new Hero();

        public ICharacterBuilder SetName(string name)
        {
            enemy.Name = name;
            return this;
        }

        public ICharacterBuilder SetGender(string gender)
        {
            enemy.Gender = gender;
            return this;
        }

        public ICharacterBuilder SetHeight(int height)
        {
            enemy.Height = height;
            return this;
        }

        public ICharacterBuilder SetBuild(string build)
        {
            enemy.Build = build;
            return this;
        }

        public ICharacterBuilder SetHairColor(string hairColor)
        {
            enemy.HairColor = hairColor;
            return this;
        }

        public ICharacterBuilder SetEyeColor(string eyeColor)
        {
            enemy.EyeColor = eyeColor;
            return this;
        }

        public ICharacterBuilder SetClothing(string clothing)
        {
            enemy.Clothing = clothing;
            return this;
        }

        public ICharacterBuilder AddToInventory(string item)
        {
            if (enemy.Inventory == null)
            {
                enemy.Inventory = new List<string>();
            }
            enemy.Inventory.Add(item);
            return this;
        }
        public ICharacterBuilder AddToDeeds(string deed)
        {
            if (enemy.Deeds == null)
            {
                enemy.Deeds = new List<string>();
            }
            enemy.Deeds.Add(deed);
            return this;
        }

        public Hero Build()
        {
            return enemy;
        }

    }
}
