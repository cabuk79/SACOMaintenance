using SACOMaintenance.DataAccess;
using SACOMaintenance.ViewModel;
using SACOMaintenance.WinForms.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace SACOMaintenance.WinForms
{
    public partial class MainForm : Form
    {
        //private readonly AreaViewModel _viewModel;

        public MainForm()
        {
            InitializeComponent();
            //_viewModel = new AreaViewModel(new AreaProvider());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //_viewModel.Load();
            //areaBindingSource.DataSource = _viewModel.areas;

            //dgvAreasDataGrid.AutoGenerateColumns = false;
            //dgvAreasDataGrid.DataSource = areaBindingSource;           
            //DataGridViewColumn nameCol = new DataGridViewTextBoxColumn();
            //nameCol.DataPropertyName = "AreaName";
            //nameCol.HeaderText = "Name";
            //nameCol.Name = "areaName";
            //dgvAreasDataGrid.Columns.Add(nameCol);
        }

        private void btnAreasForm_Click(object sender, EventArgs e)
        {
            AreaForm areaForm = new AreaForm();
            areaForm.Show();
        }
    }
}
