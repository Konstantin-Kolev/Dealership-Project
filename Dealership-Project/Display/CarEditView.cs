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

        
        private void PopulateDataGridViewDefault()
        {
            dataGridView.Rows.Clear();
            CarBusiness carBusiness = new CarBusiness();
            var carsList = carBusiness.GetAllCars();
            DataPopulator(carsList);
            dataGridView.Columns[9].Visible = false;
            //dataGridView1.Columns[0].DisplayIndex = 3;
        }

        private void SetupDataGridView()
        {
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

            dataGridView.AutoSizeRowsMode =
            DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dataGridView.ColumnHeadersBorderStyle =
            DataGridViewHeaderBorderStyle.Single;
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridView.RowHeadersVisible = false;
            dataGridView.SelectionMode =
            DataGridViewSelectionMode.FullRowSelect;
            dataGridView.MultiSelect = false;
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
        //Buttons + attached logic//
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
            if (txtOwner.Text != "")
            {
                int.TryParse(txtOwner.Text, out int ownerId);
                car.OwnerId = ownerId;
            }

            CarBusiness carBusiness = new CarBusiness();
            carBusiness.Add(car);
            PopulateDataGridViewDefault();
            ClearTextBoxes();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                var car = dataGridView.SelectedRows[0].Cells;
                var carId = int.Parse(car[9].Value.ToString());
                editId = carId;
                UpdateTextBoxes(carId);
                ToggleSaveUpdate();
                DisableSelect();
            }
        }

        private void UpdateTextBoxes(int Id)
        {
            CarBusiness carBusiness = new CarBusiness();
            Car car = carBusiness.GetCarById(Id);
            txtColor.Text = car.Color;
            txtDealership.Text = car.CarDealershipId.ToString();
            txtEngine.Text = car.EngineId.ToString();
            txtGears.Text = car.TransmissionGears.ToString();
            txtManufacturer.Text = car.Manufacturer;
            txtModel.Text = car.Model;
            txtOwner.Text = car.OwnerId.ToString();
            txtPrice.Text = car.Price.ToString();
            txtTransmission.Text = car.TransmissionType;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Car car = GetEditedCar();
            CarBusiness carBusiness = new CarBusiness();
            carBusiness.Update(car);
            PopulateDataGridViewDefault();
            ResetSelect();
            ToggleSaveUpdate();
            ClearTextBoxes();
        }

        private Car GetEditedCar()
        {
            Car car = new Car();

            car.Id = editId;
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

            return car;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                var car = dataGridView.SelectedRows[0].Cells;
                var carId = int.Parse(car[9].Value.ToString());
                CarBusiness carBusiness = new CarBusiness();
                carBusiness.Delete(carId);
                PopulateDataGridViewDefault();
                ResetSelect();
            }
        }

        private void btnOpenHelper_Click(object sender, EventArgs e)
        {
            GridInfoPopUp gridInfoPopUp = new GridInfoPopUp();
            gridInfoPopUp.Show();
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            SetupDataGridView();
            PopulateDataGridViewDefault();
        }
        //Buttons + attached logic//

        //Data populators//
        private void DataPopulator(List<Car> cars)
        {
            foreach (var car in cars)
            {
                CarBusiness carBusiness = new CarBusiness();
                string[] row =
                {
                    car.Manufacturer,
                    car.Model,
                    carBusiness.GetDealershipName(car.CarDealershipId),
                    carBusiness.GetEngineName(car.EngineId),
                    car.TransmissionType,
                    car.TransmissionGears.ToString(),
                    car.Color,
                    car.Price.ToString() + " лв.",
                    carBusiness.GetOwnerName(car.OwnerId),
                    car.Id.ToString()
                };
                dataGridView.Rows.Add(row);
            }
        }

        private void DataPopulatorSingle(Car car)
        {
            CarBusiness carBusiness = new CarBusiness();
            string[] row =
            {
                    car.Manufacturer,
                    car.Model,
                    carBusiness.GetDealershipName(car.CarDealershipId),
                    carBusiness.GetEngineName(car.EngineId),
                    car.TransmissionType,
                    car.TransmissionGears.ToString(),
                    car.Color,
                    car.Price.ToString() + " лв.",
                    carBusiness.GetOwnerName(car.OwnerId),
                    car.Id.ToString()
                };
            dataGridView.Rows.Add(row);
        }
        //Data populators//

        //FormatLogic
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
        //Formatlogic//
    }
}
