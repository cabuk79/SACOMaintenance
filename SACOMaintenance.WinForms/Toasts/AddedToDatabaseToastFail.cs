using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SACOMaintenance.WinForms.Toasts
{
    public partial class AddedToDatabaseToastFail : Form
    {
        private int currentTickTotal = 0;
        public AddedToDatabaseToastFail()
        {
            InitializeComponent();
            timerTickFail.Start();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timerTickFail_Tick(object sender, EventArgs e)
        {
            if(currentTickTotal == 2)
            {
                this.Close();
            }
            else
            {
                currentTickTotal++;
            }
        }
    }
}
