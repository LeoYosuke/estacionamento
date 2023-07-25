using System.Numerics;
using System.Windows.Forms;

namespace aula09Estacionamento
{
    public partial class Form1 : Form
    {
        List<string> carro_placa = new List<string>();

        List<int> qnt_carro = new List<int>();

        
        

        public Form1()
        {


            InitializeComponent();
        }
        void listar()
        {
            for (int i = 0; i < carro_placa.Count; i++)
            {
                ListViewItem listViewItem = new ListViewItem();
            }
        } 
        void limpaCampo()
        {
            txtplaca.Clear();

            txtplaca.Focus();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BTNestacionar_Click(object sender, EventArgs e)
        {
            if (carro_placa.Count >= 5)
            {
                MessageBox.Show("ta cheio igual a thais carla...");
            }
            
            if(txtplaca.Text == "")
            {
                MessageBox.Show("Preencha o campo para continuar");
                return;
            }
            string placa = txtplaca.Text;
            carro_placa.Add(placa);

           

            lblcarrosestacionados.Text = carro_placa.Count.ToString();

            listView1.Items.Clear();

            for (int i = 0; i < carro_placa.Count; i++)
            {
                listView1.Items.Add($"[VAGA {i+1}] - {carro_placa[i]}");
            }
            int qnt = carro_placa.Count();
            lblcarrosestacionados.Text = qnt.ToString();


           


            limpaCampo();


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < carro_placa.Count; i++)
            {
                ListViewItem listViewItem = new ListViewItem();
            }
        }

        private void BTNretirar_Click(object sender, EventArgs e)
        {
            string placa = txtplaca.Text;
            carro_placa.Remove(placa);
        }
    }
}