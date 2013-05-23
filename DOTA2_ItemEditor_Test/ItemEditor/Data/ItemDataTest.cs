using Dota2.ItemEditor.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Drawing;

namespace DOTA2_ItemEditor_Test
{
    
    
    /// <summary>
    ///ItemDataTest のテスト クラスです。すべての
    ///ItemDataTest 単体テストをここに含めます
    ///</summary>
    [TestClass()]
    public class ItemDataTest {


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
        ///ItemData コンストラクター のテスト
        ///</summary>
        [TestMethod()]
        public void ItemDataConstructorTest() {
            string itemid = string.Empty; // TODO: 適切な値に初期化してください
            string name = string.Empty; // TODO: 適切な値に初期化してください
            string effect = string.Empty; // TODO: 適切な値に初期化してください
            ItemData target = new ItemData(itemid, name, effect);
            Assert.Inconclusive("TODO: ターゲットを確認するためのコードを実装してください");
        }

        /// <summary>
        ///ItemData コンストラクター のテスト
        ///</summary>
        [TestMethod()]
        public void ItemDataConstructorTest1() {
            string itemid = string.Empty; // TODO: 適切な値に初期化してください
            string name = string.Empty; // TODO: 適切な値に初期化してください
            ItemData target = new ItemData(itemid, name);
            Assert.Inconclusive("TODO: ターゲットを確認するためのコードを実装してください");
        }

        /// <summary>
        ///Equals のテスト
        ///</summary>
        [TestMethod()]
        public void EqualsTest() {
            string itemid = string.Empty; // TODO: 適切な値に初期化してください
            string name = string.Empty; // TODO: 適切な値に初期化してください
            ItemData target = new ItemData(itemid, name); // TODO: 適切な値に初期化してください
            object obj = null; // TODO: 適切な値に初期化してください
            bool expected = false; // TODO: 適切な値に初期化してください
            bool actual;
            actual = target.Equals(obj);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("このテストメソッドの正確性を確認します。");
        }

        [TestMethod()]
        public void FromCSVValue配列の長さTest() {
            string[] values = { "item_arcane_ring" }; 
            ItemData expected = null;
            ItemData actual;
            actual = ItemData.FromCSVValue(values);

            Assert.AreEqual(expected, actual);
            
        }


        /// <summary>
        ///FromCSVValue のテスト
        ///</summary>
        [TestMethod()]
        public void FromCSVValueTest() {
            //"item_arcane_ring"
            //"Ring of Aquila"
            //"+9 Damage\\r\\n+3 All Stats\\r\\n+3 Agility\\r\\n+1 Armor\\r\\nこのアイテムを使用することで、オーラの効果をヒーロー限定にすることができる。(トグル式*再使用で全味方ユニット)\\r\\nオーラ 範囲900\\r\\n+0.65 Mana Regeneration\\r\\n+2 armor (Assault CuirassやVladmir's Offeringの効果とは重複しない)"

            //Assert.AreEqual(

            string[] values = null; // TODO: 適切な値に初期化してください
            ItemData expected = null; // TODO: 適切な値に初期化してください
            ItemData actual;
            actual = ItemData.FromCSVValue(values);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("このテストメソッドの正確性を確認します。");
        }


        /// <summary>
        ///FromItemBuildFileLine のテスト
        ///</summary>
        [TestMethod()]
        public void FromItemBuildFileLineTest() {
            string line = string.Empty; // TODO: 適切な値に初期化してください
            ItemData expected = null; // TODO: 適切な値に初期化してください
            ItemData actual;
            actual = ItemData.FromItemBuildFileLine(line);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("このテストメソッドの正確性を確認します。");
        }


        /// <summary>
        ///ToString のテスト
        ///</summary>
        [TestMethod()]
        public void ToStringTest() {
            string itemid = string.Empty; // TODO: 適切な値に初期化してください
            string name = string.Empty; // TODO: 適切な値に初期化してください
            ItemData target = new ItemData(itemid, name); // TODO: 適切な値に初期化してください
            string expected = string.Empty; // TODO: 適切な値に初期化してください
            string actual;
            actual = target.ToString();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("このテストメソッドの正確性を確認します。");
        }

        /// <summary>
        ///op_Equality のテスト
        ///</summary>
        [TestMethod()]
        public void op_EqualityTest() {
            ItemData data1 = null; // TODO: 適切な値に初期化してください
            ItemData data2 = null; // TODO: 適切な値に初期化してください
            bool expected = false; // TODO: 適切な値に初期化してください
            bool actual;
            actual = (data1 == data2);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("このテストメソッドの正確性を確認します。");
        }

        /// <summary>
        ///op_Inequality のテスト
        ///</summary>
        [TestMethod()]
        public void op_InequalityTest() {
            ItemData data1 = null; // TODO: 適切な値に初期化してください
            ItemData data2 = null; // TODO: 適切な値に初期化してください
            bool expected = false; // TODO: 適切な値に初期化してください
            bool actual;
            actual = (data1 != data2);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("このテストメソッドの正確性を確認します。");
        }

        /// <summary>
        ///Effect のテスト
        ///</summary>
        [TestMethod()]
        public void EffectTest() {
            string itemid = string.Empty; // TODO: 適切な値に初期化してください
            string name = string.Empty; // TODO: 適切な値に初期化してください
            ItemData target = new ItemData(itemid, name); // TODO: 適切な値に初期化してください
            string expected = string.Empty; // TODO: 適切な値に初期化してください
            string actual;
            target.Effect = expected;
            actual = target.Effect;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("このテストメソッドの正確性を確認します。");
        }

        /// <summary>
        ///Image のテスト
        ///</summary>
        [TestMethod()]
        public void ImageTest() {
            string itemid = string.Empty; // TODO: 適切な値に初期化してください
            string name = string.Empty; // TODO: 適切な値に初期化してください
            ItemData target = new ItemData(itemid, name); // TODO: 適切な値に初期化してください
            Image expected = null; // TODO: 適切な値に初期化してください
            Image actual;
            target.Image = expected;
            actual = target.Image;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("このテストメソッドの正確性を確認します。");
        }

        /// <summary>
        ///ItemId のテスト
        ///</summary>
        [TestMethod()]
        public void ItemIdTest() {
            string itemid = string.Empty; // TODO: 適切な値に初期化してください
            string name = string.Empty; // TODO: 適切な値に初期化してください
            ItemData target = new ItemData(itemid, name); // TODO: 適切な値に初期化してください
            string expected = string.Empty; // TODO: 適切な値に初期化してください
            string actual;
            target.ItemId = expected;
            actual = target.ItemId;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("このテストメソッドの正確性を確認します。");
        }

        /// <summary>
        ///Name のテスト
        ///</summary>
        [TestMethod()]
        public void NameTest() {
            string itemid = string.Empty; // TODO: 適切な値に初期化してください
            string name = string.Empty; // TODO: 適切な値に初期化してください
            ItemData target = new ItemData(itemid, name); // TODO: 適切な値に初期化してください
            string expected = string.Empty; // TODO: 適切な値に初期化してください
            string actual;
            target.Name = expected;
            actual = target.Name;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("このテストメソッドの正確性を確認します。");
        }
    }
}
