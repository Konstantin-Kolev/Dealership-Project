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
            this.dataGridTowns = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTowns)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridTowns
            // 
            this.dataGridTowns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTowns.Location = new System.Drawing.Point(360, 113);
            this.dataGridTowns.Name = "dataGridTowns";
            this.dataGridTowns.Size = new System.Drawing.Size(353, 273);
            this.dataGridTowns.TabIndex = 0;
            // 
            // TownEditView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridTowns);
            this.Name = "TownEditView";
            this.Text = "TownEditView";
            this.Load += new System.EventHandler(this.TownEditView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTowns)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridTowns;
    }
}