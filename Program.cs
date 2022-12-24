// Creating Objects
Problem test1 = new Problem();

bool result;

result = test1.lessThan100(96,4);

// Printing Variables
Console.WriteLine(result);

// Class
class Problem
{
    // Method 
    public bool IsEqual(int num1, int num2)
    {
        // if same numbers return true
        if(num1==num2)
        {
            return true;
        }else
        {
            return false;
        }
    }
    public bool lessThan100(int num1, int num2)
    {
        if( num1 + num2 >= 100)
        {
            return false;
        }else
        {
            return true;
        }
    }
}