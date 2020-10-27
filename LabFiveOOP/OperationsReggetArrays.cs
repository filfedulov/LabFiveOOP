using System;

namespace OperationsOverArrays
{
    class OperationsReggetArrays : OperationsTwodimensionalArrays
    {
        protected static int[][] reggetArray = new int[0][];
        private uint checkNull = 0,
            memoryIforDelete = 0,
            maxLength;


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
            if (reggetArray.Length != 0)
            {
                MiniMenu_();
            }

            if (reggetArray.Length == 0 || can)
            {
                InputSizeArray_();

                InputRandomNumbers_();
               
                for (UInt16 i = 0; i < reggetArray.Length; i++)
                {
                    for (UInt16 j = 0; j < reggetArray[i].Length; j++)
                    {
                        if (reggetArray[i].Length != 0)
                        reggetArray[i][j] = randomCounter.Next(from, to);
                    }
                }
            }
            return reggetArray;
        }
        private int[][] ReggetArrayInputingNumbers()
        {
            if (reggetArray.Length != 0)
            {
                MiniMenu_();
            }

            if (reggetArray.Length == 0 || can)
            {
                InputSizeArray_();
                InputKeybordNumbers_();
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
            Console.Write("\nРваный двумерный массив\n{\n");
            for (UInt16 i = 0; i < reggetArray.Length; i++)
            {
                for (UInt16 j = 0; j < reggetArray[i].Length; j++)
                {
                    if (i == reggetArray.Length - 1 && j == reggetArray[i].Length - 1)
                        Console.Write($" {reggetArray[i][j]}");
                    else if (j == reggetArray[i].Length - 1)
                        Console.Write($" {reggetArray[i][j]}");
                    else
                        Console.Write($" {reggetArray[i][j]},\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("}");
            return;
        }

        private void MiniMenu_()
        {
            can = false;
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
        private void InputSizeArray_()
        {
            checkNull = 0;
            Console.WriteLine("\nВведите размер рваного двумерного массива!");
            do
            {
                try
                {
                    Console.Write("\nКоличество строк: ");
                    str = uint.Parse(Console.ReadLine());
                    if (str == 0)
                    {
                        Console.WriteLine("\nНе бывает рваных двумерных массивов на 0 строк, повторите ввод...");
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

            do
            {
                UInt16 i = 0;
                for (; i < reggetArray.Length; i++)
                {
                    try
                    {
                        Console.Write($"\nВведите количество столбцов в {i + 1} строке: ");
                        stl = uint.Parse(Console.ReadLine());
                        reggetArray[i] = new int[stl];
                        if (stl == 0)
                            checkNull++;
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
                if (!CheckOnNullAlls_())
                    break;
                else
                {
                    Console.WriteLine("\nВсе строки имеют размер 0, повторите ввод столбцов...\n");
                    checkNull = 0;
                }
                    

            } while (true);
        }
        private bool CheckOnNullAlls_()
        {
            bool allNull = false;
            if (checkNull == reggetArray.Length)
                allNull = true;
            return allNull;
        }
        private void InputRandomNumbers_()
        {
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
        }
        private void InputKeybordNumbers_()
        {
            Console.WriteLine("\nЗаполните рваный двумерный массив с клавиатуры!");
            for (UInt16 i = 0; i < reggetArray.Length; i++)
            {
                for (UInt16 j = 0; j < reggetArray[i].Length; j++)
                {
                    try
                    {
                        if (reggetArray[i].Length != 0)
                        {
                            Console.Write($"{i + 1}-я строка, {j + 1}-й столбец: ");
                            reggetArray[i][j] = int.Parse(Console.ReadLine());
                        }
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

        protected void DeleteTheLongStr()
        {
            SearchMaxLength_();
            reggetArray = MemoryAllocation_();
        }

        private void SearchMaxLength_()
        {
            UInt16 i = 0;
            memoryIforDelete = 0;
            maxLength = (uint)reggetArray[i].Length;
            while (i < reggetArray.Length - 1)
            {
                if (reggetArray[i + 1].Length > maxLength)
                {
                    maxLength = (uint)reggetArray[i + 1].Length;
                    memoryIforDelete = (uint)(i + 1);
                }
                i++;
            }
        }
        private int[][] MemoryAllocation_()
        {
            if (reggetArray.Length != 0)
            {
                int[][] tmpReggetArray = new int[reggetArray.Length - 1][];
                for (UInt16 i = 0; i < memoryIforDelete; i++)
                {
                    tmpReggetArray[i] = new int[reggetArray[i].Length];
                }
                for (UInt16 i = (ushort)memoryIforDelete; i < tmpReggetArray.Length; i++)
                {
                    tmpReggetArray[i] = new int[reggetArray[i + 1].Length];
                }

                for (UInt16 i = 0; i < memoryIforDelete; i++)
                {
                    for (UInt16 j = 0; j < tmpReggetArray[i].Length; j++)
                    {
                        if (tmpReggetArray[i].Length != 0)
                            tmpReggetArray[i][j] = reggetArray[i][j];
                    }
                }
                for (UInt16 i = (ushort)memoryIforDelete; i < tmpReggetArray.Length; i++)
                {
                    for (UInt16 j = 0; j < tmpReggetArray[i].Length; j++)
                    {
                        if (tmpReggetArray[i].Length != 0)
                            tmpReggetArray[i][j] = reggetArray[i + 1][j];
                    }
                }
                return tmpReggetArray;
            }
            else
            {
                return reggetArray;
            }
        }
    }
}