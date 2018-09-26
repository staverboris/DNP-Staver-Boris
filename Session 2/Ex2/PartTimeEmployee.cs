public class PartTimeEmployee : Employee{
    private double hourlyWage;
    private int hoursPerMonth;
    
    public PartTimeEmployee(double hourlyWage, int hoursPerMonth,string name)
    :base(name)
    {
this.hourlyWage=hourlyWage;
this.hoursPerMonth=hoursPerMonth;
    }
    public override double GetMonthlySalary(){
      double sum;
      sum=hourlyWage*hoursPerMonth;
      return sum;
    }
}