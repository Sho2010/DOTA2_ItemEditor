using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Drawing;
using System.Diagnostics;
using DOTA2.ItemEditor.ItemEditor.Data;


namespace Dota2.ItemEditor.Data{

    [Flags]
    public enum HeroRole{
        Carry,
        Ganker,
        Pusher,
        Initiator,
        Support,
        Disabler,
        Jungler
    }

    public enum PrimaryAttribute:int {
        Str = 0,
        Agi = 1,
        Int = 2
    }

    public class HeroData {

        public HeroData(string name) {
            Name = name;
        }

        public HeroRole Role { get; set; }
        public string Name { get; set; }
        public string BuildFileHeroName{ get; set; }

        public Image Image { get; set; }
        public PrimaryAttribute Attribute { get; set; }

        private ItemBuildData itemBuildData ;
        public ItemBuildData ItemBuildData { 
            get{
                if(itemBuildData == null){
                    itemBuildData = ItemBuildData.ReadHeroBuild(BuildFileHeroName);
                }
                return itemBuildData;
            }
        }

        internal static HeroData fromCSVValue(string[] fields) {
            //TODO check
            if (fields.Length < 3) {
                return null;
            }

            HeroData hero = new HeroData(fields[0]);

            try {
                hero.BuildFileHeroName = fields[1];
                hero.Attribute = (PrimaryAttribute)int.Parse(fields[2]);
            }
            catch {
                Console.WriteLine("hero value warn:" + fields);
            }

            //Debug.WriteLine(hero.Name);
            //Debug.WriteLine(hero.Attribute);

            return hero;
        }

        public string DefaultBuildFileName {
            get {
                return "default_" + BuildFileHeroName;
            }
        }


        public ItemBuildData RestoreDefaultItemBuild() {
            ItemBuildData defaultData = ItemBuildData.ReadBuildFile(DataResources.DEFAULT_BUILD_FILES_DIR + DefaultBuildFileName);
            this.itemBuildData = defaultData;
            return this.ItemBuildData;
        }
    }
}
