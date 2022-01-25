using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class AddQuote : Form
    {

        private DeskQuote deskQuote;

        public AddQuote()
        {
            InitializeComponent();
            rushOptionInput.DataSource = Enum.GetValues(typeof(RushOption));
            surfaceInput.DataSource = Enum.GetValues(typeof(SurfaceMaterial));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var mainMenu = new MainMenu();
            mainMenu.Show();
            Close();
        }


        private void widthInput_Validating(object sender, CancelEventArgs e)
        {
            int width;

            //Validate the user entered only numbers
            if (!int.TryParse(widthInput.Text, out width))
            {
                e.Cancel = true;
                widthInput.Focus();
                widthInput.BackColor = Color.Red;
                errorProviderApp.SetError(widthInput, "This is an only numbers field");

            }
            //Validate that the number is between 24 and 96
            else if(width < 24 || width > 96) {
                e.Cancel = true;
                widthInput.Focus();
                widthInput.BackColor = Color.Red;
                errorProviderApp.SetError(widthInput, "Enter a number between 24 and 96");
              
            } else
            {
                e.Cancel = false;
                widthInput.BackColor = Color.White;
                errorProviderApp.SetError(widthInput, "");
                SetMakeQuoteBtn();
            }

        }

        private void depthInput_KeyPress(object sender, KeyPressEventArgs e)
        {

            //Validate the user entered only numbers
            if (!Char.IsNumber(e.KeyChar))
            {
                depthInput.Focus();
                depthInput.BackColor = Color.Red;
                errorProviderApp.SetError(depthInput, "This is an only numbers field");
            }
            else
            {
                depthInput.BackColor = Color.White;
                errorProviderApp.SetError(depthInput, "");
                SetMakeQuoteBtn();
            }
        }

        private void depthInput_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                int depth = Int32.Parse(depthInput.Text);

                if (depth < 24 || depth > 96)
                {
                    e.Cancel = true;
                    depthInput.Focus();
                    depthInput.BackColor = Color.Red;
                    errorProviderApp.SetError(depthInput, "Enter a number between 24 and 96");
                }
                else
                {
                    e.Cancel = false;
                    depthInput.BackColor = Color.White;
                    errorProviderApp.SetError(depthInput, "");
                    SetMakeQuoteBtn();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Something went wrong");
            }
        }

        private void drawersInput_Validating(object sender, CancelEventArgs e)
        {
            int drawers;

            //Validate the user entered only numbers
            if (!int.TryParse(drawersInput.Text, out drawers))
            {
                e.Cancel = true;
                drawersInput.Focus();
                drawersInput.BackColor = Color.Red;
                errorProviderApp.SetError(drawersInput, "This is an only numbers field");

            }
            //Validate that the number is between 24 and 96
            else if (drawers < 0 || drawers > 6)
            {
                e.Cancel = true;
                drawersInput.Focus();
                drawersInput.BackColor = Color.Red;
                errorProviderApp.SetError(drawersInput, "Enter a number between 0 and 6");

            }
            else
            {
                e.Cancel = false;
                drawersInput.BackColor = Color.White;
                errorProviderApp.SetError(drawersInput, "");
                SetMakeQuoteBtn();
            }
        }

       public void SetMakeQuoteBtn()
        {
            if (
                widthInput.Text != string.Empty &&
                depthInput.Text != string.Empty &&
                drawersInput.Text != string.Empty &&
                clientNameInput.Text != string.Empty
                )
            {
                makeQuoteBtn.Enabled = true;

            } else
            {
                makeQuoteBtn.Enabled = false;
            };
        }

        private void makeQuoteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //Get values
                string clientName = clientNameInput.Text;
                RushOption rush = (RushOption)Enum.Parse(typeof(RushOption), rushOptionInput.SelectedItem.ToString());
                int width = int.Parse(widthInput.Text);
                int depth = int.Parse(depthInput.Text);
                int numberDrawers = int.Parse(drawersInput.Text);
                SurfaceMaterial surfaceMaterial = (SurfaceMaterial)Enum.Parse(typeof(SurfaceMaterial), surfaceInput.SelectedItem.ToString());

                //Set up objects
                Desk desk = new Desk(width, depth, numberDrawers, surfaceMaterial);
                this.deskQuote = new DeskQuote(clientName, desk, rush);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Something went wrong");
            }
            
            //Display new view
            var displayQuote = new DisplayQuote(deskQuote);
            displayQuote.Tag = this;
            displayQuote.Show(this);
            Hide();







        }
    }
}
