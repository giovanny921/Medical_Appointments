namespace CitasMedicas.Forms
{
    partial class UpdatedDoctorForm
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
            this.listBoxSpecialitiesUpdate = new System.Windows.Forms.ListBox();
            this.numericUpDownAgeUpdate = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLastNameUpdate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNameUpdate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumIDUpdated = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAgeUpdate)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxSpecialitiesUpdate
            // 
            this.listBoxSpecialitiesUpdate.FormattingEnabled = true;
            this.listBoxSpecialitiesUpdate.ItemHeight = 15;
            this.listBoxSpecialitiesUpdate.Items.AddRange(new object[] {
            "General medicine",
            "Dermatology",
            "Dentist"});
            this.listBoxSpecialitiesUpdate.Location = new System.Drawing.Point(151, 185);
            this.listBoxSpecialitiesUpdate.Name = "listBoxSpecialitiesUpdate";
            this.listBoxSpecialitiesUpdate.Size = new System.Drawing.Size(359, 49);
            this.listBoxSpecialitiesUpdate.TabIndex = 16;
            // 
            // numericUpDownAgeUpdate
            // 
            this.numericUpDownAgeUpdate.Location = new System.Drawing.Point(152, 144);
            this.numericUpDownAgeUpdate.Name = "numericUpDownAgeUpdate";
            this.numericUpDownAgeUpdate.Size = new System.Drawing.Size(147, 23);
            this.numericUpDownAgeUpdate.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Speciality";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Age";
            // 
            // txtLastNameUpdate
            // 
            this.txtLastNameUpdate.Location = new System.Drawing.Point(151, 100);
            this.txtLastNameUpdate.Name = "txtLastNameUpdate";
            this.txtLastNameUpdate.Size = new System.Drawing.Size(359, 23);
            this.txtLastNameUpdate.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Last Name";
            // 
            // txtNameUpdate
            // 
            this.txtNameUpdate.Location = new System.Drawing.Point(152, 54);
            this.txtNameUpdate.Name = "txtNameUpdate";
            this.txtNameUpdate.Size = new System.Drawing.Size(358, 23);
            this.txtNameUpdate.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Name";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(203, 254);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Numero ID";
            // 
            // txtNumIDUpdated
            // 
            this.txtNumIDUpdated.Location = new System.Drawing.Point(152, 19);
            this.txtNumIDUpdated.Name = "txtNumIDUpdated";
            this.txtNumIDUpdated.Size = new System.Drawing.Size(358, 23);
            this.txtNumIDUpdated.TabIndex = 19;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(299, 254);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // UpdatedDoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 302);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtNumIDUpdated);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.listBoxSpecialitiesUpdate);
            this.Controls.Add(this.numericUpDownAgeUpdate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLastNameUpdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNameUpdate);
            this.Controls.Add(this.label5);
            this.Name = "UpdatedDoctorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Updated Doctor";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAgeUpdate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBoxSpecialitiesUpdate;
        private NumericUpDown numericUpDownAgeUpdate;
        private Label label4;
        private Label label3;
        private TextBox txtLastNameUpdate;
        private Label label2;
        private TextBox txtNameUpdate;
        private Label label5;
        private Button btnSearch;
        private Label label1;
        private TextBox txtNumIDUpdated;
        private Button btnUpdate;
    }
}