using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Dota2.ItemEditor.Data;
using DOTA2.ItemEditor.ItemEditor.Data;

namespace Dota2.ItemEditor.Controls{
    public partial class ItemChoiceControl : UserControl{

        private Point mouseDownPoint = Point.Empty;

        public ItemChoiceControl(){
            InitializeComponent();
        }

        private void ItemChoiceControl_Load(object sender, EventArgs e) {
            //全アイテムの読み込み
            foreach (ItemData item in DataResources.ItemDataList){
                ListViewItem listItem = new ListViewItem(item.Name, item.Name);
                listItem.Tag = item;
                listItem.ToolTipText = item.Effect;
                listItem.ImageKey = item.Name + ".png";
                
                //item dataにも
                item.Image = lergeImageList.Images[listItem.ImageKey];

                itemListView.Items.Add(listItem);
            }

            itemComboBox.DataSource = DataResources.ItemDataList;
            itemComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
        }


        //public void setItemImageList(ImageList imageList) {
        //    itemListView.LargeImageList = imageList;
        //    itemListView.SmallImageList = imageList;
        //    itemListView.LargeImageList.ImageSize = new Size(32, 32);
        //    itemListView.View = View.LargeIcon;
        //    foreach (ListViewItem listitem in itemListView.Items) {
        //        ImageList hoge = listitem.ImageList;
        //        ItemData item = listitem.Tag as ItemData;
        //        Image image = itemListView.LargeImageList.Images[item.Name];
        //        if (image != null) {
        //            Console.WriteLine("image not null");
        //            Console.WriteLine(image.Size);
        //        }
        //    }
        //    itemListView.Refresh();
        //}




        private void itemComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            itemListView.FindItemWithText(itemComboBox.SelectedItem.ToString());
        }


        #region view type change menu

        private void viewToolStripMenuItem_DropDownOpening(object sender, EventArgs e) {
            smallIconToolStripMenuItem.Checked = itemListView.View == View.SmallIcon;
            largeIconToolStripMenuItem.Checked = itemListView.View == View.LargeIcon;
            detailToolStripMenuItem.Checked = itemListView.View == View.Details;
            listToolStripMenuItem1.Checked = itemListView.View == View.List;
        }
        private void smallIconToolStripMenuItem_Click(object sender, EventArgs e) {
            itemListView.View = View.SmallIcon;
        }

        private void largeIconToolStripMenuItem_Click(object sender, EventArgs e) {
            itemListView.View = View.LargeIcon;
        }

        private void detailToolStripMenuItem_Click(object sender, EventArgs e) {
            itemListView.View = View.Details;
        }
        private void listToolStripMenuItem1_Click(object sender, EventArgs e) {
            itemListView.View = View.List;
        }

        #endregion

        #region D&D関係
        /* D&D実装*/
        private void itemListView_ItemDrag(object sender, ItemDragEventArgs e) {
            ListViewItem item = e.Item as ListViewItem;
            if (item != null) {
                DataObject data = new DataObject(ItemData.DRAG_FORMAT, item.Tag);
                itemListView.DoDragDrop(data, DragDropEffects.All);
            }
        }
        #endregion


    }
}
