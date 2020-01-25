using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scorebord_leden
{
    public class GenFunction
    {
        public static int GetLvIndex(ListView lv)
        {
            int index = - 1;
            if (lv.SelectedItems.Count > 0)
            {
                index =  lv.Items.IndexOf(lv.SelectedItems[0]);
            }

            return index; ;
        }

        public static void SelectLvCurrentItem(ListView lv, int index)
        {
            lv.Items[index].Selected = true;
            lv.Select();
            lv.EnsureVisible(index);
        }

        public static void SetLvLastItem(ListView lv)
        {
            int lastItem = lv.Items.Count - 1;
            lv.Items[lastItem].Selected = true;
            lv.Select();
            lv.EnsureVisible(lastItem);
        }

        public static void GetLvPervIndexAfterDelete(ListView lv, int prevIndex)
        {
            int itemCount = GetLvItemCount(lv);

            if (itemCount > 1)
            {
                lv.Items[prevIndex - 1].Selected = true;
                lv.Select();
                lv.EnsureVisible(prevIndex - 1);
            }
            else { }
        }

        public static int GetLvItemCount(ListView lv)
        {
            return lv.Items.Count - 1;
        }

        public static void SetLvEditAfterNew(ListView lv)
        {
            SetLvLastItem(lv);
            lv.Items[lv.Items.Count - 1].BeginEdit();
        }
    }
}
