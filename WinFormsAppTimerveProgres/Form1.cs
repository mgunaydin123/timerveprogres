namespace WinFormsAppTimerveProgres
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            // if(progressBar1.Value<=90)
            // progressBar1.Value = progressBar1.Value+ 10;

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value <= 90)
            progressBar1.Value = progressBar1.Value+ 10;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
         
        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            progressBar1.Value = 0;
        }
    }
}