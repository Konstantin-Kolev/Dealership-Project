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

namespace Display
{
    public partial class CarEditView : Form
    {
        public CarEditView()
        {
            InitializeComponent();
        }

        private void dataGridCars_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UpdateGrid()
        {
            CarBusiness carBusiness = new CarBusiness();
            dataGridCars.DataSource = carBusiness.GetAllCars();
            dataGridCars.ReadOnly = true;
            dataGridCars.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
}
