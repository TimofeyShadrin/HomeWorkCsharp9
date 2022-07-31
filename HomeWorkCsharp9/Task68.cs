namespace Seminar9
{
    class Task68 : Ackerman
    {
        public static void ReturnTask68()
        {
            bool answer = false;
            while (true)
            {
                Console.Clear();
                try
                {
                    FillDataForAckerman();
                    uint result = AckermanFunction(FirstValue, SecondValue);
                    Console.WriteLine($"\n\tРезультат вычисления функции Аккермана = {result}");

                    Console.Write(
                        "\n\tПожалуста нажмите любую клавишу для возврата в основное меню: "
                    );
                    Console.ReadKey();
                    Console.Clear();
                    break;
                }
                catch
                {
                    answer = Methods.ChoiseEscOrEnter(answer);
                    if (answer == true)
                        break;
                }
            }
        }
    }
}
