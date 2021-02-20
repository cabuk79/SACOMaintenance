using SACOMaintenance.DataAccess;
using SACOMaintenance.ViewModel;
using SACOMaintenance.WinForms.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;


namespace SACOMaintenance.WinForms
{
    public partial class MainForm : Form
    {
        private readonly RequestsViewModel _viewModel;

        public MainForm()
        {
            InitializeComponent();
            _viewModel = new RequestsViewModel(new MaintRequestInitiationDataProvider());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _viewModel.Load();           
        }

        private void btnAreasForm_Click(object sender, EventArgs e)
        {
            AreaForm areaForm = new AreaForm();
            areaForm.Show();
        }
    }
}
