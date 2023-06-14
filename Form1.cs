namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
           
            InitializeComponent();
            //this.button1.Click += (sender, e) =>
            //{
            //    DialogResult r = MessageBox.Show("clos form?", "close", MessageBoxButtons.YesNo);
            //    if (r == DialogResult.Yes)
            //        this.Close();
            //};


        }

        private void button1_Click(object sender, EventArgs e)
        {
           
           DialogResult r= MessageBox.Show("clos form?","close",MessageBoxButtons.YesNo);
            if(r==DialogResult.Yes)
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(txtName.Text);
            this.Text =$" {txtName.Text}::{txtLastName.Text}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmPaint p1 = new frmPaint();
            p1.TxtName = "enter full name";
            if (p1.ShowDialog() == DialogResult.OK)
            {
                string[] arr = p1.TxtName.Split(" ");
                txtName.Text = arr[0];
                txtLastName.Text=arr[arr.Length-1];
                //MessageBox.Show(p1.TxtName);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label3.Text = txtName.Text + txtLastName.Text;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            label3.Text = txtName.Text + txtLastName.Text;
        }
    }
}