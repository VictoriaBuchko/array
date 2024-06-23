namespace array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1) Пользователь вводит длину сторон пятиугольника,
            //длина каждой стороны заносится в массив, необходимо вычислить периметр пятиугольника
            //(периметр – сумма всех сторон).Решить задачу двумя способами – с помощью соответствующего
            //метода класса System.Array и «вручную».
            Console.WriteLine($"Первое задание");
            double[] sides = new double[5];

            for (int i = 0; i < sides.Length; i++)
            {
                Console.Write($"Введите длину стороны {i + 1}: ");
                sides[i] = double.Parse(Console.ReadLine());
            }

            double perimeter = sides.Sum();
            Console.WriteLine($"Периметр пятиугольника: {perimeter}");

            double perimeters = 0;
            for (int i = 0; i < sides.Length; i++)
            {
                perimeters += sides[i];
            }

            Console.WriteLine($"Периметр пятиугольника: {perimeters}");

            //2) Пользователь вводит в массив прибыль фирмы за год(12 месяцев).
            //Необходимо определить месяц, в котором прибыль была максимальна,
            //и месяц, в котором прибыль была минимальна.

            Console.WriteLine($"\nВторое задание");
            double[] monthlyProfit = new double[12];

            for (int i = 0; i < monthlyProfit.Length; i++)
            {
                Console.Write($"Введите прибыль фирмы за {i + 1} месяц: ");
                monthlyProfit[i] = double.Parse(Console.ReadLine());
            }

            double maxValue = monthlyProfit.Max();
            double minValue = monthlyProfit.Min();

            int maxMonth = Array.IndexOf(monthlyProfit, maxValue);
            int minMonth = Array.IndexOf(monthlyProfit, minValue);
            Console.WriteLine($"Максимальная прибыль была в {maxMonth+1} месяце = {maxValue:F2}");
            Console.WriteLine($"Минимальная прибыль была в {minMonth+1} месяце = {minValue:F2}");

            //3) Создать массив целых чисел размером 10 элементов.
            //Заполнить его случайными числами в диапазоне от - 9 до 9 включительно.
            //Найти сумму нечетных элементов. Найти сумму элементов с нечетными индексами.

            Console.WriteLine($"\nТретье задание");
            int[] randomNumbers = new int[10];

            Random random = new Random();
            for (int i = 0; i < randomNumbers.Length; i++)
            {
                randomNumbers[i] = random.Next(-9, 10);
            }

            Console.WriteLine("Массив:");
            for (int i = 0; i < randomNumbers.Length; i++)
            {
                Console.Write(randomNumbers[i] + " ");
            }

            Console.WriteLine("");

            int sumOddElements = 0;
            for (int i = 0; i < randomNumbers.Length; i++)
            {
                if (randomNumbers[i] % 2 != 0) 
                {
                    sumOddElements += randomNumbers[i]; 
                }
            }
            Console.WriteLine($"Сумма нечетных элементов: {sumOddElements}");

            int sumWithOddIndices = 0;
            for (int i = 1; i < randomNumbers.Length; i += 2)
            {
                sumWithOddIndices += randomNumbers[i];
            }
            Console.WriteLine($"Сумма элементов с нечетными индексами: {sumWithOddIndices}");
        }
    }
    
}
