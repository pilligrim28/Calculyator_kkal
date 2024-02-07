using System;
using System.Windows.Forms;

namespace Calculyator_kkal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44) // цифры, клавиша BackSpace и запятая
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {



            // double ves = Convert.ToDouble(textBox1.Text);
            // double rost = Convert.ToDouble(textBox2.Text);
            // double vozrast = Convert.ToDouble(textBox3.Text);
            if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "")
            {
                MessageBox.Show("Заполните все поля!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                double ves = Convert.ToDouble(textBox1.Text);
                double rost = Convert.ToDouble(textBox2.Text);
                double vozrast = Convert.ToDouble(textBox3.Text);

                {
                    if (comboBox3.SelectedIndex == 0)
                    {
                        if (comboBox1.SelectedIndex == 0)
                        {
                            if (comboBox2.SelectedIndex == 0)
                            {
                                double rass = ((ves * 10) + (rost * 6.25) - (vozrast * 5) + 5) * 1.2;
                                rasschet.Text = "Вам потребуется: " + rass.ToString() + " кКал.";
                                if (radioButton1.Checked)
                                {
                                    double perviy = rass / 100 * 33;
                                    label7.Visible = true;
                                    label8.Visible = true;
                                    label9.Visible = true;
                                    label10.Visible = false;
                                    label11.Visible = false;
                                    label7.Text = "Завтрак " + perviy.ToString() + " кКал.";
                                    label8.Text = "Обед " + perviy.ToString() + " кКал.";
                                    label9.Text = "Ужин " + perviy.ToString() + " кКал.";

                                }
                                else if (radioButton2.Checked)
                                {
                                    double perviy = rass / 100 * 30;
                                    double vtoroy = rass / 100 * 20;
                                    label7.Visible = true;
                                    label8.Visible = true;
                                    label9.Visible = true;
                                    label10.Visible = true;
                                    label11.Visible = false;
                                    label7.Text = "Завтрак " + perviy.ToString() + " кКал.";
                                    label8.Text = "Обед " + perviy.ToString() + " кКал.";
                                    label9.Text = "Полдник " + vtoroy.ToString() + " кКал.";
                                    label10.Text = "Ужин " + vtoroy.ToString() + " кКал.";


                                }
                                else if (radioButton3.Checked)
                                {
                                    double perviy = rass / 100 * 30;
                                    double vtoroy = rass / 100 * 15;
                                    double tretiy = rass / 100 * 10;
                                    label7.Visible = true;
                                    label8.Visible = true;
                                    label9.Visible = true;
                                    label10.Visible = true;
                                    label11.Visible = true;
                                    label7.Text = "Завтрак " + perviy.ToString() + " кКал.";
                                    label8.Text = "2-ой Завтрак " + perviy.ToString() + " кКал.";
                                    label9.Text = "Обед " + vtoroy.ToString() + " кКал.";
                                    label10.Text = "Полдник "+vtoroy.ToString()+" кКал.";
                                    label11.Text = "Ужин " + tretiy.ToString() + " кКал.";
                                }

                                MessageBox.Show("Вам потребуется: " + rass + " кКал.");


                            }
                            else if (comboBox2.SelectedIndex == 1)
                            {
                                double rass = ((ves * 10) + (rost * 6.25) - (vozrast * 5) + 5) * 1.38;
                                rasschet.Text = "Вам потребуется: " + rass.ToString() + " кКал.";
                                if (radioButton1.Checked)
                                {
                                    double perviy = rass / 100 * 33;
                                    label7.Visible = true;
                                    label8.Visible = true;
                                    label9.Visible = true;
                                    label10.Visible = false;
                                    label11.Visible = false;
                                    label7.Text = "Завтрак " + perviy.ToString() + " кКал.";
                                    label8.Text = "Обед " + perviy.ToString() + " кКал.";
                                    label9.Text = "Ужин " + perviy.ToString() + " кКал.";

                                }
                                else if (radioButton2.Checked)
                                {
                                    double perviy = rass / 100 * 30;
                                    double vtoroy = rass / 100 * 20;
                                    label7.Visible = true;
                                    label8.Visible = true;
                                    label9.Visible = true;
                                    label10.Visible = true;
                                    label11.Visible = false;
                                    label7.Text = "Завтрак " + perviy.ToString() + " кКал.";
                                    label8.Text = "Обед " + perviy.ToString() + " кКал.";
                                    label9.Text = "Полдник " + vtoroy.ToString() + " кКал.";
                                    label10.Text = "Ужин " + vtoroy.ToString() + " кКал.";


                                }
                                else if (radioButton3.Checked)
                                {
                                    double perviy = rass / 100 * 30;
                                    double vtoroy = rass / 100 * 15;
                                    double tretiy = rass / 100 * 10;
                                    label7.Visible = true;
                                    label8.Visible = true;
                                    label9.Visible = true;
                                    label10.Visible = true;
                                    label11.Visible = true;
                                    label7.Text = "Завтрак " + perviy.ToString() + " кКал.";
                                    label8.Text = "2-ой Завтрак " + perviy.ToString() + " кКал.";
                                    label9.Text = "Обед " + vtoroy.ToString() + " кКал.";
                                    label10.Text = "Полдник " + vtoroy.ToString() + " кКал.";
                                    label11.Text = "Ужин " + tretiy.ToString() + " кКал.";
                                }
                                MessageBox.Show("Вам потребуется: " + rass + " кКал.");
                            }
                            else if (comboBox2.SelectedIndex == 2)
                            {
                                double rass = ((ves * 10) + (rost * 6.25) - (vozrast * 5) + 5) * 1.55;
                                rasschet.Text = "Вам потребуется: " + rass.ToString() + " кКал.";
                                if (radioButton1.Checked)
                                {
                                    double perviy = rass / 100 * 33;
                                    label7.Visible = true;
                                    label8.Visible = true;
                                    label9.Visible = true;
                                    label10.Visible = false;
                                    label11.Visible = false;
                                    label7.Text = "Завтрак " + perviy.ToString() + " кКал.";
                                    label8.Text = "Обед " + perviy.ToString() + " кКал.";
                                    label9.Text = "Ужин " + perviy.ToString() + " кКал.";

                                }
                                else if (radioButton2.Checked)
                                {
                                    double perviy = rass / 100 * 30;
                                    double vtoroy = rass / 100 * 20;
                                    label7.Visible = true;
                                    label8.Visible = true;
                                    label9.Visible = true;
                                    label10.Visible = true;
                                    label11.Visible = false;
                                    label7.Text = "Завтрак " + perviy.ToString() + " кКал.";
                                    label8.Text = "Обед " + perviy.ToString() + " кКал.";
                                    label9.Text = "Полдник " + vtoroy.ToString() + " кКал.";
                                    label10.Text = "Ужин " + vtoroy.ToString() + " кКал.";


                                }
                                else if (radioButton3.Checked)
                                {
                                    double perviy = rass / 100 * 30;
                                    double vtoroy = rass / 100 * 15;
                                    double tretiy = rass / 100 * 10;
                                    label7.Visible = true;
                                    label8.Visible = true;
                                    label9.Visible = true;
                                    label10.Visible = true;
                                    label11.Visible = true;
                                    label7.Text = "Завтрак " + perviy.ToString() + " кКал.";
                                    label8.Text = "2-ой Завтрак " + perviy.ToString() + " кКал.";
                                    label9.Text = "Обед " + vtoroy.ToString() + " кКал.";
                                    label10.Text = "Полдник " + vtoroy.ToString() + " кКал.";
                                    label11.Text = "Ужин " + tretiy.ToString() + " кКал.";
                                }
                                MessageBox.Show("Вам потребуется: " + rass + " кКал.");
                            }
                            else if (comboBox2.SelectedIndex == 3)
                            {
                                double rass = ((ves * 10) + (rost * 6.25) - (vozrast * 5) + 5) * 1.7;
                                rasschet.Text = "Вам потребуется: " + rass.ToString() + " кКал.";
                                if (radioButton1.Checked)
                                {
                                    double perviy = rass / 100 * 33;
                                    label7.Visible = true;
                                    label8.Visible = true;
                                    label9.Visible = true;
                                    label10.Visible = false;
                                    label11.Visible = false;
                                    label7.Text = "Завтрак " + perviy.ToString() + " кКал.";
                                    label8.Text = "Обед " + perviy.ToString() + " кКал.";
                                    label9.Text = "Ужин " + perviy.ToString() + " кКал.";

                                }
                                else if (radioButton2.Checked)
                                {
                                    double perviy = rass / 100 * 30;
                                    double vtoroy = rass / 100 * 20;
                                    label7.Visible = true;
                                    label8.Visible = true;
                                    label9.Visible = true;
                                    label10.Visible = true;
                                    label11.Visible = false;
                                    label7.Text = "Завтрак " + perviy.ToString() + " кКал.";
                                    label8.Text = "Обед " + perviy.ToString() + " кКал.";
                                    label9.Text = "Полдник " + vtoroy.ToString() + " кКал.";
                                    label10.Text = "Ужин " + vtoroy.ToString() + " кКал.";


                                }
                                else if (radioButton3.Checked)
                                {
                                    double perviy = rass / 100 * 30;
                                    double vtoroy = rass / 100 * 15;
                                    double tretiy = rass / 100 * 10;
                                    label7.Visible = true;
                                    label8.Visible = true;
                                    label9.Visible = true;
                                    label10.Visible = true;
                                    label11.Visible = true;
                                    label7.Text = "Завтрак " + perviy.ToString() + " кКал.";
                                    label8.Text = "2-ой Завтрак " + perviy.ToString() + " кКал.";
                                    label9.Text = "Обед " + vtoroy.ToString() + " кКал.";
                                    label10.Text = "Полдник " + vtoroy.ToString() + " кКал.";
                                    label11.Text = "Ужин " + tretiy.ToString() + " кКал.";
                                }
                                MessageBox.Show("Вам потребуется: " + rass + " кКал.");
                            }
                            else if (comboBox2.SelectedIndex == 4)
                            {
                                double rass = ((ves * 10) + (rost * 6.25) - (vozrast * 5) + 5) * 1.9;
                                rasschet.Text = "Вам потребуется: " + rass.ToString() + " кКал.";
                                if (radioButton1.Checked)
                                {
                                    double perviy = rass / 100 * 33;
                                    label7.Visible = true;
                                    label8.Visible = true;
                                    label9.Visible = true;
                                    label10.Visible = false;
                                    label11.Visible = false;
                                    label7.Text = "Завтрак " + perviy.ToString() + " кКал.";
                                    label8.Text = "Обед " + perviy.ToString() + " кКал.";
                                    label9.Text = "Ужин " + perviy.ToString() + " кКал.";

                                }
                                else if (radioButton2.Checked)
                                {
                                    double perviy = rass / 100 * 30;
                                    double vtoroy = rass / 100 * 20;
                                    label7.Visible = true;
                                    label8.Visible = true;
                                    label9.Visible = true;
                                    label10.Visible = true;
                                    label11.Visible = false;
                                    label7.Text = "Завтрак " + perviy.ToString() + " кКал.";
                                    label8.Text = "Обед " + perviy.ToString() + " кКал.";
                                    label9.Text = "Полдник " + vtoroy.ToString() + " кКал.";
                                    label10.Text = "Ужин " + vtoroy.ToString() + " кКал.";


                                }
                                else if (radioButton3.Checked)
                                {
                                    double perviy = rass / 100 * 30;
                                    double vtoroy = rass / 100 * 15;
                                    double tretiy = rass / 100 * 10;
                                    label7.Visible = true;
                                    label8.Visible = true;
                                    label9.Visible = true;
                                    label10.Visible = true;
                                    label11.Visible = true;
                                    label7.Text = "Завтрак " + perviy.ToString() + " кКал.";
                                    label8.Text = "2-ой Завтрак " + perviy.ToString() + " кКал.";
                                    label9.Text = "Обед " + vtoroy.ToString() + " кКал.";
                                    label10.Text = "Полдник " + vtoroy.ToString() + " кКал.";
                                    label11.Text = "Ужин " + tretiy.ToString() + " кКал.";
                                }
                                MessageBox.Show("Вам потребуется: " + rass + " кКал.");
                            }


                        }

                        else if (comboBox1.SelectedIndex == 1)
                        {
                            if (comboBox2.SelectedIndex == 0)
                            {
                                double rass = ((ves * 10) + (rost * 6.25) - (vozrast * 5) - 161) * 1.2;
                                rasschet.Text = "Вам потребуется: " + rass.ToString() + " кКал.";
                                if (radioButton1.Checked)
                                {
                                    double perviy = rass / 100 * 33;
                                    label7.Visible = true;
                                    label8.Visible = true;
                                    label9.Visible = true;
                                    label10.Visible = false;
                                    label11.Visible = false;
                                    label7.Text = "Завтрак " + perviy.ToString() + " кКал.";
                                    label8.Text = "Обед " + perviy.ToString() + " кКал.";
                                    label9.Text = "Ужин " + perviy.ToString() + " кКал.";

                                }
                                else if (radioButton2.Checked)
                                {
                                    double perviy = rass / 100 * 30;
                                    double vtoroy = rass / 100 * 20;
                                    label7.Visible = true;
                                    label8.Visible = true;
                                    label9.Visible = true;
                                    label10.Visible = true;
                                    label11.Visible = false;
                                    label7.Text = "Завтрак " + perviy.ToString() + " кКал.";
                                    label8.Text = "Обед " + perviy.ToString() + " кКал.";
                                    label9.Text = "Полдник " + vtoroy.ToString() + " кКал.";
                                    label10.Text = "Ужин " + vtoroy.ToString() + " кКал.";


                                }
                                else if (radioButton3.Checked)
                                {
                                    double perviy = rass / 100 * 30;
                                    double vtoroy = rass / 100 * 15;
                                    double tretiy = rass / 100 * 10;
                                    label7.Visible = true;
                                    label8.Visible = true;
                                    label9.Visible = true;
                                    label10.Visible = true;
                                    label11.Visible = true;
                                    label7.Text = "Завтрак " + perviy.ToString() + " кКал.";
                                    label8.Text = "2-ой Завтрак " + perviy.ToString() + " кКал.";
                                    label9.Text = "Обед " + vtoroy.ToString() + " кКал.";
                                    label10.Text = "Полдник " + vtoroy.ToString() + " кКал.";
                                    label11.Text = "Ужин " + tretiy.ToString() + " кКал.";
                                }
                                MessageBox.Show("Вам потребуется: " + rass + " кКал.");
                            }
                            else if (comboBox2.SelectedIndex == 1)
                            {
                                double rass = ((ves * 10) + (rost * 6.25) - (vozrast * 5) - 161) * 1.38;
                                rasschet.Text = "Вам потребуется: " + rass.ToString() + " кКал.";
                                if (radioButton1.Checked)
                                {
                                    double perviy = rass / 100 * 33;
                                    label7.Visible = true;
                                    label8.Visible = true;
                                    label9.Visible = true;
                                    label10.Visible = false;
                                    label11.Visible = false;
                                    label7.Text = "Завтрак " + perviy.ToString() + " кКал.";
                                    label8.Text = "Обед " + perviy.ToString() + " кКал.";
                                    label9.Text = "Ужин " + perviy.ToString() + " кКал.";

                                }
                                else if (radioButton2.Checked)
                                {
                                    double perviy = rass / 100 * 30;
                                    double vtoroy = rass / 100 * 20;
                                    label7.Visible = true;
                                    label8.Visible = true;
                                    label9.Visible = true;
                                    label10.Visible = true;
                                    label11.Visible = false;
                                    label7.Text = "Завтрак " + perviy.ToString() + " кКал.";
                                    label8.Text = "Обед " + perviy.ToString() + " кКал.";
                                    label9.Text = "Полдник " + vtoroy.ToString() + " кКал.";
                                    label10.Text = "Ужин " + vtoroy.ToString() + " кКал.";


                                }
                                else if (radioButton3.Checked)
                                {
                                    double perviy = rass / 100 * 30;
                                    double vtoroy = rass / 100 * 15;
                                    double tretiy = rass / 100 * 10;
                                    label7.Visible = true;
                                    label8.Visible = true;
                                    label9.Visible = true;
                                    label10.Visible = true;
                                    label11.Visible = true;
                                    label7.Text = "Завтрак " + perviy.ToString() + " кКал.";
                                    label8.Text = "2-ой Завтрак " + perviy.ToString() + " кКал.";
                                    label9.Text = "Обед " + vtoroy.ToString() + " кКал.";
                                    label10.Text = "Полдник " + vtoroy.ToString() + " кКал.";
                                    label11.Text = "Ужин " + tretiy.ToString() + " кКал.";
                                }
                                MessageBox.Show("Вам потребуется: " + rass + " кКал.");
                            }
                            else if (comboBox2.SelectedIndex == 2)
                            {
                                double rass = ((ves * 10) + (rost * 6.25) - (vozrast * 5) - 161) * 1.55;
                                rasschet.Text = "Вам потребуется: " + rass.ToString() + " кКал.";
                                if (radioButton1.Checked)
                                {
                                    double perviy = rass / 100 * 33;
                                    label7.Visible = true;
                                    label8.Visible = true;
                                    label9.Visible = true;
                                    label10.Visible = false;
                                    label11.Visible = false;
                                    label7.Text = "Завтрак " + perviy.ToString() + " кКал.";
                                    label8.Text = "Обед " + perviy.ToString() + " кКал.";
                                    label9.Text = "Ужин " + perviy.ToString() + " кКал.";

                                }
                                else if (radioButton2.Checked)
                                {
                                    double perviy = rass / 100 * 30;
                                    double vtoroy = rass / 100 * 20;
                                    label7.Visible = true;
                                    label8.Visible = true;
                                    label9.Visible = true;
                                    label10.Visible = true;
                                    label11.Visible = false;
                                    label7.Text = "Завтрак " + perviy.ToString() + " кКал.";
                                    label8.Text = "Обед " + perviy.ToString() + " кКал.";
                                    label9.Text = "Полдник " + vtoroy.ToString() + " кКал.";
                                    label10.Text = "Ужин " + vtoroy.ToString() + " кКал.";


                                }
                                else if (radioButton3.Checked)
                                {
                                    double perviy = rass / 100 * 30;
                                    double vtoroy = rass / 100 * 15;
                                    double tretiy = rass / 100 * 10;
                                    label7.Visible = true;
                                    label8.Visible = true;
                                    label9.Visible = true;
                                    label10.Visible = true;
                                    label11.Visible = true;
                                    label7.Text = "Завтрак " + perviy.ToString() + " кКал.";
                                    label8.Text = "2-ой Завтрак " + perviy.ToString() + " кКал.";
                                    label9.Text = "Обед " + vtoroy.ToString() + " кКал.";
                                    label10.Text = "Полдник " + vtoroy.ToString() + " кКал.";
                                    label11.Text = "Ужин " + tretiy.ToString() + " кКал.";
                                }
                                MessageBox.Show("Вам потребуется: " + rass + " кКал.");
                            }
                            else if (comboBox2.SelectedIndex == 3)
                            {
                                double rass = ((ves * 10) + (rost * 6.25) - (vozrast * 5) - 161) * 1.7;
                                rasschet.Text = "Вам потребуется: " + rass.ToString() + " кКал.";
                                if (radioButton1.Checked)
                                {
                                    double perviy = rass / 100 * 33;
                                    label7.Visible = true;
                                    label8.Visible = true;
                                    label9.Visible = true;
                                    label10.Visible = false;
                                    label11.Visible = false;
                                    label7.Text = "Завтрак " + perviy.ToString() + " кКал.";
                                    label8.Text = "Обед " + perviy.ToString() + " кКал.";
                                    label9.Text = "Ужин " + perviy.ToString() + " кКал.";

                                }
                                else if (radioButton2.Checked)
                                {
                                    double perviy = rass / 100 * 30;
                                    double vtoroy = rass / 100 * 20;
                                    label7.Visible = true;
                                    label8.Visible = true;
                                    label9.Visible = true;
                                    label10.Visible = true;
                                    label11.Visible = false;
                                    label7.Text = "Завтрак " + perviy.ToString() + " кКал.";
                                    label8.Text = "Обед " + perviy.ToString() + " кКал.";
                                    label9.Text = "Полдник " + vtoroy.ToString() + " кКал.";
                                    label10.Text = "Ужин " + vtoroy.ToString() + " кКал.";


                                }
                                else if (radioButton3.Checked)
                                {
                                    double perviy = rass / 100 * 30;
                                    double vtoroy = rass / 100 * 15;
                                    double tretiy = rass / 100 * 10;
                                    label7.Visible = true;
                                    label8.Visible = true;
                                    label9.Visible = true;
                                    label10.Visible = true;
                                    label11.Visible = true;
                                    label7.Text = "Завтрак " + perviy.ToString() + " кКал.";
                                    label8.Text = "2-ой Завтрак " + perviy.ToString() + " кКал.";
                                    label9.Text = "Обед " + vtoroy.ToString() + " кКал.";
                                    label10.Text = "Полдник " + vtoroy.ToString() + " кКал.";
                                    label11.Text = "Ужин " + tretiy.ToString() + " кКал.";
                                }
                                MessageBox.Show("Вам потребуется: " + rass + " кКал.");
                            }
                            else if (comboBox2.SelectedIndex == 4)
                            {
                                double rass = ((ves * 10) + (rost * 6.25) - (vozrast * 5) - 161) * 1.9;
                                rasschet.Text = "Вам потребуется: " + rass.ToString() + " кКал.";
                                if (radioButton1.Checked)
                                {
                                    double perviy = rass / 100 * 33;
                                    label7.Visible = true;
                                    label8.Visible = true;
                                    label9.Visible = true;
                                    label10.Visible = false;
                                    label11.Visible = false;
                                    label7.Text = "Завтрак " + perviy.ToString() + " кКал.";
                                    label8.Text = "Обед " + perviy.ToString() + " кКал.";
                                    label9.Text = "Ужин " + perviy.ToString() + " кКал.";

                                }
                                else if (radioButton2.Checked)
                                {
                                    double perviy = rass / 100 * 30;
                                    double vtoroy = rass / 100 * 20;
                                    label7.Visible = true;
                                    label8.Visible = true;
                                    label9.Visible = true;
                                    label10.Visible = true;
                                    label11.Visible = false;
                                    label7.Text = "Завтрак " + perviy.ToString() + " кКал.";
                                    label8.Text = "Обед " + perviy.ToString() + " кКал.";
                                    label9.Text = "Полдник " + vtoroy.ToString() + " кКал.";
                                    label10.Text = "Ужин " + vtoroy.ToString() + " кКал.";


                                }
                                else if (radioButton3.Checked)
                                {
                                    double perviy = rass / 100 * 30;
                                    double vtoroy = rass / 100 * 15;
                                    double tretiy = rass / 100 * 10;
                                    label7.Visible = true;
                                    label8.Visible = true;
                                    label9.Visible = true;
                                    label10.Visible = true;
                                    label11.Visible = true;
                                    label7.Text = "Завтрак " + perviy.ToString() + " кКал.";
                                    label8.Text = "2-ой Завтрак " + perviy.ToString() + " кКал.";
                                    label9.Text = "Обед " + vtoroy.ToString() + " кКал.";
                                    label10.Text = "Полдник " + vtoroy.ToString() + " кКал.";
                                    label11.Text = "Ужин " + tretiy.ToString() + " кКал.";
                                }
                                MessageBox.Show("Вам потребуется: " + rass + " кКал.");
                            }


                        }

                    }

                    else
                    {

                    }

                    if (comboBox3.SelectedIndex == 1) //формула Харриса-Бенедикта нужно будет поменять значения!!!
                    {
                        if (comboBox1.SelectedIndex == 0)
                        {
                            if (comboBox2.SelectedIndex == 0)
                            {
                                double rass = (655 + (ves * 9.6) + (rost * 1.8) - (vozrast * 4.7)) * 1.2;
                                rasschet.Text = "Вам потребуется: " + rass.ToString() + " кКал.";
                                if (radioButton1.Checked)
                                {
                                    double perviy = rass / 100 * 33;
                                    label7.Visible = true;
                                    label8.Visible = true;
                                    label9.Visible = true;
                                    label10.Visible = false;
                                    label11.Visible = false;
                                    label7.Text = "Завтрак " + perviy.ToString() + " кКал.";
                                    label8.Text = "Обед " + perviy.ToString() + " кКал.";
                                    label9.Text = "Ужин " + perviy.ToString() + " кКал.";

                                }
                                else if (radioButton2.Checked)
                                {
                                    double perviy = rass / 100 * 30;
                                    double vtoroy = rass / 100 * 20;
                                    label7.Visible = true;
                                    label8.Visible = true;
                                    label9.Visible = true;
                                    label10.Visible = true;
                                    label11.Visible = false;
                                    label7.Text = "Завтрак " + perviy.ToString() + " кКал.";
                                    label8.Text = "Обед " + perviy.ToString() + " кКал.";
                                    label9.Text = "Полдник " + vtoroy.ToString() + " кКал.";
                                    label10.Text = "Ужин " + vtoroy.ToString() + " кКал.";


                                }
                                else if (radioButton3.Checked)
                                {
                                    double perviy = rass / 100 * 30;
                                    double vtoroy = rass / 100 * 15;
                                    double tretiy = rass / 100 * 10;
                                    label7.Visible = true;
                                    label8.Visible = true;
                                    label9.Visible = true;
                                    label10.Visible = true;
                                    label11.Visible = true;
                                    label7.Text = "Завтрак " + perviy.ToString() + " кКал.";
                                    label8.Text = "2-ой Завтрак " + perviy.ToString() + " кКал.";
                                    label9.Text = "Обед " + vtoroy.ToString() + " кКал.";
                                    label10.Text = "Полдник " + vtoroy.ToString() + " кКал.";
                                    label11.Text = "Ужин " + tretiy.ToString() + " кКал.";
                                }
                                MessageBox.Show("Вам потребуется: " + rass + " кКал.");
                            }
                            else if (comboBox2.SelectedIndex == 1)
                            {
                                double rass = (655 + (ves * 9.6) + (rost * 1.8) - (vozrast * 4.7)) * 1.38;
                                rasschet.Text = "Вам потребуется: " + rass.ToString() + " кКал.";
                                if (radioButton1.Checked)
                                {
                                    double perviy = rass / 100 * 33;
                                    label7.Visible = true;
                                    label8.Visible = true;
                                    label9.Visible = true;
                                    label10.Visible = false;
                                    label11.Visible = false;
                                    label7.Text = "Завтрак " + perviy.ToString() + " кКал.";
                                    label8.Text = "Обед " + perviy.ToString() + " кКал.";
                                    label9.Text = "Ужин " + perviy.ToString() + " кКал.";

                                }
                                else if (radioButton2.Checked)
                                {
                                    double perviy = rass / 100 * 30;
                                    double vtoroy = rass / 100 * 20;
                                    label7.Visible = true;
                                    label8.Visible = true;
                                    label9.Visible = true;
                                    label10.Visible = true;
                                    label11.Visible = false;
                                    label7.Text = "Завтрак " + perviy.ToString() + " кКал.";
                                    label8.Text = "Обед " + perviy.ToString() + " кКал.";
                                    label9.Text = "Полдник " + vtoroy.ToString() + " кКал.";
                                    label10.Text = "Ужин " + vtoroy.ToString() + " кКал.";


                                }
                                else if (radioButton3.Checked)
                                {
                                    double perviy = rass / 100 * 30;
                                    double vtoroy = rass / 100 * 15;
                                    double tretiy = rass / 100 * 10;
                                    label7.Visible = true;
                                    label8.Visible = true;
                                    label9.Visible = true;
                                    label10.Visible = true;
                                    label11.Visible = true;
                                    label7.Text = "Завтрак " + perviy.ToString() + " кКал.";
                                    label8.Text = "2-ой Завтрак " + perviy.ToString() + " кКал.";
                                    label9.Text = "Обед " + vtoroy.ToString() + " кКал.";
                                    label10.Text = "Полдник " + vtoroy.ToString() + " кКал.";
                                    label11.Text = "Ужин " + tretiy.ToString() + " кКал.";
                                }
                                MessageBox.Show("Вам потребуется: " + rass + " кКал.");
                            }
                            else if (comboBox2.SelectedIndex == 2)
                            {
                                double rass = (655 + (ves * 9.6) + (rost * 1.8) - (vozrast * 4.7)) * 1.55;
                                rasschet.Text = "Вам потребуется: " + rass.ToString() + " кКал.";
                                if (radioButton1.Checked)
                                {
                                    double perviy = rass / 100 * 33;
                                    label7.Visible = true;
                                    label8.Visible = true;
                                    label9.Visible = true;
                                    label10.Visible = false;
                                    label11.Visible = false;
                                    label7.Text = "Завтрак " + perviy.ToString() + " кКал.";
                                    label8.Text = "Обед " + perviy.ToString() + " кКал.";
                                    label9.Text = "Ужин " + perviy.ToString() + " кКал.";

                                }
                                else if (radioButton2.Checked)
                                {
                                    double perviy = rass / 100 * 30;
                                    double vtoroy = rass / 100 * 20;
                                    label7.Visible = true;
                                    label8.Visible = true;
                                    label9.Visible = true;
                                    label10.Visible = true;
                                    label11.Visible = false;
                                    label7.Text = "Завтрак " + perviy.ToString() + " кКал.";
                                    label8.Text = "Обед " + perviy.ToString() + " кКал.";
                                    label9.Text = "Полдник " + vtoroy.ToString() + " кКал.";
                                    label10.Text = "Ужин " + vtoroy.ToString() + " кКал.";


                                }
                                else if (radioButton3.Checked)
                                {
                                    double perviy = rass / 100 * 30;
                                    double vtoroy = rass / 100 * 15;
                                    double tretiy = rass / 100 * 10;
                                    label7.Visible = true;
                                    label8.Visible = true;
                                    label9.Visible = true;
                                    label10.Visible = true;
                                    label11.Visible = true;
                                    label7.Text = "Завтрак " + perviy.ToString() + " кКал.";
                                    label8.Text = "2-ой Завтрак " + perviy.ToString() + " кКал.";
                                    label9.Text = "Обед " + vtoroy.ToString() + " кКал.";
                                    label10.Text = "Полдник " + vtoroy.ToString() + " кКал.";
                                    label11.Text = "Ужин " + tretiy.ToString() + " кКал.";
                                }
                                MessageBox.Show("Вам потребуется: " + rass + " кКал.");
                            }
                            else if (comboBox2.SelectedIndex == 3)
                            {
                                double rass = (655 + (ves * 9.6) + (rost * 1.8) - (vozrast * 4.7)) * 1.7;
                                rasschet.Text = "Вам потребуется: " + rass.ToString() + " кКал.";
                                if (radioButton1.Checked)
                                {
                                    double perviy = rass / 100 * 33;
                                    label7.Visible = true;
                                    label8.Visible = true;
                                    label9.Visible = true;
                                    label10.Visible = false;
                                    label11.Visible = false;
                                    label7.Text = "Завтрак " + perviy.ToString() + " кКал.";
                                    label8.Text = "Обед " + perviy.ToString() + " кКал.";
                                    label9.Text = "Ужин " + perviy.ToString() + " кКал.";

                                }
                                else if (radioButton2.Checked)
                                {
                                    double perviy = rass / 100 * 30;
                                    double vtoroy = rass / 100 * 20;
                                    label7.Visible = true;
                                    label8.Visible = true;
                                    label9.Visible = true;
                                    label10.Visible = true;
                                    label11.Visible = false;
                                    label7.Text = "Завтрак " + perviy.ToString() + " кКал.";
                                    label8.Text = "Обед " + perviy.ToString() + " кКал.";
                                    label9.Text = "Полдник " + vtoroy.ToString() + " кКал.";
                                    label10.Text = "Ужин " + vtoroy.ToString() + " кКал.";


                                }
                                else if (radioButton3.Checked)
                                {
                                    double perviy = rass / 100 * 30;
                                    double vtoroy = rass / 100 * 15;
                                    double tretiy = rass / 100 * 10;
                                    label7.Visible = true;
                                    label8.Visible = true;
                                    label9.Visible = true;
                                    label10.Visible = true;
                                    label11.Visible = true;
                                    label7.Text = "Завтрак " + perviy.ToString() + " кКал.";
                                    label8.Text = "2-ой Завтрак " + perviy.ToString() + " кКал.";
                                    label9.Text = "Обед " + vtoroy.ToString() + " кКал.";
                                    label10.Text = "Полдник " + vtoroy.ToString() + " кКал.";
                                    label11.Text = "Ужин " + tretiy.ToString() + " кКал.";
                                }
                                MessageBox.Show("Вам потребуется: " + rass + " кКал.");
                            }
                            else if (comboBox2.SelectedIndex == 4)
                            {
                                double rass = (655 + (ves * 9.6) + (rost * 1.8) - (vozrast * 4.7)) * 1.9;
                                rasschet.Text = "Вам потребуется: " + rass.ToString() + " кКал.";
                                if (radioButton1.Checked)
                                {
                                    double perviy = rass / 100 * 33;
                                    label7.Visible = true;
                                    label8.Visible = true;
                                    label9.Visible = true;
                                    label10.Visible = false;
                                    label11.Visible = false;
                                    label7.Text = "Завтрак " + perviy.ToString() + " кКал.";
                                    label8.Text = "Обед " + perviy.ToString() + " кКал.";
                                    label9.Text = "Ужин " + perviy.ToString() + " кКал.";

                                }
                                else if (radioButton2.Checked)
                                {
                                    double perviy = rass / 100 * 30;
                                    double vtoroy = rass / 100 * 20;
                                    label7.Visible = true;
                                    label8.Visible = true;
                                    label9.Visible = true;
                                    label10.Visible = true;
                                    label11.Visible = false;
                                    label7.Text = "Завтрак " + perviy.ToString() + " кКал.";
                                    label8.Text = "Обед " + perviy.ToString() + " кКал.";
                                    label9.Text = "Полдник " + vtoroy.ToString() + " кКал.";
                                    label10.Text = "Ужин " + vtoroy.ToString() + " кКал.";


                                }
                                else if (radioButton3.Checked)
                                {
                                    double perviy = rass / 100 * 30;
                                    double vtoroy = rass / 100 * 15;
                                    double tretiy = rass / 100 * 10;
                                    label7.Visible = true;
                                    label8.Visible = true;
                                    label9.Visible = true;
                                    label10.Visible = true;
                                    label11.Visible = true;
                                    label7.Text = "Завтрак " + perviy.ToString() + " кКал.";
                                    label8.Text = "2-ой Завтрак " + perviy.ToString() + " кКал.";
                                    label9.Text = "Обед " + vtoroy.ToString() + " кКал.";
                                    label10.Text = "Полдник " + vtoroy.ToString() + " кКал.";
                                    label11.Text = "Ужин " + tretiy.ToString() + " кКал.";
                                }
                                MessageBox.Show("Вам потребуется: " + rass + " кКал.");
                            }


                        }

                        else if (comboBox1.SelectedIndex == 1)
                        {
                            if (comboBox2.SelectedIndex == 0)
                            {
                                double rass = (66 + (ves * 13.7) + (rost * 5) - (vozrast * 6.8)) * 1.2;
                                rasschet.Text = "Вам потребуется: " + rass.ToString() + " кКал.";
                                if (radioButton1.Checked)
                                {
                                    double perviy = rass / 100 * 33;
                                    label7.Visible = true;
                                    label8.Visible = true;
                                    label9.Visible = true;
                                    label10.Visible = false;
                                    label11.Visible = false;
                                    label7.Text = "Завтрак " + perviy.ToString() + " кКал.";
                                    label8.Text = "Обед " + perviy.ToString() + " кКал.";
                                    label9.Text = "Ужин " + perviy.ToString() + " кКал.";

                                }
                                else if (radioButton2.Checked)
                                {
                                    double perviy = rass / 100 * 30;
                                    double vtoroy = rass / 100 * 20;
                                    label7.Visible = true;
                                    label8.Visible = true;
                                    label9.Visible = true;
                                    label10.Visible = true;
                                    label11.Visible = false;
                                    label7.Text = "Завтрак " + perviy.ToString() + " кКал.";
                                    label8.Text = "Обед " + perviy.ToString() + " кКал.";
                                    label9.Text = "Полдник " + vtoroy.ToString() + " кКал.";
                                    label10.Text = "Ужин " + vtoroy.ToString() + " кКал.";


                                }
                                else if (radioButton3.Checked)
                                {
                                    double perviy = rass / 100 * 30;
                                    double vtoroy = rass / 100 * 15;
                                    double tretiy = rass / 100 * 10;
                                    label7.Visible = true;
                                    label8.Visible = true;
                                    label9.Visible = true;
                                    label10.Visible = true;
                                    label11.Visible = true;
                                    label7.Text = "Завтрак " + perviy.ToString() + " кКал.";
                                    label8.Text = "2-ой Завтрак " + perviy.ToString() + " кКал.";
                                    label9.Text = "Обед " + vtoroy.ToString() + " кКал.";
                                    label10.Text = "Полдник " + vtoroy.ToString() + " кКал.";
                                    label11.Text = "Ужин " + tretiy.ToString() + " кКал.";
                                }
                                MessageBox.Show("Вам потребуется: " + rass + " кКал.");
                            }
                            else if (comboBox2.SelectedIndex == 1)
                            {
                                double rass = (66 + (ves * 13.7) + (rost * 5) - (vozrast * 6.8)) * 1.38;
                                rasschet.Text = "Вам потребуется: " + rass.ToString() + " кКал.";
                                if (radioButton1.Checked)
                                {
                                    double perviy = rass / 100 * 33;
                                    label7.Visible = true;
                                    label8.Visible = true;
                                    label9.Visible = true;
                                    label10.Visible = false;
                                    label11.Visible = false;
                                    label7.Text = "Завтрак " + perviy.ToString() + " кКал.";
                                    label8.Text = "Обед " + perviy.ToString() + " кКал.";
                                    label9.Text = "Ужин " + perviy.ToString() + " кКал.";

                                }
                                else if (radioButton2.Checked)
                                {
                                    double perviy = rass / 100 * 30;
                                    double vtoroy = rass / 100 * 20;
                                    label7.Visible = true;
                                    label8.Visible = true;
                                    label9.Visible = true;
                                    label10.Visible = true;
                                    label11.Visible = false;
                                    label7.Text = "Завтрак " + perviy.ToString() + " кКал.";
                                    label8.Text = "Обед " + perviy.ToString() + " кКал.";
                                    label9.Text = "Полдник " + vtoroy.ToString() + " кКал.";
                                    label10.Text = "Ужин " + vtoroy.ToString() + " кКал.";


                                }
                                else if (radioButton3.Checked)
                                {
                                    double perviy = rass / 100 * 30;
                                    double vtoroy = rass / 100 * 15;
                                    double tretiy = rass / 100 * 10;
                                    label7.Visible = true;
                                    label8.Visible = true;
                                    label9.Visible = true;
                                    label10.Visible = true;
                                    label11.Visible = true;
                                    label7.Text = "Завтрак " + perviy.ToString() + " кКал.";
                                    label8.Text = "2-ой Завтрак " + perviy.ToString() + " кКал.";
                                    label9.Text = "Обед " + vtoroy.ToString() + " кКал.";
                                    label10.Text = "Полдник " + vtoroy.ToString() + " кКал.";
                                    label11.Text = "Ужин " + tretiy.ToString() + " кКал.";
                                }
                                MessageBox.Show("Вам потребуется: " + rass + " кКал.");
                            }
                            else if (comboBox2.SelectedIndex == 2)
                            {
                                double rass = (66 + (ves * 13.7) + (rost * 5) - (vozrast * 6.8)) * 1.55;
                                rasschet.Text = "Вам потребуется: " + rass.ToString() + " кКал.";
                                MessageBox.Show("Вам потребуется: " + rass + " кКал.");
                            }
                            else if (comboBox2.SelectedIndex == 3)
                            {
                                double rass = (66 + (ves * 13.7) + (rost * 5) - (vozrast * 6.8)) * 1.7;
                                rasschet.Text = "Вам потребуется: " + rass.ToString() + " кКал.";
                                if (radioButton1.Checked)
                                {
                                    double perviy = rass / 100 * 33;
                                    label7.Visible = true;
                                    label8.Visible = true;
                                    label9.Visible = true;
                                    label10.Visible = false;
                                    label11.Visible = false;
                                    label7.Text = "Завтрак " + perviy.ToString() + " кКал.";
                                    label8.Text = "Обед " + perviy.ToString() + " кКал.";
                                    label9.Text = "Ужин " + perviy.ToString() + " кКал.";

                                }
                                else if (radioButton2.Checked)
                                {
                                    double perviy = rass / 100 * 30;
                                    double vtoroy = rass / 100 * 20;
                                    label7.Visible = true;
                                    label8.Visible = true;
                                    label9.Visible = true;
                                    label10.Visible = true;
                                    label11.Visible = false;
                                    label7.Text = "Завтрак " + perviy.ToString() + " кКал.";
                                    label8.Text = "Обед " + perviy.ToString() + " кКал.";
                                    label9.Text = "Полдник " + vtoroy.ToString() + " кКал.";
                                    label10.Text = "Ужин " + vtoroy.ToString() + " кКал.";


                                }
                                else if (radioButton3.Checked)
                                {
                                    double perviy = rass / 100 * 30;
                                    double vtoroy = rass / 100 * 15;
                                    double tretiy = rass / 100 * 10;
                                    label7.Visible = true;
                                    label8.Visible = true;
                                    label9.Visible = true;
                                    label10.Visible = true;
                                    label11.Visible = true;
                                    label7.Text = "Завтрак " + perviy.ToString() + " кКал.";
                                    label8.Text = "2-ой Завтрак " + perviy.ToString() + " кКал.";
                                    label9.Text = "Обед " + vtoroy.ToString() + " кКал.";
                                    label10.Text = "Полдник " + vtoroy.ToString() + " кКал.";
                                    label11.Text = "Ужин " + tretiy.ToString() + " кКал.";
                                }
                                MessageBox.Show("Вам потребуется: " + rass + " кКал.");
                            }
                            else if (comboBox2.SelectedIndex == 4)
                            {
                                double rass = (66 + (ves * 13.7) + (rost * 5) - (vozrast * 6.8)) * 1.9;
                                rasschet.Text = "Вам потребуется: " + rass.ToString() + " кКал.";
                                if (radioButton1.Checked)
                                {
                                    double perviy = rass / 100 * 33;
                                    label7.Visible = true;
                                    label8.Visible = true;
                                    label9.Visible = true;
                                    label10.Visible = false;
                                    label11.Visible = false;
                                    label7.Text = "Завтрак " + perviy.ToString() + " кКал.";
                                    label8.Text = "Обед " + perviy.ToString() + " кКал.";
                                    label9.Text = "Ужин " + perviy.ToString() + " кКал.";

                                }
                                else if (radioButton2.Checked)
                                {
                                    double perviy = rass / 100 * 30;
                                    double vtoroy = rass / 100 * 20;
                                    label7.Visible = true;
                                    label8.Visible = true;
                                    label9.Visible = true;
                                    label10.Visible = true;
                                    label11.Visible = false;
                                    label7.Text = "Завтрак " + perviy.ToString() + " кКал.";
                                    label8.Text = "Обед " + perviy.ToString() + " кКал.";
                                    label9.Text = "Полдник " + vtoroy.ToString() + " кКал.";
                                    label10.Text = "Ужин " + vtoroy.ToString() + " кКал.";


                                }
                                else if (radioButton3.Checked)
                                {
                                    double perviy = rass / 100 * 30;
                                    double vtoroy = rass / 100 * 15;
                                    double tretiy = rass / 100 * 10;
                                    label7.Visible = true;
                                    label8.Visible = true;
                                    label9.Visible = true;
                                    label10.Visible = true;
                                    label11.Visible = true;
                                    label7.Text = "Завтрак " + perviy.ToString() + " кКал.";
                                    label8.Text = "2-ой Завтрак " + perviy.ToString() + " кКал.";
                                    label9.Text = "Обед " + vtoroy.ToString() + " кКал.";
                                    label10.Text = "Полдник " + vtoroy.ToString() + " кКал.";
                                    label11.Text = "Ужин " + tretiy.ToString() + " кКал.";
                                }
                                MessageBox.Show("Вам потребуется: " + rass + " кКал.");
                            }
                        }
                    }
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox3.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox1.SelectedIndex = 0;
            radioButton1.Checked = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
            label10.Text = "";
            label11.Text = "";
            rasschet.Text = "";

        }
    }
}

