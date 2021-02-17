using SACOMaintenance.BuisnessModels;
using SACOMaintenance.DataAccess;
using SACOMaintenance.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SACOMaintenance.WinForms.Forms
{
    public partial class AddNewAreaform : Form
    {
        private readonly AreaViewModel _viewModel;

        public delegate void SaveEvent();
        public SaveEvent AreaSaved;

        public AddNewAreaform()
        {
            InitializeComponent();
            _viewModel = new AreaViewModel(new AreaProvider());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _viewModel.newArea.AreaName = txtAreaNameAdd.Text;
            _viewModel.AddNewArea();
            AreaSaved();
        }
    }
}
