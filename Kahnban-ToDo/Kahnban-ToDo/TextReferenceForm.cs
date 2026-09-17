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
        private long _userStoryId = -1;
        private TextReference? _textReference;

        public TextReferenceForm(long userStoryId)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;

            _userStoryId = userStoryId;
            Button_Save_State();
        }

        public TextReferenceForm(long userStoryId, long referenceId)
        {
            InitializeComponent();
            _userStoryId = userStoryId;

            _textReference = ReadTextReference(referenceId);
            if (_textReference == null)
            {
                Debug.WriteLine("Error reading text reference.");
                return;
            }

            TextBox_Title_Populate();
            RichTextBox_Content_Populate();

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

            bool hasTitle = false;
            bool hasContent = false;
            bool updatedTitle = false;
            bool updatedContent = false;

            if (_textReference != null)
            {
                string titleToUpdate = _textReference.Title;
                updatedTitle = title.Equals(titleToUpdate) == false;

                string contentToUpdate = _textReference.Content;
                updatedContent = content.Equals(contentToUpdate) == false;
            }
            else
            {
                hasTitle = title.Equals("") == false;
                hasContent = content.Equals("") == false;
            }

            bool hasUnsavedChanges = hasTitle || hasContent || updatedTitle || updatedContent;

            if (hasUnsavedChanges)
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

            TextReference? textReference = null;
            long referenceId = -1;

            Controller controller = new();
            if (_textReference == null)
            {
                textReference = new TextReference();
                referenceId = controller.CreateId();
            }
            else
            {
                textReference = _textReference;
                referenceId = _textReference.Id;
            }

            if (textReference == null) return;
            if (referenceId < 0) return;

            textReference.Id = referenceId;

            string title = TextBox_Title.Text.Trim();
            textReference.Title = title;

            string content = RichTextBox_Content.Text.Trim();
            textReference.Content = content;

            try
            {
                controller.Save(textReference, filePath, referenceId, typeof(Reference));
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
        private void TextBox_Title_Populate()
        {
            TextBox_Title.Text = _textReference.Title;
        }

        private void RichTextBox_Content_Populate()
        {
            RichTextBox_Content.Text = _textReference.Content;
        }
        #endregion Populate

        #region Read ===============================================
        // Read methods return an object or value.
        private TextReference? ReadTextReference(long referenceId)
        {
            string organizationPath = AppStore.organizationPath;
            string projectId = AppStore.project?.Id.ToString() ?? "";
            string userStoryId = _userStoryId.ToString();
            string filePath = Path.Combine(organizationPath, projectId, userStoryId);

            Controller controller = new();
            return controller.ReadObject<TextReference>(filePath, referenceId);
        }
        #endregion
    }
}
