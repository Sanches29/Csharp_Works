using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio4
{
    public partial class Form1 : Form
    {
        bool startPaint = false;
        Graphics g;
        int? initX = null; //int? is shorthand for Nullable<int>.
        int? initY = null;

        public Form1()
        {
            InitializeComponent();
            g = pnlPainel.CreateGraphics();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                btnCor.BackColor = colorDialog1.Color;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            g.Clear(pnlPainel.BackColor);
            pnlPainel.BackColor = Color.White;
        }

        private void pnlPainel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlPainel_MouseMove(object sender, MouseEventArgs e)
        {
            if (startPaint)
            {
                //Setting the Pen BackColor
                Pen p = new Pen(btnCor.BackColor);
                //Drawing the line.
                g.DrawLine(p, new Point(initX ?? e.X, initY ?? e.Y), new Point(e.X, e.Y));
                initX = e.X;
                initY = e.Y;
            }
        }

        private void pnlPainel_MouseDown(object sender, MouseEventArgs e)
        {
            startPaint = true;
        }

        private void pnlPainel_MouseUp(object sender, MouseEventArgs e)
        {
            startPaint = false;
            initX = null;
            initY = null;
        }
    }
}
