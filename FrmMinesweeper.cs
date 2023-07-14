using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class FrmMinesweeper : Form
    {
        public FrmMinesweeper()
        {
            InitializeComponent();        

        }


        private void btnEmpezar_Click(object sender, EventArgs e)
        {
            Random rdn = new Random();
            int mine1 = rdn.Next(1, 12);
            int mine2 = rdn.Next(12, 18);
            int mine3 = rdn.Next(19, 25);

            for(int i = 1; i <=25 ; i++)
            {

                Button btnTemp = new Button();
           
                btnTemp.Name = "btnStart" + i.ToString();
                btnTemp.Size = new System.Drawing.Size(40,40);
                btnTemp.Text = i.ToString();
                btnTemp.UseVisualStyleBackColor = true;

                if (mine1 == i || mine2 == i || mine3 == i)
                    btnTemp.Tag = true;
                else
                    btnTemp.Tag = false;



                btnTemp.Click += btnTemp_Click;
                flowLayoutPanel1.Controls.Add(btnTemp);
            }
        }

        private void btnTemp_Click(object sender, EventArgs e)
        {

            Button btnTemp = (Button)sender;
            bool tag = (bool)btnTemp.Tag;

            if(tag)
            {
                btnTemp.BackColor = Color.Red;
                int score = int.Parse(lblboom.Text);
                score++;
                lblboom.Text = score.ToString();

                if(score ==1)
                {
                    MessageBox.Show("You are lost","Game result", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
             
            }
       
            else
            {
                btnTemp.BackColor = Color.Green;
                int score = int.Parse(lblScore.Text);
                score++;
                lblScore.Text = score.ToString();
                btnTemp.Enabled = false;
                
               
            }
        }
    }
}
