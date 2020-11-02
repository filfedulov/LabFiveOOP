using System;

namespace OperationsOverArrays
{
    class OperationsTwodimensionalArrays : OperationsArrays
    {
        protected uint str,
            stl,
            k;
        protected static int[,] twoDimArray = new int[0, 0];


        protected void CreateTwoDimArray()
        {
            do
            {
                try
                {
                    Console.WriteLine("\n1.) Создать двумерный массив заполненный случайными числами;\n2.) Создать двумерный массив и заполнить с клавиатуры;\n3.) Вернуться в меню..\n");
                    uint choice = uint.Parse(Console.ReadLine());
                    if (choice == 1)
                    {
                        ArrayCompletingRandomNumbers();
                        CoutTwoDimArray();
                        break;
                    }
                    else if (choice == 2)
                    {
                        ArrayInputingNumbers();
                        CoutTwoDimArray();
                        break;
                    }
                    else if (choice == 3)
                        break;
                    else
                        Console.WriteLine("\nНет дейстия под данным индексом, повторите ввод...\n");

                }
                catch (FormatException fex)
                {
                    Console.WriteLine(fex.Message);
                }
                catch (OverflowException oex)
                {
                    Console.WriteLine(oex.Message);
                }

            } while (true);

        }

        private int[,] ArrayCompletingRandomNumbers()
        {
            if (twoDimArray.Length != 0)
            {
                MiniMenu_();
            }

            if (twoDimArray.Length == 0 || can)
            {

                InputSizeArray_();
                InputRandomNumbers_();

                for (UInt16 i = 0; i < twoDimArray.GetLength(0); i++)
                {
                    for (UInt16 j = 0; j < twoDimArray.GetLength(1); j++)
                    {
                        twoDimArray[i, j] = randomCounter.Next(from, to);
                    }
                }
            }

            return twoDimArray;
        }

        private int[,] ArrayInputingNumbers()
        {
            if (twoDimArray.Length != 0)
            {
                MiniMenu_();
            }
            if (twoDimArray.Length == 0 || can)
            {
                InputSizeArray_();
                InputKeybordNumbers_();
            }
            return twoDimArray;
        }

        private void MiniMenu_()
        {
            can = false;
            do
            {
                try
                {
                    Console.WriteLine("\nДвумерный массив уже создан! Выберите индекс действия\n1.) Создать новый двумерный массив.\n2.) Вернуться в меню..\n");
                    uint choice = uint.Parse(Console.ReadLine());
                    if (choice == 1)
                    {
                        can = true;
                        break;
                    }
                    else if (choice == 2)
                        break;
                    else
                        Console.WriteLine("\nНет дейстия под данным индексом, повторите ввод...\n");
                }
                catch (FormatException fex)
                {
                    Console.WriteLine(fex.Message);
                }
                catch (OverflowException oex)
                {
                    Console.WriteLine(oex.Message);
                }

            } while (true);
        }
        private void InputSizeArray_()
        {
            Console.WriteLine("\nВведите размер двумерного массива!");
            do
            {
                try
                {
                    Console.Write("Количество строк: ");
                    str = uint.Parse(Console.ReadLine());
                    if (str == 0)
                    {
                        Console.WriteLine("\nНе получится поработать с двумерным массивом на 0 строк, повторите ввод...");
                        continue;
                    }
                    break;
                }
                catch (FormatException fex)
                {
                    Console.WriteLine(fex.Message);
                }
                catch (OverflowException oex)
                {
                    Console.WriteLine(oex.Message);
                }
            } while (true);
            do
            {
                try
                {
                    Console.Write("Количество столбцов: ");
                    stl = uint.Parse(Console.ReadLine());
                    if (stl == 0)
                    {
                        Console.WriteLine("\nУ двумерного массива не может быть 0 столбцов, повторите ввод...");
                        continue;
                    }
                    twoDimArray = new int[str, stl];
                    break;
                }
                catch (FormatException fex)
                {
                    Console.WriteLine(fex.Message);
                }
                catch (OverflowException oex)
                {
                    Console.WriteLine(oex.Message);
                }
            } while (true);
        }
        private void InputRandomNumbers_()
        {
            Console.WriteLine("\nВведите диапазон чисел");
            do
            {
                try
                {
                    Console.Write("От: ");
                    from = int.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException fex)
                {
                    Console.WriteLine(fex.Message);
                }
                catch (OverflowException oex)
                {
                    Console.WriteLine(oex.Message);
                }

            } while (true);
            do
            {
                try
                {
                    Console.Write("До: ");
                    to = int.Parse(Console.ReadLine());
                    if (to < from)
                        throw new Exception("\nЗначение MaxValue не может быть меньше значения MinValue, повторите ввод...\n");
                    break;
                }
                catch (FormatException fex)
                {
                    Console.WriteLine(fex.Message);
                }
                catch (OverflowException oex)
                {
                    Console.WriteLine(oex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            } while (true);
        }
        private void InputKeybordNumbers_()
        {
            Console.WriteLine("\nЗаполните двумерный массив с клавиатуры!");
            for (UInt16 i = 0; i < twoDimArray.GetLength(0); i++)
            {
                for (UInt16 j = 0; j < twoDimArray.GetLength(1); j++)
                {
                    try
                    {
                        Console.Write($"{i + 1}-я строка, {j + 1}-й столбец: ");
                        twoDimArray[i, j] = int.Parse(Console.ReadLine());
                    }
                    catch (FormatException fex)
                    {
                        j -= 1;
                        Console.WriteLine(fex.Message);
                    }
                    catch (OverflowException oex)
                    {
                        j -= 1;
                        Console.WriteLine(oex.Message);
                    }
                }
            }
        }

        protected void CoutTwoDimArray()
        {
            if (twoDimArray.Length == 0)
            {
                Console.WriteLine("\nМассив пуст.\n");
                return;
            }
            Console.Write("\nДвумерный массив\n{\n");
            for (uint i = 0; i < twoDimArray.GetLength(0); i++)
            {
                for (uint j = 0; j < twoDimArray.GetLength(1); j++)
                {
                    if (i == twoDimArray.GetLength(0) - 1 && j == twoDimArray.GetLength(1) - 1)
                        Console.Write($" {twoDimArray[i, j]} \n}}\n");
                    else if (j == twoDimArray.GetLength(1) - 1)
                        Console.Write($" {twoDimArray[i, j]}"); 
                    else
                        Console.Write($" {twoDimArray[i, j]},\t");
                }
                Console.WriteLine();
            }
            return;
        }

        protected int[,] AddStr(ref int[,] twoDimArray)
        {
            uint choice;
            do
            {
                try
                {
                    Console.Write("\nДобавить строку с номером: ");
                    k = uint.Parse(Console.ReadLine());
                    if (k == 0)
                        throw new Exception("\nДля пользователя нет нулевой строки, повторите ввод...");

                    break;
                }
                catch (FormatException fex)
                {
                    Console.WriteLine(fex.Message);
                }
                catch (OverflowException oex)
                {
                    Console.WriteLine(oex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            } while (true);
            k--;

            if (k > twoDimArray.GetLength(0) || k < 0)
            {
                Console.WriteLine($"\nВ данном двумерном массиве {twoDimArray.GetLength(0)} строк, " +
                    $"\nдобавить строку можно: в начало, в конец, либо в диапазоне от начала до конца, поэтому повторите ввод...\n");
                return AddStr(ref twoDimArray);
            }

            do
            {
                try
                {
                    Console.WriteLine("\nВыбериет состав данной строки\n1.) Заполнить строку случайными числами;" +
                        "\n2.) Заполнить строку с клавиатуры;" +
                        "\n3.) Заполнить строку нулями;" +
                        "\n4.) Вернуться в меню..");
                    choice = uint.Parse(Console.ReadLine());
                    if (choice == 1)
                    {
                        InputStrRandomNumbers_();
                        break;
                    }
                    else if (choice == 2)
                    {
                        InputStrKeyboardNumbers_();
                        break;
                    }
                    else if (choice == 3)
                    {
                        InputStrNull_();
                        break;
                    }
                    else if (choice == 4)
                        break;
                    else
                        Console.WriteLine("\nНет действия под данным индексом, повторите ввод...");

                }
                catch (FormatException fex)
                {
                    Console.WriteLine(fex.Message);
                }
                catch (OverflowException oex)
                {
                    Console.WriteLine(oex.Message);
                }
            } while (true);

            return twoDimArray;
            
        }

        private void InputStrNull_()
        {
            int[,] tmpTwoDimArray = new int[twoDimArray.GetLength(0) + 1, twoDimArray.GetLength(1)];

            if (k <= twoDimArray.GetLength(0) - 1)
            {
                for (uint i = 0; i < k; i++)
                {
                    for (uint j = 0; j < tmpTwoDimArray.GetLength(1); j++)
                        tmpTwoDimArray[i, j] = twoDimArray[i, j];
                }
                for (uint i = k; i < tmpTwoDimArray.GetLength(0); i++)
                {
                    for (uint j = 0; j < tmpTwoDimArray.GetLength(1); j++)
                    {
                        if (i == k)
                            tmpTwoDimArray[i, j] = 0;
                        else
                            tmpTwoDimArray[i, j] = twoDimArray[i - 1, j];
                    }
                }

                twoDimArray = tmpTwoDimArray;
            }
            else
            {
                for (uint i = 0; i < k; i++)
                {
                    for (uint j = 0; j < tmpTwoDimArray.GetLength(1); j++)
                        tmpTwoDimArray[i, j] = twoDimArray[i, j];
                }
                for (uint i = k; i < k + 1; i++)
                {
                    for (uint j = 0; j < tmpTwoDimArray.GetLength(1); j++)
                        tmpTwoDimArray[i, j] = 0;
                }

                twoDimArray = tmpTwoDimArray;
            }
        }
        private void InputStrRandomNumbers_()
        {
            InputRandomNumbers_();
            int[,] tmpTwoDimArray = new int[twoDimArray.GetLength(0) + 1, twoDimArray.GetLength(1)];

            if (k <= twoDimArray.GetLength(0) - 1)
            {
                for (uint i = 0; i < k; i++)
                {
                    for (uint j = 0; j < tmpTwoDimArray.GetLength(1); j++)
                        tmpTwoDimArray[i, j] = twoDimArray[i, j];
                }
                for (uint i = k; i < tmpTwoDimArray.GetLength(0); i++)
                {
                    for (uint j = 0; j < tmpTwoDimArray.GetLength(1); j++)
                    {
                        if (i == k)
                            tmpTwoDimArray[i, j] = randomCounter.Next(from, to);
                        else
                            tmpTwoDimArray[i, j] = twoDimArray[i - 1, j];
                    }
                }

                twoDimArray = tmpTwoDimArray;
            }
            else
            {
                for (uint i = 0; i < k; i++)
                {
                    for (uint j = 0; j < tmpTwoDimArray.GetLength(1); j++)
                        tmpTwoDimArray[i, j] = twoDimArray[i, j];
                }
                for (uint i = k; i < k + 1; i++)
                {
                    for (uint j = 0; j < tmpTwoDimArray.GetLength(1); j++)
                        tmpTwoDimArray[i, j] = randomCounter.Next(from, to);
                }

                twoDimArray = tmpTwoDimArray;
            }
        }
        private void InputStrKeyboardNumbers_()
        {
            int[,] tmpTwoDimArray = new int[twoDimArray.GetLength(0) + 1, twoDimArray.GetLength(1)];

            if (k <= twoDimArray.GetLength(0) - 1)
            {
                for (uint i = 0; i < k; i++)
                {
                    for (uint j = 0; j < tmpTwoDimArray.GetLength(1); j++)
                        tmpTwoDimArray[i, j] = twoDimArray[i, j];
                }
                for (uint i = k; i < tmpTwoDimArray.GetLength(0); i++)
                {
                    for (uint j = 0; j < tmpTwoDimArray.GetLength(1); j++)
                    {
                        try
                        {
                            if (i == k)
                            {
                                Console.Write($"{i + 1}-я строка, {j + 1}-й столбец: ");
                                tmpTwoDimArray[i, j] = int.Parse(Console.ReadLine());

                            }
                            else
                                tmpTwoDimArray[i, j] = twoDimArray[i - 1, j];
                        }
                        catch (FormatException fex)
                        {
                            j -= 1;
                            Console.WriteLine(fex.Message);
                        }
                        catch (OverflowException oex)
                        {
                            j -= 1;
                            Console.WriteLine(oex.Message);
                        }
                    }
                }
                twoDimArray = tmpTwoDimArray;
            }
            else
            {
                for (uint i = 0; i < k; i++)
                {
                    for (uint j = 0; j < tmpTwoDimArray.GetLength(1); j++)
                        tmpTwoDimArray[i, j] = twoDimArray[i, j];
                }
                for (uint i = k; i < k + 1; i++)
                {
                    for (uint j = 0; j < tmpTwoDimArray.GetLength(1); j++)
                    {
                        Console.Write($"{i + 1}-я строка, {j + 1}-й столбец: ");
                        tmpTwoDimArray[i, j] = int.Parse(Console.ReadLine());
                    }   
                }
                twoDimArray = tmpTwoDimArray;
            }
        }
    }
}