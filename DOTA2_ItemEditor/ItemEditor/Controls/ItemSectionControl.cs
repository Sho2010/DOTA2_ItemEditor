using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Dota2.ItemEditor.Data;
using DOTA2.ItemEditor.ItemEditor.Data;

namespace DOTA2.ItemEditor.ItemEditor.Controls {
    public partial class ItemSectionControl : UserControl {
        
        /// <summary>
        /// アイテムの追加、削除、セクション名の変更があった場合発生する。
        /// </summary>
        public event ItemEditedEventHandler ItemEdited;


        private ItemBuildSection currentSection;

        public ItemSectionControl() {
            InitializeComponent();
        }

        #region D&D
        private void flowLayoutPanel_DragDrop(object sender, DragEventArgs e) {
            Console.WriteLine("D&D");
            ItemData item = ((IDataObject)e.Data).GetData(ItemData.DRAG_FORMAT) as ItemData;

            if (item != null) {
                addItem(item , false);
            }
        }

        private void flowLayoutPanel_DragEnter(object sender, DragEventArgs e) {
            e.Effect = DragDropEffects.All;
        }
        #endregion


        private void addItemPicture(ItemData item) {
            PictureBox pic = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pic)).BeginInit();
            pic.Image = item.Image;
            pic.InitialImage = null;
            pic.Location = new System.Drawing.Point(3, 3);

            pic.Name = item.Name;
            pic.Size = new System.Drawing.Size(43, 32);
            pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pic.Tag = item;
            pic.ContextMenuStrip = this.itemSectionContextMenuStrip;
            pic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            //ToolTip作成
            ToolTip tooltip1 = new ToolTip();
            tooltip1.SetToolTip(pic, item.Effect);
            this.flowLayoutPanel.Controls.Add(pic);

            //TODO:KeyDown実装 めんどいからあとで

        }

        /*アイテムを追加*/
        private void addItem(ItemData item , bool init) {
            addItemPicture(item);

            //データ的にアイテムを追加
            if (!init) {
                currentSection.Items.Add(item);
            }

            //アイテムが追加されたので編集イベント発行
            if (ItemEdited != null && !init) {
                ItemEdited(this , new ItemEditEventArgs(item , 
                    DOTA2.ItemEditor.ItemEditor.Controls.ItemEditEventArgs.EventType.Add));
            }
        }

        private void deleteItem(ItemData item) {
            if (item == null) {
                return;
            }

            Control deletePic = null;

            foreach (Control control in flowLayoutPanel.Controls){
                ItemData bindItem = control.Tag as ItemData;
                if (bindItem != null && bindItem == item) {
                    deletePic = control;
                    break;
                }
            }

            if (deletePic != null) {
                currentSection.Items.Remove(item);      //セクション内のデータも削除
                flowLayoutPanel.Controls.Remove(deletePic);
                //アイテムが削除されたので編集イベント発行
                if (ItemEdited != null) {
                    ItemEdited(this, new ItemEditEventArgs(item, DOTA2.ItemEditor.ItemEditor.Controls.ItemEditEventArgs.EventType.Delete));
                }
            }
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e) {
            PictureBox pic = itemSectionContextMenuStrip.SourceControl as PictureBox;
            if (pic != null) {

                ItemData delItem = pic.Tag as ItemData;
                if (delItem != null) {
                    currentSection.Items.Remove(delItem);
                }

                flowLayoutPanel.Controls.Remove(pic);
                //アイテムが削除されたので編集イベント発行
                if (ItemEdited != null) {
                    ItemEdited(this, new ItemEditEventArgs(delItem, DOTA2.ItemEditor.ItemEditor.Controls.ItemEditEventArgs.EventType.Delete));
                }
            }
        }

        private void sectionNameTextBox_TextChanged(object sender, EventArgs e) {
            //セクションラベルが編集されたのでイベントを発行
            if (ItemEdited != null) {
                ItemEdited(this, new ItemEditEventArgs(null, DOTA2.ItemEditor.ItemEditor.Controls.ItemEditEventArgs.EventType.LabelEdit));
            }
        }

        /// <summary>
        /// 引数のセクションからUIに値を設定
        /// </summary>
        /// <param name="section">設定アイテムセクション</param>
        public void LayoutSectionValue(ItemBuildSection section) {
            //一回全部消す
            flowLayoutPanel.Controls.Clear();

            sectionNameTextBox.Text = section.SectionLabel;
            currentSection = section;

            foreach (ItemData item in section.Items) {
                //初期化の時は変更イベント発行しない
                addItem(item, true);
            }
        }

        public string SectionNameText {
            get {
                return sectionNameTextBox != null ? sectionNameTextBox.Text : "";
            }
            set {
                sectionNameTextBox.Text = value;
            }
        }
    }

    /// <summary>
    /// アイテム編集時に発生するイベントハンドラ
    /// </summary>
    /// <param name="sender">いつもの</param>
    /// <param name="e">編集対象いるならあとで入れる</param>
    public delegate void ItemEditedEventHandler(object sender, ItemEditEventArgs e);

    public class ItemEditEventArgs : EventArgs {
        public enum EventType {
            Add,
            Delete,
            LabelEdit
        }


        public ItemEditEventArgs(string labelValue) {
            Event = EventType.LabelEdit;
            LabelNewValue = labelValue;

        }

        public ItemEditEventArgs(ItemData item , EventType type) {
            EditItemData = item;
            Event = type;
        }

        public string LabelNewValue { get; private set; }
        public ItemData EditItemData { get; private set; }
        public EventType Event { get; private set; }
    }

}
