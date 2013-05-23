using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using DOTA2.ItemEditor.ItemEditor.Data;

namespace Dota2.ItemEditor.Data {
    public class ItemData {


        public const string DRAG_FORMAT = "DOTA2_ItemData";

        public ItemData(string itemid, string name) {
            Name = name;
            ItemId = itemid;
        }

        public ItemData(string itemid, string name, string effect) {
            Name = name;
            Effect = effect;
            ItemId = itemid;
        }

        public string Name { get; set; }
        public string Effect { get; set; }
        public string ItemId { get; set; }
        public Image Image { get; set; }


        public static ItemData FromCSVValue(string[] values) {
            if (values.Length < 2) {
                return null;
            }
            if (values.Length == 2) {
                return new ItemData(values[0], values[1], "");
            }
            return new ItemData(values[0], values[1], values[2].Replace("\\r\\n" , "\r\n"));
            
        }

        public static ItemData FromItemBuildFileLine(string line) {
            //"item"   "item_id"　
            //上記形式　空白の数は不定　""で囲ってない場合知らん
            if (string.IsNullOrEmpty(line)) {
                return null;
            }
            line = line.Trim();
            string[] temp = line.Split('"');
            if (temp.Length > 4) {
                return DataResources.FindItemData(temp[3]);
            }
            return null;
        }

        public override string ToString() {
            return "Name:" + this.Name;
        }

        #region 演算子オーバーロード
        /// <summary>
        /// "=="のオーバーロード
        /// </summary>
        /// <param name="data1"></param>
        /// <param name="data2"></param>
        /// <returns></returns>
        public static bool operator ==(ItemData data1, ItemData data2) {
            //参照レベルで一緒
            if (object.ReferenceEquals(data1, data2)) {
                return true;
            }

            //==のオーバーロードなのでこうやって比較しないと無限ループ
            if (((object)data1 == null) || ((object)data2 == null)) {
                return false;
            }

            return (data1.ItemId == data2.ItemId && data1.Name == data2.Name);
        }

        public static bool operator !=(ItemData data1, ItemData data2) {
            //これも!=使うと無限ループする
            return !(data1 == data2);
        }

        public override bool Equals(object obj) {
            if (obj as ItemData != null) {
                return this == (obj as ItemData);
            }
            return base.Equals(obj);
        }

        public override int GetHashCode() {
            return base.GetHashCode();
        }
        #endregion

    }
}
