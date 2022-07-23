namespace Seminar9
{
    class Decisions
    {
        private static int firstNumber = 1;
        private static int secondNumber = 2;
        public static List<int> numbers = new List<int>();
        public static int result = 0;

        public static int FirstNumber
        {
            get { return firstNumber; }
            set
            {
                if (value > 0) firstNumber = value;
                else
                {
                    firstNumber = 1;
                }
            }
        }

        public static int SecondNumber
        {
            get { return secondNumber; }
            set
            {
                if (value > firstNumber) secondNumber = value;
                else
                {
                    secondNumber = firstNumber + Math.Abs(value) + 1;
                    Console.Write("\n\tВаш ввод не соответствует требованиям!\n" +
                        $"\tЗа значение верхней границы принято число: {secondNumber}");
                }
            }
        }

        public static void FillList()
        {
            for (int i = firstNumber; i <= secondNumber; i++)
            {
                numbers.Add(i);
            }
        }

        public static void SumOfListElements()
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                result += numbers[i];
            }
        }
    }
}