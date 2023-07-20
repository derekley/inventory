namespace System
{
    internal class FormClosingEventHandler
    {
        private Action<object, EventArgs> frmAddPart_FormClosing;

        public FormClosingEventHandler(Action<object, EventArgs> frmAddPart_FormClosing)
        {
            this.frmAddPart_FormClosing = frmAddPart_FormClosing;
        }
    }
}