using DarkHeresy2CharacterCreator.Model.GeneralSuppliment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkHeresy2CharacterCreator.Model.Character
{
    public static class CharacterCompleteCreationExtension
    {
        #region Add and remove general suppliments
        public static void AddHomeworld(this Character character, HomeWorld homeworld)
        {
            character.HomeWorld = homeworld;
            character.FateTreshold = homeworld.FateTreshold;
            character.TotalWounds = homeworld.Wounds;
            character.Aptitudes.Add(homeworld.HomeWorldAptitude);
        }
        public static void RemoveHomeworld(this Character character)
        {
            if (character.HomeWorld != null)
            {
                var removedHomeworld = character.HomeWorld;
                character.Aptitudes.Remove(removedHomeworld.HomeWorldAptitude);
                character.FateTreshold = 0;
                character.TotalWounds = 0;
                character.HomeWorld = null;
            }
        }

        public static void AddBackround(this Character character, Background background)
        {
            character.Background = background;

            foreach (var b in background.BackgroundSkills)
                character.Skills.Add(b.Item1);

            foreach (var t in background.BackgroundsTalents)
                character.Talents.Add(t.Item1);

            foreach (var item in background.BackgroundEquipment)
                character.Gear.Add(item.Item1);

            character.Aptitudes.Add(background.BackgroundAptitude.Item1);

            if (background.Trait != null)
                character.Traits.Add(background.Trait);
        }
        public static void RemoveBackround(this Character character)
        {
            if (character.Background != null)
            {
                var removedBackground = character.Background;
                foreach (var b in removedBackground.BackgroundSkills)
                    character.Skills.Remove(b.Item1);

                foreach (var t in removedBackground.BackgroundsTalents)
                    character.Talents.Remove(t.Item1);

                foreach (var item in removedBackground.BackgroundEquipment)
                    character.Gear.Remove(item.Item1);

                character.Aptitudes.Remove(removedBackground.BackgroundAptitude.Item1);

                if (removedBackground.Trait != null)
                    character.Traits.Remove(removedBackground.Trait);

                character.Background = null;
            }
        }

        public static void AddRole(this Character character, Role role)
        {
            character.Role = role;

            foreach (var a in role.Aptitudes)
                character.Aptitudes.Add(a.Item1);

            character.Talents.Add(role.RoleTalent.Item1);
        }

        public static void RemoveRole(this Character character)
        {
            if(character.Role != null)
            {
                var removedRole = character.Role;

                foreach (var a in removedRole.Aptitudes)
                    character.Aptitudes.Remove(a.Item1);

                character.Talents.Remove(removedRole.RoleTalent.Item1);

                character.Role = null;
            }
        }

        #endregion
    }
}
