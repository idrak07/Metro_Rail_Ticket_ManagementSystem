namespace Metro_Rail_Ticket_Management
{
    partial class AdminDashboard
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.profileBtn = new System.Windows.Forms.Button();
            this.scheduleBtn = new System.Windows.Forms.Button();
            this.addTrainBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dashBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.timeTable = new System.Windows.Forms.DateTimePicker();
            this.searchTrainBtn = new System.Windows.Forms.Button();
            this.nibirProjectDataSet = new Metro_Rail_Ticket_Management.NibirProjectDataSet();
            this.trainsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trainsTableAdapter = new Metro_Rail_Ticket_Management.NibirProjectDataSetTableAdapters.trainsTableAdapter();
            this.trainCombo = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nibirProjectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.BackgroundImage = global::Metro_Rail_Ticket_Management.Properties.Resources.Rhome;
            this.panel1.Controls.Add(this.profileBtn);
            this.panel1.Controls.Add(this.scheduleBtn);
            this.panel1.Controls.Add(this.addTrainBtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dashBtn);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 652);
            this.panel1.TabIndex = 10;
            // 
            // profileBtn
            // 
            this.profileBtn.BackColor = System.Drawing.Color.Turquoise;
            this.profileBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileBtn.Location = new System.Drawing.Point(0, 241);
            this.profileBtn.Name = "profileBtn";
            this.profileBtn.Size = new System.Drawing.Size(190, 50);
            this.profileBtn.TabIndex = 9;
            this.profileBtn.Text = "Profile";
            this.profileBtn.UseVisualStyleBackColor = false;
            // 
            // scheduleBtn
            // 
            this.scheduleBtn.BackColor = System.Drawing.Color.Turquoise;
            this.scheduleBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scheduleBtn.Location = new System.Drawing.Point(0, 194);
            this.scheduleBtn.Name = "scheduleBtn";
            this.scheduleBtn.Size = new System.Drawing.Size(190, 50);
            this.scheduleBtn.TabIndex = 8;
            this.scheduleBtn.Text = "Add Schedule";
            this.scheduleBtn.UseVisualStyleBackColor = false;
            this.scheduleBtn.Click += new System.EventHandler(this.scheduleBtn_Click);
            // 
            // addTrainBtn
            // 
            this.addTrainBtn.BackColor = System.Drawing.Color.Turquoise;
            this.addTrainBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTrainBtn.Location = new System.Drawing.Point(0, 147);
            this.addTrainBtn.Name = "addTrainBtn";
            this.addTrainBtn.Size = new System.Drawing.Size(190, 50);
            this.addTrainBtn.TabIndex = 7;
            this.addTrainBtn.Text = "Add Train";
            this.addTrainBtn.UseVisualStyleBackColor = false;
            this.addTrainBtn.Click += new System.EventHandler(this.searchBtn_Click);
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
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.logoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutBtn.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logoutBtn.Location = new System.Drawing.Point(1031, 12);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(139, 45);
            this.logoutBtn.TabIndex = 12;
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
            this.label1.Location = new System.Drawing.Point(250, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 45);
            this.label1.TabIndex = 13;
            this.label1.Text = "Dashboard";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Font = new System.Drawing.Font("Castellar", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.nameLabel.Location = new System.Drawing.Point(397, 219);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(166, 25);
            this.nameLabel.TabIndex = 14;
            this.nameLabel.Text = "Train Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Castellar", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(489, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Castellar", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(493, 377);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Time";
            // 
            // date
            // 
            this.date.CustomFormat = "yyyy/MM/dd";
            this.date.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date.Location = new System.Drawing.Point(627, 285);
            this.date.MinDate = new System.DateTime(2020, 9, 24, 0, 0, 0, 0);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(200, 31);
            this.date.TabIndex = 17;
            this.date.Value = new System.DateTime(2020, 9, 24, 0, 0, 0, 0);
            // 
            // timeTable
            // 
            this.timeTable.CustomFormat = "HH:mm:ss";
            this.timeTable.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeTable.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeTable.Location = new System.Drawing.Point(627, 378);
            this.timeTable.Name = "timeTable";
            this.timeTable.ShowUpDown = true;
            this.timeTable.Size = new System.Drawing.Size(200, 31);
            this.timeTable.TabIndex = 18;
            this.timeTable.ValueChanged += new System.EventHandler(this.timeTable_ValueChanged);
            // 
            // searchTrainBtn
            // 
            this.searchTrainBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.searchTrainBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchTrainBtn.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTrainBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.searchTrainBtn.Location = new System.Drawing.Point(541, 476);
            this.searchTrainBtn.Name = "searchTrainBtn";
            this.searchTrainBtn.Size = new System.Drawing.Size(139, 45);
            this.searchTrainBtn.TabIndex = 20;
            this.searchTrainBtn.Text = "Search Train";
            this.searchTrainBtn.UseVisualStyleBackColor = false;
            this.searchTrainBtn.Click += new System.EventHandler(this.searchTrainBtn_Click);
            // 
            // nibirProjectDataSet
            // 
            this.nibirProjectDataSet.DataSetName = "NibirProjectDataSet";
            this.nibirProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // trainsBindingSource
            // 
            this.trainsBindingSource.DataMember = "trains";
            this.trainsBindingSource.DataSource = this.nibirProjectDataSet;
            // 
            // trainsTableAdapter
            // 
            this.trainsTableAdapter.ClearBeforeFill = true;
            // 
            // trainCombo
            // 
            this.trainCombo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.trainsBindingSource, "trainname", true));
            this.trainCombo.DataSource = this.trainsBindingSource;
            this.trainCombo.DisplayMember = "trainname";
            this.trainCombo.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trainCombo.FormattingEnabled = true;
            this.trainCombo.Location = new System.Drawing.Point(627, 222);
            this.trainCombo.Name = "trainCombo";
            this.trainCombo.Size = new System.Drawing.Size(320, 31);
            this.trainCombo.TabIndex = 22;
            this.trainCombo.ValueMember = "trainname";
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Metro_Rail_Ticket_Management.Properties.Resources.Rhome;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.trainCombo);
            this.Controls.Add(this.searchTrainBtn);
            this.Controls.Add(this.timeTable);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.panel1);
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nibirProjectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button scheduleBtn;
        private System.Windows.Forms.Button addTrainBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button dashBtn;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button profileBtn;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.DateTimePicker timeTable;
        private System.Windows.Forms.Button searchTrainBtn;
        private NibirProjectDataSet nibirProjectDataSet;
        private System.Windows.Forms.BindingSource trainsBindingSource;
        private NibirProjectDataSetTableAdapters.trainsTableAdapter trainsTableAdapter;
        private System.Windows.Forms.ComboBox trainCombo;
    }
}