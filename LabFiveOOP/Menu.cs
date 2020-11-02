using System;

namespace OperationsOverArrays
{
    class Menu : OperationsReggetArrays
    {
        private uint choice = 0;
  

        public int MainMenu()
        {
            bool can = false;
            Console.WriteLine("\t\t\tКОНСОЛЬНОЕ ПРИЛОЖЕНИЕ ДЛЯ РАБОТЫ С МАССИВАМИ");
                try
                { 
                    Console.WriteLine("\nВыберите индекс действия основного меню\n1.  Операции c массивами;" +
                    "\n2.  Операции с двумерными массива;" +
                    "\n3.  Операции с рваными двумерными массивами;" +
                    "\n4.  Выход.");
                    choice = uint.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            MenuForArray_();
                            break;
                        case 2:
                            MenuForTwoDimArray_();
                            break;
                        case 3:
                            MenuForReggetArray_();
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

            if (can)
                return 0;
            return MainMenu();
        }

        private void MenuForArray_()
        {
            bool can = false;
            Menu m = new Menu();
            Console.WriteLine("\t\t\tОПЕРАЦИИ НАД МАССИВАМИ");
            do
            {
                try
                {
                    Console.WriteLine("\nВыберите индекс действия\n1.  Создание массив;" +
                    "\n2.  Вывод массива;" +
                    "\n3.  Удалить первый четный элемент в массиве;" +
                    "\n4.  Вернуться в главное меню..");
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
                            if (array.Length != 0)
                                m.DeleteFirstEvenElement();
                            else
                                Console.WriteLine("\nУдалять нечего.\n");
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
        private void MenuForTwoDimArray_()
        {
            bool can = false;
            Menu m = new Menu();
            Console.WriteLine("\t\t\tОПЕРАЦИИ НАД ДВУМЕРНЫМИ МАССИВАМИ");
            do
            {
                try
                {
                    Console.WriteLine("\nВыберите индекс действия\n1.  Создание двумерного массива;" +
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
                            if (twoDimArray.Length != 0)
                            {
                                m.AddStr(ref twoDimArray);
                                m.CoutTwoDimArray();
                            }
                            else Console.WriteLine("\nСначала создайте думерный массив..");
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
        private void MenuForReggetArray_()
        {
            bool can = false;
            Menu m = new Menu();
            Console.WriteLine("\t\t\tОПЕРАЦИИ НАД РВАНЫМИ ДВУМЕРНЫМИ МАССИВАМИ");
            do
            {
                try
                {
                    Console.WriteLine("\nВыберите индекс действия\n1.  Создание рваного двумерного массива;" +
                    "\n2.  Вывод рваного двумерного массива;" +
                    "\n3.  Удалить самую длинную строку;" +
                    "\n4.  Вернуться в главное меню..");
                    choice = uint.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            m.CreateReggetArray();
                            break;
                        case 2:
                            m.CoutReggetArray();
                            break;
                        case 3:
                            if (reggetArray.Length != 0)
                            {
                                m.DeleteTheLongStr();
                                m.CoutReggetArray();
                            }
                            else
                                Console.WriteLine("\nУдалять нечего.\n");
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
        }
    }
}