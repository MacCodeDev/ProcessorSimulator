using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        string[] pamiec = new string[65536];
        string[] stos = new string[65536];
        int znacznik = 0;

        public Form1()
        {
            InitializeComponent();
        }
        public int funkcja_licz()
        {
            if(radio_indek.Checked == true && radio_si.Checked == true)
            {
               int a = Int32.Parse(text_si.Text, System.Globalization.NumberStyles.HexNumber);
               int b = Int32.Parse(text_DISP.Text, System.Globalization.NumberStyles.HexNumber);
                int c;
                c = a + b;
                if(c <= 65534)
                {
                    return c;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show(string.Format("Proszę zmienić wartości ponieważ suma przekracza maksymalną wartość pamięci"));
                }
            }
            else if(radio_indek.Checked == true && radio_DI.Checked == true)
            {
                int a = Int32.Parse(text_DI.Text, System.Globalization.NumberStyles.HexNumber);
                int b = Int32.Parse(text_DISP.Text, System.Globalization.NumberStyles.HexNumber);
                int c;
                c = a + b;
                if (c <= 65534)
                {
                    return c;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show(string.Format("Proszę zmienić wartości ponieważ suma przekracza maksymalną wartość pamięci"));
                }
            }
            else if(radio_baz.Checked == true && radio_BX.Checked == true)
            {
                int a = Int32.Parse(textBox2.Text, System.Globalization.NumberStyles.HexNumber);
                int b = Int32.Parse(text_DISP.Text, System.Globalization.NumberStyles.HexNumber);
                int c;
                c = a + b;
                if (c <= 65534)
                {
                    return c;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show(string.Format("Proszę zmienić wartości ponieważ suma przekracza maksymalną wartość pamięci"));
                }
            }
            else if(radio_baz.Checked == true && radio_BP.Checked == true)
            {
                int a = Int32.Parse(text_BP.Text, System.Globalization.NumberStyles.HexNumber);
                int b = Int32.Parse(text_DISP.Text, System.Globalization.NumberStyles.HexNumber);
                int c;
                c = a + b;
                if (c <= 65534)
                {
                    return c;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show(string.Format("Proszę zmienić wartości ponieważ suma przekracza maksymalną wartość pamięci"));
                }
            }
            else if(radio_indek_baz.Checked == true && radio_sibx.Checked == true)
            {
                int a = Int32.Parse(text_si.Text, System.Globalization.NumberStyles.HexNumber);
                int c = Int32.Parse(textBox2.Text, System.Globalization.NumberStyles.HexNumber);
                int b = Int32.Parse(text_DISP.Text, System.Globalization.NumberStyles.HexNumber);
                int d;
                d = a + b + c;
                if (d <= 65534)
                {
                    return d;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show(string.Format("Proszę zmienić wartości ponieważ suma przekracza maksymalną wartość pamięci"));
                }
            }
            else if (radio_indek_baz.Checked == true && radio_sibp.Checked == true)
            {
                int a = Int32.Parse(text_si.Text, System.Globalization.NumberStyles.HexNumber);
                int c = Int32.Parse(text_BP.Text, System.Globalization.NumberStyles.HexNumber);
                int b = Int32.Parse(text_DISP.Text, System.Globalization.NumberStyles.HexNumber);
                int d;
                d = a + b + c;
                if (d <= 65534)
                {
                    return d;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show(string.Format("Proszę zmienić wartości ponieważ suma przekracza maksymalną wartość pamięci"));
                }
            }
            else if (radio_indek_baz.Checked == true && radio_dibx.Checked == true)
            {
                int a = Int32.Parse(text_DI.Text, System.Globalization.NumberStyles.HexNumber);
                int c = Int32.Parse(textBox2.Text, System.Globalization.NumberStyles.HexNumber);
                int b = Int32.Parse(text_DISP.Text, System.Globalization.NumberStyles.HexNumber);
                int d;
                d = a + b + c;
                if (d <= 65534)
                {
                    return d;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show(string.Format("Proszę zmienić wartości ponieważ suma przekracza maksymalną wartość pamięci"));
                }
            }
            else if (radio_indek_baz.Checked == true && radio_dibp.Checked == true)
            {
                int a = Int32.Parse(text_DI.Text, System.Globalization.NumberStyles.HexNumber);
                int c = Int32.Parse(text_BP.Text, System.Globalization.NumberStyles.HexNumber);
                int b = Int32.Parse(text_DISP.Text, System.Globalization.NumberStyles.HexNumber);
                int d;
                d = a + b + c;
                if (d <= 65534)
                {
                    return d;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show(string.Format("Proszę zmienić wartości ponieważ suma przekracza maksymalną wartość pamięci"));
                }
            }
            return 0;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text;
        }

        private void but_AX_Click(object sender, EventArgs e)
        {
            int a;
            a = Convert.ToInt32(textBox5.Text, 16);
            textBox1.Text = Convert.ToString(a, 16);
            if (Int32.Parse(textBox1.Text, System.Globalization.NumberStyles.HexNumber) < 16)
                {
                    textBox1.Text = "000" + textBox1.Text;
                }
                else if(Int32.Parse(textBox1.Text, System.Globalization.NumberStyles.HexNumber) < 16 * 16)
                {
                    textBox1.Text = "00" + textBox1.Text;
                }
                else if(Int32.Parse(textBox1.Text, System.Globalization.NumberStyles.HexNumber) < 16 * 16 * 16)
                {
                    textBox1.Text = "0" + textBox1.Text;
                }
            
        }

        private void but_BX_Click(object sender, EventArgs e)
        {
            int a;
            a = Convert.ToInt32(textBox6.Text, 16);
            textBox2.Text = Convert.ToString(a, 16);
            if (Int32.Parse(textBox2.Text, System.Globalization.NumberStyles.HexNumber) < 16)
                {
                    textBox2.Text = "000" + textBox2.Text;
                }
                else if (Int32.Parse(textBox2.Text, System.Globalization.NumberStyles.HexNumber) < 16 * 16)
                {
                    textBox2.Text = "00" + textBox2.Text;
                }
                else if (Int32.Parse(textBox2.Text, System.Globalization.NumberStyles.HexNumber) < 16 * 16 * 16)
                {
                    textBox2.Text = "0" + textBox2.Text;
                }
            
        }

        private void but_CX_Click(object sender, EventArgs e)
        {
            int a;
            a = Convert.ToInt32(textBox7.Text, 16);
            textBox3.Text = Convert.ToString(a, 16);
            if (Int32.Parse(textBox3.Text, System.Globalization.NumberStyles.HexNumber) < 16)
                {
                    textBox3.Text = "000" + textBox3.Text;
                }
                else if (Int32.Parse(textBox3.Text, System.Globalization.NumberStyles.HexNumber) < 16 * 16)
                {
                    textBox3.Text = "00" + textBox3.Text;
                }
                else if (Int32.Parse(textBox3.Text, System.Globalization.NumberStyles.HexNumber) < 16 * 16 * 16)
                {
                    textBox3.Text = "0" + textBox3.Text;
                }
            
        }

        private void but_DX_Click(object sender, EventArgs e)
        {
                int a;
                a = Convert.ToInt32(textBox8.Text, 16);
                textBox4.Text = Convert.ToString(a, 16);
                
                if (Int32.Parse(textBox4.Text, System.Globalization.NumberStyles.HexNumber) < 16)
                {
                    textBox4.Text = "000" + textBox4.Text;
                }
                else if (Int32.Parse(textBox4.Text, System.Globalization.NumberStyles.HexNumber) < 16 * 16)
                {
                    textBox4.Text = "00" + textBox4.Text;
                }
                else if (Int32.Parse(textBox4.Text, System.Globalization.NumberStyles.HexNumber) < 16 * 16 * 16)
                {
                    textBox4.Text = "0" + textBox4.Text;
                }
        }

        private void mov_axcx_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox3.Text;
        }

        private void mov_axdx_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox4.Text;
        }

        private void mov_bxax_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
        }

        private void mov_bxcx_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox3.Text;
        }

        private void mov_bxdx_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox4.Text;
        }

        private void mov_cxax_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox1.Text;
        }

        private void mov_cxbx_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox2.Text;
        }

        private void mov_cxdx_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox4.Text;
        }

        private void mov_dxax_Click(object sender, EventArgs e)
        {
            textBox4.Text = textBox1.Text;
        }

        private void mov_dxbx_Click(object sender, EventArgs e)
        {
            textBox4.Text = textBox2.Text;
        }

        private void mov_dxcx_Click(object sender, EventArgs e)
        {
            textBox4.Text = textBox3.Text;
        }

        private void reset_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0000";
            textBox2.Text = "0000";
            textBox3.Text = "0000";
            textBox4.Text = "0000";
        }

        private void textBox5_Validating(object sender, CancelEventArgs e)
        {
            char[] zezwolone = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            foreach (char litera in textBox5.Text.ToUpper().ToArray())
            {
                if
                    (!zezwolone.Contains(litera))
                {
                    System.Windows.Forms.MessageBox.Show(string.Format("'{0}' nie jest liczbą systemu szesnastkowego ", litera));
                    e.Cancel = true;
                    textBox5.Text = "";
                }
            }
        }

        private void xchg_axbx_Click(object sender, EventArgs e)
        {
            string a;
            a = textBox1.Text;
            textBox1.Text = textBox2.Text;
            textBox2.Text = a;
        }

        private void xchg_axcx_Click(object sender, EventArgs e)
        {
            string a;
            a = textBox1.Text;
            textBox1.Text = textBox3.Text;
            textBox3.Text = a;
        }

        private void xchg_bxax_Click(object sender, EventArgs e)
        {
            string a;
            a = textBox2.Text;
            textBox2.Text = textBox1.Text;
            textBox1.Text = a;
        }

        private void textBox6_Validating(object sender, CancelEventArgs e)
        {
            char[] zezwolone = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            foreach (char litera in textBox6.Text.ToUpper().ToArray())
            {
                if
                    (!zezwolone.Contains(litera))
                {
                    System.Windows.Forms.MessageBox.Show(string.Format("'{0}' nie jest liczbą systemu szesnastkowego ", litera));
                    e.Cancel = true;
                    textBox6.Text = "";
                }
            }
        }

        private void textBox7_Validating(object sender, CancelEventArgs e)
        {
            char[] zezwolone = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            foreach (char litera in textBox7.Text.ToUpper().ToArray())
            {
                if
                    (!zezwolone.Contains(litera))
                {
                    System.Windows.Forms.MessageBox.Show(string.Format("'{0}' nie jest liczbą systemu szesnastkowego ", litera));
                    e.Cancel = true;
                    textBox7.Text = "";
                }
            }
        }

        private void textBox8_Validating(object sender, CancelEventArgs e)
        {
            char[] zezwolone = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            foreach (char litera in textBox8.Text.ToUpper().ToArray())
            {
                if
                    (!zezwolone.Contains(litera))
                {
                    System.Windows.Forms.MessageBox.Show(string.Format("'{0}' nie jest liczbą systemu szesnastkowego ", litera));
                    e.Cancel = true;
                    textBox8.Text = "";
                }
            }
        }

        private void xchg_axdx_Click(object sender, EventArgs e)
        {
            string a;
            a = textBox1.Text;
            textBox1.Text = textBox4.Text;
            textBox4.Text = a;
        }

        private void xchg_bxcx_Click(object sender, EventArgs e)
        {
            string a;
            a = textBox2.Text;
            textBox2.Text = textBox3.Text;
            textBox3.Text = a;
        }

        private void xchg_bxdx_Click(object sender, EventArgs e)
        {
            string a;
            a = textBox2.Text;
            textBox2.Text = textBox4.Text;
            textBox4.Text = a;
        }

        private void xchg_cxax_Click(object sender, EventArgs e)
        {
            string a;
            a = textBox3.Text;
            textBox3.Text = textBox1.Text;
            textBox1.Text = a;
        }

        private void xchg_cxbx_Click(object sender, EventArgs e)
        {
            string a;
            a = textBox3.Text;
            textBox3.Text = textBox2.Text;
            textBox2.Text = a;
        }

        private void xchg_cxdx_Click(object sender, EventArgs e)
        {
            string a;
            a = textBox3.Text;
            textBox3.Text = textBox4.Text;
            textBox4.Text = a;
        }

        private void xchg_dxax_Click(object sender, EventArgs e)
        {
            string a;
            a = textBox4.Text;
            textBox4.Text = textBox1.Text;
            textBox1.Text = a;
        }

        private void xchg_dxbx_Click(object sender, EventArgs e)
        {
            string a;
            a = textBox4.Text;
            textBox4.Text = textBox2.Text;
            textBox2.Text = a;
        }

        private void xchg_dxcx_Click(object sender, EventArgs e)
        {
            string a;
            a = textBox4.Text;
            textBox4.Text = textBox3.Text;
            textBox3.Text = a;
        }

        private void radio_zrej_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radio_zpam_CheckedChanged(object sender, EventArgs e)
        {
 
        }

        private void radio_indek_CheckedChanged(object sender, EventArgs e)
        {
            if(radio_indek.Checked == true)
            {
                radio_AX.Checked = true;
                radio_si.Checked = true;
                radio_BX.Enabled = false;
                radio_BP.Enabled = false;
                radio_sibx.Enabled = false;
                radio_sibp.Enabled = false;
                radio_dibx.Enabled = false;
                radio_dibp.Enabled = false;
                radio_si.Enabled = true;
                radio_DI.Enabled = true;
            }
        }

        private void radio_baz_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_baz.Checked == true)
            {
                radio_AX.Checked = true;
                radio_BX.Checked = true;
                radio_BX.Enabled = true;
                radio_BP.Enabled = true;
                radio_sibx.Enabled = false;
                radio_sibp.Enabled = false;
                radio_dibx.Enabled = false;
                radio_dibp.Enabled = false;
                radio_si.Enabled = false;
                radio_DI.Enabled = false;
            }
        }

        private void radio_indek_baz_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_indek_baz.Checked == true)
            {
                radio_AX.Checked = true;
                radio_sibx.Checked = true;
                radio_BX.Enabled = false;
                radio_BP.Enabled = false;
                radio_sibx.Enabled = true;
                radio_sibp.Enabled = true;
                radio_dibx.Enabled = true;
                radio_dibp.Enabled = true;
                radio_si.Enabled = false;
                radio_DI.Enabled = false;
            }
        }
        private void textw_SI_Validating(object sender, CancelEventArgs e)
        {
            char[] zezwolone = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            foreach (char litera in textw_SI.Text.ToUpper().ToArray())
            {
                if
                    (!zezwolone.Contains(litera))
                {
                    System.Windows.Forms.MessageBox.Show(string.Format("'{0}' nie jest liczbą systemu szesnastkowego ", litera));
                    e.Cancel = true;
                    textw_SI.Text = "";
                }
            }
        }
        private void textw_di_Validating(object sender, CancelEventArgs e)
        {
            char[] zezwolone = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            foreach (char litera in textw_di.Text.ToUpper().ToArray())
            {
                if
                    (!zezwolone.Contains(litera))
                {
                    System.Windows.Forms.MessageBox.Show(string.Format("'{0}' nie jest liczbą systemu szesnastkowego ", litera));
                    e.Cancel = true;
                    textw_di.Text = "";
                }
            }
        }
        private void textw_bp_Validating(object sender, CancelEventArgs e)
        {
            char[] zezwolone = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            foreach (char litera in textw_bp.Text.ToUpper().ToArray())
            {
                if
                    (!zezwolone.Contains(litera))
                {
                    System.Windows.Forms.MessageBox.Show(string.Format("'{0}' nie jest liczbą systemu szesnastkowego ", litera));
                    e.Cancel = true;
                    textw_bp.Text = "";
                }
            }
        }
        private void textw_Sp_Validating(object sender, CancelEventArgs e)
        {
            char[] zezwolone = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            foreach (char litera in textw_Sp.Text.ToUpper().ToArray())
            {
                if
                    (!zezwolone.Contains(litera))
                {
                    System.Windows.Forms.MessageBox.Show(string.Format("'{0}' nie jest liczbą systemu szesnastkowego ", litera));
                    e.Cancel = true;
                    textw_Sp.Text = "";
                }
            }
        }
        private void textw_DISP_Validating(object sender, CancelEventArgs e)
        {
            char[] zezwolone = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            foreach (char litera in textw_DISP.Text.ToUpper().ToArray())
            {
                if
                    (!zezwolone.Contains(litera))
                {
                    System.Windows.Forms.MessageBox.Show(string.Format("'{0}' nie jest liczbą systemu szesnastkowego ", litera));
                    e.Cancel = true;
                    textw_DISP.Text = "";
                }
            }
        }

        private void but_SI_Click(object sender, EventArgs e)
        {
                text_si.Text = textw_SI.Text;
        }

        private void but_DI_Click(object sender, EventArgs e)
        {
                text_DI.Text = textw_di.Text;
        }

        private void but_BP_Click(object sender, EventArgs e)
        {
                text_BP.Text = textw_bp.Text;
        }

        private void but_SP_Click(object sender, EventArgs e)
        {
                text_SP.Text = textw_Sp.Text;
        }

        private void but_DISP_Click(object sender, EventArgs e)
        {
                text_DISP.Text = textw_DISP.Text;
        }

        private void random_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int rnd1 = rand.Next(0, 65535);
            int rnd2 = rand.Next(0, 65535);
            int rnd3 = rand.Next(0, 65535);
            int rnd4 = rand.Next(0, 65535);
            int rnd5 = rand.Next(0, 65535);
            int rnd6 = rand.Next(0, 65535);
            int rnd7 = rand.Next(0, 65535);
            int rnd8 = rand.Next(0, 65535);
            int rnd9 = rand.Next(0, 65535);
            textBox5.Text = Convert.ToString(rnd1, 16);
            textBox6.Text = Convert.ToString(rnd2, 16);
            textBox7.Text = Convert.ToString(rnd3, 16);
            textBox8.Text = Convert.ToString(rnd4, 16);
            textw_SI.Text = Convert.ToString(rnd5, 16);
            textw_di.Text = Convert.ToString(rnd6, 16);
            textw_bp.Text = Convert.ToString(rnd7, 16);
            textw_Sp.Text = Convert.ToString(rnd8, 16);
            textw_DISP.Text = Convert.ToString(rnd9, 16);
        }

        private void MOV_DISP_Click(object sender, EventArgs e)
        {
            if (radio_zrej.Checked == true)
            {
                pamieczapis(funkcja_licz(), rejestr());
            }
            else if (radio_zpam.Checked == true)
            {
                if (radio_AX.Checked == true)
                {
                    textBox1.Text = pamodcz(funkcja_licz());
                }
                else if (radiobx.Checked == true)
                {
                    textBox2.Text = pamodcz(funkcja_licz());
                }
                else if (radio_cx.Checked == true)
                {
                    textBox3.Text = pamodcz(funkcja_licz());
                }
                else if (radio_dx.Checked == true)
                {
                    textBox4.Text = pamodcz(funkcja_licz());
                }
            }

        }
        public void pamieczapis(int gdzie, string wartosc)
        {
            pamiec[gdzie] = Convert.ToString(wartosc[0]) + Convert.ToString(wartosc[1]);
            pamiec[gdzie + 1] = Convert.ToString(wartosc[2]) + Convert.ToString(wartosc[3]);
        }
        private string rejestr()
        {
            if(radio_AX.Checked == true)
            {
                return textBox1.Text;
            }
            else if(radiobx.Checked == true)
            {
                return textBox2.Text;
            }
            else if (radio_cx.Checked == true)
            {
                return textBox3.Text;
            }
            else if (radio_dx.Checked == true)
            {
                return textBox4.Text;
            }
            return "0";
        }
        private string pamodcz(int gdzie)
        {
           return pamiec[gdzie] + pamiec[gdzie + 1];
        }

        private void XCHG_DISP_Click(object sender, EventArgs e)
        {
            string a = rejestr();
                if (radio_AX.Checked == true)
                {
                    textBox1.Text = pamodcz(funkcja_licz());
                }
                else if (radiobx.Checked == true)
                {
                    textBox2.Text = pamodcz(funkcja_licz());
                }
                else if (radio_cx.Checked == true)
                {
                    textBox3.Text = pamodcz(funkcja_licz());
                }
                else if (radio_dx.Checked == true)
                {
                    textBox4.Text = pamodcz(funkcja_licz());
                }
            pamieczapis(funkcja_licz(), a);
        }

        private void Zapel_Click(object sender, EventArgs e)
        {
            for(int i=0;i<65536;i++)
            {
                pamiec[i] = "00";
                stos[i] = "00";
            }
            
        }

        private void PUSH_AX_Click(object sender, EventArgs e)
        {
            stos[znacznik] = Convert.ToString(textBox1.Text[0]) + Convert.ToString(textBox1.Text[1]);
            stos[znacznik + 1] = Convert.ToString(textBox1.Text[2]) + Convert.ToString(textBox1.Text[3]);
            znacznik += 2;
            text_SP.Text = Convert.ToString(znacznik,16);
        }

        private void PUSH_BX_Click(object sender, EventArgs e)
        {
            stos[znacznik] = Convert.ToString(textBox2.Text[0]) + Convert.ToString(textBox2.Text[1]);
            stos[znacznik + 1] = Convert.ToString(textBox2.Text[2]) + Convert.ToString(textBox2.Text[3]);
            znacznik += 2;
            text_SP.Text = Convert.ToString(znacznik, 16);
        }

        private void PUSH_CX_Click(object sender, EventArgs e)
        {
            stos[znacznik] = Convert.ToString(textBox3.Text[0]) + Convert.ToString(textBox3.Text[1]);
            stos[znacznik + 1] = Convert.ToString(textBox3.Text[2]) + Convert.ToString(textBox3.Text[3]);
            znacznik += 2;
            text_SP.Text = Convert.ToString(znacznik, 16);
        }

        private void PUSH_DX_Click(object sender, EventArgs e)
        {
            stos[znacznik] = Convert.ToString(textBox4.Text[0]) + Convert.ToString(textBox4.Text[1]);
            stos[znacznik + 1] = Convert.ToString(textBox4.Text[2]) + Convert.ToString(textBox4.Text[3]);
            znacznik += 2;
            text_SP.Text = Convert.ToString(znacznik, 16);
        }

        private void POP_AX_Click(object sender, EventArgs e)
        {
            if (text_SP.Text == "1" || text_SP.Text == "0000" || text_SP.Text == "000" || text_SP.Text == "00" || text_SP.Text == "0")
            {

            }
            else
            {
                textBox1.Text = stos[znacznik - 2] + stos[znacznik - 1];
                znacznik -= 2;
                text_SP.Text = Convert.ToString(znacznik, 16);
            }
        }

        private void POP_BX_Click(object sender, EventArgs e)
        {
            if (text_SP.Text == "1" || text_SP.Text == "0000" || text_SP.Text == "000" || text_SP.Text == "00" || text_SP.Text == "0")
            {

            }
            else
            {
                textBox2.Text = stos[znacznik - 2] + stos[znacznik - 1];
                znacznik -= 2;
                text_SP.Text = Convert.ToString(znacznik, 16);
            }
        }

        private void POP_CX_Click(object sender, EventArgs e)
        {
            if (text_SP.Text == "1" || text_SP.Text == "0000" || text_SP.Text == "000" || text_SP.Text == "00" || text_SP.Text == "0")
            {

            }
            else
            {
                textBox3.Text = stos[znacznik - 2] + stos[znacznik - 1];
                znacznik -= 2;
                text_SP.Text = Convert.ToString(znacznik, 16);
            }
        }

        private void POP_DX_Click(object sender, EventArgs e)
        {
            if (text_SP.Text == "1" || text_SP.Text == "0000" || text_SP.Text == "000" || text_SP.Text == "00" || text_SP.Text == "0")
            {

            }
            else
            {
                textBox4.Text = stos[znacznik - 2] + stos[znacznik - 1];
                znacznik -= 2;
                text_SP.Text = Convert.ToString(znacznik, 16);
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}