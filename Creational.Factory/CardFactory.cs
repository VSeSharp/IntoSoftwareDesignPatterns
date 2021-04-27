namespace Creational.Factory
{
    public class CardFactory
    {
        public static Card GetCard(string cardType)
        {
            Card cardDetails = null;
            if (cardType == "Gold")
            {
                cardDetails = new Gold();
            }
            else if (cardType == "Platinum")
            {
                cardDetails = new Platinum();
            }
            else if (cardType == "Red")
            {
                cardDetails = new Red();
            }
            return cardDetails;
        }
    }
}
