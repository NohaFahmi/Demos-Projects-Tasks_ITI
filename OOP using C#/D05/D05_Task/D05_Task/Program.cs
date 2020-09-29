using System;
using System.Buffers;
using System.Net.NetworkInformation;

namespace D05_Task
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Q.1:
            Console.WriteLine("----------------Point 3D -----------------");

            Point3D point_1 = new Point3D();//(15, 6, 9)

            Point3D point_2 = new Point3D(); //(5, 2, 3)

            for (int i = 0; i < 2; i++)
            {

                Console.WriteLine($"Enter The point {i + 1} Coordinate of X: ");
                string user_X = Console.ReadLine();
                int p_x;
                while (!(int.TryParse(user_X, out p_x)))
                {
                    Console.WriteLine($"Enter The point {i + 1} Coordinate of X: ");
                    user_X = Console.ReadLine();
                }

                Console.WriteLine($"Enter The point {i + 1} Coordinate of Y: ");
                string user_Y = Console.ReadLine();
                int p_y;
                while (!(int.TryParse(user_Y, out p_y)))
                {
                    Console.WriteLine($"Enter The point {i + 1} Coordinate of Y: ");
                    user_Y = Console.ReadLine();
                }


                Console.WriteLine($"Enter The point {i + 1} Coordinate of Z: ");
                string user_Z = Console.ReadLine();
                int p_z;

                while (!(int.TryParse(user_Z, out p_z)))
                {
                    Console.WriteLine($"Enter The point {i + 1} Coordinate of Z: ");
                    user_Z = Console.ReadLine();
                }

                if (i == 0)
                {
                    point_1 = new Point3D(p_x, p_y, p_z);
                    Console.WriteLine(point_1.ToString());

                }
                if (i == 1)
                {
                    point_2 = new Point3D(p_x, p_y, p_z);

                    Console.WriteLine(point_2.ToString());
                }
            }

            Console.WriteLine("-----Operations-------");

            Point3D point_3 = point_1 + point_2;//(20, 8, 12)
            Console.WriteLine(point_3.Show());

            Point3D point_4 = point_1 - point_2; //(10, 4, 6)
            Console.WriteLine(point_4.Show());

            Point3D point_5 = point_1 * point_2; //(75, 12, 27)
            Console.WriteLine(point_5.Show());

            Point3D point_6 = point_1 / point_2;//(3, 3, 3)
            Console.WriteLine(point_6.Show());

            Point3D point_7 = ++point_1; //(16, 7, 10)
            Console.WriteLine(point_7.Show());

            Point3D point_8 = --point_2; //(4, 1, 2)
            Console.WriteLine(point_8.Show());

            Console.WriteLine(point_1 > point_2); //true
            Console.WriteLine(point_1 < point_2); //false

            #endregion

            Console.WriteLine("----------------Calculator V1-----------------");

            #region Q.2:

            Calculator calc = new Calculator(4, 6);
            Console.WriteLine(calc.Add());
            Console.WriteLine(calc.Substract());
            Console.WriteLine(calc.Multiple());
            Console.WriteLine(calc.Divide());
            #endregion

            Console.WriteLine("----------------Calculator V2-----------------");

            #region Q.3:

            Console.WriteLine(Calculator_1.Add(3, 10));

            Console.WriteLine(Calculator_1.multiple(3, 10));


            Console.WriteLine(Calculator_1.Substract(3, 10));


            Console.WriteLine(Calculator_1.Divide(3, 2));
            Console.WriteLine(Calculator_1.Divide(3, 10));


            #endregion
            Console.WriteLine("----------------End-----------------");

        }
    }
}

