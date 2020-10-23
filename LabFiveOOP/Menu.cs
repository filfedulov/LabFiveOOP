using System;


namespace OperationsOverArrays
{
    class Menu : OperationsReggetArrays
    {
        private uint choice = 0;
        bool can = false;

        public void MenuForArray()
        {
            Menu m = new Menu();
            Console.WriteLine("\t\t\tОПЕРАЦИИ НАД МАССИВАМИ");
            do
            {
                try
                {
                    Console.WriteLine("\nВыберите индекс действия\n1.  Создание массив;" +
                    "\n2.  Вывод массива;" +
                    "\n3.  Найти первый четный элемент в массиве;" +
                    "\n4. Вернуться в главное меню..");
                    choice = uint.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            m.CreateArray();
                            break;
                        case 2:
                            m.CoutArray();
                            break;
                        case 3:
                            m.DeleteFirstEvenElement();
                            break;
                        case 4:
                            can = true;
                            break;
                        default:
                            Console.WriteLine("\nНет действия под данным индексом, повторите ввод...\n");
                            break;
                    }
                }
                catch (FormatException fex)
                {
                    Console.WriteLine(fex.Message);
                }
                catch (OverflowException oex)
                {
                    Console.WriteLine(oex.Message);
                }
            } while (!can);

            return;
        }
        public void MenuForTwoDimArray()
        {
            Menu m = new Menu();
            Console.WriteLine("\t\t\tОПЕРАЦИИ НАД ДВУМЕРНЫМИ МАССИВАМИ");
            do
            {
                try
                {
                    Console.WriteLine("\nВыберите индекс действия\n1.  Создание двумерный массив;" +
                    "\n2.  Вывод двумерного массива;" +
                    "\n3.  Добавить строку с заданным номером;" +
                    "\n4.  Вернуться в главное меню..");
                    choice = uint.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            m.CreateTwoDimArray();
                            break;
                        case 2:
                            m.CoutTwoDimArray();
                            break;
                        case 3:
                            m.AddStr(ref twoDimArray);
                            break;
                        case 4:
                            can = true;
                            break;
                        default:
                            Console.WriteLine("\nНет действия под данным индексом, повторите ввод...\n");
                            break;
                    }
                }
                catch (FormatException fex)
                {
                    Console.WriteLine(fex.Message);
                }
                catch (OverflowException oex)
                {
                    Console.WriteLine(oex.Message);
                }
            } while (!can);

            return;
        }
    }
}
