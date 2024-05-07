using System;
using System.Runtime.CompilerServices;


namespace CS_youtube_kurs
{
    class Program
    {
        public static float Sum(int x, float y)
        {
            return (x + y);
        }
        public static void Variables()
        {
            sbyte a = -128;     //range -128 to 127                         8-bit
            byte b = 255;       //range 0 to 255                            8-bit
            short c = -32768;   //range -32,768 to 32,767                   16-bit
            ushort d = 65535;   //range 0 to 65,535                         16-bit
            int e = -10;        //range -2,147,483,648 to 2,147,483,647     32-bit
            uint f = 5;         //range 0 to 4,294,967,295                  32-bit
            long g = -9223372036854775808;   //range -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807        64-bit
            float h = -4.5345f;
            double j = 5.324d;

            char symbol = 'A';
            bool isFirst = false;
            string str = "Variables: ";
            Console.WriteLine(str + a + ", " + b + ", " + c + ", " + d + ", " + e + ", " + f + ", " + g + ", " + h + ", " + j);
        }
        public static void ReadInput()
        {
            //�������� ��������� ��������� ����������
            //int num_1 = 0, num_2 = 0;
            //int num_1, num_2;

            Console.WriteLine("Input int number (����� �����)");
            int num_1 = Convert.ToInt32(Console.ReadLine()) * 2;
            //�������� ���������
            //num_1 = num_1*2;
            //num_1 *= 2;

            Console.WriteLine("Input float number (����� � �������)");
            float num_2 = (float)Convert.ToDouble(Console.ReadLine());
            //float num_2 = float.Parse(Console.ReadLine()) + 10f;      //��� ������� ����.������
            Console.WriteLine(Sum(num_1, num_2));
        }
        public static void MathFunctions()
        {
            Console.WriteLine("Absolute of -20 is: " + Math.Abs(-20));          //20
            Console.WriteLine("Ceiling of 4.11 is: " + Math.Ceiling(4.11f));    //5 � ��������
            Console.WriteLine("Floor of 4.99 is: " + Math.Floor(4.99f));        //4 � ��������
            Console.WriteLine("Round of 4.56 is: " + Math.Round(4.56f));        //5 �� ��������

            Console.WriteLine("Min (5,0) is: " + Math.Min(5, 0));
            Console.WriteLine("Max(-15,56) is: " + Math.Max(-15, 56));
            Console.WriteLine("Pow(5, 3) is: " + Math.Pow(5, 3));               //������� 5*5*5=125
            Console.WriteLine("PI is: " + Math.PI);                             //3,14....
        }
        public static void AreaCircle()
        {
            Console.WriteLine("Input radius (float num): ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine("Area of the circle with radius {0} is {1}", radius, area);
        }
        public static void UpdateUserData()
        {
            Console.Write("Enter level: ");
            string? role = Console.ReadLine();

            if (role == "admin")
            {
                Console.Write("Enter user name: ");
                string? user_name = Console.ReadLine();
                Console.Write("Enter {0}'s age: ", user_name);
                short age = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("{0}'s age is: {1}", user_name, age);
            }
            else
            {
                Console.WriteLine("You have not permission to do changes");
            }
        }
        public static void UserPermissions()
        {
            Console.Write("Choose your level (admin/editor/user): ");
            string? level = Console.ReadLine();

            switch (level)
            {
                case "admin":
                    Console.WriteLine("{0} can view, comment, edit, delete or create new", level);
                    break;
                case "editor":
                    Console.WriteLine("{0} can view, comment and edit", level);
                    break;
                case "user":
                    Console.WriteLine("{0} can view and comment");
                    break;
                default:
                    Console.WriteLine("Unrecognized level");
                    break;
            }
        }
        public static void Cycles()
        {
            Console.WriteLine("Cycle for:");
            for (float i = 50; i> 10; i /= 2)
            {
                Console.WriteLine("Element: {0}", i);
            }
            Console.WriteLine("\nCycle while:");
            byte j = 5;
            while(j >=1)
            {
                Console.WriteLine("Element: " + j);
                j--;
            }
            bool isHasCar = true;
            while(isHasCar)
            {   
                Console.WriteLine("\ninput some text, to end the cycle type: stop");
                string? end = Console.ReadLine();
                if (end == "stop")
                {
                    isHasCar = false;
                }
            }
            Console.WriteLine("\nCycle do-while:");
            byte k = 100;
            do
            {
                Console.WriteLine("Element: " + k);
            }
            while (k<10);

            Console.WriteLine("\nbreak, continue:");
            for(short a = 0; a < 10; a++) {
                if (a > 5) break;
                Console.WriteLine("El: " + a);
                if (a % 2 != 0) continue;
                Console.WriteLine("Number {0} is even", a);
            }
        }

        static void Main()
        {
            //Variables();
            //ReadInput();
            //MathFunctions();
            //AreaCircle();
            //UpdateUserData();
            //UserPermissions();
            Cycles();



            Console.ReadKey();
        }
    }
}
