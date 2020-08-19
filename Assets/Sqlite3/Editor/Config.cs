namespace Sqlite3
{
    using Sqlite3.Attribute;
    using System.Collections.Generic;

    /// <summary>
    /// 配置Gen Code的数据类型
    /// </summary>
    public static class MappingConfig
    {
        [TableConfig]
        public static List<Config> custom1
        {
            get
            {
                var types = new[]
                {
                    //游戏商城(门派商店)
                    typeof(ShopSectionData),   
                    //签到信息
                    typeof(SignData),
                    typeof(SignEntity),
                    //对话内容ID
                    typeof(DialogData),
                    typeof(NpcDialogData),
                    //健康数据类型
                    typeof(HealthEntity),
                    //记账数据类型
                    typeof(LogEntity),
                };
                var model = new Config(null) { AllAutoCreateIns = true };
                var list = new List<Config>();
                foreach (var type in types)
                {
                    var c = model.Clone();
                    c.Type = type;
                    list.Add(c);
                }
                return list;
            }
        }
        [TableConfig]
        public static List<Config> custom2
        {
            get
            {
                var types = new[]
                {
                    typeof(EquipData),
                    typeof(ItemData),
                    typeof(TaskData),
                    typeof(EventData),
                    typeof(TaskSectionData),
                    typeof(NpcData),
                    typeof(HeroData),
                    typeof(SkillData),
                    typeof(SkillCompundData),
                    typeof(SkillCompoundQualityData),
                    typeof(ItemUseData),
                    typeof(UserInfo),
                    typeof(GroceryShopData),
                    typeof(RealworldHeroData),
                    typeof(RealworldHeroActiveSkillData),
                    typeof(RealworldHeroSummonData),
                    typeof(RealworldHeroUpgradeStarData),
                    typeof(RealworldRelateB2Data),
                    typeof(RealworldUnionData),
                    typeof(TaskRealworldDailyData),
                    typeof(ForbiddenData),
                    typeof(RealworldAccidentData),
                    typeof(RealworldUserLevelupData),
                    typeof(RealworldEquipmentQualityCompoundData),
                    typeof(RealworldEquipmentExchangeData),
                    typeof(RealworldEventData),
                    typeof(RealworldItemDropData),
                    typeof(LevelData),
                    typeof(LevelReachData),
                    typeof(MeltShopData),
                    typeof(ShopData),
                    typeof(BattleData),
                    typeof(RealworldStoryData),
                    typeof(MonsterLevelData),
                    typeof(JournalData),
                };

                var model = new Config(null) { PK = "id", AllAutoCreateIns = true };
                var list = new List<Config>();
                foreach (var type in types)
                {
                    var c = model.Clone();
                    c.Type = type;
                    list.Add(c);
                }
                return list;
            }
        }
        [TableConfig]
        public static List<Config> custom3
        {
            get
            {
                var types = new[]
                {
                    typeof(EquipEntity),
                    typeof(ItemEntity),
                    typeof(TaskEntity),
                    typeof(EventEntity),
                    typeof(TaskSectionEntity),
                    typeof(NpcEntity),
                    typeof(HeroEntity),
                    typeof(RealworldHeroEntity),
                    typeof(SkillCompundEntity),
                    //规化数据
                    typeof(PlanData1),
                    typeof(RealworldItemEntity),
                    typeof(DiaryEntity),
                };

                var model = new Config(null) { PK = "id", AutoInc = true, AllAutoCreateIns = true };
                var list = new List<Config>();
                foreach (var type in types)
                {
                    var c = model.Clone();
                    c.Type = type;
                    list.Add(c);
                }
                return list;
            }
        }
    }
}