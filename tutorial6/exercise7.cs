using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorial6
{
   class exercise7
    {
            static void Main()
            {
                while (true)
                {
                    double a;
                    char c;
                    double b;

                    // 使用if/else进行输入验证
                    if (!(double.TryParse(Console.ReadLine(), out a)))
                    {
                        Console.WriteLine("Please enter a number!");
                        continue;
                    }
                    if (!(char.TryParse(Console.ReadLine(), out c)))
                    {
                        Console.WriteLine("Please enter correct operator: + - * / ");
                        continue;
                    }
                    else if (!(c == '+' || c == '-' || c == '*' || c == '/'))
                    {
                        Console.WriteLine("Please enter correct operator: + - * / ");
                        continue;
                    }
                    if (!(double.TryParse(Console.ReadLine(), out b)))
                    {
                        Console.WriteLine("Please enter a number!");
                        continue;
                    }

                    try
                    {
                        if (c == '+')
                        {
                            Console.WriteLine($"{a} + {b} = {a + b}");
                        }
                        else if (c == '-')
                        {
                            Console.WriteLine($"{a} - {b} = {a - b}");
                        }
                        else if (c == '*')
                        {
                            Console.WriteLine($"{a} * {b} = {a * b}");
                        }
                        else if (c == '/')
                        {
                            Console.WriteLine($"{a} / {b} = {Math.Round((a / b), 2)}");
                        }
                    }
                    catch (DivideByZeroException ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}, division by zero is not allowed.");
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}, incorrect input format.");
                    }
                    finally
                    {
                      
                        Console.WriteLine("Calculation completed.");
                    }
                }
            }
        }

    }

