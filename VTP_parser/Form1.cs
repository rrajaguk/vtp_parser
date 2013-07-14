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
        public enum displayedData {success,VB,excel}
        private displayedData currentlyDisplayed;
        private MergeResult mergeRes;
       
        public Form1()
        {
            InitializeComponent();
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
            dataGridView1.DataSource =  TestMergeAdapter.Adapt(mergeRes,mergeResultType.success);
            dataGridView1.Columns[0].Width = 180;
            dataGridView1.Columns[1].Width = 40;
            currentlyDisplayed = displayedData.success;
        }


        private void MissmatchButton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = TestMergeAdapter.Adapt(mergeRes, mergeResultType.mismatch);
            dataGridView1.Columns[0].Width = 180;
            dataGridView1.Columns[1].Width = 40;
            currentlyDisplayed = displayedData.success;
        }

        private void VBTestButton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = TestCaseAdapter.Adapt(mergeRes, resultType.VB);
            dataGridView1.Columns[0].Width = 220;
            currentlyDisplayed = displayedData.VB;
        }

        private void ExcelButton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = TestCaseAdapter.Adapt(mergeRes, resultType.Excel);
            dataGridView1.Columns[0].Width = 220;
            currentlyDisplayed = displayedData.excel;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
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
                default:
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
            ExcelDescriptionText.Text = TS.TestDescription;
            ExcelDomainText.Text = TS.TestDomain;
            ExcelBehaviorText.Text = TS.TestBehaviour;
        }
        private void clearAllTextBox()
        {

            ExcelFileNameText.Clear();
            ExcelDescriptionText.Clear();
            ExcelDomainText.Clear();
            ExcelBehaviorText.Clear();
        
            VBFileNameText.Clear();
            VBDescriptionText.Clear();
            VBDomainText.Clear();
            VBBehaviorText.Clear();

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

    }
}
