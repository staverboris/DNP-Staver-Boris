using System.Collections.Generic;
using System.Linq;

public class Company{
    private List<Employee> employs;
    public Company(){
        employs=new List<Employee>();
            }
    public double GetMonthlySalaryTotal(){
        double total=0;
        for(int i=0; i<employs.Count();i++){
         total+= employs[i].GetMonthlySalary();
         
        }
        return total;
       
    }
     public void EmployNewEmployee(Employee newEmployee){
            employs.Add(newEmployee);
       
        }
}