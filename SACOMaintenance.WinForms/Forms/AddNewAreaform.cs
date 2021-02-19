using SACOMaintenance.DataAccess;
using SACOMaintenance.ViewModel;
using SACOMaintenance.WinForms.Toasts;
using System;
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
            _viewModel = new AreaViewModel(new AreaProvider(), new FactoryDataProvider());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _viewModel.newArea.AreaName = txtAreaNameAdd.Text;
            _viewModel.newArea.CommentsNotes = txtAreaComments.Text;
            _viewModel.newArea.FactoryId = (int)cboFactory.SelectedValue;
            _viewModel.AddNewArea(_viewModel.newArea); //txtAreaNameAdd.Text);

            if(_viewModel.AreaExists == false)
            {
                AreaSaved();
                AddedToDatabaseToastSuccess addedDbSuccessToast = new AddedToDatabaseToastSuccess();
                addedDbSuccessToast.Show();
            }
            else
            {               
                AddedToDatabaseToastFail addedToDatabaseFailToast = new AddedToDatabaseToastFail();
                addedToDatabaseFailToast.Show();                
            }

            
        }

        private void AddNewAreaform_Load(object sender, EventArgs e)
        {
            _viewModel.Load();

            cboFactory.DataSource = _viewModel.factories;
            cboFactory.DisplayMember = "FactoryName";
            cboFactory.ValueMember = "Id";
        }
    }
}
