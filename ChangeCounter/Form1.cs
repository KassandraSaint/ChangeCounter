using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangeCounter
{
    public partial class Form1 : Form
    {
        // Constants
        const decimal FIVE_CENTS = 0.05m;
        const decimal TEN_CENTS = 0.10m;
        const decimal TWENTY_FIVE_CENTS = 0.25m;
        const decimal FIFTY_CENTS = 0.50m;

        // Initializing total variable to hold total
        private decimal total = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void fiveCentsPic_Click(object sender, EventArgs e)
        {
            // Adding 5 cents to total value
            total += FIVE_CENTS;
            // Showing new total in currency format in the totalLabel
            totalLabel.Text = total.ToString("c");
        }

        private void tenCentsPic_Click(object sender, EventArgs e)
        {
            // Adding 10 cents ti the total value
            total += TEN_CENTS;
            // Showing new total in currency format in the totalLabel
            totalLabel.Text = total.ToString("c");
        }

        private void twentyfiveCentsPic_Click(object sender, EventArgs e)
        {
            // Adding 25 cents to the total value
            total += TWENTY_FIVE_CENTS;
            // Showing new total value in currency format in the totalLabel
            totalLabel.Text = total.ToString("c");
        }

        private void fifteCentsPic_Click(object sender, EventArgs e)
        {
            // Adding 50 cents to the total value
            total += FIFTY_CENTS;
            // Showing new total value in the currency format in the totalLabel
            totalLabel.Text = total.ToString("c"); 
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Closing the program
            this.Close();
        }
    }
}
