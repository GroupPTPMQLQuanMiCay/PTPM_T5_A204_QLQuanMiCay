using System.Windows.Forms;

namespace FormControl.Message
{
    public class Message
    {
        public static void showErrorLoadData(string table)
        {
            MessageBox.Show("Không thể load dữ liệu bảng " + table);
        }

        public static void showMissingInfoMessage(string about, string when)
        {
            MessageBox.Show("Vui lòng cung cấp thông tin " + about + " để " + when);
        }

        public static void showInvalidParameterMessage(string about)
        {
            MessageBox.Show("Dữ liệu " + about + " không hợp lệ");
        }

        public static void showCreateSuccessfully(string obj)
        {
            MessageBox.Show(string.Format("Thêm mới {0} thành công", obj));
        }

        public static void showUpdateSuccessfully(string obj)
        {
            MessageBox.Show(string.Format("Cập nhật {0} thành công", obj));
        }

        public static void showDeleteSuccessfully(string obj)
        {
            MessageBox.Show(string.Format("Xóa {0} thành công", obj));
        }

        public static void showCreateFailed(string obj)
        {
            MessageBox.Show(string.Format("Thêm mới {0} không thành công", obj));
        }

        public static void showUpdateFailed(string obj)
        {
            MessageBox.Show(string.Format("Cập nhật {0} không thành công", obj));
        }

        public static void showDeleteFailed(string obj)
        {
            MessageBox.Show(string.Format("Xóa {0} không thành công", obj));
        }

        public static void showFailedDBExecution(string job, string table)
        {
            MessageBox.Show(string.Format(string.Format("Lỗi không thể {0} trên " +
                "                                       bảng {1}", job, table)));
        }
    }
}
