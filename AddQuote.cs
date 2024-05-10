using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MegaDesk_Spendlove
{
    public partial class AddQuote : Form
    {
        private DeskQuote deskQuote;
        public AddQuote()
        {
            InitializeComponent();

            foreach (RushLevel value in Enum.GetValues(typeof(RushLevel)))
            {
                rushCombo.Items.Add(value.GetDescription());
            }
            rushCombo.SelectedItem = RushLevel.NO_RUSH.GetDescription();

            foreach (DesktopMaterial value in Enum.GetValues(typeof(DesktopMaterial)))
            {
                materialCombo.Items.Add(value.GetDescription());
            }
            materialCombo.SelectedItem = DesktopMaterial.PINE.GetDescription();
        }

       

        private void widthInput_Validating(object sender, CancelEventArgs e)
        {
            int width;
            bool valid = false;
            try
            {
                width = Convert.ToInt32(widthInput.Text);               
                if (DeskQuote.validWidth(width))
                { 
                    widthInput.ForeColor = Color.Black;
                    valid = true ;
                }
            }
            catch 
            {
                valid = false;
            }

            if (!valid) 
            {
                widthInput.ForeColor = Color.Red;
                e.Cancel = true;
                widthInput.Select(0, widthInput.Text.Length);
            }
            
        }


        private void depthInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void drawerInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private DesktopMaterial getSelectedMaterial()
        {
            DesktopMaterial dMaterial = DesktopMaterial.PINE;
            if (materialCombo.SelectedItem != null)
            {
                string selectedDescription = materialCombo.SelectedItem.ToString();
               
                foreach (DesktopMaterial enumValue in Enum.GetValues(typeof(DesktopMaterial)))
                {
                    if (enumValue.GetDescription() == selectedDescription)
                    {
                        dMaterial = enumValue;
                        break;
                    }
                }
            }
            return dMaterial;
        }

        private RushLevel getSelectedRushLevel()
        {
            RushLevel rLevel = RushLevel.NO_RUSH;
            if (rushCombo.SelectedItem != null)
            {
                string selectedDescription = rushCombo.SelectedItem.ToString();
               
                foreach (RushLevel enumValue in Enum.GetValues(typeof(RushLevel)))
                {
                    if (enumValue.GetDescription() == selectedDescription)
                    {
                        rLevel = enumValue;
                        break;
                    }
                }
            }
            return rLevel;
        }

        private void displayQuoteBtn_Click(object sender, EventArgs e)
        {
            int width = 0, depth = 0, numDrawers = 0;
            deskQuote = new DeskQuote(nameInput.Text, getSelectedRushLevel());
            try
            {
                width = Convert.ToInt32(widthInput.Text);
                depth = Convert.ToInt32(depthInput.Text);
                numDrawers = Convert.ToInt32(drawersInput.Text);

                deskQuote.configureDesk(width, depth, numDrawers, getSelectedMaterial());

                if (deskQuote.state == QuoteState.COMPLETE)
                {
                    DisplayQuote displayQuote = new DisplayQuote(deskQuote);
                    displayQuote.Show();
                }
            }
             catch 
            {
                Console.WriteLine("Invalid Data");
            }
            
            
        }

        private void materialCombo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void rushCombo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void drawersInput_Validating(object sender, CancelEventArgs e)
        {
            int drawers;
            bool valid = false;
            try
            {
                drawers = Convert.ToInt32(drawersInput.Text);
                if (DeskQuote.validDrawers(drawers))
                {
                    drawersInput.ForeColor = Color.Black;
                    valid = true;
                }
            }
            catch
            {
                valid = false;
            }

            if (!valid)
            {
                drawersInput.ForeColor = Color.Red;
                e.Cancel = true;
                drawersInput.Select(0, drawersInput.Text.Length);
            }
        }

        private void depthInput_Validating(object sender, CancelEventArgs e)
        {
            int depth;
            bool valid = false;
            try
            {
                depth = Convert.ToInt32(depthInput.Text);
                if (DeskQuote.validDepth(depth))
                {
                    depthInput.ForeColor = Color.Black;
                    valid = true;
                }
            }
            catch
            {
                valid = false;
            }

            if (!valid)
            {
                depthInput.ForeColor = Color.Red;
                e.Cancel = true;
                depthInput.Select(0, depthInput.Text.Length);
            }
        }
    }
}
