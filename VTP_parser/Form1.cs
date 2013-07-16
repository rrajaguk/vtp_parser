using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NPOI.HSSF.UserModel;
using RunnerParser;
using RunnerParser.ObjComparer;
using RunnerParser.ObjRepresentation;
using VTP_parser.VisualAdapter;

namespace VTP_parser
{
    public partial class Form1 : Form
    {
        public enum displayedData {success,VB,excel,missmatch}
        private displayedData currentlyDisplayed;
        private MergeResult mergeRes;
       
        public Form1()
        {
            InitializeComponent();
        }
        private void showBox(bool excel, bool vb)
        {
            ExcelBox.Visible = excel;
            VBBox.Visible = vb;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ExcelParser excelFileParser = new ExcelParser(VTPLocationText.Text);
            excelFileParser.Parse();
            VbProjParser vbProjectParser = new VbProjParser(
                Path.GetDirectoryName(VBProjLocationText.Text),
                Path.GetFileName(VBProjLocationText.Text));
            vbProjectParser.Parse();
            List<TestMerge> MainTestCase = new List<TestMerge>();

            mergeRes= new MergeResult(vbProjectParser,excelFileParser);
            SuccessButton.Enabled = true;
            VBTestButton.Enabled = true;
            ExcelButton.Enabled = true;
            MissmatchButton.Enabled = true;
        }

        private void SuccessButton_Click(object sender, EventArgs e)
        {
            clearAllTextBox();
            currentlyDisplayed = displayedData.success;
            dataGridView1.DataSource =  TestMergeAdapter.Adapt(mergeRes,mergeResultType.success);
            dataGridView1.Columns[0].Width = 180;
            dataGridView1.Columns[1].Width = 40;
            showBox(true, true);
            hideCopyOptions();
        }

        private void showCopyOptions()
        {
            CopyAllVB_Excel.Visible = true;
            CopyAllExcel_VB.Visible = true;
        }
        private void hideCopyOptions()
        {
            CopyAllExcel_VB.Visible = false;
            CopyAllVB_Excel.Visible = false; 
            CopyDomainExcel_VB.Visible = false;
            CopyDomainVB_Excel.Visible = false;
            CopyDescriptionExcel_VB.Visible = false;
            CopyDescriptionVB_Excel.Visible = false;
        }


        private void MissmatchButton_Click(object sender, EventArgs e)
        {
            clearAllTextBox();
            currentlyDisplayed = displayedData.missmatch;
            dataGridView1.DataSource = TestMergeAdapter.Adapt(mergeRes, mergeResultType.mismatch);
            dataGridView1.Columns[0].Width = 180;
            dataGridView1.Columns[1].Width = 40;
            showBox(true, true);
        }

        private void VBTestButton_Click(object sender, EventArgs e)
        {
            clearAllTextBox();
            dataGridView1.DataSource = TestCaseAdapter.Adapt(mergeRes, resultType.VB);
            dataGridView1.Columns[0].Width = 220;
            currentlyDisplayed = displayedData.VB;
            showBox(false, true);
            hideCopyOptions();
        }

        private void ExcelButton_Click(object sender, EventArgs e)
        {
            clearAllTextBox();
            dataGridView1.DataSource = TestCaseAdapter.Adapt(mergeRes, resultType.Excel);
            dataGridView1.Columns[0].Width = 220;
            currentlyDisplayed = displayedData.excel;

            showBox(true,false);
            hideCopyOptions();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            clearAllTextBox();
            switch (currentlyDisplayed)
            {
                case displayedData.success:
                    populateSuccessData(e.RowIndex);
                    break;
                case displayedData.VB:
                    populateVbData(e.RowIndex);
                    break;
                case displayedData.excel:
                    populateExcelData(e.RowIndex);
                    break;
                case displayedData.missmatch:
                    showCopyOptions();
                    populateMissmatch(e.RowIndex);
                    break;
            
            }
        }

        private void populateExcelData(int p)
        {
            populateExcel(mergeRes.UnmacthedExcel[p]);
        }
        private void populateExcel(TestCase TS)
        {
            ExcelFileNameText.Text = TS.TestName;
            ExcelDescriptionText.Text = TS.TestBehaviour;
            ExcelDomainText.Text = TS.TestDomain;
        }
        private void clearAllTextBox()
        {

            ExcelFileNameText.Clear();
            ExcelDescriptionText.Clear();
            ExcelDomainText.Clear();
        
            VBFileNameText.Clear();
            VBDescriptionText.Clear();
            VBDomainText.Clear();
            VBBehaviorText.Clear();

            resetColoring();
        }
        private void populateVbData(int p)
        {
            populateVB(mergeRes.UnmacthedVB[p]);
        }
        private void populateVB(TestCase TS)
        {
            VBFileNameText.Text = TS.TestFileName;
            VBDescriptionText.Text = TS.TestDescription;
            VBDomainText.Text = TS.TestDomain;
            VBBehaviorText.Text = TS.TestBehaviour;
        }
        private void populateMissmatch(int p)
        {
            TestMerge result = mergeRes.UnmacthedContent[p];
            populateExcel(result.excelSource);
            populateVB(result.vbSource);

            //set the coloring
            if (!result.sameDescription)
            {
                ExcelDescriptionText.BackColor = Color.Yellow;
                VBDescriptionText.BackColor = Color.Yellow;
                CopyDescriptionExcel_VB.Visible = true;
                CopyDescriptionVB_Excel.Visible = true;
            }
            else
            {
                ExcelDescriptionText.BackColor = Color.FromKnownColor(KnownColor.Window);
                VBDescriptionText.BackColor = Color.FromKnownColor(KnownColor.Window);
                CopyDescriptionExcel_VB.Visible = false;
                CopyDescriptionVB_Excel.Visible = false;
            }

            if (!result.sameDomain)
            {
                ExcelDomainText.BackColor = Color.Yellow;
                VBDomainText.BackColor = Color.Yellow;
                CopyDomainExcel_VB.Visible = true;
                CopyDomainVB_Excel.Visible = true;
            }
            else
            {
                ExcelDomainText.BackColor = Color.FromKnownColor(KnownColor.Window);
                VBDomainText.BackColor = Color.FromKnownColor(KnownColor.Window);
                CopyDomainExcel_VB.Visible = false;
                CopyDomainVB_Excel.Visible = false;
            }

        }

        private void resetColoring()
        {
            resetColoring(true, true);
        }
        private void resetColoring(bool domain, bool description)
        {
            if (domain)
            {
                ExcelDomainText.BackColor = Color.FromKnownColor(KnownColor.Window);
                VBDomainText.BackColor = Color.FromKnownColor(KnownColor.Window);
            }
            if (description)
            {
                ExcelDescriptionText.BackColor = Color.FromKnownColor(KnownColor.Window);
                VBDescriptionText.BackColor = Color.FromKnownColor(KnownColor.Window);
            }

        }

        private void populateSuccessData(int p)
        {
            TestMerge result = mergeRes.Success[p];
            populateExcel(result.excelSource);
            populateVB(result.vbSource);
        }

        private void VBProjLocButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Visual Basic Project (.vbproj)|*.vbproj";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                VBProjLocationText.Text = openFileDialog1.FileName;
                VBProjLocationText.SelectionStart = VBProjLocationText.Text.Length - 1;
            }
        }

        private void ExcelLocButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Excel File (.xlsx)|*.xlsx";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                VTPLocationText.Text = openFileDialog1.FileName;
                VTPLocationText.SelectionStart = VTPLocationText.Text.Length - 1;
            }

        }

        private void CopyVB_Click(object sender, EventArgs e)
        {
            VBDescriptionText.Text = ExcelDescriptionText.Text;
            VBDomainText.Text = ExcelDomainText.Text;
            resetColoring();
            hideCopyOptions();
          
            //handle the data
            dataGridView1.CurrentRow.Cells[1].Value = true;
        }

        private void CopyExcel_Click(object sender, EventArgs e)
        {
            ExcelDomainText.Text = VBDomainText.Text;
            ExcelDescriptionText.Text = VBDescriptionText.Text;
            resetColoring();
            hideCopyOptions();

            //handle the data
            dataGridView1.CurrentRow.Cells[1].Value = true;
        }

        private void CopyDomainExcel_VB_Click(object sender, EventArgs e)
        {
            VBDomainText.Text = ExcelDomainText.Text;
            CopyDomainVB_Excel.Visible = false;
            CopyDomainExcel_VB.Visible = false;
            resetColoring(true, false);
            //TODO: handle the data
        }

        private void CopyDomainVB_Excel_Click(object sender, EventArgs e)
        {
            ExcelDomainText.Text = VBDomainText.Text;
            CopyDomainVB_Excel.Visible = false;
            CopyDomainExcel_VB.Visible = false;
            resetColoring(true, false);
            //TODO: handle the data
        }

        private void CopyDescriptionVB_Excel_Click(object sender, EventArgs e)
        {
            ExcelDescriptionText.Text = VBDescriptionText.Text;
            CopyDescriptionVB_Excel.Visible = false;
            CopyDescriptionExcel_VB.Visible = false;
            resetColoring(false, true);
            //TODO: handle the data
        }

        private void CopyDescriptionExcel_VB_Click(object sender, EventArgs e)
        {
            VBDescriptionText.Text = ExcelDescriptionText.Text;
            CopyDescriptionVB_Excel.Visible = false;
            CopyDescriptionExcel_VB.Visible = false;
            resetColoring(false, true);
            //TODO: handle the data
        }

        private void SwapDescBehavior_Click(object sender, EventArgs e)
        {
            string temp = VBDescriptionText.Text;
            VBDescriptionText.Text = VBBehaviorText.Text;
            VBBehaviorText.Text = temp;
        }


    }
}
