using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dinamik_Araclar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = new Button();
            Point btnkonum = new Point(200,200);
            btn.Location = btnkonum;
            btn.Name = "Button1";
            btn.Text = "Tıkla";
            btn.BackColor = Color.Aqua;
            btn.Height = 50;
            btn.Width = 200;

            Label lbl = new Label();
            Point lblkonum = new Point(200,250);
            lbl.Location = lblkonum;
            lbl.Name = "Label1";
            lbl.Text = "Elyasa";
            lbl.BackColor = Color.Gainsboro;
            lbl.Height = 20;
            lbl.Width = 200;
            lbl.AutoSize = true;
            this.Controls.Add(lbl);
            this.Controls.Add(btn);
      
            for (int i = 1; i <=5; i++)
            {
                TextBox txt = new TextBox();
                Point txtkonum = new Point(350, i * 30);
                txt.Location = txtkonum;
                txt.Name = "Textbox1" + i;
                txt.Text = i.ToString();
                txt.BackColor = Color.LawnGreen;
                txt.Height = 20;
                txt.Width = 200;
                txt.AutoSize = true;
                this.Controls.Add(txt);
                    
            }
        }
    }
}
