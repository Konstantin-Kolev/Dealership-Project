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
    public partial class CarDealershipEditView : Form
    {
        private int editId = 0;

        public CarDealershipEditView()
        {
            InitializeComponent();
        }

        private void CarDealershipEditView_Load(object sender, EventArgs e)
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

        private void PopulateDataGridViewDefault()
        {
            dataGridView.Rows.Clear();
            CarDealershipBusiness carDealershipBusiness = new CarDealershipBusiness();
            var dealershipList = carDealershipBusiness.GetAllCarDealerships();
            DataPopulator(dealershipList);
        }

        private void PopulateDataGridViewGetCarDealershipByName()
        {
            dataGridView.Rows.Clear();
            CarDealershipBusiness carDealershipBusiness = new CarDealershipBusiness();
            var dealership = carDealershipBusiness.GetCarDealershipByName(txtGet.Text);
            DataPopulatorSingle(dealership);
        }

        private void DataPopulator(List<CarDealership> carDealerships)
        {
            foreach (var dealership in carDealerships)
            {
                CarDealershipBusiness carDealershipBusiness = new CarDealershipBusiness();
                string[] row =
                {
                    dealership.Name,
                    carDealershipBusiness.GetTownName(dealership.TownId),
                    dealership.Id.ToString()
                };
                dataGridView.Rows.Add(row);
            }
        }

        private void DataPopulatorSingle(CarDealership dealership)
        {
            CarDealershipBusiness carDealershipBusiness = new CarDealershipBusiness();
            string[] row =
            {
                dealership.Name,
                carDealershipBusiness.GetTownName(dealership.TownId),
                dealership.Id.ToString()
            };
            dataGridView.Rows.Add(row);
        }

        private void SetupDataGridView()
        {
            dataGridView.ColumnCount = 3;

            dataGridView.Columns[0].Name = "Име";
            dataGridView.Columns[1].Name = "Град";
            dataGridView.Columns[2].Name = "ID";

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

        private void ClearTextBoxes()
        {
            txtName.Text = "";
            txtTown.Text = "";
        }

        private void UpdateTextBoxes(int Id)
        {
            CarDealershipBusiness carDealershipBusiness = new CarDealershipBusiness();
            CarDealership carDealership = carDealershipBusiness.GetCarDealershipById(Id);
            txtName.Text = carDealership.Name;
            txtTown.Text = carDealership.TownId.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var name = txtName.Text;
            int.TryParse(txtTown.Text, out int town);

            CarDealership carDealership = new CarDealership();
            carDealership.Name = name;
            carDealership.TownId = town;

            CarDealershipBusiness carDealershipBusiness = new CarDealershipBusiness();
            carDealershipBusiness.Add(carDealership);
            PopulateDataGridViewDefault();
            ClearTextBoxes();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                var dealership = dataGridView.SelectedRows[0].Cells;
                var dealershipId = int.Parse(dealership[2].Value.ToString());
                editId = dealershipId;
                UpdateTextBoxes(dealershipId);
                ToggleSaveUpdate();
                DisableSelect();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CarDealership carDealership = GetEditedCarDealership();
            CarDealershipBusiness carDealershipBusiness = new CarDealershipBusiness();
            carDealershipBusiness.Update(carDealership);
            PopulateDataGridViewDefault();
            ResetSelect();
            ToggleSaveUpdate();
            ClearTextBoxes();
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                var dealership = dataGridView.SelectedRows[0].Cells;
                var dealershipId = int.Parse(dealership[2].Value.ToString());
                CarDealershipBusiness carDealershipBusiness = new CarDealershipBusiness();
                carDealershipBusiness.Delete(dealershipId);
                PopulateDataGridViewDefault();
                ResetSelect();
            }
        }

        private CarDealership GetEditedCarDealership()
        {
            CarDealership carDealership = new CarDealership();

            carDealership.Id = editId;
            carDealership.Name = txtName.Text;
            int.TryParse(txtTown.Text, out int townId);
            carDealership.TownId = townId;

            return carDealership;
        }

        private void cbGet_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbGet.SelectedIndex;
            switch (index)
            {
                case 0: SetupDataGridView(); PopulateDataGridViewGetCarDealershipByName(); break;
                    //case 1: SetupDataGridView(); PopulateDataGridView3(); break;
            }
        }
    }
}
