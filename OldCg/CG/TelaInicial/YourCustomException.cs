using System;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace CG
{
    [Serializable]
    internal class YourCustomException : Exception
    {
        private string v;
        private EventArgs e;

        public YourCustomException()
        {
        }

        public YourCustomException(string message) : base(message)
        {

        }

        public YourCustomException(string v, EventArgs e)
        {
            this.v = v;
            this.e = e;
            MessageBox.Show(v);

            MessageBox.Show(e.ToString());

        }

        public YourCustomException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected YourCustomException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}