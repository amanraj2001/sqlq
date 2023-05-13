
using System.Linq;
namespace linqAssignment
{
    internal class Program
    {




        class employee
        {
            public int EmployeeId { get; set; }
            public string Firsname { get; set; }
            public string Lastname { get; set; }
            public int Salary { get; set; }
            public DateTime Joining_date { get; set; }
            public string department { get; set; }


        }

        class Incentive
        {

            public int Employee_ref_id { get; set; }
            public DateTime Incentive_date { get; set; }
            public int Incentive_amount { get; set; }

        }



        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //employee[] employee = new employee[8];

            List<employee> employees = new List<employee>()
            {


            new employee() {EmployeeId=1,Firsname="John",Lastname="Abraham",Salary=1000000,Joining_date=new DateTime(2013, 01, 01, 12, 00, 00),department="Banking"},

            new employee() { EmployeeId = 2, Firsname = "Michael", Lastname = "Clarke", Salary = 800000, Joining_date = new DateTime(2013, 01, 01, 12, 00, 00), department = "Insurance" },

            new employee() { EmployeeId = 3, Firsname = "Roy", Lastname = "Thomas", Salary = 700000, Joining_date = new DateTime(2013, 02, 01, 12, 00, 00), department = "Banking" },

            new employee() { EmployeeId = 4, Firsname = "Tom", Lastname = "Jose", Salary = 600000, Joining_date = new DateTime(2013, 02, 01, 12, 00, 00), department = "Insurance" },

            new employee() { EmployeeId = 5, Firsname = "Jerry", Lastname = "Pinto", Salary = 650000, Joining_date = new DateTime(2013, 02, 01, 12, 00, 00), department = "Insurance" },
            new employee() { EmployeeId = 6, Firsname = "Philip", Lastname = "Mathew", Salary = 750000, Joining_date = new DateTime(2013, 01, 01, 12, 00, 00), department = "Services" },

            new employee() { EmployeeId = 7, Firsname = "TestName1", Lastname = "123", Salary = 650000, Joining_date = new DateTime(2013, 01, 01, 12, 00, 00), department = "Services" },

            new employee() { EmployeeId = 8, Firsname = "TestName2", Lastname = "Lname%", Salary = 600000, Joining_date = new DateTime(2013, 02, 01, 12, 00, 00), department = "Insurance" },
        };


            //Incentive[] incentives = new Incentive[5];

            List<Incentive> incentive = new List<Incentive>()
        {

        new Incentive() { Employee_ref_id = 1,Incentive_date = new DateTime(2013 - 02 - 01),Incentive_amount = 5000 },
        new Incentive() { Employee_ref_id = 2, Incentive_date = new DateTime(2013 - 02 - 01), Incentive_amount = 3000 },
         new Incentive() { Employee_ref_id = 3, Incentive_date = new DateTime(2013 - 02 - 01), Incentive_amount = 4000 },
         new Incentive() { Employee_ref_id = 1, Incentive_date = new DateTime(2013 - 01 - 01), Incentive_amount = 4500 },
        new Incentive() { Employee_ref_id = 2, Incentive_date = new DateTime(2013 - 01 - 01), Incentive_amount = 3500 },

        };



            //foreach (var item in employees)
            //{
            //    Console.WriteLine(item.EmployeeId);
            //}


            var ques2 = from s in employees
                        select s;

            //for (int i= 0; i< employees.Count;i++)
            //{
            //    Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t", employees[i].EmployeeId, employees[i].Firsname, employees[i].Lastname, employees[i].Salary,employees[i].department);
            //}
            foreach(var i in ques2)
            {
                Console.WriteLine(i.Firsname + " " + i.Lastname + " " + i.Salary + " " + i.Joining_date + " " + i.department);
            }
            Console.WriteLine("------------------------question-3---------------------------");
            //q3
            var que3 = from s in employees
                       select s;

            foreach(var i in que3)
            {
                Console.WriteLine(i.Firsname+" " + i.Lastname);
            }

            Console.WriteLine("------------------------question-4---------------------------");
            var que4 = from s in employees
                       let Employeename = s.Firsname
                       select Employeename  ;
            
            foreach(var i in que4)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("------------------------question-5---------------------------");

            var que5 = from s in employees
                       select s;

            foreach (var i in que5)
            {
                Console.WriteLine(i.Firsname.ToUpper());
            }
            Console.WriteLine("------------------------question-6---------------------------");
            var que6 = from s in employees
                       select s;

            foreach(var i in que6)
            {
                Console.WriteLine(i.Firsname.ToLower());
            }
            Console.WriteLine("------------------------question-7---------------------------");

            var que7 = (from s in employees
                       select s.department).Distinct();
            foreach( var i in que7)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("------------------------question-8---------------------------");


            var que8 = from s in employees
                       select s.Firsname.Substring(0, 3);
            foreach(var i in que8)
            {
                Console.WriteLine(i);
            }


            Console.WriteLine("------------------------question-9---------------------------");

            var que9 = from s in employees
                       where s.Firsname == "John"
                       select s.Firsname.IndexOf("o");

            foreach(var i in que9)
            {

            Console.WriteLine(i);
            }

            Console.WriteLine("------------------------question-10---------------------------");
            var que10 = from s in employees
                        select s.Firsname.TrimEnd();

            foreach(var i in que10)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("------------------------question-11---------------------------");

            var que11 = from s in employees
                        select s.Firsname.TrimStart();
            foreach(var i in que11)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("------------------------question-12---------------------------");

            var que12 = from s in employees
                        select s.Firsname.Length;

            foreach(var i in que12)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("------------------------question-13---------------------------");

            var que13 = from s in employees
                        select s.Firsname.Replace("o", "$");

            foreach(var i  in que13)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("------------------------question-14---------------------------");

            var que14 = from s in employees
                        select s;
            foreach(var i in que14)
            {
                Console.WriteLine(i.Firsname+" "+i.Lastname);
            }
            Console.WriteLine("------------------------question-15---------------------------");

            var que15 = from s in employees
                        select s;
            foreach(var i in que15)
            {
                Console.WriteLine(i.Firsname+" "+i.Joining_date.Year+" "+i.Joining_date.Month+" "+i.Joining_date.Day);

            }
            Console.WriteLine("------------------------question-16---------------------------");
            var que16 = from s in employees
                        orderby s.Firsname
                        select s;
            foreach(var i in que16)
            {
                Console.WriteLine(i.Firsname+" "+i.Lastname+" "+i.Joining_date+" "+i.department);
            }
            Console.WriteLine("------------------------question-17---------------------------");

            var que17 = from s in employees
                        orderby s.Firsname descending
                        select s;
            foreach (var i in que17)
            {
                Console.WriteLine(i.Firsname + " " + i.Lastname + " " + i.Joining_date + " " + i.department);
            }

            Console.WriteLine("------------------------question-18---------------------------");

            var que18 = from s in employees
                        orderby s.Firsname ascending
                        orderby s.Salary descending
                        select s;

            foreach(var i in que18)
            {
                Console.WriteLine(i.Firsname + " " + i.Lastname + " " + i.Joining_date + " " + i.department);
            }


            Console.WriteLine("------------------------question-19---------------------------");

            var que19 = from s in employees
                        where s.Firsname=="John"
                        select s;
            foreach(var i in que19)
            {
                Console.WriteLine(i.Firsname+" "+i.Lastname+" "+i.Salary+" "+i.department);
            }


            Console.WriteLine("------------------------question-20---------------------------");

            var que20= from s in employees
                       where (s.Firsname=="John" || s.Firsname=="Roy")
                       select s;
            foreach(var i in que20)
            {
                Console.WriteLine(i.Firsname + " " + i.Lastname + " " + i.Salary + " " + i.department);

            }


            Console.WriteLine("------------------------question-21---------------------------");

            var que21 = from s in employees
                        where (s.Firsname!="John" && s.Firsname != "Roy")
                        select s;

            foreach(var i in que21)
            {
                Console.WriteLine(i.Firsname + " " + i.Lastname + " " + i.Salary + " " + i.department);
            }

            Console.WriteLine("------------------------question-22---------------------------");


            var que22 = from s in employees
                        where s.Firsname.StartsWith('J')
                        select s;
            foreach(var  i in que22)
            {
                Console.WriteLine(i.Firsname + " " + i.Lastname + " " + i.Salary + " " + i.department);

            }


            Console.WriteLine("------------------------question-23---------------------------");

            var que23 = from s in employees
                        where s.Firsname.Contains("o")
                        select s;
            foreach(var i in que23)
            {
                Console.WriteLine(i.Firsname + " " + i.Lastname + " " + i.Salary + " " + i.department);
            }
            Console.WriteLine("------------------------question-24---------------------------");
            var que24 = from s in employees
                        where s.Firsname.EndsWith("n")
                        select s;

            foreach(var i in que24)
            {
                Console.WriteLine(i.Firsname + " " + i.Lastname + " " + i.Salary + " " + i.department);

            }

            Console.WriteLine("------------------------question-25---------------------------");

            var que25 = from s in employees
                        where (s.Firsname.EndsWith("n") && s.Firsname.Length == 4)
                        select s;
            foreach(var i in que25)
            {
                Console.WriteLine(i.Firsname + " " + i.Lastname + " " + i.Salary + " " + i.department);
            }

            Console.WriteLine("------------------------question-26---------------------------");

            var que26 = from s in employees
                        where (s.Firsname.StartsWith("J") && s.Firsname.Length == 4)
                        select s;

            foreach(var i in que26)
            {
                Console.WriteLine(i.Firsname + " " + i.Lastname + " " + i.Salary + " " + i.department);
            }

            Console.WriteLine("------------------------question-27---------------------------");

            var que27 = from s in employees
                        where s.Salary > 600000
                        select s;
            foreach(var i in que27)
            {
                Console.WriteLine(i.Firsname + " " + i.Lastname + " " + i.Salary + " " + i.department);

            }

            Console.WriteLine("------------------------question-28---------------------------");
            var que28 = from s in employees
                        where s.Salary < 800000
                        select s;
            foreach(var i in que28)
            {
                Console.WriteLine(i.Firsname + " " + i.Lastname + " " + i.Salary + " " + i.department);

            }

            Console.WriteLine("------------------------question-29---------------------------");

            var que29 = from s in employees
                        where (s.Salary > 500000 && s.Salary < 800000)
                        select s;
            foreach(var i in que29)
            {
                Console.WriteLine(i.Firsname + " " + i.Lastname + " " + i.Salary + " " + i.department);

            }

            Console.WriteLine("------------------------question-30---------------------------");

            var que30 = from s in employees
                        where (s.Firsname == "John" && s.Firsname == "Michael")
                        select s;

            foreach(var i in que30)
            {
                Console.WriteLine(i.Firsname + " " + i.Lastname + " " + i.Salary + " " + i.department);
            }

            Console.WriteLine("------------------------question-31---------------------------");
            var que31 = from s in employees
                        where s.Joining_date.Year == 2013
                        select s;

            foreach(var i in que31)
            {
                Console.WriteLine(i.Firsname + " " + i.Lastname + " " + i.Salary + " " + i.department);

            }
            Console.WriteLine("------------------------question-32---------------------------");

            var que32 = from s in employees
                        where s.Joining_date.Month == 1
                        select s;
            foreach (var i in que32)
            {
                Console.WriteLine(i.Firsname + " " + i.Lastname + " "+i.Joining_date+" " + i.Salary + " " + i.department);

            }

            Console.WriteLine("------------------------question-33---------------------------");
            var que33 = from s in employees
                        where s.Joining_date.Date < new DateTime(2013,01, 31)
                        select s;

            foreach (var i in que33)
            {
                Console.WriteLine(i.Firsname + " " + i.Lastname + " " + i.Joining_date + " " + i.Salary + " " + i.department);

            }

            Console.WriteLine("------------------------question-34---------------------------");

            var que34 = from s in employees
                        where (s.Joining_date.Month>1 && s.Joining_date.Day>31)
                        select s;

            foreach (var i in que34)
            {
                Console.WriteLine(i.Firsname + " " + i.Lastname + " " + i.Joining_date + " " + i.Salary + " " + i.department);

            }























        }
    }
}
