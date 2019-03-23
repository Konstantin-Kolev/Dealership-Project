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
        private CarBusiness carBusiness = new CarBusiness();

        public CarEditView()
        {
            InitializeComponent();
        }

        private void dataGridCars_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UpdateGrid()
        {
            dataGridCars.DataSource = carBusiness.GetAllCars();
            dataGridCars.ReadOnly = true;
            dataGridCars.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void TEST_Click(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

            UpdateGrid();
        }

        private void CarEditView_Load(object sender, EventArgs e)
        {

        }
    }
}
