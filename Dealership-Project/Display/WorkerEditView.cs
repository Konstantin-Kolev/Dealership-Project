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
    public partial class WorkerEditView : Form
    {
        private int editId = 0;

        public WorkerEditView()
        {
            InitializeComponent();
        }

        private void WorkerEditView_Load(object sender, EventArgs e)
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
            WorkerBusiness workerBusiness = new WorkerBusiness();
            var workersList = workerBusiness.GetAllWorkers();
            DataPopulator(workersList);
        }

        private void PopulateDataGridViewGetWorkerById()
        {
            dataGridView.Rows.Clear();
            WorkerBusiness workerBusiness = new WorkerBusiness();
            int.TryParse(txtGet.Text, out int workerId);
            var worker = workerBusiness.GetWorkerById(workerId);
            DataPopulatorSingle(worker);
        }

        private void PopulateDataGridViewGetWorkersByDealershipId()
        {
            dataGridView.Rows.Clear();
            WorkerBusiness workerBusiness = new WorkerBusiness();
            int.TryParse(txtGet.Text, out int dealershipId);
            var workersList = workerBusiness.GetWorkersByDealershipId(dealershipId);
            DataPopulator(workersList);
        }

        private void PopulateDataGridViewGetWorkersByFirstName()
        {
            dataGridView.Rows.Clear();
            WorkerBusiness workerBusiness = new WorkerBusiness();
            var workersList = workerBusiness.GetWorkersByFirstName(txtGet.Text);
            DataPopulator(workersList);
        }

        private void PopulateDataGridViewGetWorkersByLastName()
        {
            dataGridView.Rows.Clear();
            WorkerBusiness workerBusiness = new WorkerBusiness();
            var workersList = workerBusiness.GetWorkersByLastName(txtGet.Text);
            DataPopulator(workersList);
        }

        private void PopulateDataGridViewGetWorkersByPosition()
        {
            dataGridView.Rows.Clear();
            WorkerBusiness workerBusiness = new WorkerBusiness();
            var workersList = workerBusiness.GetWorkersByPosition(txtGet.Text);
            DataPopulator(workersList);
        }

        private void PopulateDataGridViewGetWorkersBySalary()
        {
            dataGridView.Rows.Clear();
            WorkerBusiness workerBusiness = new WorkerBusiness();
            decimal.TryParse(txtGet.Text, out decimal salary);
            var workersList = workerBusiness.GetWorkersBySalary(salary);
            DataPopulator(workersList);
        }

        private void PopulateDataGridViewGetWorkersWithHigherSalary()
        {
            dataGridView.Rows.Clear();
            WorkerBusiness workerBusiness = new WorkerBusiness();
            decimal.TryParse(txtGet.Text, out decimal salary);
            var workersList = workerBusiness.GetWorkersWithHigherSalary(salary);
            DataPopulator(workersList);
        }

        private void PopulateDataGridViewGetWorkersWithLowerSalary()
        {
            dataGridView.Rows.Clear();
            WorkerBusiness workerBusiness = new WorkerBusiness();
            decimal.TryParse(txtGet.Text, out decimal salary);
            var workersList = workerBusiness.GetWorkersWithLowerSalary(salary);
            DataPopulator(workersList);
        }
        //Get logic//

        //Sort logic//
        private void PopulateDataGridViewSortWorkersByBothNamesAscending()
        {
            dataGridView.Rows.Clear();
            WorkerBusiness workerBusiness = new WorkerBusiness();
            var workersList = workerBusiness.SortWorkersByBothNamesAscending();
            DataPopulator(workersList);
        }

        private void PopulateDataGridViewSortWorkersByBothNamesDescending()
        {
            dataGridView.Rows.Clear();
            WorkerBusiness workerBusiness = new WorkerBusiness();
            var workersList = workerBusiness.SortWorkersByBothNamesDescending();
            DataPopulator(workersList);
        }

        private void PopulateDataGridViewSortWorkersByCarDealership()
        {
            dataGridView.Rows.Clear();
            WorkerBusiness workerBusiness = new WorkerBusiness();
            var workersList = workerBusiness.SortWorkersByCarDealership();
            DataPopulator(workersList);
        }

        private void PopulateDataGridViewSortWorkersByFirstNameAscending()
        {
            dataGridView.Rows.Clear();
            WorkerBusiness workerBusiness = new WorkerBusiness();
            var workersList = workerBusiness.SortWorkersByFirstNameAscending();
            DataPopulator(workersList);
        }

        private void PopulateDataGridViewSortWorkersByFirstNameDescending()
        {
            dataGridView.Rows.Clear();
            WorkerBusiness workerBusiness = new WorkerBusiness();
            var workersList = workerBusiness.SortWorkersByFirstNameDescending();
            DataPopulator(workersList);
        }

        private void PopulateDataGridViewSortWorkersByLastNameAscending()
        {
            dataGridView.Rows.Clear();
            WorkerBusiness workerBusiness = new WorkerBusiness();
            var workersList = workerBusiness.SortWorkersByLastNameAscending();
            DataPopulator(workersList);
        }

        private void PopulateDataGridViewSortWorkersByLastNameDescending()
        {
            dataGridView.Rows.Clear();
            WorkerBusiness workerBusiness = new WorkerBusiness();
            var workersList = workerBusiness.SortWorkersByLastNameDescending();
            DataPopulator(workersList);
        }

        private void PopulateDataGridViewSortWorkersByPosition()
        {
            dataGridView.Rows.Clear();
            WorkerBusiness workerBusiness = new WorkerBusiness();
            var workersList = workerBusiness.SortWorkersByPosition();
            DataPopulator(workersList);
        }

        private void PopulateDataGridViewSortWorkersBySalaryAscending()
        {
            dataGridView.Rows.Clear();
            WorkerBusiness workerBusiness = new WorkerBusiness();
            var workersList = workerBusiness.SortWorkersBySalaryAscending();
            DataPopulator(workersList);
        }

        private void PopulateDataGridViewSortWorkersBySalaryDescending()
        {
            dataGridView.Rows.Clear();
            WorkerBusiness workerBusiness = new WorkerBusiness();
            var workersList = workerBusiness.SortWorkersBySalaryDescending();
            DataPopulator(workersList);
        }
        //Sort logic//
        //Main logic//

        //cbGet and cbSort//
        private void cbGet_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbGet.SelectedIndex;
            switch (index)
            {
                case 0: SetupDataGridView(); PopulateDataGridViewGetWorkerById(); break;
                case 1: SetupDataGridView(); PopulateDataGridViewGetWorkersByDealershipId(); break;
                case 2: SetupDataGridView(); PopulateDataGridViewGetWorkersByFirstName(); break;
                case 3: SetupDataGridView(); PopulateDataGridViewGetWorkersByLastName(); break;
                case 4: SetupDataGridView(); PopulateDataGridViewGetWorkersByPosition(); break;
                case 5: SetupDataGridView(); PopulateDataGridViewGetWorkersBySalary(); break;
                case 6: SetupDataGridView(); PopulateDataGridViewGetWorkersWithLowerSalary(); break;
                case 7: SetupDataGridView(); PopulateDataGridViewGetWorkersWithHigherSalary(); break;
            }
        }

        private void cbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbSort.SelectedIndex;
            switch (index)
            {
                case 0: SetupDataGridView(); PopulateDataGridViewSortWorkersByBothNamesAscending(); break;
                case 1: SetupDataGridView(); PopulateDataGridViewSortWorkersByBothNamesDescending(); break;
                case 2: SetupDataGridView(); PopulateDataGridViewSortWorkersByFirstNameAscending(); break;
                case 3: SetupDataGridView(); PopulateDataGridViewSortWorkersByFirstNameDescending(); break;
                case 4: SetupDataGridView(); PopulateDataGridViewSortWorkersByLastNameAscending(); break;
                case 5: SetupDataGridView(); PopulateDataGridViewSortWorkersByLastNameDescending(); break;
                case 6: SetupDataGridView(); PopulateDataGridViewSortWorkersBySalaryAscending(); break;
                case 7: SetupDataGridView(); PopulateDataGridViewSortWorkersBySalaryDescending(); break;
                case 8: SetupDataGridView(); PopulateDataGridViewSortWorkersByPosition(); break;
                case 9: SetupDataGridView(); PopulateDataGridViewSortWorkersByCarDealership(); break;
            }
        }
        //cbGet and cbSort//

        //Buttons + attached logic//
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Worker worker = new Worker
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Position = txtPosition.Text
            };
            decimal.TryParse(txtSalary.Text, out decimal salary);
            worker.Salary = salary;
            int.TryParse(txtDealership.Text, out int dealershipId);
            worker.CarDealershipId = dealershipId;

            WorkerBusiness workerBusiness = new WorkerBusiness();
            workerBusiness.Add(worker);
            PopulateDataGridViewDefault();
            ClearTextBoxes();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                var worker = dataGridView.SelectedRows[0].Cells;
                var workerId = int.Parse(worker[0].Value.ToString());
                editId = workerId;
                UpdateTextBoxes(workerId);
                ToggleSaveUpdate();
                DisableSelect();
            }
        }

        private void UpdateTextBoxes(int Id)
        {
            WorkerBusiness workerBusiness = new WorkerBusiness();
            Worker worker = workerBusiness.GetWorkerById(Id);

            txtFirstName.Text = worker.FirstName;
            txtLastName.Text = worker.LastName;
            txtPosition.Text = worker.Position;
            txtSalary.Text = worker.Salary.ToString();
            txtDealership.Text = worker.CarDealershipId.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Worker worker = GetEditedWorker();
            WorkerBusiness workerBusiness = new WorkerBusiness();
            workerBusiness.Update(worker);
            PopulateDataGridViewDefault();
            ResetSelect();
            ToggleSaveUpdate();
            ClearTextBoxes();
        }

        private Worker GetEditedWorker()
        {
            Worker worker = new Worker();

            worker.Id = editId;
            worker.FirstName = txtFirstName.Text;
            worker.LastName = txtLastName.Text;
            worker.Position = txtPosition.Text;
            decimal.TryParse(txtSalary.Text, out decimal salary);
            worker.Salary = salary;
            int.TryParse(txtDealership.Text, out int dealershipId);
            worker.CarDealershipId = dealershipId;

            return worker;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                var worker = dataGridView.SelectedRows[0].Cells;
                var workerId = int.Parse(worker[0].Value.ToString());
                WorkerBusiness workerBusiness = new WorkerBusiness();
                workerBusiness.Delete(workerId);
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
        //Buttons + attached logic//

        //Data populators//
        private void DataPopulator(List<Worker> workers)
        {
            foreach (var worker in workers)
            {
                WorkerBusiness workerBusiness = new WorkerBusiness();
                string[] row =
                {
                    worker.Id.ToString(),
                    worker.FirstName,
                    worker.LastName,
                    worker.Position,
                    worker.Salary.ToString(),
                    workerBusiness.GetDealershipName(worker.CarDealershipId)
                };
                dataGridView.Rows.Add(row);
            }
        }

        private void DataPopulatorSingle(Worker worker)
        {
            WorkerBusiness workerBusiness = new WorkerBusiness();
            string[] row =
            {
                worker.Id.ToString(),
                worker.FirstName,
                worker.LastName,
                worker.Position,
                worker.Salary.ToString(),
                workerBusiness.GetDealershipName(worker.CarDealershipId)
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
            dataGridView.Columns[2].Name = "Фамилия";
            dataGridView.Columns[3].Name = "Длъжност";
            dataGridView.Columns[4].Name = "Заплата";
            dataGridView.Columns[5].Name = "Автокъща";


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
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtDealership.Text = "";
            txtPosition.Text = "";
            txtSalary.Text = "";
        }
        //FormatLogic//
    }
}
