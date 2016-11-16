using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BranchPredictorPro.Helpers
{
    public static class FormHelper
    {

        public static void BindListbox<T>(ListBox listBox, IList<T> list, string valueFieldName, string textFieldName)
        {
            listBox.DataSource = list;
            listBox.DisplayMember = textFieldName;
            listBox.ValueMember = valueFieldName;
        }

        public static void BindControlOnPropertyChanged(Control control, string controlPropertyName, object item, string itemProperty)
        {
            control.DataBindings.Add(new Binding(controlPropertyName, item, itemProperty, true, DataSourceUpdateMode.OnPropertyChanged));
        }

        public static object[] GetSelectedColumnValues(DataGridView grid, string columnName)
        {
            if (grid.SelectedRows.Count == 0) return null;
            var result = new List<object>();
            foreach (DataGridViewRow row in grid.SelectedRows)
            {
                result.Add(row.Cells[columnName].Value);
            }
            return result.ToArray();

        }

        public static void SetSelectedItems(ListBox listbox, IList<int> selectedItems)
        {
            if (!selectedItems.Any())
            {
                listbox.ClearSelected();
                return;
            }
            foreach (var item in selectedItems)
            {
                listbox.SetSelected(item, true);
            }

        }

        public static void ShowMenuStripNearControl(ContextMenuStrip menuStrip, Control control)
        {
            var point = new Point(control.Width, 0);
            point = control.PointToScreen(point);
            menuStrip.Show(point);
        }

    }
}
