using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsEstados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string est = comboBox1.Text.ToString();
            if (est == "São Paulo" | est == "Rio de Janeiro" | est == "Espírito Santo" | est == "Minas Gerais")
            {
                cboSudeste.Items.Add(comboBox1.SelectedItem);
                comboBox1.Items.Remove(comboBox1.SelectedItem);
                lbltodas.Text = comboBox1.Items.Count.ToString();
                lblSudeste.Text = cboSudeste.Items.Count.ToString();
                
            }
            else if (est == "Goiás" | est == "Mato Grosso" | est == "Mato Grosso do Sul" | est == "Distrito Federal")
            {
                cboCentroOeste.Items.Add(comboBox1.SelectedItem);
                comboBox1.Items.Remove(comboBox1.SelectedItem);
                lbltodas.Text = comboBox1.Items.Count.ToString();
                lblCentroOeste.Text = cboCentroOeste.Items.Count.ToString();
            }
            if (est ==  "Amazonas" | est == "Pará" | est == "Acre" | est == "Roraima" | est == "Rondônia" | est == "Amapá" | est == "Tocantins")
            {
                cboNorte.Items.Add(comboBox1.SelectedItem);
                comboBox1.Items.Remove(comboBox1.SelectedItem);
                lbltodas.Text = comboBox1.Items.Count.ToString();
                lblNorte.Text = cboNorte.Items.Count.ToString();
            }
            else if (est == "Alagoas" | est == "Bahia" | est == "Ceará" | est == "Maranhão" | est == "Paraíba" | est == "Pernambuco" | est == "Piauí" | est == "Rio Grande do Norte" | est == "Sergipe")
            {
                cboNordeste.Items.Add(comboBox1.SelectedItem);
                comboBox1.Items.Remove(comboBox1.SelectedItem);
                lbltodas.Text = comboBox1.Items.Count.ToString();
                lblNordeste.Text = cboNordeste.Items.Count.ToString();
            }
            if (est == "Paraná" | est == "Rio Grande do Sul" | est == "Santa Catarina")
            {
                cboSul.Items.Add(comboBox1.SelectedItem);
                comboBox1.Items.Remove(comboBox1.SelectedItem);
                lbltodas.Text = comboBox1.Items.Count.ToString();
                lblSul.Text = cboSul.Items.Count.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbltodas_Click(object sender, EventArgs e)
        {
            lbltodas.Text = comboBox1.Items.Count.ToString();
        }

        private void lblNorte_Click(object sender, EventArgs e)
        {
            lblNorte.Text = cboNorte.Items.Count.ToString();
        }

        private void lblNordeste_Click(object sender, EventArgs e)
        {
            lblNordeste.Text = cboNordeste.Items.Count.ToString();
        }

        private void lblCentroOeste_Click(object sender, EventArgs e)
        {
            lblCentroOeste.Text = cboCentroOeste.Items.Count.ToString();
        }

        private void lblSudeste_Click(object sender, EventArgs e)
        {
            lblSudeste.Text = cboSudeste.Items.Count.ToString();
        }

        private void lblSul_Click(object sender, EventArgs e)
        {
            lblSul.Text = cboSul.Items.Count.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
