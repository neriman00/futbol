namespace FootBall
{
    partial class stadion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stadion));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnstadium = new System.Windows.Forms.Button();
            this.btnRooms = new System.Windows.Forms.Button();
            this.btnclients = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnReserv = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnclients);
            this.panel1.Controls.Add(this.btnRooms);
            this.panel1.Controls.Add(this.btnstadium);
            this.panel1.Controls.Add(this.btnReserv);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(379, 728);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // btnstadium
            // 
            this.btnstadium.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnstadium.FlatAppearance.BorderSize = 0;
            this.btnstadium.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnstadium.Font = new System.Drawing.Font("MV Boli", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstadium.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnstadium.Image = ((System.Drawing.Image)(resources.GetObject("btnstadium.Image")));
            this.btnstadium.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnstadium.Location = new System.Drawing.Point(0, 313);
            this.btnstadium.Name = "btnstadium";
            this.btnstadium.Size = new System.Drawing.Size(376, 74);
            this.btnstadium.TabIndex = 2;
            this.btnstadium.Text = "Stadium";
            this.btnstadium.UseVisualStyleBackColor = false;
            // 
            // btnRooms
            // 
            this.btnRooms.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnRooms.FlatAppearance.BorderSize = 0;
            this.btnRooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRooms.Font = new System.Drawing.Font("MV Boli", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRooms.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRooms.Image = ((System.Drawing.Image)(resources.GetObject("btnRooms.Image")));
            this.btnRooms.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRooms.Location = new System.Drawing.Point(0, 411);
            this.btnRooms.Name = "btnRooms";
            this.btnRooms.Size = new System.Drawing.Size(376, 74);
            this.btnRooms.TabIndex = 3;
            this.btnRooms.Text = "Rooms";
            this.btnRooms.UseVisualStyleBackColor = false;
            // 
            // btnclients
            // 
            this.btnclients.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnclients.FlatAppearance.BorderSize = 0;
            this.btnclients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclients.Font = new System.Drawing.Font("MV Boli", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclients.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnclients.Image = ((System.Drawing.Image)(resources.GetObject("btnclients.Image")));
            this.btnclients.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclients.Location = new System.Drawing.Point(-3, 506);
            this.btnclients.Name = "btnclients";
            this.btnclients.Size = new System.Drawing.Size(379, 74);
            this.btnclients.TabIndex = 4;
            this.btnclients.Text = "Clients";
            this.btnclients.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(376, 177);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(921, 551);
            this.dataGridView1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FootBall.Properties.Resources.footballo;
            this.pictureBox2.Location = new System.Drawing.Point(3, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(375, 179);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // btnReserv
            // 
            this.btnReserv.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnReserv.FlatAppearance.BorderSize = 0;
            this.btnReserv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReserv.Font = new System.Drawing.Font("MV Boli", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReserv.ForeColor = System.Drawing.Color.White;
            this.btnReserv.Image = ((System.Drawing.Image)(resources.GetObject("btnReserv.Image")));
            this.btnReserv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReserv.Location = new System.Drawing.Point(0, 216);
            this.btnReserv.Name = "btnReserv";
            this.btnReserv.Size = new System.Drawing.Size(376, 74);
            this.btnReserv.TabIndex = 1;
            this.btnReserv.Text = "Reservetion";
            this.btnReserv.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Location = new System.Drawing.Point(376, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(921, 179);
            this.panel2.TabIndex = 2;
            // 
            // stadion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 728);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "stadion";
            this.Text = "Stadium";
            this.Load += new System.EventHandler(this.Stadion_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRooms;
        private System.Windows.Forms.Button btnstadium;
        private System.Windows.Forms.Button btnReserv;
        private System.Windows.Forms.Button btnclients;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
    }
}