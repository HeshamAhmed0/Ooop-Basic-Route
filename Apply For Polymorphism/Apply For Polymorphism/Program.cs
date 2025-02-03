namespace Apply_For_Polymorphism
{
    internal class Program
    {
        public static void GetEmployeeInfo(Employee employee)
        {
            if (employee is not null)
            {
                employee.GetType();
                employee.GetDetails();
            }
        }
        static void Main(string[] args)
        {
            PartTimeEmployee partTimeEmployeeobj = new PartTimeEmployee(10,"Hesham",20,20);
            GetEmployeeInfo(partTimeEmployeeobj);

            FullTimeEmployee fullTimeEmployeeobj = new FullTimeEmployee(10,"Hesham",50,500);
        }
    }
}
