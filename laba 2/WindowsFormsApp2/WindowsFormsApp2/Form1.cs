using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        public static int[] get_array(int[,] array, int length_a, int num, int check)
        {
            int[] mass = new int[length_a];
            if(check == 1) for(int i = 0; i < length_a; i++) mass[i] = array[num, i];
            else if(check == 2) for(int j = 0; j < length_a; j++) mass[j] = array[j, num];
            return mass;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        bool chek_A = false , chek_B = false;
        int chek_row_col = 0;
        int[,] result_A;
        private void genericA_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int a = Convert.ToInt32(domainUpDown1.Text[0])-48;
            result_A = WindowsFormsApp2.Gendub.ran(a);
            chek_A = true;
            if (chek_B)
            {
                groupBox1.Enabled = true;
                groupBox2.Enabled = true;
                groupBox3.Enabled = true;
                groupBox4.Enabled = true;
            }
            string arr = "";
            for(int i = 0; i < a; i++)
            {
                for(int j = 0; j < a; j++)
                {
                    arr+=result_A[i,j]+" ";
                    
                }
                listBox1.Items.Add(arr);
                arr = "";
            }

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dubbleRow_Click(object sender, EventArgs e)
        {
            toolStripLabel2.Text = "рядки";
            toolStripLabel4.Text = "рядки";
            chek_row_col = 1;
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {

        }

        private void dobbleCol_Click(object sender, EventArgs e)
        {
            toolStripLabel2.Text = "стовпці";
            toolStripLabel4.Text = "стовпці";
            chek_row_col = 2;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            WindowsFormsApp2.Gendub.duble(result_A, result_B, Convert.ToInt32(toolStripTextBox1.Text)-1, Convert.ToInt32(toolStripTextBox2.Text)-1, chek_row_col, Convert.ToInt32(domainUpDown1.Text[0]) - 48);
            listBox2.Items.Clear();
            string arr = "";
            for (int i = 0; i < Convert.ToInt32(domainUpDown1.Text[0]) - 48; i++)
            {
                for (int j = 0; j < Convert.ToInt32(domainUpDown1.Text[0]) - 48; j++)
                {
                    arr += result_B[i, j] + " ";

                }
                listBox2.Items.Add(arr);
                arr = "";
            }
        }
        int[,] result_B;

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int m = ((int)numericUpDown1.Value)-1, n = ((int)numericUpDown2.Value)-1;
            int length = Convert.ToInt32(domainUpDown1.Text[0]) - 48;
            WindowsFormsApp2.One_Array a = new WindowsFormsApp2.One_Array(get_array(result_A, length, m, 1));
            WindowsFormsApp2.One_Array b = new WindowsFormsApp2.One_Array(get_array(result_B, length, n, 1));
            bool result = a == b;
            if (result) MessageBox.Show("Рядки рівні");
            else MessageBox.Show("Рядки не рівні");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int m = ((int)numericUpDown4.Value) - 1, n = ((int)numericUpDown3.Value) - 1;
            int length = Convert.ToInt32(domainUpDown1.Text[0]) - 48;
            WindowsFormsApp2.One_Array a = new WindowsFormsApp2.One_Array(get_array(result_A, length, m, 1));
            WindowsFormsApp2.One_Array b = new WindowsFormsApp2.One_Array(get_array(result_B, length, n, 1));
            One_Array result = a + b;
            for(int i = 0; i < result.arr.Length; i++) 
                textBox1.Text += Convert.ToString(result.arr[i]) + " ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int m = ((int)numericUpDown5.Value) - 1, n = ((int)numericUpDown6.Value);
            int length = Convert.ToInt32(domainUpDown1.Text[0]) - 48;
            WindowsFormsApp2.One_Array a = new WindowsFormsApp2.One_Array(get_array(result_A, length, m, 1));
            One_Array result = a * n;
            for (int i = 0; i < result.arr.Length; i++)
                textBox2.Text += Convert.ToString(result.arr[i]) + " ";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int m = ((int)numericUpDown7.Value) - 1;
            int length = Convert.ToInt32(domainUpDown1.Text[0]) - 48;
            WindowsFormsApp2.One_Array a = new WindowsFormsApp2.One_Array(get_array(result_A, length, m, 1));
            One_Array result = a++;
            for (int i = 0; i < result.arr.Length; i++)
                textBox3.Text += Convert.ToString(result.arr[i]) + " ";
        }

        private void genericB_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            int a = Convert.ToInt32(domainUpDown1.Text[0]) - 48;
            result_B = WindowsFormsApp2.Gendub.ran(a);
            chek_B = true;
            if (chek_A)
            {
                groupBox1.Enabled = true;
                groupBox2.Enabled = true;
                groupBox3.Enabled = true;
                groupBox4.Enabled = true;
            }
            string arr = "";
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    arr += result_B[i, j] + " ";

                }
                listBox2.Items.Add(arr);
                arr = "";
            }
        }
    }
}
