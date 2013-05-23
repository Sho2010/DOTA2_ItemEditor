using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dota2.ItemEditor.Data;
using System.IO;
using System.Windows.Forms;

/* 例
 * "itembuilds/mirana.txt"
 * { 
 * 	"author"		"Valve"
 *	"hero"			"npc_dota_hero_alchemist"
 *	"Title"			"Recommended items for Alchemist"
 *
 *   "Items"
 *   {
 *     "#DOTA_Item_Build_Starting_Items"
 *     {
 *       "items"   "item_tango"
 *     }
 *     //==以下セクション省略 etc...
 *   }
 * }
 * 
 * クラス
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 */

namespace DOTA2.ItemEditor.ItemEditor.Data {
    public class ItemBuildData {
        /*コメント行はこれ*/
        public const string COMMENT = "//==";
        private const string HEADER = "itembuilds/axe.txt";

        public HeroData Hero { get; set; }
        public string BuildName { get; set; }

        /// <summary>
        /// "Items"の手前にある key value pair 
        /// 例：
        /// "author"		"Valve"
        /// "hero"			"npc_dota_hero_alchemist"
        /// "Title"			"Recommended items for Alchemist"
        /// </summary>
        public Dictionary<string , string> ItemsHeader{ get; set; }
        
        public string FileHeader { get; set; }
        public List<ItemBuildSection> Sections { get; set; }

        public ItemBuildData() {
            Sections = new List<ItemBuildSection>();
            ItemsHeader = new Dictionary<string, string>();
        }

        public string ToFileString() {
            StringBuilder sb = new StringBuilder();
            
            sb.AppendLine("\"" + HEADER + "\"");
            sb.AppendLine("{");
            sb.AppendLine(ToItemsHeaders(true));
            sb.AppendLine("\t\"Items\""); //ここは大文字
            sb.AppendLine("\t{");
            
            foreach (ItemBuildSection section in Sections) {
                sb.Append(section.ToSectionString(true));
            }

            sb.AppendLine("\t}");   //Items閉じ括弧
            sb.AppendLine("}");     //全体閉じ括弧
            return sb.ToString();
        }

        private string ToItemsHeaders(bool indent) {
            if (ItemsHeader == null) {
                return "";
            }

            string tab = indent ? "\t" : "";
            StringBuilder sb = new StringBuilder();
            foreach (string key in ItemsHeader.Keys) {
                sb.AppendLine(string.Format(tab + "\"{0}\"\t\t\"{1}\""  , key , ItemsHeader[key]));
            }
            return sb.ToString();
        }

        public bool WriteFile(string filePath) {
            try {
                File.WriteAllText(filePath, ToFileString());
                return true;
            }
            catch (Exception e){
                Console.WriteLine(e);
                MessageBox.Show("書き込み失敗。" , "エラー");
            }
            return false;
        }

        private enum ReadPhase {
            Header,         //ヘッダー読み込み
            HeaderAfter,    //ヘッダー終了後
            ItemsHeaderSection,   //"Items"部分の読み飛ばし
            SectionHeader,  //セクション読み込み
            SectionContent, //セクション読み込み
            SectionSearch,   //セクション終了時次にセクションが存在しているかチェック　セクションがなければファイナライズへ
            Finalize        //終了処理
        }


        //めんどいからある程度ファイルフォーマット決め打ち
        public static ItemBuildData ReadBuildFile(string filePath){
            ItemBuildData data = new ItemBuildData();
            
            try{
                ReadPhase phase = ReadPhase.Header;
                ItemBuildSection currentSection = null;

                foreach (string temp in File.ReadAllLines(filePath)) {
                    string line = temp.Trim();
                    if (line.StartsWith(COMMENT) || line == "") {
                        continue;   //コメント行
                    }

                    //Console.WriteLine(line);

                    switch (phase) {
                        case ReadPhase.Header:
                            data.FileHeader = line;
                            phase = ReadPhase.HeaderAfter;
                            break;
                        case ReadPhase.HeaderAfter:
                            if (line == "{") {
                                phase = ReadPhase.ItemsHeaderSection;
                            }
                            break;
                        case ReadPhase.ItemsHeaderSection:
                            if (line == "{") {
                                phase = ReadPhase.SectionHeader;
                            }
                            else if(line.ToLower() != "items"){
                                data.AddItemsHeader(line);
                            }
                            break;
                        case ReadPhase.SectionHeader:
                            if(line == "}"){
                                //アイテムセクションの終了
                                phase = ReadPhase.Finalize;
                                continue;
                            }

                            currentSection = new ItemBuildSection();
                            currentSection.SectionLabel = line.Replace("\"" , "");  //"外して渡す
                            phase = ReadPhase.SectionContent;
                            break;
                        case ReadPhase.SectionContent:
                            if (line == "{") {
                                continue;   //Section開始括弧　次
                            }

                            //セクション終了　データへ登録し次のヘッダ探しへ
                            if (line == "}") {
                                data.Sections.Add(currentSection);
                                phase = ReadPhase.SectionHeader;
                                continue;
                            }

                            ItemData item = ItemData.FromItemBuildFileLine(line);
                            if (item != null) {
                                currentSection.Items.Add(item);
                            }
                            break;
                        case ReadPhase.Finalize:
                            //特になんもしない
                            break;
                    }
                }
                return data;
            }
            catch {
                MessageBox.Show("読み込み失敗。", "エラー");
            }
            return null;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="build">${heroname}.txt</param>
        /// <returns></returns>
        internal static ItemBuildData ReadHeroBuild(string herofile) {
            //ex:default_alchemist.txt
            string filename = DataResources.BUILD_FILES_DIR  + "default_" + herofile;
            return ReadBuildFile(filename);
        }

        public void AddItemsHeader(string line) {
            //"author"      "Valve"
            //"hero"        "npc_dota_hero_alchemist"
            //"Title"       "Recommended items for Alchemist"
            //上記形式　空白の数は不定　""で囲ってない場合知らん
            if (string.IsNullOrEmpty(line)) {
                return;
            }
            line = line.Trim();
            string[] temp = line.Split('"');
            if (temp.Length > 4) {
                ItemsHeader.Add(temp[1], temp[3]);
            }
        }  
    }
}
