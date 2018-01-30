namespace Vid2Gif
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.submitButton = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.fileText = new System.Windows.Forms.TextBox();
            this.fileSelect = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.scaleText = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.startTimeText = new System.Windows.Forms.NumericUpDown();
            this.lengthText = new System.Windows.Forms.NumericUpDown();
            this.fpsText = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scaleText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startTimeText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lengthText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpsText)).BeginInit();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(12, 306);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(219, 23);
            this.submitButton.TabIndex = 0;
            this.submitButton.Text = "Convert";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // openFile
            // 
            this.openFile.FileName = "openFile";
            // 
            // fileText
            // 
            this.fileText.Location = new System.Drawing.Point(12, 12);
            this.fileText.Name = "fileText";
            this.fileText.Size = new System.Drawing.Size(188, 20);
            this.fileText.TabIndex = 1;
            // 
            // fileSelect
            // 
            this.fileSelect.Location = new System.Drawing.Point(206, 11);
            this.fileSelect.Name = "fileSelect";
            this.fileSelect.Size = new System.Drawing.Size(25, 21);
            this.fileSelect.TabIndex = 2;
            this.fileSelect.Text = "...";
            this.fileSelect.UseVisualStyleBackColor = true;
            this.fileSelect.Click += new System.EventHandler(this.fileSelect_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.scaleText);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.startTimeText);
            this.groupBox1.Controls.Add(this.lengthText);
            this.groupBox1.Controls.Add(this.fpsText);
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 192);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(146, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "px";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Scale";
            // 
            // scaleText
            // 
            this.scaleText.Location = new System.Drawing.Point(82, 131);
            this.scaleText.Maximum = new decimal(new int[] {
            355535,
            0,
            0,
            0});
            this.scaleText.Name = "scaleText";
            this.scaleText.Size = new System.Drawing.Size(58, 20);
            this.scaleText.TabIndex = 8;
            this.scaleText.Value = new decimal(new int[] {
            480,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(146, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Seconds";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(146, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Seconds";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Start Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Length";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "FPS";
            // 
            // startTimeText
            // 
            this.startTimeText.Location = new System.Drawing.Point(82, 93);
            this.startTimeText.Maximum = new decimal(new int[] {
            355535,
            0,
            0,
            0});
            this.startTimeText.Name = "startTimeText";
            this.startTimeText.Size = new System.Drawing.Size(58, 20);
            this.startTimeText.TabIndex = 2;
            // 
            // lengthText
            // 
            this.lengthText.Location = new System.Drawing.Point(82, 56);
            this.lengthText.Maximum = new decimal(new int[] {
            355535,
            0,
            0,
            0});
            this.lengthText.Name = "lengthText";
            this.lengthText.Size = new System.Drawing.Size(58, 20);
            this.lengthText.TabIndex = 1;
            this.lengthText.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // fpsText
            // 
            this.fpsText.Location = new System.Drawing.Point(82, 19);
            this.fpsText.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.fpsText.Name = "fpsText";
            this.fpsText.Size = new System.Drawing.Size(58, 20);
            this.fpsText.TabIndex = 0;
            this.fpsText.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 341);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.fileSelect);
            this.Controls.Add(this.fileText);
            this.Controls.Add(this.submitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VidGiffer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scaleText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startTimeText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lengthText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpsText)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.TextBox fileText;
        private System.Windows.Forms.Button fileSelect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown startTimeText;
        private System.Windows.Forms.NumericUpDown lengthText;
        private System.Windows.Forms.NumericUpDown fpsText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown scaleText;
    }
}

