using Hammer.MDIContainer.Control;
using MaterialMessageBoxUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SchoolManagement.Desktop.Helpers
{
    public class WindowHelper
    {
        public static void CatchException(Exception ex)
        {
            MaterialMessageBox.Show("An error has occured! Please check your network connection and try again. If error persists, contact your IT administrator.", "AlertCircle", MessageBoxButton.OK);
        }
        public static void CloseWindow(object parent)
        {
            MdiContainer container = ((MdiWindow)parent).Parent as MdiContainer;
            container.Items.Remove((MdiWindow)parent);
        }
        //public static void LaunchPrintWindow(object parent)
        //{
        //    MdiContainer container = ((MdiWindow)parent).Parent as MdiContainer;
        //    HomeWindow homeWindow = (HomeWindow)FindWindow(container.Parent);

        //    MdiWindow item = new MdiWindow
        //    {
        //        Title = "Print Preview",
        //        CanClose = true,
        //        Height = 530,
        //        Width = 1050,
        //        IsResizable = true,
        //        IsModal = false,
        //        Content = new PrintPreview(),
        //        WindowID = "Print Preview",
        //        ParentTitle = ((MdiWindow)parent).Title,
        //        ParentSelectedIndex = ((MdiWindow)parent).ParentSelectedIndex,
        //        AdditionalProperties = new List<KeyValuePair<string, object>>() { homeWindow._printTools }
        //    };
        //    item.Closing += (s, f) => { container.Items.Remove(item); homeWindow.CollapseAllMenuToolBars(); };
        //    container.Items.Add(item);
        //}

        //public static void LaunchPrintWindow(object parent, int windowWidth, int windowHeight)
        //{
        //    MdiContainer container = ((MdiWindow)parent).Parent as MdiContainer;
        //    HomeWindow homeWindow = (HomeWindow)FindWindow(container.Parent);

        //    MdiWindow item = new MdiWindow
        //    {
        //        Title = "Print Preview",
        //        CanClose = true,
        //        Height = windowHeight,
        //        Width = windowWidth,
        //        IsResizable = true,
        //        IsModal = false,
        //        Content = new PrintPreview(),
        //        WindowID = "Print Preview",
        //        ParentTitle = ((MdiWindow)parent).Title,
        //        ParentSelectedIndex = ((MdiWindow)parent).ParentSelectedIndex,
        //        AdditionalProperties = new List<KeyValuePair<string, object>>() { homeWindow._printTools }
        //    };
        //    item.Closing += (s, f) => { container.Items.Remove(item); homeWindow.CollapseAllMenuToolBars(); };
        //    container.Items.Add(item);
        //}

        public static object FindWindow(object container)
        {
            if (((System.Windows.FrameworkElement)container).GetType().Equals(typeof(HomeWindow)))
            {
                return (System.Windows.FrameworkElement)container;
            }
            else
            {
                if (((System.Windows.FrameworkElement)container).Parent != null)
                {
                    return FindWindow(((System.Windows.FrameworkElement)container).Parent);
                }
                else
                {
                    return null;
                }
            }
        }

        public static bool CheckRestoreExistingWindow(MdiWindow window, MdiContainer container)
        {
            if ((container.Items.OfType<MdiWindow>()).Where(r => r.Content.GetType() == window.Content.GetType()).Count() > 0)
            {
                var existingWindow = (container.Items.OfType<MdiWindow>()).Where(r => r.Content.GetType() == window.Content.GetType()).First();
                if (existingWindow.WindowState == System.Windows.WindowState.Minimized)
                {
                    existingWindow.ToggleRestoreWindow();
                }
                else
                {
                    existingWindow.Focus();
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
