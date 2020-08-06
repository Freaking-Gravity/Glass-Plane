namespace Glass_Shield
{
    partial class Glass_Plane
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Glass_Plane));
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.blackWindowButton = new System.Windows.Forms.RadioButton();
            this.transparentRadio = new System.Windows.Forms.RadioButton();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox.BackColor = System.Drawing.Color.Black;
            this.groupBox.Controls.Add(this.numericUpDown1);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Controls.Add(this.blackWindowButton);
            this.groupBox.Controls.Add(this.transparentRadio);
            this.groupBox.Controls.Add(this.ConfirmButton);
            this.groupBox.Location = new System.Drawing.Point(621, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(136, 107);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.DimGray;
            this.numericUpDown1.ForeColor = System.Drawing.Color.White;
            this.numericUpDown1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown1.Location = new System.Drawing.Point(68, 73);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(54, 22);
            this.numericUpDown1.TabIndex = 8;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(6, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Opacity";
            // 
            // blackWindowButton
            // 
            this.blackWindowButton.AutoSize = true;
            this.blackWindowButton.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.blackWindowButton.Location = new System.Drawing.Point(6, 49);
            this.blackWindowButton.Name = "blackWindowButton";
            this.blackWindowButton.Size = new System.Drawing.Size(83, 21);
            this.blackWindowButton.TabIndex = 2;
            this.blackWindowButton.TabStop = true;
            this.blackWindowButton.Text = "Sizeable";
            this.blackWindowButton.UseVisualStyleBackColor = true;
            this.blackWindowButton.CheckedChanged += new System.EventHandler(this.blackWindowButton_CheckedChanged);
            // 
            // transparentRadio
            // 
            this.transparentRadio.AutoSize = true;
            this.transparentRadio.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.transparentRadio.Location = new System.Drawing.Point(6, 21);
            this.transparentRadio.Name = "transparentRadio";
            this.transparentRadio.Size = new System.Drawing.Size(94, 21);
            this.transparentRadio.TabIndex = 1;
            this.transparentRadio.TabStop = true;
            this.transparentRadio.Text = "No Border";
            this.transparentRadio.UseVisualStyleBackColor = true;
            this.transparentRadio.CheckedChanged += new System.EventHandler(this.transparentRadio_CheckedChanged);
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(47, 303);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(75, 23);
            this.ConfirmButton.TabIndex = 0;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            // 
            // ResetButton
            // 
            this.ResetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetButton.BackColor = System.Drawing.Color.DimGray;
            this.ResetButton.Cursor = System.Windows.Forms.Cursors.No;
            this.ResetButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ResetButton.ForeColor = System.Drawing.Color.White;
            this.ResetButton.Location = new System.Drawing.Point(763, 12);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(25, 25);
            this.ResetButton.TabIndex = 7;
            this.ResetButton.Text = "X";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // Glass_Plane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.CancelButton = this.ResetButton;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.ResetButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Glass_Plane";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Glass_Plane";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.RadioButton blackWindowButton;
        private System.Windows.Forms.RadioButton transparentRadio;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

