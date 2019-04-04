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
            dataGridView.Columns[9].Visible = false;
            PopulateDataGridViewDefault();
        }

        //Main logic//
        //Get logic//
        private void PopulateDataGridViewDefault()
        {
            dataGridView.Rows.Clear();
            CarBusiness carBusiness = new CarBusiness();
            var carsList = carBusiness.GetAllCars();
            DataPopulator(carsList);
            //dataGridView1.Columns[0].DisplayIndex = 3;
        }

        private void PopulateDataGridViewGetCarById()
        {
            dataGridView.Rows.Clear();
            CarBusiness carBusiness = new CarBusiness();
            int.TryParse(txtGet.Text, out int carId);
            var cars = carBusiness.GetCarById(carId);
            DataPopulatorSingle(cars);
        }

        private void PopulateDataGridViewGetCarsByCarDealership()
        {
            dataGridView.Rows.Clear();
            CarBusiness carBusiness = new CarBusiness();
            int.TryParse(txtGet.Text, out int carDealershipId);
            var carsList = carBusiness.GetCarsByCarDealership(carDealershipId);
            DataPopulator(carsList);
        }

        private void PopulateDataGridViewGetCarsByColor()
        {
            dataGridView.Rows.Clear();
            CarBusiness carBusiness = new CarBusiness();
            var carsList = carBusiness.GetCarsByColor(txtGet.Text);
            DataPopulator(carsList);
        }

        private void PopulateDataGridViewGetCarsByDisplacement()
        {
            dataGridView.Rows.Clear();
            CarBusiness carBusiness = new CarBusiness();
            int.TryParse(txtGet.Text, out int displacement);
            var carsList = carBusiness.GetCarsByDisplacement(displacement);
            DataPopulator(carsList);
        }

        private void PopulateDataGridViewGetCarsByFuelType()
        {
            dataGridView.Rows.Clear();
            CarBusiness carBusiness = new CarBusiness();
            var carsList = carBusiness.GetCarsByFuelType(txtGet.Text);
            DataPopulator(carsList);
        }

        private void PopulateDataGridViewGetCarsByManufacturer()
        {
            dataGridView.Rows.Clear();
            CarBusiness carBusiness = new CarBusiness();
            var carsList = carBusiness.GetCarsByManufacturer(txtGet.Text);
            DataPopulator(carsList);
        }

        private void PopulateDataGridViewGetCarsByModel()
        {
            dataGridView.Rows.Clear();
            CarBusiness carBusiness = new CarBusiness();
            var carsList = carBusiness.GetCarsByModel(txtGet.Text);
            DataPopulator(carsList);
        }

        private void PopulateDataGridViewGetCarsByPower()
        {
            dataGridView.Rows.Clear();
            CarBusiness carBusiness = new CarBusiness();
            int.TryParse(txtGet.Text, out int power);
            var carsList = carBusiness.GetCarsByPower(power);
            DataPopulator(carsList);
        }

        private void PopulateDataGridViewGetCarsByPrice()
        {
            dataGridView.Rows.Clear();
            CarBusiness carBusiness = new CarBusiness();
            int.TryParse(txtGet.Text, out int price);
            var carsList = carBusiness.GetCarsByPrice(price);
            DataPopulator(carsList);
        }

        private void PopulateDataGridViewGetCarsByTransmissionType()
        {
            dataGridView.Rows.Clear();
            CarBusiness carBusiness = new CarBusiness();
            var carsList = carBusiness.GetCarsByTransmissionType(txtGet.Text);
            DataPopulator(carsList);
        }

        private void PopulateDataGridViewGetCarsForSale()
        {
            dataGridView.Rows.Clear();
            CarBusiness carBusiness = new CarBusiness();
            var carsList = carBusiness.GetCarsForSale();
            DataPopulator(carsList);
        }

        private void PopulateDataGridViewGetCarsOverPrice()
        {
            dataGridView.Rows.Clear();
            CarBusiness carBusiness = new CarBusiness();
            int.TryParse(txtGet.Text, out int price);
            var carsList = carBusiness.GetCarsOverPrice(price);
            DataPopulator(carsList);
        }

        private void PopulateDataGridViewGetCarsTransmissionGears()
        {
            dataGridView.Rows.Clear();
            CarBusiness carBusiness = new CarBusiness();
            int.TryParse(txtGet.Text, out int gears);
            var carsList = carBusiness.GetCarsTransmissionGears(gears);
            DataPopulator(carsList);
        }

        private void PopulateDataGridViewGetCarsUnderPrice()
        {
            dataGridView.Rows.Clear();
            CarBusiness carBusiness = new CarBusiness();
            int.TryParse(txtGet.Text, out int price);
            var carsList = carBusiness.GetCarsUnderPrice(price);
            DataPopulator(carsList);
        }

        private void PopulateDataGridViewGetOwnedCars()
        {
            dataGridView.Rows.Clear();
            CarBusiness carBusiness = new CarBusiness();
            var carsList = carBusiness.GetOwnedCars();
            DataPopulator(carsList);
        }
        //Get logic//

        //Sort logic//
        private void PopulateDataGridViewSortCarsByDealershipNameAscending()
        {
            dataGridView.Rows.Clear();
            CarBusiness carBusiness = new CarBusiness();
            var carsList = carBusiness.SortCarsByDealershipNameAscending();
            DataPopulator(carsList);
        }

        private void PopulateDataGridViewSortCarsByDealershipNameDescending()
        {
            dataGridView.Rows.Clear();
            CarBusiness carBusiness = new CarBusiness();
            var carsList = carBusiness.SortCarsByDealershipNameDescending();
            DataPopulator(carsList);
        }

        private void PopulateDataGridViewSortCarsByTransmissionGearsAscending()
        {
            dataGridView.Rows.Clear();
            CarBusiness carBusiness = new CarBusiness();
            var carsList = carBusiness.SortCarsByTransmissionGearsAscending();
            DataPopulator(carsList);
        }

        private void PopulateDataGridViewSortCarsByTransmissionGearsDescending()
        {
            dataGridView.Rows.Clear();
            CarBusiness carBusiness = new CarBusiness();
            var carsList = carBusiness.SortCarsByTransmissionGearsDescending();
            DataPopulator(carsList);
        }

        private void PopulateDataGridViewSortCarsByManufacturerAndModelAscending()
        {
            dataGridView.Rows.Clear();
            CarBusiness carBusiness = new CarBusiness();
            var carsList = carBusiness.SortCarsByManufacturerAndModelAscending();
            DataPopulator(carsList);
        }

        private void PopulateDataGridViewSortCarsByManufacturerAndModelDescending()
        {
            dataGridView.Rows.Clear();
            CarBusiness carBusiness = new CarBusiness();
            var carsList = carBusiness.SortCarsByManufacturerAndModelDescending();
            DataPopulator(carsList);
        }

        private void PopulateDataGridViewSortCarsByPowerAscending()
        {
            dataGridView.Rows.Clear();
            CarBusiness carBusiness = new CarBusiness();
            var carsList = carBusiness.SortCarsByPowerAscending();
            DataPopulator(carsList);
        }

        private void PopulateDataGridViewSortCarsByPowerDescending()
        {
            dataGridView.Rows.Clear();
            CarBusiness carBusiness = new CarBusiness();
            var carsList = carBusiness.SortCarsByPowerDescending();
            DataPopulator(carsList);
        }

        private void PopulateDataGridViewSortCarsByFuelEconomyAscending()
        {
            dataGridView.Rows.Clear();
            CarBusiness carBusiness = new CarBusiness();
            var carsList = carBusiness.SortCarsByFuelEconomyAscending();
            DataPopulator(carsList);
        }

        private void PopulateDataGridViewSortCarsByFuelEconomyDescending()
        {
            dataGridView.Rows.Clear();
            CarBusiness carBusiness = new CarBusiness();
            var carsList = carBusiness.SortCarsByFuelEconomyDescending();
            DataPopulator(carsList);
        }

        private void PopulateDataGridViewSortCarsByDisplacementAscending()
        {
            dataGridView.Rows.Clear();
            CarBusiness carBusiness = new CarBusiness();
            var carsList = carBusiness.SortCarsByDisplacementAscending();
            DataPopulator(carsList);
        }

        private void PopulateDataGridViewSortCarsByDisplacementDescending()
        {
            dataGridView.Rows.Clear();
            CarBusiness carBusiness = new CarBusiness();
            var carsList = carBusiness.SortCarsByDisplacementDescending();
            DataPopulator(carsList);
        }

        private void PopulateDataGridViewSortCarsByPriceAscending()
        {
            dataGridView.Rows.Clear();
            CarBusiness carBusiness = new CarBusiness();
            var carsList = carBusiness.SortCarsByPriceAscending();
            DataPopulator(carsList);
        }

        private void PopulateDataGridViewSortCarsByPriceDescending()
        {
            dataGridView.Rows.Clear();
            CarBusiness carBusiness = new CarBusiness();
            var carsList = carBusiness.SortCarsByPriceDescending();
            DataPopulator(carsList);
        }

        private void PopulateDataGridViewSortCarsByFuelType()
        {
            dataGridView.Rows.Clear();
            CarBusiness carBusiness = new CarBusiness();
            var carsList = carBusiness.SortCarsByFuelType();
            DataPopulator(carsList);
        }

        private void PopulateDataGridViewSortCarsByTransmissionType()
        {
            dataGridView.Rows.Clear();
            CarBusiness carBusiness = new CarBusiness();
            var carsList = carBusiness.SortCarsByTransmissionType();
            DataPopulator(carsList);
        }

        private void PopulateDataGridViewSortCarsByColor()
        {
            dataGridView.Rows.Clear();
            CarBusiness carBusiness = new CarBusiness();
            var carsList = carBusiness.SortCarsByColor();
            DataPopulator(carsList);
        }
        //Sort logic//
        //Main logic//

        //cbGet and cbSort//
        private void cbGet_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbGet.SelectedIndex;
            switch (index)
            {
                case 0: SetupDataGridView(); PopulateDataGridViewGetCarById(); break;
                case 1: SetupDataGridView(); PopulateDataGridViewGetCarsByManufacturer(); break;
                case 2: SetupDataGridView(); PopulateDataGridViewGetCarsByModel(); break;
                case 3: SetupDataGridView(); PopulateDataGridViewGetCarsByCarDealership(); break;
                case 4: SetupDataGridView(); PopulateDataGridViewGetCarsByFuelType(); break;
                case 5: SetupDataGridView(); PopulateDataGridViewGetCarsByPower(); break;
                case 6: SetupDataGridView(); PopulateDataGridViewGetCarsByDisplacement(); break;
                case 7: SetupDataGridView(); PopulateDataGridViewGetCarsByFuelType(); break;
                case 8: SetupDataGridView(); PopulateDataGridViewGetCarsTransmissionGears(); break;
                case 9: SetupDataGridView(); PopulateDataGridViewGetCarsByColor(); break;
                case 10: SetupDataGridView(); PopulateDataGridViewGetCarsByPrice(); break;
                case 11: SetupDataGridView(); PopulateDataGridViewGetCarsUnderPrice(); break;
                case 12: SetupDataGridView(); PopulateDataGridViewGetCarsOverPrice(); break;
                case 13: SetupDataGridView(); PopulateDataGridViewGetCarsForSale(); break;
                case 14: SetupDataGridView(); PopulateDataGridViewGetOwnedCars(); break;
            }
        }

        private void cbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbSort.SelectedIndex;
            switch (index)
            {
                case 0: SetupDataGridView(); PopulateDataGridViewSortCarsByDealershipNameAscending(); break;
                case 1: SetupDataGridView(); PopulateDataGridViewSortCarsByDealershipNameDescending(); break;
                case 2: SetupDataGridView(); PopulateDataGridViewSortCarsByTransmissionGearsAscending(); break;
                case 3: SetupDataGridView(); PopulateDataGridViewSortCarsByTransmissionGearsDescending(); break;
                case 4: SetupDataGridView(); PopulateDataGridViewSortCarsByManufacturerAndModelAscending(); break;
                case 5: SetupDataGridView(); PopulateDataGridViewSortCarsByManufacturerAndModelDescending(); break;
                case 6: SetupDataGridView(); PopulateDataGridViewSortCarsByPowerAscending(); break;
                case 7: SetupDataGridView(); PopulateDataGridViewSortCarsByPowerDescending(); break;
                case 8: SetupDataGridView(); PopulateDataGridViewSortCarsByFuelEconomyAscending(); break;
                case 9: SetupDataGridView(); PopulateDataGridViewSortCarsByFuelEconomyDescending(); break;
                case 10: SetupDataGridView(); PopulateDataGridViewSortCarsByDisplacementAscending(); break;
                case 11: SetupDataGridView(); PopulateDataGridViewSortCarsByDisplacementDescending(); break;
                case 12: SetupDataGridView(); PopulateDataGridViewSortCarsByPriceAscending(); break;
                case 13: SetupDataGridView(); PopulateDataGridViewSortCarsByPriceDescending(); break;
                case 14: SetupDataGridView(); PopulateDataGridViewSortCarsByFuelType(); break;
                case 15: SetupDataGridView(); PopulateDataGridViewSortCarsByTransmissionType(); break;
                case 16: SetupDataGridView(); PopulateDataGridViewSortCarsByColor(); break;
            }
        }
        //cbGet and cbSort//

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
