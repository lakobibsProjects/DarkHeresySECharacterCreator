﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DarkHeresy2CharacterCreator.Model.Character;
using PropertyChanged;

namespace DarkHeresy2CharacterCreator.Model.Skills
{
    /// <summary>
    /// General functionality of skill
    /// </summary>
    [AddINotifyPropertyChangedInterface]
    public abstract class AbstractSkill : IPrerequisitable, IAptitudeDependent
    {
        #region Fields
        private SkillName name;
        private Ranking rank;
        private AptitudeName first;
        private AptitudeName second;
        private int bonus = -20;
        private readonly int[,] costTable = new int[,] { { 300, 600, 900, 1200 }, { 200, 400, 600, 800 }, { 100, 200, 300, 400 } };
        private int cost;
        private string discription;
        #endregion Fields
        #region Properties
        public SkillName Name
        {
            get { return name; }
            set { name = value; }
        }

        public Ranking Rank
        {
            get { return rank; }
            protected set { rank = value; }
        }
        public AptitudeName FirstAptitude { get { return first; } protected set { first = value; } }
        public AptitudeName SecondAptitude { get { return second; } protected set { second = value; } }
        public int Cost { get { return cost; } private set { cost = value; } }
        public int SkillBonus
        {
            get { return bonus; }
            private set
            {
                switch (Rank)
                {
                    case Ranking.Unknown:
                        bonus = -20;
                        break;
                    case Ranking.Known:
                        bonus = 0;
                        break;
                    case Ranking.Trained:
                        bonus = 10;
                        break;
                    case Ranking.Experienced:
                        bonus = 20;
                        break;
                    case Ranking.Veteran:
                        bonus = 30;
                        break;
                }
            }
        }

        public string Discription { get { return discription; } internal set { discription = value; } }
        #endregion Properties

        /// <summary>
        /// Determine cost to advance skill
        /// </summary>
        /// <param name="charecterAptitudes">Aptitudes of character</param>
        public void ChangeAdvanceCost(IEnumerable<AptitudeName> CharecterAptitudes)
        {
            int haveAptitudes = 0;
            bool hasOneAptitude = false;
            bool hasSecondAptitude = false;
            foreach (AptitudeName a in CharecterAptitudes)
            {
                if (a == FirstAptitude) hasOneAptitude = true;
                if (a == SecondAptitude) hasSecondAptitude = true;
            }
            if (hasOneAptitude) haveAptitudes++;
            if (hasSecondAptitude) haveAptitudes++;

            if (Rank < Ranking.Veteran)
                Cost = costTable[haveAptitudes, (int)rank];
        }
        public void IncreaceRank(ICharacter character)
        {
            if (Rank < Ranking.Veteran && character.NotSpendExp >= Cost)
            {
                Rank++;
                character.SpendExpirience += Cost;
                ChangeAdvanceCost(character.Aptitudes);
            }
        }
    }
}
