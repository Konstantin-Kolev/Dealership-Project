namespace Display
{
    partial class TownEditView
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnOpenHelper = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblSort = new System.Windows.Forms.Label();
            this.cbSort = new System.Windows.Forms.ComboBox();
            this.lblGet = new System.Windows.Forms.Label();
            this.cbGet = new System.Windows.Forms.ComboBox();
            this.txtGet = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
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
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(48, 29);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(29, 13);
            this.lblName.TabIndex = 17;
            this.lblName.Text = "Име";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(51, 45);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 18;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(369, 43);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Добави";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(369, 102);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 27;
            this.btnUpdate.Text = "Промени";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
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
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(369, 164);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 29;
            this.btnDelete.Text = "Изтрий";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnOpenHelper
            // 
            this.btnOpenHelper.Location = new System.Drawing.Point(464, 102);
            this.btnOpenHelper.Name = "btnOpenHelper";
            this.btnOpenHelper.Size = new System.Drawing.Size(157, 23);
            this.btnOpenHelper.TabIndex = 30;
            this.btnOpenHelper.Text = "Помощна таблица";
            this.btnOpenHelper.UseVisualStyleBackColor = true;
            this.btnOpenHelper.Click += new System.EventHandler(this.btnOpenHelper_Click);
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
            // lblSort
            // 
            this.lblSort.AutoSize = true;
            this.lblSort.Location = new System.Drawing.Point(545, 48);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(76, 13);
            this.lblSort.TabIndex = 32;
            this.lblSort.Text = "Сортиране по";
            // 
            // cbSort
            // 
            this.cbSort.FormattingEnabled = true;
            this.cbSort.Items.AddRange(new object[] {
            "Име възходящ",
            "Име низходящ"});
            this.cbSort.Location = new System.Drawing.Point(627, 45);
            this.cbSort.Name = "cbSort";
            this.cbSort.Size = new System.Drawing.Size(121, 21);
            this.cbSort.TabIndex = 33;
            this.cbSort.SelectedIndexChanged += new System.EventHandler(this.cbSort_SelectedIndexChanged);
            // 
            // lblGet
            // 
            this.lblGet.AutoSize = true;
            this.lblGet.Location = new System.Drawing.Point(754, 48);
            this.lblGet.Name = "lblGet";
            this.lblGet.Size = new System.Drawing.Size(50, 13);
            this.lblGet.TabIndex = 34;
            this.lblGet.Text = "Справки";
            // 
            // cbGet
            // 
            this.cbGet.FormattingEnabled = true;
            this.cbGet.Items.AddRange(new object[] {
            "Град по ID",
            "Град по име"});
            this.cbGet.Location = new System.Drawing.Point(810, 45);
            this.cbGet.Name = "cbGet";
            this.cbGet.Size = new System.Drawing.Size(121, 21);
            this.cbGet.TabIndex = 35;
            this.cbGet.SelectedIndexChanged += new System.EventHandler(this.cbGet_SelectedIndexChanged);
            // 
            // txtGet
            // 
            this.txtGet.Location = new System.Drawing.Point(937, 45);
            this.txtGet.Name = "txtGet";
            this.txtGet.Size = new System.Drawing.Size(100, 20);
            this.txtGet.TabIndex = 36;
            // 
            // TownEditView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 623);
            this.Controls.Add(this.txtGet);
            this.Controls.Add(this.cbGet);
            this.Controls.Add(this.lblGet);
            this.Controls.Add(this.cbSort);
            this.Controls.Add(this.lblSort);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnOpenHelper);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TownEditView";
            this.Text = "Градове";
            this.Load += new System.EventHandler(this.TownEditView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnOpenHelper;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblSort;
        private System.Windows.Forms.ComboBox cbSort;
        private System.Windows.Forms.Label lblGet;
        private System.Windows.Forms.ComboBox cbGet;
        private System.Windows.Forms.TextBox txtGet;
    }
}