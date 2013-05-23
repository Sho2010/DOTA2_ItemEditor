using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dota2.ItemEditor.Data;
using System.IO;

namespace DOTA2.ItemEditor.ItemEditor.Data {
    class DataResources {

        public const string DEFAULT_DOTA2_PATH = @"C:\Program Files\Steam\steamapps\common\dota 2 beta\dota";
        
        //TODO:パスリソースから取る
        public const string ITEM_CSV_PATH = @"./Resources/item_effect.csv";
        public const string HERO_CSV_PATH = @"./Resources/hero.csv";
        public const string BUILD_FILES_DIR = @"./Resources/builds/";
        public const string DEFAULT_BUILD_FILES_DIR = @"./Resources/default/";

        private static Dictionary<string, ItemBuildData> buildMap;
        public static Dictionary<string, ItemBuildData> BuildMap{
            get {
                if (buildMap == null) {
                    loadBuildResource();
                }
                return buildMap;
            }
        }

        private static List<HeroData> heroList;
        public static List<HeroData> HeroDataList {
            get {
                if (heroList == null) {
                    loadHeroResource();
                }
                return heroList;
            }
        }

        private static List<ItemData> itemDataList;

        public static List<ItemData> ItemDataList {
            get {
                if (itemDataList == null) {
                    loadItemResource();
                }
                return itemDataList;
            }
        }

        public void init() {
            //めんどくさいから全部オンメモ
            loadHeroResource();
            loadItemResource();
            loadBuildResource();
        }

        private static void loadBuildResource() {
            try {
                buildMap = new Dictionary<string, ItemBuildData>();
                if (!Directory.Exists(BUILD_FILES_DIR)) {
                    //message
                    return;
                }

                foreach (string buildFile in Directory.GetFiles(BUILD_FILES_DIR)) {
                    ItemBuildData buildData = ItemBuildData.ReadBuildFile(buildFile);
                    string key = FileNameToHeroName(buildFile);
                    if(buildData != null && !buildMap.ContainsKey(key) ){
                        buildMap.Add(key, buildData);
                    }
                }
            }
            catch (Exception e) {
                Console.WriteLine(e);
                Console.Error.WriteLine("CSV parse error");
            }
        }

        private static void loadHeroResource() {
            try {
                heroList = new List<HeroData>();

                Microsoft.VisualBasic.FileIO.TextFieldParser parser = new Microsoft.VisualBasic.FileIO.TextFieldParser(
                    HERO_CSV_PATH,
                    System.Text.Encoding.GetEncoding(932));

                parser.SetDelimiters(new string[] { "," }); //,区切り
                parser.HasFieldsEnclosedInQuotes = true;    //" escape
                parser.TrimWhiteSpace = true;               //trim on

                while (!parser.EndOfData) {
                    //フィールドを読み込む
                    string[] fields = parser.ReadFields();
                    HeroData data = HeroData.fromCSVValue(fields);
                    if (data != null) {
                        heroList.Add(data);
                    }
                }
            }
            catch (Exception e) {
                Console.WriteLine(e);
                Console.Error.WriteLine("CSV parse error");
            }
        }

        private static void loadItemResource() {

            try {
                itemDataList = new List<ItemData>();

                Microsoft.VisualBasic.FileIO.TextFieldParser parser = new Microsoft.VisualBasic.FileIO.TextFieldParser(
                    ITEM_CSV_PATH,
                    System.Text.Encoding.GetEncoding(932));

                parser.SetDelimiters(new string[] { "," });
                parser.HasFieldsEnclosedInQuotes = true;    //" escape
                parser.TrimWhiteSpace = true;               //trim on

                while (!parser.EndOfData) {
                    //フィールドを読み込む
                    string[] fields = parser.ReadFields();
                    ItemData data = ItemData.FromCSVValue(fields);
                    if (data != null) {
                        itemDataList.Add(data);
                    }
                }
            }
            catch (Exception e){
                Console.WriteLine(e);
                Console.Error.WriteLine("CSV parse error");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="itemid"></param>
        /// <returns></returns>
        public static ItemData FindItemData(string itemid) {
            if (string.IsNullOrEmpty(itemid)) {
                return null;
            }
            itemid = itemid.Trim();

            ItemData result = DataResources.ItemDataList.Find(delegate(ItemData data) {
                return data.ItemId.ToLower() == itemid.ToLower();
            });
            return result;
        }


        /// <summary>
        /// buildファイル名からHero名を取得します。
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public static string FileNameToHeroName(string file) {
            if(string.IsNullOrEmpty(file)){
                return "";
            }

            //ex:"default_alchemist.txt"
            string[] temp = Path.GetFileNameWithoutExtension(file).Split('_');
            if (temp.Length >= 2) {
                return temp[1];
            }
            return "";
        }
    }
}
