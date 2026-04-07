namespace sib_application;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();

        Label label1 = new Label();
        label1.Name = "testLabel1";
        label1.Location = new Point(50, 50);
        label1.Size = new Size { Width = 300, Height = 30 };

        Label label2 = new Label();
        label2.Name = "testLabel2";
        label2.Location = new Point(50, 90);
        label2.Size = new Size { Width = 370, Height = 30 };

        Label label3 = new Label();
        label3.Name = "testLabel3";
        label3.Location = new Point(50, 130);
        label3.Size = new Size { Width = 300, Height = 30 };

        Label label4 = new Label();
        label4.Name = "testLabel4";
        label4.Location = new Point(50, 170);
        label4.Size = new Size { Width = 300, Height = 30 };

        Label label5 = new Label();
        label5.Name = "testLabel5";
        label5.Location = new Point(50, 210);
        label5.Size = new Size { Width = 300, Height = 30 };

        unsafe
        {
            // variable1
            char sym = '*';
            char* ptr1 = &sym;
            ulong addr1 = (ulong)ptr1;
            label1.Text = $"variable sym: value = {sym}, address = {addr1}";

            sym = '/';
            label2.Text = $"variable sym ïîñëå èçìåíåíèÿ: value = {sym}, address = {addr1}";

            // variable2
            int number = 42;
            int* ptr2 = &number;
            ulong addr2 = (ulong)ptr2;
            label3.Text = $"viraible number: value = {number}, address = {addr2}";

            // variable3
            double pi = 3.14159;
            double* ptr3 = &pi;
            ulong addr3 = (ulong)ptr3;
            label4.Text = $"viraible pi: value = {pi}, address = {addr3}";

            // variable4
            bool flag = true;
            bool* ptr4 = &flag;
            ulong addr4 = (ulong)ptr4;
            label5.Text = $"viraible flag: value = {flag}, address = {addr4}";
        }

        this.Controls.Add(label1);
        this.Controls.Add(label2);
        this.Controls.Add(label3);
        this.Controls.Add(label4);
        this.Controls.Add(label5);
    }
}
