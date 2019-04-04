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
            dataGridView.ReadOnly = true;
            //this.GetAllCars();
        }

        private void btnShowCars_Click(object sender, EventArgs e)
        {
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
                    carDealershipBusiness.GetTownId(dealership.TownId),
                    carDealershipBusiness.GetTownName(dealership.TownId)
                };
                dataGridView.Rows.Add(row);
            }
        }
    }
}
