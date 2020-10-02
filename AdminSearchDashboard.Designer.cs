namespace Metro_Rail_Ticket_Management
{
    partial class AdminSearchDashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.profileBtn = new System.Windows.Forms.Button();
            this.scheduleBtn = new System.Windows.Forms.Button();
            this.addTrainBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dashBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchDash = new System.Windows.Forms.DataGridView();
            this.trainName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewButtonColumn();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.notfoundLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchDash)).BeginInit();
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
            this.panel1.TabIndex = 11;
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
            this.label1.TabIndex = 11;
            this.label1.Text = "Search Train";
            // 
            // searchDash
            // 
            this.searchDash.AllowUserToAddRows = false;
            this.searchDash.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.searchDash.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.searchDash.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.searchDash.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchDash.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.trainName,
            this.departure,
            this.destination,
            this.date,
            this.time,
            this.seat,
            this.Class,
            this.fare,
            this.Action});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.searchDash.DefaultCellStyle = dataGridViewCellStyle2;
            this.searchDash.Location = new System.Drawing.Point(210, 100);
            this.searchDash.Name = "searchDash";
            this.searchDash.ReadOnly = true;
            this.searchDash.RowHeadersVisible = false;
            this.searchDash.RowHeadersWidth = 51;
            this.searchDash.RowTemplate.Height = 24;
            this.searchDash.Size = new System.Drawing.Size(960, 500);
            this.searchDash.TabIndex = 13;
            this.searchDash.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.searchDash_CellContentClick);
            // 
            // trainName
            // 
            this.trainName.DataPropertyName = "trainname";
            this.trainName.HeaderText = "Train";
            this.trainName.MinimumWidth = 6;
            this.trainName.Name = "trainName";
            this.trainName.ReadOnly = true;
            // 
            // departure
            // 
            this.departure.DataPropertyName = "departure";
            this.departure.HeaderText = "Departure";
            this.departure.MinimumWidth = 6;
            this.departure.Name = "departure";
            this.departure.ReadOnly = true;
            // 
            // destination
            // 
            this.destination.DataPropertyName = "destination";
            this.destination.HeaderText = "Destination";
            this.destination.MinimumWidth = 6;
            this.destination.Name = "destination";
            this.destination.ReadOnly = true;
            // 
            // date
            // 
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "Date";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // time
            // 
            this.time.DataPropertyName = "time";
            this.time.HeaderText = "Time";
            this.time.MinimumWidth = 6;
            this.time.Name = "time";
            this.time.ReadOnly = true;
            // 
            // seat
            // 
            this.seat.DataPropertyName = "availableseat";
            this.seat.HeaderText = "Available Seat";
            this.seat.MinimumWidth = 6;
            this.seat.Name = "seat";
            this.seat.ReadOnly = true;
            // 
            // Class
            // 
            this.Class.DataPropertyName = "class";
            this.Class.HeaderText = "Class";
            this.Class.MinimumWidth = 6;
            this.Class.Name = "Class";
            this.Class.ReadOnly = true;
            // 
            // fare
            // 
            this.fare.DataPropertyName = "fare";
            this.fare.HeaderText = "Fare";
            this.fare.MinimumWidth = 6;
            this.fare.Name = "fare";
            this.fare.ReadOnly = true;
            // 
            // Action
            // 
            this.Action.HeaderText = "Action";
            this.Action.MinimumWidth = 6;
            this.Action.Name = "Action";
            this.Action.ReadOnly = true;
            this.Action.Text = "Delete";
            this.Action.UseColumnTextForButtonValue = true;
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
            this.logoutBtn.TabIndex = 14;
            this.logoutBtn.Text = "Log Out";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // notfoundLabel
            // 
            this.notfoundLabel.AutoSize = true;
            this.notfoundLabel.BackColor = System.Drawing.Color.Transparent;
            this.notfoundLabel.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notfoundLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.notfoundLabel.Location = new System.Drawing.Point(525, 300);
            this.notfoundLabel.Name = "notfoundLabel";
            this.notfoundLabel.Size = new System.Drawing.Size(284, 47);
            this.notfoundLabel.TabIndex = 15;
            this.notfoundLabel.Text = "No Train Found";
            this.notfoundLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.notfoundLabel.Visible = false;
            // 
            // AdminSearchDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Metro_Rail_Ticket_Management.Properties.Resources.Rhome;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.notfoundLabel);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.searchDash);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "AdminSearchDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminSearchDashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchDash)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button profileBtn;
        private System.Windows.Forms.Button scheduleBtn;
        private System.Windows.Forms.Button addTrainBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button dashBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView searchDash;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainName;
        private System.Windows.Forms.DataGridViewTextBoxColumn departure;
        private System.Windows.Forms.DataGridViewTextBoxColumn destination;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn seat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class;
        private System.Windows.Forms.DataGridViewTextBoxColumn fare;
        private System.Windows.Forms.DataGridViewButtonColumn Action;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Label notfoundLabel;
    }
}