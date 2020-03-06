namespace TickerPicker
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.randomBtn = new System.Windows.Forms.Button();
            this.optionsCB = new System.Windows.Forms.CheckBox();
            this.whatDoLabel = new System.Windows.Forms.Label();
            this.whatDoBtn = new System.Windows.Forms.Button();
            this.outLabel = new System.Windows.Forms.Label();
            this.stockLabel = new System.Windows.Forms.Label();
            this.listGB = new System.Windows.Forms.GroupBox();
            this.populateBtn = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.listGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.stockLabel);
            this.groupBox1.Controls.Add(this.optionsCB);
            this.groupBox1.Controls.Add(this.whatDoLabel);
            this.groupBox1.Controls.Add(this.whatDoBtn);
            this.groupBox1.Controls.Add(this.outLabel);
            this.groupBox1.Controls.Add(this.randomBtn);
            this.groupBox1.Location = new System.Drawing.Point(313, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 463);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Your Stock Pick";
            // 
            // randomBtn
            // 
            this.randomBtn.Location = new System.Drawing.Point(24, 30);
            this.randomBtn.Name = "randomBtn";
            this.randomBtn.Size = new System.Drawing.Size(155, 57);
            this.randomBtn.TabIndex = 4;
            this.randomBtn.Text = "Get Random Stock";
            this.randomBtn.UseVisualStyleBackColor = true;
            this.randomBtn.Click += new System.EventHandler(this.randomBtn_Click);
            // 
            // optionsCB
            // 
            this.optionsCB.AutoSize = true;
            this.optionsCB.Location = new System.Drawing.Point(23, 171);
            this.optionsCB.Name = "optionsCB";
            this.optionsCB.Size = new System.Drawing.Size(195, 21);
            this.optionsCB.TabIndex = 12;
            this.optionsCB.Text = "Options trading available?";
            this.optionsCB.UseVisualStyleBackColor = true;
            // 
            // whatDoLabel
            // 
            this.whatDoLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.whatDoLabel.Location = new System.Drawing.Point(23, 257);
            this.whatDoLabel.Name = "whatDoLabel";
            this.whatDoLabel.Size = new System.Drawing.Size(254, 32);
            this.whatDoLabel.TabIndex = 11;
            // 
            // whatDoBtn
            // 
            this.whatDoBtn.Location = new System.Drawing.Point(24, 198);
            this.whatDoBtn.Name = "whatDoBtn";
            this.whatDoBtn.Size = new System.Drawing.Size(253, 47);
            this.whatDoBtn.TabIndex = 10;
            this.whatDoBtn.Text = "What should I do with it?";
            this.whatDoBtn.UseVisualStyleBackColor = true;
            this.whatDoBtn.Click += new System.EventHandler(this.whatDoBtn_Click);
            // 
            // outLabel
            // 
            this.outLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.outLabel.Font = new System.Drawing.Font("Wide Latin", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outLabel.Location = new System.Drawing.Point(24, 135);
            this.outLabel.Name = "outLabel";
            this.outLabel.Size = new System.Drawing.Size(194, 32);
            this.outLabel.TabIndex = 9;
            this.outLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stockLabel
            // 
            this.stockLabel.AutoSize = true;
            this.stockLabel.Location = new System.Drawing.Point(21, 106);
            this.stockLabel.Name = "stockLabel";
            this.stockLabel.Size = new System.Drawing.Size(122, 17);
            this.stockLabel.TabIndex = 13;
            this.stockLabel.Text = "Your stock pick is:";
            // 
            // listGB
            // 
            this.listGB.Controls.Add(this.populateBtn);
            this.listGB.Controls.Add(this.listBox);
            this.listGB.Location = new System.Drawing.Point(39, 33);
            this.listGB.Name = "listGB";
            this.listGB.Size = new System.Drawing.Size(246, 463);
            this.listGB.TabIndex = 10;
            this.listGB.TabStop = false;
            this.listGB.Text = "NYSE/NASDAQ Stocks";
            // 
            // populateBtn
            // 
            this.populateBtn.Location = new System.Drawing.Point(30, 328);
            this.populateBtn.Name = "populateBtn";
            this.populateBtn.Size = new System.Drawing.Size(182, 57);
            this.populateBtn.TabIndex = 7;
            this.populateBtn.Text = "Populate List";
            this.populateBtn.UseVisualStyleBackColor = true;
            this.populateBtn.Click += new System.EventHandler(this.populateBtn_Click_1);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(30, 49);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(182, 260);
            this.listBox.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(11, 303);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(282, 143);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 605);
            this.Controls.Add(this.listGB);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Ticker Picker";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.listGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label stockLabel;
        private System.Windows.Forms.CheckBox optionsCB;
        private System.Windows.Forms.Label whatDoLabel;
        private System.Windows.Forms.Button whatDoBtn;
        private System.Windows.Forms.Label outLabel;
        private System.Windows.Forms.Button randomBtn;
        private System.Windows.Forms.GroupBox listGB;
        private System.Windows.Forms.Button populateBtn;
        private System.Windows.Forms.ListBox listBox;
    }
}

