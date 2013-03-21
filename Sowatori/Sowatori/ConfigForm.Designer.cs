namespace Sowatori
{
    partial class ConfigForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.LengthLabel = new System.Windows.Forms.Label();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.DiffLabel = new System.Windows.Forms.Label();
            this.LengthBar = new System.Windows.Forms.TrackBar();
            this.HeightBar = new System.Windows.Forms.TrackBar();
            this.DiffBar = new System.Windows.Forms.TrackBar();
            this.LengthNumLabel = new System.Windows.Forms.Label();
            this.HeightNumLabel = new System.Windows.Forms.Label();
            this.DiffNumLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LengthBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiffBar)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(167, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "ПриНЯть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LengthLabel
            // 
            this.LengthLabel.AutoSize = true;
            this.LengthLabel.Location = new System.Drawing.Point(9, 13);
            this.LengthLabel.Name = "LengthLabel";
            this.LengthLabel.Size = new System.Drawing.Size(70, 13);
            this.LengthLabel.TabIndex = 1;
            this.LengthLabel.Text = "Длина поля:";
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Location = new System.Drawing.Point(9, 94);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(76, 13);
            this.HeightLabel.TabIndex = 2;
            this.HeightLabel.Text = "Ширина поля:";
            // 
            // DiffLabel
            // 
            this.DiffLabel.AutoSize = true;
            this.DiffLabel.Location = new System.Drawing.Point(144, 13);
            this.DiffLabel.Name = "DiffLabel";
            this.DiffLabel.Size = new System.Drawing.Size(66, 13);
            this.DiffLabel.TabIndex = 5;
            this.DiffLabel.Text = "Сложность:";
            // 
            // LengthBar
            // 
            this.LengthBar.LargeChange = 2;
            this.LengthBar.Location = new System.Drawing.Point(3, 29);
            this.LengthBar.Name = "LengthBar";
            this.LengthBar.Size = new System.Drawing.Size(104, 45);
            this.LengthBar.SmallChange = 2;
            this.LengthBar.TabIndex = 2;
            this.LengthBar.Scroll += new System.EventHandler(this.LengthBar_Scroll);
            // 
            // HeightBar
            // 
            this.HeightBar.LargeChange = 2;
            this.HeightBar.Location = new System.Drawing.Point(3, 110);
            this.HeightBar.Name = "HeightBar";
            this.HeightBar.Size = new System.Drawing.Size(104, 45);
            this.HeightBar.SmallChange = 2;
            this.HeightBar.TabIndex = 2;
            this.HeightBar.Scroll += new System.EventHandler(this.HeightBar_Scroll);
            // 
            // DiffBar
            // 
            this.DiffBar.LargeChange = 2;
            this.DiffBar.Location = new System.Drawing.Point(138, 29);
            this.DiffBar.Minimum = 2;
            this.DiffBar.Name = "DiffBar";
            this.DiffBar.Size = new System.Drawing.Size(104, 45);
            this.DiffBar.SmallChange = 2;
            this.DiffBar.TabIndex = 2;
            this.DiffBar.Value = 2;
            this.DiffBar.Scroll += new System.EventHandler(this.DiffBar_Scroll);
            // 
            // LengthNumLabel
            // 
            this.LengthNumLabel.AutoSize = true;
            this.LengthNumLabel.Location = new System.Drawing.Point(85, 13);
            this.LengthNumLabel.Name = "LengthNumLabel";
            this.LengthNumLabel.Size = new System.Drawing.Size(0, 13);
            this.LengthNumLabel.TabIndex = 13;
            // 
            // HeightNumLabel
            // 
            this.HeightNumLabel.AutoSize = true;
            this.HeightNumLabel.Location = new System.Drawing.Point(91, 94);
            this.HeightNumLabel.Name = "HeightNumLabel";
            this.HeightNumLabel.Size = new System.Drawing.Size(0, 13);
            this.HeightNumLabel.TabIndex = 14;
            // 
            // DiffNumLabel
            // 
            this.DiffNumLabel.AutoSize = true;
            this.DiffNumLabel.Location = new System.Drawing.Point(207, 13);
            this.DiffNumLabel.Name = "DiffNumLabel";
            this.DiffNumLabel.Size = new System.Drawing.Size(0, 13);
            this.DiffNumLabel.TabIndex = 15;
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 155);
            this.Controls.Add(this.DiffNumLabel);
            this.Controls.Add(this.HeightNumLabel);
            this.Controls.Add(this.LengthNumLabel);
            this.Controls.Add(this.DiffBar);
            this.Controls.Add(this.HeightBar);
            this.Controls.Add(this.LengthBar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LengthLabel);
            this.Controls.Add(this.HeightLabel);
            this.Controls.Add(this.DiffLabel);
            this.Name = "ConfigForm";
            this.Text = "ConfigForm";
            this.Load += new System.EventHandler(this.ConfigForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LengthBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiffBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LengthLabel;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label DiffLabel;
        private System.Windows.Forms.TrackBar LengthBar;
        private System.Windows.Forms.TrackBar HeightBar;
        private System.Windows.Forms.TrackBar DiffBar;
        private System.Windows.Forms.Label LengthNumLabel;
        private System.Windows.Forms.Label HeightNumLabel;
        private System.Windows.Forms.Label DiffNumLabel;
    }
}