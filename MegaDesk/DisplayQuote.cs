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
    public partial class DisplayQuote : Form
    {
        private DeskQuote deskQuote { get; set; }

        public DisplayQuote( DeskQuote deskQuote)
        {
            this.deskQuote = deskQuote;
            InitializeComponent();
            SetUpValues();
        }

        private void SetUpValues()
        {
            clientNameDisplay.Text = deskQuote.clientName;
            int deskArea = deskQuote.desk.width * deskQuote.desk.depth;
            deskAreaDisplay.Text = deskArea.ToString();
            numberDrawersDisplay.Text = deskQuote.desk.numberDrawers.ToString();
            surfaceDisplay.Text = deskQuote.desk.surface.ToString();
            rushDisplay.Text = deskQuote.rush.ToString();
            totalPriceDisplay.Text = deskQuote.totalPrice.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddQuote addQuote = new AddQuote();
            addQuote.Tag = this;
            addQuote.Show(this);
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var mainMenu = new MainMenu();
            mainMenu.Show();
            Close();
        }
    }
}
