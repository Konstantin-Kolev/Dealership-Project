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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CarBusiness carBusiness = new CarBusiness();
            //ba4ka ama iska izdokusorqvane//
            var manufacturer = txtManufacturer.Text;
            var model = txtModel.Text;
            var engine = 2;
            var carDealershipId = 3;



            var transmissionType = "Automatic";
            var transmissionGears = 5;
            var color = "Green";
            decimal price = 4000;


            Car car = new Car();
            car.CarDealershipId = carDealershipId;
            car.Color = color;
            car.EngineId = engine;
            car.Manufacturer = manufacturer;
            car.Model = txtModel.Text;
            car.Price = price;
            car.TransmissionGears = transmissionGears;
            car.TransmissionType = transmissionType;
            //carBusiness.Add(car);
            //PopulateDataGridView();
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            SetupDataGridView();
            PopulateDataGridViewDefault();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                var item = dataGridView.SelectedRows[0].Cells;
                var id = int.Parse(item[0].Value.ToString());
                editId = id;
                UpdateTextboxes(id);
                ToggleSaveUpdate();
                DisableSelect();
            }
        }

        private void UpdateTextboxes(int id)
        {
            CarBusiness carBusiness = new CarBusiness();
            Car update = carBusiness.GetCarById(id);
            //dovarwi//
        }

        private Car GetEditedCar()
        {
            Car car = new Car();
            car.Id = editId;

            var model = txtModel.Text;
            decimal price = 0;
            decimal.TryParse(txtPrice.Text, out price);
            int gears = 0;
            int.TryParse(txtGears.Text, out gears);
            car.Model = model;
            car.Price = price;
            car.TransmissionGears = gears;

            return car;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Car editedCar = GetEditedCar();
            CarBusiness carBusiness = new CarBusiness();
            carBusiness.Update(editedCar);
            PopulateDataGridViewDefault();
            ResetSelect();
            ToggleSaveUpdate();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                var item = dataGridView.SelectedRows[0].Cells;
                var id = int.Parse(item[0].Value.ToString());
                CarBusiness carBusiness = new CarBusiness();
                carBusiness.Delete(id);
                PopulateDataGridViewDefault();
                ResetSelect();
            }
        }

        private void btnOpenHelper_Click(object sender, EventArgs e)
        {
            GridInfoPopUp gridInfoPopUp = new GridInfoPopUp();
            gridInfoPopUp.Show();
        }
    }
}
