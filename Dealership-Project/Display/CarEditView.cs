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
using Data;

namespace Display
{
    public partial class CarEditView : Form
    {
        private CarBusiness carBusiness = new CarBusiness();

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
            foreach(var car in carBusinessList)
            {
                
                string[] row =
                {
                    car.Manufacturer, car.Model/*, car.CarDealershipNavigation.Name   , car.Engine.Name*/, car.TransmissionType, car.TransmissionGears.ToString(),
                    car.Color, car.Price.ToString(),""
                };
                dataGridView1.Rows.Add(row);
            }

            //dataGridView1.Columns[0].DisplayIndex = 3;
        }

        private void SetupDataGridView()
        {
          //  this.Controls.Add(dataGridView1);

            dataGridView1.ColumnCount = 9;

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

            dataGridView1.Columns[0].Name = "Manufacturer";
            dataGridView1.Columns[1].Name = "Model";
            dataGridView1.Columns[2].Name = "Dealership";
            dataGridView1.Columns[3].Name = "Engine";
            dataGridView1.Columns[4].Name = "Transmission";
            dataGridView1.Columns[5].Name = "Gears";
            dataGridView1.Columns[6].Name = "Color";
            dataGridView1.Columns[7].Name = "Price";
            dataGridView1.Columns[8].Name = "Owner";

            dataGridView1.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
           // dataGridView1.Dock = DockStyle.Fill;
        }
    }
}
