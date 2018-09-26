public class Mains {
    public static void Main (string [] args)
    {
      Company company=new Company();
Employee Boris= new PartTimeEmployee(3,200,"Boris");
Employee OPulaBelita= new FullTimeEmployee(500,"Lelic");
company.EmployNewEmployee(Boris);
company.EmployNewEmployee(OPulaBelita);
System.Console.WriteLine(company.GetMonthlySalaryTotal());

    }
}