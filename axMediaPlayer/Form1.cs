using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace axMediaPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e){

                    axWindowsMediaPlayer1.URL = "http://95.173.188.166:9984";      
                /* or axWindowsMediaPlayer.URL = "C:\\Users\\user\\Desktop\\ooo.mp3" */
        }
    }
}
