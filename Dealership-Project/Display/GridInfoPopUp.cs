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
    public partial class GridInfoPopUp : Form
    {
        public GridInfoPopUp()
        {
            InitializeComponent();
        }

        private void GridInfoPopUp_Load(object sender, EventArgs e)
        {
            HideSpecificInfo();
            dataGridView.ReadOnly = true;
        }

        private void HideSpecificInfo()
        {
            lblInfoCar.Visible = false;
            lblInfoCustomer.Visible = false;
            lblInfoDealership.Visible = false;
            lblInfoEngine.Visible = false;
            lblInfoTown.Visible = false;
            lblInfoWorker.Visible = false;
            btnNewCar.Visible = false;
            btnNewCustomer.Visible = false;
            btnNewDealership.Visible = false;
            btnNewEngine.Visible = false;
            btnNewTown.Visible = false;
            btnNewWorker.Visible = false;
        }

        private void btnCars_Click(object sender, EventArgs e)
        {
            HideSpecificInfo();
            lblInfoCar.Visible = true;
            btnNewCar.Visible = true;

            dataGridView.Rows.Clear();

            dataGridView.ColumnCount = 13;

            dataGridView.Columns[0].Name = "ID";
            dataGridView.Columns[1].Name = "Марка";
            dataGridView.Columns[2].Name = "Модел";
            dataGridView.Columns[3].Name = "ID на автокъща";
            dataGridView.Columns[4].Name = "Автокъща";
            dataGridView.Columns[5].Name = "ID на двигател";
            dataGridView.Columns[6].Name = "Двигател";
            dataGridView.Columns[7].Name = "Скоростна кутия";
            dataGridView.Columns[8].Name = "Предавки";
            dataGridView.Columns[9].Name = "Цвят";
            dataGridView.Columns[10].Name = "Цена";
            dataGridView.Columns[11].Name = "ID на собственик";
            dataGridView.Columns[12].Name = "Собственик";

            dataGridView.AutoSizeRowsMode =
            DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dataGridView.ColumnHeadersBorderStyle =
            DataGridViewHeaderBorderStyle.Single;
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridView.RowHeadersVisible = false;
            dataGridView.SelectionMode =
            DataGridViewSelectionMode.FullRowSelect;
            dataGridView.MultiSelect = false;

            CarBusiness carBusiness = new CarBusiness();
            var carList = carBusiness.GetAllCars();
            foreach (var car in carList)
            {
                string[] row =
                {
                    car.Id.ToString(),
                    car.Manufacturer,
                    car.Model,
                    car.CarDealershipId.ToString(),
                    carBusiness.GetDealershipName(car.CarDealershipId),
                    car.EngineId.ToString(),
                    carBusiness.GetEngineName(car.EngineId),
                    car.TransmissionType,
                    car.TransmissionGears.ToString(),
                    car.Color,
                    car.Price.ToString(),
                    car.OwnerId.ToString(),
                    carBusiness.GetOwnerName(car.OwnerId)
                };
                dataGridView.Rows.Add(row);
            }
        }

        private void btnDealerships_Click(object sender, EventArgs e)
        {
            HideSpecificInfo();
            lblInfoDealership.Visible = true;
            btnNewDealership.Visible = true;

            dataGridView.Rows.Clear();

            dataGridView.ColumnCount = 4;

            dataGridView.Columns[0].Name = "ID";
            dataGridView.Columns[1].Name = "Име";
            dataGridView.Columns[2].Name = "ID на град";
            dataGridView.Columns[3].Name = "Град";

            dataGridView.AutoSizeRowsMode =
            DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dataGridView.ColumnHeadersBorderStyle =
            DataGridViewHeaderBorderStyle.Single;
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridView.RowHeadersVisible = false;
            dataGridView.SelectionMode =
            DataGridViewSelectionMode.FullRowSelect;
            dataGridView.MultiSelect = false;

            CarDealershipBusiness carDealershipBusiness = new CarDealershipBusiness();
            var dealershipList = carDealershipBusiness.GetAllCarDealerships();
            foreach (var dealership in dealershipList)
            {
                string[] row =
                {
                    dealership.Id.ToString(),
                    dealership.Name,
                    dealership.TownId.ToString(),
                    carDealershipBusiness.GetTownName(dealership.TownId)
                };
                dataGridView.Rows.Add(row);
            }
        }

        private void btnEngines_Click(object sender, EventArgs e)
        {
            HideSpecificInfo();
            lblInfoEngine.Visible = true;
            btnNewEngine.Visible = true;

            dataGridView.Rows.Clear();

            dataGridView.ColumnCount = 6;

            dataGridView.Columns[0].Name = "ID";
            dataGridView.Columns[1].Name = "Име";
            dataGridView.Columns[2].Name = "Гориво";
            dataGridView.Columns[3].Name = "Мощност";
            dataGridView.Columns[4].Name = "Работен обем";
            dataGridView.Columns[5].Name = "Разход на 100 километра";

            dataGridView.AutoSizeRowsMode =
            DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dataGridView.ColumnHeadersBorderStyle =
            DataGridViewHeaderBorderStyle.Single;
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridView.RowHeadersVisible = false;
            dataGridView.SelectionMode =
            DataGridViewSelectionMode.FullRowSelect;
            dataGridView.MultiSelect = false;

            EngineBusiness engineBusiness = new EngineBusiness();
            var enginesList = engineBusiness.GetAllEngines();
            foreach (var engine in enginesList)
            {
                string[] row =
                {
                    engine.Id.ToString(),
                    engine.Name,
                    FuelENGToBG(engine.FuelType),
                    engine.Power.ToString(),
                    engine.Displacement.ToString(),
                    engine.EconomyPerHundredKm.ToString()
                };
                dataGridView.Rows.Add(row);
            }
        }

        /// <summary>
        /// Convert engine's fuel from English to Bulgarian
        /// </summary>
        /// <param name="fuel">Engine's fuel in English</param>
        /// <returns>Returns engine's fuel in Bulgarian</returns>
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

        private void btnWorkers_Click(object sender, EventArgs e)
        {
            HideSpecificInfo();
            lblInfoWorker.Visible = true;
            btnNewWorker.Visible = true;

            dataGridView.Rows.Clear();

            dataGridView.ColumnCount = 7;

            dataGridView.Columns[0].Name = "ID";
            dataGridView.Columns[1].Name = "Име";
            dataGridView.Columns[2].Name = "Фамилия";
            dataGridView.Columns[3].Name = "Длъжност";
            dataGridView.Columns[4].Name = "Заплата";
            dataGridView.Columns[5].Name = "ID на автокъща";
            dataGridView.Columns[6].Name = "Автокъща";

            dataGridView.AutoSizeRowsMode =
            DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dataGridView.ColumnHeadersBorderStyle =
            DataGridViewHeaderBorderStyle.Single;
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridView.RowHeadersVisible = false;
            dataGridView.SelectionMode =
            DataGridViewSelectionMode.FullRowSelect;
            dataGridView.MultiSelect = false;

            WorkerBusiness workerBusiness = new WorkerBusiness();
            var workersList = workerBusiness.GetAllWorkers();
            foreach (var worker in workersList)
            {
                string[] row =
                {
                    worker.Id.ToString(),
                    worker.FirstName,
                    worker.LastName,
                    worker.Position,
                    worker.Salary.ToString(),
                    worker.CarDealershipId.ToString(),
                    workerBusiness.GetDealershipName(worker.CarDealershipId)
                };
                dataGridView.Rows.Add(row);
            }
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            HideSpecificInfo();
            lblInfoCustomer.Visible = true;
            btnNewCustomer.Visible = true;

            dataGridView.Rows.Clear();

            dataGridView.ColumnCount = 5;

            dataGridView.Columns[0].Name = "ID";
            dataGridView.Columns[1].Name = "Име";
            dataGridView.Columns[2].Name = "Фамилия";
            dataGridView.Columns[3].Name = "ID град";
            dataGridView.Columns[4].Name = "Град";

            dataGridView.AutoSizeRowsMode =
            DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dataGridView.ColumnHeadersBorderStyle =
            DataGridViewHeaderBorderStyle.Single;
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridView.RowHeadersVisible = false;
            dataGridView.SelectionMode =
            DataGridViewSelectionMode.FullRowSelect;
            dataGridView.MultiSelect = false;

            CustomerBusiness customerBusiness = new CustomerBusiness();
            var customersList = customerBusiness.GetAllCustomers();
            foreach (var customer in customersList)
            {
                string[] row =
                {
                    customer.Id.ToString(),
                    customer.FirstName,
                    customer.LastName,
                    customer.TownId.ToString(),
                    customerBusiness.GetTownName(customer.TownId)
                };
                dataGridView.Rows.Add(row);
            }
        }

        private void btnTowns_Click(object sender, EventArgs e)
        {
            HideSpecificInfo();
            lblInfoTown.Visible = true;
            btnNewTown.Visible = true;

            dataGridView.Rows.Clear();

            dataGridView.ColumnCount = 2;

            dataGridView.Columns[0].Name = "ID";
            dataGridView.Columns[1].Name = "Име";

            dataGridView.AutoSizeRowsMode =
            DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dataGridView.ColumnHeadersBorderStyle =
            DataGridViewHeaderBorderStyle.Single;
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridView.RowHeadersVisible = false;
            dataGridView.SelectionMode =
            DataGridViewSelectionMode.FullRowSelect;
            dataGridView.MultiSelect = false;

            TownBusiness townBusiness = new TownBusiness();
            var townsList = townBusiness.GetAllTowns();
            foreach (var town in townsList)
            {
                string[] row =
                {
                    town.Id.ToString(),
                    town.Name,
                };
                dataGridView.Rows.Add(row);
            }
        }

        private void btnNewCar_Click(object sender, EventArgs e)
        {
            CarEditView carEditView = new CarEditView();
            carEditView.Show();
        }

        private void btnNewDealership_Click(object sender, EventArgs e)
        {
            CarDealershipEditView carDealershipEditView = new CarDealershipEditView();
            carDealershipEditView.Show();
        }

        private void btnNewEngine_Click(object sender, EventArgs e)
        {
            EngineEditView engineEditView = new EngineEditView();
            engineEditView.Show();
        }

        private void btnNewWorker_Click(object sender, EventArgs e)
        {
            WorkerEditView workerEditView = new WorkerEditView();
            workerEditView.Show();
        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            CustomerEditView customerEditView = new CustomerEditView();
            customerEditView.Show();
        }

        private void btnNewTown_Click(object sender, EventArgs e)
        {
            TownEditView townEditView = new TownEditView();
            townEditView.Show();
        }
    }
}
