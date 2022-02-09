using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Task_WPF9
{
    class MyCommands
    {
        public static RoutedCommand Exit { get; set; }
        public static RoutedCommand Save { get; set; }
        public static RoutedCommand Open { get; set; }
        public static RoutedCommand GraphicEditor { get; set; }

        static MyCommands()
        {
            Exit = new RoutedCommand("Exit", typeof(MyCommands));
            Save = new RoutedCommand("Save", typeof(MyCommands));
            Open = new RoutedCommand("Open", typeof(MyCommands));
            GraphicEditor = new RoutedCommand("Graphic Editor", typeof(MyCommands));
        }
    }

    class GraphicCommands
    {
        public static RoutedCommand Exit { get; set; }
        public static RoutedCommand Save { get; set; }
        public static RoutedCommand Open { get; set; }
        static GraphicCommands()
        {
            Exit = new RoutedCommand("Exit", typeof(MyCommands));
            Save = new RoutedCommand("Save", typeof(MyCommands));
            Open = new RoutedCommand("Open", typeof(MyCommands));
        }

    }
}
