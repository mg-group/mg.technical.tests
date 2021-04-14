//Exercise 1
//How would you make the following method more readable?


double getPaymentAmount() 
{
    double result;
    if (_isDead)
    {
         result = GetDeadAmount();
    }
    else 
    {
        if (_isSeparated) 
        {
            result = GetSeparatedAmount();
        }
        else 
        {
            if (_isRetired)
            {
                result = GetRetiredAmount();
            }
            else
            {
                result = GetNormalPayAmount();
            }
        }
     }
  return result;
}