using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasaDoGesso
{
    public static class ViewExtensions
    {
        public static void AplicarPadroesDataGrid(this DataGridView dataGrid,
            bool readOnlyAll = true)
        {
            dataGrid.AllowUserToOrderColumns = true;
            dataGrid.AutoGenerateColumns = false;
            dataGrid.ReadOnly = readOnlyAll;
            dataGrid.MultiSelect = false;
            dataGrid.AllowUserToAddRows = false;
            dataGrid.AllowUserToDeleteRows = false;
            dataGrid.AllowUserToResizeRows = false;
            dataGrid.RowHeadersVisible = false;
            dataGrid.BackgroundColor = Color.WhiteSmoke;
            dataGrid.BorderStyle = BorderStyle.None;
            dataGrid.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            dataGrid.DefaultCellStyle.Font = new System.Drawing.Font(dataGrid.Font.FontFamily, 11);
            dataGrid.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.Lavender;
            dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGrid.CellFormatting += DataGrid_CellFormatting;
        }

        private static void DataGrid_CellFormatting(object sender, System.Windows.Forms.DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                DataGridView dataGrid = (sender as DataGridView);
                DataGridViewColumn column = dataGrid.Columns[e.ColumnIndex];
                if (column.DataPropertyName.Contains("."))
                {
                    object data = dataGrid.Rows[e.RowIndex].DataBoundItem;
                    string[] properties = column.DataPropertyName.Split('.');
                    for (int i = 0; i < properties.Length && data != null; i++)
                        data = data.GetType().GetProperty(properties[i]).GetValue(data);
                    dataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = data;
                }
            }
            catch { }
        }
    }
}
