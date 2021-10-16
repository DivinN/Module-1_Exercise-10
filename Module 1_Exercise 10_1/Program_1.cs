using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_1_Exercise_10_1
{
    class Program_1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Создадим экземпляр класса для подсчета значений угла.");
            Console.WriteLine("Пожалуйста, введите градусы вашего угла");
            int angle_gradus = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("А теперь значение минут вашего угла.");
            int angle_min = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("И, наконец, введите значение секунд вашего угла.");
            int angle_sec = Convert.ToInt32(Console.ReadLine());

            MyDegrees experimentWithMyDegrees = new MyDegrees(angle_gradus, angle_min, angle_sec);

            Console.WriteLine("Прекрасно, мы создали ваш класс!");
            
            double myDegreesInRadians = experimentWithMyDegrees.ToRadians();
            Console.WriteLine("А также посчитали для вас значение заданного угла в радианах: {0}", Math.Round(myDegreesInRadians, 3));

            experimentWithMyDegrees.Gradus = 10;
            Console.WriteLine("Теперь мы задали градусы равными 10");
            double myDegreesInRadians_2 = experimentWithMyDegrees.ToRadians();

            Console.WriteLine("Тогда в радианах это будет: {0}", Math.Round(myDegreesInRadians_2, 3));
            Console.ReadKey();
        }
    }


    class MyDegrees
    {
        static int gradus;
        static int min;
        static int sec;

        public int Gradus
        {
            set
            {
                if ((value >= 0) && (value <= 360))
                {
                    gradus = value;
                }
                else
                {
                    Console.WriteLine("В этой программе градус должен быть в диапазоне от 0 до 360!");
                }
            }
            get
            {
                return gradus;
            }
        }
        
        public int Min
        {
            set
            {
                if ((value >= 0) && (value <= 60))
                {
                    min = value;
                }
                else
                {
                    Console.WriteLine("В этой программе минуты должны быть в диапазоне от 0 до 60!");
                }
            }
            get
            {
                return min;
            }
        }
        
        public int Sec
        {
            set
            {
                if ((value >= 0) && (value <= 60))
                {
                    sec = value;
                }
                else
                {
                    Console.WriteLine("В этой программе секунды должны быть в диапазоне от 0 до 60!");
                }
            }
            get
            {
                return sec;
            }
        }

        // Конструктор
        public MyDegrees(int gradusForCalculations = 0, int minForCalculations = 0, int secForCalculations = 0)
        {
            if ((gradusForCalculations >= 0) && (gradusForCalculations <= 360))
            {
                gradus = gradusForCalculations;
            }
            else
            {
                Console.WriteLine("В этой программе градус должен быть в диапазоне от 0 до 360! Мы пока что задали градусы равными нулю.");
                gradus = 0;
            }
            
            if ((minForCalculations >= 0) && (minForCalculations <= 60))
            {
                min = minForCalculations;
            }
            else
            {
                Console.WriteLine("В этой программе минуты должны быть в диапазоне от 0 до 60! Мы пока что задали минуты равными нулю.");
                min = 0;
            }

            if ((secForCalculations >= 0) && (secForCalculations <= 60))
            {
                sec = secForCalculations;
            }
            else
            {
                Console.WriteLine("В этой программе секунды должны быть в диапазоне от 0 до 60! Мы пока что задали секунды равными нулю.");
                sec = 0;
            }
            
        }

        public double ToRadians()
        {
            double radians;
            radians = (gradus * Math.PI / 180) + (min * Math.PI / (180 * 60)) + (sec * Math.PI / (180 * 60 * 60));

            return radians;
        }

    }
}
