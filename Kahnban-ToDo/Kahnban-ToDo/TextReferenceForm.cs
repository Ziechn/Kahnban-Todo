using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Kahnban_ToDo
{
    public partial class TextReferenceForm : Form
    {
        // Local Memory
        private long _userStoryId;
        private TextReference? _textReference;

        public TextReferenceForm(long userStoryId)
        {
            InitializeComponent();
            _userStoryId = userStoryId;
            Button_Save_State();
        }

        public TextReferenceForm(long userStoryId, TextReference textReference)
        {
            InitializeComponent();
            _userStoryId = userStoryId;

            _textReference = textReference;
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
            long id = -1;

            string organizationPath = AppStore.organizationPath;
            string projectId = AppStore.project?.Id.ToString() ?? "";
            string userStoryId = _userStoryId.ToString();

            Controller controller = new();

            TextReference? textReference = null;
            if (_textReference == null)
            {
                textReference = new TextReference();
                id = controller.CreateId();
            }
            else
            {
                textReference = _textReference;
                id = textReference.Id;
            }

            textReference.Id = id;

            string title = TextBox_Title.Text.Trim();
            textReference.Title = title;

            string content = RichTextBox_Content.Text.Trim();
            textReference.Content = content;

            string fileName = $"{id}.json";
            string filePath = Path.Combine(organizationPath, projectId, userStoryId, fileName);
            controller.Save(textReference, filePath, typeof(Reference));

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
    }
}
