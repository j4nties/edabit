string cupWithBall = "B";

var result = CupSwapping(new String[] {"BC", "CB", "CA", "BA" });

Console.WriteLine($"The cup with the ball is: {result}");

//function 
string CupSwapping(string[] swaps) 
{
    // creating string list(array) named listSwaps = { "AB", "CA" }
    List<string> listSwaps = swaps.ToList();
    // for each swapping actions "XY" do...
    foreach ( string currentSwap in listSwaps)
    {
        // checks if ball is inside of any of this cups if yes then do...
        if (currentSwap.Contains(cupWithBall))
        {
            // take index of cupwithball
            int ballIndex = currentSwap.IndexOf(cupWithBall);
            if (ballIndex == 0)
            {
                cupWithBall = currentSwap[1].ToString();
            }else
            {
                cupWithBall = currentSwap[0].ToString();
            }
        }
    }
    return(cupWithBall);
}




