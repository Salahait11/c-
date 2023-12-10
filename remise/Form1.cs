namespace remise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double prix = Convert.ToDouble(textBoxPrixUnitaire.Text);
            int quantite = Convert.ToInt32(textBoxQuantite.Text);
            double tauxRemise;
            if (quantite < 10)
            {
                tauxRemise = 0;
            }
            else if (quantite < 50)
            {
                tauxRemise = 0.05;
            }
            else if (quantite < 100)
            {
                tauxRemise = 0.1;
            }
            else
            {
                tauxRemise = 0.2;
            }
            double montantbrut = prix * quantite;
            double remise = montantbrut * tauxRemise;
            double montantNet = montantbrut - remise;
            dataGridViewCommandes.Rows.Add($"{prix} Dhs", quantite, tauxRemise, $"{montantbrut} Dhs", $"{remise} Dhs", $"{montantNet} Dhs");
            {
                MessageBox.Show("Merci.");
            }
        }

        private void dataGridViewCommandes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void textBoxPrixUnitaire_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
