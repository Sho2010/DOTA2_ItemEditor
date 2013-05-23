using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dota2.ItemEditor.Data;
using System.Windows.Forms;

namespace DOTA2.ItemEditor.ItemEditor.Controls {
    class HeroFilter {

        public PrimaryAttribute AttributeFilter { get; set; }
        public HeroRole RoleFilter { get; set; }        

        public bool IsFilter(HeroData data) {
            if (AttributeFilter.HasFlag(data.Attribute)){
                return true;
            }

            if (RoleFilter.HasFlag(data.Role)) {
                return true;
            }

            return false;
        }

        public void ExecFilter(List<ListViewItem> itemList) {
            itemList.RemoveAll(delegate(ListViewItem item) {
                HeroData data = item.Tag as HeroData;
                if (data != null) {
                    return !IsFilter(data);
                }
                return false;
            });
        }

    }
}
