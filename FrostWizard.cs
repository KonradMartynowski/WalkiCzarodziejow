using System;

namespace WalkiCzarodziejow
{
    class FrostWizard : Wizard
    {
        public override int CastSpell()
        {
            return CastFrostBollt();
        }

        private int CastFrostBollt()
        {
            Console.Write("{0} wystrzelił kulę lodu - ", Name);
            return Str/2;
        }
    }
}
