//Creating Objects
Problem object_1 = new Problem();

string result = object_1.Bomb("There is a bomb.");

// Printing Variables
Console.WriteLine(result);


// Class
class Problem
{
    //Method checks if there is a bomb word in sentence
    public string Bomb(string sentence) //detect the bomb
    {
        sentence = sentence.ToLower();  //converting string lowercase form
        if (sentence.Contains("bomb")){
            return "Duck!!!";
        }else
        {
            return "There is no bomb, relax.";
        }
    }
}