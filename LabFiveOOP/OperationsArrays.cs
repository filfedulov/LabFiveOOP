using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace OperationsOverArrays
{
    class OperationsArrays
    {
        protected readonly Random randomCounter = new Random();
        private int[] array = new int[0];
        private uint size;
        protected int from,
            to;
        

        protected void CreateArray()
        {
            do
            {
                try
                {
                    Console.WriteLine("\n1.) Создать массив заполненный случайными числами;\n2.) Создать массив и заполнить с клавиатуры;\n3.) Вернуться в меню..\n");
                    uint choice = uint.Parse(Console.ReadLine());
                    if (choice == 1)
                    {
                        ArrayCompletingRandomNumbers();
                        CoutArray();
                        break;
                    }
                    else if (choice == 2)
                    {
                        ArrayInputingNumbers();
                        CoutArray();
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
        private int[] ArrayCompletingRandomNumbers()
        {
            bool can = false;
            if (array.Length != 0)
            {
                do
                {
                    try
                    {
                        Console.WriteLine("\nМассив уже создан! Выберите индекс действия\n1.) Создать новый массив.\n2.) Вернуться в меню..\n");
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
                    catch(OverflowException oex)
                    {
                        Console.WriteLine(oex.Message);
                    }

                } while (true);
            }

            if (array.Length == 0 || can)
            {
                do
                {
                    try
                    {
                        Console.Write("\nВведите размер массив: ");
                        size = uint.Parse(Console.ReadLine());
                        if (size == 0)
                        {
                            Console.WriteLine("\nНе получится поработать с массивом на 0 строк, повторите ввод...");
                            continue;
                        }
                        array = new int[size];
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
                
                for (UInt16 i = 0; i < array.Length; i++)
                {
                    array[i] = randomCounter.Next(from, to);
                }
            }
            
            return array;
        }
        private int[] ArrayInputingNumbers()
        {
            bool can = false;
            if (array.Length != 0)
            {
                do
                {
                    try
                    {
                        Console.WriteLine("\nМассив уже создан! Выберите индекс действия\n1.) Создать новый массив.\n2.) Вернуться в меню..\n");
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

            if (array.Length == 0 || can)
            {
                do
                {
                    try
                    {
                        Console.Write("\nВведите размер массив: ");
                        size = uint.Parse(Console.ReadLine());
                        if (size == 0)
                        {
                            Console.WriteLine("\nНе получится поработать с массивом на 0 строк, повторите ввод...");
                            continue;
                        }
                        array = new int[size];

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
                Console.WriteLine("\nЗаполните массив с клавиатуры!");
                for (; i < array.Length; i++)
                {
                    try
                    {
                        Console.Write($"{i + 1}-й: ");
                        array[i] = int.Parse(Console.ReadLine());

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
            }

            return array;
        }
        protected void CoutArray()
        {
            if(array.Length == 0)
            {
                Console.WriteLine("\nМассив пуст.\n");
                return;
            }
            Console.Write("\nМассив\n{ ");
            for (uint i = 0; i < array.Length; i++)
            {
                if (i == array.Length - 1)
                    Console.Write($"{array[i]} }}\n");
                else
                    Console.Write($"{array[i]}, ");
            }
            return;
        }

        protected void DeleteFirstEvenElement()
        {
            if (array.Length == 0)
            {
                Console.WriteLine("\nМассив пуст.\n");
                return;
            }
            else
            {
                uint memoryIndex = 0;
                bool evenElementYes = false;
                for (uint i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == 0)
                    {
                        evenElementYes = true;
                        memoryIndex = i;
                        break;
                    }
                }
                if (evenElementYes)
                {
                    int[] tmpArray = new int[array.Length - 1];
                    for (uint i = 0; i < memoryIndex; i++)
                    {
                        tmpArray[i] = array[i];
                    }
                    for (uint i = memoryIndex; i < tmpArray.Length; i++)
                    {
                        tmpArray[i] = array[i + 1];
                    }
                    array = tmpArray;
                    CoutArray();
                    return;
                }
                else
                {
                    Console.WriteLine("\nЧетных элементов нет в массиве.\n");
                    return;
                }
            }
        }
    }
}
