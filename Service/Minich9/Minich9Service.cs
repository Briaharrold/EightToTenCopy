namespace EightToTenCopy.Service.Minich9;
public class Minich9Service : IMinich9Service
{
        public string EightBall()
    {
        Random outCome = new Random();
        int number = outCome.Next(8);

        switch (number)
        {
            case 0:
                return "Outlook good";
            case 1:
                return "My sources say no";
            case 2:
                return "It is certain";
            case 3:
                return "Better not tell you now";
            case 4:
                return "Outlook is neutral.";
            case 5:
                return "Reply hazy, try again";
            case 6:
                return "Very doubtful.";
            default:
                return "YES!";

        }
    }
}
