//Exercise 3
//How would you improve the maintainability of the following code? 
public class Employee 
{
    private int _type;
    static int ENGINEER = 0;
    static int SALESMAN = 1;
    static int MANAGER = 2;
    public double MonthlySalary {get; set;}
    public double Commission {get; set;}
    public double Bonus {get; set;}
    public Employee (int type) { _type = type; }
    public int GetPaymentAmount() 
    {
      switch (_type) {
        default:
        case 0:
            return MonthlySalary;
        case 1:
            return MonthlySalary + Commission;
        case 2:
            return MonthlySalary + Bonus;
      }
    }
}