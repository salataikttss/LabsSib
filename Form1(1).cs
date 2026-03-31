namespace app_31._03._26_winforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Label lblTitle = new Label()
            {
                Text = "Расчет объема рыбы",
                Font = new Font("Arial", 14, FontStyle.Bold),
                Location = new Point(50, 20),
                Size = new Size(300, 30)
            };

            Label lblForce = new Label()
            {
                Text = "Выталкивающая сила (Н):",
                Location = new Point(50, 70),
                Size = new Size(150, 25)
            };

            TextBox txtForce = new TextBox()
            {
                Location = new Point(210, 70),
                Size = new Size(100, 25),
                Text = "10,3"
            };

            Label lblDensity = new Label()
            {
                Text = "Плотность воды (кг/м³):",
                Location = new Point(50, 110),
                Size = new Size(150, 25)
            };

            TextBox txtDensity = new TextBox()
            {
                Location = new Point(210, 110),
                Size = new Size(100, 25),
                Text = "1030"
            };

            Label lblGravity = new Label()
            {
                Text = "Ускорение g (м/с²):",
                Location = new Point(50, 150),
                Size = new Size(150, 25)
            };

            TextBox txtGravity = new TextBox()
            {
                Location = new Point(210, 150),
                Size = new Size(100, 25),
                Text = "9,81"
            };

            Button btnCalculate = new Button()
            {
                Text = "Рассчитать объем",
                Location = new Point(50, 190),
                Size = new Size(150, 35)
            };

            Label lblResult = new Label()
            {
                Text = "Результат:",
                Font = new Font("Arial", 12, FontStyle.Bold),
                Location = new Point(50, 240),
                Size = new Size(300, 30)
            };

            Label lblAnswer = new Label()
            {
                Text = "Объем рыбы: ___ м³",
                Font = new Font("Arial", 11),
                Location = new Point(50, 280),
                Size = new Size(300, 30)
            };

            btnCalculate.Click += (sender, e) =>
            {
                try
                {
                    double force = double.Parse(txtForce.Text);
                    double density = double.Parse(txtDensity.Text);
                    double g = double.Parse(txtGravity.Text);

                    // Расчет объема по формуле: V = F / (ρ * g)
                    // где F - сила Архимеда, ρ - плотность жидкости, g - ускорение свободного падения
                    double volume = force / (density * g);

                    // Округляем до 6 знаков
                    volume = Math.Round(volume, 6);

                    // Выводим результат
                    lblAnswer.Text = $"Объем рыбы: {volume} м³";

                    // message box - выводим данные
                    MessageBox.Show($"Объем рыбы = {volume} м³\n\n" +
                                  $"Расчет:\n" +
                                  $"V = F / (ρ * g)\n" +
                                  $"V = {force} / ({density} * {g})\n" +
                                  $"V = {force} / {density * g}\n" +
                                  $"V = {volume} м³",
                                  "Результат расчета",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Пожалуйста, введите корректные числовые значения!",
                                  "Ошибка ввода",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Произошла ошибка: {ex.Message}",
                                  "Ошибка",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Error);
                }
            };

            this.Controls.Add(lblTitle);
            this.Controls.Add(lblForce);
            this.Controls.Add(txtForce);
            this.Controls.Add(lblDensity);
            this.Controls.Add(txtDensity);
            this.Controls.Add(lblGravity);
            this.Controls.Add(txtGravity);
            this.Controls.Add(btnCalculate);
            this.Controls.Add(lblResult);
            this.Controls.Add(lblAnswer);

            this.Text = "Расчет объема рыбы";
            this.Size = new Size(450, 380);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
