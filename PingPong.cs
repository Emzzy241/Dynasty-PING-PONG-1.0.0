using System;
using System.Collections.Generic; // as you can see, this one is greyed out, don't forget that we added it to ensure we could use our Dictionary anytime any day
// a Dictionary is capable of storing strings and integers at a time


class PingPong
{
    static void Main()
    {
        // after our Main entrypoint, we now move on to writing our Ping Pong Application

        Console.WriteLine("Hello My Beautiful User, Welcome to the Dynasty's PING PONG Tournament");
        Console.WriteLine("Please Enter a Number greater than 0");

        // saving user's number and turning it into an double; a double can account for oth integer and decimal numbers





        string userNumberInString = Console.ReadLine();

        int userNumber = int.Parse(userNumberInString);


        // a new feature that will run the Main() method again if user inputs a number less than 1
        // if (userNumber < 1)
        // {
        //     Main();
        // }

        // running a for loop to show users all numbers less than the njumber user enterred 
        // this message shouldn't be added to the forloop, it keeps showing it for every iteration of the loop and that is very Ugly

        Console.WriteLine("Here are the numbers less than " + userNumber);

        for (int lesserNumber = 1; lesserNumber <= userNumber; lesserNumber++)

        {
            // Console.WriteLine(lesserNumber); ... This is not needed, our forloop prints out the lesser numbers anyway


            // running a branch to determine if we have a ping, or a pong, or a ping-pong
            // FOR Ping: I used the modulo operator here to determine if I can divide any of the lesserNumber by 3
            if ((lesserNumber % 3 == 0 && lesserNumber % 5 == 0))
            {
                Console.WriteLine("Ping-Pong");

                // string newLesserNumber = lesserNumber.ToString();
            }

            else if(lesserNumber % 3 == 0){
                Console.WriteLine("Ping");
            }

            else if(lesserNumber % 5 == 0){
                Console.WriteLine("Pong");
            }
            else
            {
                Console.WriteLine(lesserNumber);
            }
        }

        // Console.WriteLine("Enter a number greater than 0.");
        // string stringNumber = Console.ReadLine();
        // int inputtedNumber = int.Parse(stringNumber);
        // Console.WriteLine("--------------------");
        // for (int index = 1; index <= inputtedNumber; index++)
        // {
        //     if ((index % 3 == 0) && (index % 5 == 0))
        //     {
        //         Console.WriteLine("Ping-Pong");
        //     }
        //     else if (index % 5 == 0)
        //     {
        //         Console.WriteLine("Pong");
        //     }
        //     else if (index % 3 == 0)
        //     {
        //         Console.WriteLine("Ping");
        //     }
        //     else
        //     {
        //         Console.WriteLine(index);
        //     }
        // }

    }
}

// CODES THAT WERE NOTNEEDED FOR APPLICATION

// // newLesserNumber.Replace("3", "Ping");

// Console.WriteLine(newLesserNumber);



// string pingString = lesserNumber.ToString();

// pingString.Replace("3", "Ping");
// pingString.Remove(1);

// Console.WriteLine("Ping");

// Console.WriteLine(pingString);