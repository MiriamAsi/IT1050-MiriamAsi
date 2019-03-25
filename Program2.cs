// Fig. 4.1: Gradebook.cs
//Class declaration with one method.
using System;

public class GradeBook
{
    //display a welcome message to the GradeBook user
    public void DisplayMessage()
    {
        Console.WriteLine( "Hello World from Miriam!" );
    } // end method DisplayMessage
} // end class GradeBook
// Fig. 4.2: GradeBookTest.cs
// Create a GradeBook object and call its DisplayMessage Method.
public class GradeBookTest
{
    // Main method begins program execution
    public static void Main(string[] args)
    {
        // create a GradeBook object and assign it myGradeBook
        Gradebook myGradeBook = new GradeBook();

        // call myGradeBook's DisplayMethod method
        myGradeBook.DisplayMessage();
    } //end Main
} // end class GradeBookTest
   
