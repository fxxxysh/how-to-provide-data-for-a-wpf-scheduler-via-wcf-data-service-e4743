using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WpfApplication1.CarsModelService1;
using System.Data.Services.Client;
using System.Windows.Input;
using DevExpress.Xpf.Core.Commands;

namespace WpfApplication1.ViewModel
{
    public class MainWindowViewModel
    {
        CarsModelEntities context;

        public DataServiceCollection<CarScheduling> Appointments { get; private set; }
        public DataServiceCollection<Car> Resources { get; private set; }
        public DateTime? StartDate { get; set; }
        public ICommand SaveChangesCommand { get; private set; }

        public MainWindowViewModel() {
            InitViewModel();
        }

        private void InitViewModel()
        {
            context = new CarsModelEntities(new Uri("http://localhost:52731/CarsModelService.svc"));
            Appointments = new DataServiceCollection<CarScheduling>(context.CarSchedulings);
            Resources = new DataServiceCollection<Car>(context.Cars);
            StartDate = Appointments[0].StartTime;
            SaveChangesCommand = new DelegateCommand<object>((arg) => { context.SaveChanges(); });
        }
    }
}
