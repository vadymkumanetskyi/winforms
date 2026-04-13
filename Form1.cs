namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Button btn = new Button();
            btn.Text = "Натисни" ;
            btn.Width = 120;
            btn.Height = 40;
            btn.Left = 50;
            btn.Top = 30;
            btn.Controls.Add(btn);
            btn.Click += Btn_Click;
            TextBox textBox = new TextBox();
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
