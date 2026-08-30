using System;
using System.Collections.Generic;
using System.Text;

namespace Kahnban_ToDo
{
    internal static class FormUtilities
    {
        public static void NavigateTo(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            AppStore.mainPanel.Controls.Clear();
            AppStore.mainPanel.Controls.Add(form);

            form.Show();
        }

        public static void DisplayPlaceholder(TextBox textBox, string placeholder)
        {
            string text = textBox.Text;

            bool isPlaceholder = text.Equals(placeholder);
            if (isPlaceholder)
            {
                textBox.Text = "";
                textBox.ForeColor = SystemColors.ControlText;
                return;
            }

            bool isEmpty = text.Equals("");
            if (isEmpty == false) return;

            textBox.Text = placeholder;
            textBox.ForeColor = Color.LightGray;
        }
    }
}
