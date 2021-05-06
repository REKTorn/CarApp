namespace CarApp
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxForSale = new System.Windows.Forms.CheckBox();
            this.tbxYear = new System.Windows.Forms.TextBox();
            this.tbxModel = new System.Windows.Forms.TextBox();
            this.tbxMake = new System.Windows.Forms.TextBox();
            this.tbxRegNr = new System.Windows.Forms.TextBox();
            this.lsvCars = new System.Windows.Forms.ListView();
            this.regnr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.make = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.model = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.year = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.forsale = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnRemoveMarked = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbxForSale);
            this.groupBox1.Controls.Add(this.tbxYear);
            this.groupBox1.Controls.Add(this.tbxModel);
            this.groupBox1.Controls.Add(this.tbxMake);
            this.groupBox1.Controls.Add(this.tbxRegNr);
            this.groupBox1.Location = new System.Drawing.Point(20, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1162, 154);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAdd.Location = new System.Drawing.Point(975, 23);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(159, 43);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(322, 95);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Year";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(322, 29);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Model";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(28, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Make";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(28, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Reg Nr";
            // 
            // cbxForSale
            // 
            this.cbxForSale.AutoSize = true;
            this.cbxForSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbxForSale.Location = new System.Drawing.Point(709, 28);
            this.cbxForSale.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxForSale.Name = "cbxForSale";
            this.cbxForSale.Size = new System.Drawing.Size(112, 29);
            this.cbxForSale.TabIndex = 4;
            this.cbxForSale.Text = "For Sale";
            this.cbxForSale.UseVisualStyleBackColor = true;
            // 
            // tbxYear
            // 
            this.tbxYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbxYear.Location = new System.Drawing.Point(424, 95);
            this.tbxYear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxYear.Name = "tbxYear";
            this.tbxYear.Size = new System.Drawing.Size(148, 30);
            this.tbxYear.TabIndex = 3;
            // 
            // tbxModel
            // 
            this.tbxModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbxModel.Location = new System.Drawing.Point(424, 29);
            this.tbxModel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxModel.Name = "tbxModel";
            this.tbxModel.Size = new System.Drawing.Size(148, 30);
            this.tbxModel.TabIndex = 2;
            // 
            // tbxMake
            // 
            this.tbxMake.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbxMake.Location = new System.Drawing.Point(112, 95);
            this.tbxMake.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxMake.Name = "tbxMake";
            this.tbxMake.Size = new System.Drawing.Size(148, 30);
            this.tbxMake.TabIndex = 1;
            // 
            // tbxRegNr
            // 
            this.tbxRegNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbxRegNr.Location = new System.Drawing.Point(112, 29);
            this.tbxRegNr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxRegNr.Name = "tbxRegNr";
            this.tbxRegNr.Size = new System.Drawing.Size(148, 30);
            this.tbxRegNr.TabIndex = 0;
            // 
            // lsvCars
            // 
            this.lsvCars.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.regnr,
            this.make,
            this.model,
            this.year,
            this.forsale});
            this.lsvCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lsvCars.Location = new System.Drawing.Point(20, 185);
            this.lsvCars.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lsvCars.Name = "lsvCars";
            this.lsvCars.Size = new System.Drawing.Size(1160, 412);
            this.lsvCars.TabIndex = 1;
            this.lsvCars.UseCompatibleStateImageBehavior = false;
            this.lsvCars.View = System.Windows.Forms.View.Details;
            this.lsvCars.SelectedIndexChanged += new System.EventHandler(this.lsvCars_SelectedIndexChanged);
            // 
            // regnr
            // 
            this.regnr.Text = "Reg Nr";
            this.regnr.Width = 137;
            // 
            // make
            // 
            this.make.Text = "Make";
            this.make.Width = 145;
            // 
            // model
            // 
            this.model.Text = "Model";
            this.model.Width = 135;
            // 
            // year
            // 
            this.year.Text = "Year";
            this.year.Width = 155;
            // 
            // forsale
            // 
            this.forsale.Text = "For Sale";
            this.forsale.Width = 158;
            // 
            // btnClearAll
            // 
            this.btnClearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnClearAll.Location = new System.Drawing.Point(110, 623);
            this.btnClearAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(216, 43);
            this.btnClearAll.TabIndex = 2;
            this.btnClearAll.Text = "Clear all";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnRemoveMarked
            // 
            this.btnRemoveMarked.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRemoveMarked.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveMarked.Location = new System.Drawing.Point(876, 623);
            this.btnRemoveMarked.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRemoveMarked.Name = "btnRemoveMarked";
            this.btnRemoveMarked.Size = new System.Drawing.Size(218, 43);
            this.btnRemoveMarked.TabIndex = 3;
            this.btnRemoveMarked.Text = "Remove marked";
            this.btnRemoveMarked.UseVisualStyleBackColor = true;
            this.btnRemoveMarked.Click += new System.EventHandler(this.btnRemoveMarked_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSearch.Location = new System.Drawing.Point(651, 90);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(246, 41);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search with Reg Nr";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 666);
            this.Controls.Add(this.btnRemoveMarked);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.lsvCars);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1213, 722);
            this.MinimumSize = new System.Drawing.Size(1213, 722);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbxForSale;
        private System.Windows.Forms.TextBox tbxYear;
        private System.Windows.Forms.TextBox tbxModel;
        private System.Windows.Forms.TextBox tbxMake;
        private System.Windows.Forms.TextBox tbxRegNr;
        private System.Windows.Forms.ListView lsvCars;
        private System.Windows.Forms.ColumnHeader regnr;
        private System.Windows.Forms.ColumnHeader make;
        private System.Windows.Forms.ColumnHeader model;
        private System.Windows.Forms.ColumnHeader year;
        private System.Windows.Forms.ColumnHeader forsale;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnRemoveMarked;
        private System.Windows.Forms.Button btnSearch;
    }
}

