namespace VTP_parser
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ExcelBehaviorText = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ExcelDescriptionText = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ExcelDomainText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ExcelFileNameText = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.VBBehaviorText = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.VBDescriptionText = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.VBDomainText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.VBFileNameText = new System.Windows.Forms.TextBox();
            this.SuccessButton = new System.Windows.Forms.Button();
            this.VBTestButton = new System.Windows.Forms.Button();
            this.ExcelButton = new System.Windows.Forms.Button();
            this.CopyVB = new System.Windows.Forms.Button();
            this.CopyExcel = new System.Windows.Forms.Button();
            this.MissmatchButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(816, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Analyze";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(654, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(283, 575);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CopyVB);
            this.groupBox1.Controls.Add(this.ExcelBehaviorText);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ExcelDescriptionText);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ExcelDomainText);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ExcelFileNameText);
            this.groupBox1.Location = new System.Drawing.Point(294, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 404);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Excel File";
            // 
            // ExcelBehaviorText
            // 
            this.ExcelBehaviorText.Location = new System.Drawing.Point(29, 239);
            this.ExcelBehaviorText.Name = "ExcelBehaviorText";
            this.ExcelBehaviorText.Size = new System.Drawing.Size(253, 96);
            this.ExcelBehaviorText.TabIndex = 8;
            this.ExcelBehaviorText.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Test Behavior";
            // 
            // ExcelDescriptionText
            // 
            this.ExcelDescriptionText.Location = new System.Drawing.Point(30, 125);
            this.ExcelDescriptionText.Name = "ExcelDescriptionText";
            this.ExcelDescriptionText.Size = new System.Drawing.Size(253, 96);
            this.ExcelDescriptionText.TabIndex = 6;
            this.ExcelDescriptionText.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Test Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Test Domain";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExcelDomainText
            // 
            this.ExcelDomainText.Location = new System.Drawing.Point(29, 80);
            this.ExcelDomainText.Name = "ExcelDomainText";
            this.ExcelDomainText.Size = new System.Drawing.Size(254, 20);
            this.ExcelDomainText.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Test File Name";
            // 
            // ExcelFileNameText
            // 
            this.ExcelFileNameText.Location = new System.Drawing.Point(30, 36);
            this.ExcelFileNameText.Name = "ExcelFileNameText";
            this.ExcelFileNameText.Size = new System.Drawing.Size(254, 20);
            this.ExcelFileNameText.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CopyExcel);
            this.groupBox2.Controls.Add(this.VBBehaviorText);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.VBDescriptionText);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.VBDomainText);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.VBFileNameText);
            this.groupBox2.Location = new System.Drawing.Point(607, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 402);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "VB File";
            // 
            // VBBehaviorText
            // 
            this.VBBehaviorText.Location = new System.Drawing.Point(29, 239);
            this.VBBehaviorText.Name = "VBBehaviorText";
            this.VBBehaviorText.Size = new System.Drawing.Size(253, 96);
            this.VBBehaviorText.TabIndex = 8;
            this.VBBehaviorText.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Test Behavior";
            // 
            // VBDescriptionText
            // 
            this.VBDescriptionText.Location = new System.Drawing.Point(30, 125);
            this.VBDescriptionText.Name = "VBDescriptionText";
            this.VBDescriptionText.Size = new System.Drawing.Size(253, 96);
            this.VBDescriptionText.TabIndex = 6;
            this.VBDescriptionText.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Test Description";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Test Domain";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VBDomainText
            // 
            this.VBDomainText.Location = new System.Drawing.Point(30, 80);
            this.VBDomainText.Name = "VBDomainText";
            this.VBDomainText.Size = new System.Drawing.Size(254, 20);
            this.VBDomainText.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Test File Name";
            // 
            // VBFileNameText
            // 
            this.VBFileNameText.Location = new System.Drawing.Point(30, 36);
            this.VBFileNameText.Name = "VBFileNameText";
            this.VBFileNameText.Size = new System.Drawing.Size(254, 20);
            this.VBFileNameText.TabIndex = 0;
            // 
            // SuccessButton
            // 
            this.SuccessButton.Enabled = false;
            this.SuccessButton.Location = new System.Drawing.Point(12, 31);
            this.SuccessButton.Name = "SuccessButton";
            this.SuccessButton.Size = new System.Drawing.Size(75, 23);
            this.SuccessButton.TabIndex = 10;
            this.SuccessButton.Text = "Success";
            this.SuccessButton.Click += new System.EventHandler(this.SuccessButton_Click);
            // 
            // VBTestButton
            // 
            this.VBTestButton.Enabled = false;
            this.VBTestButton.Location = new System.Drawing.Point(102, 31);
            this.VBTestButton.Name = "VBTestButton";
            this.VBTestButton.Size = new System.Drawing.Size(148, 23);
            this.VBTestButton.TabIndex = 11;
            this.VBTestButton.Text = "Orphan VB Test Cases";
            this.VBTestButton.UseVisualStyleBackColor = true;
            this.VBTestButton.Click += new System.EventHandler(this.VBTestButton_Click);
            // 
            // ExcelButton
            // 
            this.ExcelButton.Enabled = false;
            this.ExcelButton.Location = new System.Drawing.Point(102, 60);
            this.ExcelButton.Name = "ExcelButton";
            this.ExcelButton.Size = new System.Drawing.Size(148, 23);
            this.ExcelButton.TabIndex = 12;
            this.ExcelButton.Text = "Orphan Excel Definition";
            this.ExcelButton.UseVisualStyleBackColor = true;
            this.ExcelButton.Click += new System.EventHandler(this.ExcelButton_Click);
            // 
            // CopyVB
            // 
            this.CopyVB.Location = new System.Drawing.Point(190, 360);
            this.CopyVB.Name = "CopyVB";
            this.CopyVB.Size = new System.Drawing.Size(92, 23);
            this.CopyVB.TabIndex = 9;
            this.CopyVB.Text = "Copy To VB ->>";
            this.CopyVB.UseVisualStyleBackColor = true;
            // 
            // CopyExcel
            // 
            this.CopyExcel.Location = new System.Drawing.Point(30, 358);
            this.CopyExcel.Name = "CopyExcel";
            this.CopyExcel.Size = new System.Drawing.Size(107, 23);
            this.CopyExcel.TabIndex = 10;
            this.CopyExcel.Text = "<<- Copy to Excel";
            this.CopyExcel.UseVisualStyleBackColor = true;
            // 
            // MissmatchButton
            // 
            this.MissmatchButton.Enabled = false;
            this.MissmatchButton.Location = new System.Drawing.Point(12, 60);
            this.MissmatchButton.Name = "MissmatchButton";
            this.MissmatchButton.Size = new System.Drawing.Size(75, 23);
            this.MissmatchButton.TabIndex = 13;
            this.MissmatchButton.Text = "Missmatch";
            this.MissmatchButton.UseVisualStyleBackColor = true;
            this.MissmatchButton.Click += new System.EventHandler(this.MissmatchButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(557, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "label9";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 667);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.MissmatchButton);
            this.Controls.Add(this.ExcelButton);
            this.Controls.Add(this.VBTestButton);
            this.Controls.Add(this.SuccessButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ExcelFileNameText;
        private System.Windows.Forms.RichTextBox ExcelBehaviorText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox ExcelDescriptionText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ExcelDomainText;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox VBBehaviorText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox VBDescriptionText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox VBDomainText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox VBFileNameText;
        private System.Windows.Forms.Button SuccessButton;
        private System.Windows.Forms.Button VBTestButton;
        private System.Windows.Forms.Button ExcelButton;
        private System.Windows.Forms.Button CopyVB;
        private System.Windows.Forms.Button CopyExcel;
        private System.Windows.Forms.Button MissmatchButton;
        private System.Windows.Forms.Label label9;
    }
}

