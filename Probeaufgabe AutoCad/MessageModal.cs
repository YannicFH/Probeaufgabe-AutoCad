using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Probeaufgabe_AutoCad;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.Runtime;
using Spire.Xls;

namespace Probeaufgabe_AutoCad
{
    public partial class MessageModal : Form
    {
        public MessageModal(string tag, string prompt)
        {
            InitializeComponent();
            string tagInput = tag;
            string placeholderTag = "Attribute Tag:";
            string promptInput = prompt;         
            string placeholderString = "Atrribute Prompt:";
            lblAttTag.Text = placeholderTag;
            lblAttTagText.Text = tagInput;
            lblAttString.Text = placeholderString;
            lblAttStringText.Text = promptInput;
        }
        
        private void MessageModal_Load(object sender, EventArgs e)
        {

        }

        private void btnExportExcle_Click(object sender, EventArgs e)
        {

            Workbook workbook = new Workbook();

            workbook.Worksheets.Clear();

            Worksheet worksheet = workbook.Worksheets.Add("Attributes");

            worksheet.Range[1, 1].Value = "Tag";
            worksheet.Range[1, 2].Value = "Prompt";
            worksheet.Range[2, 1].Value = lblAttTagText.Text;
            worksheet.Range[2, 2].Value = lblAttStringText.Text;


            worksheet.AllocatedRange.AutoFitColumns();
            
            workbook.SaveToFile(@"C:\Users\y-her\Downloads\Attributes.xlsx", ExcelVersion.Version2016);

            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
