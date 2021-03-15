using SACOMaintenance.Common.ModelDB;
using SACOMaintenance.DataAccess.Interfaces;
using SACOMaintenance.ViewModel.Interfaces;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SACOMaintenance.ViewModel
{
    public class MaintRequestFullViewModel : INotifyPropertyChanged, IMaintRequestFullViewModel
    {
        public MaintRequestInitiation maintReqInitation { get; set; } = new();

        public IMaintRequestInitiation MaintReqDataProvider { get; }

        public MaintRequestFullViewModel(IMaintRequestInitiation maintReqInitProvider)
        {
            MaintReqDataProvider = maintReqInitProvider;
        }

        public int maintReqId
        {
            get => maintReqInitation.Id;
            set
            {
                if(maintReqInitation.Id != value)
                {
                    maintReqInitation.Id = value;
                    RaisePropertychangedEvent();
                }
            }
        }

        public string maintReqDetails
        {
            get => maintReqInitation.RequestDetails;
            set
            {
                if(maintReqInitation.RequestDetails != value)
                {
                    maintReqInitation.RequestDetails = value;
                    RaisePropertychangedEvent();
                }
            }
        }

        public int? maintReqAreaId
        {
            get => maintReqInitation.AreaId;
            set
            {
                if(maintReqInitation.AreaId != value)
                {
                    maintReqInitation.Area.Id = (int)value;
                    RaisePropertychangedEvent();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertychangedEvent([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        MaintRequestInitiation IMaintRequestFullViewModel.GetMaintReqInitation(int maintReqId)
        {
            maintReqInitation = MaintReqDataProvider.GetSingleRequestInitiation(maintReqId);
            return maintReqInitation;
        }
    }
}
