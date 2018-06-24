using System;

namespace WalkiCzarodziejow
{
    class WoodoShaman : Wizard
    {
        public override int CastSpell()
        {
            return CastCurse();
        }

        private int CastCurse()
        {
            Console.Write("{0} rzucił klątwę - ", Name);
            return Str/2;
        }
    }
}
