using System;
using System.Windows.Forms;

namespace app_31._03._26_winforms
{
    public partial class Form1 : Form
    {
        private TextBox txtHeight;
        private TextBox txtPressure;
        private Button btnCalculate;
        private Label lblResult;
        private Label lblHeight;
        private Label lblPressure;

        public Form1()
        {
            InitializeComponent();
            InitializeCustomComponents();
        }

        private void InitializeCustomComponents()
        {
            this.Text = "Расчет плотности жидкости";
            this.Size = new System.Drawing.Size(400, 300);

            lblHeight = new Label();
            lblHeight.Text = "Столб жидкости высотой (см):";
            lblHeight.Location = new System.Drawing.Point(20, 20);
            lblHeight.Size = new System.Drawing.Size(200, 25);

            txtHeight = new TextBox();
            txtHeight.Location = new System.Drawing.Point(220, 20);
            txtHeight.Size = new System.Drawing.Size(150, 20);

            lblPressure = new Label();
            lblPressure.Text = "Давление в паскалях:";
            lblPressure.Location = new System.Drawing.Point(20, 60);
            lblPressure.Size = new System.Drawing.Size(200, 25);

            txtPressure = new TextBox();
            txtPressure.Location = new System.Drawing.Point(220, 60);
            txtPressure.Size = new System.Drawing.Size(150, 20);

            btnCalculate = new Button();
            btnCalculate.Text = "Рассчитать плотность";
            btnCalculate.Location = new System.Drawing.Point(20, 100);
            btnCalculate.Size = new System.Drawing.Size(350, 30);
            btnCalculate.Click += BtnCalculate_Click;

            lblResult = new Label();
            lblResult.Text = "Плотность: ";
            lblResult.Location = new System.Drawing.Point(20, 150);
            lblResult.Size = new System.Drawing.Size(350, 50);
            lblResult.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);

            this.Controls.Add(lblHeight);
            this.Controls.Add(txtHeight);
            this.Controls.Add(lblPressure);
            this.Controls.Add(txtPressure);
            this.Controls.Add(btnCalculate);
            this.Controls.Add(lblResult);
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double h = Convert.ToDouble(txtHeight.Text); // высота столба жидкости в сантиметрах
                double p = Convert.ToDouble(txtPressure.Text); // давление в паскалях

                h = h / 100;

                double g = 9.8; // ускорение свободного падения в м/с^3

                // Formula: p = density * g * h, therefore density = p / (g * h)
                double density = p / (g * h);

                lblResult.Text = $"Плотность жидкости: {density} кг/м^3";

                if (density < 0)
                {
                    lblResult.Text += "\n(Ошибка: отрицательная плотность)";
                }
                else if (density > 20000)
                {
                    lblResult.Text += "\n(Внимание: нереалистично высокая плотность)";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Пожалуйста, введите корректные числовые значения!",
                    "Ошибка ввода",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Высота столба не может быть равна нулю!",
                    "Ошибка расчета",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
