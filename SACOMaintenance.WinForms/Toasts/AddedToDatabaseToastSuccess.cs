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
    public partial class AddedToDatabaseToastSuccess : Form
    {
        private int currentTickTotal = 0;
        public AddedToDatabaseToastSuccess()
        {
            InitializeComponent();
            showToastTimer.Start();
        }

        private void showToastTimer_Tick(object sender, EventArgs e)
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
