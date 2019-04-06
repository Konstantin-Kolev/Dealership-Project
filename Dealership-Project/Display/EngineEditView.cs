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

        /// <summary>
        /// Populate the data grid with information about all existing engines in the database
        /// </summary>
        private void PopulateDataGridViewDefault()
        {
            dataGridView.Rows.Clear();
            EngineBusiness engineBusiness = new EngineBusiness();
            var enginesList = engineBusiness.GetAllEngines();
            DataPopulator(enginesList);
        }

        /// <summary>
        /// Populate the data grid with information about engine with given engine Id
        /// </summary>
        private void PopulateDataGridViewGetEngineById()
        {
            dataGridView.Rows.Clear();
            EngineBusiness engineBusiness = new EngineBusiness();
            int.TryParse(txtGet.Text, out int engineId);
            var enginesList = engineBusiness.GetEngineById(engineId);
            DataPopulatorSingle(enginesList);
        }

        /// <summary>
        /// Populate the data grid with information about engine with given name
        /// </summary>
        private void PopulateDataGridViewGetEngineByName()
        {
            dataGridView.Rows.Clear();
            EngineBusiness engineBusiness = new EngineBusiness();
            var enginesList = engineBusiness.GetEngineByName(txtGet.Text);
            DataPopulatorSingle(enginesList);
        }

        /// <summary>
        /// Populate the data grid with information about engine with given fuel type
        /// </summary>
        private void PopulateDataGridViewGetEnginesByFuelType()
        {
            dataGridView.Rows.Clear();
            EngineBusiness engineBusiness = new EngineBusiness();
            var enginesList = engineBusiness.GetEnginesByFuelType(txtGet.Text);
            DataPopulator(enginesList);
        }

        /// <summary>
        /// Populate the data grid with information about engine with given displacement
        /// </summary>
        private void PopulateDataGridViewGetEnginesByDisplacement()
        {
            dataGridView.Rows.Clear();
            EngineBusiness engineBusiness = new EngineBusiness();
            int.TryParse(txtGet.Text, out int displacement);
            var enginesList = engineBusiness.GetEnginesByDisplacement(displacement);
            DataPopulator(enginesList);
        }

        /// <summary>
        /// Populate the data grid with information about engines with displacement smaller than given
        /// </summary>
        private void PopulateDataGridViewGetEnginesWithLowerDisplacement()
        {
            dataGridView.Rows.Clear();
            EngineBusiness engineBusiness = new EngineBusiness();
            int.TryParse(txtGet.Text, out int displacement);
            var enginesList = engineBusiness.GetEnginesWithLowerDisplacement(displacement);
            DataPopulator(enginesList);
        }

        /// <summary>
        /// Populate the data grid with information about engines with displacement larger than given
        /// </summary>
        private void PopulateDataGridViewGetEnginesWithHigherDisplacement()
        {
            dataGridView.Rows.Clear();
            EngineBusiness engineBusiness = new EngineBusiness();
            int.TryParse(txtGet.Text, out int displacement);
            var enginesList = engineBusiness.GetEnginesWithHigherDisplacement(displacement);
            DataPopulator(enginesList);
        }

        /// <summary>
        /// Populate the data grid with information about engine with given power
        /// </summary>
        private void PopulateDataGridViewGetEnginesByPower()
        {
            dataGridView.Rows.Clear();
            EngineBusiness engineBusiness = new EngineBusiness();
            int.TryParse(txtGet.Text, out int power);
            var enginesList = engineBusiness.GetEnginesByPower(power);
            DataPopulator(enginesList);
        }

        /// <summary>
        /// Populate the data grid with information about engines with less power than given
        /// </summary>
        private void PopulateDataGridViewGetEnginesWithLowerPower()
        {
            dataGridView.Rows.Clear();
            EngineBusiness engineBusiness = new EngineBusiness();
            int.TryParse(txtGet.Text, out int power);
            var enginesList = engineBusiness.GetEnginesWithLowerPower(power);
            DataPopulator(enginesList);
        }

        /// <summary>
        /// Populate the data grid with information about engines with more power than given
        /// </summary>
        private void PopulateDataGridViewGetEnginesWithHigherPower()
        {
            dataGridView.Rows.Clear();
            EngineBusiness engineBusiness = new EngineBusiness();
            int.TryParse(txtGet.Text, out int power);
            var enginesList = engineBusiness.GetEnginesWithHigherPower(power);
            DataPopulator(enginesList);
        }

        /// <summary>
        /// Populate the data grid with information about engine with given economy
        /// </summary>
        private void PopulateDataGridViewGetEnginesByEconomyPerHundredKm()
        {
            dataGridView.Rows.Clear();
            EngineBusiness engineBusiness = new EngineBusiness();
            decimal.TryParse(txtGet.Text, out decimal economy);
            var enginesList = engineBusiness.GetEnginesByEconomyPerHundredKm(economy);
            DataPopulator(enginesList);
        }

        /// <summary>
        /// Populate the data grid with information about engines with worse economy than given
        /// </summary>
        private void PopulateDataGridViewGetEnginesWithLowerEconomyPerHundredKm()
        {
            dataGridView.Rows.Clear();
            EngineBusiness engineBusiness = new EngineBusiness();
            decimal.TryParse(txtGet.Text, out decimal economy);
            var enginesList = engineBusiness.GetEnginesWithLowerEconomyPerHundredKm(economy);
            DataPopulator(enginesList);
        }

        /// <summary>
        /// Populate the data grid with information about engines with better economy than given
        /// </summary>
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

        /// <summary>
        /// Populate the data grid with information sorted by engines' power in ascending order
        /// </summary>
        private void PopulateDataGridViewSortEnginesByPowerAscending()
        {
            dataGridView.Rows.Clear();
            EngineBusiness engineBusiness = new EngineBusiness();
            var enginesList = engineBusiness.SortEnginesByPowerAscending();
            DataPopulator(enginesList);
        }

        /// <summary>
        /// Populate the data grid with information sorted by engines' power in descending order
        /// </summary>
        private void PopulateDataGridViewSortEnginesByPowerDescending()
        {
            dataGridView.Rows.Clear();
            EngineBusiness engineBusiness = new EngineBusiness();
            var enginesList = engineBusiness.SortEnginesByPowerDescending();
            DataPopulator(enginesList);
        }

        /// <summary>
        /// Populate the data grid with information sorted by engines' economy in ascending order
        /// </summary>
        private void PopulateDataGridViewSortEnginesByEconomyPerHundredKmAscending()
        {
            dataGridView.Rows.Clear();
            EngineBusiness engineBusiness = new EngineBusiness();
            var enginesList = engineBusiness.SortEnginesByEconomyPerHundredKmAscending();
            DataPopulator(enginesList);
        }

        /// <summary>
        /// Populate the data grid with information sorted by engines' economy in descending order
        /// </summary>
        private void PopulateDataGridViewSortEnginesByEconomyPerHundredKmDescending()
        {
            dataGridView.Rows.Clear();
            EngineBusiness engineBusiness = new EngineBusiness();
            var enginesList = engineBusiness.SortEnginesByEconomyPerHundredKmDescending();
            DataPopulator(enginesList);
        }

        /// <summary>
        /// Populate the data grid with information sorted by engines' displacement in ascending order
        /// </summary>
        private void PopulateDataGridViewSortEnginesByDisplacementAscending()
        {
            dataGridView.Rows.Clear();
            EngineBusiness engineBusiness = new EngineBusiness();
            var enginesList = engineBusiness.SortEnginesByDisplacementAscending();
            DataPopulator(enginesList);
        }

        /// <summary>
        /// Populate the data grid with information sorted by engines' displacement in descending order
        /// </summary>
        private void PopulateDataGridViewSortEnginesByDisplacementDescending()
        {
            dataGridView.Rows.Clear();
            EngineBusiness engineBusiness = new EngineBusiness();
            var enginesList = engineBusiness.SortEnginesByDisplacementDescending();
            DataPopulator(enginesList);
        }

        /// <summary>
        /// Populate the data grid with information sorted by engines' name in ascending order
        /// </summary>
        private void PopulateDataGridViewSortEnginesByNameAscending()
        {
            dataGridView.Rows.Clear();
            EngineBusiness engineBusiness = new EngineBusiness();
            var enginesList = engineBusiness.SortEnginesByNameAscending();
            DataPopulator(enginesList);
        }

        /// <summary>
        /// Populate the data grid with information sorted by engines' name in descending order
        /// </summary>
        private void PopulateDataGridViewSortEnginesByNameDescending()
        {
            dataGridView.Rows.Clear();
            EngineBusiness engineBusiness = new EngineBusiness();
            var enginesList = engineBusiness.SortEnginesByNameDescending();
            DataPopulator(enginesList);
        }

        /// <summary>
        /// Populate the data grid with information sorted by engines' fuel type
        /// </summary>
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
            engine.FuelType = FuelBGTtoENG(txtFuelType.Text);
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

        /// <summary>
        /// Update the input text boxes with information for a selected engine
        /// </summary>
        /// <param name="Id">The ID of a selected engine</param>
        private void UpdateTextBoxes(int Id)
        {
            EngineBusiness engineBusiness = new EngineBusiness();
            Engine engine = engineBusiness.GetEngineById(Id);
            txtDisplacement.Text = engine.Displacement.ToString();
            txtEconomy.Text = engine.EconomyPerHundredKm.ToString();
            txtFuelType.Text = FuelENGToBG(engine.FuelType);
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

        /// <summary>
        /// Pull edited information from the input text boxes to an instance of a engine
        /// </summary>
        /// <returns>Returns an engine with edited information</returns>
        private Engine GetEditedEngine()
        {
            Engine engine = new Engine();

            engine.Id = editId;

            engine.Name = txtName.Text;
            engine.FuelType = FuelBGTtoENG(txtFuelType.Text);
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

        /// <summary>
        /// Convert engine's fuel from Bulgarian to English
        /// </summary>
        /// <param name="fuel">Engine's fuel in Bulgarian</param>
        /// <returns>Returns engine's fuel in English</returns>
        private string FuelBGTtoENG(string fuel)
        {
            if (fuel == "Бензин")
            {
                return "Gasoline";
            }
            else if (fuel == "Дизел")
            {
                return "Diesel";
            }
            else if (fuel == "Газ")
            {
                return "LPG";
            }
            else
            {
                return "Electricity";
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
        //Buttons + attached//

        //Data populators//

        /// <summary>
        /// Populate the data grid with information about engine
        /// </summary>
        /// <param name="cars">A list of engines used to populate the data grid</param>
        private void DataPopulator(List<Engine> engines)
        {
            foreach (var engine in engines)
            {
                EngineBusiness engineBusiness = new EngineBusiness();
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
        /// Populate the data grid with information for a single engine
        /// </summary>
        /// <param name="engine">A single engine used to populate the data grid</param>
        private void DataPopulatorSingle(Engine engine)
        {
            EngineBusiness engineBusiness = new EngineBusiness();
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
        //Data populators//

        //FormatLogic//

        /// <summary>
        /// Setup a data grid for engines
        /// </summary>
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

        /// <summary>
        /// Clear the input text boxes
        /// </summary>
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
