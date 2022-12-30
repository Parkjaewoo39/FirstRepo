using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatIsOverride
{
    public class Monster
    {
       public class BigMonster
        {
           
            public string bigname;
            public int bighp;
            public int bigdamage;
            public int bigdefence;
            public string bigsound;

            public void BigMove(string move)
            {
                Console.WriteLine("{0}이 등장했다.", move);
                Console.WriteLine("");
                Console.WriteLine("hp{0}\n공격력{1}\n방어력{2}", this.bighp, this.bigdamage, this.bigdefence);

            }

            public void BigAttack(string move, int damage)
            {
                Console.WriteLine("{0} 이(가) \n\n{1}의 공격력으로 앞발을 휘둘렀다.", move, damage);
                Console.WriteLine("");
            }

            public void BigMoveAndAttack()
            {
                this.BigMove(this.bigname);
                this.BigAttack(this.bigname, this.bigdamage);
            }
            public string BigMonsterName()
            {
                return this.bigname;
            }

            public string Name
            {
                get { return this.bigname; }
                private set { this.bigname = value;}                                         //
            }
            public int BigHpValue()
            {
                return this.bighp;
            }
            public int BigDamageValue()
            {
                return this.bigdamage;
            }
            public int BigDefenceValue()
            {
                return this.bigdefence;
            }
            public string BigSoundValue()
            {
                return this.bigsound;
            }
        }
        public class BigBear : BigMonster
        {
            
            public string GetName() 
            {
                return this.bigname;
            }
            //public void SetName(string value_) 
            //{
            //    this.Name = value_;
            //}


            /// <summary>
            /// ///////////////////////////////
            /// </summary>
            public BigBear()
            {
                this.bigname = "큰 곰";
                this.bighp = 300;
                this.bigdamage = 25;
                this.bigdefence = 5;
                this.bigsound = "쿠오오오오엉!";
            }
        }
    }       //class Monster


}
