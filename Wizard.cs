using System;

namespace WalkiCzarodziejow
{
    abstract class Wizard
    {
        protected string Name { get; set; }
        protected int Str { get; set; }
        protected int Hp { get; set; }

        public void SetStats(string Name, int Str, int Hp)
        {
            this.Name = Name;
            this.Str = Str + 5;
            this.Hp = Hp + 10;
        }

        public string GetName()
        {
            return Name;
        }

        public int GetHp()
        {
            if (Hp >= 0)
            {
                return Hp; 
            }
            else
            {
                return 0;
            }
        }

        public bool IsALive()
        {
            if (Hp >= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public abstract int CastSpell();

        public void GetDammage(int dmg)
        {
            Console.Write("{0} otrzymuje {1} obrażeń ",Name,dmg);
            Hp -= dmg;
        }
        
        public void DrinkHealthPotion()
        {
            Console.WriteLine("{0} pije miksturę zdrowie i zyzkuje 8 pkt życia",Name);
            Hp += 8;
        }
    }
}
