using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task05Library
{
    public class CharacterDirector
    {
        private ICharacterBuilder characterBuilder;

        public CharacterDirector(ICharacterBuilder builder)
        {
            characterBuilder = builder;
        }

        public void CreateCharacter(string name, string gender, int height, string build, string hairColor, string eyeColor, string clothing, List<string> inventory, List<string> deeds)
        {
            characterBuilder.SetName(name)
                            .SetGender(gender)
                            .SetHeight(height)
                            .SetBuild(build)
                            .SetHairColor(hairColor)
                            .SetEyeColor(eyeColor)
                            .SetClothing(clothing);

            if (inventory != null)
            {
                foreach (var item in inventory)
                {
                    characterBuilder.AddToInventory(item);
                }
            }
            if (deeds != null)
            {
                foreach (var deed in deeds)
                {
                    characterBuilder.AddToDeeds(deed);
                }
            }
        }
    }
}
