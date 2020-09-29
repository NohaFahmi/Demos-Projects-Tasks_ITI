using System;

namespace D03_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            #region static
            //set 3 employees


            //emp1.setId(0);
            //emp1.setSalary(11500);
            //emp1.setGender(GenderTypes.F);
            //emp1.setHireDate(2015, "Jan", 3);



            //emp2.setId(1);
            //emp2.setSalary(3500);
            //emp2.setGender(GenderTypes.M);
            //emp2.setHireDate(2010, "March", 15);
            // HiringDate hd = emp2.getHDate();



            //emp3.setId(2);
            //emp3.setSalary(1500);
            //emp3.setGender(GenderTypes.M);
            //emp3.setHireDate(1980, "Dec", 31);


            //Console.WriteLine($"employee 3 has an id = {emp2.getId()} " +
            //$"and Salary = {emp2.getSalary()} and he is a {emp2.getGender()}" +
            //$"and he get hired on date of {hd.getFullDate()}");

            #endregion


            Employees emp1 = new Employees();
            Employees emp2 = new Employees();
            Employees emp3 = new Employees();

           
            //set an array for employees
            Employees[] empArr =
            {
                emp1,
                emp2,
                emp3
            };
            

            for (int i = 0; i < empArr.Length; i++)
            {
                Console.WriteLine("============ Enter a new employee's Data: ============");

                Console.WriteLine("============ Enter Employee's ID: ============");

                int userId = int.Parse(Console.ReadLine());
                empArr[i].setId(userId);

                Console.WriteLine("============ Enter Employee's SALARY (RANGE IS 1500:10000): ============");
                double userSalary = double.Parse(Console.ReadLine());
                empArr[i].setSalary(userSalary);

                Console.WriteLine("============ Enter Employee's Gender (F for Female ||  M for Male): ============");
                string userGender = Console.ReadLine();

                GenderTypes checkGender;
               
                while(!(Enum.TryParse(userGender, out checkGender)))
                {
                    
                        Console.WriteLine("Please, Enter F for Female or M for Male!");
                        userGender = Console.ReadLine();

                }

                if (checkGender == GenderTypes.M)
                {
                    empArr[i].setGender(checkGender);

                }
                else if (checkGender == GenderTypes.M)
                {
                    empArr[i].setGender(checkGender);
                }



                Console.WriteLine("============ Enter Employee's Hiring Date: ============");
                Console.WriteLine("============ Enter Day: ============");
                int input_d = int.Parse(Console.ReadLine());

                Console.WriteLine("============ Enter Month: ============");
                string input_m = Console.ReadLine();

                Console.WriteLine("============ Enter Year: ============");
                int input_y = int.Parse(Console.ReadLine());

                empArr[i].setHireDate(input_y, input_m, input_d);
                empArr[i].getHDate().getFullDate();
                

            }
            Console.WriteLine("============Employee's Data: ============");
            
            foreach (Employees emp in empArr)
            {
                
                Console.WriteLine($"The Employee with ID = {emp.getId()} " +
                $"has a Salary = {emp.getSalary()} and his/her gender is {emp.getGender()} " +
                $"and he/she has get hired on Date: {emp.getHDate().getFullDate()}.");
                Console.WriteLine("========================");
               
            }
            Console.WriteLine("============Employee's Data: ============");

        }
    }
}
