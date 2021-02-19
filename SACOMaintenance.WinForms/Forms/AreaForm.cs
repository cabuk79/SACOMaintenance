using System.Windows.Forms;
using SACOMaintenance.BuisnessModels;
using SACOMaintenance.DataAccess;
using SACOMaintenance.ViewModel;

namespace SACOMaintenance.WinForms.Forms
{
    public partial class AreaForm : Form
    {
        private readonly AreaViewModel _viewModel;

        public AreaForm()
        {
            InitializeComponent();
            _viewModel = new AreaViewModel(new AreaProvider(), new FactoryDataProvider());
        }

        private void AreaForm_Load(object sender, System.EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            _viewModel.Load();

            areasBindingSource.DataSource = _viewModel.areas; //set the view model data source

            //set the areas list box
            lbAreaListNav.DataSource = areasBindingSource;
            lbAreaListNav.DisplayMember = "AreaName";
            lbAreaListNav.ValueMember = "Id";

            areasBindingSource.ResetBindings(false);

            //set the controls to the binding source
            txtAreaName.DataBindings.Add("Text", areasBindingSource, "AreaName", false, DataSourceUpdateMode.OnPropertyChanged);
            txtAreaComments.DataBindings.Add("Text", areasBindingSource, "CommentsNotes", false, DataSourceUpdateMode.OnPropertyChanged);

            cboFactory.DataSource = _viewModel.factories;
            cboFactory.DisplayMember = "FactoryName";
            cboFactory.ValueMember = "Id";
            cboFactory.DataBindings.Add("SelectedValue", areasBindingSource, "FactoryId");
        }

        public void ReLoadList()
        {
            _viewModel.Load();

            areasBindingSource.DataSource = _viewModel.areas; //set the view model data source

            //set the areas list box
            lbAreaListNav.DataSource = areasBindingSource;
            lbAreaListNav.DisplayMember = "AreaName";
            lbAreaListNav.ValueMember = "Id";

            areasBindingSource.ResetBindings(false);
        }

        private void btnSaveArea_Click(object sender, System.EventArgs e)
        {
            if(areasBindingSource.Current is Area areaChosen)
            {
                _viewModel.SaveArea(areaChosen);
            }
        }

        private void btnNewArea_Click(object sender, System.EventArgs e)
        {
            AddNewAreaform addNewAreaForm = new AddNewAreaform();
            addNewAreaForm.AreaSaved += NewAreaSaved;
            addNewAreaForm.Show();
        }

        private void NewAreaSaved()
        {
            ReLoadList();
        }
    }
}
