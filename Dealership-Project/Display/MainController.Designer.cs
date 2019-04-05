namespace Display
{
    partial class MainController
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainController));
            this.btnCars = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEngines = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnDealerships = new System.Windows.Forms.Button();
            this.btnWorkers = new System.Windows.Forms.Button();
            this.btnTowns = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCars
            // 
            this.btnCars.Location = new System.Drawing.Point(45, 189);
            this.btnCars.Name = "btnCars";
            this.btnCars.Size = new System.Drawing.Size(151, 36);
            this.btnCars.TabIndex = 0;
            this.btnCars.Text = "Автомобили";
            this.btnCars.UseVisualStyleBackColor = true;
            this.btnCars.Click += new System.EventHandler(this.btnCars_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-12, -12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(636, 357);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnEngines
            // 
            this.btnEngines.Location = new System.Drawing.Point(45, 105);
            this.btnEngines.Name = "btnEngines";
            this.btnEngines.Size = new System.Drawing.Size(151, 36);
            this.btnEngines.TabIndex = 2;
            this.btnEngines.Text = "Двигатели";
            this.btnEngines.UseVisualStyleBackColor = true;
            this.btnEngines.Click += new System.EventHandler(this.btnEngines_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.Location = new System.Drawing.Point(202, 147);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(118, 36);
            this.btnCustomers.TabIndex = 3;
            this.btnCustomers.Text = "Клиенти";
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnDealerships
            // 
            this.btnDealerships.Location = new System.Drawing.Point(45, 147);
            this.btnDealerships.Name = "btnDealerships";
            this.btnDealerships.Size = new System.Drawing.Size(151, 36);
            this.btnDealerships.TabIndex = 4;
            this.btnDealerships.Text = "Автокъщи";
            this.btnDealerships.UseVisualStyleBackColor = true;
            this.btnDealerships.Click += new System.EventHandler(this.btnDealerships_Click);
            // 
            // btnWorkers
            // 
            this.btnWorkers.Location = new System.Drawing.Point(202, 106);
            this.btnWorkers.Name = "btnWorkers";
            this.btnWorkers.Size = new System.Drawing.Size(118, 35);
            this.btnWorkers.TabIndex = 5;
            this.btnWorkers.Text = "Служители";
            this.btnWorkers.UseVisualStyleBackColor = true;
            this.btnWorkers.Click += new System.EventHandler(this.btnWorkers_Click);
            // 
            // btnTowns
            // 
            this.btnTowns.Location = new System.Drawing.Point(45, 63);
            this.btnTowns.Name = "btnTowns";
            this.btnTowns.Size = new System.Drawing.Size(151, 36);
            this.btnTowns.TabIndex = 6;
            this.btnTowns.Text = "Градове";
            this.btnTowns.UseVisualStyleBackColor = true;
            this.btnTowns.Click += new System.EventHandler(this.btnTowns_Click);
            // 
            // MainController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 335);
            this.Controls.Add(this.btnTowns);
            this.Controls.Add(this.btnWorkers);
            this.Controls.Add(this.btnDealerships);
            this.Controls.Add(this.btnCustomers);
            this.Controls.Add(this.btnEngines);
            this.Controls.Add(this.btnCars);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainController";
            this.Text = "Главно меню";
            this.Load += new System.EventHandler(this.MainController_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCars;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEngines;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnDealerships;
        private System.Windows.Forms.Button btnWorkers;
        private System.Windows.Forms.Button btnTowns;
    }
}

