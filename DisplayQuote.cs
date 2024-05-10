using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Spendlove
{
    public partial class DisplayQuote : Form
    {
        private DeskQuote deskQuote;
        public DisplayQuote(DeskQuote deskQuote)
        {
            InitializeComponent();
            this.deskQuote = deskQuote;
            displayCustomerDetails();
            displayDeskDetails();
            displayQuoteDetails();
        }

        private void displayCustomerDetails()
        {
            nameLabel.Text = deskQuote.GetCustomerName();
        }

        private void displayQuoteDetails()
        {
            rushLabel.Text = deskQuote.GetRushLevel().GetDescription();
            dateLabel.Text = deskQuote.GetDate().ToShortDateString();
            priceLabel.Text = deskQuote.GetPrice().ToString("C");
        }

        private void displayDeskDetails()
        {
            Desk desk = deskQuote.GetDesk();
            widthLabel.Text = desk.GetWidth().ToString();
            depthLabel.Text = desk.GetDepth().ToString();
            drawersLabel.Text = desk.GetNumDrawers().ToString();
            materialLabel.Text = desk.GetMaterial().GetDescription();
        }
    }
}
