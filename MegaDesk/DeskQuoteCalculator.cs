namespace MegaDesk
{
    public class DeskQuoteCalculator
    {
        public int CalculateQuotePrice(Desk desk, RushOption rush)
        {
            int totalPrice = 200;

            //Add surface cost
            totalPrice += ((int)desk.surface);

            //Add drawers cost
            totalPrice += 50 * desk.numberDrawers;

            //Add desk area cost
            int deskArea = desk.width * desk.depth;

            //Add rush price
            totalPrice += AddRush(rush, deskArea);

            return totalPrice;
            
        }

        public int AddRush(RushOption rush, int deskArea)
        {
            int rushPrice;
            switch (rush)
            {
                case RushOption.Three:
                    if (deskArea < 1000)
                    {
                        rushPrice = 60;
                    }
                    else if (deskArea >= 1000 && deskArea <= 2000)
                    {
                        rushPrice = 70;
                    }
                    else
                    {
                        rushPrice = 80;
                    }
                    break;

                case RushOption.Five:
                    if (deskArea < 1000)
                    {
                        rushPrice = 40;
                    }
                    else if (deskArea >= 1000 && deskArea <= 2000)
                    {
                        rushPrice = 50;
                    }
                    else
                    {
                        rushPrice = 60;
                    }
                    break;

                case RushOption.Seven:
                    if (deskArea < 1000)
                    {
                        rushPrice = 30;
                    }
                    else if (deskArea >= 1000 && deskArea <= 2000)
                    {
                        rushPrice = 35;
                    }
                    else
                    {
                        rushPrice = 40;
                    }
                    break;

                default:
                    rushPrice = 0;
                    break;
            }
            return rushPrice;
        
        }
    }
}