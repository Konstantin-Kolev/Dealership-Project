namespace Display
{
    partial class CarEditView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarEditView));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtManufacturer = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtDealership = new System.Windows.Forms.TextBox();
            this.cbGet = new System.Windows.Forms.ComboBox();
            this.lblSort = new System.Windows.Forms.Label();
            this.cbSort = new System.Windows.Forms.ComboBox();
            this.lblGet = new System.Windows.Forms.Label();
            this.txtGet = new System.Windows.Forms.TextBox();
            this.txtEngine = new System.Windows.Forms.TextBox();
            this.txtGears = new System.Windows.Forms.TextBox();
            this.txtTransmission = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtOwner = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblManufacturer = new System.Windows.Forms.Label();
            this.lblEngine = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblTransmission = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblDealership = new System.Windows.Forms.Label();
            this.lblGears = new System.Windows.Forms.Label();
            this.lblOwner = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnOpenHelper = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridView, "dataGridView");
            this.dataGridView.Name = "dataGridView";
            // 
            // btnAdd
            // 
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtManufacturer
            // 
            resources.ApplyResources(this.txtManufacturer, "txtManufacturer");
            this.txtManufacturer.Name = "txtManufacturer";
            // 
            // txtModel
            // 
            resources.ApplyResources(this.txtModel, "txtModel");
            this.txtModel.Name = "txtModel";
            // 
            // txtDealership
            // 
            resources.ApplyResources(this.txtDealership, "txtDealership");
            this.txtDealership.Name = "txtDealership";
            // 
            // cbGet
            // 
            this.cbGet.FormattingEnabled = true;
            this.cbGet.Items.AddRange(new object[] {
            resources.GetString("cbGet.Items"),
            resources.GetString("cbGet.Items1"),
            resources.GetString("cbGet.Items2"),
            resources.GetString("cbGet.Items3"),
            resources.GetString("cbGet.Items4"),
            resources.GetString("cbGet.Items5"),
            resources.GetString("cbGet.Items6"),
            resources.GetString("cbGet.Items7"),
            resources.GetString("cbGet.Items8"),
            resources.GetString("cbGet.Items9"),
            resources.GetString("cbGet.Items10"),
            resources.GetString("cbGet.Items11"),
            resources.GetString("cbGet.Items12"),
            resources.GetString("cbGet.Items13"),
            resources.GetString("cbGet.Items14"),
            resources.GetString("cbGet.Items15"),
            resources.GetString("cbGet.Items16"),
            resources.GetString("cbGet.Items17"),
            resources.GetString("cbGet.Items18")});
            resources.ApplyResources(this.cbGet, "cbGet");
            this.cbGet.Name = "cbGet";
            this.cbGet.SelectedIndexChanged += new System.EventHandler(this.cbGet_SelectedIndexChanged);
            // 
            // lblSort
            // 
            resources.ApplyResources(this.lblSort, "lblSort");
            this.lblSort.Name = "lblSort";
            // 
            // cbSort
            // 
            this.cbSort.FormattingEnabled = true;
            this.cbSort.Items.AddRange(new object[] {
            resources.GetString("cbSort.Items"),
            resources.GetString("cbSort.Items1"),
            resources.GetString("cbSort.Items2"),
            resources.GetString("cbSort.Items3"),
            resources.GetString("cbSort.Items4"),
            resources.GetString("cbSort.Items5"),
            resources.GetString("cbSort.Items6"),
            resources.GetString("cbSort.Items7"),
            resources.GetString("cbSort.Items8"),
            resources.GetString("cbSort.Items9"),
            resources.GetString("cbSort.Items10"),
            resources.GetString("cbSort.Items11"),
            resources.GetString("cbSort.Items12"),
            resources.GetString("cbSort.Items13"),
            resources.GetString("cbSort.Items14"),
            resources.GetString("cbSort.Items15"),
            resources.GetString("cbSort.Items16")});
            resources.ApplyResources(this.cbSort, "cbSort");
            this.cbSort.Name = "cbSort";
            this.cbSort.SelectedIndexChanged += new System.EventHandler(this.cbSort_SelectedIndexChanged);
            // 
            // lblGet
            // 
            resources.ApplyResources(this.lblGet, "lblGet");
            this.lblGet.Name = "lblGet";
            // 
            // txtGet
            // 
            resources.ApplyResources(this.txtGet, "txtGet");
            this.txtGet.Name = "txtGet";
            // 
            // txtEngine
            // 
            resources.ApplyResources(this.txtEngine, "txtEngine");
            this.txtEngine.Name = "txtEngine";
            // 
            // txtGears
            // 
            resources.ApplyResources(this.txtGears, "txtGears");
            this.txtGears.Name = "txtGears";
            // 
            // txtTransmission
            // 
            resources.ApplyResources(this.txtTransmission, "txtTransmission");
            this.txtTransmission.Name = "txtTransmission";
            // 
            // txtColor
            // 
            resources.ApplyResources(this.txtColor, "txtColor");
            this.txtColor.Name = "txtColor";
            // 
            // txtOwner
            // 
            resources.ApplyResources(this.txtOwner, "txtOwner");
            this.txtOwner.Name = "txtOwner";
            // 
            // txtPrice
            // 
            resources.ApplyResources(this.txtPrice, "txtPrice");
            this.txtPrice.Name = "txtPrice";
            // 
            // lblManufacturer
            // 
            resources.ApplyResources(this.lblManufacturer, "lblManufacturer");
            this.lblManufacturer.Name = "lblManufacturer";
            // 
            // lblEngine
            // 
            resources.ApplyResources(this.lblEngine, "lblEngine");
            this.lblEngine.Name = "lblEngine";
            // 
            // lblColor
            // 
            resources.ApplyResources(this.lblColor, "lblColor");
            this.lblColor.Name = "lblColor";
            // 
            // lblPrice
            // 
            resources.ApplyResources(this.lblPrice, "lblPrice");
            this.lblPrice.Name = "lblPrice";
            // 
            // lblTransmission
            // 
            resources.ApplyResources(this.lblTransmission, "lblTransmission");
            this.lblTransmission.Name = "lblTransmission";
            // 
            // lblModel
            // 
            resources.ApplyResources(this.lblModel, "lblModel");
            this.lblModel.Name = "lblModel";
            // 
            // lblDealership
            // 
            resources.ApplyResources(this.lblDealership, "lblDealership");
            this.lblDealership.Name = "lblDealership";
            // 
            // lblGears
            // 
            resources.ApplyResources(this.lblGears, "lblGears");
            this.lblGears.Name = "lblGears";
            // 
            // lblOwner
            // 
            resources.ApplyResources(this.lblOwner, "lblOwner");
            this.lblOwner.Name = "lblOwner";
            // 
            // btnDelete
            // 
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            resources.ApplyResources(this.btnUpdate, "btnUpdate");
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReset
            // 
            resources.ApplyResources(this.btnReset, "btnReset");
            this.btnReset.Name = "btnReset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnOpenHelper
            // 
            resources.ApplyResources(this.btnOpenHelper, "btnOpenHelper");
            this.btnOpenHelper.Name = "btnOpenHelper";
            this.btnOpenHelper.UseVisualStyleBackColor = true;
            this.btnOpenHelper.Click += new System.EventHandler(this.btnOpenHelper_Click);
            // 
            // pictureBox
            // 
            resources.ApplyResources(this.pictureBox, "pictureBox");
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.TabStop = false;
            // 
            // CarEditView
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnOpenHelper);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblOwner);
            this.Controls.Add(this.lblGears);
            this.Controls.Add(this.lblDealership);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblTransmission);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblEngine);
            this.Controls.Add(this.lblManufacturer);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtOwner);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.txtTransmission);
            this.Controls.Add(this.txtGears);
            this.Controls.Add(this.txtEngine);
            this.Controls.Add(this.txtGet);
            this.Controls.Add(this.lblGet);
            this.Controls.Add(this.cbSort);
            this.Controls.Add(this.lblSort);
            this.Controls.Add(this.cbGet);
            this.Controls.Add(this.txtDealership);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtManufacturer);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CarEditView";
            this.Load += new System.EventHandler(this.CarEditView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtManufacturer;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtDealership;
        private System.Windows.Forms.ComboBox cbGet;
        private System.Windows.Forms.Label lblSort;
        private System.Windows.Forms.ComboBox cbSort;
        private System.Windows.Forms.Label lblGet;
        private System.Windows.Forms.TextBox txtGet;
        private System.Windows.Forms.TextBox txtEngine;
        private System.Windows.Forms.TextBox txtGears;
        private System.Windows.Forms.TextBox txtTransmission;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtOwner;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblManufacturer;
        private System.Windows.Forms.Label lblEngine;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblTransmission;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblDealership;
        private System.Windows.Forms.Label lblGears;
        private System.Windows.Forms.Label lblOwner;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnOpenHelper;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}