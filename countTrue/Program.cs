//Creating Objects
Problem test1 = new Problem();
bool[] myArray = {true, false, false, true, false};
int result = test1.countTrue(myArray);
// Printing Variables
Console.WriteLine(result);
// Class
class Problem
{
    //Method
    public int countTrue(bool[] myArray)
    {
        //if array is empty {} return 0
        int counter = 0;
        if (myArray.Length == 0) 
        {
            return 0;
        }
        foreach (bool item in myArray)
        {
            //item == true
            if(item){ 
                counter++;
            }
        }
        return counter;
    }
}
