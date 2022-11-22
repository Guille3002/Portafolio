using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Happy_face_GNCB_1154322
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics papel;
            papel = pictureBox1.CreateGraphics();
            Pen pencil1 = new Pen(Color.DeepSkyBlue);

            papel.DrawEllipse(pencil1, 30, 50,100,100);

            Graphics paper;
            paper = pictureBox1.CreateGraphics();
            Pen pencil2 = new Pen(Color.DeepSkyBlue);
            
            paper.DrawEllipse(pencil2, 55, 75, 15, 15);

            Graphics papel2;
            papel2 = pictureBox1.CreateGraphics();
            Pen pencil3 = new Pen(Color.DeepSkyBlue);
            
            papel2.DrawEllipse(pencil3, 90, 75, 15, 15);

            Graphics paper2;
            paper2= pictureBox1.CreateGraphics();
            Pen pencil4 = new Pen(Color.DeepSkyBlue);
            
            paper2.DrawPie(pencil4, 47, 80, 65, 50, 180,-180);
        }
    }
}
