namespace Dota2.ItemEditor.Controls
{
    partial class HeroChoiceControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HeroChoiceControl));
            this.heroListView = new System.Windows.Forms.ListView();
            this.lergeImageList = new System.Windows.Forms.ImageList(this.components);
            this.smallImageList = new System.Windows.Forms.ImageList(this.components);
            this.heroComboBox = new System.Windows.Forms.ComboBox();
            this.heroChoiceContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smallIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.largeIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.supportCheckBox = new System.Windows.Forms.CheckBox();
            this.junglerCheckBox = new System.Windows.Forms.CheckBox();
            this.disablerCheckBox = new System.Windows.Forms.CheckBox();
            this.gankerCheckBox = new System.Windows.Forms.CheckBox();
            this.initiatorCheckBox = new System.Windows.Forms.CheckBox();
            this.pusherCheckBox = new System.Windows.Forms.CheckBox();
            this.carryCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.intCheckBox = new System.Windows.Forms.CheckBox();
            this.agiCheckBox = new System.Windows.Forms.CheckBox();
            this.strCheckBox = new System.Windows.Forms.CheckBox();
            this.heroDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.heroChoiceContextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heroDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // heroListView
            // 
            this.heroListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.heroListView.LargeImageList = this.lergeImageList;
            this.heroListView.Location = new System.Drawing.Point(0, 0);
            this.heroListView.MultiSelect = false;
            this.heroListView.Name = "heroListView";
            this.heroListView.Size = new System.Drawing.Size(454, 276);
            this.heroListView.SmallImageList = this.smallImageList;
            this.heroListView.TabIndex = 0;
            this.heroListView.UseCompatibleStateImageBehavior = false;
            this.heroListView.SelectedIndexChanged += new System.EventHandler(this.charaListView_SelectedIndexChanged);
            // 
            // lergeImageList
            // 
            this.lergeImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("lergeImageList.ImageStream")));
            this.lergeImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.lergeImageList.Images.SetKeyName(0, "Alchemist.png");
            this.lergeImageList.Images.SetKeyName(1, "AncientApparition.png");
            this.lergeImageList.Images.SetKeyName(2, "AntiMage.png");
            this.lergeImageList.Images.SetKeyName(3, "Axe.png");
            this.lergeImageList.Images.SetKeyName(4, "Bane.png");
            this.lergeImageList.Images.SetKeyName(5, "Batrider.png");
            this.lergeImageList.Images.SetKeyName(6, "Beastmaster.png");
            this.lergeImageList.Images.SetKeyName(7, "Bloodseeker.png");
            this.lergeImageList.Images.SetKeyName(8, "BountyHunter.png");
            this.lergeImageList.Images.SetKeyName(9, "Brewmaster.png");
            this.lergeImageList.Images.SetKeyName(10, "Broodmother.png");
            this.lergeImageList.Images.SetKeyName(11, "Centaur Warrunner.png");
            this.lergeImageList.Images.SetKeyName(12, "Chen.png");
            this.lergeImageList.Images.SetKeyName(13, "Clinkz.png");
            this.lergeImageList.Images.SetKeyName(14, "Clockwerk.png");
            this.lergeImageList.Images.SetKeyName(15, "CrystalMaiden.png");
            this.lergeImageList.Images.SetKeyName(16, "DarkSeer.png");
            this.lergeImageList.Images.SetKeyName(17, "Dazzle.png");
            this.lergeImageList.Images.SetKeyName(18, "DeathProphet.png");
            this.lergeImageList.Images.SetKeyName(19, "Disruptor.png");
            this.lergeImageList.Images.SetKeyName(20, "DoomBringer.png");
            this.lergeImageList.Images.SetKeyName(21, "DragonKnight.png");
            this.lergeImageList.Images.SetKeyName(22, "DrowRanger.png");
            this.lergeImageList.Images.SetKeyName(23, "Earthshaker.png");
            this.lergeImageList.Images.SetKeyName(24, "Enchantress.png");
            this.lergeImageList.Images.SetKeyName(25, "Enigma.png");
            this.lergeImageList.Images.SetKeyName(26, "FacelessVoid.png");
            this.lergeImageList.Images.SetKeyName(27, "Gyrocopter.png");
            this.lergeImageList.Images.SetKeyName(28, "Huskar.png");
            this.lergeImageList.Images.SetKeyName(29, "Invoker.png");
            this.lergeImageList.Images.SetKeyName(30, "Jakiro.png");
            this.lergeImageList.Images.SetKeyName(31, "Juggernaut.png");
            this.lergeImageList.Images.SetKeyName(32, "Keeper of the Light.png");
            this.lergeImageList.Images.SetKeyName(33, "Kunkka.png");
            this.lergeImageList.Images.SetKeyName(34, "Leshrac.png");
            this.lergeImageList.Images.SetKeyName(35, "Lich.png");
            this.lergeImageList.Images.SetKeyName(36, "Lifestealer.png");
            this.lergeImageList.Images.SetKeyName(37, "Lina.png");
            this.lergeImageList.Images.SetKeyName(38, "Lion.png");
            this.lergeImageList.Images.SetKeyName(39, "Lone Druid.png");
            this.lergeImageList.Images.SetKeyName(40, "Luna.png");
            this.lergeImageList.Images.SetKeyName(41, "Lycanthrope.png");
            this.lergeImageList.Images.SetKeyName(42, "Magnus.png");
            this.lergeImageList.Images.SetKeyName(43, "Meepo.png");
            this.lergeImageList.Images.SetKeyName(44, "Mirana.png");
            this.lergeImageList.Images.SetKeyName(45, "Morphling.png");
            this.lergeImageList.Images.SetKeyName(46, "Naga Siren.png");
            this.lergeImageList.Images.SetKeyName(47, "Nature\'sProphet.png");
            this.lergeImageList.Images.SetKeyName(48, "Necrolyte.png");
            this.lergeImageList.Images.SetKeyName(49, "NightStalker.png");
            this.lergeImageList.Images.SetKeyName(50, "Nyx Assassin.png");
            this.lergeImageList.Images.SetKeyName(51, "Ogre Magi_test2.png");
            this.lergeImageList.Images.SetKeyName(52, "Omniknight.png");
            this.lergeImageList.Images.SetKeyName(53, "Outworld Destroyer.png");
            this.lergeImageList.Images.SetKeyName(54, "Phantom Assassin.png");
            this.lergeImageList.Images.SetKeyName(55, "Phantom Lancer.png");
            this.lergeImageList.Images.SetKeyName(56, "Puck.png");
            this.lergeImageList.Images.SetKeyName(57, "Pudge.png");
            this.lergeImageList.Images.SetKeyName(58, "Pugna.png");
            this.lergeImageList.Images.SetKeyName(59, "QueenofPain.png");
            this.lergeImageList.Images.SetKeyName(60, "Razor.png");
            this.lergeImageList.Images.SetKeyName(61, "Riki.png");
            this.lergeImageList.Images.SetKeyName(62, "Rubick.png");
            this.lergeImageList.Images.SetKeyName(63, "SandKing.png");
            this.lergeImageList.Images.SetKeyName(64, "Shadow Demon.png");
            this.lergeImageList.Images.SetKeyName(65, "ShadowFiend.png");
            this.lergeImageList.Images.SetKeyName(66, "ShadowShaman.png");
            this.lergeImageList.Images.SetKeyName(67, "Silencer.png");
            this.lergeImageList.Images.SetKeyName(68, "SkeletonKing.png");
            this.lergeImageList.Images.SetKeyName(69, "Slardar.png");
            this.lergeImageList.Images.SetKeyName(70, "Sniper.png");
            this.lergeImageList.Images.SetKeyName(71, "Spectre.png");
            this.lergeImageList.Images.SetKeyName(72, "SpiritBreaker.png");
            this.lergeImageList.Images.SetKeyName(73, "StormSpirit.png");
            this.lergeImageList.Images.SetKeyName(74, "Sven.png");
            this.lergeImageList.Images.SetKeyName(75, "Templar Assassin.png");
            this.lergeImageList.Images.SetKeyName(76, "Tidehunter.png");
            this.lergeImageList.Images.SetKeyName(77, "Tinker.png");
            this.lergeImageList.Images.SetKeyName(78, "Tiny.png");
            this.lergeImageList.Images.SetKeyName(79, "Treant Protector.png");
            this.lergeImageList.Images.SetKeyName(80, "Undying.png");
            this.lergeImageList.Images.SetKeyName(81, "Ursa.png");
            this.lergeImageList.Images.SetKeyName(82, "VengefulSpirit.png");
            this.lergeImageList.Images.SetKeyName(83, "Venomancer.png");
            this.lergeImageList.Images.SetKeyName(84, "Viper.png");
            this.lergeImageList.Images.SetKeyName(85, "Visage.png");
            this.lergeImageList.Images.SetKeyName(86, "Warlock.png");
            this.lergeImageList.Images.SetKeyName(87, "Weaver.png");
            this.lergeImageList.Images.SetKeyName(88, "Windrunner.png");
            this.lergeImageList.Images.SetKeyName(89, "Wisp.png");
            this.lergeImageList.Images.SetKeyName(90, "WitchDoctor.png");
            this.lergeImageList.Images.SetKeyName(91, "Zeus.png");
            // 
            // smallImageList
            // 
            this.smallImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("smallImageList.ImageStream")));
            this.smallImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.smallImageList.Images.SetKeyName(0, "Alchemist.png");
            this.smallImageList.Images.SetKeyName(1, "AncientApparition.png");
            this.smallImageList.Images.SetKeyName(2, "AntiMage.png");
            this.smallImageList.Images.SetKeyName(3, "Axe.png");
            this.smallImageList.Images.SetKeyName(4, "Bane.png");
            this.smallImageList.Images.SetKeyName(5, "Batrider.png");
            this.smallImageList.Images.SetKeyName(6, "Beastmaster.png");
            this.smallImageList.Images.SetKeyName(7, "Bloodseeker.png");
            this.smallImageList.Images.SetKeyName(8, "BountyHunter.png");
            this.smallImageList.Images.SetKeyName(9, "Brewmaster.png");
            this.smallImageList.Images.SetKeyName(10, "Broodmother.png");
            this.smallImageList.Images.SetKeyName(11, "Centaur Warrunner.png");
            this.smallImageList.Images.SetKeyName(12, "Chen.png");
            this.smallImageList.Images.SetKeyName(13, "Clinkz.png");
            this.smallImageList.Images.SetKeyName(14, "Clockwerk.png");
            this.smallImageList.Images.SetKeyName(15, "CrystalMaiden.png");
            this.smallImageList.Images.SetKeyName(16, "DarkSeer.png");
            this.smallImageList.Images.SetKeyName(17, "Dazzle.png");
            this.smallImageList.Images.SetKeyName(18, "DeathProphet.png");
            this.smallImageList.Images.SetKeyName(19, "Disruptor.png");
            this.smallImageList.Images.SetKeyName(20, "DoomBringer.png");
            this.smallImageList.Images.SetKeyName(21, "DragonKnight.png");
            this.smallImageList.Images.SetKeyName(22, "DrowRanger.png");
            this.smallImageList.Images.SetKeyName(23, "Earthshaker.png");
            this.smallImageList.Images.SetKeyName(24, "Enchantress.png");
            this.smallImageList.Images.SetKeyName(25, "Enigma.png");
            this.smallImageList.Images.SetKeyName(26, "FacelessVoid.png");
            this.smallImageList.Images.SetKeyName(27, "Gyrocopter.png");
            this.smallImageList.Images.SetKeyName(28, "Huskar.png");
            this.smallImageList.Images.SetKeyName(29, "Invoker.png");
            this.smallImageList.Images.SetKeyName(30, "Jakiro.png");
            this.smallImageList.Images.SetKeyName(31, "Juggernaut.png");
            this.smallImageList.Images.SetKeyName(32, "Keeper of the Light.png");
            this.smallImageList.Images.SetKeyName(33, "Kunkka.png");
            this.smallImageList.Images.SetKeyName(34, "Leshrac.png");
            this.smallImageList.Images.SetKeyName(35, "Lich.png");
            this.smallImageList.Images.SetKeyName(36, "Lifestealer.png");
            this.smallImageList.Images.SetKeyName(37, "Lina.png");
            this.smallImageList.Images.SetKeyName(38, "Lion.png");
            this.smallImageList.Images.SetKeyName(39, "Lone Druid.png");
            this.smallImageList.Images.SetKeyName(40, "Luna.png");
            this.smallImageList.Images.SetKeyName(41, "Lycanthrope.png");
            this.smallImageList.Images.SetKeyName(42, "Magnus.png");
            this.smallImageList.Images.SetKeyName(43, "Meepo.png");
            this.smallImageList.Images.SetKeyName(44, "Mirana.png");
            this.smallImageList.Images.SetKeyName(45, "Morphling.png");
            this.smallImageList.Images.SetKeyName(46, "Naga Siren.png");
            this.smallImageList.Images.SetKeyName(47, "Nature\'sProphet.png");
            this.smallImageList.Images.SetKeyName(48, "Necrolyte.png");
            this.smallImageList.Images.SetKeyName(49, "NightStalker.png");
            this.smallImageList.Images.SetKeyName(50, "Nyx Assassin.png");
            this.smallImageList.Images.SetKeyName(51, "Ogre Magi_test2.png");
            this.smallImageList.Images.SetKeyName(52, "Omniknight.png");
            this.smallImageList.Images.SetKeyName(53, "Outworld Destroyer.png");
            this.smallImageList.Images.SetKeyName(54, "Phantom Assassin.png");
            this.smallImageList.Images.SetKeyName(55, "Phantom Lancer.png");
            this.smallImageList.Images.SetKeyName(56, "Puck.png");
            this.smallImageList.Images.SetKeyName(57, "Pudge.png");
            this.smallImageList.Images.SetKeyName(58, "Pugna.png");
            this.smallImageList.Images.SetKeyName(59, "QueenofPain.png");
            this.smallImageList.Images.SetKeyName(60, "Razor.png");
            this.smallImageList.Images.SetKeyName(61, "Riki.png");
            this.smallImageList.Images.SetKeyName(62, "Rubick.png");
            this.smallImageList.Images.SetKeyName(63, "SandKing.png");
            this.smallImageList.Images.SetKeyName(64, "Shadow Demon.png");
            this.smallImageList.Images.SetKeyName(65, "ShadowFiend.png");
            this.smallImageList.Images.SetKeyName(66, "ShadowShaman.png");
            this.smallImageList.Images.SetKeyName(67, "Silencer.png");
            this.smallImageList.Images.SetKeyName(68, "SkeletonKing.png");
            this.smallImageList.Images.SetKeyName(69, "Slardar.png");
            this.smallImageList.Images.SetKeyName(70, "Sniper.png");
            this.smallImageList.Images.SetKeyName(71, "Spectre.png");
            this.smallImageList.Images.SetKeyName(72, "SpiritBreaker.png");
            this.smallImageList.Images.SetKeyName(73, "StormSpirit.png");
            this.smallImageList.Images.SetKeyName(74, "Sven.png");
            this.smallImageList.Images.SetKeyName(75, "Templar Assassin.png");
            this.smallImageList.Images.SetKeyName(76, "Tidehunter.png");
            this.smallImageList.Images.SetKeyName(77, "Tinker.png");
            this.smallImageList.Images.SetKeyName(78, "Tiny.png");
            this.smallImageList.Images.SetKeyName(79, "Treant Protector.png");
            this.smallImageList.Images.SetKeyName(80, "Undying.png");
            this.smallImageList.Images.SetKeyName(81, "Ursa.png");
            this.smallImageList.Images.SetKeyName(82, "VengefulSpirit.png");
            this.smallImageList.Images.SetKeyName(83, "Venomancer.png");
            this.smallImageList.Images.SetKeyName(84, "Viper.png");
            this.smallImageList.Images.SetKeyName(85, "Visage.png");
            this.smallImageList.Images.SetKeyName(86, "Warlock.png");
            this.smallImageList.Images.SetKeyName(87, "Weaver.png");
            this.smallImageList.Images.SetKeyName(88, "Windrunner.png");
            this.smallImageList.Images.SetKeyName(89, "Wisp.png");
            this.smallImageList.Images.SetKeyName(90, "WitchDoctor.png");
            this.smallImageList.Images.SetKeyName(91, "Zeus.png");
            // 
            // heroComboBox
            // 
            this.heroComboBox.DisplayMember = "Name";
            this.heroComboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.heroComboBox.FormattingEnabled = true;
            this.heroComboBox.Location = new System.Drawing.Point(0, 0);
            this.heroComboBox.Name = "heroComboBox";
            this.heroComboBox.Size = new System.Drawing.Size(454, 20);
            this.heroComboBox.TabIndex = 1;
            this.heroComboBox.ValueMember = "Name";
            this.heroComboBox.SelectedIndexChanged += new System.EventHandler(this.charaComboBox_SelectedIndexChanged);
            // 
            // heroChoiceContextMenuStrip
            // 
            this.heroChoiceContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem});
            this.heroChoiceContextMenuStrip.Name = "heroChoiceContextMenuStrip";
            this.heroChoiceContextMenuStrip.Size = new System.Drawing.Size(105, 26);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smallIconToolStripMenuItem,
            this.largeIconToolStripMenuItem,
            this.detailToolStripMenuItem,
            this.listToolStripMenuItem1});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.viewToolStripMenuItem.Text = "View";
            this.viewToolStripMenuItem.DropDownOpening += new System.EventHandler(this.viewToolStripMenuItem_DropDownOpening);
            // 
            // smallIconToolStripMenuItem
            // 
            this.smallIconToolStripMenuItem.Name = "smallIconToolStripMenuItem";
            this.smallIconToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.smallIconToolStripMenuItem.Text = "smallIcon";
            this.smallIconToolStripMenuItem.DropDownOpening += new System.EventHandler(this.smallIconToolStripMenuItem_DropDownOpening);
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
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.heroComboBox);
            this.splitContainer1.Panel1.Margin = new System.Windows.Forms.Padding(3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.heroListView);
            this.splitContainer1.Size = new System.Drawing.Size(454, 420);
            this.splitContainer1.SplitterDistance = 140;
            this.splitContainer1.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.supportCheckBox);
            this.groupBox2.Controls.Add(this.junglerCheckBox);
            this.groupBox2.Controls.Add(this.disablerCheckBox);
            this.groupBox2.Controls.Add(this.gankerCheckBox);
            this.groupBox2.Controls.Add(this.initiatorCheckBox);
            this.groupBox2.Controls.Add(this.pusherCheckBox);
            this.groupBox2.Controls.Add(this.carryCheckBox);
            this.groupBox2.Location = new System.Drawing.Point(136, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(195, 110);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Role";
            // 
            // supportCheckBox
            // 
            this.supportCheckBox.AutoSize = true;
            this.supportCheckBox.Location = new System.Drawing.Point(6, 84);
            this.supportCheckBox.Name = "supportCheckBox";
            this.supportCheckBox.Size = new System.Drawing.Size(63, 16);
            this.supportCheckBox.TabIndex = 6;
            this.supportCheckBox.Text = "Support";
            this.supportCheckBox.UseVisualStyleBackColor = true;
            this.supportCheckBox.CheckedChanged += new System.EventHandler(this.filterCheckBox_CheckedChanged);
            // 
            // junglerCheckBox
            // 
            this.junglerCheckBox.AutoSize = true;
            this.junglerCheckBox.Location = new System.Drawing.Point(114, 62);
            this.junglerCheckBox.Name = "junglerCheckBox";
            this.junglerCheckBox.Size = new System.Drawing.Size(62, 16);
            this.junglerCheckBox.TabIndex = 5;
            this.junglerCheckBox.Text = "Jungler";
            this.junglerCheckBox.UseVisualStyleBackColor = true;
            this.junglerCheckBox.CheckedChanged += new System.EventHandler(this.filterCheckBox_CheckedChanged);
            // 
            // disablerCheckBox
            // 
            this.disablerCheckBox.AutoSize = true;
            this.disablerCheckBox.Location = new System.Drawing.Point(114, 40);
            this.disablerCheckBox.Name = "disablerCheckBox";
            this.disablerCheckBox.Size = new System.Drawing.Size(66, 16);
            this.disablerCheckBox.TabIndex = 4;
            this.disablerCheckBox.Text = "Disabler";
            this.disablerCheckBox.UseVisualStyleBackColor = true;
            this.disablerCheckBox.CheckedChanged += new System.EventHandler(this.filterCheckBox_CheckedChanged);
            // 
            // gankerCheckBox
            // 
            this.gankerCheckBox.AutoSize = true;
            this.gankerCheckBox.Location = new System.Drawing.Point(114, 18);
            this.gankerCheckBox.Name = "gankerCheckBox";
            this.gankerCheckBox.Size = new System.Drawing.Size(60, 16);
            this.gankerCheckBox.TabIndex = 3;
            this.gankerCheckBox.Text = "Ganker";
            this.gankerCheckBox.UseVisualStyleBackColor = true;
            this.gankerCheckBox.CheckedChanged += new System.EventHandler(this.filterCheckBox_CheckedChanged);
            // 
            // initiatorCheckBox
            // 
            this.initiatorCheckBox.AutoSize = true;
            this.initiatorCheckBox.Location = new System.Drawing.Point(6, 62);
            this.initiatorCheckBox.Name = "initiatorCheckBox";
            this.initiatorCheckBox.Size = new System.Drawing.Size(63, 16);
            this.initiatorCheckBox.TabIndex = 2;
            this.initiatorCheckBox.Text = "Initiator";
            this.initiatorCheckBox.UseVisualStyleBackColor = true;
            this.initiatorCheckBox.CheckedChanged += new System.EventHandler(this.filterCheckBox_CheckedChanged);
            // 
            // pusherCheckBox
            // 
            this.pusherCheckBox.AutoSize = true;
            this.pusherCheckBox.Location = new System.Drawing.Point(6, 40);
            this.pusherCheckBox.Name = "pusherCheckBox";
            this.pusherCheckBox.Size = new System.Drawing.Size(59, 16);
            this.pusherCheckBox.TabIndex = 1;
            this.pusherCheckBox.Text = "Pusher";
            this.pusherCheckBox.UseVisualStyleBackColor = true;
            this.pusherCheckBox.CheckedChanged += new System.EventHandler(this.filterCheckBox_CheckedChanged);
            // 
            // carryCheckBox
            // 
            this.carryCheckBox.AutoSize = true;
            this.carryCheckBox.Location = new System.Drawing.Point(6, 18);
            this.carryCheckBox.Name = "carryCheckBox";
            this.carryCheckBox.Size = new System.Drawing.Size(52, 16);
            this.carryCheckBox.TabIndex = 0;
            this.carryCheckBox.Text = "Carry";
            this.carryCheckBox.UseVisualStyleBackColor = true;
            this.carryCheckBox.CheckedChanged += new System.EventHandler(this.filterCheckBox_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.intCheckBox);
            this.groupBox1.Controls.Add(this.agiCheckBox);
            this.groupBox1.Controls.Add(this.strCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(10, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(120, 110);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PrimaryAttribute";
            // 
            // intCheckBox
            // 
            this.intCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.intCheckBox.AutoSize = true;
            this.intCheckBox.Location = new System.Drawing.Point(6, 78);
            this.intCheckBox.Name = "intCheckBox";
            this.intCheckBox.Size = new System.Drawing.Size(82, 16);
            this.intCheckBox.TabIndex = 2;
            this.intCheckBox.Text = "Intelligence";
            this.intCheckBox.UseVisualStyleBackColor = true;
            this.intCheckBox.CheckedChanged += new System.EventHandler(this.filterCheckBox_CheckedChanged);
            // 
            // agiCheckBox
            // 
            this.agiCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.agiCheckBox.AutoSize = true;
            this.agiCheckBox.Location = new System.Drawing.Point(6, 48);
            this.agiCheckBox.Name = "agiCheckBox";
            this.agiCheckBox.Size = new System.Drawing.Size(57, 16);
            this.agiCheckBox.TabIndex = 1;
            this.agiCheckBox.Text = "Agility";
            this.agiCheckBox.UseVisualStyleBackColor = true;
            this.agiCheckBox.CheckedChanged += new System.EventHandler(this.filterCheckBox_CheckedChanged);
            // 
            // strCheckBox
            // 
            this.strCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.strCheckBox.AutoSize = true;
            this.strCheckBox.Location = new System.Drawing.Point(6, 18);
            this.strCheckBox.Name = "strCheckBox";
            this.strCheckBox.Size = new System.Drawing.Size(67, 16);
            this.strCheckBox.TabIndex = 0;
            this.strCheckBox.Text = "Strength";
            this.strCheckBox.UseVisualStyleBackColor = true;
            this.strCheckBox.CheckedChanged += new System.EventHandler(this.filterCheckBox_CheckedChanged);
            // 
            // heroDataBindingSource
            // 
            this.heroDataBindingSource.DataSource = typeof(Dota2.ItemEditor.Data.HeroData);
            // 
            // HeroChoiceControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ContextMenuStrip = this.heroChoiceContextMenuStrip;
            this.Controls.Add(this.splitContainer1);
            this.Name = "HeroChoiceControl";
            this.Size = new System.Drawing.Size(454, 420);
            this.heroChoiceContextMenuStrip.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heroDataBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView heroListView;
        private System.Windows.Forms.ComboBox heroComboBox;
        private System.Windows.Forms.BindingSource heroDataBindingSource;
        private System.Windows.Forms.ContextMenuStrip heroChoiceContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smallIconToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem largeIconToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listToolStripMenuItem1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ImageList lergeImageList;
        private System.Windows.Forms.ImageList smallImageList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox intCheckBox;
        private System.Windows.Forms.CheckBox agiCheckBox;
        private System.Windows.Forms.CheckBox strCheckBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox initiatorCheckBox;
        private System.Windows.Forms.CheckBox pusherCheckBox;
        private System.Windows.Forms.CheckBox carryCheckBox;
        private System.Windows.Forms.CheckBox supportCheckBox;
        private System.Windows.Forms.CheckBox junglerCheckBox;
        private System.Windows.Forms.CheckBox disablerCheckBox;
        private System.Windows.Forms.CheckBox gankerCheckBox;
    }
}
