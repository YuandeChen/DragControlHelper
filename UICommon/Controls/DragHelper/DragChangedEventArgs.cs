using System;
using System.Windows;
using System.Windows.Shapes;
using System.Windows.Controls;

namespace UICommon.Controls
{
    public class DragChangedEventArgs : RoutedEventArgs
    {
        public DragChangedEventArgs(RoutedEvent Event, Rect NewBound, object Target = null) : base(Event)
        {
            this.NewBound = NewBound;
            DragTargetElement = Target;
        }
        public Rect NewBound { get; private set; }

        public object DragTargetElement { get; private set; }
    }
    public delegate void DragChangedEventHandler(object Sender, DragChangedEventArgs e);
}
