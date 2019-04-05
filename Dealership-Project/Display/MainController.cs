using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
using Data;

namespace Display
{
    public partial class MainController : Form
    {
        public MainController()
        {
            InitializeComponent();
        }

        private void MainController_Load(object sender, EventArgs e)
        {

        }

        private void btnCars_Click(object sender, EventArgs e)
        {
            CarEditView carEditView = new CarEditView();
            carEditView.ShowDialog();
        }

        private void btnDealerships_Click(object sender, EventArgs e)
        {
            CarDealershipEditView carDealershipEditView = new CarDealershipEditView();
            carDealershipEditView.ShowDialog();
        }

        private void btnEngines_Click(object sender, EventArgs e)
        {
            EngineEditView engineEditView = new EngineEditView();
            engineEditView.ShowDialog();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            CustomerEditView customerEditView = new CustomerEditView();
            customerEditView.ShowDialog();
        }

        private void btnWorkers_Click(object sender, EventArgs e)
        {
            WorkerEditView workerEditView = new WorkerEditView();
            workerEditView.ShowDialog();
        }

        private void btnTowns_Click(object sender, EventArgs e)
        {
            TownEditView townEditView = new TownEditView();
            townEditView.ShowDialog();
        }
    }
}
