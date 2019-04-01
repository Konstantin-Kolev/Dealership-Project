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
        private CarBusiness carBusiness = new CarBusiness();
        private CarDealershipBusiness carDealershipBusiness = new CarDealershipBusiness();
        private EngineBusiness engineBusiness = new EngineBusiness();

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
            dataGridView1.Rows.Clear();
            var carBusinessList = carBusiness.GetAllCars();
            var carDealershipList = carDealershipBusiness.GetAllCarDealerships();
            var engineList = engineBusiness.GetAllEngines();
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
                foreach (var engine in engineList)
                {
                    if (engine.Id.ToString() == row[3])
                    {
                        row[3] = engine.Name;
                    }
                }
                foreach (var dealership in carDealershipList)
                {
                    if (dealership.Id.ToString() == row[2])
                    {
                        row[2] = dealership.Name;
                    }
                }
                if (row[8] == "")
                {
                    row[8] = "For Sale !";
                }
                dataGridView1.Rows.Add(row);
            }

            //dataGridView1.Columns[0].DisplayIndex = 3;
        }

        private void PopulateDataGridView2()
        {
            dataGridView1.Rows.Clear();
            var carBusinessList = carBusiness.SortCarsByDisplacemnetAscending();
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
                dataGridView1.Rows.Add(row);
            }

            //dataGridView1.Columns[0].DisplayIndex = 3;
        }

        private void PopulateDataGridView3()
        {
            dataGridView1.Rows.Clear();
            var carBusinessList = carBusiness.SortCarsByPowerAscending();
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
                dataGridView1.Rows.Add(row);
            }

            //dataGridView1.Columns[0].DisplayIndex = 3;
        }

        private void SetupDataGridView()
        {
          //  this.Controls.Add(dataGridView1);

            dataGridView1.ColumnCount = 9;

            dataGridView1.Columns[0].Name = "Manufacturer";
            dataGridView1.Columns[1].Name = "Model";
            dataGridView1.Columns[2].Name = "Dealership";
            dataGridView1.Columns[3].Name = "Engine";
            dataGridView1.Columns[4].Name = "Transmission";
            dataGridView1.Columns[5].Name = "Gears";
            dataGridView1.Columns[6].Name = "Color";
            dataGridView1.Columns[7].Name = "Price";
            dataGridView1.Columns[8].Name = "Owner";

            //dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            //dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            //dataGridView1.ColumnHeadersDefaultCellStyle.Font =
            //new Font(dataGridView1.Font, FontStyle.Bold);

            //dataGridView1.Name = "dataGridView1";
            //dataGridView1.Location = new Point(8, 8);
            //dataGridView1.Size = new Size(500, 250);
            //dataGridView1.AutoSizeRowsMode =
            //DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            //dataGridView1.ColumnHeadersBorderStyle =
            //DataGridViewHeaderBorderStyle.Single;
            //dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            //dataGridView1.GridColor = Color.Black;
            //dataGridView1.RowHeadersVisible = false;



            dataGridView1.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
           // dataGridView1.Dock = DockStyle.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ba4ka ama iska izdokusorqvane//
            var manufacturer = textBox1.Text;
            var model = textBox2.Text;
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;
            switch(index)
            {
                case 0:SetupDataGridView(); PopulateDataGridView2(); break;
                case 1:SetupDataGridView(); PopulateDataGridView3(); break;
            }
        }
    }
}
