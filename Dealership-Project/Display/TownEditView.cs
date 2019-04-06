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
    public partial class TownEditView : Form
    {
        private int editId = 0;

        public TownEditView()
        {
            InitializeComponent();
        }

        private void TownEditView_Load(object sender, EventArgs e)
        {
            dataGridView.ReadOnly = true;
            SetupDataGridView();
            dataGridView.Columns[0].Visible = false;
            PopulateDataGridViewDefault();
        }

        //Main logic//
        //Get logic//

        /// <summary>
        /// Populate the data grid with information about all existing towns in the database
        /// </summary>
        private void PopulateDataGridViewDefault()
        {
            dataGridView.Rows.Clear();
            TownBusiness townBusiness = new TownBusiness();
            var townList = townBusiness.GetAllTowns();
            DataPopulator(townList);
        }

        /// <summary>
        /// Populate the data grid with information about town with given town Id
        /// </summary>
        private void PopulateDataGridViewGetTownById()
        {
            dataGridView.Rows.Clear();
            TownBusiness townBusiness = new TownBusiness();
            int.TryParse(txtGet.Text, out int townId);
            var town = townBusiness.GetTownById(townId);
            DataPopulatorSingle(town);
        }

        /// <summary>
        /// Populate the data grid with information about town with given town name
        /// </summary>
        private void PopulateDataGridViewGetTownByName()
        {
            dataGridView.Rows.Clear();
            TownBusiness townBusiness = new TownBusiness();
            var town = townBusiness.GetTownByName(txtGet.Text);
            DataPopulatorSingle(town);
        }
        //Get logic//

        //Sort logic//

        /// <summary>
        /// Populate the data grid with information sorted by towns' name in ascending order
        /// </summary>
        private void PopulateDataGridViewSortTownsByNameAscending()
        {
            dataGridView.Rows.Clear();
            TownBusiness townBusiness = new TownBusiness();
            var townList = townBusiness.SortTownsByNameAscending();
            DataPopulator(townList);
        }

        /// <summary>
        /// Populate the data grid with information sorted by towns' name in descending order
        /// </summary>
        private void PopulateDataGridViewSortTownsByNameDescending()
        {
            dataGridView.Rows.Clear();
            TownBusiness townBusiness = new TownBusiness();
            var townList = townBusiness.SortTownsByNameDescending();
            DataPopulator(townList);
        }
        //Sort logic//
        //Main logic//

        //cbGet and cbSort//
        private void cbGet_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbGet.SelectedIndex;
            switch (index)
            {
                case 0: SetupDataGridView(); PopulateDataGridViewGetTownById(); break;
                case 1: SetupDataGridView(); PopulateDataGridViewGetTownByName(); break;
            }
        }

        private void cbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbSort.SelectedIndex;
            switch (index)
            {
                case 0: SetupDataGridView(); PopulateDataGridViewSortTownsByNameAscending(); break;
                case 1: SetupDataGridView(); PopulateDataGridViewSortTownsByNameDescending(); break;
            }
        }
        //cbGet and cbSort//

        //Buttons + attached logic//
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Town town = new Town
            {
                Name = txtName.Text
            };

            TownBusiness townBusiness = new TownBusiness();
            townBusiness.Add(town);
            PopulateDataGridViewDefault();
            txtName.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                var town = dataGridView.SelectedRows[0].Cells;
                var townId = int.Parse(town[0].Value.ToString());
                editId = townId;
                UpdateTextBoxes(townId);
                ToggleSaveUpdate();
                DisableSelect();
            }
        }

        /// <summary>
        /// Update the input text boxes with information for a selected town
        /// </summary>
        /// <param name="Id">The ID of a selected town</param>
        private void UpdateTextBoxes(int Id)
        {
            TownBusiness townBusiness = new TownBusiness();
            Town town = townBusiness.GetTownById(Id);
            txtName.Text = town.Name;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Town town = GetEditedTown();
            TownBusiness townBusiness = new TownBusiness();
            townBusiness.Update(town);
            PopulateDataGridViewDefault();
            ResetSelect();
            ToggleSaveUpdate();
            txtName.Text = "";
        }

        /// <summary>
        /// Pull edited information from the input text boxes to an instance of a town
        /// </summary>
        /// <returns>Returns a town with edited information</returns>
        private Town GetEditedTown()
        {
            Town town = new Town();

            town.Id = editId;
            town.Name = txtName.Text;

            return town;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                var town = dataGridView.SelectedRows[0].Cells;
                var townId = int.Parse(town[0].Value.ToString());
                TownBusiness townBusiness = new TownBusiness();
                townBusiness.Delete(townId);
                PopulateDataGridViewDefault();
                ResetSelect();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            SetupDataGridView();
            PopulateDataGridViewDefault();
        }

        private void btnOpenHelper_Click(object sender, EventArgs e)
        {
            GridInfoPopUp gridInfoPopUp = new GridInfoPopUp();
            gridInfoPopUp.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Buttons + attached logic//

        //Data populators//

        /// <summary>
        /// Populate the data grid with information about towns
        /// </summary>
        /// <param name="towns">A list of towns used to populate the data grid</param>
        private void DataPopulator(List<Town> towns)
        {
            foreach (var town in towns)
            {
                string[] row =
                {
                    town.Id.ToString(),
                    town.Name
                };
                dataGridView.Rows.Add(row);
            }
        }

        /// <summary>
        /// Populate the data grid with information for a single town
        /// </summary>
        /// <param name="town">A single town used to populate the data grid</param>
        private void DataPopulatorSingle(Town town)
        {
            string[] row =
            {
                town.Id.ToString(),
                town.Name
            };
            dataGridView.Rows.Add(row);
        }
        //Data populators//

        //FormatLogic//

        /// <summary>
        /// Setup a data grid for towns
        /// </summary>
        private void SetupDataGridView()
        {
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
        //FormatLogic//
    }
}
