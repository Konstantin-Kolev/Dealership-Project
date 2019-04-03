namespace Display
{
    partial class GridInfoPopUp
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
            this.btnShowCars = new System.Windows.Forms.Button();
            this.btnDealerships = new System.Windows.Forms.Button();
            this.btnWorkers = new System.Windows.Forms.Button();
            this.btnEngines = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnTowns = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 101);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(776, 337);
            this.dataGridView.TabIndex = 0;
            // 
            // btnShowCars
            // 
            this.btnShowCars.Location = new System.Drawing.Point(12, 72);
            this.btnShowCars.Name = "btnShowCars";
            this.btnShowCars.Size = new System.Drawing.Size(83, 23);
            this.btnShowCars.TabIndex = 1;
            this.btnShowCars.Text = "Автомобили";
            this.btnShowCars.UseVisualStyleBackColor = true;
            this.btnShowCars.Click += new System.EventHandler(this.btnShowCars_Click);
            // 
            // btnDealerships
            // 
            this.btnDealerships.Location = new System.Drawing.Point(101, 72);
            this.btnDealerships.Name = "btnDealerships";
            this.btnDealerships.Size = new System.Drawing.Size(75, 23);
            this.btnDealerships.TabIndex = 2;
            this.btnDealerships.Text = "Автокъщи";
            this.btnDealerships.UseVisualStyleBackColor = true;
            this.btnDealerships.Click += new System.EventHandler(this.btnDealerships_Click);
            // 
            // btnWorkers
            // 
            this.btnWorkers.Location = new System.Drawing.Point(551, 72);
            this.btnWorkers.Name = "btnWorkers";
            this.btnWorkers.Size = new System.Drawing.Size(75, 23);
            this.btnWorkers.TabIndex = 3;
            this.btnWorkers.Text = "Работници";
            this.btnWorkers.UseVisualStyleBackColor = true;
            // 
            // btnEngines
            // 
            this.btnEngines.Location = new System.Drawing.Point(182, 72);
            this.btnEngines.Name = "btnEngines";
            this.btnEngines.Size = new System.Drawing.Size(75, 23);
            this.btnEngines.TabIndex = 4;
            this.btnEngines.Text = "Двигатели";
            this.btnEngines.UseVisualStyleBackColor = true;
            // 
            // btnCustomers
            // 
            this.btnCustomers.Location = new System.Drawing.Point(632, 72);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(75, 23);
            this.btnCustomers.TabIndex = 5;
            this.btnCustomers.Text = "Клиенти";
            this.btnCustomers.UseVisualStyleBackColor = true;
            // 
            // btnTowns
            // 
            this.btnTowns.Location = new System.Drawing.Point(713, 72);
            this.btnTowns.Name = "btnTowns";
            this.btnTowns.Size = new System.Drawing.Size(75, 23);
            this.btnTowns.TabIndex = 6;
            this.btnTowns.Text = "Градове";
            this.btnTowns.UseVisualStyleBackColor = true;
            // 
            // GridInfoPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTowns);
            this.Controls.Add(this.btnCustomers);
            this.Controls.Add(this.btnEngines);
            this.Controls.Add(this.btnWorkers);
            this.Controls.Add(this.btnDealerships);
            this.Controls.Add(this.btnShowCars);
            this.Controls.Add(this.dataGridView);
            this.Name = "GridInfoPopUp";
            this.Text = "GridInfoPopUp";
            this.Load += new System.EventHandler(this.GridInfoPopUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnShowCars;
        private System.Windows.Forms.Button btnDealerships;
        private System.Windows.Forms.Button btnWorkers;
        private System.Windows.Forms.Button btnEngines;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnTowns;
    }
}