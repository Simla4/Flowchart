using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowChart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Control activeControl;
        private Point previousPosition;
        

        private void temizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
        }
        public void Control()
        {
            var myControl = new Panel();
            myControl.Location = new Point(30, 50);
            myControl.Size = new Size(55, 10);
            myControl.BackColor = Color.DodgerBlue;

            myControl.MouseClick += MyControl_Click;
            myControl.MouseDown += new MouseEventHandler(MyControl_MouseDown);
            myControl.MouseMove += new MouseEventHandler(MyControl_MouseMove);
            myControl.MouseUp += new MouseEventHandler(MyControl_MouseUp);

            panel1.Controls.Add(myControl);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Control();
            
        }
        private void MyControl_MouseUp(object sender, MouseEventArgs e)
        {
            ActiveControl = null;
            Cursor = Cursors.Default;
        }

        private void MyControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (activeControl == null || activeControl != sender)
            {
                return;
            }
            var location = activeControl.Location;

            location.Offset(e.Location.X - previousPosition.X, e.Location.Y - previousPosition.Y);
            activeControl.Location = location;
        }

        private void MyControl_MouseDown(object sender, MouseEventArgs e)
        {
            activeControl = sender as Control;
            previousPosition = e.Location;
            Cursor = Cursors.Hand;
        }
        private void MyControl_Click(object sender, MouseEventArgs e)
        {
            MessageBox.Show("MessageBox çalıştı");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Control();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Control();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Control();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Control();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Control();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Control();
        }
    }
}
