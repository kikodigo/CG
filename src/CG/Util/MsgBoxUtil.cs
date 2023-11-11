namespace CG.Util
{
    public class MsgBoxUtil
    {
        public static void MsgBox(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK);
        }

        public static void MsgBoxInformation(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void MsgBoxError(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static bool MsgBoxQuestion(string message, string title)
        {
            return DialogResult.Yes == MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
