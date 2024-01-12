
namespace EightToTenCopy.Service.Minich10;

public class Minich10Service : IMinich10Service
{

    public string RestarauntPicker( string category )
    {
         
            string[] restaurants = new string[10];

        switch (category.ToUpper())
        {
            case "MEXICAN":
                restaurants[0] = "El Mayita";
                restaurants[1] = "El Senor Frog's";
                restaurants[2] = "Tepa Taqueria";
                restaurants[3] = "Taco House Mexican Grill";
                restaurants[4] = "El Frutal";
                restaurants[5] = "Maria's Taqueria & Meat Market";
                restaurants[6] = "Don Luis Mexican Restaurant";
                restaurants[7] = "Taco's La Palmita";
                restaurants[8] = "Casa Flores Mexican Restaurant";
                restaurants[9] = "Tonantzin";
                break;
            case "SEAFOOD": 
                restaurants[0] = "Sotto Mare Oysteria & Seafood";
                restaurants[1] = "Captain Crab";
                restaurants[2] = "Thanh Long";
                restaurants[3] = "Tadich Grill";
                restaurants[4] = "Basa Seafood Express";
                restaurants[5] = "Bar Crudo";
                restaurants[6] = "Woodhouse Fish";
                restaurants[7] = "Anchor Oyster Bar";
                restaurants[8] = "Scoma's Restaurant";
                restaurants[9] = "Hog Island Oyster Co";
                break;

            case "THAI":
                restaurants[0] = "GK Mongolian BBQ";
                restaurants[1] = "Happy Lamb Hot Pot";
                restaurants[2] = "Fresh Grill Mongolian BBQ";
                restaurants[3] = "Mings";
                restaurants[4] = "Golden Palace";
                restaurants[5] = "Beijing Buffet";
                restaurants[6] = "Swagat";
                restaurants[7] = "Sizzling Fresh Mongolian BBQ";
                restaurants[8] = "Gobi Mongolian Grill";
                restaurants[9] = "Hunan House Mongolian BBQ & Bar";
                break;
            default:
                return "Not a valid input. Please type Thai, Seafood or Mexican";
        }

        Random r = new();
        int randomRes = r.Next(10);

        return $"I Would Suggest {restaurants[randomRes]}.";
    }

}




