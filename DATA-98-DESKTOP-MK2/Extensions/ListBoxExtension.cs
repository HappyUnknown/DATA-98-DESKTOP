using DATA_98_DESKTOP_MK2.Constants;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace DATA_98_DESKTOP_MK2.Extensions
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
        public static string ItemsAsSequence(this ListBox lb)
        {
            string[] array = ItemsAsArray(lb);
            return JsonConvert.SerializeObject(array);
        }
    }
}
