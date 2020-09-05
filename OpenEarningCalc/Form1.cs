using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GanhosMae
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            foreach (Control control in Controls)
            {
                if (control is TextBox)
                {
                    control.TextChanged += Control_TextChanged;
                }
            }
        }

        private void Control_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (string.IsNullOrEmpty(textBox.Text))
            {
                textBox.BackColor = Color.Red;
            }
            else
            {
                textBox.BackColor = Color.White;
            }
        }

        private void btnIguDom_Click(object sender, EventArgs e) //Igualar Domingo
        {
            string GDiaDom = txtGDomingo.Text;
            txtGDomingo2.Text = GDiaDom;
            txtGDomingo3.Text = GDiaDom;
            txtGDomingo4.Text = GDiaDom;
            txtGDomingo5.Text = GDiaDom;
        }

        private void btnIguSeg_Click(object sender, EventArgs e) //Igualar Segunda
        {
            string GDiaSeg = txtGSegunda.Text;
            txtGSegunda2.Text = GDiaSeg;
            txtGSegunda3.Text = GDiaSeg;
            txtGSegunda4.Text = GDiaSeg;
            txtGSegunda5.Text = GDiaSeg;
        }

        private void btnIguTer_Click(object sender, EventArgs e) //Igualar Terça
        {
            string GDiaTer = txtGTerca.Text;
            txtGTerca2.Text = GDiaTer;
            txtGTerca3.Text = GDiaTer;
            txtGTerca4.Text = GDiaTer;
            txtGTerca5.Text = GDiaTer;
        }

        private void btnIguQua_Click(object sender, EventArgs e) //Igualar Quarta
        {
            string GDiaQua = txtGQuarta.Text;
            txtGQuarta2.Text = GDiaQua;
            txtGQuarta3.Text = GDiaQua;
            txtGQuarta4.Text = GDiaQua;
            txtGQuarta5.Text = GDiaQua;
        }

        private void btnIguQui_Click(object sender, EventArgs e) //Igualar Quinta
        {
            string GDiaQui = txtGQuinta.Text;
            txtGQuinta2.Text = GDiaQui;
            txtGQuinta3.Text = GDiaQui;
            txtGQuinta4.Text = GDiaQui;
            txtGQuinta5.Text = GDiaQui;
        }

        private void btnIguSex_Click(object sender, EventArgs e) //Igualar Sexta
        {
            string GDiaSex = txtGSexta.Text;
            txtGSexta2.Text = GDiaSex;
            txtGSexta3.Text = GDiaSex;
            txtGSexta4.Text = GDiaSex;
            txtGSexta5.Text = GDiaSex;
        }

        private void btnIguSab_Click(object sender, EventArgs e) //Igualar Sabado
        {
            string GDiaSab = txtGSabado.Text;
            txtGSabado2.Text = GDiaSab;
            txtGSabado3.Text = GDiaSab;
            txtGSabado4.Text = GDiaSab;
            txtGSabado5.Text = GDiaSab;
        }

        private void btnCalcDom_Click(object sender, EventArgs e) //calcular Domingo
        {
            decimal GanhoDom1 = Convert.ToDecimal(txtGDomingo.Text);
            decimal GanhoDom2 = Convert.ToDecimal(txtGDomingo2.Text);
            decimal GanhoDom3 = Convert.ToDecimal(txtGDomingo3.Text);
            decimal GanhoDom4 = Convert.ToDecimal(txtGDomingo4.Text);
            decimal GanhoDom5 = Convert.ToDecimal(txtGDomingo5.Text);

            decimal GTotalDom = GanhoDom1 + GanhoDom2 + GanhoDom3 + GanhoDom4 + GanhoDom5;
            txtTotalDom.Text = Convert.ToString(GTotalDom);
        }

        private void btnCalcSeg_Click(object sender, EventArgs e) //calcular Segunda
        {
            decimal GanhoSeg1 = Convert.ToDecimal(txtGSegunda.Text);
            decimal GanhoSeg2 = Convert.ToDecimal(txtGSegunda2.Text);
            decimal GanhoSeg3 = Convert.ToDecimal(txtGSegunda3.Text);
            decimal GanhoSeg4 = Convert.ToDecimal(txtGSegunda4.Text);
            decimal GanhoSeg5 = Convert.ToDecimal(txtGSegunda5.Text);

            decimal GTotalSeg = GanhoSeg1 + GanhoSeg2 + GanhoSeg3 + GanhoSeg4 + GanhoSeg5;
            txtTotalSeg.Text = Convert.ToString(GTotalSeg);
        }

        private void btnCalcTer_Click(object sender, EventArgs e) //calcular Terça
        {
            decimal GanhoTer1 = Convert.ToDecimal(txtGTerca.Text);
            decimal GanhoTer2 = Convert.ToDecimal(txtGTerca2.Text);
            decimal GanhoTer3 = Convert.ToDecimal(txtGTerca3.Text);
            decimal GanhoTer4 = Convert.ToDecimal(txtGTerca4.Text);
            decimal GanhoTer5 = Convert.ToDecimal(txtGTerca5.Text);

            decimal GTotalTer = GanhoTer1 + GanhoTer2 + GanhoTer3 + GanhoTer4 + GanhoTer5;
            txtTotalTer.Text = Convert.ToString(GTotalTer);
        }

        private void btnCalcQua_Click(object sender, EventArgs e) //calcular Quarta
        {
            decimal GanhoQua1 = Convert.ToDecimal(txtGQuarta.Text);
            decimal GanhoQua2 = Convert.ToDecimal(txtGQuarta2.Text);
            decimal GanhoQua3 = Convert.ToDecimal(txtGQuarta3.Text);
            decimal GanhoQua4 = Convert.ToDecimal(txtGQuarta4.Text);
            decimal GanhoQua5 = Convert.ToDecimal(txtGQuarta5.Text);

            decimal GTotalQua = GanhoQua1 + GanhoQua2 + GanhoQua3 + GanhoQua4 + GanhoQua5;
            txtTotalQua.Text = Convert.ToString(GTotalQua);
        }

        private void btnCalcQui_Click(object sender, EventArgs e) //calcular Quinta
        {
            decimal GanhoQui1 = Convert.ToDecimal(txtGQuinta.Text);
            decimal GanhoQui2 = Convert.ToDecimal(txtGQuinta2.Text);
            decimal GanhoQui3 = Convert.ToDecimal(txtGQuinta3.Text);
            decimal GanhoQui4 = Convert.ToDecimal(txtGQuinta4.Text);
            decimal GanhoQui5 = Convert.ToDecimal(txtGQuinta5.Text);

            decimal GTotalQui = GanhoQui1 + GanhoQui2 + GanhoQui3 + GanhoQui4 + GanhoQui5;
            txtTotalQui.Text = Convert.ToString(GTotalQui);
        }

        private void btnCalcSex_Click(object sender, EventArgs e) //calcular Sexta
        {
            decimal GanhoSex1 = Convert.ToDecimal(txtGSexta.Text);
            decimal GanhoSex2 = Convert.ToDecimal(txtGSexta2.Text);
            decimal GanhoSex3 = Convert.ToDecimal(txtGSexta3.Text);
            decimal GanhoSex4 = Convert.ToDecimal(txtGSexta4.Text);
            decimal GanhoSex5 = Convert.ToDecimal(txtGSexta5.Text);

            decimal GTotalSex = GanhoSex1 + GanhoSex2 + GanhoSex3 + GanhoSex4 + GanhoSex5;
            txtTotalSex.Text = Convert.ToString(GTotalSex);
        }

        private void btnCalcSab_Click(object sender, EventArgs e) //calcular Sabado
        {
            decimal GanhoSab1 = Convert.ToDecimal(txtGSabado.Text);
            decimal GanhoSab2 = Convert.ToDecimal(txtGSabado2.Text);
            decimal GanhoSab3 = Convert.ToDecimal(txtGSabado3.Text);
            decimal GanhoSab4 = Convert.ToDecimal(txtGSabado4.Text);
            decimal GanhoSab5 = Convert.ToDecimal(txtGSabado5.Text);

            decimal GTotalSab = GanhoSab1 + GanhoSab2 + GanhoSab3 + GanhoSab4 + GanhoSab5;
            txtTotalSab.Text = Convert.ToString(GTotalSab);
        }

        private void btnCalcSem1_Click(object sender, EventArgs e) //calcular semana 1
        {
            decimal GanhoDom1 = Convert.ToDecimal(txtGDomingo.Text);
            decimal GanhoSeg1 = Convert.ToDecimal(txtGSegunda.Text);
            decimal GanhoTer1 = Convert.ToDecimal(txtGTerca.Text);
            decimal GanhoQua1 = Convert.ToDecimal(txtGQuarta.Text);
            decimal GanhoQui1 = Convert.ToDecimal(txtGQuinta.Text);
            decimal GanhoSex1 = Convert.ToDecimal(txtGSexta.Text);
            decimal GanhoSab1 = Convert.ToDecimal(txtGSabado.Text);

            decimal Sem1TotalG = GanhoDom1 + GanhoSeg1 + GanhoTer1 + GanhoQua1 + GanhoQui1 + GanhoSex1 + GanhoSab1;
            txtTotalSem1.Text = Convert.ToString(Sem1TotalG);
        }

        private void btnCalcSem2_Click(object sender, EventArgs e)  //calcular semana 2
        {
            decimal GanhoDom2 = Convert.ToDecimal(txtGDomingo2.Text);
            decimal GanhoSeg2 = Convert.ToDecimal(txtGSegunda2.Text);
            decimal GanhoTer2 = Convert.ToDecimal(txtGTerca2.Text);
            decimal GanhoQua2 = Convert.ToDecimal(txtGQuarta2.Text);
            decimal GanhoQui2 = Convert.ToDecimal(txtGQuinta2.Text);
            decimal GanhoSex2 = Convert.ToDecimal(txtGSexta2.Text);
            decimal GanhoSab2 = Convert.ToDecimal(txtGSabado2.Text);

            decimal Sem2TotalG = GanhoDom2 + GanhoSeg2 + GanhoTer2 + GanhoQua2 + GanhoQui2 + GanhoSex2 + GanhoSab2;
            txtTotalSem2.Text = Convert.ToString(Sem2TotalG);
        }

        private void btnCalcSem3_Click(object sender, EventArgs e) //calcular semana 3
        {
            decimal GanhoDom3 = Convert.ToDecimal(txtGDomingo3.Text);
            decimal GanhoSeg3 = Convert.ToDecimal(txtGSegunda3.Text);
            decimal GanhoTer3 = Convert.ToDecimal(txtGTerca3.Text);
            decimal GanhoQua3 = Convert.ToDecimal(txtGQuarta3.Text);
            decimal GanhoQui3 = Convert.ToDecimal(txtGQuinta3.Text);
            decimal GanhoSex3 = Convert.ToDecimal(txtGSexta3.Text);
            decimal GanhoSab3 = Convert.ToDecimal(txtGSabado3.Text);

            decimal Sem3TotalG = GanhoDom3 + GanhoSeg3 + GanhoTer3 + GanhoQua3 + GanhoQui3 + GanhoSex3 + GanhoSab3;
            txtTotalSem3.Text = Convert.ToString(Sem3TotalG);
        }

        private void btnCalcSem4_Click(object sender, EventArgs e) //calcular semana 4
        {
            decimal GanhoDom4 = Convert.ToDecimal(txtGDomingo4.Text);
            decimal GanhoSeg4 = Convert.ToDecimal(txtGSegunda4.Text);
            decimal GanhoTer4 = Convert.ToDecimal(txtGTerca4.Text);
            decimal GanhoQua4 = Convert.ToDecimal(txtGQuarta4.Text);
            decimal GanhoQui4 = Convert.ToDecimal(txtGQuinta4.Text);
            decimal GanhoSex4 = Convert.ToDecimal(txtGSexta4.Text);
            decimal GanhoSab4 = Convert.ToDecimal(txtGSabado4.Text);

            decimal Sem4TotalG = GanhoDom4 + GanhoSeg4 + GanhoTer4 + GanhoQua4 + GanhoQui4 + GanhoSex4 + GanhoSab4;
            txtTotalSem4.Text = Convert.ToString(Sem4TotalG);
        }

        private void btnCalcSem5_Click(object sender, EventArgs e) //calcular semana 5
        {
            decimal GanhoDom5 = Convert.ToDecimal(txtGDomingo5.Text);
            decimal GanhoSeg5 = Convert.ToDecimal(txtGSegunda5.Text);
            decimal GanhoTer5 = Convert.ToDecimal(txtGTerca5.Text);
            decimal GanhoQua5 = Convert.ToDecimal(txtGQuarta5.Text);
            decimal GanhoQui5 = Convert.ToDecimal(txtGQuinta5.Text);
            decimal GanhoSex5 = Convert.ToDecimal(txtGSexta5.Text);
            decimal GanhoSab5 = Convert.ToDecimal(txtGSabado5.Text);

            decimal Sem5TotalG = GanhoDom5 + GanhoSeg5 + GanhoTer5 + GanhoQua5 + GanhoQui5 + GanhoSex5 + GanhoSab5;
            txtTotalSem5.Text = Convert.ToString(Sem5TotalG);
        }

        private void button1_Click(object sender, EventArgs e) //Calcular Total
        {
            decimal GanhoDom1 = Convert.ToDecimal(txtGDomingo.Text);
            decimal GanhoDom2 = Convert.ToDecimal(txtGDomingo2.Text);
            decimal GanhoDom3 = Convert.ToDecimal(txtGDomingo3.Text);
            decimal GanhoDom4 = Convert.ToDecimal(txtGDomingo4.Text);
            decimal GanhoDom5 = Convert.ToDecimal(txtGDomingo5.Text);
            decimal GanhoSeg1 = Convert.ToDecimal(txtGSegunda.Text);
            decimal GanhoSeg2 = Convert.ToDecimal(txtGSegunda2.Text);
            decimal GanhoSeg3 = Convert.ToDecimal(txtGSegunda3.Text);
            decimal GanhoSeg4 = Convert.ToDecimal(txtGSegunda4.Text);
            decimal GanhoSeg5 = Convert.ToDecimal(txtGSegunda5.Text);
            decimal GanhoTer1 = Convert.ToDecimal(txtGTerca.Text);
            decimal GanhoTer2 = Convert.ToDecimal(txtGTerca2.Text);
            decimal GanhoTer3 = Convert.ToDecimal(txtGTerca3.Text);
            decimal GanhoTer4 = Convert.ToDecimal(txtGTerca4.Text);
            decimal GanhoTer5 = Convert.ToDecimal(txtGTerca5.Text);
            decimal GanhoQua1 = Convert.ToDecimal(txtGQuarta.Text);
            decimal GanhoQua2 = Convert.ToDecimal(txtGQuarta2.Text);
            decimal GanhoQua3 = Convert.ToDecimal(txtGQuarta3.Text);
            decimal GanhoQua4 = Convert.ToDecimal(txtGQuarta4.Text);
            decimal GanhoQua5 = Convert.ToDecimal(txtGQuarta5.Text);
            decimal GanhoQui1 = Convert.ToDecimal(txtGQuinta.Text);
            decimal GanhoQui2 = Convert.ToDecimal(txtGQuinta2.Text);
            decimal GanhoQui3 = Convert.ToDecimal(txtGQuinta3.Text);
            decimal GanhoQui4 = Convert.ToDecimal(txtGQuinta4.Text);
            decimal GanhoQui5 = Convert.ToDecimal(txtGQuinta5.Text);
            decimal GanhoSex1 = Convert.ToDecimal(txtGSexta.Text);
            decimal GanhoSex2 = Convert.ToDecimal(txtGSexta2.Text);
            decimal GanhoSex3 = Convert.ToDecimal(txtGSexta3.Text);
            decimal GanhoSex4 = Convert.ToDecimal(txtGSexta4.Text);
            decimal GanhoSex5 = Convert.ToDecimal(txtGSexta5.Text);
            decimal GanhoSab1 = Convert.ToDecimal(txtGSabado.Text);
            decimal GanhoSab2 = Convert.ToDecimal(txtGSabado2.Text);
            decimal GanhoSab3 = Convert.ToDecimal(txtGSabado3.Text);
            decimal GanhoSab4 = Convert.ToDecimal(txtGSabado4.Text);
            decimal GanhoSab5 = Convert.ToDecimal(txtGSabado5.Text);

            decimal SomaTotalDom = GanhoDom1 + GanhoDom2 + GanhoDom3 + GanhoDom4 + GanhoDom5;
            decimal SomaTotalSeg = GanhoSeg1 + GanhoSeg2 + GanhoSeg3 + GanhoSeg4 + GanhoSeg5;
            decimal SomaTotalTer = GanhoTer1 + GanhoTer2 + GanhoTer3 + GanhoTer4 + GanhoTer5;
            decimal SomaTotalQua = GanhoQua1 + GanhoQua2 + GanhoQua3 + GanhoQua4 + GanhoQua5;
            decimal SomaTotalQui = GanhoQui1 + GanhoQui2 + GanhoQui3 + GanhoQui4 + GanhoQui5;
            decimal SomaTotalSex = GanhoSex1 + GanhoSex2 + GanhoSex3 + GanhoSex4 + GanhoSex5;
            decimal SomaTotalSab = GanhoSab1 + GanhoSab2 + GanhoSab3 + GanhoSab4 + GanhoSab5;

            decimal SomaTotalMes = SomaTotalDom + SomaTotalSeg + SomaTotalTer + SomaTotalQua + SomaTotalQui + SomaTotalSex + SomaTotalSab;
            txtTotalMes.Text = Convert.ToString(SomaTotalMes);
            MessageBox.Show("O ganho total do mês é: " + Convert.ToString(SomaTotalMes));
        }

        private void FontTrackBar_Scroll(object sender, EventArgs e)
        {
            lblFontSize.Text = FontTrackBar.Value.ToString();   //seta o valor da barra na label
            int FontSizeInt = FontTrackBar.Value;
            string FontModel = Convert.ToString(this.Font.FontFamily);
            this.Font = new Font(FontModel, FontSizeInt);
            //Form1.DefaultFont.Size = FontTrackBar.Value;
        }

        private void Form1_Load(object sender, EventArgs e)
        {  
            FontTrackBar.Value = Convert.ToInt16(this.Font.Size);       //insere o tamanho da fonte na trackbar
            lblFontSize.Text = FontTrackBar.Value.ToString();           //seta o valor da barra na label
        }

        private void rbtArial_Click(object sender, EventArgs e)
        {
            int FontSizeInt = FontTrackBar.Value;
            this.Font = new Font("Arial", FontSizeInt);
        }

        private void rbtTimesNewRoman_Click(object sender, EventArgs e)
        {
            int FontSizeInt = FontTrackBar.Value;
            this.Font = new Font("Times New Roman", FontSizeInt);
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            HelpBox FormAjuda = new HelpBox();
            FormAjuda.Show();
        }

        private void txtGSabado5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

         
        }

        private void txtGSabado5_TextChanged(object sender, EventArgs e)
        {
            //pass
        }
    }
}
