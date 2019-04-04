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
using Data.Models;


namespace Display
{
    public partial class CarEditView : Form
    {
        private int editId = 0;

        public CarEditView()
        {
            InitializeComponent();
            this.Load += new EventHandler(CarEditView_Load);
        }

        private void CarEditView_Load(object sender, EventArgs e)
        {
            dataGridView.ReadOnly = true;
            SetupDataGridView();
            PopulateDataGridViewDefault();
        }

        private void DisableSelect()
        {
            dataGridView.Enabled = false;
        }

        private void ResetSelect()
        {
            dataGridView.ClearSelection();
            dataGridView.Enabled = true;
        }

        private void ToggleSaveUpdate()
        {
            if (btnUpdate.Visible)
            {
                btnSave.Visible = true;
                btnUpdate.Visible = false;
            }
            else
            {
                btnSave.Visible = false;
                btnUpdate.Visible = true;
            }
        }

        private void ClearTextBoxes()
        {
            txtDealership.Text = "";
            txtEngine.Text = "";
            txtGears.Text = "";
            txtManufacturer.Text = "";
            txtModel.Text = "";
            txtOwner.Text = "";
            txtPrice.Text = "";
            txtTransmission.Text = "";
            txtColor.Text = "";
        }

        private void PopulateDataGridViewDefault()
        {
            CarBusiness carBusiness = new CarBusiness();
            dataGridView.Rows.Clear();
            var carBusinessList = carBusiness.GetAllCars();
            foreach (var car in carBusinessList)
            {
                string[] row =
                {
                    car.Manufacturer,
                    car.Model,
                    //car.CarDealership.Name,
                    car.CarDealershipId.ToString(),
                    car.EngineId.ToString(),
                    car.TransmissionType,
                    car.TransmissionGears.ToString(),
                    car.Color,
                    car.Price.ToString() + " лв.",
                    car.OwnerId.ToString(),
                    car.Id.ToString()
                };
                dataGridView.Rows.Add(row);
                
            }
            //dataGridView.Columns[9].Visible = false;
            //dataGridView1.Columns[0].DisplayIndex = 3;
        }

        private void SetupDataGridView()
        {
            //  this.Controls.Add(dataGridView1);

            dataGridView.ColumnCount = 10;

            dataGridView.Columns[0].Name = "Manufacturer";
            dataGridView.Columns[1].Name = "Model";
            dataGridView.Columns[2].Name = "Dealership";
            dataGridView.Columns[3].Name = "Engine";
            dataGridView.Columns[4].Name = "Transmission";
            dataGridView.Columns[5].Name = "Gears";
            dataGridView.Columns[6].Name = "Color";
            dataGridView.Columns[7].Name = "Price";
            dataGridView.Columns[8].Name = "Owner";
            dataGridView.Columns[9].Name = "ID";

            //dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            //dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            //dataGridView1.ColumnHeadersDefaultCellStyle.Font =
            //new Font(dataGridView1.Font, FontStyle.Bold);
            dataGridView.AutoSizeRowsMode =
            DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dataGridView.ColumnHeadersBorderStyle =
            DataGridViewHeaderBorderStyle.Single;
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            //dataGridView1.GridColor = Color.Black;
            dataGridView.RowHeadersVisible = false;



            dataGridView.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dataGridView.MultiSelect = false;
            // dataGridView1.Dock = DockStyle.Fill;
        }

        private void cbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbSort.SelectedIndex;
            /*switch (index)
            {
                case 0: SetupDataGridView(); PopulateDataGridView2(); break;
                case 1: SetupDataGridView(); PopulateDataGridView3(); break;
            }*/
        }

        private void UpdateTextBoxes(int Id)
        {
            CarDealershipBusiness carDealershipBusiness = new CarDealershipBusiness();
            CarDealership carDealership = carDealershipBusiness.GetCarDealershipById(Id);
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            SetupDataGridView();
            PopulateDataGridViewDefault();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Car car = new Car();
            car.Color = txtColor.Text;
            car.Manufacturer = txtManufacturer.Text;
            car.Model = txtModel.Text;
            decimal.TryParse(txtPrice.Text, out decimal price);
            car.Price = price;
            int.TryParse(txtGears.Text, out int gears);
            car.TransmissionGears = gears;
            car.TransmissionType = txtTransmission.Text;
            int.TryParse(txtEngine.Text, out int engineId);
            car.EngineId = engineId;
            int.TryParse(txtDealership.Text, out int dealershipId);
            car.CarDealershipId = dealershipId;
            int.TryParse(txtOwner.Text, out int ownerId);
            car.OwnerId = ownerId;

            CarBusiness carBusiness = new CarBusiness();
            carBusiness.Add(car);
            PopulateDataGridViewDefault();
            ClearTextBoxes();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnOpenHelper_Click(object sender, EventArgs e)
        {
            GridInfoPopUp gridInfoPopUp = new GridInfoPopUp();
            gridInfoPopUp.Show();
        }
    }
}
