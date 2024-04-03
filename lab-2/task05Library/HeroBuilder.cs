using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task05Library
{
    public class HeroBuilder : ICharacterBuilder
    {
        private Hero hero = new Hero();

        public ICharacterBuilder SetName(string name)
        {
            hero.Name = name;
            return this;
        }

        public ICharacterBuilder SetGender(string gender)
        {
            hero.Gender = gender;
            return this;
        }

        public ICharacterBuilder SetHeight(int height)
        {
            hero.Height = height;
            return this;
        }

        public ICharacterBuilder SetBuild(string build)
        {
            hero.Build = build;
            return this;
        }

        public ICharacterBuilder SetHairColor(string hairColor)
        {
            hero.HairColor = hairColor;
            return this;
        }

        public ICharacterBuilder SetEyeColor(string eyeColor)
        {
            hero.EyeColor = eyeColor;
            return this;
        }

        public ICharacterBuilder SetClothing(string clothing)
        {
            hero.Clothing = clothing;
            return this;
        }

        public ICharacterBuilder AddToInventory(string item)
        {
            if (hero.Inventory == null)
            {
                hero.Inventory = new List<string>();
            }
            hero.Inventory.Add(item);
            return this;
        }
        public ICharacterBuilder AddToDeeds(string deed)
        {
            if (hero.Deeds == null)
            {
                hero.Deeds = new List<string>();
            }
            hero.Deeds.Add(deed);
            return this;
        }

        public Hero Build()
        {
            return hero;
        }
    }
}
