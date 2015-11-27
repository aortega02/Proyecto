using System;
using System.Windows.Forms;
using clMiLibreria;

namespace Operaciones
{
    public partial class FrmMain : Form
    {
        Calculos clase = new Calculos();
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnIr_Click(object sender, EventArgs e)
        {
            if (cmbOper.SelectedIndex == 0)
            {
                double areaCirculo;
                if (rdOpc1.Checked == true)
                {
                    areaCirculo = clase.CalculoAreaCirculo(Convert.ToDouble(txtval1.Text));
                }
                else
                {
                    areaCirculo = clase.CalculoAreaCirculo(Convert.ToDecimal(txtval1.Text));
                }
                lblResult.Text = areaCirculo.ToString();
            }
            else if (cmbOper.SelectedIndex == 1)
            {
                double areaCuadrado;
                areaCuadrado = clase.CalcularAreaCuadrado(Convert.ToDouble(txtval1.Text));
                lblResult.Text = areaCuadrado.ToString();
            }
            else if (cmbOper.SelectedIndex == 2)
            {
                Class1 cont = new Class1();
                cont.contar(txtval1.Text);
                lblResult.Text = cont.cant.ToString();
            }
            else if (cmbOper.SelectedIndex == 3)
            {
                Class1 sum = new Class1();
                sum.sumar(Convert.ToInt32(txtval1.Text), Convert.ToInt32(txtval2.Text));
                lblResult.Text = sum.autosuma.ToString();
            }
        }

        private void cmbOper_SelectedIndexChanged(object sender, EventArgs e)
        {
            Class1 camb = new Class1();
            lblparam.Text = "Parametro:";
            //txtval1.Text = "0";

            TextBox[] txt = { txtval1, txtval2 };
            camb.cmbstatus(txt, true, "0");

            //txtval2.Text = "0";
            lblResult.Text = "0";
            lblResult.Visible = true;
            lblResInfo.Text = "Total:";
            lblResInfo.Visible = true;
            gpTipoOper.Visible = false;

            if (cmbOper.SelectedIndex == 0)
            {
                gpTipoOper.Visible = true;
                rdOpc1.Checked = true;
                txtval2.Visible = false;
            }
            else if (cmbOper.SelectedIndex == 1)
            {
                lblparam.Text = "Parametro - Lado:";
                txtval2.Visible = false;
            }
            else if (cmbOper.SelectedIndex == 2)
            {
                lblparam.Text = "Igrese una Palabra:";
                txtval1.Text = "";
                txtval2.Visible = false;

            }
            else if (cmbOper.SelectedIndex == 3)
            {
                lblparam.Text = "Parametros:";
                txtval2.Visible = true;
            }
        }

        private void rdOpc1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdOpc2.Checked == true)
            {
                lblparam.Text = "Parametro - Diametro:";
                TextBox[] txt = { txtval1 };
                cmbstatus(txt);
            }
            else if (rdOpc1.Checked == true)
            {
                lblparam.Text = "Parametro - Radio:";
            }
        }

        private void cmbstatus (TextBox[] txt)
        {
            foreach (TextBox auxTxt in txt)
            {
                auxTxt.ReadOnly = true;
            }
        }
    }
}
