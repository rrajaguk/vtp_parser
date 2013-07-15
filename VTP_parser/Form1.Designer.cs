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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.VBProjLocationText = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ExcelBox = new System.Windows.Forms.GroupBox();
            this.CopyDomainExcel_VB = new System.Windows.Forms.Button();
            this.CopyDescriptionExcel_VB = new System.Windows.Forms.Button();
            this.CopyAllExcel_VB = new System.Windows.Forms.Button();
            this.ExcelDescriptionText = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ExcelDomainText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ExcelFileNameText = new System.Windows.Forms.TextBox();
            this.VBBox = new System.Windows.Forms.GroupBox();
            this.CopyDescriptionVB_Excel = new System.Windows.Forms.Button();
            this.CopyDomainVB_Excel = new System.Windows.Forms.Button();
            this.CopyAllVB_Excel = new System.Windows.Forms.Button();
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
            this.MissmatchButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.VTPLocationText = new System.Windows.Forms.TextBox();
            this.VBProjLocButton = new System.Windows.Forms.Button();
            this.ExcelLocButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.ExcelBox.SuspendLayout();
            this.VBBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(228, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Analyze";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // VBProjLocationText
            // 
            this.VBProjLocationText.Location = new System.Drawing.Point(121, 16);
            this.VBProjLocationText.Name = "VBProjLocationText";
            this.VBProjLocationText.Size = new System.Drawing.Size(160, 20);
            this.VBProjLocationText.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(283, 575);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ExcelBox
            // 
            this.ExcelBox.Controls.Add(this.CopyDomainExcel_VB);
            this.ExcelBox.Controls.Add(this.CopyDescriptionExcel_VB);
            this.ExcelBox.Controls.Add(this.CopyAllExcel_VB);
            this.ExcelBox.Controls.Add(this.ExcelDescriptionText);
            this.ExcelBox.Controls.Add(this.label3);
            this.ExcelBox.Controls.Add(this.label2);
            this.ExcelBox.Controls.Add(this.ExcelDomainText);
            this.ExcelBox.Controls.Add(this.label1);
            this.ExcelBox.Controls.Add(this.ExcelFileNameText);
            this.ExcelBox.Location = new System.Drawing.Point(294, 87);
            this.ExcelBox.Name = "ExcelBox";
            this.ExcelBox.Size = new System.Drawing.Size(346, 404);
            this.ExcelBox.TabIndex = 3;
            this.ExcelBox.TabStop = false;
            this.ExcelBox.Text = "Excel File";
            this.ExcelBox.Visible = false;
            // 
            // CopyDomainExcel_VB
            // 
            this.CopyDomainExcel_VB.Location = new System.Drawing.Point(289, 79);
            this.CopyDomainExcel_VB.Name = "CopyDomainExcel_VB";
            this.CopyDomainExcel_VB.Size = new System.Drawing.Size(44, 23);
            this.CopyDomainExcel_VB.TabIndex = 12;
            this.CopyDomainExcel_VB.Text = "->>";
            this.CopyDomainExcel_VB.UseVisualStyleBackColor = true;
            this.CopyDomainExcel_VB.Visible = false;
            this.CopyDomainExcel_VB.Click += new System.EventHandler(this.CopyDomainExcel_VB_Click);
            // 
            // CopyDescriptionExcel_VB
            // 
            this.CopyDescriptionExcel_VB.Location = new System.Drawing.Point(289, 164);
            this.CopyDescriptionExcel_VB.Name = "CopyDescriptionExcel_VB";
            this.CopyDescriptionExcel_VB.Size = new System.Drawing.Size(44, 23);
            this.CopyDescriptionExcel_VB.TabIndex = 11;
            this.CopyDescriptionExcel_VB.Text = "->>";
            this.CopyDescriptionExcel_VB.UseVisualStyleBackColor = true;
            this.CopyDescriptionExcel_VB.Visible = false;
            this.CopyDescriptionExcel_VB.Click += new System.EventHandler(this.CopyDescriptionExcel_VB_Click);
            // 
            // CopyAllExcel_VB
            // 
            this.CopyAllExcel_VB.Location = new System.Drawing.Point(248, 360);
            this.CopyAllExcel_VB.Name = "CopyAllExcel_VB";
            this.CopyAllExcel_VB.Size = new System.Drawing.Size(92, 23);
            this.CopyAllExcel_VB.TabIndex = 9;
            this.CopyAllExcel_VB.Text = "Copy All To VB ->>";
            this.CopyAllExcel_VB.UseVisualStyleBackColor = true;
            this.CopyAllExcel_VB.Visible = false;
            this.CopyAllExcel_VB.Click += new System.EventHandler(this.CopyVB_Click);
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
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Test Objective";
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
            // VBBox
            // 
            this.VBBox.Controls.Add(this.CopyDescriptionVB_Excel);
            this.VBBox.Controls.Add(this.CopyDomainVB_Excel);
            this.VBBox.Controls.Add(this.CopyAllVB_Excel);
            this.VBBox.Controls.Add(this.VBBehaviorText);
            this.VBBox.Controls.Add(this.label5);
            this.VBBox.Controls.Add(this.VBDescriptionText);
            this.VBBox.Controls.Add(this.label6);
            this.VBBox.Controls.Add(this.label7);
            this.VBBox.Controls.Add(this.VBDomainText);
            this.VBBox.Controls.Add(this.label8);
            this.VBBox.Controls.Add(this.VBFileNameText);
            this.VBBox.Location = new System.Drawing.Point(646, 89);
            this.VBBox.Name = "VBBox";
            this.VBBox.Size = new System.Drawing.Size(330, 402);
            this.VBBox.TabIndex = 9;
            this.VBBox.TabStop = false;
            this.VBBox.Text = "VB File";
            this.VBBox.Visible = false;
            // 
            // CopyDescriptionVB_Excel
            // 
            this.CopyDescriptionVB_Excel.Location = new System.Drawing.Point(7, 162);
            this.CopyDescriptionVB_Excel.Name = "CopyDescriptionVB_Excel";
            this.CopyDescriptionVB_Excel.Size = new System.Drawing.Size(44, 23);
            this.CopyDescriptionVB_Excel.TabIndex = 14;
            this.CopyDescriptionVB_Excel.Text = "<<-";
            this.CopyDescriptionVB_Excel.UseVisualStyleBackColor = true;
            this.CopyDescriptionVB_Excel.Visible = false;
            this.CopyDescriptionVB_Excel.Click += new System.EventHandler(this.CopyDescriptionVB_Excel_Click);
            // 
            // CopyDomainVB_Excel
            // 
            this.CopyDomainVB_Excel.Location = new System.Drawing.Point(7, 77);
            this.CopyDomainVB_Excel.Name = "CopyDomainVB_Excel";
            this.CopyDomainVB_Excel.Size = new System.Drawing.Size(44, 23);
            this.CopyDomainVB_Excel.TabIndex = 13;
            this.CopyDomainVB_Excel.Text = "<<-";
            this.CopyDomainVB_Excel.UseVisualStyleBackColor = true;
            this.CopyDomainVB_Excel.Visible = false;
            this.CopyDomainVB_Excel.Click += new System.EventHandler(this.CopyDomainVB_Excel_Click);
            // 
            // CopyAllVB_Excel
            // 
            this.CopyAllVB_Excel.Location = new System.Drawing.Point(7, 358);
            this.CopyAllVB_Excel.Name = "CopyAllVB_Excel";
            this.CopyAllVB_Excel.Size = new System.Drawing.Size(124, 23);
            this.CopyAllVB_Excel.TabIndex = 10;
            this.CopyAllVB_Excel.Text = "<<- Copy All to Excel";
            this.CopyAllVB_Excel.UseVisualStyleBackColor = true;
            this.CopyAllVB_Excel.Visible = false;
            this.CopyAllVB_Excel.Click += new System.EventHandler(this.CopyExcel_Click);
            // 
            // VBBehaviorText
            // 
            this.VBBehaviorText.Location = new System.Drawing.Point(57, 240);
            this.VBBehaviorText.Name = "VBBehaviorText";
            this.VBBehaviorText.Size = new System.Drawing.Size(253, 96);
            this.VBBehaviorText.TabIndex = 8;
            this.VBBehaviorText.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Test Behavior";
            // 
            // VBDescriptionText
            // 
            this.VBDescriptionText.BackColor = System.Drawing.SystemColors.Window;
            this.VBDescriptionText.Location = new System.Drawing.Point(57, 123);
            this.VBDescriptionText.Name = "VBDescriptionText";
            this.VBDescriptionText.Size = new System.Drawing.Size(253, 96);
            this.VBDescriptionText.TabIndex = 6;
            this.VBDescriptionText.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Test Description";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Test Domain";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VBDomainText
            // 
            this.VBDomainText.Location = new System.Drawing.Point(57, 80);
            this.VBDomainText.Name = "VBDomainText";
            this.VBDomainText.Size = new System.Drawing.Size(254, 20);
            this.VBDomainText.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Test File Name";
            // 
            // VBFileNameText
            // 
            this.VBFileNameText.Location = new System.Drawing.Point(57, 36);
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
            this.label9.Location = new System.Drawing.Point(14, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "VB Project Location";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "VTP File Location";
            // 
            // VTPLocationText
            // 
            this.VTPLocationText.Location = new System.Drawing.Point(121, 39);
            this.VTPLocationText.Name = "VTPLocationText";
            this.VTPLocationText.Size = new System.Drawing.Size(160, 20);
            this.VTPLocationText.TabIndex = 15;
            // 
            // VBProjLocButton
            // 
            this.VBProjLocButton.Location = new System.Drawing.Point(286, 11);
            this.VBProjLocButton.Name = "VBProjLocButton";
            this.VBProjLocButton.Size = new System.Drawing.Size(27, 23);
            this.VBProjLocButton.TabIndex = 17;
            this.VBProjLocButton.Text = "...";
            this.VBProjLocButton.UseVisualStyleBackColor = true;
            this.VBProjLocButton.Click += new System.EventHandler(this.VBProjLocButton_Click);
            // 
            // ExcelLocButton
            // 
            this.ExcelLocButton.Location = new System.Drawing.Point(286, 39);
            this.ExcelLocButton.Name = "ExcelLocButton";
            this.ExcelLocButton.Size = new System.Drawing.Size(27, 23);
            this.ExcelLocButton.TabIndex = 18;
            this.ExcelLocButton.Text = "...";
            this.ExcelLocButton.UseVisualStyleBackColor = true;
            this.ExcelLocButton.Click += new System.EventHandler(this.ExcelLocButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.ExcelLocButton);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.VBProjLocButton);
            this.groupBox1.Controls.Add(this.VBProjLocationText);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.VTPLocationText);
            this.groupBox1.Location = new System.Drawing.Point(653, -5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 88);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 667);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MissmatchButton);
            this.Controls.Add(this.ExcelButton);
            this.Controls.Add(this.VBTestButton);
            this.Controls.Add(this.SuccessButton);
            this.Controls.Add(this.VBBox);
            this.Controls.Add(this.ExcelBox);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "VTP Scanner";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ExcelBox.ResumeLayout(false);
            this.ExcelBox.PerformLayout();
            this.VBBox.ResumeLayout(false);
            this.VBBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox VBProjLocationText;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox ExcelBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ExcelFileNameText;
        private System.Windows.Forms.RichTextBox ExcelDescriptionText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ExcelDomainText;
        private System.Windows.Forms.GroupBox VBBox;
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
        private System.Windows.Forms.Button CopyAllExcel_VB;
        private System.Windows.Forms.Button CopyAllVB_Excel;
        private System.Windows.Forms.Button MissmatchButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox VTPLocationText;
        private System.Windows.Forms.Button VBProjLocButton;
        private System.Windows.Forms.Button ExcelLocButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button CopyDomainExcel_VB;
        private System.Windows.Forms.Button CopyDescriptionExcel_VB;
        private System.Windows.Forms.Button CopyDescriptionVB_Excel;
        private System.Windows.Forms.Button CopyDomainVB_Excel;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

