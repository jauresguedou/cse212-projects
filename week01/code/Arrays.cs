using System.Runtime.CompilerServices;

public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // I created the empty array to store the multiples of the number.
        double [] result = new double[length];

        // I declared a variable to store calculation result between the number and the length data.
        double multiplication;

        // I used a for loop to itirate throuh the length for multiplication and addition to the array.
        for(int i= 1; i <= length; i++)
        {
            // Calculate the number multiples 
            multiplication = i*number;
            // Assign each multiple a position into resulted array.
            result[i-1] = multiplication;
        }




        return result; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Identify how many elements are in the original list of data by using Count method.

        int  totalElement = data.Count;
        // Identify the starting point or the position from where numbers should be moved.
        int   startPosition = totalElement - amount;

        // Store temporarily the numbers we had to move into a variable.

        List<int> temporaryData = data.GetRange(startPosition,amount);

        //Remove the stored numbers from the  original list.

        data.RemoveRange(startPosition,amount);    
        
        // Insert the temporarily stored data at the beginning of the list
        data.InsertRange(0,temporaryData);

    }
}
