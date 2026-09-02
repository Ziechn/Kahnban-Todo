using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Kahnban_ToDo
{
    public partial class TextReferenceForm : Form
    {
        // Local Memory
        private long _referenceId = -1;
        private long _userStoryId = -1;

        public TextReferenceForm(long userStoryId)
        {
            InitializeComponent();
            _userStoryId = userStoryId;
            Button_Save_State();
        }

        public TextReferenceForm(long userStoryId, long referenceId)
        {
            InitializeComponent();
            _referenceId = referenceId;
            _userStoryId = userStoryId;

            TextReference? textReference = ReadTextReference();
            if (textReference == null)
            {
                Debug.WriteLine("Error reading text reference.");
                return;
            }

            TextBox_Title_Populate(textReference);
            RichTextBox_Content_Populate(textReference);

            Button_Save_State();
        }

        #region Event Handlers =====================================
        private void TextReferenceForm_Shown(object sender, EventArgs e)
        {
            TextBox_Title.Focus();
        }
        #endregion Event Handlers

        #region Interaction ========================================
        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            string title = TextBox_Title.Text;
            string content = RichTextBox_Content.Text;

            bool hasTitle = title.Equals("") == false;
            bool hasContent = content.Equals("") == false;

            if (hasTitle || hasContent)
            {
                string message = "Discard unsaved changes?";

                DialogResult result = MessageBox.Show(
                    message,
                    "Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                    );

                if (result == DialogResult.No) return;
            }

            Close();
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            string organizationPath = AppStore.organizationPath;
            string projectId = AppStore.project?.Id.ToString() ?? "";
            string userStoryId = _userStoryId.ToString();

            string filePath = Path.Combine(organizationPath, projectId, userStoryId);

            Controller controller = new();

            TextReference? textReference = null;
            if (_referenceId < 0)
            {
                textReference = new TextReference();
                _referenceId = controller.CreateId();
            }
            else
            {
                try
                {
                    textReference = controller.ReadObject<TextReference>(filePath, _referenceId);
                }
                catch(Exception exception)
                {
                    Debug.WriteLine(exception);
                    return;
                }
            }

            if (textReference == null) return;

            textReference.Id = _referenceId;

            string title = TextBox_Title.Text.Trim();
            textReference.Title = title;

            string content = RichTextBox_Content.Text.Trim();
            textReference.Content = content;

            try
            {
                controller.Save(textReference, filePath, _referenceId, typeof(Reference));
            }
            catch (Exception exception)
            {
                Debug.WriteLine(exception);
                return;
            }

            Close();
        }

        private void Button_Save_State()
        {
            string title = TextBox_Title.Text.Trim();
            string content = RichTextBox_Content.Text.Trim();

            bool hasTitle = title.Equals("") == false;
            bool hasContent = content.Equals("") == false;

            bool isEnabled = hasTitle && hasContent;
            Button_Save.Enabled = isEnabled;
        }

        private void RichTextBox_Content_KeyUp(object sender, KeyEventArgs e)
        {
            Button_Save_State();
        }

        private void TextBox_Title_KeyUp(object sender, KeyEventArgs e)
        {
            Button_Save_State();
        }
        #endregion Interaction

        #region Populate ===========================================
        private void TextBox_Title_Populate(TextReference textReference)
        {
            TextBox_Title.Text = textReference.Title;
        }

        private void RichTextBox_Content_Populate(TextReference textReference)
        {
            RichTextBox_Content.Text = textReference.Content;
        }
        #endregion Populate

        #region Read ===============================================
        // Read methods return an object or value.
        private TextReference? ReadTextReference()
        {
            string organizationPath = AppStore.organizationPath;
            string projectId = AppStore.project?.Id.ToString() ?? "";
            string userStoryId = _userStoryId.ToString();
            string filePath = Path.Combine(organizationPath, projectId, userStoryId);

            Controller controller = new();
            return controller.ReadObject<TextReference>(filePath, _referenceId);
        }
        #endregion
    }
}
