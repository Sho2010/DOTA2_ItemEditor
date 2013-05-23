using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Dota2.ItemEditor.Data;
using DOTA2.ItemEditor.ItemEditor.Data;
using DOTA2.ItemEditor.ItemEditor.Controls;

namespace Dota2.ItemEditor.ItemEditor.Controls {
    public partial class ItemEditControl : UserControl {
        public ItemEditControl() {
            InitializeComponent();
        }

        /// <summary>
        /// �ύX�t���O
        /// </summary>
        private bool changed = false;

        private HeroData currentHero;

        private void defaultButton_Click(object sender, EventArgs e) {
            if (currentHero == null) {
                return;
            }
            if (DialogResult.OK == MessageBox.Show(this, "Restore default?", "Restore", MessageBoxButtons.OKCancel)) {
                currentHero.RestoreDefaultItemBuild();

                //TODO:�������ݎ��s�`�F�b�N
                settingOverwrite(); 
                
                changed = false;
                SetHero(currentHero);   //�Đݒ肵�ĉ�ʕ`�悵�Ȃ���
            }
        }

        public void SetHero(HeroData heroData) {
            if (changed) {
                //�ύX����Ă����ꍇ�̃_�C�A���O
                switch(MessageBox.Show(this, "Setteing changed overwrite?", "", MessageBoxButtons.YesNoCancel)){
                    case DialogResult.Yes:
                        //�ۑ�����
                        if (!settingOverwrite()) {
                            return; //���炩�̗��R�ŕۑ����s�����ꍇ
                        }
                        break;
                    case DialogResult.No:
                        //�������Ȃ�
                        break;
                    case DialogResult.Cancel:
                        return;
                }
            }

            currentHero = heroData;

            //�摜����ւ�
            if (heroData != null && heroData.Image != null) {
                heroPictureBox.Image = heroData.Image;
            }
            else {
                heroPictureBox.Image = null;
            }

            
            //�A�C�e���ݒ�ǂݍ���
            refreshSection();

            changed = false;
        }

        private void refreshSection(){
            if (currentHero == null) {
                return;
            }

            //�A�C�e���ݒ�ǂݍ���
            flowLayoutPanel1.Controls.Clear();
            ItemBuildData builddata = currentHero.ItemBuildData;
            if(builddata != null){
                foreach (ItemBuildSection section in builddata.Sections) {
                    addSectionControl(section);
                }
            }
        }

        internal void addSectionControl(ItemBuildSection section) {
            ItemSectionControl sectionControl = new ItemSectionControl();
            sectionControl.AllowDrop = true;
            sectionControl.AutoSize = true;
            sectionControl.Location = new System.Drawing.Point(3, 3);
            sectionControl.MinimumSize = new System.Drawing.Size(200, 150);
            sectionControl.Name = section.SectionLabel;
            sectionControl.Size = new System.Drawing.Size(200, 150);

            sectionControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            sectionControl.ItemEdited += new ItemEditedEventHandler(sectionControl_ItemEdited);

            sectionControl.LayoutSectionValue(section);
            flowLayoutPanel1.Controls.Add(sectionControl);

        }

        void sectionControl_ItemEdited(object sender, EventArgs e) {
            changed = true;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns>�ۑ��ɐ��������ꍇtrue</returns>
        internal bool showSaveFileDialog() {
            if (currentHero == null) {
                return false;
            }
            saveFileDialog.InitialDirectory = DataResources.BUILD_FILES_DIR;
            saveFileDialog.FileName = currentHero.DefaultBuildFileName;

            if (saveFileDialog.ShowDialog(this) == DialogResult.OK) {
                return currentHero.ItemBuildData.WriteFile(saveFileDialog.FileName);  
            }
            return false;
        }

        internal bool showOverwriteDialog() {
            if (currentHero == null) {
                return false;
            }
            if (DialogResult.Yes == MessageBox.Show(this, "Are you sure overwrite?", "Overwrite", MessageBoxButtons.YesNo)) {
                return settingOverwrite();
            }
            return false;
        }

        internal bool settingOverwrite() {
            if (currentHero == null) {
                return false;
            }

            string file = DataResources.BUILD_FILES_DIR + currentHero.DefaultBuildFileName;
            if (currentHero.ItemBuildData.WriteFile(file)) {
                changed = false;
                return true;
            }
            return false;
        }

        /// <summary>
        /// �Z�N�V�������x���̃f�t�H���g�{�^�����N���b�N���ꂽ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sectionDefaultButtonClick(object sender, EventArgs e) {
            ItemSectionControl control = sender as ItemSectionControl;
            if(control != null){
                //���Ԗڂ̃p�l�������肵�Ă���ɑΉ������f�t�H���g��������擾
                int index = this.flowLayoutPanel1.Controls.IndexOf(control);
                string name = ItemBuildSection.GetDefaultString(index);
                control.SectionNameText = name;
            }
        }

        private void overwriteButton_Click(object sender, EventArgs e) {
            showOverwriteDialog();
        }

        private void saveButton_Click(object sender, EventArgs e) {
            showSaveFileDialog();
        }

        private void itemSectionControl1_ItemEdited(object sender, ItemEditEventArgs e) {
            ItemSectionControl control = sender as ItemSectionControl;
            int index = -1;
            if(control != null){
                //���Ԗڂ̃p�l�������肵�Ă���ɑΉ������f�t�H���g��������擾
                index = this.flowLayoutPanel1.Controls.IndexOf(control);
            }

            switch (e.Event) {
                case ItemEditEventArgs.EventType.Add:
                    
                    break;
                case ItemEditEventArgs.EventType.Delete:
                    break;
                case ItemEditEventArgs.EventType.LabelEdit:
                    break;
            }
        }
    }
}
