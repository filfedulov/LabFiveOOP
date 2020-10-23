using System;
using System.Runtime.InteropServices;

namespace OperationsOverArrays
{
    class OperationsTwodimensionalArrays : OperationsArrays
    {
        protected uint str,
            stl;
        protected static int[,] twoDimArray = new int[0, 0];

        protected  void CreateTwoDimArray()
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
            bool can = false;
            if (twoDimArray.Length != 0)
            {
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

            if (twoDimArray.Length == 0 || can)
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

                Console.WriteLine("\nВведите диапазон чисел заполняемых массив");
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
            bool can = false;
            if (twoDimArray.Length != 0)
            {
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

            if (twoDimArray.Length == 0 || can)
            {
                Console.WriteLine("\nВведите размер двумерного массив!");

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

                Console.WriteLine("\nЗаполните массив с клавиатуры!");
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

            return twoDimArray;
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
                        Console.Write($"{twoDimArray[i, j]} \n}}\n");
                    else
                        Console.Write($"{twoDimArray[i, j]},\t");
                }
                Console.WriteLine();
            }
            return;
        }
       
        protected int[,] AddStr(ref int[,] twoDimArray)
        {
            uint k;
            do
            {
                try
                {
                    Console.Write("Добавить строку с номером: ");
                    k = uint.Parse(Console.ReadLine());
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
            
            if (k > twoDimArray.GetLength(0) || k < 0)
            {
                Console.WriteLine($"\nВ данном двумерном массиве {twoDimArray.GetLength(0)} строк, " +
                    $"\nдобавить строку можно: в начало, в конец, либо в диапазоне от начала до конца, поэтому повторите ввод...\n");
                return AddStr(ref twoDimArray);
            }

            int[,] tmpTwoDimArray = new int[twoDimArray.GetLength(0) + 1, twoDimArray.GetLength(1)];
            
            if (k < twoDimArray.GetLength(0) - 1)
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
            else if (k == twoDimArray.GetLength(0))
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
            else
            {
                for (uint i = 0; i < k; i++)
                {
                    for (uint j = 0; j < tmpTwoDimArray.GetLength(1); j++)
                        tmpTwoDimArray[i, j] = twoDimArray[i, j];
                }
                for (uint i = k; i < k + 2; i++)
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
                
            return twoDimArray;
        }
    }
}
