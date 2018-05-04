using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace Hammer.MDIContainer.Control.Extensions
{
    internal static class WindowBehaviorExtension
    {
        public static void Maximize(this MdiWindow window)
        {
            if (window.IsResizable)
            {
                Canvas.SetTop(window, 0.0);
                Canvas.SetLeft(window, 0.0);

                AnimateResize(window, window.Container.ActualWidth - 4, window.Container.ActualHeight - 4, true);

                window.WindowState = WindowState.Maximized;
                ResetItems(window);

            }
        }

        public static void Normalize(this MdiWindow window)
        {
            Canvas.SetTop(window, window.LastTop);
            Canvas.SetLeft(window, window.LastLeft);

            AnimateResize(window, window.LastWidth, window.LastHeight, false);

            window.WindowState = WindowState.Normal;
            ResetItems(window);
        }

        public static void ResetItems(this MdiWindow window)
        {
            var normalizedItems = window.Container.Items;

            int count = 0;
            foreach (MdiWindow item in window.Container.Items)
            {
                if (item.WindowState == WindowState.Minimized)
                {
                    Canvas.SetTop(item, item.Container.ActualHeight - 32);
                    Canvas.SetLeft(item, count * 203);

                    RemoveWindowLock(item);
                    AnimateResize(item, 200, 32, true);
                    count++;
                }
            }

            window.Container.MinimizedWindowsCount = count;
        }

        public static void Minimize(this MdiWindow window)
        {
            //ResetItems(window);
            int minimizedItemsCount = window.Container.MinimizedWindowsCount;

            //for (int i = 1; i < window.Container.Items.Count; i++)
            //{
            //    if (((MdiWindow)window.Container.Items[i]).WindowState == WindowState.Minimized)
            //    {
            //        minimizedItemsCount++;
            //    }
            //}

            window.LastWidth = window.ActualWidth;
            window.LastHeight = window.ActualHeight;
            Canvas.SetTop(window, window.Container.ActualHeight - 32);
            Canvas.SetLeft(window, minimizedItemsCount * 203);

            RemoveWindowLock(window);
            AnimateResize(window, 200, 32, true);

            window.WindowState = WindowState.Minimized;

            window.Tumblr.Source = window.CreateSnapshot();
        }

        private static void AnimateResize(MdiWindow window, double newWidth, double newHeight, bool lockWindow)
        {
            window.LayoutTransform = new ScaleTransform();

            var widthAnimation = new DoubleAnimation(window.ActualWidth, newWidth, new Duration(TimeSpan.FromMilliseconds(10)));
            var heightAnimation = new DoubleAnimation(window.ActualHeight, newHeight, new Duration(TimeSpan.FromMilliseconds(10)));

            if (lockWindow == false)
            {
                widthAnimation.Completed += (s, e) => window.BeginAnimation(FrameworkElement.WidthProperty, null);
                heightAnimation.Completed += (s, e) => window.BeginAnimation(FrameworkElement.HeightProperty, null);
            }

            window.BeginAnimation(FrameworkElement.WidthProperty, widthAnimation, HandoffBehavior.Compose);
            window.BeginAnimation(FrameworkElement.HeightProperty, heightAnimation, HandoffBehavior.Compose);
        }

        public static void ToggleMaximize(this MdiWindow window)
        {
            if (window.WindowState == WindowState.Maximized)
            {
                window.Normalize();
            }
            else
            {
                window.Maximize();
            }
        }

        public static void ToggleMinimize(this MdiWindow window)
        {
            if (window.WindowState != WindowState.Minimized)
            {
                window.Minimize();
            }
            else
            {
                switch (window.PreviousWindowState)
                {
                    case WindowState.Maximized:
                        window.Maximize();
                        break;
                    case WindowState.Normal:
                        window.Normalize();
                        break;
                    default:
                        throw new NotSupportedException("Invalid WindowState");
                }
            }
        }

        public static void ToggleRestore(this MdiWindow window)
        {
            switch (window.PreviousWindowState)
            {
                case WindowState.Maximized:
                    window.Maximize();
                    break;
                case WindowState.Normal:
                    window.Normalize();
                    break;
                default:
                    throw new NotSupportedException("Invalid WindowState");
            }
        }

        public static void RemoveWindowLock(this MdiWindow window)
        {
            window.BeginAnimation(FrameworkElement.WidthProperty, null);
            window.BeginAnimation(FrameworkElement.HeightProperty, null);
        }
    }
}