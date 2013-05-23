using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using DOTA2.ItemEditor.ItemEditor.Data;
using Dota2.ItemEditor.Data;

namespace DOTA2_ItemEditor
{
    public partial class MainForm : Form{
        public MainForm(){
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {
        }

        private void heroChoiceControl_HeroSelected(object sender, Dota2.ItemEditor.Controls.HeroSelectEventArgs e) {
            itemEditControl1.SetHero(e.SelectedHero);
        }
    }
}
