using System;
using System.Collections.Generic; // as you can see, this one is greyed out, don't forget that we added it to ensure we could use our Dictionary anytime any day
// a Dictionary is capable of storing strings and integers at a time


class PingPong{
    static void Main(){
        // after our Main entrypoint, we now move on to writing our Ping Pong Application

        Console.WriteLine("Hello My Beautiful User, Welcome to the Dynasty's PING PONG Tournament");
        Console.WriteLine("Please Enter any Number of your Choice");

        // saving user's number and turning it into an double; a double can account for oth integer and decimal numbers

        string userNumberInString = Console.ReadLine();

        double userNumber = double.Parse(userNumberInString);

        // running a for loop to show users all numbers less than the njumber user enterred 
            // this message shouldn't be added to the forloop, it keeps showing it for every iteration of the loop and that is very Ugly

            Console.WriteLine("Here are the numbers less than " + userNumber);

        for (int lesserNumber = 1; lesserNumber <= userNumber; lesserNumber++)
        
        {
            Console.WriteLine(lesserNumber);
            
            // running a branch to determine if we have a ping, or a pong, or a ping-pong
            // FOR Ping: I used the modulo operator here to determine if I can divide any of the lesserNumber by 3
            if(lesserNumber % 3 == 0){
                // Console.Write("Ping");

                Console.WriteLine("Ping");
                
            }
        }

        
        
    }
}