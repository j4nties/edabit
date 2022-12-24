//Creating Objects
Problem object_1 = new Problem();

var result = object_1.lessThanOrEqualToZero(5);

// Printing Variables
Console.WriteLine(result);

// Class
class Problem
{   
    public bool lessThanOrEqualToZero(double numb)
    {
        return numb<=0;
    }
}
