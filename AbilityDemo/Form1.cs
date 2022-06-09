namespace AbilityDemo
{

    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent(); 

        }
        
        private UserControl1 userControl1;
        private UserControl2 userControl2;
                      
        private void button1_Click(object sender, EventArgs e)
        {
            // User Control 1
            if (userControl1 != null) userControl1.Dispose();            
            userControl1 = new UserControl1();
            this.Controls.Add(userControl1);
            userControl1.Visible = false;

            if (btnUserCtrl1.Text == "ADD UC1")      
            {
                userControl1.Visible=true;
                btnUserCtrl1.Text = "Remove UC1";
            }
            
            else
            {
                userControl1.Visible=false;               
                btnUserCtrl1.Text = "ADD UC1";

            }          


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //User Control 2                      
           if (userControl2 != null) userControl2.Dispose();
            userControl2 = new UserControl2();            
            this.Controls.Add(userControl2);
            userControl2.Visible = false;
            if (btnUserCtrl2.Text == "Remove UC2")
            {
                userControl2.Visible=false;
                btnUserCtrl2.Text = "ADD UC2";
            }

            else
            {
                userControl2.Visible = true;
                btnUserCtrl2.Text = "Remove UC2";

            }


        }

    }
}