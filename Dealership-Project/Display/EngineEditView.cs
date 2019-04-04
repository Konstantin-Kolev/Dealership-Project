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
        public EngineEditView()
        {
            InitializeComponent();
        }

        private void EngineEditView_Load(object sender, EventArgs e)
        {
            dataGridView.ReadOnly = true;
            SetupDataGridView();
            PopulateDataGridViewDefault();
        }

        private void PopulateDataGridViewDefault()
        {
            dataGridView.Rows.Clear();
            EngineBusiness engineBusiness = new EngineBusiness();
            var enginesList = engineBusiness.GetAllEngines();
            DataPopulator(enginesList);
        }

        private void DataPopulator(List<Engine> engines)
        {
            foreach (var engine in engines)
            {
                EngineBusiness engineBusiness = new EngineBusiness();
                string[] row =
                {
                    engine.Name,
                    engine.FuelType,
                    engine.Power.ToString(),
                    engine.Displacement.ToString(),
                    engine.EconomyPerHundredKm.ToString()
                };
                dataGridView.Rows.Add(row);
            }
        }

        private void SetupDataGridView()
        {
            dataGridView.ColumnCount = 5;

            dataGridView.Columns[0].Name = "Име";
            dataGridView.Columns[1].Name = "Гориво";
            dataGridView.Columns[2].Name = "Мощност";
            dataGridView.Columns[3].Name = "Работен обем";
            dataGridView.Columns[4].Name = "Разход на 100 километра";

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
    }
}
