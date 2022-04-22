namespace projectfinon

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //double jryyy = ggoo-TextBox
        //double ggoo = 0;
        public static string change;
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string strdata = string.Empty;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV(*.csv)|*.csv";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] readALLline = File.ReadAllLines(openFileDialog.FileName);

                for (int i = 0; i < readALLline.Length; i++)
                {
                    string studenraw = readALLline[i];
                    string[] studenSplied = studenraw.Split(',');                    
                    dataGridView1.Rows.Add(studenSplied);

                    //todo add studen odject to datagridview
                    //adddata to gridview(studen);
                }


            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells["Column1"].Value.ToString();
                textBox2.Text = row.Cells["Column2"].Value.ToString();

            }

            switch (textBox1.Text)
            {
                case "���"://1
                   
                    pic.Image = Properties.Resources.������;
                    break;
                case "���"://2

                    pic.Image = Properties.Resources.coffee7_1;
                    break;

                case "�Ҵ�"://3

                    pic.Image = Properties.Resources.�Ҵ���繺���;
                    break;

                case "���й��"://4

                    pic.Image = Properties.Resources.�ҹ�;
                    break;
                case "�ҹ�"://5

                    pic.Image = Properties.Resources.�ҹ�;
                    break;
                case "�����"://6

                    pic.Image = Properties.Resources.�����;
                    break;
                case "������"://7

                    pic.Image = Properties.Resources.�ҹ�;
                    break;
                case "����"://8

                    pic.Image = Properties.Resources.����;
                    break;

                case "����⫴�"://9

                    pic.Image = Properties.Resources.����⫴�;
                    break;

                case "�����"://10

                    pic.Image = Properties.Resources.����;
                    break;
                case "��ѡ��"://11

                    pic.Image = Properties.Resources.��ѡ��;
                    break;
                case "���ͺ"://12

                    pic.Image = Properties.Resources.���ͺ;
                    break;
                case "����ҧ"://13

                    pic.Image = Properties.Resources.����ҧ;
                    break;
                case "��ͺ���"://14

                    pic.Image = Properties.Resources.��ͺ���;
                    break;
                case "�����˹���"://15

                    pic.Image = Properties.Resources.�����˹���;
                    break;
            }
        }
            double pricerow = 0;
            double jummun = 0;
            string gggg = string.Empty;
            string hhhh = string.Empty;
            string aaaa = string.Empty;
            
       private double calculalisi()
        {
            
             double ggoo = 0;
            for (int x = 0; x < listView1.Items.Count; x++)
            {
                gggg = (listView1.Items[x].SubItems[1].Text);

                hhhh = (listView1.Items[x].SubItems[2].Text);

                jummun = Convert.ToDouble(gggg);
                pricerow = Convert.ToDouble(hhhh);
                
                 ggoo += jummun * pricerow;

            }
            return ggoo;
        }




       

        private void button3_Click(object sender, EventArgs e)
        {
                              

            if (textBox1.Text == string.Empty || textBox2.Text == string.Empty || textBox3.Text == string.Empty)
            {
                MessageBox.Show("�ô���͡��¡��", "�س������͡", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


            else if (textBox3.Text != "")
            {
                int sss = 0;
                int number;
                float number2;
                if (!Int32.TryParse(textBox3.Text, out number) && !float.TryParse(textBox3.Text, out number2)|| number <= 0)
                {
                    MessageBox.Show("�����Ţͧ�س��ͧ�繵���Ţ��ҹ���������", "��Ǩ�ͺ�����١��ͧ������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    ListViewItem lissst = new ListViewItem(textBox1.Text);
                    lissst.SubItems.Add(textBox2.Text);
                    lissst.SubItems.Add(textBox3.Text);
                    listView1.Items.Add(lissst);
                   
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Text = calculalisi().ToString();
                }
                

                
            }
                           
      

        }
        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar != '\b') && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
            if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
                {
                    if ((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar != '\b') && (e.KeyChar != '.'))
                    {
                        e.Handled = true;
                    }
                    else
                      {
                        e.Handled = false;
                    }
                    if (Char.IsControl(e.KeyChar))
                    {
                        e.Handled = false;
                    }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            textBox4.Clear();
            textBox5.Clear();


        }

       
        

          private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
          {
                    listView1.Items.Remove(listView1.SelectedItems[0]);
                    textBox4.Text = calculalisi().ToString();
                    textBox4.Clear();
                    textBox5.Clear();

        }
                        
                private void button2_Click(object sender, EventArgs e)
                {
                    
                        
                        string ssum1 = textBox4.Text;
                        string ssum2 = textBox5.Text;
                      
                   
                   
                    if(textBox4.Text == string.Empty ||textBox5.Text == string.Empty  )
                    {
                        MessageBox.Show("�õ�Ǩ�ͺ��ͧ", "��͹", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

            
                        
                        


                    else
                    {


                    Form2 f = new Form2();
                    f.totoll = textBox4.Text;
                    f.donla = textBox5.Text;                  
                    f.ShowDialog();

                //--------------------------------------------------------------------------------------------------------------------------
                    
                       printPreviewDialog1.Document = printDocument1;
                       printPreviewDialog1.ShowDialog();


                FileStream fs = new FileStream("D:\\files.CSV", FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                for (int x = 0; x < listView1.Items.Count; x++)
                {
                    gggg = (listView1.Items[x].SubItems[1].Text);

                    hhhh = (listView1.Items[x].SubItems[2].Text);
                    aaaa = (listView1.Items[x].SubItems[0].Text);
                    sw.WriteLine(aaaa + ',' + gggg + ',' + hhhh + DateTime.Now.ToString());
                }
                //foreach (ListViewItem li in listView1.Items)
                //{
                //    sw.WriteLine(li.Text);
                //}
                sw.Close();
                fs.Close();
                


            }
        }




                
                

               
            

        

      

        private void button4_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Font font = new Font("courier new", 14);
            float fontHeight = font.GetHeight();
            int startx = 320;
            int starty = 40;
            int offset = 30;
            float leftmargin = e.MarginBounds.Left;
            float topmargin = e.MarginBounds.Top;
            e.Graphics.DrawString ("�����", new Font("courier new",25 ), new SolidBrush( ForeColor), startx, starty);
            string top = "�ѹ��������" +"\t"+ DateTime.Now.ToString();
            e.Graphics.DrawString(top,Font,new SolidBrush(ForeColor), startx, starty + offset);
            offset = offset + (int)fontHeight;
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------",new Font("courier new", 20),new SolidBrush(ForeColor), 0,starty+offset);
            offset = offset + 30;
            e.Graphics.DrawString("��¡��\t�Ҥ�\t���",font,new SolidBrush(ForeColor), startx,starty+offset);
            offset = offset + 30;
            for (int x = 0; x < listView1.Items.Count; x++)
            {
                e.Graphics.DrawString(listView1.Items[x].SubItems[0].Text+"\t"+listView1.Items[x].SubItems[1].Text + "\t"+ listView1.Items[x].SubItems[2].Text + "\t",new Font("courier new", 12), new SolidBrush(ForeColor), startx, starty+offset);
                offset = offset + 30;
            }
            offset = offset + (int)fontHeight+5;
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------", new Font("courier new", 20), new SolidBrush(ForeColor), 0, starty + offset);
            offset = offset + 15;
            e.Graphics.DrawString("�ʹ�ط��"+ "\t" + textBox4.Text+"\t" +"�ҷ", font, new SolidBrush(ForeColor), startx, starty + offset);
            offset = offset + 30;
            e.Graphics.DrawString("�Թʴ"+"\t"+textBox5.Text+"\t" + "�ҷ", font, new SolidBrush(ForeColor), startx, starty + offset);
            offset = offset + 30;
            e.Graphics.DrawString("�Թ�͹"+ "\t" + change+"\t" + "�ҷ", font, new SolidBrush(ForeColor), startx, starty + offset);
            offset = offset + 60;
            e.Graphics.DrawString("�ͺ�س������ԡ��", font, new SolidBrush(ForeColor), startx, starty + offset);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {


             FileStream fs = new FileStream("D:\\files.CSV", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            for (int x = 0; x < listView1.Items.Count; x++)
            {
                gggg = (listView1.Items[x].SubItems[1].Text);

                hhhh = (listView1.Items[x].SubItems[2].Text);
                aaaa = (listView1.Items[x].SubItems[0].Text);
                sw.WriteLine(aaaa +',' + gggg + ',' + hhhh+ DateTime.Now.ToString()); 
            }
                //foreach (ListViewItem li in listView1.Items)
                //{
                //    sw.WriteLine(li.Text);
                //}
                sw.Close();
            fs.Close();
            MessageBox.Show("����");







            //-----------------------------------------------------------

            /* FileStream fs = new FileStream("D:\\files.CSV", FileMode.Create, FileAccess.Write);
             StreamWriter sw = new StreamWriter(fs);
             foreach (ListViewItem li in listView1.Items)
             {
                 sw.WriteLine(li.Text);
             }
             sw.Close();
             fs.Close();
             MessageBox.Show("File Created");*/
        }
    }
}