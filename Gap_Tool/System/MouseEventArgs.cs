using System.Windows.Forms;

namespace System
{
    internal class MouseEventArgs
    {
        private Action<object, Windows.Forms.MouseEventArgs> gap_MouseDoubleClick;

        public MouseEventArgs(Action<object, Windows.Forms.MouseEventArgs> gap_MouseDoubleClick)
        {
            this.gap_MouseDoubleClick = gap_MouseDoubleClick;
        }
    }
}