using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectfinon
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string totoll;
        public string donla;
        public double tront = 0;
        public string datete;
        
        public int sum1 = 0;
        public int sum2 = 0;
        public int total = 0;
        
        private void Form2_Load(object sender, EventArgs e)
        {   
            datete = DateTime.Now.ToString();
            textBox1.Text = totoll ;
            textBox2.Text = donla;
            sum1 = Convert.ToInt16(textBox1.Text);
            sum2 = Convert.ToInt16(textBox2.Text) ;
            this.total = sum2 - sum1;
           
            string mmoff = Convert.ToString(total);

            textBox3.Text = mmoff;
                      
            textBox4.Text = datete;
            
      
           
        }

           

        

        private void button1_Click_1(object sender, EventArgs e)
        {

            Form1.change = textBox3.Text;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.change = textBox3.Text;
            this.Close();
        }
    }
}
