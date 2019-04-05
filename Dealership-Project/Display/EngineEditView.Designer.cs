namespace Display
{
    partial class EngineEditView
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
            this.lblDisplacement = new System.Windows.Forms.Label();
            this.lblEconomy = new System.Windows.Forms.Label();
            this.lblFuelType = new System.Windows.Forms.Label();
            this.lblPower = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtManufacturer = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnOpenHelper = new System.Windows.Forms.Button();
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
            // lblDisplacement
            // 
            this.lblDisplacement.AutoSize = true;
            this.lblDisplacement.Location = new System.Drawing.Point(260, 29);
            this.lblDisplacement.Name = "lblDisplacement";
            this.lblDisplacement.Size = new System.Drawing.Size(78, 13);
            this.lblDisplacement.TabIndex = 17;
            this.lblDisplacement.Text = "Работен обем";
            // 
            // lblEconomy
            // 
            this.lblEconomy.AutoSize = true;
            this.lblEconomy.Location = new System.Drawing.Point(154, 88);
            this.lblEconomy.Name = "lblEconomy";
            this.lblEconomy.Size = new System.Drawing.Size(137, 13);
            this.lblEconomy.TabIndex = 18;
            this.lblEconomy.Text = "Разход на 100 километра";
            // 
            // lblFuelType
            // 
            this.lblFuelType.AutoSize = true;
            this.lblFuelType.Location = new System.Drawing.Point(154, 29);
            this.lblFuelType.Name = "lblFuelType";
            this.lblFuelType.Size = new System.Drawing.Size(43, 13);
            this.lblFuelType.TabIndex = 19;
            this.lblFuelType.Text = "Гориво";
            // 
            // lblPower
            // 
            this.lblPower.AutoSize = true;
            this.lblPower.Location = new System.Drawing.Point(48, 88);
            this.lblPower.Name = "lblPower";
            this.lblPower.Size = new System.Drawing.Size(54, 13);
            this.lblPower.TabIndex = 20;
            this.lblPower.Text = "Мощност";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(48, 29);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(29, 13);
            this.lblName.TabIndex = 21;
            this.lblName.Text = "Име";
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.Location = new System.Drawing.Point(157, 104);
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.Size = new System.Drawing.Size(100, 20);
            this.txtManufacturer.TabIndex = 22;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(51, 104);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 23;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(263, 45);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 24;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(157, 45);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 25;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(51, 45);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 26;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(369, 43);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 27;
            this.btnAdd.Text = "Добави";
            this.btnAdd.UseVisualStyleBackColor = true;
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
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(369, 102);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 29;
            this.btnUpdate.Text = "Промени";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(369, 164);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 30;
            this.btnDelete.Text = "Изтрий";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(464, 43);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 31;
            this.btnReset.Text = "Нулирай";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnOpenHelper
            // 
            this.btnOpenHelper.Location = new System.Drawing.Point(464, 102);
            this.btnOpenHelper.Name = "btnOpenHelper";
            this.btnOpenHelper.Size = new System.Drawing.Size(157, 23);
            this.btnOpenHelper.TabIndex = 32;
            this.btnOpenHelper.Text = "Помощна таблица";
            this.btnOpenHelper.UseVisualStyleBackColor = true;
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
            // cbSort
            // 
            this.cbSort.FormattingEnabled = true;
            this.cbSort.Items.AddRange(new object[] {
            "Мощност възходящ",
            "Мощност низходящ",
            "Икономия възходящ",
            "Икономия низходящ",
            "Вид гориво",
            "Вид трансмисия",
            "Брой предавки възходящ",
            "Брой предавки низходящ",
            "Работен обем възходящ",
            "Работен обем низходящ",
            "Цвят",
            "Цена възходящ",
            "Цена низходящ",
            "Марка и модел възходящ",
            "Марка и модел низходящ",
            "Автокъща възходящ",
            "Автокъща низходящ"});
            this.cbSort.Location = new System.Drawing.Point(627, 45);
            this.cbSort.Name = "cbSort";
            this.cbSort.Size = new System.Drawing.Size(121, 21);
            this.cbSort.TabIndex = 34;
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
            // cbGet
            // 
            this.cbGet.FormattingEnabled = true;
            this.cbGet.Items.AddRange(new object[] {
            "spravka 1",
            "spravka2"});
            this.cbGet.Location = new System.Drawing.Point(810, 45);
            this.cbGet.Name = "cbGet";
            this.cbGet.Size = new System.Drawing.Size(121, 21);
            this.cbGet.TabIndex = 36;
            // 
            // txtGet
            // 
            this.txtGet.Location = new System.Drawing.Point(937, 45);
            this.txtGet.Name = "txtGet";
            this.txtGet.Size = new System.Drawing.Size(100, 20);
            this.txtGet.TabIndex = 37;
            // 
            // EngineEditView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 623);
            this.Controls.Add(this.txtGet);
            this.Controls.Add(this.cbGet);
            this.Controls.Add(this.lblGet);
            this.Controls.Add(this.cbSort);
            this.Controls.Add(this.lblSort);
            this.Controls.Add(this.btnOpenHelper);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtManufacturer);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblPower);
            this.Controls.Add(this.lblFuelType);
            this.Controls.Add(this.lblEconomy);
            this.Controls.Add(this.lblDisplacement);
            this.Controls.Add(this.dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EngineEditView";
            this.Text = "Двигатели";
            this.Load += new System.EventHandler(this.EngineEditView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label lblDisplacement;
        private System.Windows.Forms.Label lblEconomy;
        private System.Windows.Forms.Label lblFuelType;
        private System.Windows.Forms.Label lblPower;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtManufacturer;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnOpenHelper;
        private System.Windows.Forms.Label lblSort;
        private System.Windows.Forms.ComboBox cbSort;
        private System.Windows.Forms.Label lblGet;
        private System.Windows.Forms.ComboBox cbGet;
        private System.Windows.Forms.TextBox txtGet;
    }
}