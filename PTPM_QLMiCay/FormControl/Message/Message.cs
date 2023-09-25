using System.Windows.Forms;

namespace FormControl.Message
{
    public class Message
    {
        public static void showErrorLoadData(string table)
        {
            MessageBox.Show("Không thể load dữ liệu bảng " + table);
        }
    }
}
