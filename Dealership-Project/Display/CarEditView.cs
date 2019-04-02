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
        public CarEditView()
        {
            InitializeComponent();
            this.Load += new EventHandler(CarEditView_Load);
        }

        private void CarEditView_Load(object sender, EventArgs e)
        {
            //SetupLayout();
            SetupDataGridView();
            PopulateDataGridView();
        }

        private void PopulateDataGridView()
        {
            CarBusiness carBusiness = new CarBusiness();
            EngineBusiness engineBusiness = new EngineBusiness();
            //CarDealershipBusiness carDealershipBusiness = new CarDealershipBusiness();
            dataGridView.Rows.Clear();
            var carBusinessList = carBusiness.GetAllCars();
            //var carDealershipList = carDealershipBusiness.GetAllCarDealerships();
            var engineList = engineBusiness.GetAllEngines();
            foreach (var car in carBusinessList)
            {

                string[] row =
                {
                    car.Manufacturer,
                    car.Model,
                    //car.CarDealership.Name,
                    carBusiness.GetDealershipName(car.CarDealershipId),
                    car.EngineId.ToString(),
                    car.TransmissionType,
                    car.TransmissionGears.ToString(),
                    car.Color,
                    car.Price.ToString() + " лв.",
                    car.OwnerId.ToString(),
                    car.Id.ToString()
                };
                foreach (var engine in engineList)
                {
                    if (engine.Id.ToString() == row[3])
                    {
                        row[3] = engine.Name;
                    }
                }
                /*foreach (var dealership in carDealershipList)
                {
                    if (dealership.Id.ToString() == row[2])
                    {
                        row[2] = dealership.Name;
                    }
                }*/
                if (row[8] == "")
                {
                    row[8] = "For Sale !";
                }
                dataGridView.Rows.Add(row);
            }
            //dataGridView.Columns[9].Visible = false;
            //dataGridView1.Columns[0].DisplayIndex = 3;
        }

        private void PopulateDataGridView2()
        {
            CarBusiness carBusiness = new CarBusiness();
            EngineBusiness engineBusiness = new EngineBusiness();
            CarDealershipBusiness carDealershipBusiness = new CarDealershipBusiness();
            dataGridView.Rows.Clear();
            var carBusinessList = carBusiness.SortCarsByDisplacementAscending();
            foreach (var car in carBusinessList)
            {

                string[] row =
                {
                    car.Manufacturer,
                    car.Model,
                    car.CarDealershipId.ToString(),
                    car.EngineId.ToString(),
                    car.TransmissionType,
                    car.TransmissionGears.ToString(),
                    car.Color,
                    car.Price.ToString() + " лв.",
                    car.OwnerId.ToString()
                };
                if (row[8] == "")
                {
                    row[8] = "For Sale !";
                }
                dataGridView.Rows.Add(row);
            }

            //dataGridView1.Columns[0].DisplayIndex = 3;
        }

        private void PopulateDataGridView3()
        {
            CarBusiness carBusiness = new CarBusiness();
            EngineBusiness engineBusiness = new EngineBusiness();
            CarDealershipBusiness carDealershipBusiness = new CarDealershipBusiness();
            dataGridView.Rows.Clear();
            var carBusinessList = carBusiness.SortCarsByPowerAscending();
            foreach (var car in carBusinessList)
            {

                string[] row =
                {
                    //car.Id.ToString(),
                    car.Manufacturer,
                    car.Model,
                    car.CarDealershipId.ToString(),
                    car.EngineId.ToString(),
                    car.TransmissionType,
                    car.TransmissionGears.ToString(),
                    car.Color,
                    car.Price.ToString() + " лв.",
                    car.OwnerId.ToString()
                };
                if (row[8] == "")
                {
                    row[8] = "For Sale !";
                }
                dataGridView.Rows.Add(row);
            }
            //dataGridView1.Columns[9].Visible = false;
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
            car.Model = model;
            car.Price = price;
            car.TransmissionGears = transmissionGears;
            car.TransmissionType = transmissionType;
            carBusiness.Add(car);
            PopulateDataGridView();
        }

        private void cbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbSort.SelectedIndex;
            switch (index)
            {
                case 0: SetupDataGridView(); PopulateDataGridView2(); break;
                case 1: SetupDataGridView(); PopulateDataGridView3(); break;
            }
        }
    }
}
