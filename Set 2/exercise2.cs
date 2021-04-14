//Exercise 2
//Is the following code easily maintainable? How would you improve it? 
public class Product
{
//...//
    public decimal Price()
    {
        if (UOM.Equals("grams"))
            return Quantity * 6m / 1000;
      
        if (UOM.Equals("bottle"))
            return Quantity * 3m; 
      
        var total = 0m;
        if (UOM.Equals("bag"))
        {
            total += Quantity * .2m;
            var setsOfFour = Quantity / 4;
            total -= setsOfFour * .15m; //discount on groups of 4 items
            return total;
        }
        return 0m;
    }
}