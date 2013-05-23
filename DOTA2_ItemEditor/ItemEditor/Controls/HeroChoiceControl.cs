using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using Dota2.ItemEditor.Data;
using DOTA2.ItemEditor.ItemEditor.Data;
using DOTA2.ItemEditor.ItemEditor.Controls;

namespace Dota2.ItemEditor.Controls{
    public partial class HeroChoiceControl : UserControl{

        private List<HeroData> heroList = new List<HeroData>();

        public event HeroSelectEventHandler HeroSelected;

        private HeroFilter filter = new HeroFilter();

        public HeroChoiceControl(){
            InitializeComponent();

            heroComboBox.DataSource = DataResources.HeroDataList;
            heroComboBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            heroComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;

            foreach (HeroData hero in DataResources.HeroDataList) {
                ListViewItem listItem = new ListViewItem(hero.Name, hero.Name);
                listItem.Tag = hero;
                //listItem.ToolTipText = hero.Effect;
                listItem.ImageKey = hero.Name + ".png";
                
                //item dataにも
                hero.Image = lergeImageList.Images[listItem.ImageKey];
                heroListView.Items.Add(listItem);
            }
        }

        /*
         * 変更後ListViewの候補を絞る */
        private void charaComboBox_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void charaListView_SelectedIndexChanged(object sender, EventArgs e) {
            //イベント通知
            if(HeroSelected !=  null){
                if (heroListView.SelectedItems.Count > 0 && heroListView.SelectedItems[0].Tag as HeroData != null) {
                    HeroSelected(this, new HeroSelectEventArgs(heroListView.SelectedItems[0].Tag as HeroData));
                }                
            }      
        }

        private void smallIconToolStripMenuItem_DropDownOpening(object sender, EventArgs e){
            if (heroListView.View == View.SmallIcon){
                smallIconToolStripMenuItem.Checked = true;
            }
        }
        

        
        #region view type change menu

        private void viewToolStripMenuItem_DropDownOpening(object sender, EventArgs e) {
            smallIconToolStripMenuItem.Checked = heroListView.View == View.SmallIcon;            
            largeIconToolStripMenuItem.Checked = heroListView.View == View.LargeIcon;
            detailToolStripMenuItem.Checked = heroListView.View == View.Details;
            listToolStripMenuItem1.Checked = heroListView.View == View.List;
        }
        private void smallIconToolStripMenuItem_Click(object sender, EventArgs e) {
            heroListView.View = View.SmallIcon;
        }

        private void largeIconToolStripMenuItem_Click(object sender, EventArgs e) {
            heroListView.View = View.LargeIcon;
        }

        private void detailToolStripMenuItem_Click(object sender, EventArgs e) {
            heroListView.View = View.Details;
        }
        private void listToolStripMenuItem1_Click(object sender, EventArgs e) {
            heroListView.View = View.List;
        }

        #endregion

        internal void setHeroImageList(ImageList heroImageList) {
            heroListView.LargeImageList = heroImageList;
        }

        public void ExecFilter() {
            
            //フィルターに値をセット
            PrimaryAttribute att = new PrimaryAttribute();
            //filter.set

            //フィルターを実行
            System.Windows.Forms.ListView.ListViewItemCollection col = heroListView.Items;
            //filter.ExecFilter();
        }

        private void filterCheckBox_CheckedChanged(object sender, EventArgs e) {

        }


    }

    public delegate void HeroSelectEventHandler(object sender, HeroSelectEventArgs e);

    public class HeroSelectEventArgs : EventArgs {

        public HeroSelectEventArgs(HeroData heroData) {
            selectedHero = heroData;
        }

        private readonly HeroData selectedHero;
        public HeroData SelectedHero { get { return selectedHero; } }
    }
}
