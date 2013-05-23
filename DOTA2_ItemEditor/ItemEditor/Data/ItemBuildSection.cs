using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dota2.ItemEditor.Data;

namespace DOTA2.ItemEditor.ItemEditor.Data {
    public class ItemBuildSection {

        private const string BLANK = "\t\t";
        private const string ITEM = "item";

        private const string RESOURCE_STRING01 = @"#DOTA_Item_Build_Starting_Items";
        private const string RESOURCE_STRING01_VALUE = "StartingItems";
        private const string RESOURCE_STRING02 = @"#DOTA_Item_Build_Early_Game";
        private const string RESOURCE_STRING02_VALUE = "Early";
        private const string RESOURCE_STRING03 = @"#DOTA_Item_Build_Core_Items";
        private const string RESOURCE_STRING03_VALUE = "Core";
        private const string RESOURCE_STRING04 = @"#DOTA_Item_Build_Luxury";
        private const string RESOURCE_STRING04_VALUE = "Luxury";

        public ItemBuildSection() {
            Items = new List<ItemData>();
        }

        private string sectionLabel;

        public string SectionLabel {
            get { return sectionLabel; }
            set {
                switch (value) {
                    case RESOURCE_STRING01:
                        sectionLabel = RESOURCE_STRING01_VALUE;
                        return;
                    case RESOURCE_STRING02:
                        sectionLabel = RESOURCE_STRING02_VALUE;
                        return;
                    case RESOURCE_STRING03:
                        sectionLabel = RESOURCE_STRING03_VALUE;
                        return;
                    case RESOURCE_STRING04:
                        sectionLabel = RESOURCE_STRING04_VALUE;
                        return;
                    default:
                        sectionLabel = value;
                        return;
                };
            }
        }
        
        public List<ItemData> Items { get; set; }

        public string ToSectionString(bool indent) {
            StringBuilder sb = new StringBuilder();
            string tab = indent ? "\t\t" : "";

            sb.AppendLine(tab + "\"" + writeNameSectionString() + "\"");
            sb.AppendLine(tab + "{");
            foreach (ItemData item in Items) {
                //\tが先頭についてるのはどちらにしろここはインデントする
                sb.AppendLine(string.Format(tab + "\t\"{0}\"\t\t\"{1}\"", ITEM, item.ItemId));
            }
            sb.AppendLine(tab + "}");

            return sb.ToString();
        }

        /**
         * こんな感じの形式
         * #DOTA_HOGE
         * {
         *      "item"  "item_tango"
         * }
         */

        private string writeNameSectionString() {
            //リソース対応文字列の場合　リソース文字列で書き込む
            switch (SectionLabel) {
                case RESOURCE_STRING01_VALUE:
                    return RESOURCE_STRING01;
                case RESOURCE_STRING02_VALUE:
                    return RESOURCE_STRING02;
                case RESOURCE_STRING03_VALUE:
                    return RESOURCE_STRING03;
                case RESOURCE_STRING04_VALUE:
                    return RESOURCE_STRING04;
                default:
                    return SectionLabel;
            }
        }

        public static string GetDefaultString(int index){
            switch(index){
                case 0:
                    return RESOURCE_STRING01_VALUE;
                case 1:
                    return RESOURCE_STRING02_VALUE;
                case 2:
                    return RESOURCE_STRING03_VALUE;
                case 3:
                    return RESOURCE_STRING04_VALUE;
                default:
                    return "default";
            }
        }
    }
}
