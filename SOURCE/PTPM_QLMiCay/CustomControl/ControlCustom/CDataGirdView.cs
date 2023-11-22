using System.Drawing;
using System.Windows.Forms;

namespace CustomControl.ControlCustom
{
    public class CDataGirdView : DataGridView
    {
        public CDataGirdView() 
        {
            this.BackgroundColor = Color.White;
            this.Margin = new Padding(3, 3, 3, 3);
            //this.AllowUserToResizeRows = false;
            //DataGridViewCellStyle alternatingRowsStyle = new DataGridViewCellStyle();
            //alternatingRowsStyle.SelectionBackColor = Color.Orange;
            //alternatingRowsStyle.ForeColor = Color.Orange;
            //alternatingRowsStyle.Font = new Font("Segoe UI", 9,FontStyle.Regular, (GraphicsUnit)3,0,false);
            //this.AlternatingRowsDefaultCellStyle = alternatingRowsStyle;
            this.ColumnHeadersHeight = 25;
            this.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Dock = DockStyle.Fill;
            this.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.RowHeadersVisible = false;
            this.GridColor = Color.White;
        }
    }
}
