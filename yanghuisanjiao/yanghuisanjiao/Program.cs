using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace yanghuisanjiao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入杨辉三角的层数：");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("杨辉三角的层数={0}", n);

            /*
                        int[,] a = new int[n, 2 * n - 1];

                        for(int i=0;i<=n-1;i++)
                        {
                            for (int j = 0; j <= 2 * n - 1 - 1; j++)
                            {
                    
                                if (j<n-1)
                                {
                                    if (i == (n-1) - j) a[i, j] = 1;
                                    else if (i < (n-1) - j) a[i, j] = 0;
                                    else a[i, j] = a[i - 1, j - 1] + a[i - 1, j + 1];
                                }
                                else if(j==n-1)
                                {
                                    if (i == 0) a[i, j] = 1;
                                    else a[i, j] = a[i - 1, j - 1] + a[i - 1, j + 1];
                                }
                                else
                                {
                                    if (i == j-(n - 1)) a[i, j] = 1;
                                    else if (i < j-(n - 1)) a[i, j] = 0;
                                    else a[i, j] = a[i - 1, j - 1] + a[i - 1, j + 1];
                                }
                            }
                         }

            
                        for (int i = 0; i <= n - 1; i++)
                        {
                            for (int j = 0; j <= 2 * n - 1 - 1; j++)
                            {
                                if (a[i, j] == 0) Console.Write("  ");
                                else Console.Write("{0}", a[i, j]);
                                //Console.Write("[{0},{1}]", i, j);
                            }
                            Console.WriteLine();
                        }
            */
            int[,] a = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = n - 1; j >= i; j--)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j <= i; j++)
                {
                    if (j == 0 || j == i)
                    {
                        a[i, j] = 1;
                    }
                    else
                    {
                        a[i, j] = a[i - 1, j] + a[i - 1, j - 1];
                    }

                    Console.Write(" {0}", a[i, j]);
                    if (j == i)
                    {
                        Console.WriteLine();
                    }

                }
            }


            Console.ReadLine();
        }
    }
}
