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
    public partial class CustomerEditView : Form
    {
        private int editId = 0;

        public CustomerEditView()
        {
            InitializeComponent();
        }

        private void CustomerEditView_Load(object sender, EventArgs e)
        {
            dataGridView.ReadOnly = true;
            SetupDataGridView();
            dataGridView.Columns[0].Visible = false;
            dataGridView.Columns[4].Visible = false;
            PopulateDataGridViewDefault();
        }

        //Main logic//
        //Get logic//
        private void PopulateDataGridViewDefault()
        {
            dataGridView.Rows.Clear();
            CustomerBusiness customerBusiness = new CustomerBusiness();
            var customersList = customerBusiness.GetAllCustomers();
            DataPopulator(customersList);
        }
        
        private void PopulateDataGridViewGetCustomerById()
        {
            dataGridView.Rows.Clear();
            CustomerBusiness customerBusiness = new CustomerBusiness();
            int.TryParse(txtGet.Text, out int customerId);
            var customer = customerBusiness.GetCustomerById(customerId);
            DataPopulatorSingle(customer);
        }

        private void PopulateDataGridViewGetCustomerByTownId()
        {
            dataGridView.Rows.Clear();
            CustomerBusiness customerBusiness = new CustomerBusiness();
            int.TryParse(txtGet.Text, out int townId);
            var customersList = customerBusiness.GetCustomersByTownId(townId);
            DataPopulator(customersList);
        }

        private void PopulateDataGridViewGetCustomersByTownName()
        {
            dataGridView.Rows.Clear();
            CustomerBusiness customerBusiness = new CustomerBusiness();
            var customersList = customerBusiness.GetCustomersByTownName(txtGet.Text);
            DataPopulator(customersList);
        }

        private void PopulateDataGridViewGetCustomersByFirstName()
        {
            dataGridView.Rows.Clear();
            CustomerBusiness customerBusiness = new CustomerBusiness();
            var customersList = customerBusiness.GetCustomersByFirstName(txtGet.Text);
            DataPopulator(customersList);
        }

        private void PopulateDataGridViewGetCustomersByLastName()
        {
            dataGridView.Rows.Clear();
            CustomerBusiness customerBusiness = new CustomerBusiness();
            var customersList = customerBusiness.GetCustomersByLastName(txtGet.Text);
            DataPopulator(customersList);
        }
        //Get logic//

        //Sort logic//
        private void PopulateDataGridViewSortCustomerByBothNamesAscending()
        {
            dataGridView.Rows.Clear();
            CustomerBusiness customerBusiness = new CustomerBusiness();
            var customersList = customerBusiness.SortCustomerByBothNamesAscending();
            DataPopulator(customersList);
        }

        private void PopulateDataGridViewSortCustomerByBothNamesDescending()
        {
            dataGridView.Rows.Clear();
            CustomerBusiness customerBusiness = new CustomerBusiness();
            var customersList = customerBusiness.SortCustomerByBothNamesDescending();
            DataPopulator(customersList);
        }

        private void PopulateDataGridViewSortCustomerByFirstNameAscending()
        {
            dataGridView.Rows.Clear();
            CustomerBusiness customerBusiness = new CustomerBusiness();
            var customersList = customerBusiness.SortCustomersByFirstNameAscending();
            DataPopulator(customersList);
        }

        private void PopulateDataGridViewSortCustomerByFirstNameDescending()
        {
            dataGridView.Rows.Clear();
            CustomerBusiness customerBusiness = new CustomerBusiness();
            var customersList = customerBusiness.SortCustomersByFirstNameDescending();
            DataPopulator(customersList);
        }

        private void PopulateDataGridViewSortCustomerByLastNameAscending()
        {
            dataGridView.Rows.Clear();
            CustomerBusiness customerBusiness = new CustomerBusiness();
            var customersList = customerBusiness.SortCustomersByLastNameAscending();
            DataPopulator(customersList);
        }

        private void PopulateDataGridViewSortCustomerByLastNameDescending()
        {
            dataGridView.Rows.Clear();
            CustomerBusiness customerBusiness = new CustomerBusiness();
            var customersList = customerBusiness.SortCustomersByLastNameDescending();
            DataPopulator(customersList);
        }

        private void PopulateDataGridViewSortCustomerByTownNameAscending()
        {
            dataGridView.Rows.Clear();
            CustomerBusiness customerBusiness = new CustomerBusiness();
            var customersList = customerBusiness.SortCustomersByTownNameAscending();
            DataPopulator(customersList);
        }

        private void PopulateDataGridViewSortCustomerByTownNameDescending()
        {
            dataGridView.Rows.Clear();
            CustomerBusiness customerBusiness = new CustomerBusiness();
            var customersList = customerBusiness.SortCustomersByTownNameDescending();
            DataPopulator(customersList);
        }
        //Sort logic//
        //Main logic//

        //cbGet and cbSort//
        private void cbGet_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbGet.SelectedIndex;
            switch (index)
            {
                case 0: SetupDataGridView(); PopulateDataGridViewGetCustomerById(); break;
                case 1: SetupDataGridView(); PopulateDataGridViewGetCustomerByTownId(); break;
                case 2: SetupDataGridView(); PopulateDataGridViewGetCustomersByFirstName(); break;
                case 3: SetupDataGridView(); PopulateDataGridViewGetCustomersByLastName(); break;
                case 4: SetupDataGridView(); PopulateDataGridViewGetCustomersByTownName(); break;
            }
        }

        private void cbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbSort.SelectedIndex;
            switch (index)
            {
                case 0: SetupDataGridView(); PopulateDataGridViewSortCustomerByBothNamesAscending(); break;
                case 1: SetupDataGridView(); PopulateDataGridViewSortCustomerByBothNamesDescending(); break;
                case 2: SetupDataGridView(); PopulateDataGridViewSortCustomerByFirstNameAscending(); break;
                case 3: SetupDataGridView(); PopulateDataGridViewSortCustomerByFirstNameDescending(); break;
                case 4: SetupDataGridView(); PopulateDataGridViewSortCustomerByLastNameAscending(); break;
                case 5: SetupDataGridView(); PopulateDataGridViewSortCustomerByLastNameDescending(); break;
                case 6: SetupDataGridView(); PopulateDataGridViewSortCustomerByTownNameAscending(); break;
                case 7: SetupDataGridView(); PopulateDataGridViewSortCustomerByTownNameDescending(); break;
            }
        }
        //cbGet and cbSort//

        //Buttons + attached logic//
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text
            };
            int.TryParse(txtTown.Text, out int townId);
            customer.TownId = townId;

            CustomerBusiness customerBusiness = new CustomerBusiness();
            customerBusiness.Add(customer);
            PopulateDataGridViewDefault();
            ClearTextBoxes();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                var customer = dataGridView.SelectedRows[0].Cells;
                var customerId = int.Parse(customer[0].Value.ToString());
                editId = customerId;
                UpdateTextBoxes(customerId);
                ToggleSaveUpdate();
                DisableSelect();
            }
        }

        private void UpdateTextBoxes(int Id)
        {
            CustomerBusiness customerBusiness = new CustomerBusiness();
            Customer customer = customerBusiness.GetCustomerById(Id);

            txtFirstName.Text = customer.FirstName;
            txtLastName.Text = customer.LastName;
            txtTown.Text = customer.TownId.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Customer customer = GetEditedCustomer();
            CustomerBusiness customerBusiness = new CustomerBusiness();
            customerBusiness.Update(customer);
            PopulateDataGridViewDefault();
            ResetSelect();
            ToggleSaveUpdate();
            ClearTextBoxes();
        }

        private Customer GetEditedCustomer()
        {
            Customer customer = new Customer();

            customer.Id = editId;
            customer.FirstName = txtFirstName.Text;
            customer.LastName = txtLastName.Text;
            int.TryParse(txtTown.Text, out int townId);
            customer.TownId = townId;

            return customer;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                var customer = dataGridView.SelectedRows[0].Cells;
                var customerId = int.Parse(customer[0].Value.ToString());
                CustomerBusiness customerBusiness = new CustomerBusiness();
                customerBusiness.Delete(customerId);
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
        private void DataPopulator(List<Customer> customers)
        {
            foreach (var customer in customers)
            {
                CustomerBusiness customerBusiness = new CustomerBusiness();
                string[] row =
                {
                    customer.Id.ToString(),
                    customer.FirstName,
                    customer.LastName,
                    customerBusiness.GetTownName(customer.TownId),
                    customer.TownId.ToString()
                };
                dataGridView.Rows.Add(row);
            }
        }

        private void DataPopulatorSingle(Customer customer)
        {
            CustomerBusiness customerBusiness = new CustomerBusiness();
            string[] row =
            {
                    customer.Id.ToString(),
                    customer.FirstName,
                    customer.LastName,
                    customerBusiness.GetTownName(customer.TownId),
                    customer.TownId.ToString()
                };
            dataGridView.Rows.Add(row);
        }
        //Data populators//

        //FormatLogic//
        private void SetupDataGridView()
        {
            dataGridView.ColumnCount = 5;

            dataGridView.Columns[0].Name = "ID";
            dataGridView.Columns[1].Name = "Име";
            dataGridView.Columns[2].Name = "Фамилия";
            dataGridView.Columns[3].Name = "Град";
            dataGridView.Columns[4].Name = "ID на град";


            dataGridView.AutoSizeRowsMode =
            DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dataGridView.ColumnHeadersBorderStyle =
            DataGridViewHeaderBorderStyle.Single;
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridView.RowHeadersVisible = false;
            dataGridView.SelectionMode =
            DataGridViewSelectionMode.FullRowSelect;
            dataGridView.MultiSelect = false;

            dataGridView.Columns[4].Visible = false;
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
            txtTown.Text = "";
        }
        //FormatLogic//
    }
}
