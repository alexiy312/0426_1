using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0426_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text="1日1回勝負";
            MessageBox.Show("YOU LOSE\nなんで負けたか明日までに考えといてください\nそしたら何かが見えてくるはずです\nほな、頂きます");
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.Aqua;
            button2.Text = "(;O;)";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Location = new Point(1, 1);
            button3.Size = new Size(2, 2);
            MessageBox.Show("どこでしょうか？\nウィンドウ上にちゃんといます！");
        }
    }
}
