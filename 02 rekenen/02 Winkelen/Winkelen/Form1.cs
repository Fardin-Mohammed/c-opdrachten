namespace Winkelen
{
    public partial class Form1 : Form
    {
        int sponge;
        double spongePrice = 49.99;
        int elden;
        double eldenPrice = 79.99;
        int spiderman;
        double spidermanPrice = 60.99;
        int ps5s;
        double ps5Price = 499.99;
        int controllers;
        double controllerPrice = 69.99;
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateTotal_Click(object sender, EventArgs e)
        {
            //1) reken hier de totaal prijs uit
            double total = (sponge * spongePrice) + (elden * eldenPrice) + (spiderman * spidermanPrice) + (ps5s * ps5Price) + (controllers * controllerPrice);

            totalPrice.Text = total.ToString();
        }

        private void koopPs5_Click(object sender, EventArgs e)
        {
            ps5s++;
            labelPs5Amount.Text = ps5s.ToString();
        }

        private void koopController_Click(object sender, EventArgs e)
        {
            controllers++;
            labelCtrlAmount.Text = controllers.ToString();
        }

        private void koopSponge_Click(object sender, EventArgs e)
        {
            sponge++;
            labelSpongeAmount.Text = sponge.ToString();
        }

        private void koopSpiderman_Click(object sender, EventArgs e)
        {
            spiderman++;
            labelSpiderAmount.Text = spiderman.ToString();
        }
        private void koopElden_Click(object sender, EventArgs e)
        {
            elden++;
            labelEldenAmount.Text = elden.ToString();
        }

        private void totalPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}