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
        /// <summary>
        /// Variable used in 'Update' operation
        /// </summary>
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
            dataGridView.Columns[0].Visible = false;
            PopulateDataGridViewDefault();
        }

        //Main logic//
        //Get logic//

        /// <summary>
        /// Populate the data grid with information about all existing cars in the database
        /// </summary>
        private void PopulateDataGridViewDefault()
        {
            dataGridView.Rows.Clear(); HideSpecificInfo();
            CarBusiness carBusiness = new CarBusiness();
            var carsList = carBusiness.GetAllCars();
            DataPopulator(carsList);
            //dataGridView1.Columns[0].DisplayIndex = 3;
        }

        /// <summary>
        /// Populate the data grid with information about car with given car Id
        /// </summary>
        private void PopulateDataGridViewGetCarById()
        {
            dataGridView.Rows.Clear(); HideSpecificInfo();
            CarBusiness carBusiness = new CarBusiness();
            int.TryParse(txtGet.Text, out int carId);
            var cars = carBusiness.GetCarById(carId);
            DataPopulatorSingle(cars);
        }

        /// <summary>
        /// Populate the data grid with information about cars with given dealership Id
        /// </summary>
        private void PopulateDataGridViewGetCarsByCarDealership()
        {
            dataGridView.Rows.Clear(); HideSpecificInfo();
            CarBusiness carBusiness = new CarBusiness();
            int.TryParse(txtGet.Text, out int carDealershipId);
            var carsList = carBusiness.GetCarsByCarDealership(carDealershipId);
            DataPopulator(carsList);
        }

        /// <summary>
        /// Populate the data grid with information about cars with given color
        /// </summary>
        private void PopulateDataGridViewGetCarsByColor()
        {
            dataGridView.Rows.Clear(); HideSpecificInfo();
            CarBusiness carBusiness = new CarBusiness();
            var carsList = carBusiness.GetCarsByColor(txtGet.Text);
            DataPopulator(carsList);
        }

        /// <summary>
        /// Populate the data grid with information about cars with given displacement
        /// </summary>
        private void PopulateDataGridViewGetCarsByDisplacement()
        {
            dataGridView.Rows.Clear(); HideSpecificInfo();
            CarBusiness carBusiness = new CarBusiness();
            int.TryParse(txtGet.Text, out int displacement);
            var carsList = carBusiness.GetCarsByDisplacement(displacement);
            DataPopulator(carsList);
            dataGridView.Columns[6].Visible = true;
        }

        /// <summary>
        /// Populate the data grid with information about cars with displacement larger than given
        /// </summary>
        private void PopulateDataGridViewGetCarsWithHigherDisplacement()
        {
            dataGridView.Rows.Clear(); HideSpecificInfo();
            CarBusiness carBusiness = new CarBusiness();
            int.TryParse(txtGet.Text, out int displacement);
            var carsList = carBusiness.GetCarsWithHigherDisplacement(displacement);
            DataPopulator(carsList);
            dataGridView.Columns[6].Visible = true;
        }

        /// <summary>
        /// Populate the data grid with information about cars with displacement smaller than given
        /// </summary>
        private void PopulateDataGridViewGetCarsWithLowerDisplacement()
        {
            dataGridView.Rows.Clear(); HideSpecificInfo();
            CarBusiness carBusiness = new CarBusiness();
            int.TryParse(txtGet.Text, out int displacement);
            var carsList = carBusiness.GetCarsWithLowerDisplacement(displacement);
            DataPopulator(carsList);
            dataGridView.Columns[6].Visible = true;
        }

        /// <summary>
        /// Populate the data grid with information about cars with given fuel type
        /// </summary>
        private void PopulateDataGridViewGetCarsByFuelType()
        {
            dataGridView.Rows.Clear(); HideSpecificInfo();
            CarBusiness carBusiness = new CarBusiness();
            var carsList = carBusiness.GetCarsByFuelType(FuelBGTtoENG(txtGet.Text));
            DataPopulator(carsList);
            dataGridView.Columns[7].Visible = true;
        }

        /// <summary>
        /// Populate the data grid with information about cars with given manufacturer
        /// </summary>
        private void PopulateDataGridViewGetCarsByManufacturer()
        {
            dataGridView.Rows.Clear(); HideSpecificInfo();
            CarBusiness carBusiness = new CarBusiness();
            var carsList = carBusiness.GetCarsByManufacturer(txtGet.Text);
            DataPopulator(carsList);
        }

        /// <summary>
        /// Populate the data grid with information about cars with given model
        /// </summary>
        private void PopulateDataGridViewGetCarsByModel()
        {
            dataGridView.Rows.Clear(); HideSpecificInfo();
            CarBusiness carBusiness = new CarBusiness();
            var carsList = carBusiness.GetCarsByModel(txtGet.Text);
            DataPopulator(carsList);
        }

        /// <summary>
        /// Populate the data grid with information about cars with given power
        /// </summary>
        private void PopulateDataGridViewGetCarsByPower()
        {
            dataGridView.Rows.Clear(); HideSpecificInfo();
            CarBusiness carBusiness = new CarBusiness();
            int.TryParse(txtGet.Text, out int power);
            var carsList = carBusiness.GetCarsByPower(power);
            DataPopulator(carsList);
            dataGridView.Columns[5].Visible = true;
        }

        /// <summary>
        /// Populate the data grid with information about cars with power more than given
        /// </summary>
        private void PopulateDataGridViewGetCarsWithHigherPower()
        {
            dataGridView.Rows.Clear(); HideSpecificInfo();
            CarBusiness carBusiness = new CarBusiness();
            int.TryParse(txtGet.Text, out int power);
            var carsList = carBusiness.GetCarsWithHigherPower(power);
            DataPopulator(carsList);
            dataGridView.Columns[5].Visible = true;
        }

        /// <summary>
        /// Populate the data grid with information about cars with power less than given
        /// </summary>
        private void PopulateDataGridViewGetCarsWithLowerPower()
        {
            dataGridView.Rows.Clear(); HideSpecificInfo();
            CarBusiness carBusiness = new CarBusiness();
            int.TryParse(txtGet.Text, out int power);
            var carsList = carBusiness.GetCarsWithLowerPower(power);
            DataPopulator(carsList);
            dataGridView.Columns[5].Visible = true;
        }

        /// <summary>
        /// Populate the data grid with information about cars with given price
        /// </summary>
        private void PopulateDataGridViewGetCarsByPrice()
        {
            dataGridView.Rows.Clear(); HideSpecificInfo();
            CarBusiness carBusiness = new CarBusiness();
            int.TryParse(txtGet.Text, out int price);
            var carsList = carBusiness.GetCarsByPrice(price);
            DataPopulator(carsList);
        }

        /// <summary>
        /// Populate the data grid with information about cars with price higher than given
        /// </summary>
        private void PopulateDataGridViewGetCarsWithHigherPrice()
        {
            dataGridView.Rows.Clear(); HideSpecificInfo();
            CarBusiness carBusiness = new CarBusiness();
            int.TryParse(txtGet.Text, out int price);
            var carsList = carBusiness.GetCarsWithHigherPrice(price);
            DataPopulator(carsList);
        }

        /// <summary>
        /// Populate the data grid with information about cars with price lower than given
        /// </summary>
        private void PopulateDataGridViewGetCarsWithLowerPrice()
        {
            dataGridView.Rows.Clear(); HideSpecificInfo();
            CarBusiness carBusiness = new CarBusiness();
            int.TryParse(txtGet.Text, out int price);
            var carsList = carBusiness.GetCarsWithLowerPrice(price);
            DataPopulator(carsList);
        }

        /// <summary>
        /// Populate the data grid with information about cars with given type of transmission
        /// </summary>
        private void PopulateDataGridViewGetCarsByTransmissionType()
        {
            dataGridView.Rows.Clear(); HideSpecificInfo();
            CarBusiness carBusiness = new CarBusiness();
            var carsList = carBusiness.GetCarsByTransmissionType(txtGet.Text);
            DataPopulator(carsList);
        }

        /// <summary>
        /// Populate the data grid with information about cars with given number of gears
        /// </summary>
        private void PopulateDataGridViewGetCarsByTransmissionGears()
        {
            dataGridView.Rows.Clear(); HideSpecificInfo();
            CarBusiness carBusiness = new CarBusiness();
            int.TryParse(txtGet.Text, out int gears);
            var carsList = carBusiness.GetCarsByTransmissionGears(gears);
            DataPopulator(carsList);
        }

        /// <summary>
        /// Populate the data grid with information about cars which are for sale
        /// </summary>
        private void PopulateDataGridViewGetCarsForSale()
        {
            dataGridView.Rows.Clear(); HideSpecificInfo();
            CarBusiness carBusiness = new CarBusiness();
            var carsList = carBusiness.GetCarsForSale();
            DataPopulator(carsList);
        }

        /// <summary>
        /// Populate the data grid with information about cars which have been sold
        /// </summary>
        private void PopulateDataGridViewGetOwnedCars()
        {
            dataGridView.Rows.Clear(); HideSpecificInfo();
            CarBusiness carBusiness = new CarBusiness();
            var carsList = carBusiness.GetOwnedCars();
            DataPopulator(carsList);
        }
        //Get logic//

        //Sort logic//

        /// <summary>
        /// Populate the data grid with information sorted by cars' dealership name in ascending order
        /// </summary>
        private void PopulateDataGridViewSortCarsByDealershipNameAscending()
        {
            dataGridView.Rows.Clear(); HideSpecificInfo();
            CarBusiness carBusiness = new CarBusiness();
            var carsList = carBusiness.SortCarsByDealershipNameAscending();
            DataPopulator(carsList);
        }

        /// <summary>
        /// Populate the data grid with information sorted by cars' dealership name in descending order
        /// </summary>
        private void PopulateDataGridViewSortCarsByDealershipNameDescending()
        {
            dataGridView.Rows.Clear(); HideSpecificInfo();
            CarBusiness carBusiness = new CarBusiness();
            var carsList = carBusiness.SortCarsByDealershipNameDescending();
            DataPopulator(carsList);
        }

        /// <summary>
        /// Populate the data grid with information sorted by cars' number of gears in ascending order
        /// </summary>
        private void PopulateDataGridViewSortCarsByTransmissionGearsAscending()
        {
            dataGridView.Rows.Clear(); HideSpecificInfo();
            CarBusiness carBusiness = new CarBusiness();
            var carsList = carBusiness.SortCarsByTransmissionGearsAscending();
            DataPopulator(carsList);
        }

        /// <summary>
        /// Populate the data grid with information sorted by cars' number of gears in descending order
        /// </summary>
        private void PopulateDataGridViewSortCarsByTransmissionGearsDescending()
        {
            dataGridView.Rows.Clear(); HideSpecificInfo();
            CarBusiness carBusiness = new CarBusiness();
            var carsList = carBusiness.SortCarsByTransmissionGearsDescending();
            DataPopulator(carsList);
        }

        /// <summary>
        /// Populate the data grid with information sorted by cars' manufacturer and model in ascending order
        /// </summary>
        private void PopulateDataGridViewSortCarsByManufacturerAndModelAscending()
        {
            dataGridView.Rows.Clear(); HideSpecificInfo();
            CarBusiness carBusiness = new CarBusiness();
            var carsList = carBusiness.SortCarsByManufacturerAndModelAscending();
            DataPopulator(carsList);
        }

        /// <summary>
        /// Populate the data grid with information sorted by cars' manufacturer and model in descending order
        /// </summary>
        private void PopulateDataGridViewSortCarsByManufacturerAndModelDescending()
        {
            dataGridView.Rows.Clear(); HideSpecificInfo();
            CarBusiness carBusiness = new CarBusiness();
            var carsList = carBusiness.SortCarsByManufacturerAndModelDescending();
            DataPopulator(carsList);
        }

        /// <summary>
        /// Populate the data grid with information sorted by cars' power in ascending order
        /// </summary>
        private void PopulateDataGridViewSortCarsByPowerAscending()
        {
            dataGridView.Rows.Clear(); HideSpecificInfo();
            CarBusiness carBusiness = new CarBusiness();
            var carsList = carBusiness.SortCarsByPowerAscending();
            DataPopulator(carsList);
            dataGridView.Columns[5].Visible = true;
        }

        /// <summary>
        /// Populate the data grid with information sorted by cars' power in descending order
        /// </summary>
        private void PopulateDataGridViewSortCarsByPowerDescending()
        {
            dataGridView.Rows.Clear(); HideSpecificInfo();
            CarBusiness carBusiness = new CarBusiness();
            var carsList = carBusiness.SortCarsByPowerDescending();
            DataPopulator(carsList);
            dataGridView.Columns[5].Visible = true;
        }

        /// <summary>
        /// Populate the data grid with information sorted by cars' fuel economy in ascending order
        /// </summary>
        private void PopulateDataGridViewSortCarsByFuelEconomyAscending()
        {
            dataGridView.Rows.Clear(); HideSpecificInfo();
            CarBusiness carBusiness = new CarBusiness();
            var carsList = carBusiness.SortCarsByFuelEconomyAscending();
            DataPopulator(carsList);
            dataGridView.Columns[8].Visible = true;
        }

        /// <summary>
        /// Populate the data grid with information sorted by cars' fuel economy in descending order
        /// </summary>
        private void PopulateDataGridViewSortCarsByFuelEconomyDescending()
        {
            dataGridView.Rows.Clear(); HideSpecificInfo();
            CarBusiness carBusiness = new CarBusiness();
            var carsList = carBusiness.SortCarsByFuelEconomyDescending();
            DataPopulator(carsList);
            dataGridView.Columns[8].Visible = true;
        }

        /// <summary>
        /// Populate the data grid with information sorted by cars' displacement in ascending order
        /// </summary>
        private void PopulateDataGridViewSortCarsByDisplacementAscending()
        {
            dataGridView.Rows.Clear(); HideSpecificInfo();
            CarBusiness carBusiness = new CarBusiness();
            var carsList = carBusiness.SortCarsByDisplacementAscending();
            DataPopulator(carsList);
            dataGridView.Columns[6].Visible = true;
        }

        /// <summary>
        /// Populate the data grid with information sorted by cars' displacement in descending order
        /// </summary>
        private void PopulateDataGridViewSortCarsByDisplacementDescending()
        {
            dataGridView.Rows.Clear(); HideSpecificInfo();
            CarBusiness carBusiness = new CarBusiness();
            var carsList = carBusiness.SortCarsByDisplacementDescending();
            DataPopulator(carsList);
            dataGridView.Columns[6].Visible = true;
        }

        /// <summary>
        /// Populate the data grid with information sorted by cars' price in ascending order
        /// </summary>
        private void PopulateDataGridViewSortCarsByPriceAscending()
        {
            dataGridView.Rows.Clear(); HideSpecificInfo();
            CarBusiness carBusiness = new CarBusiness();
            var carsList = carBusiness.SortCarsByPriceAscending();
            DataPopulator(carsList);
        }

        /// <summary>
        /// Populate the data grid with information sorted by cars' price in descending order
        /// </summary>
        private void PopulateDataGridViewSortCarsByPriceDescending()
        {
            dataGridView.Rows.Clear(); HideSpecificInfo();
            CarBusiness carBusiness = new CarBusiness();
            var carsList = carBusiness.SortCarsByPriceDescending();
            DataPopulator(carsList);
        }

        /// <summary>
        /// Populate the data grid with information sorted by cars' fuel type
        /// </summary>
        private void PopulateDataGridViewSortCarsByFuelType()
        {
            dataGridView.Rows.Clear(); HideSpecificInfo();
            CarBusiness carBusiness = new CarBusiness();
            var carsList = carBusiness.SortCarsByFuelType();
            DataPopulator(carsList);
            dataGridView.Columns[7].Visible = true;
        }

        /// <summary>
        /// Populate the data grid with information sorted by cars' transmission type
        /// </summary>
        private void PopulateDataGridViewSortCarsByTransmissionType()
        {
            dataGridView.Rows.Clear(); HideSpecificInfo();
            CarBusiness carBusiness = new CarBusiness();
            var carsList = carBusiness.SortCarsByTransmissionType();
            DataPopulator(carsList);
        }

        /// <summary>
        /// Populate the data grid with information sorted by cars' color
        /// </summary>
        private void PopulateDataGridViewSortCarsByColor()
        {
            dataGridView.Rows.Clear(); HideSpecificInfo();
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
                case 6: SetupDataGridView(); PopulateDataGridViewGetCarsWithLowerPower(); break;
                case 7: SetupDataGridView(); PopulateDataGridViewGetCarsWithHigherPower(); break;
                case 8: SetupDataGridView(); PopulateDataGridViewGetCarsByDisplacement(); break;
                case 9: SetupDataGridView(); PopulateDataGridViewGetCarsWithLowerDisplacement(); break;
                case 10: SetupDataGridView(); PopulateDataGridViewGetCarsWithHigherDisplacement(); break;
                case 11: SetupDataGridView(); PopulateDataGridViewGetCarsByTransmissionType(); break;
                case 12: SetupDataGridView(); PopulateDataGridViewGetCarsByTransmissionGears(); break;
                case 13: SetupDataGridView(); PopulateDataGridViewGetCarsByColor(); break;
                case 14: SetupDataGridView(); PopulateDataGridViewGetCarsByPrice(); break;
                case 15: SetupDataGridView(); PopulateDataGridViewGetCarsWithLowerPrice(); break;
                case 16: SetupDataGridView(); PopulateDataGridViewGetCarsWithHigherPrice(); break;
                case 17: SetupDataGridView(); PopulateDataGridViewGetCarsForSale(); break;
                case 18: SetupDataGridView(); PopulateDataGridViewGetOwnedCars(); break;
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
                var carId = int.Parse(car[0].Value.ToString());
                editId = carId;
                UpdateTextBoxes(carId);
                ToggleSaveUpdate();
                DisableSelect();
            }
        }

        /// <summary>
        /// Update the input text boxes with information for a selected car
        /// </summary>
        /// <param name="Id">The ID of a selected car</param>
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

        /// <summary>
        /// Pull edited information from the input text boxes to an instance of a car
        /// </summary>
        /// <returns>Returns a car with edited information</returns>
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
            int.TryParse(txtOwner.Text, out int ownerId);
            car.OwnerId = ownerId;

            return car;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                var car = dataGridView.SelectedRows[0].Cells;
                var carId = int.Parse(car[0].Value.ToString());
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Convert car's fuel from Bulgarian to English
        /// </summary>
        /// <param name="fuel">Car's fuel in Bulgarian</param>
        /// <returns>Returns car's fuel in English</returns>
        private string FuelBGTtoENG(string fuel)
        {
            if (fuel == "Бензин")
            {
                return "Gasoline";
            }
            else if (fuel == "Дизел")
            {
                return "Diesel";
            }
            else if (fuel == "Газ")
            {
                return "LPG";
            }
            else
            {
                return "Electricity";
            }
        }

        /// <summary>
        /// Convert car's fuel from English to Bulgarian
        /// </summary>
        /// <param name="fuel">Car's fuel in English</param>
        /// <returns>Returns car's fuel in Bulgarian</returns>
        private string FuelENGToBG(string fuel)
        {
            if (fuel == "Gasoline")
            {
                return "Бензин";
            }
            else if (fuel == "Diesel")
            {
                return "Дизел";
            }
            else if (fuel == "LPG")
            {
                return "Газ";
            }
            else
            {
                return "Електричество";
            }
        }
        //Buttons + attached logic//

        //Data populators//

        /// <summary>
        /// Populate the data grid with information about cars
        /// </summary>
        /// <param name="cars">A list of cars used to populate the data grid</param>
        private void DataPopulator(List<Car> cars)
        {
            foreach (var car in cars)
            {
                EngineBusiness engineBusiness = new EngineBusiness();
                var engine = engineBusiness.GetEngineById(car.EngineId);
                CarBusiness carBusiness = new CarBusiness();
                string[] row =
                {
                    car.Id.ToString(),
                    car.Manufacturer,
                    car.Model,
                    carBusiness.GetDealershipName(car.CarDealershipId),
                    engine.Name,
                    engine.Power.ToString(),
                    engine.Displacement.ToString(),
                    FuelENGToBG(engine.FuelType),
                    engine.EconomyPerHundredKm.ToString(),
                    car.TransmissionType,
                    car.TransmissionGears.ToString(),
                    car.Color,
                    car.Price.ToString() + " лв.",
                    carBusiness.GetOwnerName(car.OwnerId),
                };
                dataGridView.Rows.Add(row);
            }
        }

        /// <summary>
        /// Populate the data grid with information for a single car
        /// </summary>
        /// <param name="car">A single car used to populate the data grid</param>
        private void DataPopulatorSingle(Car car)
        {
            EngineBusiness engineBusiness = new EngineBusiness();
            var engine = engineBusiness.GetEngineById(car.EngineId);
            CarBusiness carBusiness = new CarBusiness();
            string[] row =
            {
                    car.Id.ToString(),
                    car.Manufacturer,
                    car.Model,
                    carBusiness.GetDealershipName(car.CarDealershipId),
                    engine.Name,
                    engine.Power.ToString(),
                    engine.Displacement.ToString(),
                    FuelENGToBG(engine.FuelType),
                    engine.EconomyPerHundredKm.ToString(),
                    car.TransmissionType,
                    car.TransmissionGears.ToString(),
                    car.Color,
                    car.Price.ToString() + " лв.",
                    carBusiness.GetOwnerName(car.OwnerId),
            };
            dataGridView.Rows.Add(row);
        }
        //Data populators//

        //FormatLogic
        
        /// <summary>
        /// Setup a data grid for cars
        /// </summary>
        private void SetupDataGridView()
        {
            dataGridView.ColumnCount = 14;

            dataGridView.Columns[0].Name = "ID";
            dataGridView.Columns[1].Name = "Марка";
            dataGridView.Columns[2].Name = "Модел";
            dataGridView.Columns[3].Name = "Автокъща";
            dataGridView.Columns[4].Name = "Двигател";
            dataGridView.Columns[5].Name = "Мощност";
            dataGridView.Columns[6].Name = "Работен обем";
            dataGridView.Columns[7].Name = "Гориво";
            dataGridView.Columns[8].Name = "Разход на 100 километра";
            dataGridView.Columns[9].Name = "Скоростна кутия";
            dataGridView.Columns[10].Name = "Брой предавки";
            dataGridView.Columns[11].Name = "Цвят";
            dataGridView.Columns[12].Name = "Цена";
            dataGridView.Columns[13].Name = "Собственик";

   
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

        /// <summary>
        /// Disable the user's ability to interact with the control
        /// </summary>
        private void DisableSelect()
        {
            dataGridView.Enabled = false;
        }

        /// <summary>
        /// Enable the user's ability to interact with the control and clear user selection
        /// </summary>
        private void ResetSelect()
        {
            dataGridView.ClearSelection();
            dataGridView.Enabled = true;
        }

        /// <summary>
        /// Toggle the visibilty of the 'Update' and 'Save' buttons
        /// </summary>
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

        /// <summary>
        /// Clear the input text boxes
        /// </summary>
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

        /// <summary>
        /// Hide specific info that could not be of relevancy in the default context
        /// </summary>
        private void HideSpecificInfo()
        {
            dataGridView.Columns[5].Visible = false;
            dataGridView.Columns[6].Visible = false;
            dataGridView.Columns[7].Visible = false;
            dataGridView.Columns[8].Visible = false;
        }
        //Formatlogic//
    }
}