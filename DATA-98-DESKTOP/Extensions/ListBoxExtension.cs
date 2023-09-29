using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace DATA_98_DESKTOP.Extensions
{
    public static class ListBoxExtension
    {
        public static string[] ItemsAsArray(this ListBox lb)
        {
            string[] array = new string[lb.Items.Count];
            for (int i = 0; i < array.Length; i++)
                array[i] = lb.Items[i].ToString();
            return array;
        }
    }
}
