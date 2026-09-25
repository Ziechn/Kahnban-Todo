using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace Kahnban_ToDo
{
    public partial class ContactManagementForm : Form
    {
        // CONSTANTS = COLUMNS
        private const string COLUMN_EMAIL = "email";
        private const string COLUMN_ID = "id";
        private const string COLUMN_METHOD = "primaryContactMethod";
        private const string COLUMN_NAME = "name";
        private const string COLUMN_PHONE = "phone";
        private const string COLUMN_PRIMARY = "primaryContact";

        // CONSTANTS - FILE NAMES
        private const string FILENAME_CONTACT = "contacts";

        // CONSTANTS - HEADERS
        private const string HEADER_EMAIL = "email";
        private const string HEADER_ID = "ID";
        private const string HEADER_METHOD = "Contact Method";
        private const string HEADER_NAME = "Name";
        private const string HEADER_PHONE = "Phone Number";
        private const string HEADER_PRIMARY = "Contact (username)";


        public ContactManagementForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;

            DataGridView_Contacts_Initialize();
            DataGridView_Contacts_Populate();
        }

        private void Button_Contact_Delete_Click(object sender, EventArgs e)
        {
            if (DataGridView_Contacts.SelectedCells.Count == 0) return;

            int rowIndex = DataGridView_Contacts.SelectedCells[0].RowIndex;
            if (rowIndex < 0) return;

            DataGridViewRow row = DataGridView_Contacts.Rows[rowIndex];
            if (row == null) return;

            long id = DataGridViewUtilities.GetCellValue_Long(row, COLUMN_ID);

            Controller controller = new();
            string application = Application.ExecutablePath;
            string applicationPath = Path.GetDirectoryName(application);
            try
            {
                List<Contact>? contacts = controller.ReadContacts();
                if (contacts == null || contacts.Count < 1) return;

                int removed = contacts.RemoveAll(contact => contact.Id == id);
                if (removed == 0) return;

                controller.Save(contacts, applicationPath, FILENAME_CONTACT);
            }
            catch (Exception exception)
            {
                Debug.WriteLine(exception);
                return;
            }

            DataGridView_Contacts_Populate();
        }

        private void Button_Contact_Delete_State(bool isEnabled)
        {
            Button_Contact_Delete.Enabled = isEnabled;
        }

        private void Contacts_Save()
        {
            Controller controller = new();
            List<Contact> contacts = new List<Contact>();

            foreach (DataGridViewRow row in DataGridView_Contacts.Rows)
            {
                if (row.IsNewRow) continue;

                long id = DataGridViewUtilities.GetCellValue_Long(row, COLUMN_ID);
                if (id < 0)
                {
                    id = controller.GenerateId();
                    row.Cells[COLUMN_ID]?.Value = id;
                }
                bool isIdValid = id > 0;

                string email = DataGridViewUtilities.GetCellValue_String(row, COLUMN_EMAIL);
                bool isEmailValid = string.IsNullOrEmpty(email) == false;

                string method = DataGridViewUtilities.GetCellValue_String(row, COLUMN_METHOD);
                bool isMethodValid = string.IsNullOrEmpty(method) == false;

                string name = DataGridViewUtilities.GetCellValue_String(row, COLUMN_NAME);
                bool isNameValid = string.IsNullOrEmpty(name) == false;

                string phone = DataGridViewUtilities.GetCellValue_String(row, COLUMN_PHONE);
                bool isPhoneValid = string.IsNullOrEmpty(phone) == false;

                string primary = DataGridViewUtilities.GetCellValue_String(row, COLUMN_PRIMARY);
                bool isPrimaryValid = string.IsNullOrEmpty(primary) == false;

                bool isContactValid = isIdValid && isNameValid;
                if (isContactValid == false) continue;

                Contact contact = new(
                    email,
                    id,
                    name,
                    phone,
                    method,
                    primary
                    );

                contacts.Add(contact);
            }

            if (contacts.Count < 1) return;

            string application = Application.ExecutablePath;
            string applicationPath = Path.GetDirectoryName(application);
            try
            {
                controller.Save(contacts, applicationPath, FILENAME_CONTACT);
            }
            catch (Exception exception)
            {
                Debug.WriteLine(exception);
            }
        }

        private void DataGridView_Contacts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex < 0) return;

            bool isRowValid = false;

            DataGridViewRow row = DataGridView_Contacts.Rows[rowIndex];
            if (row != null)
            {
                if (row.IsNewRow || rowIndex < 0)
                {
                    isRowValid = false;
                }
                else
                {
                    isRowValid = true;
                }
            }

            Button_Contact_Delete_State(isRowValid);
        }

        private void DataGridView_Contacts_Initialize()
        {
            // Create columns
            DataGridView_Contacts.Columns.Add(COLUMN_ID, HEADER_ID);
            DataGridView_Contacts.Columns.Add(COLUMN_NAME, HEADER_NAME);
            DataGridView_Contacts.Columns.Add(COLUMN_PHONE, HEADER_PHONE);
            DataGridView_Contacts.Columns.Add(COLUMN_EMAIL, HEADER_EMAIL);
            DataGridView_Contacts.Columns.Add(COLUMN_METHOD, HEADER_METHOD);
            DataGridView_Contacts.Columns.Add(COLUMN_PRIMARY, HEADER_PRIMARY);

            // Hide the columns
            DataGridView_Contacts.Columns[COLUMN_ID]?.Visible = false;
            DataGridView_Contacts.Columns[COLUMN_ID]?.ReadOnly = true;
        }

        private void DataGridView_Contacts_KeyUp(object sender, KeyEventArgs e)
        {
            Contacts_Save();
        }

        private void DataGridView_Contacts_Populate()
        {
            DataGridView_Contacts.Rows.Clear();

            Controller controller = new();
            List<Contact> contacts = new List<Contact>();

            try
            {
                contacts = controller.ReadContacts();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return;
            }

            if (contacts.Count < 1) return;

            foreach (Contact contact in contacts)
            {
                DataGridView_Contacts.Rows.Add(
                    contact.Id,
                    contact.Name,
                    contact.PhoneNumber,
                    contact.Email,
                    contact.PrimaryContactMethod,
                    contact.PrimaryContact
                    );
            }
        }
    }
}
