using System.Globalization;

namespace Assignment2
{

    #region 1
    internal class Employee
    {
        #region Attributes

        private int id;
        private string name;
        private double salary;
        private Gender gender;
        private HiringDate hireDate;
        private Security securityLevel;

        #endregion

        public Employee(int _id, string _name, double _salary, Gender _gneder, HiringDate _hireDate, Security _securityLevel)
        {
            id = _id;
            name = _name;
            salary = _salary;
            gender = _gneder;
            hireDate = _hireDate;
            securityLevel = _securityLevel;
        }

        #region Property

        public Gender Gender
        {
            get { return gender; }
            set { gender = value; }
        }


        public HiringDate HireDate
        {
            get { return hireDate; }
            set { hireDate = value; }
        }


        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }


        public Security SecurityLevel
        {
            get { return securityLevel; }
            set { securityLevel = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        #endregion

        #region 5
        public override string ToString()
        {
            return string.Format(new CultureInfo("en-US"), "{0:C}", salary); ;
        }
        #endregion

    }

    #endregion

    #region 2

    internal class HiringDate
    {
        private int day;
        private int month;
        private int year;

        public HiringDate(int _day, int _month, int _year)
        {
            day = _day;
            month = _month;
            year = _year;
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }


        public int Month
        {
            get { return month; }
            set { month = value; }
        }


        public int Day
        {
            get { return day; }
            set { day = value; }
        }

        #region 5

        public override string ToString()
        {
            return $"{day}-{month}-{year}";
        }
        #endregion

    }

    #endregion

    #region 3

    enum Gender
    {
        M, F
    }
    #endregion

    #region 4
    [Flags]
    enum Security
    {
        Guest = 1, Developer = 2, Secretary = 4, DBA = 8
    }

    #endregion


    internal class Program
    {
        static void Main()
        {
            #region 6

            Employee[] employee = new Employee[3];
            employee[0].SecurityLevel = Security.DBA;
            employee[1].SecurityLevel = Security.Guest;
            employee[2].SecurityLevel = Security.DBA;
            employee[2].SecurityLevel |= Security.Guest;
            employee[2].SecurityLevel |= Security.Developer;
            employee[2].SecurityLevel |= Security.Secretary;

            #endregion

            #region 7
            employee.OrderBy(emp => emp.HireDate);
            foreach (Employee emp in employee)
            {
                Console.WriteLine(emp.Id);
                Console.WriteLine(emp.Name);
                Console.WriteLine(emp.Salary);
                Console.WriteLine(emp.Gender);
                Console.WriteLine(emp.HireDate);
                Console.WriteLine(emp.SecurityLevel);
            }
            #endregion
        }

    }
}
