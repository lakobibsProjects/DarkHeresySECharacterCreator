﻿using DarkHeresy2CharacterCreator.Model.PsychicPowers;
using DarkHeresy2CharacterCreator.Model.Skills;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;

namespace DarkHeresy2CharacterCreator.Model.Talents
{
    /// <summary>
    /// Instantiate logic of talent 
    /// </summary>
    [AddINotifyPropertyChangedInterface]
    public class Talent : ITalent
    {
        #region Fields
        private string name;
        private string discription;
        private SourceList sourceBook;
        private int sourcePage;
        private int tier;
        private AptitudeName first;
        private AptitudeName second;
        private int cost;
        private ObservableCollection<ValueTuple<Type, string, string, int>> prerequisites;
        private ObservableCollection<string> specializations;
        private readonly int[,] costTable = { { 600, 900, 1200 }, { 300, 450, 600 }, { 200, 300, 400 } };
        #endregion Fields
        #region Properties
        public string Name { get { return name; } set { name = value; } }
        public string Discription { get { return discription; } set { discription = value; } }

        public AptitudeName FirstAptitude { get { return first; } protected set { first = value; } }
        public AptitudeName SecondAptitude { get { return second; } protected set { second = value; } }
        public int Cost { get { return cost; } private set { cost = value; } }

        public int Tier { get { return tier; } protected set { tier = value; } }

        public SourceList SourceBook { get { return sourceBook; } protected set { sourceBook = value; } }

        public int SourcePage { get { return sourcePage; } protected set { sourcePage = value; } }

        public ObservableCollection<ValueTuple<Type, string, string, int>> Prerequisites { get { return prerequisites; } set { prerequisites = value; } }

        public ObservableCollection<string> Specializations { get { return specializations; } set { specializations = value; } }
        #endregion Properties
        #region Consturctors
        public Talent(string name, string discription, AptitudeName firstAptitude, AptitudeName secondAptitude, int tier)
        {
            Name = name;
            Discription = discription;
            FirstAptitude = firstAptitude;
            SecondAptitude = secondAptitude;
            Tier = tier;
            Cost = costTable[0, 0];
            SourceBook = SourceList.Core_Rulebook_2_edition;
            SourcePage = 119;

            prerequisites = new ObservableCollection<ValueTuple<Type, string, string, int>>();
            specializations = new ObservableCollection<string>();
        }
        public Talent(string name, string Discription, AptitudeName firstAptitude, AptitudeName secondAptitude, int tier, SourceList sourceBook, int sourcePage)
            : this(name, Discription, firstAptitude, secondAptitude, tier)
        {
            SourceBook = sourceBook;
            SourcePage = sourcePage;
        }
        #endregion Constructors

        /// <summary>
        /// Determine cost to take talent
        /// </summary>
        /// <param name="charecterAptitudes">Aptitudes of character</param>
        public void ChangeAdvanceCost(IEnumerable<AptitudeName> charecterAptitudes)
        {
            int haveAptitudes = 0;
            foreach (AptitudeName a in charecterAptitudes)
                if (a == FirstAptitude || a == SecondAptitude) haveAptitudes++;
            Cost = costTable[haveAptitudes, tier - 1];
        }
        //todo: rewrite
        /// <summary>
        /// Can character take a talent
        /// </summary>
        /// <param name="character">Character than request access</param>
        /// <returns></returns>
        public bool PrerequisiteAccess(Character.Character character)
        {
            bool hasAccess = false;
            int prerquisiteAccessed = 0;
            foreach (var item in Prerequisites)
            {
                switch (item.Item1.Name)
                {
                    case "Talent":          //todo: update with specialization
                        if (character.Talents.Contains(TalentList.Talents.Where(t => t.Name == item.Item2).FirstOrDefault()))                        
                            prerquisiteAccessed++;                        
                        break;
                    case "Characteristic":
                        if (character.Characteristics.Where(c => c.Name.ToString() == item.Item2).FirstOrDefault().Value >= item.Item4)
                            prerquisiteAccessed++;
                        break;
                    case "Trait":
                        if (character.Traits.Contains(Traits.TraitList.Traits.Where(t => t.Name == item.Item2).FirstOrDefault()))
                            prerquisiteAccessed++;
                        break;
                    case "Item":
                        if(character.Gear.Where(i => i.Name == item.Item2).FirstOrDefault() != null)
                            prerquisiteAccessed++;
                        break;
                    case "CommonSkills":
                        if (character.CommonSkills.Where(c => c.Name.ToString() == item.Item2).FirstOrDefault().Rank >= (Ranking)item.Item4)
                            prerquisiteAccessed++;
                        break;
                    case "SpecializedSkills":          //todo: update with specialization
                        if (character.SpecializedSkills.Where(c => c.Name.ToString() == item.Item2).FirstOrDefault().Rank >= (Ranking)item.Item4)
                            prerquisiteAccessed++;
                        break;
                }
            }

            return hasAccess;
        }
    }
}
