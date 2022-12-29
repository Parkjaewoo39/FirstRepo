using System;

namespace Mosterclass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kight kight = new Kight();      //플레이어 기사 가져오고                                

            BigMonster bigMonS = new BigMonster();          //몹 풀러오는것

            PlayerStatus playerS = new PlayerStatus();      //플레이어 스탯

            BigMonsterStatus bigMosS = new BigMonsterStatus();      //몬스터 스탯

            Random ran = new Random();

            BigBear bear = new BigBear();

            int mobRan = ran.Next(0, 2 + 1);           //몹이 랜덤하게 나오게 난수

            int[] monArr = new int[3] { 1, 2, 3 };             //생성자int형 대조.       

            int[] playerStatus = new int[3];              //플레이어는 한명
            playerStatus[0] = kight.PlayerHpValue();
            playerStatus[1] = kight.PlayerDamageValue();
            playerStatus[2] = kight.PlayerDefenceValue();


            int[] bigMosStatus = new int[3];      //몬스터들의 값을 배열에 담아서 가져가기
            bigMosStatus[0] = bigMosS.BigHpValue();
            bigMosStatus[1] = bigMosS.BigDamageValue();
            bigMosStatus[2] = bigMosS.BigDefenceValue();


            string mobname = string.Empty;
            string playname = string.Empty;

            int hpValue = 0;

            //전투를 시작 1 ,2 도망ㄱ
            //한번씩 때리기
            int userInput = 0;
            Console.WriteLine("{0}이(가) 등장했다.\n{1}\n\n",
                    bear.BigMonsterName(), bear.BigSoundValue());

            Console.WriteLine("전투 시작 1\n도망을 치다 2 : ");
            userInput = Convert.ToInt32(Console.ReadLine());

            if (userInput == 1)
            {
                Console.WriteLine("――――――――――――");

                Console.WriteLine("{0}이(가) 등장했다.\n{1}",
                    bear.BigMonsterName(), bear.BigSoundValue());

                Console.WriteLine("\n체력 {0}\n공격력{1}\n방어력{2}",
                    bear.BigHpValue(), bear.BigDamageValue(), bear.BigDefenceValue());

                Console.WriteLine("");
                Console.WriteLine("――――――――――――");

                Console.WriteLine("플레이어 {0}의 상태", kight.PlayerName());

                Console.WriteLine("\n체력 {0}\n공격력{1}\n방어력{2}",
                    kight.PlayerHpValue(), kight.PlayerDamageValue(), kight.PlayerDefenceValue());

                Console.WriteLine("");
                Console.WriteLine("――――――――――――");


                int userInput2 = 0;
                Console.WriteLine("1.공격하기 \n2.막기(방어가 두배) : ");
                int.TryParse(Console.ReadLine(), out userInput2);
                //userInput2 = Convert.ToInt32(Console.ReadLine());


                if (userInput2 == 1)
                {
                    if (playerStatus[0] > 0)
                    {
                        Console.WriteLine("플레이어 {0} 이(가) 공격을 했습니다!\n\n", kight.PlayerName());
                        Console.WriteLine("{0}의 데미지를 주었습니다.", kight.PlayerDamageValue());

                        Console.WriteLine("{0}이 공격을 맞았습니다.\n{1}", bear.BigMonsterName(), bear.BigSoundValue());
                        bigMosStatus[0] -= playerStatus[1] - bigMosStatus[2];

                        Console.WriteLine("{0}이(가) 반격을 했습니다.\n", bear.BigMonsterName());
                        Console.WriteLine("플레이어는 {0}의 데미지를 받았습니다.", bear.BigDamageValue());

                        playerStatus[0] -= bigMosStatus[1] - playerStatus[2];

                        Console.WriteLine("")


                    }
                    else if (bigMosStatus[0] > 0)
                    {
                        Console.WriteLine("플레이어 {0} 이(가) 공격을 했습니다!\n\n", kight.PlayerName());
                        Console.WriteLine("{0}의 데미지를 주었습니다.", kight.PlayerDamageValue());

                        Console.WriteLine("{0}이 공격을 맞았습니다.\n{1}", bear.BigMonsterName(), bear.BigSoundValue());

                        Console.WriteLine("{0}이(가) 반격을 했습니다.\n", bear.BigMonsterName());
                        Console.WriteLine("플레이어는 {0}의 데미지를 받았습니다.", bear.BigDamageValue());

                    }
                    else if()
                    {
                        
                    }
                }

                else if (userInput2 == 2)
                {
                    Console.WriteLine("플레이어는 방어를 했다!");

                }




            }
            else
            {
                Console.WriteLine("무사히 도망쳤다!");
            }

            switch (monArr[mobRan])
            {
                case 0:
                    bigMonS = new BigBear();
                    break;
                case 1:
                    bigMonS = new KingSlime();
                    break;
                case 2:
                    bigMonS = new SkelletonMagicion();
                    break;
            }
        }
        class Player        //플레이어 모체 생성자 
        {
            public string playername;
            public int playerhp;
            public int playerdamage;
            public int playerdefence;

            protected void PlayerMove(string playername)
            {
                Console.WriteLine("{0}가 적을 만났다.\n}", playername);
                Console.WriteLine("");
                Console.WriteLine("hp{0}\n공격력{1}\n방어력{2}\n", this.playerhp, this.playerdamage, this.playerdefence);

            }
            protected void PlayerAttack(string playername, int playerdamage)
            {
                Console.WriteLine("{0}가 적을\n{1}의 공격력으로 때렸다.\n\t", playername, playerdamage);

            }

            public void PlayerMoveAndAttack()
            {
                this.PlayerMove(this.playername);
                this.PlayerAttack(this.playername, this.playerdamage);
            }

            public string PlayerName()
            {
                return this.playername;
            }
            public int PlayerHpValue()
            {
                return this.playerhp;
            }
            public int PlayerDamageValue()
            {
                return this.playerdamage;
            }
            public int PlayerDefenceValue()
            {
                return this.playerdefence;
            }

        }
        class PlayerStatus : Player
        {
            public void PlyaerStatus()
            {
                PlayerName();
                PlayerHpValue();
                PlayerDamageValue();
                PlayerDefenceValue();
            }
        }

        class Kight : Player //플레이어 자식 생성자
        {
            public Kight()
            {
                this.playername = "기사";
                this.playerhp = 500;
                this.playerdamage = 30;
                this.playerdefence = 15;
            }

        }
        class Magicion : Player
        {
            public Magicion()
            {
                this.playername = "마법사";
                this.playerhp = 300;
                this.playerdamage = 50;
                this.playerdefence = 5;
            }

        }

        class BigMonster
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

        }       //큰 몬스터
        class BigMonsterStatus : BigMonster
        {
            public void MosterStatus()
            {
                BigMonsterName();
                BigHpValue();
                BigDamageValue();
                BigDefenceValue();
                BigSoundValue();
            }
        }

        class BigBear : BigMonster
        {
            public BigBear()
            {
                this.bigname = "큰 곰";
                this.bighp = 300;
                this.bigdamage = 25;
                this.bigdefence = 5;
                this.bigsound = "쿠오오오오엉!";
            }
        }
        class KingSlime : BigMonster
        {
            public KingSlime()
            {
                this.bigname = "킹 슬라임";
                this.bighp = 500;
                this.bigdamage = 50;
                this.bigdefence = 10;
                this.bigsound = "(몰캉몰캉)";
            }
        }

        class SkelletonMagicion : BigMonster
        {
            public SkelletonMagicion()
            {
                this.bigname = "해골 마법사";
                this.bighp = 420;
                this.bigdamage = 30;
                this.bigdefence = 8;
                this.bigsound = "달그락 달그락";
            }
        }
    }
}
