using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EightToTenCopy.Service.Minich8
{
    public class Minich8Service : IMinich8Service
    {
 

        public string GuessItEasy(string guess)
    {
        if (int.TryParse(guess, out int number))
        {
            Random r = new();
            int randNumber = r.Next(1, 11);
            string response = "";

            if (number > randNumber)
            {
                response = $"The number you chose {number} is greater than {randNumber}.";
            }
            else if (number < randNumber)
            {
                response = $"The number you chose {number} is less than {randNumber}.";
            }
            else
            {
                response = $"Congratulations!! the number was {number} it took you {randNumber} guesses to get it right. Great job!!";
            }
            return response;
        }
        return "Invalid input.";
    }

    public string GuessItHard(string guess)
    {
        if (int.TryParse(guess, out int number))
        {
            Random r = new();
            int randNumber = r.Next(1, 101);
            string response = "";

            if (number > randNumber)
            {
              response = $"The number you chose {number} is greater than {randNumber}.";
            }
            else if (number < randNumber)
            {
                    response = $"The number you chose {number} is less than {randNumber}.";
            }
            else
            {
               response = $"Congratulations!! The number was {number} it took you {randNumber} guesses to get it right. Great job!!";
            }
            return response;
        }
        return "Invalid input.";
    }

    public string GuessItMedium(string guess)
    {
        if (int.TryParse(guess, out int number))
        {
            Random r = new();
            int randNumber = r.Next(1, 51);
            string response = "";

            if (number > randNumber)
            {
              response = $"The number you chose {number} is greater than {randNumber}.";
            }
            else if (number < randNumber)
            {
                  response = $"The number you chose {number} is less than {randNumber}.";
            }
            else
            {
                response = $"Congratulations!! The number was {number} it took you {randNumber} guesses to get it right. Great job!!";
            }
            return response;
        }
        return "Invalid input.";
    }
    }
    }