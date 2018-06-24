using System;

namespace WalkiCzarodziejow
{
    class FireWizard : Wizard
    {

        public override int CastSpell()
        {
            return CastFireBall();
        }

        private int CastFireBall()
        {
            Console.Write("{0} wystrzelił kulę ognia - ",Name);
            return Str/2;
        }
    }
}
