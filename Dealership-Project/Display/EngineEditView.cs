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
    public partial class EngineEditView : Form
    {
        private int editId = 0;

        public EngineEditView()
        {
            InitializeComponent();
        }

        private void EngineEditView_Load(object sender, EventArgs e)
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
            EngineBusiness engineBusiness = new EngineBusiness();
            var enginesList = engineBusiness.GetAllEngines();
            DataPopulator(enginesList);
        }

        private void PopulateDataGridViewGetEngineById()
        {
            dataGridView.Rows.Clear();
            EngineBusiness engineBusiness = new EngineBusiness();
            int.TryParse(txtGet.Text, out int engineId);
            var enginesList = engineBusiness.GetEngineById(engineId);
            DataPopulatorSingle(enginesList);
        }

        private void PopulateDataGridViewGetEngineByName()
        {
            dataGridView.Rows.Clear();
            EngineBusiness engineBusiness = new EngineBusiness();
            var enginesList = engineBusiness.GetEngineByName(txtGet.Text);
            DataPopulatorSingle(enginesList);
        }

        private void PopulateDataGridViewGetEnginesByFuelType()
        {
            dataGridView.Rows.Clear();
            EngineBusiness engineBusiness = new EngineBusiness();
            var enginesList = engineBusiness.GetEnginesByFuelType(txtGet.Text);
            DataPopulator(enginesList);
        }

        private void PopulateDataGridViewGetEnginesByDisplacement()
        {
            dataGridView.Rows.Clear();
            EngineBusiness engineBusiness = new EngineBusiness();
            int.TryParse(txtGet.Text, out int displacement);
            var enginesList = engineBusiness.GetEnginesByDisplacement(displacement);
            DataPopulator(enginesList);
        }

        private void PopulateDataGridViewGetEnginesWithLowerDisplacement()
        {
            dataGridView.Rows.Clear();
            EngineBusiness engineBusiness = new EngineBusiness();
            int.TryParse(txtGet.Text, out int displacement);
            var enginesList = engineBusiness.GetEnginesWithLowerDisplacement(displacement);
            DataPopulator(enginesList);
        }

        private void PopulateDataGridViewGetEnginesWithHigherDisplacement()
        {
            dataGridView.Rows.Clear();
            EngineBusiness engineBusiness = new EngineBusiness();
            int.TryParse(txtGet.Text, out int displacement);
            var enginesList = engineBusiness.GetEnginesWithHigherDisplacement(displacement);
            DataPopulator(enginesList);
        }

        private void PopulateDataGridViewGetEnginesByPower()
        {
            dataGridView.Rows.Clear();
            EngineBusiness engineBusiness = new EngineBusiness();
            int.TryParse(txtGet.Text, out int power);
            var enginesList = engineBusiness.GetEnginesByPower(power);
            DataPopulator(enginesList);
        }

        private void PopulateDataGridViewGetEnginesWithLowerPower()
        {
            dataGridView.Rows.Clear();
            EngineBusiness engineBusiness = new EngineBusiness();
            int.TryParse(txtGet.Text, out int power);
            var enginesList = engineBusiness.GetEnginesWithLowerPower(power);
            DataPopulator(enginesList);
        }

        private void PopulateDataGridViewGetEnginesWithHigherPower()
        {
            dataGridView.Rows.Clear();
            EngineBusiness engineBusiness = new EngineBusiness();
            int.TryParse(txtGet.Text, out int power);
            var enginesList = engineBusiness.GetEnginesWithHigherPower(power);
            DataPopulator(enginesList);
        }

        private void PopulateDataGridViewGetEnginesByEconomyPerHundredKm()
        {
            dataGridView.Rows.Clear();
            EngineBusiness engineBusiness = new EngineBusiness();
            decimal.TryParse(txtGet.Text, out decimal economy);
            var enginesList = engineBusiness.GetEnginesByEconomyPerHundredKm(economy);
            DataPopulator(enginesList);
        }

        private void PopulateDataGridViewGetEnginesWithLowerEconomyPerHundredKm()
        {
            dataGridView.Rows.Clear();
            EngineBusiness engineBusiness = new EngineBusiness();
            decimal.TryParse(txtGet.Text, out decimal economy);
            var enginesList = engineBusiness.GetEnginesWithLowerEconomyPerHundredKm(economy);
            DataPopulator(enginesList);
        }

        private void PopulateDataGridViewGetEnginesWithHigherEconomyPerHundredKm()
        {
            dataGridView.Rows.Clear();
            EngineBusiness engineBusiness = new EngineBusiness();
            decimal.TryParse(txtGet.Text, out decimal economy);
            var enginesList = engineBusiness.GetEnginesWithHigherEconomyPerHundredKm(economy);
            DataPopulator(enginesList);
        }
        //Get logic//
        //Sort logic//
        private void PopulateDataGridViewSortEnginesByPowerAscending()
        {
            dataGridView.Rows.Clear();
            EngineBusiness engineBusiness = new EngineBusiness();
            var enginesList = engineBusiness.SortEnginesByPowerAscending();
            DataPopulator(enginesList);
        }

        private void PopulateDataGridViewSortEnginesByPowerDescending()
        {
            dataGridView.Rows.Clear();
            EngineBusiness engineBusiness = new EngineBusiness();
            var enginesList = engineBusiness.SortEnginesByPowerDescending();
            DataPopulator(enginesList);
        }

        private void PopulateDataGridViewSortEnginesByEconomyPerHundredKmAscending()
        {
            dataGridView.Rows.Clear();
            EngineBusiness engineBusiness = new EngineBusiness();
            var enginesList = engineBusiness.SortEnginesByEconomyPerHundredKmAscending();
            DataPopulator(enginesList);
        }

        private void PopulateDataGridViewSortEnginesByEconomyPerHundredKmDescending()
        {
            dataGridView.Rows.Clear();
            EngineBusiness engineBusiness = new EngineBusiness();
            var enginesList = engineBusiness.SortEnginesByEconomyPerHundredKmDescending();
            DataPopulator(enginesList);
        }

        private void PopulateDataGridViewSortEnginesByDisplacementAscending()
        {
            dataGridView.Rows.Clear();
            EngineBusiness engineBusiness = new EngineBusiness();
            var enginesList = engineBusiness.SortEnginesByDisplacementAscending();
            DataPopulator(enginesList);
        }

        private void PopulateDataGridViewSortEnginesByDisplacementDescending()
        {
            dataGridView.Rows.Clear();
            EngineBusiness engineBusiness = new EngineBusiness();
            var enginesList = engineBusiness.SortEnginesByDisplacementDescending();
            DataPopulator(enginesList);
        }

        private void PopulateDataGridViewSortEnginesByNameAscending()
        {
            dataGridView.Rows.Clear();
            EngineBusiness engineBusiness = new EngineBusiness();
            var enginesList = engineBusiness.SortEnginesByNameAscending();
            DataPopulator(enginesList);
        }

        private void PopulateDataGridViewSortEnginesByNameDescending()
        {
            dataGridView.Rows.Clear();
            EngineBusiness engineBusiness = new EngineBusiness();
            var enginesList = engineBusiness.SortEnginesByNameDescending();
            DataPopulator(enginesList);
        }

        private void PopulateDataGridViewSortEnginesByFuelType()
        {
            dataGridView.Rows.Clear();
            EngineBusiness engineBusiness = new EngineBusiness();
            var enginesList = engineBusiness.SortEnginesByFuelType();
            DataPopulator(enginesList);
        }
        //Sort logic//
        //Main logic//

        //cbGet and cbSort//
        private void cbGet_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbGet.SelectedIndex;
            switch (index)
            {
                case 0: SetupDataGridView(); PopulateDataGridViewGetEngineById(); break;
                case 1: SetupDataGridView(); PopulateDataGridViewGetEngineByName(); break;
                case 2: SetupDataGridView(); PopulateDataGridViewGetEnginesByFuelType(); break;
                case 3: SetupDataGridView(); PopulateDataGridViewGetEnginesByDisplacement(); break;
                case 4: SetupDataGridView(); PopulateDataGridViewGetEnginesWithLowerDisplacement(); break;
                case 5: SetupDataGridView(); PopulateDataGridViewGetEnginesWithHigherDisplacement(); break;
                case 6: SetupDataGridView(); PopulateDataGridViewGetEnginesByPower(); break;
                case 7: SetupDataGridView(); PopulateDataGridViewGetEnginesWithLowerPower(); break;
                case 8: SetupDataGridView(); PopulateDataGridViewGetEnginesWithHigherPower(); break;
                case 9: SetupDataGridView(); PopulateDataGridViewGetEnginesByEconomyPerHundredKm(); break;
                case 10: SetupDataGridView(); PopulateDataGridViewGetEnginesWithLowerEconomyPerHundredKm(); break;
                case 11: SetupDataGridView(); PopulateDataGridViewGetEnginesWithHigherEconomyPerHundredKm(); break;
            }
        }

        private void cbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbSort.SelectedIndex;
            switch (index)
            {
                case 0: SetupDataGridView(); PopulateDataGridViewSortEnginesByPowerAscending(); break;
                case 1: SetupDataGridView(); PopulateDataGridViewSortEnginesByPowerDescending(); break;
                case 2: SetupDataGridView(); PopulateDataGridViewSortEnginesByEconomyPerHundredKmAscending(); break;
                case 3: SetupDataGridView(); PopulateDataGridViewSortEnginesByEconomyPerHundredKmDescending(); break;
                case 4: SetupDataGridView(); PopulateDataGridViewSortEnginesByDisplacementAscending(); break;
                case 5: SetupDataGridView(); PopulateDataGridViewSortEnginesByDisplacementDescending(); break;
                case 6: SetupDataGridView(); PopulateDataGridViewSortEnginesByNameAscending(); break;
                case 7: SetupDataGridView(); PopulateDataGridViewSortEnginesByNameDescending(); break;
                case 8: SetupDataGridView(); PopulateDataGridViewSortEnginesByFuelType(); break;
            }
        }
        //cbGet and cbSort//

        //Buttons + attached//      
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Engine engine = new Engine();

            engine.Name = txtName.Text;
            engine.FuelType = txtFuelType.Text;
            decimal.TryParse(txtEconomy.Text, out decimal economy);
            engine.EconomyPerHundredKm = economy;
            int.TryParse(txtDisplacement.Text, out int displacement);
            engine.Displacement = displacement;
            int.TryParse(txtPower.Text, out int power);
            engine.Power = power;

            EngineBusiness engineBusiness = new EngineBusiness();
            engineBusiness.Add(engine);
            PopulateDataGridViewDefault();
            ClearTextBoxes();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                var engine = dataGridView.SelectedRows[0].Cells;
                var engineId = int.Parse(engine[0].Value.ToString());
                editId = engineId;
                UpdateTextBoxes(engineId);
                ToggleSaveUpdate();
                DisableSelect();
            }
        }

        private void UpdateTextBoxes(int Id)
        {
            EngineBusiness engineBusiness = new EngineBusiness();
            Engine engine = engineBusiness.GetEngineById(Id);
            txtDisplacement.Text = engine.Displacement.ToString();
            txtEconomy.Text = engine.EconomyPerHundredKm.ToString();
            txtFuelType.Text = engine.FuelType;
            txtName.Text = engine.Name;
            txtPower.Text = engine.Power.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Engine engine = GetEditedEngine();
            EngineBusiness engineBusiness = new EngineBusiness();
            engineBusiness.Update(engine);
            PopulateDataGridViewDefault();
            ResetSelect();
            ToggleSaveUpdate();
            ClearTextBoxes();
        }

        private Engine GetEditedEngine()
        {
            Engine engine = new Engine();

            engine.Id = editId;

            engine.Name = txtName.Text;
            engine.FuelType = txtFuelType.Text;
            decimal.TryParse(txtEconomy.Text, out decimal economy);
            engine.EconomyPerHundredKm = economy;
            int.TryParse(txtDisplacement.Text, out int displacement);
            engine.Displacement = displacement;
            int.TryParse(txtPower.Text, out int power);
            engine.Power = power;

            return engine;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                var engine = dataGridView.SelectedRows[0].Cells;
                var engineId = int.Parse(engine[0].Value.ToString());
                EngineBusiness engineBusiness = new EngineBusiness();
                engineBusiness.Delete(engineId);
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
        //Buttons + attached//

        //Data populators//
        private void DataPopulator(List<Engine> engines)
        {
            foreach (var engine in engines)
            {
                EngineBusiness engineBusiness = new EngineBusiness();
                string[] row =
                {
                    engine.Id.ToString(),
                    engine.Name,
                    engine.FuelType,
                    engine.Power.ToString(),
                    engine.Displacement.ToString(),
                    engine.EconomyPerHundredKm.ToString()
                };
                dataGridView.Rows.Add(row);
            }
        }

        private void DataPopulatorSingle(Engine engine)
        {
            EngineBusiness engineBusiness = new EngineBusiness();
            string[] row =
            {
                engine.Id.ToString(),
                engine.Name,
                engine.FuelType,
                engine.Power.ToString(),
                engine.Displacement.ToString(),
                engine.EconomyPerHundredKm.ToString()
            };
            dataGridView.Rows.Add(row);
        }
        //Data populators//

        //FormatLogic//
        private void SetupDataGridView()
        {
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
            dataGridView.CellBorderStyle =
            DataGridViewCellBorderStyle.Single;
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
            txtDisplacement.Text = "";
            txtEconomy.Text = "";
            txtFuelType.Text = "";
            txtName.Text = "";
            txtPower.Text = "";
        }
        //FormatLogic//
    }
}
