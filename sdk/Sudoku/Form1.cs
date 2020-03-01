
using System;
using System.Windows.Forms;

namespace Sudoku
{

    public partial class Form1 : Form
    {
        private solve Mat = new solve();
        
        #region constructor
    public Form1()
        {
            InitializeComponent();
        }
        #endregion

        #region Methods

        public void BtnNew_Click(object sender, EventArgs e)
        {
            Mat.New();
        }
        public void BtnCheck_Click(object sender, EventArgs e)
        {
            if (Mat.Check() == false)
            {
                MessageBox.Show( "This is not the solution.");
            }
            else
            {
                MessageBox.Show("Congratulations.");
            }
        }
        private void BtnRst_Click(object sender, EventArgs e)
        {
            Mat.Reset();
            MessageBox.Show("The puzzle has been reset");
        }
        #endregion
        #region textboxes
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int x;
            if (Mat.CheckAsg(0, 0) == false)
            {
                x = Convert.ToInt32(textBox1.Text);
                Mat.setVal(0, 0,x);
            }
            else
            {
                textBox1.Text = Convert.ToString(Mat.getVal(0, 0));
            }
            
        }
        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int x;
            if (Mat.CheckAsg(0, 1) == false)
            {
                x = Convert.ToInt32(textBox1.Text);
                Mat.setVal(0, 1, x);
            }
            else
            {
                textBox1.Text = Convert.ToString(Mat.getVal(0, 1));
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            int x;
            if (Mat.CheckAsg(0, 2) == false)
            {
                x = Convert.ToInt32(textBox1.Text);
                Mat.setVal(0, 2, x);
            }
            else
            {
                textBox1.Text = Convert.ToString(Mat.getVal(0, 2));
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            int x;
            if (Mat.CheckAsg(0, 3) == false)
            {
                x = Convert.ToInt32(textBox1.Text);
                Mat.setVal(0, 3, x);
            }
            else
            {
                textBox1.Text = Convert.ToString(Mat.getVal(0, 3));
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            int x;
            if (Mat.CheckAsg(0, 4) == false)
            {
                x = Convert.ToInt32(textBox1.Text);
                Mat.setVal(0, 4, x);
            }
            else
            {
                textBox1.Text = Convert.ToString(Mat.getVal(0, 4));
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            int x;
            if (Mat.CheckAsg(0, 5) == false)
            {
                x = Convert.ToInt32(textBox1.Text);
                Mat.setVal(0, 5, x);
            }
            else
            {
                textBox1.Text = Convert.ToString(Mat.getVal(0, 5));
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            int x;
            if (Mat.CheckAsg(0, 6) == false)
            {
                x = Convert.ToInt32(textBox1.Text);
                Mat.setVal(0, 6, x);
            }
            else
            {
                textBox1.Text = Convert.ToString(Mat.getVal(0, 6));
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            int x;
            if (Mat.CheckAsg(0, 7) == false)
            {
                x = Convert.ToInt32(textBox1.Text);
                Mat.setVal(0, 7, x);
            }
            else
            {
                textBox1.Text = Convert.ToString(Mat.getVal(0, 7));
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            int x;
            if (Mat.CheckAsg(0, 8) == false)
            {
                x = Convert.ToInt32(textBox1.Text);
                Mat.setVal(0, 8, x);
            }
            else
            {
                textBox1.Text = Convert.ToString(Mat.getVal(0, 8));
            }

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            int x;
            if (Mat.CheckAsg(1, 0) == false)
            {
                x = Convert.ToInt32(textBox1.Text);
                Mat.setVal(1, 0, x);
            }
            else
            {
                textBox1.Text = Convert.ToString(Mat.getVal(1, 0));
            }

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            int x;
            if (Mat.CheckAsg(1, 1) == false)
            {
                x = Convert.ToInt32(textBox1.Text);
                Mat.setVal(1, 1, x);
            }
            else
            {
                textBox1.Text = Convert.ToString(Mat.getVal(1, 1));
            }

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            int x;
            if (Mat.CheckAsg(1, 2) == false)
            {
                x = Convert.ToInt32(textBox1.Text);
                Mat.setVal(1, 2, x);
            }
            else
            {
                textBox1.Text = Convert.ToString(Mat.getVal(1, 2));
            }

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            int x;
            if (Mat.CheckAsg(1, 3) == false)
            {
                x = Convert.ToInt32(textBox1.Text);
                Mat.setVal(1, 3, x);
            }
            else
            {
                textBox1.Text = Convert.ToString(Mat.getVal(1, 3));
            }
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            int x;
            if (Mat.CheckAsg(1, 4) == false)
            {
                x = Convert.ToInt32(textBox1.Text);
                Mat.setVal(1, 4, x);
            }
            else
            {
                textBox1.Text = Convert.ToString(Mat.getVal(1, 4));
            }
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            int x;
            if (Mat.CheckAsg(1, 5) == false)
            {
                x = Convert.ToInt32(textBox1.Text);
                Mat.setVal(1, 5, x);
            }
            else
            {
                textBox1.Text = Convert.ToString(Mat.getVal(1, 5));
            }

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            int x;
            if (Mat.CheckAsg(1, 6) == false)
            {
                x = Convert.ToInt32(textBox1.Text);
                Mat.setVal(1,6, x);
            }
            else
            {
                textBox1.Text = Convert.ToString(Mat.getVal(1, 6));
            }

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            int x;
            if (Mat.CheckAsg(1, 7) == false)
            {
                x = Convert.ToInt32(textBox1.Text);
                Mat.setVal(1, 7, x);
            }
            else
            {
                textBox1.Text = Convert.ToString(Mat.getVal(1, 7));
            }

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            int x;
            if (Mat.CheckAsg(1, 8) == false)
            {
                x = Convert.ToInt32(textBox1.Text);
                Mat.setVal(1, 8, x);
            }
            else
            {
                textBox1.Text = Convert.ToString(Mat.getVal(1, 8));
            }
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {
            int x;
            if (Mat.CheckAsg(2, 0) == false)
            {
                x = Convert.ToInt32(textBox1.Text);
                Mat.setVal(2, 0, x);
            }
            else
            {
                textBox1.Text = Convert.ToString(Mat.getVal(2, 0));
            }

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {
            int x;
            if (Mat.CheckAsg(2, 1) == false)
            {
                x = Convert.ToInt32(textBox1.Text);
                Mat.setVal(2, 1, x);
            }
            else
            {
                textBox1.Text = Convert.ToString(Mat.getVal(2, 1));
            }
        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {
            int x;
            if (Mat.CheckAsg(2, 2) == false)
            {
                x = Convert.ToInt32(textBox1.Text);
                Mat.setVal(2, 2, x);
            }
            else
            {
                textBox1.Text = Convert.ToString(Mat.getVal(2, 2));
            }

        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {
            int x;
            if (Mat.CheckAsg(2, 3) == false)
            {
                x = Convert.ToInt32(textBox1.Text);
                Mat.setVal(2, 3, x);
            }
            else
            {
                textBox1.Text = Convert.ToString(Mat.getVal(2, 3));
            }

        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {
            int x;
            if (Mat.CheckAsg(2, 4) == false)
            {
                x = Convert.ToInt32(textBox1.Text);
                Mat.setVal(2, 4, x);
            }
            else
            {
                textBox1.Text = Convert.ToString(Mat.getVal(2, 4));
            }

        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {
            int x;
            if (Mat.CheckAsg(2, 5) == false)
            {
                x = Convert.ToInt32(textBox1.Text);
                Mat.setVal(2, 5, x);
            }
            else
            {
                textBox1.Text = Convert.ToString(Mat.getVal(2, 5));
            }
        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {
            int x;
            if (Mat.CheckAsg(2, 6) == false)
            {
                x = Convert.ToInt32(textBox1.Text);
                Mat.setVal(2, 6, x);
            }
            else
            {
                textBox1.Text = Convert.ToString(Mat.getVal(2, 6));
            }

        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {
            int x;
            if (Mat.CheckAsg(2, 7) == false)
            {
                x = Convert.ToInt32(textBox1.Text);
                Mat.setVal(2, 7, x);
            }
            else
            {
                textBox1.Text = Convert.ToString(Mat.getVal(2, 7));
            }

        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {
            int x;
            if (Mat.CheckAsg(2, 8) == false)
            {
                x = Convert.ToInt32(textBox1.Text);
                Mat.setVal(2, 8, x);
            }
            else
            {
                textBox1.Text = Convert.ToString(Mat.getVal(2, 8));
            }

        }

        private void textBox28_TextChanged(object sender, EventArgs e)
        {
            int x;
            if (Mat.CheckAsg(3, 0) == false)
            {
                x = Convert.ToInt32(textBox1.Text);
                Mat.setVal(3, 0, x);
            }
            else
            {
                textBox1.Text = Convert.ToString(Mat.getVal(3, 0));
            }

        }

        private void textBox29_TextChanged(object sender, EventArgs e)
        {
            int x;
            if (Mat.CheckAsg(3, 1) == false)
            {
                x = Convert.ToInt32(textBox1.Text);
                Mat.setVal(3, 1, x);
            }
            else
            {
                textBox1.Text = Convert.ToString(Mat.getVal(3, 1));
            }

        }

        private void textBox30_TextChanged(object sender, EventArgs e)
        {
            int x;
            if (Mat.CheckAsg(3, 2) == false)
            {
                x = Convert.ToInt32(textBox1.Text);
                Mat.setVal(3, 2, x);
            }
            else
            {
                textBox1.Text = Convert.ToString(Mat.getVal(3, 2));
            }

        }

        private void textBox31_TextChanged(object sender, EventArgs e)
        {
            int x;
            if (Mat.CheckAsg(3, 3) == false)
            {
                x = Convert.ToInt32(textBox1.Text);
                Mat.setVal(3, 3, x);
            }
            else
            {
                textBox1.Text = Convert.ToString(Mat.getVal(3, 3));
            }
        }

        private void textBox32_TextChanged(object sender, EventArgs e)
        {
            int x;
            if (Mat.CheckAsg(3, 4) == false)
            {
                x = Convert.ToInt32(textBox1.Text);
                Mat.setVal(3, 4, x);
            }
            else
            {
                textBox1.Text = Convert.ToString(Mat.getVal(3, 4));
            }

        }

        private void textBox33_TextChanged(object sender, EventArgs e)
        {
            int x;
            if (Mat.CheckAsg(3, 5) == false)
            {
                x = Convert.ToInt32(textBox1.Text);
                Mat.setVal(3, 5, x);
            }
            else
            {
                textBox1.Text = Convert.ToString(Mat.getVal(3, 5));
            }
        }

        private void textBox34_TextChanged(object sender, EventArgs e)
        {
            int x;
            if (Mat.CheckAsg(3, 6) == false)
            {
                x = Convert.ToInt32(textBox1.Text);
                Mat.setVal(3, 6, x);
            }
            else
            {
                textBox1.Text = Convert.ToString(Mat.getVal(3, 6));
            }
        }

        private void textBox35_TextChanged(object sender, EventArgs e)
        {
            int x;
            if (Mat.CheckAsg(3, 7) == false)
            {
                x = Convert.ToInt32(textBox1.Text);
                Mat.setVal(3, 7, x);
            }
            else
            {
                textBox1.Text = Convert.ToString(Mat.getVal(3, 7));
            }

        }

        private void textBox36_TextChanged(object sender, EventArgs e)
        {
            int x;
            if (Mat.CheckAsg(3, 8) == false)
            {
                x = Convert.ToInt32(textBox1.Text);
                Mat.setVal(3, 8, x);
            }
            else
            {
                textBox1.Text = Convert.ToString(Mat.getVal(3, 8));
            }

        }

        private void textBox37_TextChanged(object sender, EventArgs e)
        {
            int x;
            if (Mat.CheckAsg(4, 0) == false)
            {
                x = Convert.ToInt32(textBox1.Text);
                Mat.setVal(4, 0, x);
            }
            else
            {
                textBox1.Text = Convert.ToString(Mat.getVal(4, 0));
            }
        }

        private void textBox38_TextChanged(object sender, EventArgs e)
        {
            int x;
            if (Mat.CheckAsg(4, 1) == false)
            {
                x = Convert.ToInt32(textBox1.Text);
                Mat.setVal(4, 1, x);
            }
            else
            {
                textBox1.Text = Convert.ToString(Mat.getVal(4, 1));
            }

        }

        private void textBox39_TextChanged(object sender, EventArgs e)
        {
            int x;
            if (Mat.CheckAsg(4, 2) == false)
            {
                x = Convert.ToInt32(textBox1.Text);
                Mat.setVal(4, 2, x);
            }
            else
            {
                textBox1.Text = Convert.ToString(Mat.getVal(4, 2));
            }
        }

        private void textBox40_TextChanged(object sender, EventArgs e)
        {
            int x;
            if (Mat.CheckAsg(4, 3) == false)
            {
                x = Convert.ToInt32(textBox1.Text);
                Mat.setVal(4, 3, x);
            }
            else
            {
                textBox1.Text = Convert.ToString(Mat.getVal(4, 3));
            }
        }

        private void textBox41_TextChanged(object sender, EventArgs e)
        {
            int x;
            if (Mat.CheckAsg(4, 4) == false)
            {
                x = Convert.ToInt32(textBox1.Text);
                Mat.setVal(4, 4, x);
            }
            else
            {
                textBox1.Text = Convert.ToString(Mat.getVal(4, 4));
            }

        }

        private void textBox42_TextChanged(object sender, EventArgs e)
        {
            int x;
            if (Mat.CheckAsg(4, 5) == false)
            {
                x = Convert.ToInt32(textBox1.Text);
                Mat.setVal(4, 5, x);
            }
            else
            {
                textBox1.Text = Convert.ToString(Mat.getVal(4, 5));
            }

        }

        private void textBox43_TextChanged(object sender, EventArgs e)
        {
            int x;
            if (Mat.CheckAsg(4, 6) == false)
            {
                x = Convert.ToInt32(textBox1.Text);
                Mat.setVal(4, 6, x);
            }
            else
            {
                textBox1.Text = Convert.ToString(Mat.getVal(4, 6));
            }
        }

        private void textBox44_TextChanged(object sender, EventArgs e)
        {
            int x;
            if (Mat.CheckAsg(4, 7) == false)
            {
                x = Convert.ToInt32(textBox1.Text);
                Mat.setVal(4, 7, x);
            }
            else
            {
                textBox1.Text = Convert.ToString(Mat.getVal(4, 7));
            }
        }

        private void textBox45_TextChanged(object sender, EventArgs e)
        {
            int x;
            if (Mat.CheckAsg(4, 8) == false)
            {
                x = Convert.ToInt32(textBox1.Text);
                Mat.setVal(4, 8, x);
            }
            else
            {
                textBox1.Text = Convert.ToString(Mat.getVal(4, 8));
            }

        }

        private void textBox46_TextChanged(object sender, EventArgs e)
        {
            int x;
            if (Mat.CheckAsg(5, 0) == false)
            {
                x = Convert.ToInt32(textBox1.Text);
                Mat.setVal(5, 0, x);
            }
            else
            {
                textBox1.Text = Convert.ToString(Mat.getVal(5, 0));
            }

        }

        private void textBox47_TextChanged(object sender, EventArgs e)
        {
            int x;
            if (Mat.CheckAsg(5, 1) == false)
            {
                x = Convert.ToInt32(textBox1.Text);
                Mat.setVal(5, 1, x);
            }
            else
            {
                textBox1.Text = Convert.ToString(Mat.getVal(5, 1));
            }
        }

        private void textBox48_TextChanged(object sender, EventArgs e)
        {
            int x;
            if (Mat.CheckAsg(5, 2) == false)
            {
                x = Convert.ToInt32(textBox1.Text);
                Mat.setVal(5, 2, x);
            }
            else
            {
                textBox1.Text = Convert.ToString(Mat.getVal(5, 2));
            }

        }

        private void textBox49_TextChanged(object sender, EventArgs e)
        {
            int x;
            if (Mat.CheckAsg(5, 3) == false)
            {
                x = Convert.ToInt32(textBox1.Text);
                Mat.setVal(5, 3, x);
            }
            else
            {
                textBox1.Text = Convert.ToString(Mat.getVal(5, 3));
            }
        }

        private void textBox50_TextChanged(object sender, EventArgs e)
        {
            int x;
            if (Mat.CheckAsg(5, 4) == false)
            {
                x = Convert.ToInt32(textBox1.Text);
                Mat.setVal(5, 4, x);
            }
            else
            {
                textBox1.Text = Convert.ToString(Mat.getVal(5, 4));
            }

        }

        private void textBox51_TextChanged(object sender, EventArgs e)
        {
            int x;
            if (Mat.CheckAsg(5, 5) == false)
            {
                x = Convert.ToInt32(textBox1.Text);
                Mat.setVal(5, 5, x);
            }
            else
            {
                textBox1.Text = Convert.ToString(Mat.getVal(5, 5));
            }

        }

        private void textBox52_TextChanged(object sender, EventArgs e)
        {
            int x;
            if (Mat.CheckAsg(5, 6) == false)
            {
                x = Convert.ToInt32(textBox1.Text);
                Mat.setVal(5, 6, x);
            }
            else
            {
                textBox1.Text = Convert.ToString(Mat.getVal(5, 6));
            }

        }

        private void textBox53_TextChanged(object sender, EventArgs e)
        {
            int x;
            if (Mat.CheckAsg(5, 7) == false)
            {
                x = Convert.ToInt32(textBox1.Text);
                Mat.setVal(5, 7, x);
            }
            else
            {
                textBox1.Text = Convert.ToString(Mat.getVal(5, 7));
            }
        }

        private void textBox54_TextChanged(object sender, EventArgs e)
        {
            int x;
            if (Mat.CheckAsg(5, 8) == false)
            {
                x = Convert.ToInt32(textBox1.Text);
                Mat.setVal(5, 8, x);
            }
            else
            {
                textBox1.Text = Convert.ToString(Mat.getVal(5, 8));
            }
        }

        private void textBox55_TextChanged(object sender, EventArgs e)
        {
            int x;
            if (Mat.CheckAsg(6, 0) == false)
            {
                x = Convert.ToInt32(textBox1.Text);
                Mat.setVal(6, 0, x);
            }
            else
            {
                textBox1.Text = Convert.ToString(Mat.getVal(6, 0));
            }

        }

        private void textBox56_TextChanged(object sender, EventArgs e)
        {
            int x;
            if (Mat.CheckAsg(6, 1) == false)
            {
                x = Convert.ToInt32(textBox1.Text);
                Mat.setVal(6, 1, x);
            }
            else
            {
                textBox1.Text = Convert.ToString(Mat.getVal(6, 1));
            }

        }

        private void textBox57_TextChanged(object sender, EventArgs e)
        {
            int x;
            if (Mat.CheckAsg(6, 2) == false)
            {
                x = Convert.ToInt32(textBox1.Text);
                Mat.setVal(6, 2, x);
            }
            else
            {
                textBox1.Text = Convert.ToString(Mat.getVal(6, 2));
            }

        }

        private void textBox58_TextChanged(object sender, EventArgs e)
        {
            int x;
            if (Mat.CheckAsg(6, 3) == false)
            {
                x = Convert.ToInt32(textBox1.Text);
                Mat.setVal(6, 3, x);
            }
            else
            {
                textBox1.Text = Convert.ToString(Mat.getVal(6, 3));
            }
        }

        private void textBox59_TextChanged(object sender, EventArgs e)
        {
            int x;
            if (Mat.CheckAsg(6, 4) == false)
            {
                x = Convert.ToInt32(textBox1.Text);
                Mat.setVal(6, 4, x);
            }
            else
            {
                textBox1.Text = Convert.ToString(Mat.getVal(6, 4));
            }

        }

        private void textBox60_TextChanged(object sender, EventArgs e)
        {
            int x;
            if (Mat.CheckAsg(6, 5) == false)
            {
                x = Convert.ToInt32(textBox1.Text);
                Mat.setVal(6, 5, x);
            }
            else
            {
                textBox1.Text = Convert.ToString(Mat.getVal(6, 5));
            }
        }

        private void textBox61_TextChanged(object sender, EventArgs e)
        {
            int x;
            if (Mat.CheckAsg(6, 6) == false)
            {
                x = Convert.ToInt32(textBox1.Text);
                Mat.setVal(6, 6, x);
            }
            else
            {
                textBox1.Text = Convert.ToString(Mat.getVal(6, 6));
            }
        }

        private void textBox62_TextChanged(object sender, EventArgs e)
        {
            int x;
            if (Mat.CheckAsg(6, 7) == false)
            {
                x = Convert.ToInt32(textBox1.Text);
                Mat.setVal(6, 7, x);
            }
            else
            {
                textBox1.Text = Convert.ToString(Mat.getVal(6, 7));
            }

        }

        private void textBox63_TextChanged(object sender, EventArgs e)
        {
            int x;
            if (Mat.CheckAsg(6, 8) == false)
            {
                x = Convert.ToInt32(textBox1.Text);
                Mat.setVal(6, 8, x);
            }
            else
            {
                textBox1.Text = Convert.ToString(Mat.getVal(6, 8));
            }

        }

        private void textBox64_TextChanged(object sender, EventArgs e)
        {
            int x;
            if (Mat.CheckAsg(7, 0) == false)
            {
                x = Convert.ToInt32(textBox1.Text);
                Mat.setVal(7, 0, x);
            }
            else
            {
                textBox1.Text = Convert.ToString(Mat.getVal(7, 0));
            }

        }

        private void textBox65_TextChanged(object sender, EventArgs e)
        {
            int x;
            if (Mat.CheckAsg(7, 1) == false)
            {
                x = Convert.ToInt32(textBox1.Text);
                Mat.setVal(7, 1, x);
            }
            else
            {
                textBox1.Text = Convert.ToString(Mat.getVal(7, 1));
            }

        }

        private void textBox66_TextChanged(object sender, EventArgs e)
        {
            int x;
            if (Mat.CheckAsg(7, 2) == false)
            {
                x = Convert.ToInt32(textBox1.Text);
                Mat.setVal(7, 2, x);
            }
            else
            {
                textBox1.Text = Convert.ToString(Mat.getVal(7, 2));
            }

        }

        private void textBox67_TextChanged(object sender, EventArgs e)
        {
            int x;
            if (Mat.CheckAsg(7, 3) == false)
            {
                x = Convert.ToInt32(textBox1.Text);
                Mat.setVal(7, 3, x);
            }
            else
            {
                textBox1.Text = Convert.ToString(Mat.getVal(7, 3));
            }

        }

        private void textBox68_TextChanged(object sender, EventArgs e)
        {
            int x;
            if (Mat.CheckAsg(7, 4) == false)
            {
                x = Convert.ToInt32(textBox1.Text);
                Mat.setVal(7, 4, x);
            }
            else
            {
                textBox1.Text = Convert.ToString(Mat.getVal(7, 4));
            }

        }

        private void textBox69_TextChanged(object sender, EventArgs e)
        {
            int x;
            if (Mat.CheckAsg(7, 5) == false)
            {
                x = Convert.ToInt32(textBox1.Text);
                Mat.setVal(7, 5, x);
            }
            else
            {
                textBox1.Text = Convert.ToString(Mat.getVal(7, 5));
            }

        }

        private void textBox70_TextChanged(object sender, EventArgs e)
        {
            int x;
            if (Mat.CheckAsg(7,6) == false)
            {
                x = Convert.ToInt32(textBox1.Text);
                Mat.setVal(7, 6, x);
            }
            else
            {
                textBox1.Text = Convert.ToString(Mat.getVal(7, 6));
            }

        }

        private void textBox71_TextChanged(object sender, EventArgs e)
        {
            int x;
            if (Mat.CheckAsg(7, 7) == false)
            {
                x = Convert.ToInt32(textBox1.Text);
                Mat.setVal(7, 7, x);
            }
            else
            {
                textBox1.Text = Convert.ToString(Mat.getVal(7, 7));
            }

        }

        private void textBox72_TextChanged(object sender, EventArgs e)
        {
            int x;
            if (Mat.CheckAsg(7, 8) == false)
            {
                x = Convert.ToInt32(textBox1.Text);
                Mat.setVal(7, 8, x);
            }
            else
            {
                textBox1.Text = Convert.ToString(Mat.getVal(7, 8));
            }

        }

        private void textBox73_TextChanged(object sender, EventArgs e)
        {
            int x;
            if (Mat.CheckAsg(8, 0) == false)
            {
                x = Convert.ToInt32(textBox1.Text);
                Mat.setVal(8, 0, x);
            }
            else
            {
                textBox1.Text = Convert.ToString(Mat.getVal(8, 0));
            }
        }

        private void textBox74_TextChanged(object sender, EventArgs e)
        {
            int x;
            if (Mat.CheckAsg(8, 1) == false)
            {
                x = Convert.ToInt32(textBox1.Text);
                Mat.setVal(8, 1, x);
            }
            else
            {
                textBox1.Text = Convert.ToString(Mat.getVal(8, 1));
            }

        }

        private void textBox75_TextChanged(object sender, EventArgs e)
        {
            int x;
            if (Mat.CheckAsg(8, 2) == false)
            {
                x = Convert.ToInt32(textBox1.Text);
                Mat.setVal(8, 2, x);
            }
            else
            {
                textBox1.Text = Convert.ToString(Mat.getVal(8, 2));
            }

        }

        private void textBox76_TextChanged(object sender, EventArgs e)
        {
            int x;
            if (Mat.CheckAsg(8, 3) == false)
            {
                x = Convert.ToInt32(textBox1.Text);
                Mat.setVal(8, 3, x);
            }
            else
            {
                textBox1.Text = Convert.ToString(Mat.getVal(8, 3));
            }
        }

        private void textBox77_TextChanged(object sender, EventArgs e)
        {
            int x;
            if (Mat.CheckAsg(8, 4) == false)
            {
                x = Convert.ToInt32(textBox1.Text);
                Mat.setVal(8, 4, x);
            }
            else
            {
                textBox1.Text = Convert.ToString(Mat.getVal(8, 4));
            }

        }

        private void textBox78_TextChanged(object sender, EventArgs e)
        {
            int x;
            if (Mat.CheckAsg(8, 5) == false)
            {
                x = Convert.ToInt32(textBox1.Text);
                Mat.setVal(8, 5, x);
            }
            else
            {
                textBox1.Text = Convert.ToString(Mat.getVal(8, 5));
            }

        }

        private void textBox79_TextChanged(object sender, EventArgs e)
        {
            int x;
            if (Mat.CheckAsg(8, 6) == false)
            {
                x = Convert.ToInt32(textBox1.Text);
                Mat.setVal(8, 6, x);
            }
            else
            {
                textBox1.Text = Convert.ToString(Mat.getVal(8, 6));
            }

        }

        private void textBox80_TextChanged(object sender, EventArgs e)
        {
            int x;
            if (Mat.CheckAsg(8, 7) == false)
            {
                x = Convert.ToInt32(textBox1.Text);
                Mat.setVal(8, 7, x);
            }
            else
            {
                textBox1.Text = Convert.ToString(Mat.getVal(8, 7));
            }

        }

        private void textBox81_TextChanged(object sender, EventArgs e)
        {
            int x;
            if (Mat.CheckAsg(8, 8) == false)
            {
                x = Convert.ToInt32(textBox1.Text);
                Mat.setVal(8, 8, x);
            }
            else
            {
                textBox1.Text = Convert.ToString(Mat.getVal(8, 8));
            }

        }

        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
