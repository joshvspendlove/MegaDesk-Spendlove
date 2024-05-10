using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Spendlove
{
    public static class EnumExtensions
    {
        public static string GetDescription(this Enum value)
        {
            var fieldInfo = value.GetType().GetField(value.ToString());
            var descriptionAttributes = (DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);
            return descriptionAttributes.Length > 0 ? descriptionAttributes[0].Description : value.ToString();
        }
    }

    public enum RushLevel
    {
        [Description("No Rush")]
        NO_RUSH,
        [Description("3 Day Rush")]
        RUSH_3,
        [Description("5 Day Rush")]
        RUSH_5,
        [Description("7 Day Rush")]
        RUSH_7
    }

    public enum QuoteState
    {
        COMPLETE,
        PENDING,
        INVALID
    }

    public class DeskQuote
    {
        private Desk desk;
        private double quotePrice;
        private RushLevel rushLevel;
        private string customerName;
        public QuoteState state;
        private DateTime date;
       
        public DeskQuote(string name, RushLevel rushLevel)
        {
            customerName = name;
            this.rushLevel = rushLevel;
            state = QuoteState.PENDING;
            date = DateTime.Now;
        }


        public void configureDesk(int width, int depth, int numDrawers, DesktopMaterial material)
        {
            if (validDepth(depth) && validWidth(width) && validDrawers(numDrawers))
            {
                desk = new Desk(width, depth, numDrawers, material);
                quotePrice = calculatePrice();
                state = QuoteState.COMPLETE;
            }
        }

        private double calculatePrice()
        {
            double price;
            price = Globals.STARTING_RATE;
            price += calculateMaterialPrice();
            price += calculateDrawerPrice();
            price += calculateRushPrice();
            return price;
        }

        private double calculateMaterialPrice()
        {
            double price = desk.GetArea();

            switch(desk.GetMaterial())
            {
                case DesktopMaterial.OAK:
                    price += 200;
                    break;
                case DesktopMaterial.LAMINATE:
                    price += 100;
                    break;
                case DesktopMaterial.PINE:
                    price += 50;
                    break;
                case DesktopMaterial.ROSEWOOD:
                    price += 300;
                    break;
                case DesktopMaterial.VENEER:
                    price += 125;
                    break;
                default:
                    break;
            }
            return price;
        }

        private double calculateDrawerPrice()
        {
            return desk.GetNumDrawers() * 50.00;
        }

        private double calculateRushPrice()
        {
            double price = 0, starting = 0, increment = 0;
            int surfaceArea = desk.GetArea();

            switch(rushLevel)
            {
                case RushLevel.RUSH_3:
                    starting = 60;
                    increment = 10;
                    break;
                case RushLevel.RUSH_5:
                    starting = 40;
                    increment = 10;
                    break;
                case RushLevel.RUSH_7:
                    starting = 30;
                    increment = 5;
                    break;
                case RushLevel.NO_RUSH:

                default:
                    price = 0;
                    break;
            }

            if (starting > 0 && increment > 0)
            {
                if (surfaceArea < 1000)
                    price = starting;
                else if (surfaceArea >= 100 && surfaceArea <= 2000)
                    price = starting + increment;
                else price = starting + (2*increment);
                
            }
            return price;
        }

        public string GetCustomerName() { return customerName; }

        public double GetPrice() { return quotePrice;  }
        public DateTime GetDate() { return date; }  

        public Desk GetDesk() { return desk; }

        public RushLevel GetRushLevel() { return rushLevel; }

        public static bool validWidth(int width) 
        {
            return width >= Globals.MIN_WIDTH && width <= Globals.MAX_WIDTH;
        }

        public static bool validDepth(int depth)
        {
            return depth >= Globals.MIN_DEPTH && depth <= Globals.MAX_DEPTH;
        }

        public static bool validDrawers(int numDrawers)
        {
            return numDrawers >= 0 && numDrawers <= Globals.MAX_DRAWERS;
        }
    }
}
