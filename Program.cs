class Program
{
    static string Question = "";
    static string JavobA = "";
    static string JavobB = "";
    static string JavobC = "";
    static string JavobD = "";
    static string correctAnswer = "";
    public static void Main()
    {
        int Menu;
        do
        {
            Menu = testMenu();
            if(Menu == 1)
            {
                DefaultTest();
            }
            else if(Menu == 2)
            {
                AddTest();
            }
            else if(Menu == 3)
            {
                System.Console.WriteLine("Savol: " + Question);
                System.Console.WriteLine("A)Javob: " + JavobA);
                System.Console.WriteLine("B)Javob: " + JavobB);
                System.Console.WriteLine("C)Javob: " + JavobC);
                System.Console.WriteLine("D)Javob: " + JavobD);
            }
            else if(Menu == 4)
            {
                inputTest();
                System.Console.WriteLine("Sizning testingiz muvaffaqqiyatli o'zgartirildi...");
            }
            else if(Menu == 5)
            {
                System.Console.WriteLine("Chiqish uchun biror tugmani bosing...");
                Console.ReadKey();
            }
            else
            {
                System.Console.WriteLine("Siz xato menu kiritdingiz bunday menu yo'q");
                testMenu();
            }
        }
        while(Menu != 5);

        static void AddTest()
        {
            while (true)
            {
                inputTest();

                if(Question.Trim().Length > 0 && JavobA.Trim().Length > 0 && JavobB.Trim().Length > 0 && JavobC.Trim().Length > 0 && JavobD.Trim().Length > 0)
                {
                    System.Console.WriteLine("Sizning testingiz muvofaqqiyatli qo'shildi!");
                    break;
                }
                else
                {
                    System.Console.WriteLine("Test yuklashdi muammo yuzaga keldi");
                }
            }
        }

        static void inputTest()
        {
            Console.Write("Savol kiriting: ");
            Question = Console.ReadLine()!;
            Console.Write("A) javobni kiriting: ");
            JavobA = Console.ReadLine()!;
            Console.Write("B) javobni kiriting: ");
            JavobB = Console.ReadLine()!;
            Console.Write("C) javobni kiriting: ");
            JavobC = Console.ReadLine()!;
            Console.Write("D) javobni kiriting: ");
            JavobD = Console.ReadLine()!;
            Console.Write("To'g'ri javobni kiriting: ");
            correctAnswer = Console.ReadLine()!;
        }

        static void DefaultTest()
        {
            int keyingiSavol = 1;
            int correctAnswerCount = 0;
            string Javob;
            key:
            if(keyingiSavol == 1)
            {
                System.Console.WriteLine("1.C# da Contains methodi nima vazifani bajaradi?");
                System.Console.WriteLine("A)Bilmiman");
                System.Console.WriteLine("B)Ichida bor yoqligini tekshirib beradi");
                System.Console.WriteLine("C)2 ta string ni bir biriga qo'shib beradi");
                System.Console.WriteLine("D)Hamma javob to'g'ri");
                System.Console.WriteLine();
                Javob = Console.ReadLine()!;
                if(Javob.ToUpper() == "B")
                {
                    correctAnswerCount++;
                }
                keyingiSavol++;
                goto key;
            }
            if(keyingiSavol == 2)
            {
                System.Console.WriteLine("1.C# da Contains methodi nima vazifani bajaradi?");
                System.Console.WriteLine("A)Bilmiman");
                System.Console.WriteLine("B)Ichida bor yoqligini tekshirib beradi");
                System.Console.WriteLine("C)2 ta string ni bir biriga qo'shib beradi");
                System.Console.WriteLine("D)Hamma javob to'g'ri");
                System.Console.WriteLine();
                Javob = Console.ReadLine()!;
                if(Javob.ToUpper() == "B")
                {
                    correctAnswerCount++;
                }
                keyingiSavol++;
                goto key;
            }
            if(keyingiSavol == 3)
            {
                System.Console.WriteLine("1.C# da Contains methodi nima vazifani bajaradi?");
                System.Console.WriteLine("A)Bilmiman");
                System.Console.WriteLine("B)Ichida bor yoqligini tekshirib beradi");
                System.Console.WriteLine("C)2 ta string ni bir biriga qo'shib beradi");
                System.Console.WriteLine("D)Hamma javob to'g'ri");
                System.Console.WriteLine();
                Javob = Console.ReadLine()!;
                if(Javob.ToUpper() == "B")
                {
                    correctAnswerCount++;
                }
                keyingiSavol++;
                goto key;
            }
            if(keyingiSavol == 4)
            {
                System.Console.WriteLine("1.C# da Contains methodi nima vazifani bajaradi?");
                System.Console.WriteLine("A)Bilmiman");
                System.Console.WriteLine("B)Ichida bor yoqligini tekshirib beradi");
                System.Console.WriteLine("C)2 ta string ni bir biriga qo'shib beradi");
                System.Console.WriteLine("D)Hamma javob to'g'ri");
                System.Console.WriteLine();
                Javob = Console.ReadLine()!;
                if(Javob.ToUpper() == "B")
                {
                    correctAnswerCount++;
                }
                keyingiSavol++;
                goto key;
            }
            if(keyingiSavol == 5)
            {
                System.Console.WriteLine("1.C# da Contains methodi nima vazifani bajaradi?");
                System.Console.WriteLine("A)Bilmiman");
                System.Console.WriteLine("B)Ichida bor yoqligini tekshirib beradi");
                System.Console.WriteLine("C)2 ta string ni bir biriga qo'shib beradi");
                System.Console.WriteLine("D)Hamma javob to'g'ri");
                System.Console.WriteLine();
                Javob = Console.ReadLine()!;
                if(Javob.ToUpper() == "B")
                {
                    correctAnswerCount++;
                }
                keyingiSavol++;
                goto key;
            }
            if(keyingiSavol == 6)
            {
                System.Console.WriteLine("1.C# da Contains methodi nima vazifani bajaradi?");
                System.Console.WriteLine("A)Bilmiman");
                System.Console.WriteLine("B)Ichida bor yoqligini tekshirib beradi");
                System.Console.WriteLine("C)2 ta string ni bir biriga qo'shib beradi");
                System.Console.WriteLine("D)Hamma javob to'g'ri");
                System.Console.WriteLine();
                Javob = Console.ReadLine()!;
                if(Javob.ToUpper() == "B")
                {
                    correctAnswerCount++;
                }
                keyingiSavol++;
                goto key;
            }
            System.Console.WriteLine("To'g'ri javoblar soni: " + correctAnswerCount);
        }

        static int testMenu()
        {
            System.Console.WriteLine("+=========================================+");
            System.Console.WriteLine("|-----------------Test--------------------+");
            System.Console.WriteLine("+=========================================+");
            System.Console.WriteLine("| 1 => Test ishlash-----------------------|");
            System.Console.WriteLine("| 2 => Test qo'shish----------------------|");
            System.Console.WriteLine("| 3 => Testlarim--------------------------|");
            System.Console.WriteLine("| 4 => Testni o'zgartirish----------------|");
            System.Console.WriteLine("| 5 => Chiqish----------------------------|");
            System.Console.WriteLine("+=========================================+");

            System.Console.WriteLine();
            System.Console.WriteLine("Menu ni tanlang: ");
            int menu = int.Parse(Console.ReadLine()!);
            return menu;
        }
    }
}