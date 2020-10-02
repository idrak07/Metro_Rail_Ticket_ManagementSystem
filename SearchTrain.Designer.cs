namespace Metro_Rail_Ticket_Management
{
    partial class SearchTrain
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
            this.logoutBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.profileBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dashBtn = new System.Windows.Forms.Button();
            this.departurelabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.departureBox = new System.Windows.Forms.ComboBox();
            this.destinationCombo = new System.Windows.Forms.ComboBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.search = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.seatCombo = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.logoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutBtn.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logoutBtn.Location = new System.Drawing.Point(1031, 12);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(139, 45);
            this.logoutBtn.TabIndex = 6;
            this.logoutBtn.Text = "Log Out";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Algerian", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(229, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 45);
            this.label1.TabIndex = 7;
            this.label1.Text = "Search Train";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.BackgroundImage = global::Metro_Rail_Ticket_Management.Properties.Resources.Rhome;
            this.panel1.Controls.Add(this.profileBtn);
            this.panel1.Controls.Add(this.searchBtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dashBtn);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 652);
            this.panel1.TabIndex = 8;
            // 
            // profileBtn
            // 
            this.profileBtn.BackColor = System.Drawing.Color.Turquoise;
            this.profileBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileBtn.Location = new System.Drawing.Point(0, 194);
            this.profileBtn.Name = "profileBtn";
            this.profileBtn.Size = new System.Drawing.Size(190, 50);
            this.profileBtn.TabIndex = 8;
            this.profileBtn.Text = "Profile";
            this.profileBtn.UseVisualStyleBackColor = false;
            this.profileBtn.Click += new System.EventHandler(this.profileBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.Turquoise;
            this.searchBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(0, 147);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(190, 50);
            this.searchBtn.TabIndex = 7;
            this.searchBtn.Text = "Search Train";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 48);
            this.label2.TabIndex = 5;
            this.label2.Text = "MRTMS";
            // 
            // dashBtn
            // 
            this.dashBtn.BackColor = System.Drawing.Color.Turquoise;
            this.dashBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashBtn.Location = new System.Drawing.Point(0, 100);
            this.dashBtn.Name = "dashBtn";
            this.dashBtn.Size = new System.Drawing.Size(190, 50);
            this.dashBtn.TabIndex = 1;
            this.dashBtn.Text = "Dashboard";
            this.dashBtn.UseVisualStyleBackColor = false;
            this.dashBtn.Click += new System.EventHandler(this.dashBtn_Click);
            // 
            // departurelabel
            // 
            this.departurelabel.AutoSize = true;
            this.departurelabel.BackColor = System.Drawing.Color.Transparent;
            this.departurelabel.Font = new System.Drawing.Font("Castellar", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departurelabel.ForeColor = System.Drawing.SystemColors.Control;
            this.departurelabel.Location = new System.Drawing.Point(402, 169);
            this.departurelabel.Name = "departurelabel";
            this.departurelabel.Size = new System.Drawing.Size(150, 25);
            this.departurelabel.TabIndex = 9;
            this.departurelabel.Text = "Departure";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Castellar", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(378, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Destination";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Castellar", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(478, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Date";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // departureBox
            // 
            this.departureBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departureBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departureBox.FormattingEnabled = true;
            this.departureBox.Items.AddRange(new object[] {
            "ABDULLAHPUR",
            "BASHUNDHARA",
            "BADDA ",
            "LINK ROAD",
            "GULSHAN-1",
            "GULSHAN-2",
            "MIRPUR-10",
            "MIRPUR-12",
            "KHILGAON",
            "MALIBAG",
            "KAMALAPUR",
            "JATRABARI",
            "SADARGHAT",
            "DHANMONDI",
            "SHYAMOLI",
            "KALLAYANPUR",
            "AGAGAON",
            "FARMGATE",
            "KARWAN BAZAR"});
            this.departureBox.Location = new System.Drawing.Point(624, 166);
            this.departureBox.Name = "departureBox";
            this.departureBox.Size = new System.Drawing.Size(311, 31);
            this.departureBox.TabIndex = 12;
            // 
            // destinationCombo
            // 
            this.destinationCombo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.destinationCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.destinationCombo.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destinationCombo.Items.AddRange(new object[] {
            "ABDULLAHPUR",
            "BASHUNDHARA",
            "BADDA ",
            "LINK ROAD",
            "GULSHAN-1",
            "GULSHAN-2",
            "MIRPUR-10",
            "MIRPUR-12",
            "KHILGAON",
            "MALIBAG",
            "KAMALAPUR",
            "JATRABARI",
            "SADARGHAT",
            "DHANMONDI",
            "SHYAMOLI",
            "KALLAYANPUR",
            "AGAGAON",
            "FARMGATE",
            "KARWAN BAZAR"});
            this.destinationCombo.Location = new System.Drawing.Point(624, 260);
            this.destinationCombo.Name = "destinationCombo";
            this.destinationCombo.Size = new System.Drawing.Size(311, 31);
            this.destinationCombo.TabIndex = 13;
            // 
            // date
            // 
            this.date.CustomFormat = "yyyy/MM/dd";
            this.date.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date.Location = new System.Drawing.Point(624, 350);
            this.date.MinDate = new System.DateTime(2020, 9, 17, 0, 0, 0, 0);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(200, 31);
            this.date.TabIndex = 14;
            this.date.Value = new System.DateTime(2020, 9, 17, 0, 0, 0, 0);
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.search.Location = new System.Drawing.Point(543, 528);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(139, 45);
            this.search.TabIndex = 15;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Castellar", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(478, 436);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Seat";
            // 
            // seatCombo
            // 
            this.seatCombo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.seatCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.seatCombo.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seatCombo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.seatCombo.Location = new System.Drawing.Point(624, 436);
            this.seatCombo.Name = "seatCombo";
            this.seatCombo.Size = new System.Drawing.Size(311, 31);
            this.seatCombo.TabIndex = 17;
            // 
            // SearchTrain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Metro_Rail_Ticket_Management.Properties.Resources.Rhome;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.seatCombo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.search);
            this.Controls.Add(this.date);
            this.Controls.Add(this.destinationCombo);
            this.Controls.Add(this.departureBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.departurelabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logoutBtn);
            this.Name = "SearchTrain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchTrain";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button profileBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button dashBtn;
        private System.Windows.Forms.Label departurelabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox departureBox;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.ComboBox destinationCombo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox seatCombo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}