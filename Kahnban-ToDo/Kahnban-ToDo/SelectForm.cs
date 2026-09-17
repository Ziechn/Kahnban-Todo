using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Kahnban_ToDo
{
    public partial class SelectForm : Form
    {
        // CONSTANTS
        private const string COLUMN_DIRECTORY = "directory";
        private const string COLUMN_ORGANIZATION = "organization";
        private const string HEADER_DIRECTORY = "Directory";
        private const string HEADER_ORGANIZATION = "Organization";
        private const int PROPERTY_WIDTH_ORGANIZATION = 200;

        public SelectForm()
        {
            InitializeComponent();
            DataGridView_Organizations_Initialize();
            DataGridView_Organizations_Populate();
        }

        #region DataGridView =======================================
        private void DataGridView_Organizations_Initialize()
        {
            // Organization
            DataGridViewColumn nameColumn = new DataGridViewColumn
            {
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                CellTemplate = new DataGridViewTextBoxCell(),
                HeaderText = HEADER_ORGANIZATION,
                Name = COLUMN_ORGANIZATION,
                Width = PROPERTY_WIDTH_ORGANIZATION
            };
            DataGridView_Organizations.Columns.Add(nameColumn);

            // Directory
            DataGridView_Organizations.Columns.Add(COLUMN_DIRECTORY, HEADER_DIRECTORY);
        }

        private void DataGridView_Organizations_Populate()
        {
            DataGridView_Organizations.Rows.Clear();

            string path = AppStore.path;
            List<string> directories = Directory.GetDirectories(path).ToList();

            foreach (string directory in directories)
            {
                string organization = Path.GetFileName(directory);
                DataGridView_Organizations.Rows.Add(
                    organization,
                    directory
                    );
            }
        }
        #endregion DataGridView

        #region Interaction ========================================
        private void Button_Add_Click(object sender, EventArgs e)
        {
            string result = Interaction.InputBox(
                "Enter a new organization:",
                "Organization"
                );

            string applicationDirectory = AppStore.path;
            string path = Path.Combine(applicationDirectory, result);

            Directory.CreateDirectory(path);
            DataGridView_Organizations_Populate();
        }

        private void DataGridView_Organizations_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow? row = DataGridView_Organizations.Rows[rowIndex];
            if (row == null) return;

            string directory = DataGridViewUtilities.GetCellValue_String(row, COLUMN_DIRECTORY);
            if (string.IsNullOrEmpty(directory)) return;

            string organization = Path.GetFileName(directory);
            AppStore.organization = organization;
            AppStore.organizationPath = directory;

            OrganizationForm organizationForm = new OrganizationForm();
            FormUtilities.NavigateTo(organizationForm);
        }
        #endregion Interaction
    }
}
