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
        private void PopulateDataGridViewDefault()
        {
            dataGridView.Rows.Clear();
            TownBusiness townBusiness = new TownBusiness();
            var townList = townBusiness.GetAllTowns();
            DataPopulator(townList);
        }
        //Get logic//

        //Sort logic//

        //Sort logic//
        //Main logic//

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

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }

        private void btnOpenHelper_Click(object sender, EventArgs e)
        {

        }
        //Buttons + attached logic//

        //Data populators//
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
        //FormatLogic//
    }
}
