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

        /// <summary>
        /// Populate the data grid with information about all existing customers in the database
        /// </summary>
        private void PopulateDataGridViewDefault()
        {
            dataGridView.Rows.Clear();
            CustomerBusiness customerBusiness = new CustomerBusiness();
            var customersList = customerBusiness.GetAllCustomers();
            DataPopulator(customersList);
        }

        /// <summary>
        /// Populate the data grid with information about customer with given customer Id
        /// </summary>
        private void PopulateDataGridViewGetCustomerById()
        {
            dataGridView.Rows.Clear();
            CustomerBusiness customerBusiness = new CustomerBusiness();
            int.TryParse(txtGet.Text, out int customerId);
            var customer = customerBusiness.GetCustomerById(customerId);
            DataPopulatorSingle(customer);
        }

        /// <summary>
        /// Populate the data grid with information about customers with given town Id
        /// </summary>
        private void PopulateDataGridViewGetCustomerByTownId()
        {
            dataGridView.Rows.Clear();
            CustomerBusiness customerBusiness = new CustomerBusiness();
            int.TryParse(txtGet.Text, out int townId);
            var customersList = customerBusiness.GetCustomersByTownId(townId);
            DataPopulator(customersList);
        }

        /// <summary>
        /// Populate the data grid with information about customers with given town Id
        /// </summary>
        private void PopulateDataGridViewGetCustomersByTownName()
        {
            dataGridView.Rows.Clear();
            CustomerBusiness customerBusiness = new CustomerBusiness();
            var customersList = customerBusiness.GetCustomersByTownName(txtGet.Text);
            DataPopulator(customersList);
        }

        /// <summary>
        /// Populate the data grid with information about customers with given first name
        /// </summary>
        private void PopulateDataGridViewGetCustomersByFirstName()
        {
            dataGridView.Rows.Clear();
            CustomerBusiness customerBusiness = new CustomerBusiness();
            var customersList = customerBusiness.GetCustomersByFirstName(txtGet.Text);
            DataPopulator(customersList);
        }

        /// <summary>
        /// Populate the data grid with information about customers with given last name
        /// </summary>
        private void PopulateDataGridViewGetCustomersByLastName()
        {
            dataGridView.Rows.Clear();
            CustomerBusiness customerBusiness = new CustomerBusiness();
            var customersList = customerBusiness.GetCustomersByLastName(txtGet.Text);
            DataPopulator(customersList);
        }
        //Get logic//

        //Sort logic//

        /// <summary>
        /// Populate the data grid with information sorted by customers' both names in ascending order
        /// </summary>
        private void PopulateDataGridViewSortCustomerByBothNamesAscending()
        {
            dataGridView.Rows.Clear();
            CustomerBusiness customerBusiness = new CustomerBusiness();
            var customersList = customerBusiness.SortCustomerByBothNamesAscending();
            DataPopulator(customersList);
        }

        /// <summary>
        /// Populate the data grid with information sorted by customers' both names in descending order
        /// </summary>
        private void PopulateDataGridViewSortCustomerByBothNamesDescending()
        {
            dataGridView.Rows.Clear();
            CustomerBusiness customerBusiness = new CustomerBusiness();
            var customersList = customerBusiness.SortCustomerByBothNamesDescending();
            DataPopulator(customersList);
        }

        /// <summary>
        /// Populate the data grid with information sorted by customers' first name in ascending order
        /// </summary>
        private void PopulateDataGridViewSortCustomerByFirstNameAscending()
        {
            dataGridView.Rows.Clear();
            CustomerBusiness customerBusiness = new CustomerBusiness();
            var customersList = customerBusiness.SortCustomersByFirstNameAscending();
            DataPopulator(customersList);
        }

        /// <summary>
        /// Populate the data grid with information sorted by customers' first name in descending order
        /// </summary>
        private void PopulateDataGridViewSortCustomerByFirstNameDescending()
        {
            dataGridView.Rows.Clear();
            CustomerBusiness customerBusiness = new CustomerBusiness();
            var customersList = customerBusiness.SortCustomersByFirstNameDescending();
            DataPopulator(customersList);
        }

        /// <summary>
        /// Populate the data grid with information sorted by customers' last name in ascending order
        /// </summary>
        private void PopulateDataGridViewSortCustomerByLastNameAscending()
        {
            dataGridView.Rows.Clear();
            CustomerBusiness customerBusiness = new CustomerBusiness();
            var customersList = customerBusiness.SortCustomersByLastNameAscending();
            DataPopulator(customersList);
        }

        /// <summary>
        /// Populate the data grid with information sorted by customers' last name in descending order
        /// </summary>
        private void PopulateDataGridViewSortCustomerByLastNameDescending()
        {
            dataGridView.Rows.Clear();
            CustomerBusiness customerBusiness = new CustomerBusiness();
            var customersList = customerBusiness.SortCustomersByLastNameDescending();
            DataPopulator(customersList);
        }

        /// <summary>
        /// Populate the data grid with information sorted by customers' town name in ascending order
        /// </summary>
        private void PopulateDataGridViewSortCustomerByTownNameAscending()
        {
            dataGridView.Rows.Clear();
            CustomerBusiness customerBusiness = new CustomerBusiness();
            var customersList = customerBusiness.SortCustomersByTownNameAscending();
            DataPopulator(customersList);
        }

        /// <summary>
        /// Populate the data grid with information sorted by customers' town name in descending order
        /// </summary>
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

        /// <summary>
        /// Update the input text boxes with information for a selected customer
        /// </summary>
        /// <param name="Id">The ID of a selected customer</param>
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

        /// <summary>
        /// Pull edited information from the input text boxes to an instance of a customer
        /// </summary>
        /// <returns>Returns a customer with edited information</returns>
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

        /// <summary>
        /// Populate the data grid with information about customers
        /// </summary>
        /// <param name="customers">A list of customers used to populate the data grid</param>
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

        /// <summary>
        /// Populate the data grid with information for a single customer
        /// </summary>
        /// <param name="customer">A single customer used to populate the data grid</param>
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

        /// <summary>
        /// Setup a data grid for customers
        /// </summary>
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
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtTown.Text = "";
        }
        //FormatLogic//
    }
}
