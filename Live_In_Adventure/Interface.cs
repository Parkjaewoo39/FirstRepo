using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Live_In_Adventure
{

    
    
    public class Interface
    { }

    public class User
    {
        public void userStatus() 
        {
            //!{유저 시작 랜덤스탯
            Random random = new Random();                               //배열에 담은 것을 무작위로 꺼내기위해 난수 선언
            Random ranStatus = new Random();                            // 각 배열 스테이터스의 최소부터 최대값

            int[] charStatus = new int[6] { 5, 5, 5, 5, 5, 5 };         //힘, 민첩, 지능, 카리스마, 건강, 지혜

            int[] statusSum = new int[6];

            for (int index = 0; index < charStatus.Length; index++)
            {
                int ranS = ranStatus.Next(0, 5 + 1);
                statusSum[index] = charStatus[index] + ranS;
                charStatus[index] = statusSum[index];
            }
            Console.WriteLine(
               "힘 {0} \n" + "민첩 {1}\n" + "지능 {2}\n" +
               "카리스마 {3} \n" + "건강 {4}\n" + "지혜 {5}\n",
               charStatus[0], charStatus[1], charStatus[2],
               charStatus[3], charStatus[4], charStatus[5]);

            //!}유저 시작 랜덤스탯
        }   //userStatus()
        public void userHp() 
        {
            int userHp = 100;
            int userHpMax = userHp;
            int playerHpPer = userHp * 100 / userHp;
            Console.Write("체력 :{0}/{1}",userHp,userHpMax);
            Console.SetCursorPosition(2, 54);
            for (int i = 0; i < playerHpPer / 10; i++)             
            {
                Console.Write("■");                
            }     
            for (int i = 10; playerHpPer / 10 < i ; i -= 1)
            {
                Console.Write("□");               
            }
        }       //userHP()                   

        public void userMental() 
        {
            int userMental = 5;
            int userMentalMax = userMental;
            Console.Write("정신력 : {0}/{1}\n",userMental,userMentalMax);
            Console.SetCursorPosition(2, 56);
            for (int i = 0; i < userMental; i++) 
            {                
                Console.Write("●");
            }
            for (int i = 5; userMental< i; i -= 1)
            {
                Console.Write("◎");
            }
            Console.WriteLine();
        }       //유저Mental()함수       
        
    }   //class User

    /*
    //public class Inventory
    //{

    //    public void useInventory()
    //    {
    //        List<string, int> inventory = new List<string, int>();

    //    }

    //}
    //public class Inventory 
    //{
    //    Dictionary<string, int> inventory = new Dictionary<string, int>();
    //    //준일님 설명
    //    // 이름과 값을 같이 저장하는데 이름을 검색하면 값이 오고, 값을치면 이름이 온다.
    //    //Inventory

    //    void ASd()
    //    {
    //        List<string> inventoryKeys = inventory.Keys.ToList();   //순서대로 찾을때 오래 걸리니깐 리스트에 넣어서 
    //        inventoryKeys.Sort();                                   //정리를 해야 빠르다.

    //        foreach(string keys_ in inventoryKeys)
    //        {
    //            inventory[keys_] 
    //        }
    //    }
    */
    //!{class Item
    class Item
    {
        public string name;
        public int count;
        public int price;
        public string options;
        public Item(string name, int price, string options)
        {
            this.name = name;
            this.price = price;
            this.options = options;
            this.count = 1;
        }
        public void showList()
        {
            string listName = name;
            for (int i = 0; i < 12 - Encoding.Default.GetByteCount(listName); i++)
            {
                listName += "  ";
            }
            Console.WriteLine($"{listName}{price}골드");
        }
        public Item(Item item)
        {
            this.name = item.name;
            this.price = item.price;
            this.options = item.options;
            count = 1;
        }
    }   
    //!}class Item

    class Inventory
    {
        public static List<Item> itemList = new List<Item>();
        public Inventory()
        {
            while (true)
            {
                Console.WriteLine("========인벤토리========");
                Console.WriteLine("1.장비 추가하기 \n2.장비 삭제하기\n3.장비 목록 출력\n4. 이전단계로 이동");
                Console.WriteLine("========================");
                Console.Write("입력 :");
                string input = Console.ReadLine();
                if (input == "1")
                {
                    Console.WriteLine("장비 추가");
                    Console.WriteLine("추가할 장비를 이름 입력");
                    string ItemType = Console.ReadLine();
                    Item foundItem = itemList.Find(x => x.name == ItemType);
                    if (foundItem == null)
                    {
                        itemList.Add(new Item(ItemType, 0, "장비"));
                    }
                    else if (foundItem != null)
                    {
                        foundItem.count++;
                    }
                    else
                    {
                        Console.WriteLine("잘못입력");
                    }
                    continue;
                }
                if (input == "2")
                {
                    Console.WriteLine("===========장비 삭제하기===========");
                    Console.WriteLine("1. 삭제할 장비명 입력 \n2. 이전단계");
                    Console.WriteLine("===================================");
                    Console.Write("입력 :");
                    string select = Console.ReadLine();
                    if (select == "1")
                    {
                        Console.WriteLine("삭제할 장비명 입력");
                        string Delete = Console.ReadLine();
                        Item deleteItem = itemList.Find(x => x.name == Delete);
                        if (deleteItem == null)
                        {
                            Console.WriteLine("장비가 없습니다.");
                            continue;
                        }
                        if (deleteItem.count > 1)
                        {
                            deleteItem.count--;
                        }
                        else if (deleteItem != null)
                        {
                            Console.WriteLine("{0} 이(가) 삭제되었습니다.", deleteItem.name);
                            itemList.Remove(deleteItem);
                            continue;
                        }
                        else if (select == "2")
                        {
                            continue;
                        }
                    }
                }
                else if (input == "3")
                {
                    Console.WriteLine("//장비 목록//");
                    if (itemList.Count == 0)
                    {
                        Console.WriteLine("장비가 없습니다.");
                        continue;
                    }
                    for (int i = 0; i < itemList.Count; i++)
                    {
                        Console.WriteLine($"{itemList[i].name} : {itemList[i].count}개");
                    }
                    continue;
                }
                else if (input == "4")
                {
                    break;
                    //Console.WriteLine("이전단계(네/아니오)");
                    //string askOpinion = Console.ReadLine();
                    //if (askOpinion == "네")
                    //{
                    //    Console.WriteLine("이전 단계로 이동");
                    //    Console.ReadKey();
                    //}
                    //else if (askOpinion == "아니오")
                    //{
                    //    continue;
                    //}
                    //else
                    //{
                    //    Console.WriteLine("잘못입력");
                    //}
                }
                else
                {
                    Console.WriteLine("잘못입력");
                }
            }
        }
    }
    class Command
    {
        public static Shop shop = new Shop();
        public Command()
        { //필드 지역변수 메서드
            while (true)
            {
                Console.WriteLine("============메인 메뉴===========");
                Console.WriteLine("1. 인벤토리 확인\n2. 상점으로 이동\n3. 프로그램을 종료합니다.");
                Console.WriteLine("================================");
                Console.Write("입력 :");
                string input = Console.ReadLine();
                if (input == "1")
                {
                    Inventory inventory = new Inventory();
                }
                else if (input == "2")
                {
                    shop.ShopMenu();
                }              
                else if (input == "3")
                {
                    Console.WriteLine("프로그램을 종료하시겠습니까?(네/아니오)");
                    string select = Console.ReadLine();
                    if (select == "네")
                    {
                        Console.WriteLine("프로그램을 종료합니다.");
                        break;
                    }
                    else if (select == "아니오")
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("잘못입력");
                    }
                }
            }
        }
    }

    class Shop
    {
        ConsoleColor[] color = { ConsoleColor.White, ConsoleColor.Yellow, ConsoleColor.Red, ConsoleColor.Green, ConsoleColor.Blue, ConsoleColor.Gray, ConsoleColor.DarkGray };
        //0 하양, 1 노랑, 2 빨강, 3 초록, 4 파랑, 5 회색, 6 어두운 회색
        void concol(int num) //글자색 변경 함수
        {
            Console.ForegroundColor = color[num];
        }
        public List<Item> shopItemList;
        public Shop()
        {
            shopItemList = new List<Item>();
            shopItemList.Add(new Item("부서진 대검", 50, "마법사가 애용할 것만 같은 나무로된 지팡이"));
            shopItemList.Add(new Item("장검", 80, "긴검"));
            shopItemList.Add(new Item("단검", 20, "짧은검"));
            shopItemList.Add(new Item("활", 100, "당겨서 쏘는 목재의 탄성을 확인할 수 있는 장인의 활..."));
            shopItemList.Add(new Item("지팡이", 50, "마법사가 애용할 것만 같은 나무로된 지팡이"));
            shopItemList.Add(new Item("장검", 80, "긴검"));
            shopItemList.Add(new Item("단검", 20, "짧은검"));
            shopItemList.Add(new Item("활", 100, "당겨서 쏘는 목재의 탄성을 확인할 수 있는 장인의 활..."));
            shopItemList.Add(new Item("가죽갑옷", 150, "가죽으로 만든 갑옷"));
            shopItemList.Add(new Item("나무방패", 160, "나무깎아 만든 방패"));
            shopItemList.Add(new Item("철갑옷", 170, "포항제철에서 만든 갑옷"));
            shopItemList.Add(new Item("헤라클레스바지", 180, "헤라클레스 스타일의 바지"));
            shopItemList.Add(new Item("송편방패", 190, "송편먹다가 체해서 나온 방패"));
            shopItemList.Add(new Item("영등포구제바지", 200, "영등포에서 누가입던 바지"));
            shopItemList.Add(new Item("설렁탕신발", 210, "설렁탕에 빠진 신발"));
            shopItemList.Add(new Item("마이보틀", 220, "내 물병"));
            shopItemList.Add(new Item("스타벅스커피가루", 230, "최고의 가루"));
            shopItemList.Add(new Item("저녁밥", 240, "엄마 밥좀줘"));
            shopItemList.Add(new Item("대일밴드", 250, "편의점에서도 팜"));
            shopItemList.Add(new Item("빨간물약", 260, "상처회복제"));
            shopItemList.Add(new Item("논어", 270, "공자 최고"));
            shopItemList.Add(new Item("늑대가죽", 280, "늑대 아파"));
        }
        public int money;
        public bool myMoney(int money)
        {
            if (money < this.money)
            {
                this.money -= money;
                return true;
                Console.WriteLine(money);
            }
            else
            {
                return false;
            }
        }
        //public void Job()
        //{
        //    money += 100;
        //    Console.WriteLine($"알바를 해서 {money}골드가 지급됩니다.");
        //}
        public void ItemBuy(Item foundItem)
        {
            //
            //새로 생성해서 인벤토리에 넣어야함
            //인벤토리 아이템 리스트에 찾은 아이템이 있냐 없냐
            
            Item foundInventoryItem = Inventory.itemList.Find(x => x.name == foundItem.name);
            if (foundInventoryItem == null)
            {
                Inventory.itemList.Add(new Item(foundItem));
            }
            else
            {
                foundInventoryItem.count++;
            }
            
            Console.WriteLine(foundItem.name + "을 구매하였습니다.");
            money -= shopItemList[0].price;
            Console.WriteLine($"가격: {shopItemList[0].price} 남은 골드: {money}");
           
        }
        public void ItemSale(string name)
        {
            Item Item = shopItemList.Find(x => x.name == name);
            if (Item.count == 1)
            {
                myMoney((int)(Item.price * 0.7));
                Console.WriteLine($"{(Item.price * 0.7)}골드에 {Item.name}을 판매했습니다.");
                shopItemList.Remove(Item);
            }
            else 
            {
                Console.WriteLine("제대로 입력 하시오 ");
                
            }
        }
        public void ShopMenu()
        {
            while (true)
            {
                concol(1);
                Console.WriteLine("==========상점==========");
                concol(5);
                Console.WriteLine("1. 내 소지금 확인 \n2. 아이템 목록을 확인 \n3. 아이템 구매 \n4. 아이템 판매 \n5. 이전 단계");
                concol(1);
                Console.WriteLine("========================");
                concol(5);
                Console.Write("입력 :");
                string select = Console.ReadLine();
                if (select == "1")
                {
                    Console.WriteLine("//나의 소지금//");
                    Console.WriteLine("소지금: {0} 골드", money);
                }
                else if (select == "2")
                {
                    foreach (Item item in shopItemList)
                    {
                        item.showList();
                    }
                }
                else if (select == "3")
                {
                    Console.WriteLine("//아이템 구매//");
                    Console.WriteLine("구매를 원하시는 장비명을 입력해주세요.");
                    Console.Write("입력: ");
                    string input = Console.ReadLine();
                    Item foundItem = shopItemList.Find(x => x.name == input);
                    if (foundItem == null)
                    {
                        concol(2);
                        Console.WriteLine("잘못입력");
                        concol(5);
                    }
                    else if (myMoney(foundItem.price))
                    {
                        ItemBuy(foundItem);
                    }
                    else
                    {
                        Console.WriteLine("===================");
                        Console.WriteLine("골드가 부족합니다.");
                        Console.WriteLine("===================");
                    }
                }
                else if (select == "4")
                {
                    Console.WriteLine("판매할 아이템의 이름을 입력해주세요");
                    string input = Console.ReadLine();
                    ItemSale(input);
                }
                else if (select == "5")
                {
                       break;
                    //Console.WriteLine("이전단계로 가시겠습니까?");
                    //string input = Console.ReadLine();
                    //if (input == "네")
                    //{
                    //}
                    //else if (input == "아니오")
 
                    //{
                    //    continue;
                    //}
                }
            }
        }
    }
     

    //}

}
