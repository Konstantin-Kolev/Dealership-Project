namespace Display
{
    partial class WorkerEditView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkerEditView));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblDealership = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtDealership = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnOpenHelper = new System.Windows.Forms.Button();
            this.lblSort = new System.Windows.Forms.Label();
            this.cbGet = new System.Windows.Forms.ComboBox();
            this.lblGet = new System.Windows.Forms.Label();
            this.cbSort = new System.Windows.Forms.ComboBox();
            this.txtGet = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(51, 242);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(986, 338);
            this.dataGridView.TabIndex = 1;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(48, 29);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(29, 13);
            this.lblFirstName.TabIndex = 17;
            this.lblFirstName.Text = "Име";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(154, 29);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(56, 13);
            this.lblLastName.TabIndex = 18;
            this.lblLastName.Text = "Фамилия";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(260, 29);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(60, 13);
            this.lblPosition.TabIndex = 19;
            this.lblPosition.Text = "Длъжност";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(48, 88);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(49, 13);
            this.lblSalary.TabIndex = 20;
            this.lblSalary.Text = "Заплата";
            // 
            // lblDealership
            // 
            this.lblDealership.AutoSize = true;
            this.lblDealership.Location = new System.Drawing.Point(154, 88);
            this.lblDealership.Name = "lblDealership";
            this.lblDealership.Size = new System.Drawing.Size(59, 13);
            this.lblDealership.TabIndex = 21;
            this.lblDealership.Text = "Автокъща";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(51, 45);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 22;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(157, 45);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 23;
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(263, 45);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(100, 20);
            this.txtPosition.TabIndex = 24;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(51, 104);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(100, 20);
            this.txtSalary.TabIndex = 25;
            // 
            // txtDealership
            // 
            this.txtDealership.Location = new System.Drawing.Point(157, 104);
            this.txtDealership.Name = "txtDealership";
            this.txtDealership.Size = new System.Drawing.Size(100, 20);
            this.txtDealership.TabIndex = 26;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(369, 43);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 27;
            this.btnAdd.Text = "Добави";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(369, 102);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 28;
            this.btnSave.Text = "Запази";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(369, 102);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 29;
            this.btnUpdate.Text = "Промени";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(369, 164);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 30;
            this.btnDelete.Text = "Изтрий";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(464, 43);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 31;
            this.btnReset.Text = "Нулирай";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnOpenHelper
            // 
            this.btnOpenHelper.Location = new System.Drawing.Point(464, 102);
            this.btnOpenHelper.Name = "btnOpenHelper";
            this.btnOpenHelper.Size = new System.Drawing.Size(157, 23);
            this.btnOpenHelper.TabIndex = 32;
            this.btnOpenHelper.Text = "Помощна таблица";
            this.btnOpenHelper.UseVisualStyleBackColor = true;
            this.btnOpenHelper.Click += new System.EventHandler(this.btnOpenHelper_Click);
            // 
            // lblSort
            // 
            this.lblSort.AutoSize = true;
            this.lblSort.Location = new System.Drawing.Point(545, 48);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(76, 13);
            this.lblSort.TabIndex = 33;
            this.lblSort.Text = "Сортиране по";
            // 
            // cbGet
            // 
            this.cbGet.FormattingEnabled = true;
            this.cbGet.Items.AddRange(new object[] {
            "Служител по ID",
            "Служители по ID на автокъща",
            "Служители по име",
            "Служители по фамилия",
            "Служители по длъжност",
            "Служители по заплата",
            "Служители до заплата",
            "Служители над заплата"});
            this.cbGet.Location = new System.Drawing.Point(810, 45);
            this.cbGet.Name = "cbGet";
            this.cbGet.Size = new System.Drawing.Size(121, 21);
            this.cbGet.TabIndex = 34;
            this.cbGet.SelectedIndexChanged += new System.EventHandler(this.cbGet_SelectedIndexChanged);
            // 
            // lblGet
            // 
            this.lblGet.AutoSize = true;
            this.lblGet.Location = new System.Drawing.Point(754, 48);
            this.lblGet.Name = "lblGet";
            this.lblGet.Size = new System.Drawing.Size(50, 13);
            this.lblGet.TabIndex = 35;
            this.lblGet.Text = "Справки";
            // 
            // cbSort
            // 
            this.cbSort.FormattingEnabled = true;
            this.cbSort.Items.AddRange(new object[] {
            "Две имена възходящ",
            "Две имена низходящ",
            "Име възходящ",
            "Име низходящ",
            "Фамилия възходящ",
            "Фамилия низходящ",
            "Заплата възходящ",
            "Заплата низходящ",
            "Длъжност",
            "Автокъща"});
            this.cbSort.Location = new System.Drawing.Point(627, 45);
            this.cbSort.Name = "cbSort";
            this.cbSort.Size = new System.Drawing.Size(121, 21);
            this.cbSort.TabIndex = 36;
            this.cbSort.SelectedIndexChanged += new System.EventHandler(this.cbSort_SelectedIndexChanged);
            // 
            // txtGet
            // 
            this.txtGet.Location = new System.Drawing.Point(937, 45);
            this.txtGet.Name = "txtGet";
            this.txtGet.Size = new System.Drawing.Size(100, 20);
            this.txtGet.TabIndex = 37;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-15, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1117, 687);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnExit.Location = new System.Drawing.Point(962, 164);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 39;
            this.btnExit.Text = "ИЗКЛЮЧИ";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // WorkerEditView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 623);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtGet);
            this.Controls.Add(this.cbSort);
            this.Controls.Add(this.lblGet);
            this.Controls.Add(this.cbGet);
            this.Controls.Add(this.lblSort);
            this.Controls.Add(this.btnOpenHelper);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtDealership);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblDealership);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WorkerEditView";
            this.Text = "Служители";
            this.Load += new System.EventHandler(this.WorkerEditView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblDealership;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtDealership;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnOpenHelper;
        private System.Windows.Forms.Label lblSort;
        private System.Windows.Forms.ComboBox cbGet;
        private System.Windows.Forms.Label lblGet;
        private System.Windows.Forms.ComboBox cbSort;
        private System.Windows.Forms.TextBox txtGet;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExit;
    }
}