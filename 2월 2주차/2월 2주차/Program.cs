using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2월_2주차
{
    class Program
    {
        
        private static int plus(int s,int t)
        {
            int resultnumber = s + t;
            return resultnumber;
        }
        private static int minus(int s, int t)
        {
            int resultnumber = s - t;
            return resultnumber;
        }
        private static int multipl(int s, int t)
        {
            int resultnumber = s * t;
            return resultnumber;
        }
        private static int div(int s, int t)
        {
            int resultnumber = s / t;
            return resultnumber;
        }

        private static void ConnectWithMyNEtwork()
        {
            System.Console.WriteLine("ddddd");//내용
        }
        class student
        {
            public string name;
            public int age;
            public void writelinestudentinfo()
            {
                System.Console.WriteLine($"학생의 이름은 {name}");
                System.Console.WriteLine($"학생의 나이는 {age}");
            }
            public void inputstudentinfo()
            {
                System.Console.WriteLine("{0}", name);
                System.Console.WriteLine("{0}", age);
            }
        }
        class foods
        {
            public string[] foodlist;
            public void inputfoodlist()
            {
                foodlist = new string[5];
                for(int indexnumber=0; indexnumber < 5; indexnumber++)
                {
                    System.Console.WriteLine("음식이름: ");
                    foodlist[indexnumber] = System.Console.ReadLine();
                }
                System.Console.WriteLine();

                string foodname;
                System.Console.WriteLine("추가음식이름: ");
                foodname = System.Console.ReadLine();

                for(int indexnumber=0; indexnumber<5; indexnumber++)
                {
                    if (foodlist[indexnumber] == foodname)
                    {
                        foodlist[indexnumber] = "";
                        break;
                    }
                }

                for (int indexnumber = 0; indexnumber < 5; indexnumber++)
                {
                    System.Console.WriteLine($"{ foodlist[indexnumber] }");
                }
            }
            
        }
        class ages
        {
            public int year,h;
            public string hh= System.Console.ReadLine();
            public void agelist()
            {
                h = Convert.ToInt32(hh);
                
                year = (2023 - h+1)%12;
                if (year == 0)
                {
                    System.Console.WriteLine("원숭이띠");
                }
                else if (year == 1)
                {
                    System.Console.WriteLine("닭띠");
                }
                else if (year == 2)
                {
                    System.Console.WriteLine("개띠");
                }
                else if (year == 3)
                {
                    System.Console.WriteLine("돼지띠");
                }
                else if (year == 4)
                {
                    System.Console.WriteLine("쥐띠");
                }
                else if (year == 5)
                {
                    System.Console.WriteLine("소");
                }
                else if (year == 6)
                {
                    System.Console.WriteLine("호랑이띠");
                }
                else if (year == 7)
                {
                    System.Console.WriteLine("토끼띠");
                }
                else if (year == 8)
                {
                    System.Console.WriteLine("용띠");
                }
                else if (year == 9)
                {
                    System.Console.WriteLine("뱀띠");
                }
                else if (year == 10)
                {
                    System.Console.WriteLine("말띠");
                }
                else
                {
                    System.Console.WriteLine("양띠");
                }
            }
        }
        //class game
        //{
        //    private string[] abc = new string[3] { "a", "b", "c" };


        //    private void searchgame()
        //    {
        //        string searchgamename = System.Console.ReadLine();
        //        for(int index = 0; index < 3; index++)
        //        {
        //            if (abc[index]==searchgame)
        //            {
        //                System.Console.WriteLine("있습니다.");
        //                break;
        //            }
        //            if (index == 2)
        //            {
        //                System.Console.WriteLine("없습니다.");
        //                break;
        //            }
        //        }
        //    }
        //}
        class School
        {
            protected string SchoolName;
            protected void WriteSchoolName()
            {
                System.Console.WriteLine($"학교 이름: {SchoolName}");
            }
        }
        class Classes : School
        {
            private string ClassName="3반";
            public void WriteSchoolInfo(string _schoolName)
            {
                SchoolName = _schoolName;
                WriteSchoolName();
                System.Console.WriteLine($"내 반은 {ClassName}");
            }
        }
        class Rest
        {
            protected string[] menus;
            protected int[] menusPrice;
            public void TakeMoney(int money)
            {
                System.Console.WriteLine($"돈 내기: {money}");
            }
            public void OderMenu(int number)
            {
                System.Console.WriteLine($"주문: {menus[number]}");
                TakeMoney(menusPrice[number]);
            }
            public void ShowMenu()
            {
                System.Console.Write($"종류: ");
                for(int index = 0; index < menus.Count(); index++)
                {
                    System.Console.Write($"{menus[index]} ");
                }
            }
        }
        class Korean : Rest
        {
            public void MenuSetting()
            {
                menus = new string[2];
                menus[0] = "밥";
                menus[1] = "국";

                menusPrice = new int[2];
                menusPrice[0] = 1000;
                menusPrice[1] = 8000;
            }
        }
        class japanese : Rest
        {
            public void MenuSetting()
            {
                menus = new string[2];
                menus[0] = "초밥";
                menus[1] = "우동";

                menusPrice = new int[2];
                menusPrice[0] = 15000;
                menusPrice[1] = 8000;
            }
        }
        class Chinese : Rest
        {
            public void MenuSetting()
            {
                menus = new string[2];
                menus[0] = "짜장면";
                menus[1] = "짬뽕";

                menusPrice = new int[2];
                menusPrice[0] = 4500;
                menusPrice[1] = 6000;
            }
        }
        class Books
        {
            public string bookName, bookWriter, Publisher;
           
        }
        class Library
        {
            Books[] books = new Books[99];
            public void Inputbooksdata(int Bookcount)
            {
                books[Bookcount] = new Books();
                System.Console.Write("제목: ");
                books[Bookcount].bookName = System.Console.ReadLine();
                System.Console.Write("지은이: ");
                books[Bookcount].bookWriter = System.Console.ReadLine();
                System.Console.Write("출판사: ");
                books[Bookcount].Publisher = System.Console.ReadLine();

                System.Console.WriteLine("--------------------------");
            }
            public bool askKeepPutdata()
            {
                System.Console.Write("계속 입력할까요? (y/n) : ");
                string userAnser = System.Console.ReadLine();
                if (userAnser == "Y" || userAnser == "y")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            public void Searchtitle()
            {
                System.Console.Write("찾고싶은 제목 입력: ");
                string userAnser = System.Console.ReadLine();
                for (int indexnum = 0; indexnum < books.Count(); indexnum++)
                {
                    if (books[indexnum] == null)
                    {
                        System.Console.WriteLine("못찾았습니다.");
                        break;
                    }
                    else if (books[indexnum].bookName == userAnser)
                    {

                    }
                }
            }
        }
        class STudent
        {
            public string sname;
            public string sclass;
        }
        class classes
        {
            STudent[] student = new STudent[20];

            public void studentlist(int studentcount)
            {
                student[studentcount] = new STudent();
                System.Console.Write("반: ");
                student[studentcount].sclass = System.Console.ReadLine();
                System.Console.Write("이름: ");
                student[studentcount].sname = System.Console.ReadLine();
                System.Console.WriteLine("--------------------------");
            }

            public bool askKeepPutdata()
            {
                System.Console.Write("계속 입력할까요? (y/n) : ");
                string userAnser = System.Console.ReadLine();
                if (userAnser == "Y" || userAnser == "y")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            public void Searchtitle()
            {
                System.Console.Write("찾고싶은 반 입력: ");
                string userAnser = System.Console.ReadLine();
                for (int indexnum = 0; indexnum < student.Count(); indexnum++)
                {
                    if (student[indexnum] == null)
                    {
                        System.Console.WriteLine("못찾았습니다.");
                        break;
                    }
                    else if (student[indexnum].sclass == userAnser)
                    {
                        System.Console.WriteLine(student[indexnum].sname);

                    }
                }
            }
        }
 
        static void Main(string[] args)
        {
            //학생 클래스를 만들고
            //Classes 란 클래스를 만들어서
            //학생들의 이름과 반을 입력받아 배열로 저장한다.
            //Classes 클래스에서 숫자를 입력하면
            //입력숫자와 같은 반에 들어간 모든 학생을 출력해준다.(이름만)
            classes sTudent = new classes();
            int countBookNumber = 0;
            do
            {
                sTudent.studentlist(countBookNumber);
                countBookNumber++;
            } while (sTudent.askKeepPutdata());
            sTudent.Searchtitle();



            //서점 클래스에 제목, 지은이, 출판사를 입력받아 책데이터를 쌓는다.
            //특정 키를 입력받을때까지 지속되며, 특정키 입력을 받으면
            //제목을 입력받고 제목에 맞는 지은이, 출판사를 순서대로 출력해준다.
            Library library = new Library();
            //int countBookNumber = 0;
            do
            {
                library.Inputbooksdata(countBookNumber);
                countBookNumber++;
            } while (library.askKeepPutdata());                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         



            // 식당 클래스를 상속받는 한식/양식/중식

            //식당 클래스가 전체적으로
            //가질 정보들을 갖는다
            //(돈받기/주문한 음식주기)

            //각각 식당들을 메뉴가 모두 다르다
            //한식의 삼계탕 1만원 등등 다르다
            //가고싶은 식당을 입력받고, 메뉴를 모두 띄워준다
            //유저는 메뉴를 입력하고, 내야할 가격, 고른 메뉴를 띄워준다.
            Korean koreanFood = new Korean();
            koreanFood.MenuSetting();
            koreanFood.ShowMenu();

            System.Console.WriteLine();
            System.Console.Write("먹을 음식은 몇번? : ");
            int inputMenu = Convert.ToInt32(System.Console.ReadLine()) - 1;
            koreanFood.OderMenu(inputMenu);

            japanese japaneseFood = new japanese();
            japaneseFood.MenuSetting();
            japaneseFood.ShowMenu();

            System.Console.WriteLine();
            System.Console.Write("먹을 음식은 몇번? : ");
            int inputMenu1 = Convert.ToInt32(System.Console.ReadLine()) - 1;
            japaneseFood.OderMenu(inputMenu);

            Chinese ChineseFood = new Chinese();
            ChineseFood.MenuSetting();
            ChineseFood.ShowMenu();

            System.Console.WriteLine();
            System.Console.Write("먹을 음식은 몇번? : ");
            int inputMenu2 = Convert.ToInt32(System.Console.ReadLine()) - 1;
            ChineseFood.OderMenu(inputMenu);

            //public - 외부에서 자유롭게
            //private - 나만 쓸수있다
            //protected
            Classes myNewClas = new Classes();
 



            //게임들을 보유하고 있는 게임 클래스를 제작한다.
            //게임을 입력하면 배열에 값이 있는지 없는지 제작한다.
            //game games = new game();
            //games.searchgame();


            //나이에 해당하는 띠를 출력해줄 클래스를 만든다.
            //탄생 년도를 입력하면 해당 띠를 출력한다.
            //출력할때 만 나이도 같이 계산되어 출력된다.
            ages ages = new ages();
            ages.agelist();

            //4. 먹을것 클래스를 만들어서 음식을 여러개 입력받습니다.(readline())
            //5개의 음식을 입력받습니다.
            //추가로 음식을 입력받는데, 5개의 음식중에 이미 있는 음식이면 제외합니다.
            //예) a,b,c,d,e가 있는데 추가로 b가 입력됨
            //->a,c,d,e가 된다.

            foods foods = new foods();
            foods.inputfoodlist();
            

            //학생 클래스를 만들어서 for문으로 학생 여럿을 입력받는다.
            student[] students=new student[2];
            for(int i = 0; i < 2; i++)
            {
                students[i] = new student();
                students[i].inputstudentinfo();
            }




            student astudent = new student();
            astudent.name = "박지영";
            astudent.age = 20;
            System.Console.WriteLine($"a학생의 이름은 {astudent.name}");
            //astudent.writelinestudentinfo();
            astudent.inputstudentinfo();


            //1. 학생클래스를 만들어서 학생 하나의 정보를 입력받는다(readline)
            //2. 학생클래스를 만들어서 메소드로 학생 하나의 정보를 입력받는다.

            astudent.name = System.Console.ReadLine();
            System.Console.WriteLine($"a학생의 이름은 {astudent.name}");
            astudent.age = Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine($"a학생의 나이는 {astudent.age}");

            string nn1, nn2;
            nn1 = System.Console.ReadLine();
            int s = Convert.ToInt32(nn1);
            string s3 = System.Console.ReadLine();
            nn2 = System.Console.ReadLine();
            int t = Convert.ToInt32(nn2);




            if (s3 == "+")
            {
                int NewInt = plus(s, t);
                System.Console.WriteLine(NewInt);
            }
            else if (s3 == "-")
            {
                int NewInt = minus(s, t);
                System.Console.WriteLine(NewInt);
            }
            else if (s3 == "*")
            {
                int NewInt = multipl(s, t);
                System.Console.WriteLine(NewInt);
            }
            else if (s3 == "/")
            {
                int NewInt = div(s, t);
                System.Console.WriteLine(NewInt);
            }
            else
            {
                System.Console.WriteLine("잘못된 부호입니다.");
            }
            //#region//키입력하는코드
            ////주석 단축키: ctrl+k+c, 주석풀기단축기: ctrl+k+u
            //ConsoleKeyInfo cski;
            //int x = 10;
            //int y = 10;
            //#endregion
            //while (true)
            //{
            //    Console.Clear();
            //    Console.SetCursorPosition(x, y);
            //    Console.Write("#");
            //    cski = Console.ReadKey(true);

            //    switch (cski.Key)
            //    {
            //        case ConsoleKey.LeftArrow:
            //            x--;
            //            break;
            //        case ConsoleKey.RightArrow:
            //            x++;
            //            break;
            //        case ConsoleKey.UpArrow:
            //            y--;
            //            break;
            //        case ConsoleKey.DownArrow:
            //            y++;
            //            break;

            //    }
            //}
            string xx, yy;
            xx = System.Console.ReadLine();
            yy = System.Console.ReadLine();
            int a = Convert.ToInt32(xx);
            int b = Convert.ToInt32(yy);

            if (a + b <= 10)
            {
                System.Console.WriteLine("10이하입니다.");
            }
            else if (a + b <= 20)
            {
                System.Console.WriteLine("20이하입니다.");
            }
            else if (a + b <= 30)
            {
                System.Console.WriteLine("30이하입니다.");
            }
            else
            {
                System.Console.WriteLine("30보다 큽니다.");
            }
            #region 홀수짝수
            if (a % 2 == 0 && b % 2 == 0)
            {
                System.Console.WriteLine("a는 짝수 b는 짝수");
            }
            else if (a % 2 == 0 && b % 2 == 1)
            {
                System.Console.WriteLine("a는 짝수 b는 홀수");
            }
            else if (a % 2 == 1 && b % 2 == 0)
            {
                System.Console.WriteLine("a는 홀수 b는 짝수");
            }
            else
            {
                System.Console.WriteLine("a는 홀수 b는 홀수");
            }
            #endregion
            System.Console.WriteLine("------------------------------------");

            for (int u = 0; u < 5; u++)
            {
                System.Console.WriteLine("hello");
            }
            int r = 0;
            while (r < 10)
            {
                System.Console.WriteLine("##");
                r++;
            }
            System.Console.WriteLine("------------------------------------");
            string rr = System.Console.ReadLine();
            int qw = Convert.ToInt32(rr);
            int num;
            for (num = 0; num < qw; num++)
            {
                System.Console.WriteLine("@@");
            }
            System.Console.WriteLine("------------------------------------");

            ConnectWithMyNEtwork();

         
            
        }
        
    }
}

