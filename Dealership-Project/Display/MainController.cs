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
    }
}
