using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Net.Mime.MediaTypeNames;

namespace Lagged_Fibonacci_generator
{
    public partial class LFG : Form
    {
        public double[] Numbers = new double[30];
        public double mod, h;
        public int j, k;
        private static string s;
        public LFG()
        {
            InitializeComponent();
        }
        public class node<IP>
        {
            public node(IP data) { Data = data; }
            public IP Data { get; set; }
            public node<IP> Next { get; set; }
        }
        class Ochered<IP> : IEnumerable<IP>
        {
            int count = 0;
            IEnumerator IEnumerable.GetEnumerator() { return ((IEnumerable)this).GetEnumerator(); }
            IEnumerator<IP> IEnumerable<IP>.GetEnumerator()
            {
                node<IP> current = Head;
                while (current != null)
                {
                    yield return current.Data;
                    current = current.Next;
                }
            }
            node<IP> Head; node<IP> Tail;
            public void Add_O(IP data)
            {
                node<IP> node = new node<IP>(data);
                node<IP> tempNode = Tail;
                Tail = node;
                if (count == 0) Head = Tail;
                else tempNode.Next = Tail;
                count++;
            }
            public IP remove_item_O()
            {
                IP output = Head.Data;
                Head = Head.Next;
                count--;
                return output;
            }
        }
        private void J_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (J.Text == "7") K.Text = "10";
            if (J.Text == "5") K.Text = "17";
            if (J.Text == "24") K.Text = "55";
        }
        private void K_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (K.Text == "10") J.Text = "7";
            if (K.Text == "17") J.Text = "5";
            if (K.Text == "55") J.Text = "24";
        }
        private void SRN_TextChanged(object sender, EventArgs e) { }
        private void Mod_TextChanged(object sender, EventArgs e) { }
        private void outputS_Click(object sender, EventArgs e)
        {
            if (h == 1) { SRN.Text = ""; foreach (double N in Numbers) SRN.Text += N + " "; }
            else { MessageBox.Show($"Нажмите {"TO GRAPH"}"); }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            this.Graph.Series[0].Points.Clear();
            Seed.Clear();
            J.Text = null;
            K.Text = null;
            Mod.Clear();
            SRN.Clear();
            Numbers = new double[30];
            h = 0;
        }
        private void Save_Image_Click(object sender, EventArgs e)
        {
            if (h != 0)
            {
                SaveFileDialog savedialog = new SaveFileDialog();
                savedialog.Title = "Сохранить картинку как...";
                savedialog.OverwritePrompt = true;
                savedialog.CheckPathExists = true;
                savedialog.Filter = "Image Files(*.PNG)|*.PNG|All files (*.*)|*.*";
                savedialog.ShowHelp = true;
                if (savedialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        this.Graph.SaveImage(savedialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                        MessageBox.Show("Изображение сохранено");
                    }
                    catch
                    {
                        MessageBox.Show("Невозможно сохранить изображение", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else { MessageBox.Show($"Нажмите {"TO GRAPH"}"); }
        }
        public void GF()
        {
            h = 1;
            this.Graph.Series[0].Points.Clear();
            double S = Convert.ToDouble(s);
            Ochered<int> ochered = new Ochered<int>();
            double[] A = new double[s.Length + 1];
            for (int l = 0; l < A.Length - 1; l++)
            {
                A[l] = (int)(S / Math.Pow(10, s.Length - l - 1));
                S = S - A[l] * Math.Pow(10, s.Length - l - 1);
            }
            for (int i = 0; i < 30; i++)
            {
                A[A.Length - 1] = (A[A.Length - j] + A[A.Length - k]) % mod;
                Numbers[i] = A[A.Length - 1];
                this.Graph.Series[0].Points.AddXY(i + 1, Numbers[i]);
                s = null;
                if (i == 0) foreach (int I in A) ochered.Add_O(I);
                else ochered.Add_O((int)A[A.Length - 1]);
                ochered.remove_item_O();
                foreach (int I in ochered) s = s + I + " ";
                string[] a = s.Split(' ');
                A = new double[a.Length];
                for (int l = 0; l < A.Length - 1; l++) { A[l] = Convert.ToDouble(a[l]); }
            }
            SRN.Clear();
        }
        private void Seed_TextChanged(object sender, EventArgs e) { }
        private void Close_Click(object sender, EventArgs e) { System.Windows.Forms.Application.Exit(); }
        public void DefaultSeed() { s = "7711011235813213455891442333776109871597258441816765109461"; Seed.Text = s; }
        public void DefaultJ() { j = 24; J.Text = "24"; }
        private void Graph_Click(object sender, EventArgs e) { }
        private void Seed_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) { e.Handled = true; }
        }
        private void Mod_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) { e.Handled = true; }
        }

        private void To_Graph_Click(object sender, EventArgs e)
        {
            try
            {
                if (Seed.Text == "") { MessageBox.Show("Seed по умолчанию!"); DefaultSeed(); }
                else s = Seed.Text;
                if (J.Text == "" || K.Text == "") { MessageBox.Show("j и k по умолчанию!"); DefaultJ(); DefaultK(); }
                else { j = Convert.ToInt32(J.Text); k = Convert.ToInt32(K.Text); }
                if (Mod.Text == "") { MessageBox.Show("Mod по умолчанию!"); DefaultMod(); }
                else mod = Convert.ToDouble(Mod.Text);
                if (j > Seed.Text.Length || k > Seed.Text.Length || j >= k) { MessageBox.Show($"0 < j < k <= {Seed.Text.Length}"); }
                else
                {
                    try { GF(); }
                    catch { MessageBox.Show("Неверный формат Seed"); h = 0; }
                }
            }
            catch { MessageBox.Show("Неверный формат Mod"); h = 0; }
        }

        public void DefaultK() { k = 55; K.Text = "55"; }
        public void DefaultMod() { mod = Math.Pow(2, 32); Mod.Text = "4294967296"; }
    }
}