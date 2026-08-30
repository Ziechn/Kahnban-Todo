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
    }
}
