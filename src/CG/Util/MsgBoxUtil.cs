namespace CG.Util
{
    public class MsgBoxUtil
    {
        public static void MsgBox(string mesage, string title)
        {
            MessageBox.Show(mesage, title, MessageBoxButtons.OK);
        }

        public static void MsgBoxInformation(string mesage, string title)
        {
            MessageBox.Show(mesage, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void MsgBoxError(string mesage, string title)
        {
            MessageBox.Show(mesage, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
