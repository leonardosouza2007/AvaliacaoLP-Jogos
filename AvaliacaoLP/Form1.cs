using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace AvaliacaoLP
{
    public partial class Avaliação : Form
    {
        public Avaliação()
        {
            InitializeComponent();
            txtBox_Categoria.Enabled = false;
            txtBox_Nome.Enabled = false;
            txtBox_Preco.Enabled = false;
            txtBox_Quantidade.Enabled = false;
            txtBox_ValorPagar.Enabled = false;
            checkBox_Desconto.Enabled = false;
            radioBtn_Play.Enabled = false;
            radioBtn_wii.Enabled = false;
            radioBtn_xbox.Enabled = false;
        }

        private void btn_Iniciar_Click(object sender, EventArgs e)
        {
            txtBox_Categoria.Enabled = false;
            txtBox_Nome.Enabled = true;
            txtBox_Preco.Enabled = true;
            txtBox_Quantidade.Enabled = true;
            txtBox_ValorPagar.Enabled = true;
            checkBox_Desconto.Enabled = true;
            radioBtn_Play.Enabled = true;
            radioBtn_wii.Enabled = true;
            radioBtn_xbox.Enabled = true;
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            txtBox_Categoria.Text = string.Empty;
            txtBox_Nome.Text = string.Empty;
            txtBox_Preco.Text = string.Empty;
            txtBox_Quantidade.Text = string.Empty;
            txtBox_ValorPagar.Text = string.Empty;
            radioBtn_xbox.Checked = false;
            radioBtn_wii.Checked = false;
            radioBtn_Play.Checked = false;
            checkBox_Desconto.Checked = false;
        }
        private void btn_ValorPagar_Click(object sender, EventArgs e)
        {
            if (checkBox_Desconto.Checked)
            {
                txtBox_ValorPagar.Text = ($"{float.Parse(txtBox_Preco.Text) * int.Parse(txtBox_Quantidade.Text) * 0.90}€".ToString());
            }
            else
            {
                txtBox_ValorPagar.Text = ($"{float.Parse(txtBox_Preco.Text) * int.Parse(txtBox_Quantidade.Text)}€".ToString());
            }
        }

        private void radioBtn_xbox_CheckedChanged(object sender, EventArgs e)
        {
            txtBox_Categoria.Text = radioBtn_xbox.Text;
        }

        private void radioBtn_Play_CheckedChanged(object sender, EventArgs e)
        {
            txtBox_Categoria.Text = radioBtn_Play.Text;
        }

        private void radioBtn_wii_CheckedChanged(object sender, EventArgs e)
        {
            txtBox_Categoria.Text = radioBtn_wii.Text;
        }

    }
}