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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtManufacturer = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtDealership = new System.Windows.Forms.TextBox();
            this.cbSort = new System.Windows.Forms.ComboBox();
            this.lblSort = new System.Windows.Forms.Label();
            this.cbGet = new System.Windows.Forms.ComboBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(51, 242);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(986, 338);
            this.dataGridView.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(369, 43);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Добави";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.Location = new System.Drawing.Point(51, 45);
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.Size = new System.Drawing.Size(100, 20);
            this.txtManufacturer.TabIndex = 2;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(157, 45);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 20);
            this.txtModel.TabIndex = 3;
            // 
            // txtDealership
            // 
            this.txtDealership.Location = new System.Drawing.Point(263, 45);
            this.txtDealership.Name = "txtDealership";
            this.txtDealership.Size = new System.Drawing.Size(100, 20);
            this.txtDealership.TabIndex = 4;
            // 
            // cbSort
            // 
            this.cbSort.FormattingEnabled = true;
            this.cbSort.Location = new System.Drawing.Point(627, 45);
            this.cbSort.Name = "cbSort";
            this.cbSort.Size = new System.Drawing.Size(121, 21);
            this.cbSort.TabIndex = 5;
            this.cbSort.SelectedIndexChanged += new System.EventHandler(this.cbSort_SelectedIndexChanged);
            // 
            // lblSort
            // 
            this.lblSort.AutoSize = true;
            this.lblSort.Location = new System.Drawing.Point(545, 48);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(76, 13);
            this.lblSort.TabIndex = 6;
            this.lblSort.Text = "Сортиране по";
            // 
            // cbGet
            // 
            this.cbGet.FormattingEnabled = true;
            this.cbGet.Location = new System.Drawing.Point(810, 45);
            this.cbGet.Name = "cbGet";
            this.cbGet.Size = new System.Drawing.Size(121, 21);
            this.cbGet.TabIndex = 7;
            // 
            // lblGet
            // 
            this.lblGet.AutoSize = true;
            this.lblGet.Location = new System.Drawing.Point(754, 48);
            this.lblGet.Name = "lblGet";
            this.lblGet.Size = new System.Drawing.Size(50, 13);
            this.lblGet.TabIndex = 8;
            this.lblGet.Text = "Справки";
            // 
            // txtGet
            // 
            this.txtGet.Location = new System.Drawing.Point(937, 45);
            this.txtGet.Name = "txtGet";
            this.txtGet.Size = new System.Drawing.Size(100, 20);
            this.txtGet.TabIndex = 9;
            // 
            // txtEngine
            // 
            this.txtEngine.Location = new System.Drawing.Point(51, 104);
            this.txtEngine.Name = "txtEngine";
            this.txtEngine.Size = new System.Drawing.Size(100, 20);
            this.txtEngine.TabIndex = 10;
            // 
            // txtGears
            // 
            this.txtGears.Location = new System.Drawing.Point(263, 104);
            this.txtGears.Name = "txtGears";
            this.txtGears.Size = new System.Drawing.Size(100, 20);
            this.txtGears.TabIndex = 11;
            // 
            // txtTransmission
            // 
            this.txtTransmission.Location = new System.Drawing.Point(157, 104);
            this.txtTransmission.Name = "txtTransmission";
            this.txtTransmission.Size = new System.Drawing.Size(100, 20);
            this.txtTransmission.TabIndex = 12;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(51, 166);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(100, 20);
            this.txtColor.TabIndex = 13;
            // 
            // txtOwner
            // 
            this.txtOwner.Location = new System.Drawing.Point(263, 166);
            this.txtOwner.Name = "txtOwner";
            this.txtOwner.Size = new System.Drawing.Size(100, 20);
            this.txtOwner.TabIndex = 14;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(157, 166);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 15;
            // 
            // lblManufacturer
            // 
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.Location = new System.Drawing.Point(48, 29);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(40, 13);
            this.lblManufacturer.TabIndex = 16;
            this.lblManufacturer.Text = "Марка";
            // 
            // lblEngine
            // 
            this.lblEngine.AutoSize = true;
            this.lblEngine.Location = new System.Drawing.Point(48, 88);
            this.lblEngine.Name = "lblEngine";
            this.lblEngine.Size = new System.Drawing.Size(56, 13);
            this.lblEngine.TabIndex = 17;
            this.lblEngine.Text = "Двигател";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(48, 150);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(32, 13);
            this.lblColor.TabIndex = 18;
            this.lblColor.Text = "Цвят";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(154, 150);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(33, 13);
            this.lblPrice.TabIndex = 19;
            this.lblPrice.Text = "Цена";
            // 
            // lblTransmission
            // 
            this.lblTransmission.AutoSize = true;
            this.lblTransmission.Location = new System.Drawing.Point(154, 88);
            this.lblTransmission.Name = "lblTransmission";
            this.lblTransmission.Size = new System.Drawing.Size(92, 13);
            this.lblTransmission.TabIndex = 20;
            this.lblTransmission.Text = "Скоростна кутия";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(154, 29);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(40, 13);
            this.lblModel.TabIndex = 21;
            this.lblModel.Text = "Модел";
            // 
            // lblDealership
            // 
            this.lblDealership.AutoSize = true;
            this.lblDealership.Location = new System.Drawing.Point(260, 29);
            this.lblDealership.Name = "lblDealership";
            this.lblDealership.Size = new System.Drawing.Size(59, 13);
            this.lblDealership.TabIndex = 22;
            this.lblDealership.Text = "Автокъща";
            // 
            // lblGears
            // 
            this.lblGears.AutoSize = true;
            this.lblGears.Location = new System.Drawing.Point(260, 88);
            this.lblGears.Name = "lblGears";
            this.lblGears.Size = new System.Drawing.Size(57, 13);
            this.lblGears.TabIndex = 23;
            this.lblGears.Text = "Предавки";
            // 
            // lblOwner
            // 
            this.lblOwner.AutoSize = true;
            this.lblOwner.Location = new System.Drawing.Point(260, 150);
            this.lblOwner.Name = "lblOwner";
            this.lblOwner.Size = new System.Drawing.Size(67, 13);
            this.lblOwner.TabIndex = 24;
            this.lblOwner.Text = "Собственик";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(369, 164);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Изтрий";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(369, 102);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 26;
            this.btnUpdate.Text = "Промени";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(369, 102);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "Запази";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(464, 43);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 28;
            this.btnReset.Text = "Нулирай";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnOpenHelper
            // 
            this.btnOpenHelper.Location = new System.Drawing.Point(464, 102);
            this.btnOpenHelper.Name = "btnOpenHelper";
            this.btnOpenHelper.Size = new System.Drawing.Size(157, 23);
            this.btnOpenHelper.TabIndex = 29;
            this.btnOpenHelper.Text = "Помощна таблица";
            this.btnOpenHelper.UseVisualStyleBackColor = true;
            this.btnOpenHelper.Click += new System.EventHandler(this.btnOpenHelper_Click);
            // 
            // CarEditView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 623);
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
            this.Controls.Add(this.cbGet);
            this.Controls.Add(this.lblSort);
            this.Controls.Add(this.cbSort);
            this.Controls.Add(this.txtDealership);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtManufacturer);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btnSave);
            this.Name = "CarEditView";
            this.Text = "CarEditView";
            this.Load += new System.EventHandler(this.CarEditView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtManufacturer;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtDealership;
        private System.Windows.Forms.ComboBox cbSort;
        private System.Windows.Forms.Label lblSort;
        private System.Windows.Forms.ComboBox cbGet;
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
    }
}