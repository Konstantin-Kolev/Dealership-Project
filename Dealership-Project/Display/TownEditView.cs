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

namespace Display
{
    public partial class TownEditView : Form
    {
        private TownBusiness townBusiness = new TownBusiness();

        public TownEditView()
        {
            InitializeComponent();
        }

        private void TownEditView_Load(object sender, EventArgs e)
        {

        }

        private void UpdateGrid()
        {
            dataGridTowns.DataSource = townBusiness.GetAllTowns();
            dataGridTowns.ReadOnly = true;
            dataGridTowns.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
}
