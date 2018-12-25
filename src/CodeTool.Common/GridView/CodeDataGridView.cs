using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeTool.Common.GridView
{
    public static class CodeDataGridView
    {
        public static void CodeGrid(this DataGridView dgv)
        {
            DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();
            DataGridViewCellStyle headerStyle = new DataGridViewCellStyle();
            //===
            cellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            cellStyle.BackColor = System.Drawing.Color.White;
            cellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cellStyle.ForeColor = System.Drawing.Color.Black;
            cellStyle.SelectionBackColor = System.Drawing.Color.Yellow;
            cellStyle.SelectionForeColor = System.Drawing.Color.Black;
            cellStyle.WrapMode = DataGridViewTriState.True;
            //===
            headerStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            headerStyle.BackColor = System.Drawing.SystemColors.Window;
            headerStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            headerStyle.ForeColor = System.Drawing.Color.Black;
            headerStyle.SelectionBackColor = System.Drawing.Color.White;
            headerStyle.SelectionForeColor = System.Drawing.Color.Black;
            headerStyle.WrapMode = DataGridViewTriState.False;
            dgv.ColumnHeadersDefaultCellStyle = headerStyle;

            dgv.DefaultCellStyle = cellStyle;
            dgv.ColumnHeadersHeight = 40;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv.MultiSelect = false;
            dgv.ReadOnly = true;
            dgv.RowHeadersVisible = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.TabIndex = 0;
            dgv.TabStop = true;
            dgv.AllowDrop = true;
            dgv.AllowUserToAddRows = true;
            dgv.AllowUserToDeleteRows = true;
            dgv.AllowUserToResizeColumns = true;
            dgv.AllowUserToResizeRows = true;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv.BackgroundColor = System.Drawing.Color.White;
        }

        public static void MoveToUp(this DataGridView dgv)
        {
            if (dgv.Rows.Count > 0)
            {
                int indexUp = dgv.SelectedRows[0].Index;
                if (indexUp > 0)
                {
                    dgv.Rows[indexUp].Selected = false;
                    dgv.Rows[indexUp - 1].Selected = true;
                }
            }
        }

        public static void MoveToDown(this DataGridView dgv)
        {
            if (dgv.Rows.Count > 0)
            {
                int indexDown = dgv.SelectedRows[0].Index;
                if (indexDown >= 0 && indexDown < dgv.Rows.Count - 1)
                {
                    dgv.Rows[indexDown].Selected = false;
                    dgv.Rows[indexDown + 1].Selected = true;
                }
            }
        }

        public static void HideColumn(this DataGridView dgv, string columnName)
        {
            dgv.Columns[columnName].Visible = false;
        }
    }
}