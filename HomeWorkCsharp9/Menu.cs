namespace Seminar9
{
    class Menu
    {
        public static void Intro()
        {
            Console.WriteLine(
                "\n\t �����������! �������� ���������� ������ ��� ��������!\n"
                    + "\t\t ��� ����� ����������� ������� ����� � ����, ����� ����������� ��� ������� Enter.\n"
                    + "\n\n"
                    + "\t1. ������ No 64:\n"
                    + "\t\t ������� �������� M � N.\n"
                    + "\t\t �������� ���������, ������� ������� ��� ����������� ����� � ���������� �� M �� N.\n"
                    + "\n"
                    + "\t2. ������ No 66:\n"
                    + "\t\t ������� �������� M � N.\n"
                    + "\t\t �������� ���������, ������� ����� ����� ����������� ��������� � ���������� �� M �� N.\n"
                    + "\n"
                    + "\t3. ������ No 68:\n"
                    + "\t\t �������� ��������� ���������� ������� ��������� � ������� ��������.\n"
                    + "\t\t ���� ��� ��������������� ����� m � n.\n"
                    + "\n\n"
                    + "\t ����� �� ���������"
            );
            Console.WriteLine();
        }

        private static void HorizontalLine(int left, int top, int length)
        {
            Console.SetCursorPosition(left, top);
            Console.Write("+");
            for (int i = 0; i < length; i++)
            {
                Console.Write("-");
            }
            Console.Write("+");
        }

        private static void VerticalLine(int left, int top, int height)
        {
            for (int i = 0; i <= height; i++)
            {
                Console.SetCursorPosition(left, top + i);
                Console.Write("|");
            }
        }

        public static void Box(int left, int top, int lenght, int height)
        {
            HorizontalLine(left, top, lenght);
            VerticalLine(left, top + 1, height - 1);
            VerticalLine(left + lenght + 1, top + 1, height - 1);
            HorizontalLine(left, top + height, lenght);
            Console.SetCursorPosition(0, 0);
        }
    }
}