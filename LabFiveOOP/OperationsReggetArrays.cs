using System;


namespace OperationsOverArrays
{
    class OperationsReggetArrays : OperationsTwodimensionalArrays
    {
        protected static int[][] reggetArray = new int[0][];

        protected void CreateReggetArray()
        {
            do
            {
                try
                {
                    Console.WriteLine("\n1.) Создать рваный двумерный массив заполненный случайными числами;\n2.) Создать рваный двумерный массив и заполнить с клавиатуры;\n3.) Вернуться в меню..\n");
                    uint choice = uint.Parse(Console.ReadLine());
                    if (choice == 1)
                    {
                        ReggetArrayCompletingRandomNumbers();
                        CoutReggetArray();
                        break;
                    }
                    else if (choice == 2)
                    {
                        ReggetArrayInputingNumbers();
                        CoutReggetArray();
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
        private int[][] ReggetArrayCompletingRandomNumbers()
        {
            bool can = false;
            if (reggetArray.Length != 0)
            {
                do
                {
                    try
                    {
                        Console.WriteLine("\nРваный двумерный массив уже создан! Выберите индекс действия\n1.) Создать новый рваный двумерный массив.\n2.) Вернуться в меню..\n");
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

            if (reggetArray.Length == 0 || can)
            {
                Console.WriteLine("\nВведите размер рваного двумерного массива!");

                do
                {
                    try
                    {
                        Console.Write("Количество строк: ");
                        str = uint.Parse(Console.ReadLine());
                        if (str == 0)
                        {
                            Console.WriteLine("\nНе получится поработать с рваным двумерным массивом на 0 строк, повторите ввод...");
                            continue;
                        }
                        reggetArray = new int[str][];
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

                    UInt16 i = 0;
                    for (; i < reggetArray.Length; i++)
                    {
                        try
                        {
                            Console.Write($"Введите количество столбцов в {i + 1} строке: ");
                            stl = uint.Parse(Console.ReadLine());
                            reggetArray[i] = new int[stl];
                        }
                        catch (FormatException fex)
                        {
                            i -= 1;
                            Console.WriteLine(fex.Message);
                        }
                        catch (OverflowException oex)
                        {
                            i -= 1;
                            Console.WriteLine(oex.Message);
                        }
                    }
           
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


                for (UInt16 ii = 0; i < reggetArray.Length; ii++)
                {
                    for (UInt16 j = 0; j < reggetArray[ii].Length; j++)
                    {
                        reggetArray[ii][j] = randomCounter.Next(from, to);
                    }
                }
            }

            return reggetArray;
        }
        private int[][] ReggetArrayInputingNumbers()
        {
            bool can = false;
            if (reggetArray.Length != 0)
            {
                do
                {
                    try
                    {
                        Console.WriteLine("\nРваный двумерный массив уже создан! Выберите индекс действия\n1.) Создать новый рваный двумерный массив.\n2.) Вернуться в меню..\n");
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

            if (reggetArray.Length == 0 || can)
            {
                Console.WriteLine("\nВведите размер рваного двумерного массива!");

                do
                {
                    try
                    {
                        Console.Write("Количество строк: ");
                        str = uint.Parse(Console.ReadLine());
                        if (str == 0)
                        {
                            Console.WriteLine("\nНе получится поработать с рваным двумерным массивом на 0 строк, повторите ввод...");
                            continue;
                        }
                        reggetArray = new int[str][];
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

                UInt16 i = 0;
                for (; i < reggetArray.Length; i++)
                {
                    try
                    {
                        Console.Write($"Введите количество столбцов в {i + 1} строке: ");
                        stl = uint.Parse(Console.ReadLine());
                        reggetArray[i] = new int[stl];
                    }
                    catch (FormatException fex)
                    {
                        i -= 1;
                        Console.WriteLine(fex.Message);
                    }
                    catch (OverflowException oex)
                    {
                        i -= 1;
                        Console.WriteLine(oex.Message);
                    }
                }

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


                for (UInt16 ii = 0; i < reggetArray.Length; ii++)
                {
                    for (UInt16 j = 0; j < reggetArray[ii].Length; j++)
                    {
                        reggetArray[ii][j] = randomCounter.Next(from, to);
                    }
                }
            }

            return reggetArray;
        }
        protected void CoutReggetArray()
        {
            if (reggetArray.Length == 0)
            {
                Console.WriteLine("\nМассив пуст.\n");
                return;
            }
            Console.Write("\nДвумерный массив\n{\n");
            for (uint i = 0; i < reggetArray.GetLength(0); i++)
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

     
    }    
}
