namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1(TextBox myTextBox)
        {
            InitializeComponent();
            Button btn = new Button();
            btn.Text = "Натисни" ;
            btn.Width = 120;
            btn.Height = 40;
            btn.Left = 50;
            btn.Top = 30;
            this.Controls.Add(btn);
            btn.Click += Btn_Click;
            myTextBox.Location = new Point(250, 100);
            myTextBox.Width = 100;
            myTextBox.Height = 100;
            myTextBox.Text = "hello";
            this.Controls.Add(myTextBox);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }



        
    }
}
