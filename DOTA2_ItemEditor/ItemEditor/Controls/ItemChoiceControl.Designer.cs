namespace Dota2.ItemEditor.Controls
{
    partial class ItemChoiceControl
    {
        /// <summary> 
        /// 必要なデザイナ変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナで生成されたコード

        /// <summary> 
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemChoiceControl));
            this.itemListView = new System.Windows.Forms.ListView();
            this.itemChoiceContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smallIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.largeIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lergeImageList = new System.Windows.Forms.ImageList(this.components);
            this.smallImageList = new System.Windows.Forms.ImageList(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.itemComboBox = new System.Windows.Forms.ComboBox();
            this.itemChoiceContextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // itemListView
            // 
            this.itemListView.ContextMenuStrip = this.itemChoiceContextMenuStrip;
            this.itemListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemListView.LargeImageList = this.lergeImageList;
            this.itemListView.Location = new System.Drawing.Point(0, 0);
            this.itemListView.Name = "itemListView";
            this.itemListView.ShowItemToolTips = true;
            this.itemListView.Size = new System.Drawing.Size(502, 391);
            this.itemListView.SmallImageList = this.smallImageList;
            this.itemListView.TabIndex = 0;
            this.itemListView.UseCompatibleStateImageBehavior = false;
            this.itemListView.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.itemListView_ItemDrag);
            // 
            // itemChoiceContextMenuStrip
            // 
            this.itemChoiceContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem});
            this.itemChoiceContextMenuStrip.Name = "heroChoiceContextMenuStrip";
            this.itemChoiceContextMenuStrip.Size = new System.Drawing.Size(105, 26);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smallIconToolStripMenuItem,
            this.largeIconToolStripMenuItem,
            this.detailToolStripMenuItem,
            this.listToolStripMenuItem1});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // smallIconToolStripMenuItem
            // 
            this.smallIconToolStripMenuItem.Name = "smallIconToolStripMenuItem";
            this.smallIconToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.smallIconToolStripMenuItem.Text = "smallIcon";
            this.smallIconToolStripMenuItem.Click += new System.EventHandler(this.smallIconToolStripMenuItem_Click);
            // 
            // largeIconToolStripMenuItem
            // 
            this.largeIconToolStripMenuItem.Name = "largeIconToolStripMenuItem";
            this.largeIconToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.largeIconToolStripMenuItem.Text = "largeIcon";
            this.largeIconToolStripMenuItem.Click += new System.EventHandler(this.largeIconToolStripMenuItem_Click);
            // 
            // detailToolStripMenuItem
            // 
            this.detailToolStripMenuItem.Name = "detailToolStripMenuItem";
            this.detailToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.detailToolStripMenuItem.Text = "detail";
            this.detailToolStripMenuItem.Click += new System.EventHandler(this.detailToolStripMenuItem_Click);
            // 
            // listToolStripMenuItem1
            // 
            this.listToolStripMenuItem1.Name = "listToolStripMenuItem1";
            this.listToolStripMenuItem1.Size = new System.Drawing.Size(132, 22);
            this.listToolStripMenuItem1.Text = "list";
            this.listToolStripMenuItem1.Click += new System.EventHandler(this.listToolStripMenuItem1_Click);
            // 
            // lergeImageList
            // 
            this.lergeImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("lergeImageList.ImageStream")));
            this.lergeImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.lergeImageList.Images.SetKeyName(0, "Abyssal Blade.png");
            this.lergeImageList.Images.SetKeyName(1, "Aegis of the Immortal.png");
            this.lergeImageList.Images.SetKeyName(2, "Aghanim\'s Scepter.png");
            this.lergeImageList.Images.SetKeyName(3, "Animal Courier.png");
            this.lergeImageList.Images.SetKeyName(4, "Arcane Boots.png");
            this.lergeImageList.Images.SetKeyName(5, "Armlet of Mordiggian.png");
            this.lergeImageList.Images.SetKeyName(6, "Assault Cuirass.png");
            this.lergeImageList.Images.SetKeyName(7, "Battle Fury.png");
            this.lergeImageList.Images.SetKeyName(8, "Belt of Strength.png");
            this.lergeImageList.Images.SetKeyName(9, "Black King Bar.png");
            this.lergeImageList.Images.SetKeyName(10, "Blade Mail.png");
            this.lergeImageList.Images.SetKeyName(11, "Blade of Alacrity.png");
            this.lergeImageList.Images.SetKeyName(12, "Blades of Attack.png");
            this.lergeImageList.Images.SetKeyName(13, "Blink Dagger.png");
            this.lergeImageList.Images.SetKeyName(14, "Bloodstone.png");
            this.lergeImageList.Images.SetKeyName(15, "Boots of Elvenskin.png");
            this.lergeImageList.Images.SetKeyName(16, "Boots of Speed.png");
            this.lergeImageList.Images.SetKeyName(17, "Boots of Travel.png");
            this.lergeImageList.Images.SetKeyName(18, "Bottle.png");
            this.lergeImageList.Images.SetKeyName(19, "Bracer.png");
            this.lergeImageList.Images.SetKeyName(20, "Broadsword.png");
            this.lergeImageList.Images.SetKeyName(21, "Buckler.png");
            this.lergeImageList.Images.SetKeyName(22, "Butterfly.png");
            this.lergeImageList.Images.SetKeyName(23, "Chainmail.png");
            this.lergeImageList.Images.SetKeyName(24, "Cheese.png");
            this.lergeImageList.Images.SetKeyName(25, "Circlet.png");
            this.lergeImageList.Images.SetKeyName(26, "Clarity.png");
            this.lergeImageList.Images.SetKeyName(27, "Claymore.png");
            this.lergeImageList.Images.SetKeyName(28, "Cloak.png");
            this.lergeImageList.Images.SetKeyName(29, "Crystalys.png");
            this.lergeImageList.Images.SetKeyName(30, "Daedalus.png");
            this.lergeImageList.Images.SetKeyName(31, "Dagon.png");
            this.lergeImageList.Images.SetKeyName(32, "Demon Edge.png");
            this.lergeImageList.Images.SetKeyName(33, "Desolator.png");
            this.lergeImageList.Images.SetKeyName(34, "Diffusal Blade.png");
            this.lergeImageList.Images.SetKeyName(35, "Divine Rapier.png");
            this.lergeImageList.Images.SetKeyName(36, "Drum of Endurance.png");
            this.lergeImageList.Images.SetKeyName(37, "Dust of Appearance.png");
            this.lergeImageList.Images.SetKeyName(38, "Eaglesong.png");
            this.lergeImageList.Images.SetKeyName(39, "Energy Booster.png");
            this.lergeImageList.Images.SetKeyName(40, "Ethereal Blade.png");
            this.lergeImageList.Images.SetKeyName(41, "Eul\'s Scepter of Divinity.png");
            this.lergeImageList.Images.SetKeyName(42, "Eye of Skadi.png");
            this.lergeImageList.Images.SetKeyName(43, "Flying Courier.png");
            this.lergeImageList.Images.SetKeyName(44, "Force Staff.png");
            this.lergeImageList.Images.SetKeyName(45, "Gauntlets of Strength.png");
            this.lergeImageList.Images.SetKeyName(46, "Gem of True Sight.png");
            this.lergeImageList.Images.SetKeyName(47, "Ghost Scepter.png");
            this.lergeImageList.Images.SetKeyName(48, "Gloves of Haste.png");
            this.lergeImageList.Images.SetKeyName(49, "Hand of Midas.png");
            this.lergeImageList.Images.SetKeyName(50, "Headdress.png");
            this.lergeImageList.Images.SetKeyName(51, "Healing Salve.png");
            this.lergeImageList.Images.SetKeyName(52, "Heart of Tarrasque.png");
            this.lergeImageList.Images.SetKeyName(53, "Heaven\'s Halberd.png");
            this.lergeImageList.Images.SetKeyName(54, "Helm of Iron Will.png");
            this.lergeImageList.Images.SetKeyName(55, "Helm of the Dominator.png");
            this.lergeImageList.Images.SetKeyName(56, "Hood of Defiance.png");
            this.lergeImageList.Images.SetKeyName(57, "Hyperstone.png");
            this.lergeImageList.Images.SetKeyName(58, "Iron Branch.png");
            this.lergeImageList.Images.SetKeyName(59, "item_tango.png");
            this.lergeImageList.Images.SetKeyName(60, "Javelin.png");
            this.lergeImageList.Images.SetKeyName(61, "Linken\'s Sphere.png");
            this.lergeImageList.Images.SetKeyName(62, "Maelstrom.png");
            this.lergeImageList.Images.SetKeyName(63, "Magic Stick.png");
            this.lergeImageList.Images.SetKeyName(64, "Magic Wand.png");
            this.lergeImageList.Images.SetKeyName(65, "Manta Style.png");
            this.lergeImageList.Images.SetKeyName(66, "Mantle of Intelligence.png");
            this.lergeImageList.Images.SetKeyName(67, "Mask of Madness.png");
            this.lergeImageList.Images.SetKeyName(68, "Medallion of Courage.png");
            this.lergeImageList.Images.SetKeyName(69, "Mekansm.png");
            this.lergeImageList.Images.SetKeyName(70, "Mithril Hammer.png");
            this.lergeImageList.Images.SetKeyName(71, "Mjollnir.png");
            this.lergeImageList.Images.SetKeyName(72, "Monkey King Bar.png");
            this.lergeImageList.Images.SetKeyName(73, "Morbid Mask.png");
            this.lergeImageList.Images.SetKeyName(74, "Mystic Staff.png");
            this.lergeImageList.Images.SetKeyName(75, "Necronomicon.png");
            this.lergeImageList.Images.SetKeyName(76, "Null Talisman.png");
            this.lergeImageList.Images.SetKeyName(77, "Oblivion Staff.png");
            this.lergeImageList.Images.SetKeyName(78, "Observer Ward.png");
            this.lergeImageList.Images.SetKeyName(79, "Ogre Club.png");
            this.lergeImageList.Images.SetKeyName(80, "Orb of Venom.png");
            this.lergeImageList.Images.SetKeyName(81, "Orchid Malevolence.png");
            this.lergeImageList.Images.SetKeyName(82, "Perseverance.png");
            this.lergeImageList.Images.SetKeyName(83, "Phase Boots.png");
            this.lergeImageList.Images.SetKeyName(84, "Pipe of Insight.png");
            this.lergeImageList.Images.SetKeyName(85, "Platemail.png");
            this.lergeImageList.Images.SetKeyName(86, "Point Booster.png");
            this.lergeImageList.Images.SetKeyName(87, "Poor Man\'s Shield.png");
            this.lergeImageList.Images.SetKeyName(88, "Power Treads.png");
            this.lergeImageList.Images.SetKeyName(89, "Quarterstaff.png");
            this.lergeImageList.Images.SetKeyName(90, "Quelling Blade.png");
            this.lergeImageList.Images.SetKeyName(91, "Radiance.png");
            this.lergeImageList.Images.SetKeyName(92, "Reaver.png");
            this.lergeImageList.Images.SetKeyName(93, "Refresher Orb.png");
            this.lergeImageList.Images.SetKeyName(94, "Ring of Aquila.png");
            this.lergeImageList.Images.SetKeyName(95, "Ring of Basilius.png");
            this.lergeImageList.Images.SetKeyName(96, "Ring of Health.png");
            this.lergeImageList.Images.SetKeyName(97, "Ring of Protection.png");
            this.lergeImageList.Images.SetKeyName(98, "Ring of Regen.png");
            this.lergeImageList.Images.SetKeyName(99, "Robe of the Magi.png");
            this.lergeImageList.Images.SetKeyName(100, "Rod of Atos.png");
            this.lergeImageList.Images.SetKeyName(101, "Sacred Relic.png");
            this.lergeImageList.Images.SetKeyName(102, "Sange and Yasha.png");
            this.lergeImageList.Images.SetKeyName(103, "Sange.png");
            this.lergeImageList.Images.SetKeyName(104, "Satanic.png");
            this.lergeImageList.Images.SetKeyName(105, "Scythe of Vyse.png");
            this.lergeImageList.Images.SetKeyName(106, "Sentry Ward.png");
            this.lergeImageList.Images.SetKeyName(107, "Shadow Amulet.png");
            this.lergeImageList.Images.SetKeyName(108, "Shadow Blade.png");
            this.lergeImageList.Images.SetKeyName(109, "Shiva\'s Guard.png");
            this.lergeImageList.Images.SetKeyName(110, "Skull Basher.png");
            this.lergeImageList.Images.SetKeyName(111, "Slippers of Agility.png");
            this.lergeImageList.Images.SetKeyName(112, "Smoke of Deceit.png");
            this.lergeImageList.Images.SetKeyName(113, "Soul Booster.png");
            this.lergeImageList.Images.SetKeyName(114, "Soul Ring.png");
            this.lergeImageList.Images.SetKeyName(115, "Staff of Wizardry.png");
            this.lergeImageList.Images.SetKeyName(116, "Stout Shield.png");
            this.lergeImageList.Images.SetKeyName(117, "Talisman of Evasion.png");
            this.lergeImageList.Images.SetKeyName(118, "Tango.png");
            this.lergeImageList.Images.SetKeyName(119, "Town Portal Scroll.png");
            this.lergeImageList.Images.SetKeyName(120, "Tranquil Boots.png");
            this.lergeImageList.Images.SetKeyName(121, "Ultimate Orb.png");
            this.lergeImageList.Images.SetKeyName(122, "Urn of Shadows.png");
            this.lergeImageList.Images.SetKeyName(123, "Vanguard.png");
            this.lergeImageList.Images.SetKeyName(124, "Veil of Discord.png");
            this.lergeImageList.Images.SetKeyName(125, "Vitality Booster.png");
            this.lergeImageList.Images.SetKeyName(126, "Vladmir\'s Offering.png");
            this.lergeImageList.Images.SetKeyName(127, "Void Stone.png");
            this.lergeImageList.Images.SetKeyName(128, "Wraith Band.png");
            this.lergeImageList.Images.SetKeyName(129, "Yasha.png");
            // 
            // smallImageList
            // 
            this.smallImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("smallImageList.ImageStream")));
            this.smallImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.smallImageList.Images.SetKeyName(0, "Abyssal Blade.png");
            this.smallImageList.Images.SetKeyName(1, "Aegis of the Immortal.png");
            this.smallImageList.Images.SetKeyName(2, "Aghanim\'s Scepter.png");
            this.smallImageList.Images.SetKeyName(3, "Animal Courier.png");
            this.smallImageList.Images.SetKeyName(4, "Arcane Boots.png");
            this.smallImageList.Images.SetKeyName(5, "Armlet of Mordiggian.png");
            this.smallImageList.Images.SetKeyName(6, "Assault Cuirass.png");
            this.smallImageList.Images.SetKeyName(7, "Battle Fury.png");
            this.smallImageList.Images.SetKeyName(8, "Belt of Strength.png");
            this.smallImageList.Images.SetKeyName(9, "Black King Bar.png");
            this.smallImageList.Images.SetKeyName(10, "Blade Mail.png");
            this.smallImageList.Images.SetKeyName(11, "Blade of Alacrity.png");
            this.smallImageList.Images.SetKeyName(12, "Blades of Attack.png");
            this.smallImageList.Images.SetKeyName(13, "Blink Dagger.png");
            this.smallImageList.Images.SetKeyName(14, "Bloodstone.png");
            this.smallImageList.Images.SetKeyName(15, "Boots of Elvenskin.png");
            this.smallImageList.Images.SetKeyName(16, "Boots of Speed.png");
            this.smallImageList.Images.SetKeyName(17, "Boots of Travel.png");
            this.smallImageList.Images.SetKeyName(18, "Bottle.png");
            this.smallImageList.Images.SetKeyName(19, "Bracer.png");
            this.smallImageList.Images.SetKeyName(20, "Broadsword.png");
            this.smallImageList.Images.SetKeyName(21, "Buckler.png");
            this.smallImageList.Images.SetKeyName(22, "Butterfly.png");
            this.smallImageList.Images.SetKeyName(23, "Chainmail.png");
            this.smallImageList.Images.SetKeyName(24, "Cheese.png");
            this.smallImageList.Images.SetKeyName(25, "Circlet.png");
            this.smallImageList.Images.SetKeyName(26, "Clarity.png");
            this.smallImageList.Images.SetKeyName(27, "Claymore.png");
            this.smallImageList.Images.SetKeyName(28, "Cloak.png");
            this.smallImageList.Images.SetKeyName(29, "Crystalys.png");
            this.smallImageList.Images.SetKeyName(30, "Daedalus.png");
            this.smallImageList.Images.SetKeyName(31, "Dagon.png");
            this.smallImageList.Images.SetKeyName(32, "Demon Edge.png");
            this.smallImageList.Images.SetKeyName(33, "Desolator.png");
            this.smallImageList.Images.SetKeyName(34, "Diffusal Blade.png");
            this.smallImageList.Images.SetKeyName(35, "Divine Rapier.png");
            this.smallImageList.Images.SetKeyName(36, "Drum of Endurance.png");
            this.smallImageList.Images.SetKeyName(37, "Dust of Appearance.png");
            this.smallImageList.Images.SetKeyName(38, "Eaglesong.png");
            this.smallImageList.Images.SetKeyName(39, "Energy Booster.png");
            this.smallImageList.Images.SetKeyName(40, "Ethereal Blade.png");
            this.smallImageList.Images.SetKeyName(41, "Eul\'s Scepter of Divinity.png");
            this.smallImageList.Images.SetKeyName(42, "Eye of Skadi.png");
            this.smallImageList.Images.SetKeyName(43, "Flying Courier.png");
            this.smallImageList.Images.SetKeyName(44, "Force Staff.png");
            this.smallImageList.Images.SetKeyName(45, "Gauntlets of Strength.png");
            this.smallImageList.Images.SetKeyName(46, "Gem of True Sight.png");
            this.smallImageList.Images.SetKeyName(47, "Ghost Scepter.png");
            this.smallImageList.Images.SetKeyName(48, "Gloves of Haste.png");
            this.smallImageList.Images.SetKeyName(49, "Hand of Midas.png");
            this.smallImageList.Images.SetKeyName(50, "Headdress.png");
            this.smallImageList.Images.SetKeyName(51, "Healing Salve.png");
            this.smallImageList.Images.SetKeyName(52, "Heart of Tarrasque.png");
            this.smallImageList.Images.SetKeyName(53, "Heaven\'s Halberd.png");
            this.smallImageList.Images.SetKeyName(54, "Helm of Iron Will.png");
            this.smallImageList.Images.SetKeyName(55, "Helm of the Dominator.png");
            this.smallImageList.Images.SetKeyName(56, "Hood of Defiance.png");
            this.smallImageList.Images.SetKeyName(57, "Hyperstone.png");
            this.smallImageList.Images.SetKeyName(58, "Iron Branch.png");
            this.smallImageList.Images.SetKeyName(59, "item_tango.png");
            this.smallImageList.Images.SetKeyName(60, "Javelin.png");
            this.smallImageList.Images.SetKeyName(61, "Linken\'s Sphere.png");
            this.smallImageList.Images.SetKeyName(62, "Maelstrom.png");
            this.smallImageList.Images.SetKeyName(63, "Magic Stick.png");
            this.smallImageList.Images.SetKeyName(64, "Magic Wand.png");
            this.smallImageList.Images.SetKeyName(65, "Manta Style.png");
            this.smallImageList.Images.SetKeyName(66, "Mantle of Intelligence.png");
            this.smallImageList.Images.SetKeyName(67, "Mask of Madness.png");
            this.smallImageList.Images.SetKeyName(68, "Medallion of Courage.png");
            this.smallImageList.Images.SetKeyName(69, "Mekansm.png");
            this.smallImageList.Images.SetKeyName(70, "Mithril Hammer.png");
            this.smallImageList.Images.SetKeyName(71, "Mjollnir.png");
            this.smallImageList.Images.SetKeyName(72, "Monkey King Bar.png");
            this.smallImageList.Images.SetKeyName(73, "Morbid Mask.png");
            this.smallImageList.Images.SetKeyName(74, "Mystic Staff.png");
            this.smallImageList.Images.SetKeyName(75, "Necronomicon.png");
            this.smallImageList.Images.SetKeyName(76, "Null Talisman.png");
            this.smallImageList.Images.SetKeyName(77, "Oblivion Staff.png");
            this.smallImageList.Images.SetKeyName(78, "Observer Ward.png");
            this.smallImageList.Images.SetKeyName(79, "Ogre Club.png");
            this.smallImageList.Images.SetKeyName(80, "Orb of Venom.png");
            this.smallImageList.Images.SetKeyName(81, "Orchid Malevolence.png");
            this.smallImageList.Images.SetKeyName(82, "Perseverance.png");
            this.smallImageList.Images.SetKeyName(83, "Phase Boots.png");
            this.smallImageList.Images.SetKeyName(84, "Pipe of Insight.png");
            this.smallImageList.Images.SetKeyName(85, "Platemail.png");
            this.smallImageList.Images.SetKeyName(86, "Point Booster.png");
            this.smallImageList.Images.SetKeyName(87, "Poor Man\'s Shield.png");
            this.smallImageList.Images.SetKeyName(88, "Power Treads.png");
            this.smallImageList.Images.SetKeyName(89, "Quarterstaff.png");
            this.smallImageList.Images.SetKeyName(90, "Quelling Blade.png");
            this.smallImageList.Images.SetKeyName(91, "Radiance.png");
            this.smallImageList.Images.SetKeyName(92, "Reaver.png");
            this.smallImageList.Images.SetKeyName(93, "Refresher Orb.png");
            this.smallImageList.Images.SetKeyName(94, "Ring of Aquila.png");
            this.smallImageList.Images.SetKeyName(95, "Ring of Basilius.png");
            this.smallImageList.Images.SetKeyName(96, "Ring of Health.png");
            this.smallImageList.Images.SetKeyName(97, "Ring of Protection.png");
            this.smallImageList.Images.SetKeyName(98, "Ring of Regen.png");
            this.smallImageList.Images.SetKeyName(99, "Robe of the Magi.png");
            this.smallImageList.Images.SetKeyName(100, "Rod of Atos.png");
            this.smallImageList.Images.SetKeyName(101, "Sacred Relic.png");
            this.smallImageList.Images.SetKeyName(102, "Sange and Yasha.png");
            this.smallImageList.Images.SetKeyName(103, "Sange.png");
            this.smallImageList.Images.SetKeyName(104, "Satanic.png");
            this.smallImageList.Images.SetKeyName(105, "Scythe of Vyse.png");
            this.smallImageList.Images.SetKeyName(106, "Sentry Ward.png");
            this.smallImageList.Images.SetKeyName(107, "Shadow Amulet.png");
            this.smallImageList.Images.SetKeyName(108, "Shadow Blade.png");
            this.smallImageList.Images.SetKeyName(109, "Shiva\'s Guard.png");
            this.smallImageList.Images.SetKeyName(110, "Skull Basher.png");
            this.smallImageList.Images.SetKeyName(111, "Slippers of Agility.png");
            this.smallImageList.Images.SetKeyName(112, "Smoke of Deceit.png");
            this.smallImageList.Images.SetKeyName(113, "Soul Booster.png");
            this.smallImageList.Images.SetKeyName(114, "Soul Ring.png");
            this.smallImageList.Images.SetKeyName(115, "Staff of Wizardry.png");
            this.smallImageList.Images.SetKeyName(116, "Stout Shield.png");
            this.smallImageList.Images.SetKeyName(117, "Talisman of Evasion.png");
            this.smallImageList.Images.SetKeyName(118, "Tango.png");
            this.smallImageList.Images.SetKeyName(119, "Town Portal Scroll.png");
            this.smallImageList.Images.SetKeyName(120, "Tranquil Boots.png");
            this.smallImageList.Images.SetKeyName(121, "Ultimate Orb.png");
            this.smallImageList.Images.SetKeyName(122, "Urn of Shadows.png");
            this.smallImageList.Images.SetKeyName(123, "Vanguard.png");
            this.smallImageList.Images.SetKeyName(124, "Veil of Discord.png");
            this.smallImageList.Images.SetKeyName(125, "Vitality Booster.png");
            this.smallImageList.Images.SetKeyName(126, "Vladmir\'s Offering.png");
            this.smallImageList.Images.SetKeyName(127, "Void Stone.png");
            this.smallImageList.Images.SetKeyName(128, "Wraith Band.png");
            this.smallImageList.Images.SetKeyName(129, "Yasha.png");
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.itemComboBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.itemListView);
            this.splitContainer1.Size = new System.Drawing.Size(502, 420);
            this.splitContainer1.SplitterDistance = 25;
            this.splitContainer1.TabIndex = 2;
            // 
            // itemComboBox
            // 
            this.itemComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.itemComboBox.DisplayMember = "Name";
            this.itemComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemComboBox.FormattingEnabled = true;
            this.itemComboBox.Location = new System.Drawing.Point(0, 0);
            this.itemComboBox.Name = "itemComboBox";
            this.itemComboBox.Size = new System.Drawing.Size(502, 20);
            this.itemComboBox.TabIndex = 0;
            this.itemComboBox.ValueMember = "Name";
            this.itemComboBox.SelectedIndexChanged += new System.EventHandler(this.itemComboBox_SelectedIndexChanged);
            // 
            // ItemChoiceControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "ItemChoiceControl";
            this.Size = new System.Drawing.Size(502, 420);
            this.Load += new System.EventHandler(this.ItemChoiceControl_Load);
            this.itemChoiceContextMenuStrip.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView itemListView;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox itemComboBox;
        private System.Windows.Forms.ImageList lergeImageList;
        private System.Windows.Forms.ImageList smallImageList;
        private System.Windows.Forms.ContextMenuStrip itemChoiceContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smallIconToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem largeIconToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listToolStripMenuItem1;
    }
}
