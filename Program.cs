// Creating Objects
Problem test1 = new Problem();
Problem test2 = new Problem();

bool result1, result2;

result1 = test1.IsEqual(5,6);
result2 = test1.IsEqual(3,3);

// Printing Variables
Console.WriteLine(result1);
Console.WriteLine(result2);

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
}