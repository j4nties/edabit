// Creating Objects
Problem test1 = new Problem();

var result = test1.ArrayOfMultiples(5,7);
// Printing Variables
Console.WriteLine(result);

// Class
class Problem
{
    // Method 
    public string ArrayOfMultiples(int num, int length)
    {
        int[] myArray = new int[length];
        for( int i = 0; i < length; i++ )
        {
            myArray[i] = (i+1) * num;
            Console.WriteLine(myArray[i]);
        }
        return $"[{string.Join(", ", myArray)}]";
    }
}
