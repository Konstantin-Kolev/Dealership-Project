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
            this.btnCars = new System.Windows.Forms.Button();
            this.btnDealerships = new System.Windows.Forms.Button();
            this.btnWorkers = new System.Windows.Forms.Button();
            this.btnEngines = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnTowns = new System.Windows.Forms.Button();
            this.lblInfoCar = new System.Windows.Forms.Label();
            this.btnNewCar = new System.Windows.Forms.Button();
            this.lblInfoDealership = new System.Windows.Forms.Label();
            this.lblInfoEngine = new System.Windows.Forms.Label();
            this.lblInfoWorker = new System.Windows.Forms.Label();
            this.lblInfoCustomer = new System.Windows.Forms.Label();
            this.lblInfoTown = new System.Windows.Forms.Label();
            this.btnNewDealership = new System.Windows.Forms.Button();
            this.btnNewEngine = new System.Windows.Forms.Button();
            this.btnNewWorker = new System.Windows.Forms.Button();
            this.btnNewCustomer = new System.Windows.Forms.Button();
            this.btnNewTown = new System.Windows.Forms.Button();
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
            // btnCars
            // 
            this.btnCars.Location = new System.Drawing.Point(12, 72);
            this.btnCars.Name = "btnCars";
            this.btnCars.Size = new System.Drawing.Size(83, 23);
            this.btnCars.TabIndex = 1;
            this.btnCars.Text = "Автомобили";
            this.btnCars.UseVisualStyleBackColor = true;
            this.btnCars.Click += new System.EventHandler(this.btnCars_Click);
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
            this.btnWorkers.Click += new System.EventHandler(this.btnWorkers_Click);
            // 
            // btnEngines
            // 
            this.btnEngines.Location = new System.Drawing.Point(182, 72);
            this.btnEngines.Name = "btnEngines";
            this.btnEngines.Size = new System.Drawing.Size(75, 23);
            this.btnEngines.TabIndex = 4;
            this.btnEngines.Text = "Двигатели";
            this.btnEngines.UseVisualStyleBackColor = true;
            this.btnEngines.Click += new System.EventHandler(this.btnEngines_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.Location = new System.Drawing.Point(632, 72);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(75, 23);
            this.btnCustomers.TabIndex = 5;
            this.btnCustomers.Text = "Клиенти";
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnTowns
            // 
            this.btnTowns.Location = new System.Drawing.Point(713, 72);
            this.btnTowns.Name = "btnTowns";
            this.btnTowns.Size = new System.Drawing.Size(75, 23);
            this.btnTowns.TabIndex = 6;
            this.btnTowns.Text = "Градове";
            this.btnTowns.UseVisualStyleBackColor = true;
            this.btnTowns.Click += new System.EventHandler(this.btnTowns_Click);
            // 
            // lblInfoCar
            // 
            this.lblInfoCar.AutoSize = true;
            this.lblInfoCar.Location = new System.Drawing.Point(312, 56);
            this.lblInfoCar.Name = "lblInfoCar";
            this.lblInfoCar.Size = new System.Drawing.Size(209, 13);
            this.lblInfoCar.TabIndex = 7;
            this.lblInfoCar.Text = "Искате ли да добавите нов автомобил?";
            // 
            // btnNewCar
            // 
            this.btnNewCar.Location = new System.Drawing.Point(358, 72);
            this.btnNewCar.Name = "btnNewCar";
            this.btnNewCar.Size = new System.Drawing.Size(101, 23);
            this.btnNewCar.TabIndex = 8;
            this.btnNewCar.Text = "Нов автомобил";
            this.btnNewCar.UseVisualStyleBackColor = true;
            this.btnNewCar.Click += new System.EventHandler(this.btnNewCar_Click);
            // 
            // lblInfoDealership
            // 
            this.lblInfoDealership.AutoSize = true;
            this.lblInfoDealership.Location = new System.Drawing.Point(310, 56);
            this.lblInfoDealership.Name = "lblInfoDealership";
            this.lblInfoDealership.Size = new System.Drawing.Size(211, 13);
            this.lblInfoDealership.TabIndex = 9;
            this.lblInfoDealership.Text = "Искате ли да добавите новa автокъща?";
            // 
            // lblInfoEngine
            // 
            this.lblInfoEngine.AutoSize = true;
            this.lblInfoEngine.Location = new System.Drawing.Point(313, 56);
            this.lblInfoEngine.Name = "lblInfoEngine";
            this.lblInfoEngine.Size = new System.Drawing.Size(200, 13);
            this.lblInfoEngine.TabIndex = 10;
            this.lblInfoEngine.Text = "Искате ли да добавите нов двигател?";
            // 
            // lblInfoWorker
            // 
            this.lblInfoWorker.AutoSize = true;
            this.lblInfoWorker.Location = new System.Drawing.Point(312, 56);
            this.lblInfoWorker.Name = "lblInfoWorker";
            this.lblInfoWorker.Size = new System.Drawing.Size(201, 13);
            this.lblInfoWorker.TabIndex = 11;
            this.lblInfoWorker.Text = "Искате ли да добавите нов работник?";
            // 
            // lblInfoCustomer
            // 
            this.lblInfoCustomer.AutoSize = true;
            this.lblInfoCustomer.Location = new System.Drawing.Point(324, 56);
            this.lblInfoCustomer.Name = "lblInfoCustomer";
            this.lblInfoCustomer.Size = new System.Drawing.Size(189, 13);
            this.lblInfoCustomer.TabIndex = 12;
            this.lblInfoCustomer.Text = "Искате ли да добавите нов клиент?";
            // 
            // lblInfoTown
            // 
            this.lblInfoTown.AutoSize = true;
            this.lblInfoTown.Location = new System.Drawing.Point(324, 56);
            this.lblInfoTown.Name = "lblInfoTown";
            this.lblInfoTown.Size = new System.Drawing.Size(177, 13);
            this.lblInfoTown.TabIndex = 13;
            this.lblInfoTown.Text = "Искате ли да добавите нов град?";
            // 
            // btnNewDealership
            // 
            this.btnNewDealership.Location = new System.Drawing.Point(358, 72);
            this.btnNewDealership.Name = "btnNewDealership";
            this.btnNewDealership.Size = new System.Drawing.Size(101, 23);
            this.btnNewDealership.TabIndex = 14;
            this.btnNewDealership.Text = "Нова автокъща";
            this.btnNewDealership.UseVisualStyleBackColor = true;
            this.btnNewDealership.Click += new System.EventHandler(this.btnNewDealership_Click);
            // 
            // btnNewEngine
            // 
            this.btnNewEngine.Location = new System.Drawing.Point(358, 72);
            this.btnNewEngine.Name = "btnNewEngine";
            this.btnNewEngine.Size = new System.Drawing.Size(101, 23);
            this.btnNewEngine.TabIndex = 15;
            this.btnNewEngine.Text = "Нов двигател";
            this.btnNewEngine.UseVisualStyleBackColor = true;
            this.btnNewEngine.Click += new System.EventHandler(this.btnNewEngine_Click);
            // 
            // btnNewWorker
            // 
            this.btnNewWorker.Location = new System.Drawing.Point(358, 72);
            this.btnNewWorker.Name = "btnNewWorker";
            this.btnNewWorker.Size = new System.Drawing.Size(101, 23);
            this.btnNewWorker.TabIndex = 16;
            this.btnNewWorker.Text = "Нов работник";
            this.btnNewWorker.UseVisualStyleBackColor = true;
            this.btnNewWorker.Click += new System.EventHandler(this.btnNewWorker_Click);
            // 
            // btnNewCustomer
            // 
            this.btnNewCustomer.Location = new System.Drawing.Point(358, 72);
            this.btnNewCustomer.Name = "btnNewCustomer";
            this.btnNewCustomer.Size = new System.Drawing.Size(101, 23);
            this.btnNewCustomer.TabIndex = 17;
            this.btnNewCustomer.Text = "Нов клиент";
            this.btnNewCustomer.UseVisualStyleBackColor = true;
            this.btnNewCustomer.Click += new System.EventHandler(this.btnNewCustomer_Click);
            // 
            // btnNewTown
            // 
            this.btnNewTown.Location = new System.Drawing.Point(358, 72);
            this.btnNewTown.Name = "btnNewTown";
            this.btnNewTown.Size = new System.Drawing.Size(101, 23);
            this.btnNewTown.TabIndex = 18;
            this.btnNewTown.Text = "Нов град";
            this.btnNewTown.UseVisualStyleBackColor = true;
            this.btnNewTown.Click += new System.EventHandler(this.btnNewTown_Click);
            // 
            // GridInfoPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblInfoEngine);
            this.Controls.Add(this.btnNewTown);
            this.Controls.Add(this.btnNewCustomer);
            this.Controls.Add(this.btnNewWorker);
            this.Controls.Add(this.btnNewEngine);
            this.Controls.Add(this.lblInfoDealership);
            this.Controls.Add(this.btnNewDealership);
            this.Controls.Add(this.lblInfoTown);
            this.Controls.Add(this.lblInfoCustomer);
            this.Controls.Add(this.lblInfoWorker);
            this.Controls.Add(this.btnNewCar);
            this.Controls.Add(this.lblInfoCar);
            this.Controls.Add(this.btnTowns);
            this.Controls.Add(this.btnCustomers);
            this.Controls.Add(this.btnEngines);
            this.Controls.Add(this.btnWorkers);
            this.Controls.Add(this.btnDealerships);
            this.Controls.Add(this.btnCars);
            this.Controls.Add(this.dataGridView);
            this.Name = "GridInfoPopUp";
            this.Text = "GridInfoPopUp";
            this.Load += new System.EventHandler(this.GridInfoPopUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnCars;
        private System.Windows.Forms.Button btnDealerships;
        private System.Windows.Forms.Button btnWorkers;
        private System.Windows.Forms.Button btnEngines;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnTowns;
        private System.Windows.Forms.Label lblInfoCar;
        private System.Windows.Forms.Button btnNewCar;
        private System.Windows.Forms.Label lblInfoDealership;
        private System.Windows.Forms.Label lblInfoEngine;
        private System.Windows.Forms.Label lblInfoWorker;
        private System.Windows.Forms.Label lblInfoCustomer;
        private System.Windows.Forms.Label lblInfoTown;
        private System.Windows.Forms.Button btnNewDealership;
        private System.Windows.Forms.Button btnNewEngine;
        private System.Windows.Forms.Button btnNewWorker;
        private System.Windows.Forms.Button btnNewCustomer;
        private System.Windows.Forms.Button btnNewTown;
    }
}