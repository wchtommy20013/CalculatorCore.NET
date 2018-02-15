using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorCore;
namespace CalculatorDemo {
    public partial class Form1 : Form {

        CalculatorCore.CalculatorCore calc = new CalculatorCore.CalculatorCore();

        public Form1() {
            InitializeComponent();

        }

#region num
        private void btn_1_Click(object sender, EventArgs e) {
            calc.Input(InputType.Num1);
            textBox1.Text = calc.DisplayValue;
        }

        private void btn_2_Click(object sender, EventArgs e) {
            calc.Input(InputType.Num2);
            textBox1.Text = calc.DisplayValue;
        }

        private void btn_3_Click(object sender, EventArgs e) {
            calc.Input(InputType.Num3);
            textBox1.Text = calc.DisplayValue;

        }

        private void btn_4_Click(object sender, EventArgs e) {
            calc.Input(InputType.Num4);
            textBox1.Text = calc.DisplayValue;

        }

        private void btn_5_Click(object sender, EventArgs e) {
            calc.Input(InputType.Num5);
            textBox1.Text = calc.DisplayValue;

        }

        private void btn_6_Click(object sender, EventArgs e) {
            calc.Input(InputType.Num6);
            textBox1.Text = calc.DisplayValue;

        }

        private void btn_7_Click(object sender, EventArgs e) {
            calc.Input(InputType.Num7);
            textBox1.Text = calc.DisplayValue;
        }

        private void btn_8_Click(object sender, EventArgs e) {
            calc.Input(InputType.Num8);
            textBox1.Text = calc.DisplayValue;
        }

        private void btn_9_Click(object sender, EventArgs e) {
            calc.Input(InputType.Num9);
            textBox1.Text = calc.DisplayValue;
        }

        private void btn_0_Click(object sender, EventArgs e) {
            calc.Input(InputType.Num0);
            textBox1.Text = calc.DisplayValue;

        }

        private void btn_00_Click(object sender, EventArgs e) {
            calc.Input(InputType.Num00);
            textBox1.Text = calc.DisplayValue;
        }

        #endregion

        private void btn_dot_Click(object sender, EventArgs e) {
            calc.Input(InputType.Dot);
            textBox1.Text = calc.DisplayValue;
        }

        private void button_div(object sender, EventArgs e) {
            calc.Input(InputType.Div);
            textBox1.Text = calc.DisplayValue;
        }

        private void button_mul(object sender, EventArgs e) {
            calc.Input(InputType.Mul);
            textBox1.Text = calc.DisplayValue;
        }

        private void button_sub_Click(object sender, EventArgs e) {
            calc.Input(InputType.Sub);
            textBox1.Text = calc.DisplayValue;

        }

        private void button_add_Click(object sender, EventArgs e) {
            calc.Input(InputType.Add);
            textBox1.Text = calc.DisplayValue;
        }

        private void btn_AC_Click(object sender, EventArgs e) {
            calc.Erase(true);
            textBox1.Text = calc.DisplayValue;
        }

        private void btn_C_Click(object sender, EventArgs e) {
            calc.Erase(false);
            textBox1.Text = calc.DisplayValue;

        }

        private void btn_eq_Click(object sender, EventArgs e) {
            calc.Input(InputType.Eq);
            textBox1.Text = calc.DisplayValue;
        }
    }
}
