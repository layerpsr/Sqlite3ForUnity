namespace Sqlite3
{
    using System;
    using System.Collections.Generic;

    public static class MappingMgr
    {
        static Dictionary<Type, TableMapping> _mapping;
        static MappingMgr()
        {
            _mapping = new Dictionary<Type, TableMapping>()
            {
                { typeof(ShopSectionData), new Sqlite3.Gen.ShopSectionDataMappingWarp() },
{ typeof(SignData), new Sqlite3.Gen.SignDataMappingWarp() },
{ typeof(SignEntity), new Sqlite3.Gen.SignEntityMappingWarp() },
{ typeof(DialogData), new Sqlite3.Gen.DialogDataMappingWarp() },
{ typeof(NpcDialogData), new Sqlite3.Gen.NpcDialogDataMappingWarp() },
{ typeof(HealthEntity), new Sqlite3.Gen.HealthEntityMappingWarp() },
{ typeof(LogEntity), new Sqlite3.Gen.LogEntityMappingWarp() },
{ typeof(EquipData), new Sqlite3.Gen.EquipDataMappingWarp() },
{ typeof(ItemData), new Sqlite3.Gen.ItemDataMappingWarp() },
{ typeof(TaskData), new Sqlite3.Gen.TaskDataMappingWarp() },
{ typeof(EventData), new Sqlite3.Gen.EventDataMappingWarp() },
{ typeof(TaskSectionData), new Sqlite3.Gen.TaskSectionDataMappingWarp() },
{ typeof(NpcData), new Sqlite3.Gen.NpcDataMappingWarp() },
{ typeof(HeroData), new Sqlite3.Gen.HeroDataMappingWarp() },
{ typeof(SkillData), new Sqlite3.Gen.SkillDataMappingWarp() },
{ typeof(SkillCompundData), new Sqlite3.Gen.SkillCompundDataMappingWarp() },
{ typeof(SkillCompoundQualityData), new Sqlite3.Gen.SkillCompoundQualityDataMappingWarp() },
{ typeof(ItemUseData), new Sqlite3.Gen.ItemUseDataMappingWarp() },
{ typeof(UserInfo), new Sqlite3.Gen.UserInfoMappingWarp() },
{ typeof(GroceryShopData), new Sqlite3.Gen.GroceryShopDataMappingWarp() },
{ typeof(RealworldHeroData), new Sqlite3.Gen.RealworldHeroDataMappingWarp() },
{ typeof(RealworldHeroActiveSkillData), new Sqlite3.Gen.RealworldHeroActiveSkillDataMappingWarp() },
{ typeof(RealworldHeroSummonData), new Sqlite3.Gen.RealworldHeroSummonDataMappingWarp() },
{ typeof(RealworldHeroUpgradeStarData), new Sqlite3.Gen.RealworldHeroUpgradeStarDataMappingWarp() },
{ typeof(RealworldRelateB2Data), new Sqlite3.Gen.RealworldRelateB2DataMappingWarp() },
{ typeof(RealworldUnionData), new Sqlite3.Gen.RealworldUnionDataMappingWarp() },
{ typeof(TaskRealworldDailyData), new Sqlite3.Gen.TaskRealworldDailyDataMappingWarp() },
{ typeof(ForbiddenData), new Sqlite3.Gen.ForbiddenDataMappingWarp() },
{ typeof(RealworldAccidentData), new Sqlite3.Gen.RealworldAccidentDataMappingWarp() },
{ typeof(RealworldUserLevelupData), new Sqlite3.Gen.RealworldUserLevelupDataMappingWarp() },
{ typeof(RealworldEquipmentQualityCompoundData), new Sqlite3.Gen.RealworldEquipmentQualityCompoundDataMappingWarp() },
{ typeof(RealworldEquipmentExchangeData), new Sqlite3.Gen.RealworldEquipmentExchangeDataMappingWarp() },
{ typeof(RealworldEventData), new Sqlite3.Gen.RealworldEventDataMappingWarp() },
{ typeof(RealworldItemDropData), new Sqlite3.Gen.RealworldItemDropDataMappingWarp() },
{ typeof(LevelData), new Sqlite3.Gen.LevelDataMappingWarp() },
{ typeof(LevelReachData), new Sqlite3.Gen.LevelReachDataMappingWarp() },
{ typeof(MeltShopData), new Sqlite3.Gen.MeltShopDataMappingWarp() },
{ typeof(ShopData), new Sqlite3.Gen.ShopDataMappingWarp() },
{ typeof(BattleData), new Sqlite3.Gen.BattleDataMappingWarp() },
{ typeof(RealworldStoryData), new Sqlite3.Gen.RealworldStoryDataMappingWarp() },
{ typeof(MonsterLevelData), new Sqlite3.Gen.MonsterLevelDataMappingWarp() },
{ typeof(JournalData), new Sqlite3.Gen.JournalDataMappingWarp() },
{ typeof(EquipEntity), new Sqlite3.Gen.EquipEntityMappingWarp() },
{ typeof(ItemEntity), new Sqlite3.Gen.ItemEntityMappingWarp() },
{ typeof(TaskEntity), new Sqlite3.Gen.TaskEntityMappingWarp() },
{ typeof(EventEntity), new Sqlite3.Gen.EventEntityMappingWarp() },
{ typeof(TaskSectionEntity), new Sqlite3.Gen.TaskSectionEntityMappingWarp() },
{ typeof(NpcEntity), new Sqlite3.Gen.NpcEntityMappingWarp() },
{ typeof(HeroEntity), new Sqlite3.Gen.HeroEntityMappingWarp() },
{ typeof(RealworldHeroEntity), new Sqlite3.Gen.RealworldHeroEntityMappingWarp() },
{ typeof(SkillCompundEntity), new Sqlite3.Gen.SkillCompundEntityMappingWarp() },
{ typeof(PlanData1), new Sqlite3.Gen.PlanData1MappingWarp() },
{ typeof(RealworldItemEntity), new Sqlite3.Gen.RealworldItemEntityMappingWarp() },
{ typeof(DiaryEntity), new Sqlite3.Gen.DiaryEntityMappingWarp() }
            };
        }
        public static TableMapping GetMapping<T>()
        {
            return GetMapping(typeof(T));
        }
        public static TableMapping GetMapping(Type type)
        {
            if (_mapping.ContainsKey(type))
            {
                return _mapping[type];
            }
            UnityEngine.Debug.LogWarning(string.Format("Type '{0}' not gen mapping code", type.FullName));
            return null;
        }
    }
}