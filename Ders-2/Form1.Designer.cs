namespace CarSave
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
            this.gbxCreateCar = new System.Windows.Forms.GroupBox();
            this.grpUpdate = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblUModel = new System.Windows.Forms.Label();
            this.lblSearchId = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtUModel = new System.Windows.Forms.TextBox();
            this.txtUPrice = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblMarka = new System.Windows.Forms.Label();
            this.gbxCreateCar.SuspendLayout();
            this.grpUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxCreateCar
            // 
            this.gbxCreateCar.Controls.Add(this.textBox1);
            this.gbxCreateCar.Controls.Add(this.lblMarka);
            this.gbxCreateCar.Controls.Add(this.txtPrice);
            this.gbxCreateCar.Controls.Add(this.txtModel);
            this.gbxCreateCar.Controls.Add(this.btnSave);
            this.gbxCreateCar.Controls.Add(this.lblPrice);
            this.gbxCreateCar.Controls.Add(this.lblModel);
            this.gbxCreateCar.Location = new System.Drawing.Point(23, 26);
            this.gbxCreateCar.Name = "gbxCreateCar";
            this.gbxCreateCar.Size = new System.Drawing.Size(214, 191);
            this.gbxCreateCar.TabIndex = 0;
            this.gbxCreateCar.TabStop = false;
            this.gbxCreateCar.Text = "Create Car";
            // 
            // grpUpdate
            // 
            this.grpUpdate.Controls.Add(this.textBox3);
            this.grpUpdate.Controls.Add(this.txtUModel);
            this.grpUpdate.Controls.Add(this.txtUPrice);
            this.grpUpdate.Controls.Add(this.btnUpdate);
            this.grpUpdate.Controls.Add(this.btnFind);
            this.grpUpdate.Controls.Add(this.label5);
            this.grpUpdate.Controls.Add(this.lblUModel);
            this.grpUpdate.Controls.Add(this.lblSearchId);
            this.grpUpdate.Location = new System.Drawing.Point(258, 26);
            this.grpUpdate.Name = "grpUpdate";
            this.grpUpdate.Size = new System.Drawing.Size(232, 191);
            this.grpUpdate.TabIndex = 1;
            this.grpUpdate.TabStop = false;
            this.grpUpdate.Text = "Update";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 223);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(467, 187);
            this.dataGridView1.TabIndex = 2;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(20, 34);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(36, 13);
            this.lblModel.TabIndex = 0;
            this.lblModel.Text = "Model";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(20, 90);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "Price";
            // 
            // lblUModel
            // 
            this.lblUModel.AutoSize = true;
            this.lblUModel.Location = new System.Drawing.Point(24, 78);
            this.lblUModel.Name = "lblUModel";
            this.lblUModel.Size = new System.Drawing.Size(74, 13);
            this.lblUModel.TabIndex = 3;
            this.lblUModel.Text = "Update Model";
            // 
            // lblSearchId
            // 
            this.lblSearchId.AutoSize = true;
            this.lblSearchId.Location = new System.Drawing.Point(24, 30);
            this.lblSearchId.Name = "lblSearchId";
            this.lblSearchId.Size = new System.Drawing.Size(55, 13);
            this.lblSearchId.TabIndex = 2;
            this.lblSearchId.Text = "Search ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Update Price";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(98, 119);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(117, 46);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 3;
            this.btnFind.Text = "FIND";
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(117, 131);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(85, 31);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 20);
            this.txtModel.TabIndex = 3;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(85, 83);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(106, 20);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
            // 
            // txtUModel
            // 
            this.txtUModel.Location = new System.Drawing.Point(106, 75);
            this.txtUModel.Name = "txtUModel";
            this.txtUModel.Size = new System.Drawing.Size(100, 20);
            this.txtUModel.TabIndex = 6;
            // 
            // txtUPrice
            // 
            this.txtUPrice.Location = new System.Drawing.Point(106, 101);
            this.txtUPrice.Name = "txtUPrice";
            this.txtUPrice.Size = new System.Drawing.Size(100, 20);
            this.txtUPrice.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(85, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // lblMarka
            // 
            this.lblMarka.AutoSize = true;
            this.lblMarka.Location = new System.Drawing.Point(20, 60);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(37, 13);
            this.lblMarka.TabIndex = 5;
            this.lblMarka.Text = "Marka";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 440);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grpUpdate);
            this.Controls.Add(this.gbxCreateCar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbxCreateCar.ResumeLayout(false);
            this.gbxCreateCar.PerformLayout();
            this.grpUpdate.ResumeLayout(false);
            this.grpUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxCreateCar;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.GroupBox grpUpdate;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtUModel;
        private System.Windows.Forms.TextBox txtUPrice;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblUModel;
        private System.Windows.Forms.Label lblSearchId;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblMarka;
    }
}

