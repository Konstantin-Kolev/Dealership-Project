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
            dataGridView.Columns[0].Visible = false;
            PopulateDataGridViewDefault();
        }

        //Main logic//
        //Get logic//
        private void PopulateDataGridViewDefault()
        {
            dataGridView.Rows.Clear();
            CarDealershipBusiness carDealershipBusiness = new CarDealershipBusiness();
            var dealershipList = carDealershipBusiness.GetAllCarDealerships();
            DataPopulator(dealershipList);
        }

        private void PopulateDataGridViewGetCarDealershipById()
        {
            dataGridView.Rows.Clear();
            CarDealershipBusiness carDealershipBusiness = new CarDealershipBusiness();
            int.TryParse(txtGet.Text, out int dealershipId);
            var dealership = carDealershipBusiness.GetCarDealershipById(dealershipId);
            DataPopulatorSingle(dealership);
        }

        private void PopulateDataGridViewGetCarDealershipByName()
        {
            dataGridView.Rows.Clear();
            CarDealershipBusiness carDealershipBusiness = new CarDealershipBusiness();
            var dealership = carDealershipBusiness.GetCarDealershipByName(txtGet.Text);
            DataPopulatorSingle(dealership);
        }

        private void PopulateDataGridViewGetDealershipsByTown()
        {
            dataGridView.Rows.Clear();
            CarDealershipBusiness carDealershipBusiness = new CarDealershipBusiness();
            var dealershipList = carDealershipBusiness.GetDealershipsByTown(txtGet.Text);
            DataPopulator(dealershipList);
        }
        //Get logic//

        //Sort logic//
        private void PopulateDataGridViewSortDealershipsByNameAscending()
        {
            dataGridView.Rows.Clear();
            CarDealershipBusiness carDealershipBusiness = new CarDealershipBusiness();
            var dealershipList = carDealershipBusiness.SortDealershipsByNameAscending();
            DataPopulator(dealershipList);
        }

        private void PopulateDataGridViewSortDealershipsByNameDescending()
        {
            dataGridView.Rows.Clear();
            CarDealershipBusiness carDealershipBusiness = new CarDealershipBusiness();
            var dealershipList = carDealershipBusiness.SortDealershipsByNameDescending();
            DataPopulator(dealershipList);
        }

        private void PopulateDataGridViewSortDealershipsByTownNameAscending()
        {
            dataGridView.Rows.Clear();
            CarDealershipBusiness carDealershipBusiness = new CarDealershipBusiness();
            var dealershipList = carDealershipBusiness.SortDealershipsByTownNameAscending();
            DataPopulator(dealershipList);
        }

        private void PopulateDataGridViewSortDealershipsByTownNameDescending()
        {
            dataGridView.Rows.Clear();
            CarDealershipBusiness carDealershipBusiness = new CarDealershipBusiness();
            var dealershipList = carDealershipBusiness.SortDealershipsByTownNameDescending();
            DataPopulator(dealershipList);
        }
        //Sort logic//
        //Main logic//

        //cbGet and cbSort//
        private void cbGet_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbGet.SelectedIndex;
            switch (index)
            {
                case 0: SetupDataGridView(); PopulateDataGridViewGetCarDealershipById(); break;
                case 1: SetupDataGridView(); PopulateDataGridViewGetCarDealershipByName(); break;
                case 2: SetupDataGridView(); PopulateDataGridViewGetDealershipsByTown(); break;
            }
        }

        private void cbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbSort.SelectedIndex;
            switch (index)
            {
                case 0: SetupDataGridView(); PopulateDataGridViewSortDealershipsByNameAscending(); break;
                case 1: SetupDataGridView(); PopulateDataGridViewSortDealershipsByNameDescending(); break;
                case 2: SetupDataGridView(); PopulateDataGridViewSortDealershipsByTownNameAscending(); break;
                case 3: SetupDataGridView(); PopulateDataGridViewSortDealershipsByTownNameDescending(); break;
            }
        }
        //cbGet and cbSort//

        //Buttons + attached logic//
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
                var dealershipId = int.Parse(dealership[0].Value.ToString());
                editId = dealershipId;
                UpdateTextBoxes(dealershipId);
                ToggleSaveUpdate();
                DisableSelect();
            }
        }

        private void UpdateTextBoxes(int Id)
        {
            CarDealershipBusiness carDealershipBusiness = new CarDealershipBusiness();
            CarDealership carDealership = carDealershipBusiness.GetCarDealershipById(Id);
            txtName.Text = carDealership.Name;
            txtTown.Text = carDealership.TownId.ToString();
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

        private CarDealership GetEditedCarDealership()
        {
            CarDealership carDealership = new CarDealership();

            carDealership.Id = editId;
            carDealership.Name = txtName.Text;
            int.TryParse(txtTown.Text, out int townId);
            carDealership.TownId = townId;

            return carDealership;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                var dealership = dataGridView.SelectedRows[0].Cells;
                var dealershipId = int.Parse(dealership[0].Value.ToString());
                CarDealershipBusiness carDealershipBusiness = new CarDealershipBusiness();
                carDealershipBusiness.Delete(dealershipId);
                PopulateDataGridViewDefault();
                ResetSelect();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
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
        private void DataPopulator(List<CarDealership> carDealerships)
        {
            foreach (var dealership in carDealerships)
            {
                CarDealershipBusiness carDealershipBusiness = new CarDealershipBusiness();
                string[] row =
                {
                    dealership.Id.ToString(),
                    dealership.Name,
                    carDealershipBusiness.GetTownName(dealership.TownId)
                };
                dataGridView.Rows.Add(row);
            }
        }

        private void DataPopulatorSingle(CarDealership dealership)
        {
            CarDealershipBusiness carDealershipBusiness = new CarDealershipBusiness();
            string[] row =
            {
                dealership.Id.ToString(),
                dealership.Name,
                carDealershipBusiness.GetTownName(dealership.TownId)
            };
            dataGridView.Rows.Add(row);
        }
        //Data populators//

        //FormatLogic//
        private void SetupDataGridView()
        {
            dataGridView.ColumnCount = 3;

            dataGridView.Columns[0].Name = "ID";
            dataGridView.Columns[1].Name = "Име";
            dataGridView.Columns[2].Name = "Град";

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
            txtName.Text = "";
            txtTown.Text = "";
        }
        //FormatLogic//
    }
}
