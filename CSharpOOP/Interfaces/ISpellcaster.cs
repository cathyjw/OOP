using Characters;
using Characters.Warriors;
using System;

namespace CSharpOOP.Interfaces
{
    interface ISpellcaster
    {
        int Mana { get; set; }

        void CastSpell(Character character);
    }
}
