namespace Seminar9
{
    class Task66
    {
        public static void ReturnTask66()
        {
            bool answer = false;
            while (true)
            {
                Console.Clear();
                try
                {
                    Decisions.numbers.Clear();
                    Methods.FillDataForList();
                    Decisions.FillList();
                    if (Decisions.numbers.Count > 0)
                    {
                        Methods.PrintCurrentList(Decisions.numbers);
                        Decisions.result = 0;
                        Decisions.SumOfListElements();
                        Console.WriteLine($"\t����� ����������� ��������� � ��������� ���������� ����� = {Decisions.result}");

                        Console.Write(
                            "\n\t��������� ������� ����� ������� ��� �������� � �������� ����: "
                        );
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }
                    else
                    {
                        answer = Methods.ChoiseEscOrEnter(answer);
                        if (answer == true)
                            break;
                    }
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