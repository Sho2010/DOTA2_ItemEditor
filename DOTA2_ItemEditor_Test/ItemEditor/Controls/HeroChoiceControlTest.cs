using Dota2.ItemEditor.Controls;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;

namespace DOTA2_ItemEditor_Test
{
    
    
    /// <summary>
    ///HeroChoiceControlTest のテスト クラスです。すべての
    ///HeroChoiceControlTest 単体テストをここに含めます
    ///</summary>
    [TestClass()]
    public class HeroChoiceControlTest {


        private TestContext testContextInstance;

        /// <summary>
        ///現在のテストの実行についての情報および機能を
        ///提供するテスト コンテキストを取得または設定します。
        ///</summary>
        public TestContext TestContext {
            get {
                return testContextInstance;
            }
            set {
                testContextInstance = value;
            }
        }

        #region 追加のテスト属性
        // 
        //テストを作成するときに、次の追加属性を使用することができます:
        //
        //クラスの最初のテストを実行する前にコードを実行するには、ClassInitialize を使用
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //クラスのすべてのテストを実行した後にコードを実行するには、ClassCleanup を使用
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //各テストを実行する前にコードを実行するには、TestInitialize を使用
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //各テストを実行した後にコードを実行するには、TestCleanup を使用
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///viewToolStripMenuItem_DropDownOpening のテスト
        ///</summary>
        [TestMethod()]
        [DeploymentItem("DOTA2_ItemEditor.exe")]
        public void viewToolStripMenuItem_DropDownOpeningTest() {
            HeroChoiceControl_Accessor target = new HeroChoiceControl_Accessor(); // TODO: 適切な値に初期化してください
            object sender = null; // TODO: 適切な値に初期化してください
            EventArgs e = null; // TODO: 適切な値に初期化してください
            target.viewToolStripMenuItem_DropDownOpening(sender, e);
            Assert.Inconclusive("値を返さないメソッドは確認できません。");
        }

        /// <summary>
        ///smallIconToolStripMenuItem_DropDownOpening のテスト
        ///</summary>
        [TestMethod()]
        [DeploymentItem("DOTA2_ItemEditor.exe")]
        public void smallIconToolStripMenuItem_DropDownOpeningTest() {
            HeroChoiceControl_Accessor target = new HeroChoiceControl_Accessor(); // TODO: 適切な値に初期化してください
            object sender = null; // TODO: 適切な値に初期化してください
            EventArgs e = null; // TODO: 適切な値に初期化してください
            target.smallIconToolStripMenuItem_DropDownOpening(sender, e);
            Assert.Inconclusive("値を返さないメソッドは確認できません。");
        }

        /// <summary>
        ///smallIconToolStripMenuItem_Click のテスト
        ///</summary>
        [TestMethod()]
        [DeploymentItem("DOTA2_ItemEditor.exe")]
        public void smallIconToolStripMenuItem_ClickTest() {
            HeroChoiceControl_Accessor target = new HeroChoiceControl_Accessor(); // TODO: 適切な値に初期化してください
            object sender = null; // TODO: 適切な値に初期化してください
            EventArgs e = null; // TODO: 適切な値に初期化してください
            target.smallIconToolStripMenuItem_Click(sender, e);
            Assert.Inconclusive("値を返さないメソッドは確認できません。");
        }

        /// <summary>
        ///setHeroImageList のテスト
        ///</summary>
        [TestMethod()]
        public void setHeroImageListTest() {
            HeroChoiceControl target = new HeroChoiceControl(); // TODO: 適切な値に初期化してください
            ImageList heroImageList = null; // TODO: 適切な値に初期化してください
            target.setHeroImageList(heroImageList);
            Assert.Inconclusive("値を返さないメソッドは確認できません。");
        }

        /// <summary>
        ///listToolStripMenuItem1_Click のテスト
        ///</summary>
        [TestMethod()]
        [DeploymentItem("DOTA2_ItemEditor.exe")]
        public void listToolStripMenuItem1_ClickTest() {
            HeroChoiceControl_Accessor target = new HeroChoiceControl_Accessor(); // TODO: 適切な値に初期化してください
            object sender = null; // TODO: 適切な値に初期化してください
            EventArgs e = null; // TODO: 適切な値に初期化してください
            target.listToolStripMenuItem1_Click(sender, e);
            Assert.Inconclusive("値を返さないメソッドは確認できません。");
        }

        /// <summary>
        ///largeIconToolStripMenuItem_Click のテスト
        ///</summary>
        [TestMethod()]
        [DeploymentItem("DOTA2_ItemEditor.exe")]
        public void largeIconToolStripMenuItem_ClickTest() {
            HeroChoiceControl_Accessor target = new HeroChoiceControl_Accessor(); // TODO: 適切な値に初期化してください
            object sender = null; // TODO: 適切な値に初期化してください
            EventArgs e = null; // TODO: 適切な値に初期化してください
            target.largeIconToolStripMenuItem_Click(sender, e);
            Assert.Inconclusive("値を返さないメソッドは確認できません。");
        }

        /// <summary>
        ///filterCheckBox_CheckedChanged のテスト
        ///</summary>
        [TestMethod()]
        [DeploymentItem("DOTA2_ItemEditor.exe")]
        public void filterCheckBox_CheckedChangedTest() {
            HeroChoiceControl_Accessor target = new HeroChoiceControl_Accessor(); // TODO: 適切な値に初期化してください
            object sender = null; // TODO: 適切な値に初期化してください
            EventArgs e = null; // TODO: 適切な値に初期化してください
            target.filterCheckBox_CheckedChanged(sender, e);
            Assert.Inconclusive("値を返さないメソッドは確認できません。");
        }

        /// <summary>
        ///detailToolStripMenuItem_Click のテスト
        ///</summary>
        [TestMethod()]
        [DeploymentItem("DOTA2_ItemEditor.exe")]
        public void detailToolStripMenuItem_ClickTest() {
            HeroChoiceControl_Accessor target = new HeroChoiceControl_Accessor(); // TODO: 適切な値に初期化してください
            object sender = null; // TODO: 適切な値に初期化してください
            EventArgs e = null; // TODO: 適切な値に初期化してください
            target.detailToolStripMenuItem_Click(sender, e);
            Assert.Inconclusive("値を返さないメソッドは確認できません。");
        }

        /// <summary>
        ///charaListView_SelectedIndexChanged のテスト
        ///</summary>
        [TestMethod()]
        [DeploymentItem("DOTA2_ItemEditor.exe")]
        public void charaListView_SelectedIndexChangedTest() {
            HeroChoiceControl_Accessor target = new HeroChoiceControl_Accessor(); // TODO: 適切な値に初期化してください
            object sender = null; // TODO: 適切な値に初期化してください
            EventArgs e = null; // TODO: 適切な値に初期化してください
            target.charaListView_SelectedIndexChanged(sender, e);
            Assert.Inconclusive("値を返さないメソッドは確認できません。");
        }

        /// <summary>
        ///charaComboBox_SelectedIndexChanged のテスト
        ///</summary>
        [TestMethod()]
        [DeploymentItem("DOTA2_ItemEditor.exe")]
        public void charaComboBox_SelectedIndexChangedTest() {
            HeroChoiceControl_Accessor target = new HeroChoiceControl_Accessor(); // TODO: 適切な値に初期化してください
            object sender = null; // TODO: 適切な値に初期化してください
            EventArgs e = null; // TODO: 適切な値に初期化してください
            target.charaComboBox_SelectedIndexChanged(sender, e);
            Assert.Inconclusive("値を返さないメソッドは確認できません。");
        }

        /// <summary>
        ///InitializeComponent のテスト
        ///</summary>
        [TestMethod()]
        [DeploymentItem("DOTA2_ItemEditor.exe")]
        public void InitializeComponentTest() {
            HeroChoiceControl_Accessor target = new HeroChoiceControl_Accessor(); // TODO: 適切な値に初期化してください
            target.InitializeComponent();
            Assert.Inconclusive("値を返さないメソッドは確認できません。");
        }

        /// <summary>
        ///ExecFilter のテスト
        ///</summary>
        [TestMethod()]
        public void ExecFilterTest() {
            HeroChoiceControl target = new HeroChoiceControl(); // TODO: 適切な値に初期化してください
            target.ExecFilter();
            Assert.Inconclusive("値を返さないメソッドは確認できません。");
        }

        /// <summary>
        ///Dispose のテスト
        ///</summary>
        [TestMethod()]
        [DeploymentItem("DOTA2_ItemEditor.exe")]
        public void DisposeTest() {
            HeroChoiceControl_Accessor target = new HeroChoiceControl_Accessor(); // TODO: 適切な値に初期化してください
            bool disposing = false; // TODO: 適切な値に初期化してください
            target.Dispose(disposing);
            Assert.Inconclusive("値を返さないメソッドは確認できません。");
        }

        /// <summary>
        ///HeroChoiceControl コンストラクター のテスト
        ///</summary>
        [TestMethod()]
        public void HeroChoiceControlConstructorTest() {
            HeroChoiceControl target = new HeroChoiceControl();
            Assert.Inconclusive("TODO: ターゲットを確認するためのコードを実装してください");
        }
    }
}
