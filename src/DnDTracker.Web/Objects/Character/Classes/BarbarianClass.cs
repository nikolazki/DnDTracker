﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace DnDTracker.Web.Objects.Character.Classes
{
    public class BarbarianClass : ICharacterClass
    {
        public CharacterClassType Type { get; set; }
        public List<CharacterSubClassType> SubTypes { get; set; }

        public BarbarianClass()
        {
            Type = CharacterClassType.Barbarian;
            SubTypes = new List<CharacterSubClassType>
            {
                CharacterSubClassType.PathOfTheBerserker,
                CharacterSubClassType.PathOfTheTotemWarrior
            };
        }
    }
}
