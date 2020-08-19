namespace Sqlite3.Gen
{

    public class ShopSectionDataMappingWarp : Sqlite3.TableMapping
    {
        //Ctor
        public ShopSectionDataMappingWarp()
        {
            
            this.MappedType = typeof(ShopSectionData);
            this.TableName = "ShopSectionData";
            //Columns
            this.PK = null;
            this.Columns = new[]
            {
                new Column("id", typeof(System.Int32), "id", false, false, false, false, null, null, true),
new Column("level_limit", typeof(System.Int32), "level_limit", false, false, false, false, null, null, true),
new Column("section_type", typeof(System.Int32), "section_type", false, false, false, false, null, null, true),
new Column("item_types", typeof(System.Collections.Generic.List<System.Int32>), "item_types", false, false, false, false, null, null, true),
new Column("item_ids", typeof(System.Collections.Generic.List<System.Int32>), "item_ids", false, false, false, false, null, null, true),
new Column("item_num", typeof(System.Collections.Generic.List<System.Int32>), "item_num", false, false, false, false, null, null, true),
new Column("money_types", typeof(System.Int32), "money_types", false, false, false, false, null, null, true),
new Column("money_single_cost", typeof(System.Collections.Generic.List<System.Int32>), "money_single_cost", false, false, false, false, null, null, true),

            };

            this.GetByPrimaryKeySql = "SELECT * FROM \"ShopSectionData\" LIMIT 1";

        }
        //Column Ctor
        public class Column : Sqlite3.Column
        {
            public Column(string prop_name, System.Type prop_type,
                    string name,
                    bool pk, bool auto_inc, bool unique,
                    bool not_null, string def_value,
                    int? max_len,
                    bool auto_create_ins)
            {
                this.PropertyName = prop_name;
                this.ColumnType = prop_type;

                this.Name = name;
                this.IsPK = pk;
                this.IsAutoInc = auto_inc;
                this.IsUnique = unique;
                this.IsNotNull = not_null;
                this.DefaultValue = def_value;
                this.MaxLength = max_len;
                this.IsAutoCreateIns = auto_create_ins;
            }
            public override void SetValue(object obj, object val)
            {
                var _obj = (ShopSectionData)obj;
                val = val ?? AutoCreateIns();
                switch (this.PropertyName)
                {
                   case "id":
                        _obj.id=(System.Int32)val;
                        break;
                  case "level_limit":
                        _obj.level_limit=(System.Int32)val;
                        break;
                  case "section_type":
                        _obj.section_type=(System.Int32)val;
                        break;
                  case "item_types":
                        _obj.item_types=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "item_ids":
                        _obj.item_ids=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "item_num":
                        _obj.item_num=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "money_types":
                        _obj.money_types=(System.Int32)val;
                        break;
                  case "money_single_cost":
                        _obj.money_single_cost=(System.Collections.Generic.List<System.Int32>)val;
                        break;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            public override object GetValue(object obj)
            {
                var _obj = (ShopSectionData)obj;
                switch (this.PropertyName)
                {
                   case "id":
                        return _obj.id;
                  case "level_limit":
                        return _obj.level_limit;
                  case "section_type":
                        return _obj.section_type;
                  case "item_types":
                        return _obj.item_types;
                  case "item_ids":
                        return _obj.item_ids;
                  case "item_num":
                        return _obj.item_num;
                  case "money_types":
                        return _obj.money_types;
                  case "money_single_cost":
                        return _obj.money_single_cost;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            private object AutoCreateIns()
            {
                if(!this.IsAutoCreateIns)
                    return null;
                switch (this.PropertyName)
                {
                   case "item_types":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "item_ids":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "item_num":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "money_single_cost":
                        return new System.Collections.Generic.List<System.Int32>();

                    default:
                        return null;
                }
            }
        }
    }
    public class SignDataMappingWarp : Sqlite3.TableMapping
    {
        //Ctor
        public SignDataMappingWarp()
        {
            
            this.MappedType = typeof(SignData);
            this.TableName = "SignData";
            //Columns
            this.PK = null;
            this.Columns = new[]
            {
                new Column("id", typeof(System.Int32), "id", false, false, false, false, null, null, true),
new Column("day", typeof(System.Int32), "day", false, false, false, false, null, null, true),
new Column("sign_name", typeof(System.String), "sign_name", false, false, false, false, null, null, true),
new Column("icon", typeof(System.String), "icon", false, false, false, false, null, null, true),
new Column("item_types", typeof(System.Collections.Generic.List<System.Int32>), "item_types", false, false, false, false, null, null, true),
new Column("item_ids", typeof(System.Collections.Generic.List<System.Int32>), "item_ids", false, false, false, false, null, null, true),
new Column("num", typeof(System.Collections.Generic.List<System.Int32>), "num", false, false, false, false, null, null, true),

            };

            this.GetByPrimaryKeySql = "SELECT * FROM \"SignData\" LIMIT 1";

        }
        //Column Ctor
        public class Column : Sqlite3.Column
        {
            public Column(string prop_name, System.Type prop_type,
                    string name,
                    bool pk, bool auto_inc, bool unique,
                    bool not_null, string def_value,
                    int? max_len,
                    bool auto_create_ins)
            {
                this.PropertyName = prop_name;
                this.ColumnType = prop_type;

                this.Name = name;
                this.IsPK = pk;
                this.IsAutoInc = auto_inc;
                this.IsUnique = unique;
                this.IsNotNull = not_null;
                this.DefaultValue = def_value;
                this.MaxLength = max_len;
                this.IsAutoCreateIns = auto_create_ins;
            }
            public override void SetValue(object obj, object val)
            {
                var _obj = (SignData)obj;
                val = val ?? AutoCreateIns();
                switch (this.PropertyName)
                {
                   case "id":
                        _obj.id=(System.Int32)val;
                        break;
                  case "day":
                        _obj.day=(System.Int32)val;
                        break;
                  case "sign_name":
                        _obj.sign_name=(System.String)val;
                        break;
                  case "icon":
                        _obj.icon=(System.String)val;
                        break;
                  case "item_types":
                        _obj.item_types=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "item_ids":
                        _obj.item_ids=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "num":
                        _obj.num=(System.Collections.Generic.List<System.Int32>)val;
                        break;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            public override object GetValue(object obj)
            {
                var _obj = (SignData)obj;
                switch (this.PropertyName)
                {
                   case "id":
                        return _obj.id;
                  case "day":
                        return _obj.day;
                  case "sign_name":
                        return _obj.sign_name;
                  case "icon":
                        return _obj.icon;
                  case "item_types":
                        return _obj.item_types;
                  case "item_ids":
                        return _obj.item_ids;
                  case "num":
                        return _obj.num;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            private object AutoCreateIns()
            {
                if(!this.IsAutoCreateIns)
                    return null;
                switch (this.PropertyName)
                {
                   case "item_types":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "item_ids":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "num":
                        return new System.Collections.Generic.List<System.Int32>();

                    default:
                        return null;
                }
            }
        }
    }
    public class SignEntityMappingWarp : Sqlite3.TableMapping
    {
        //Ctor
        public SignEntityMappingWarp()
        {
            
            this.MappedType = typeof(SignEntity);
            this.TableName = "SignEntity";
            //Columns
            this.PK = null;
            this.Columns = new[]
            {
                new Column("sign_state", typeof(System.Boolean), "sign_state", false, false, false, false, null, null, true),
new Column("sign_week", typeof(System.String), "sign_week", false, false, false, false, null, null, true),
new Column("id", typeof(System.Int32), "id", false, false, false, false, null, null, true),
new Column("day", typeof(System.Int32), "day", false, false, false, false, null, null, true),
new Column("sign_name", typeof(System.String), "sign_name", false, false, false, false, null, null, true),
new Column("icon", typeof(System.String), "icon", false, false, false, false, null, null, true),
new Column("item_types", typeof(System.Collections.Generic.List<System.Int32>), "item_types", false, false, false, false, null, null, true),
new Column("item_ids", typeof(System.Collections.Generic.List<System.Int32>), "item_ids", false, false, false, false, null, null, true),
new Column("num", typeof(System.Collections.Generic.List<System.Int32>), "num", false, false, false, false, null, null, true),

            };

            this.GetByPrimaryKeySql = "SELECT * FROM \"SignEntity\" LIMIT 1";

        }
        //Column Ctor
        public class Column : Sqlite3.Column
        {
            public Column(string prop_name, System.Type prop_type,
                    string name,
                    bool pk, bool auto_inc, bool unique,
                    bool not_null, string def_value,
                    int? max_len,
                    bool auto_create_ins)
            {
                this.PropertyName = prop_name;
                this.ColumnType = prop_type;

                this.Name = name;
                this.IsPK = pk;
                this.IsAutoInc = auto_inc;
                this.IsUnique = unique;
                this.IsNotNull = not_null;
                this.DefaultValue = def_value;
                this.MaxLength = max_len;
                this.IsAutoCreateIns = auto_create_ins;
            }
            public override void SetValue(object obj, object val)
            {
                var _obj = (SignEntity)obj;
                val = val ?? AutoCreateIns();
                switch (this.PropertyName)
                {
                   case "sign_state":
                        _obj.sign_state=(System.Boolean)val;
                        break;
                  case "sign_week":
                        _obj.sign_week=(System.String)val;
                        break;
                  case "id":
                        _obj.id=(System.Int32)val;
                        break;
                  case "day":
                        _obj.day=(System.Int32)val;
                        break;
                  case "sign_name":
                        _obj.sign_name=(System.String)val;
                        break;
                  case "icon":
                        _obj.icon=(System.String)val;
                        break;
                  case "item_types":
                        _obj.item_types=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "item_ids":
                        _obj.item_ids=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "num":
                        _obj.num=(System.Collections.Generic.List<System.Int32>)val;
                        break;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            public override object GetValue(object obj)
            {
                var _obj = (SignEntity)obj;
                switch (this.PropertyName)
                {
                   case "sign_state":
                        return _obj.sign_state;
                  case "sign_week":
                        return _obj.sign_week;
                  case "id":
                        return _obj.id;
                  case "day":
                        return _obj.day;
                  case "sign_name":
                        return _obj.sign_name;
                  case "icon":
                        return _obj.icon;
                  case "item_types":
                        return _obj.item_types;
                  case "item_ids":
                        return _obj.item_ids;
                  case "num":
                        return _obj.num;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            private object AutoCreateIns()
            {
                if(!this.IsAutoCreateIns)
                    return null;
                switch (this.PropertyName)
                {
                   case "item_types":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "item_ids":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "num":
                        return new System.Collections.Generic.List<System.Int32>();

                    default:
                        return null;
                }
            }
        }
    }
    public class DialogDataMappingWarp : Sqlite3.TableMapping
    {
        //Ctor
        public DialogDataMappingWarp()
        {
            
            this.MappedType = typeof(DialogData);
            this.TableName = "DialogData";
            //Columns
            this.PK = null;
            this.Columns = new[]
            {
                new Column("id", typeof(System.Int32), "id", false, false, false, false, null, null, true),
new Column("content", typeof(System.String), "content", false, false, false, false, null, null, true),

            };

            this.GetByPrimaryKeySql = "SELECT * FROM \"DialogData\" LIMIT 1";

        }
        //Column Ctor
        public class Column : Sqlite3.Column
        {
            public Column(string prop_name, System.Type prop_type,
                    string name,
                    bool pk, bool auto_inc, bool unique,
                    bool not_null, string def_value,
                    int? max_len,
                    bool auto_create_ins)
            {
                this.PropertyName = prop_name;
                this.ColumnType = prop_type;

                this.Name = name;
                this.IsPK = pk;
                this.IsAutoInc = auto_inc;
                this.IsUnique = unique;
                this.IsNotNull = not_null;
                this.DefaultValue = def_value;
                this.MaxLength = max_len;
                this.IsAutoCreateIns = auto_create_ins;
            }
            public override void SetValue(object obj, object val)
            {
                var _obj = (DialogData)obj;
                val = val ?? AutoCreateIns();
                switch (this.PropertyName)
                {
                   case "id":
                        _obj.id=(System.Int32)val;
                        break;
                  case "content":
                        _obj.content=(System.String)val;
                        break;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            public override object GetValue(object obj)
            {
                var _obj = (DialogData)obj;
                switch (this.PropertyName)
                {
                   case "id":
                        return _obj.id;
                  case "content":
                        return _obj.content;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            private object AutoCreateIns()
            {
                if(!this.IsAutoCreateIns)
                    return null;
                switch (this.PropertyName)
                {
 
                    default:
                        return null;
                }
            }
        }
    }
    public class NpcDialogDataMappingWarp : Sqlite3.TableMapping
    {
        //Ctor
        public NpcDialogDataMappingWarp()
        {
            
            this.MappedType = typeof(NpcDialogData);
            this.TableName = "NpcDialogData";
            //Columns
            this.PK = null;
            this.Columns = new[]
            {
                new Column("id", typeof(System.Int32), "id", false, false, false, false, null, null, true),
new Column("npc", typeof(System.Int32), "npc", false, false, false, false, null, null, true),
new Column("dialogs", typeof(System.Collections.Generic.List<System.Int32>), "dialogs", false, false, false, false, null, null, true),

            };

            this.GetByPrimaryKeySql = "SELECT * FROM \"NpcDialogData\" LIMIT 1";

        }
        //Column Ctor
        public class Column : Sqlite3.Column
        {
            public Column(string prop_name, System.Type prop_type,
                    string name,
                    bool pk, bool auto_inc, bool unique,
                    bool not_null, string def_value,
                    int? max_len,
                    bool auto_create_ins)
            {
                this.PropertyName = prop_name;
                this.ColumnType = prop_type;

                this.Name = name;
                this.IsPK = pk;
                this.IsAutoInc = auto_inc;
                this.IsUnique = unique;
                this.IsNotNull = not_null;
                this.DefaultValue = def_value;
                this.MaxLength = max_len;
                this.IsAutoCreateIns = auto_create_ins;
            }
            public override void SetValue(object obj, object val)
            {
                var _obj = (NpcDialogData)obj;
                val = val ?? AutoCreateIns();
                switch (this.PropertyName)
                {
                   case "id":
                        _obj.id=(System.Int32)val;
                        break;
                  case "npc":
                        _obj.npc=(System.Int32)val;
                        break;
                  case "dialogs":
                        _obj.dialogs=(System.Collections.Generic.List<System.Int32>)val;
                        break;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            public override object GetValue(object obj)
            {
                var _obj = (NpcDialogData)obj;
                switch (this.PropertyName)
                {
                   case "id":
                        return _obj.id;
                  case "npc":
                        return _obj.npc;
                  case "dialogs":
                        return _obj.dialogs;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            private object AutoCreateIns()
            {
                if(!this.IsAutoCreateIns)
                    return null;
                switch (this.PropertyName)
                {
                   case "dialogs":
                        return new System.Collections.Generic.List<System.Int32>();

                    default:
                        return null;
                }
            }
        }
    }
    public class HealthEntityMappingWarp : Sqlite3.TableMapping
    {
        //Ctor
        public HealthEntityMappingWarp()
        {
            
            this.MappedType = typeof(HealthEntity);
            this.TableName = "HealthEntity";
            //Columns
            this.PK = null;
            this.Columns = new[]
            {
                new Column("id", typeof(System.Int64), "id", false, false, false, false, null, null, true),
new Column("date", typeof(System.String), "date", false, false, false, false, null, null, true),
new Column("sleep", typeof(System.Single), "sleep", false, false, false, false, null, null, true),
new Column("walk", typeof(System.Single), "walk", false, false, false, false, null, null, true),
new Column("distance", typeof(System.Single), "distance", false, false, false, false, null, null, true),

            };

            this.GetByPrimaryKeySql = "SELECT * FROM \"HealthEntity\" LIMIT 1";

        }
        //Column Ctor
        public class Column : Sqlite3.Column
        {
            public Column(string prop_name, System.Type prop_type,
                    string name,
                    bool pk, bool auto_inc, bool unique,
                    bool not_null, string def_value,
                    int? max_len,
                    bool auto_create_ins)
            {
                this.PropertyName = prop_name;
                this.ColumnType = prop_type;

                this.Name = name;
                this.IsPK = pk;
                this.IsAutoInc = auto_inc;
                this.IsUnique = unique;
                this.IsNotNull = not_null;
                this.DefaultValue = def_value;
                this.MaxLength = max_len;
                this.IsAutoCreateIns = auto_create_ins;
            }
            public override void SetValue(object obj, object val)
            {
                var _obj = (HealthEntity)obj;
                val = val ?? AutoCreateIns();
                switch (this.PropertyName)
                {
                   case "id":
                        _obj.id=(System.Int64)val;
                        break;
                  case "date":
                        _obj.date=(System.String)val;
                        break;
                  case "sleep":
                        _obj.sleep=(System.Single)val;
                        break;
                  case "walk":
                        _obj.walk=(System.Single)val;
                        break;
                  case "distance":
                        _obj.distance=(System.Single)val;
                        break;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            public override object GetValue(object obj)
            {
                var _obj = (HealthEntity)obj;
                switch (this.PropertyName)
                {
                   case "id":
                        return _obj.id;
                  case "date":
                        return _obj.date;
                  case "sleep":
                        return _obj.sleep;
                  case "walk":
                        return _obj.walk;
                  case "distance":
                        return _obj.distance;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            private object AutoCreateIns()
            {
                if(!this.IsAutoCreateIns)
                    return null;
                switch (this.PropertyName)
                {
 
                    default:
                        return null;
                }
            }
        }
    }
    public class LogEntityMappingWarp : Sqlite3.TableMapping
    {
        //Ctor
        public LogEntityMappingWarp()
        {
            
            this.MappedType = typeof(LogEntity);
            this.TableName = "LogEntity";
            //Columns
            this.PK = null;
            this.Columns = new[]
            {
                new Column("id", typeof(System.Int64), "id", false, false, false, false, null, null, true),
new Column("date", typeof(System.String), "date", false, false, false, false, null, null, true),
new Column("dateDeatils", typeof(System.Int64), "dateDeatils", false, false, false, false, null, null, true),
new Column("type", typeof(System.Int32), "type", false, false, false, false, null, null, true),
new Column("sub_type", typeof(System.Int32), "sub_type", false, false, false, false, null, null, true),
new Column("money", typeof(System.Single), "money", false, false, false, false, null, null, true),
new Column("remarks", typeof(System.String), "remarks", false, false, false, false, null, null, true),

            };

            this.GetByPrimaryKeySql = "SELECT * FROM \"LogEntity\" LIMIT 1";

        }
        //Column Ctor
        public class Column : Sqlite3.Column
        {
            public Column(string prop_name, System.Type prop_type,
                    string name,
                    bool pk, bool auto_inc, bool unique,
                    bool not_null, string def_value,
                    int? max_len,
                    bool auto_create_ins)
            {
                this.PropertyName = prop_name;
                this.ColumnType = prop_type;

                this.Name = name;
                this.IsPK = pk;
                this.IsAutoInc = auto_inc;
                this.IsUnique = unique;
                this.IsNotNull = not_null;
                this.DefaultValue = def_value;
                this.MaxLength = max_len;
                this.IsAutoCreateIns = auto_create_ins;
            }
            public override void SetValue(object obj, object val)
            {
                var _obj = (LogEntity)obj;
                val = val ?? AutoCreateIns();
                switch (this.PropertyName)
                {
                   case "id":
                        _obj.id=(System.Int64)val;
                        break;
                  case "date":
                        _obj.date=(System.String)val;
                        break;
                  case "dateDeatils":
                        _obj.dateDeatils=(System.Int64)val;
                        break;
                  case "type":
                        _obj.type=(System.Int32)val;
                        break;
                  case "sub_type":
                        _obj.sub_type=(System.Int32)val;
                        break;
                  case "money":
                        _obj.money=(System.Single)val;
                        break;
                  case "remarks":
                        _obj.remarks=(System.String)val;
                        break;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            public override object GetValue(object obj)
            {
                var _obj = (LogEntity)obj;
                switch (this.PropertyName)
                {
                   case "id":
                        return _obj.id;
                  case "date":
                        return _obj.date;
                  case "dateDeatils":
                        return _obj.dateDeatils;
                  case "type":
                        return _obj.type;
                  case "sub_type":
                        return _obj.sub_type;
                  case "money":
                        return _obj.money;
                  case "remarks":
                        return _obj.remarks;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            private object AutoCreateIns()
            {
                if(!this.IsAutoCreateIns)
                    return null;
                switch (this.PropertyName)
                {
 
                    default:
                        return null;
                }
            }
        }
    }
    public class EquipDataMappingWarp : Sqlite3.TableMapping
    {
        //Ctor
        public EquipDataMappingWarp()
        {
            
            this.MappedType = typeof(EquipData);
            this.TableName = "EquipData";
            //Columns
            this.PK = new Column("id", typeof(System.Int32), "id", true, false, false, false, null, null, true);
            this.Columns = new[]
            {
                this.PK,
new Column("equip_name", typeof(System.String), "equip_name", false, false, false, false, null, null, true),
new Column("desc", typeof(System.String), "desc", false, false, false, false, null, null, true),
new Column("source", typeof(System.String), "source", false, false, false, false, null, null, true),
new Column("quality", typeof(System.Int32), "quality", false, false, false, false, null, null, true),
new Column("place", typeof(System.Int32), "place", false, false, false, false, null, null, true),
new Column("icon", typeof(System.String), "icon", false, false, false, false, null, null, true),
new Column("attack", typeof(System.Int32), "attack", false, false, false, false, null, null, true),
new Column("defense", typeof(System.Int32), "defense", false, false, false, false, null, null, true),
new Column("health", typeof(System.Int32), "health", false, false, false, false, null, null, true),
new Column("speed", typeof(System.Int32), "speed", false, false, false, false, null, null, true),
new Column("hit", typeof(System.Int32), "hit", false, false, false, false, null, null, true),
new Column("critical", typeof(System.Int32), "critical", false, false, false, false, null, null, true),
new Column("dodge", typeof(System.Int32), "dodge", false, false, false, false, null, null, true),
new Column("parry", typeof(System.Int32), "parry", false, false, false, false, null, null, true),
new Column("fight_back", typeof(System.Int32), "fight_back", false, false, false, false, null, null, true),
new Column("equip_group_id", typeof(System.Int32), "equip_group_id", false, false, false, false, null, null, true),
new Column("milt_receive", typeof(System.Int32), "milt_receive", false, false, false, false, null, null, true),
new Column("sold", typeof(System.Int32), "sold", false, false, false, false, null, null, true),
new Column("level_limit", typeof(System.Int32), "level_limit", false, false, false, false, null, null, true),

            };

            this.GetByPrimaryKeySql = "SELECT * FROM \"EquipData\" WHERE \"id\" = ?";

        }
        //Column Ctor
        public class Column : Sqlite3.Column
        {
            public Column(string prop_name, System.Type prop_type,
                    string name,
                    bool pk, bool auto_inc, bool unique,
                    bool not_null, string def_value,
                    int? max_len,
                    bool auto_create_ins)
            {
                this.PropertyName = prop_name;
                this.ColumnType = prop_type;

                this.Name = name;
                this.IsPK = pk;
                this.IsAutoInc = auto_inc;
                this.IsUnique = unique;
                this.IsNotNull = not_null;
                this.DefaultValue = def_value;
                this.MaxLength = max_len;
                this.IsAutoCreateIns = auto_create_ins;
            }
            public override void SetValue(object obj, object val)
            {
                var _obj = (EquipData)obj;
                val = val ?? AutoCreateIns();
                switch (this.PropertyName)
                {
                   case "id":
                        _obj.id=(System.Int32)val;
                        break;
                  case "equip_name":
                        _obj.equip_name=(System.String)val;
                        break;
                  case "desc":
                        _obj.desc=(System.String)val;
                        break;
                  case "source":
                        _obj.source=(System.String)val;
                        break;
                  case "quality":
                        _obj.quality=(System.Int32)val;
                        break;
                  case "place":
                        _obj.place=(System.Int32)val;
                        break;
                  case "icon":
                        _obj.icon=(System.String)val;
                        break;
                  case "attack":
                        _obj.attack=(System.Int32)val;
                        break;
                  case "defense":
                        _obj.defense=(System.Int32)val;
                        break;
                  case "health":
                        _obj.health=(System.Int32)val;
                        break;
                  case "speed":
                        _obj.speed=(System.Int32)val;
                        break;
                  case "hit":
                        _obj.hit=(System.Int32)val;
                        break;
                  case "critical":
                        _obj.critical=(System.Int32)val;
                        break;
                  case "dodge":
                        _obj.dodge=(System.Int32)val;
                        break;
                  case "parry":
                        _obj.parry=(System.Int32)val;
                        break;
                  case "fight_back":
                        _obj.fight_back=(System.Int32)val;
                        break;
                  case "equip_group_id":
                        _obj.equip_group_id=(System.Int32)val;
                        break;
                  case "milt_receive":
                        _obj.milt_receive=(System.Int32)val;
                        break;
                  case "sold":
                        _obj.sold=(System.Int32)val;
                        break;
                  case "level_limit":
                        _obj.level_limit=(System.Int32)val;
                        break;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            public override object GetValue(object obj)
            {
                var _obj = (EquipData)obj;
                switch (this.PropertyName)
                {
                   case "id":
                        return _obj.id;
                  case "equip_name":
                        return _obj.equip_name;
                  case "desc":
                        return _obj.desc;
                  case "source":
                        return _obj.source;
                  case "quality":
                        return _obj.quality;
                  case "place":
                        return _obj.place;
                  case "icon":
                        return _obj.icon;
                  case "attack":
                        return _obj.attack;
                  case "defense":
                        return _obj.defense;
                  case "health":
                        return _obj.health;
                  case "speed":
                        return _obj.speed;
                  case "hit":
                        return _obj.hit;
                  case "critical":
                        return _obj.critical;
                  case "dodge":
                        return _obj.dodge;
                  case "parry":
                        return _obj.parry;
                  case "fight_back":
                        return _obj.fight_back;
                  case "equip_group_id":
                        return _obj.equip_group_id;
                  case "milt_receive":
                        return _obj.milt_receive;
                  case "sold":
                        return _obj.sold;
                  case "level_limit":
                        return _obj.level_limit;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            private object AutoCreateIns()
            {
                if(!this.IsAutoCreateIns)
                    return null;
                switch (this.PropertyName)
                {
 
                    default:
                        return null;
                }
            }
        }
    }
    public class ItemDataMappingWarp : Sqlite3.TableMapping
    {
        //Ctor
        public ItemDataMappingWarp()
        {
            
            this.MappedType = typeof(ItemData);
            this.TableName = "ItemData";
            //Columns
            this.PK = new Column("id", typeof(System.Int32), "id", true, false, false, false, null, null, true);
            this.Columns = new[]
            {
                this.PK,
new Column("item_name", typeof(System.String), "item_name", false, false, false, false, null, null, true),
new Column("desc", typeof(System.String), "desc", false, false, false, false, null, null, true),
new Column("icon", typeof(System.Int32), "icon", false, false, false, false, null, null, true),
new Column("type", typeof(System.Int32), "type", false, false, false, false, null, null, true),
new Column("item_type", typeof(System.Collections.Generic.List<System.Int32>), "item_type", false, false, false, false, null, null, true),
new Column("item_id", typeof(System.Collections.Generic.List<System.Int32>), "item_id", false, false, false, false, null, null, true),
new Column("num", typeof(System.Int32), "num", false, false, false, false, null, null, true),
new Column("drop_pro", typeof(System.Collections.Generic.List<System.Int32>), "drop_pro", false, false, false, false, null, null, true),
new Column("drop_limit", typeof(System.Int32), "drop_limit", false, false, false, false, null, null, true),
new Column("quality", typeof(System.Int32), "quality", false, false, false, false, null, null, true),
new Column("level", typeof(System.Int32), "level", false, false, false, false, null, null, true),
new Column("key_id", typeof(System.Int32), "key_id", false, false, false, false, null, null, true),
new Column("source", typeof(System.String), "source", false, false, false, false, null, null, true),
new Column("pile", typeof(System.Int32), "pile", false, false, false, false, null, null, true),
new Column("can_use", typeof(System.Int32), "can_use", false, false, false, false, null, null, true),
new Column("hide", typeof(System.Int32), "hide", false, false, false, false, null, null, true),
new Column("item_num", typeof(System.Collections.Generic.List<System.Int32>), "item_num", false, false, false, false, null, null, true),
new Column("world_types", typeof(System.Int32), "world_types", false, false, false, false, null, null, true),

            };

            this.GetByPrimaryKeySql = "SELECT * FROM \"ItemData\" WHERE \"id\" = ?";

        }
        //Column Ctor
        public class Column : Sqlite3.Column
        {
            public Column(string prop_name, System.Type prop_type,
                    string name,
                    bool pk, bool auto_inc, bool unique,
                    bool not_null, string def_value,
                    int? max_len,
                    bool auto_create_ins)
            {
                this.PropertyName = prop_name;
                this.ColumnType = prop_type;

                this.Name = name;
                this.IsPK = pk;
                this.IsAutoInc = auto_inc;
                this.IsUnique = unique;
                this.IsNotNull = not_null;
                this.DefaultValue = def_value;
                this.MaxLength = max_len;
                this.IsAutoCreateIns = auto_create_ins;
            }
            public override void SetValue(object obj, object val)
            {
                var _obj = (ItemData)obj;
                val = val ?? AutoCreateIns();
                switch (this.PropertyName)
                {
                   case "id":
                        _obj.id=(System.Int32)val;
                        break;
                  case "item_name":
                        _obj.item_name=(System.String)val;
                        break;
                  case "desc":
                        _obj.desc=(System.String)val;
                        break;
                  case "icon":
                        _obj.icon=(System.Int32)val;
                        break;
                  case "type":
                        _obj.type=(System.Int32)val;
                        break;
                  case "item_type":
                        _obj.item_type=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "item_id":
                        _obj.item_id=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "num":
                        _obj.num=(System.Int32)val;
                        break;
                  case "drop_pro":
                        _obj.drop_pro=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "drop_limit":
                        _obj.drop_limit=(System.Int32)val;
                        break;
                  case "quality":
                        _obj.quality=(System.Int32)val;
                        break;
                  case "level":
                        _obj.level=(System.Int32)val;
                        break;
                  case "key_id":
                        _obj.key_id=(System.Int32)val;
                        break;
                  case "source":
                        _obj.source=(System.String)val;
                        break;
                  case "pile":
                        _obj.pile=(System.Int32)val;
                        break;
                  case "can_use":
                        _obj.can_use=(System.Int32)val;
                        break;
                  case "hide":
                        _obj.hide=(System.Int32)val;
                        break;
                  case "item_num":
                        _obj.item_num=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "world_types":
                        _obj.world_types=(System.Int32)val;
                        break;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            public override object GetValue(object obj)
            {
                var _obj = (ItemData)obj;
                switch (this.PropertyName)
                {
                   case "id":
                        return _obj.id;
                  case "item_name":
                        return _obj.item_name;
                  case "desc":
                        return _obj.desc;
                  case "icon":
                        return _obj.icon;
                  case "type":
                        return _obj.type;
                  case "item_type":
                        return _obj.item_type;
                  case "item_id":
                        return _obj.item_id;
                  case "num":
                        return _obj.num;
                  case "drop_pro":
                        return _obj.drop_pro;
                  case "drop_limit":
                        return _obj.drop_limit;
                  case "quality":
                        return _obj.quality;
                  case "level":
                        return _obj.level;
                  case "key_id":
                        return _obj.key_id;
                  case "source":
                        return _obj.source;
                  case "pile":
                        return _obj.pile;
                  case "can_use":
                        return _obj.can_use;
                  case "hide":
                        return _obj.hide;
                  case "item_num":
                        return _obj.item_num;
                  case "world_types":
                        return _obj.world_types;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            private object AutoCreateIns()
            {
                if(!this.IsAutoCreateIns)
                    return null;
                switch (this.PropertyName)
                {
                   case "item_type":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "item_id":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "drop_pro":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "item_num":
                        return new System.Collections.Generic.List<System.Int32>();

                    default:
                        return null;
                }
            }
        }
    }
    public class TaskDataMappingWarp : Sqlite3.TableMapping
    {
        //Ctor
        public TaskDataMappingWarp()
        {
            
            this.MappedType = typeof(TaskData);
            this.TableName = "TaskData";
            //Columns
            this.PK = new Column("id", typeof(System.Int32), "id", true, false, false, false, null, null, true);
            this.Columns = new[]
            {
                this.PK,
new Column("task_name", typeof(System.String), "task_name", false, false, false, false, null, null, true),
new Column("description", typeof(System.String), "description", false, false, false, false, null, null, true),
new Column("icon", typeof(System.String), "icon", false, false, false, false, null, null, true),
new Column("npc_name", typeof(System.Int32), "npc_name", false, false, false, false, null, null, true),
new Column("npc_id", typeof(System.Int32), "npc_id", false, false, false, false, null, null, true),
new Column("group", typeof(System.Int32), "group", false, false, false, false, null, null, true),
new Column("limit_level", typeof(System.Int32), "limit_level", false, false, false, false, null, null, true),
new Column("type", typeof(System.Int32), "type", false, false, false, false, null, null, true),
new Column("condition", typeof(System.Collections.Generic.List<System.Int32>), "condition", false, false, false, false, null, null, true),
new Column("target_num", typeof(System.Collections.Generic.List<System.Int32>), "target_num", false, false, false, false, null, null, true),
new Column("recept_scene", typeof(System.Int32), "recept_scene", false, false, false, false, null, null, true),
new Column("after_id", typeof(System.Int32), "after_id", false, false, false, false, null, null, true),
new Column("reward_types", typeof(System.Collections.Generic.List<System.Int32>), "reward_types", false, false, false, false, null, null, true),
new Column("reward_ids", typeof(System.Collections.Generic.List<System.Int32>), "reward_ids", false, false, false, false, null, null, true),
new Column("reward_numbers", typeof(System.Collections.Generic.List<System.Int32>), "reward_numbers", false, false, false, false, null, null, true),
new Column("receiving_npc", typeof(System.Collections.Generic.List<System.Int32>), "receiving_npc", false, false, false, false, null, null, true),
new Column("receiving_content", typeof(System.Collections.Generic.List<System.Int32>), "receiving_content", false, false, false, false, null, null, true),
new Column("complete_npc", typeof(System.Collections.Generic.List<System.Int32>), "complete_npc", false, false, false, false, null, null, true),
new Column("complete_content", typeof(System.Collections.Generic.List<System.Int32>), "complete_content", false, false, false, false, null, null, true),
new Column("belong", typeof(System.Int32), "belong", false, false, false, false, null, null, true),
new Column("chatType", typeof(System.Int32), "chatType", false, false, false, false, null, null, true),
new Column("time_range", typeof(System.Int32[]), "time_range", false, false, false, false, null, null, true),
new Column("need_battle", typeof(System.Int32), "need_battle", false, false, false, false, null, null, true),
new Column("friends_team", typeof(System.Collections.Generic.List<System.Int32>), "friends_team", false, false, false, false, null, null, true),
new Column("friends_level", typeof(System.Collections.Generic.List<System.Int32>), "friends_level", false, false, false, false, null, null, true),
new Column("enemies_team", typeof(System.Collections.Generic.List<System.Int32>), "enemies_team", false, false, false, false, null, null, true),
new Column("enemies_level", typeof(System.Collections.Generic.List<System.Int32>), "enemies_level", false, false, false, false, null, null, true),
new Column("task_type", typeof(System.Int32), "task_type", false, false, false, false, null, null, true),
new Column("task_commit_type", typeof(System.Int32), "task_commit_type", false, false, false, false, null, null, true),

            };

            this.GetByPrimaryKeySql = "SELECT * FROM \"TaskData\" WHERE \"id\" = ?";

        }
        //Column Ctor
        public class Column : Sqlite3.Column
        {
            public Column(string prop_name, System.Type prop_type,
                    string name,
                    bool pk, bool auto_inc, bool unique,
                    bool not_null, string def_value,
                    int? max_len,
                    bool auto_create_ins)
            {
                this.PropertyName = prop_name;
                this.ColumnType = prop_type;

                this.Name = name;
                this.IsPK = pk;
                this.IsAutoInc = auto_inc;
                this.IsUnique = unique;
                this.IsNotNull = not_null;
                this.DefaultValue = def_value;
                this.MaxLength = max_len;
                this.IsAutoCreateIns = auto_create_ins;
            }
            public override void SetValue(object obj, object val)
            {
                var _obj = (TaskData)obj;
                val = val ?? AutoCreateIns();
                switch (this.PropertyName)
                {
                   case "id":
                        _obj.id=(System.Int32)val;
                        break;
                  case "task_name":
                        _obj.task_name=(System.String)val;
                        break;
                  case "description":
                        _obj.description=(System.String)val;
                        break;
                  case "icon":
                        _obj.icon=(System.String)val;
                        break;
                  case "npc_name":
                        _obj.npc_name=(System.Int32)val;
                        break;
                  case "npc_id":
                        _obj.npc_id=(System.Int32)val;
                        break;
                  case "group":
                        _obj.group=(System.Int32)val;
                        break;
                  case "limit_level":
                        _obj.limit_level=(System.Int32)val;
                        break;
                  case "type":
                        _obj.type=(System.Int32)val;
                        break;
                  case "condition":
                        _obj.condition=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "target_num":
                        _obj.target_num=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "recept_scene":
                        _obj.recept_scene=(System.Int32)val;
                        break;
                  case "after_id":
                        _obj.after_id=(System.Int32)val;
                        break;
                  case "reward_types":
                        _obj.reward_types=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "reward_ids":
                        _obj.reward_ids=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "reward_numbers":
                        _obj.reward_numbers=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "receiving_npc":
                        _obj.receiving_npc=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "receiving_content":
                        _obj.receiving_content=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "complete_npc":
                        _obj.complete_npc=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "complete_content":
                        _obj.complete_content=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "belong":
                        _obj.belong=(System.Int32)val;
                        break;
                  case "chatType":
                        _obj.chatType=(System.Int32)val;
                        break;
                  case "time_range":
                        _obj.time_range=(System.Int32[])val;
                        break;
                  case "need_battle":
                        _obj.need_battle=(System.Int32)val;
                        break;
                  case "friends_team":
                        _obj.friends_team=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "friends_level":
                        _obj.friends_level=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "enemies_team":
                        _obj.enemies_team=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "enemies_level":
                        _obj.enemies_level=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "task_type":
                        _obj.task_type=(System.Int32)val;
                        break;
                  case "task_commit_type":
                        _obj.task_commit_type=(System.Int32)val;
                        break;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            public override object GetValue(object obj)
            {
                var _obj = (TaskData)obj;
                switch (this.PropertyName)
                {
                   case "id":
                        return _obj.id;
                  case "task_name":
                        return _obj.task_name;
                  case "description":
                        return _obj.description;
                  case "icon":
                        return _obj.icon;
                  case "npc_name":
                        return _obj.npc_name;
                  case "npc_id":
                        return _obj.npc_id;
                  case "group":
                        return _obj.group;
                  case "limit_level":
                        return _obj.limit_level;
                  case "type":
                        return _obj.type;
                  case "condition":
                        return _obj.condition;
                  case "target_num":
                        return _obj.target_num;
                  case "recept_scene":
                        return _obj.recept_scene;
                  case "after_id":
                        return _obj.after_id;
                  case "reward_types":
                        return _obj.reward_types;
                  case "reward_ids":
                        return _obj.reward_ids;
                  case "reward_numbers":
                        return _obj.reward_numbers;
                  case "receiving_npc":
                        return _obj.receiving_npc;
                  case "receiving_content":
                        return _obj.receiving_content;
                  case "complete_npc":
                        return _obj.complete_npc;
                  case "complete_content":
                        return _obj.complete_content;
                  case "belong":
                        return _obj.belong;
                  case "chatType":
                        return _obj.chatType;
                  case "time_range":
                        return _obj.time_range;
                  case "need_battle":
                        return _obj.need_battle;
                  case "friends_team":
                        return _obj.friends_team;
                  case "friends_level":
                        return _obj.friends_level;
                  case "enemies_team":
                        return _obj.enemies_team;
                  case "enemies_level":
                        return _obj.enemies_level;
                  case "task_type":
                        return _obj.task_type;
                  case "task_commit_type":
                        return _obj.task_commit_type;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            private object AutoCreateIns()
            {
                if(!this.IsAutoCreateIns)
                    return null;
                switch (this.PropertyName)
                {
                   case "condition":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "target_num":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "reward_types":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "reward_ids":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "reward_numbers":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "receiving_npc":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "receiving_content":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "complete_npc":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "complete_content":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "time_range":
                        return new System.Int32[0];
                  case "friends_team":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "friends_level":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "enemies_team":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "enemies_level":
                        return new System.Collections.Generic.List<System.Int32>();

                    default:
                        return null;
                }
            }
        }
    }
    public class EventDataMappingWarp : Sqlite3.TableMapping
    {
        //Ctor
        public EventDataMappingWarp()
        {
            
            this.MappedType = typeof(EventData);
            this.TableName = "EventData";
            //Columns
            this.PK = new Column("id", typeof(System.Int32), "id", true, false, false, false, null, null, true);
            this.Columns = new[]
            {
                this.PK,
new Column("event_name", typeof(System.String), "event_name", false, false, false, false, null, null, true),
new Column("limit_level", typeof(System.Int32), "limit_level", false, false, false, false, null, null, true),
new Column("limit_reputation", typeof(System.Int32), "limit_reputation", false, false, false, false, null, null, true),
new Column("limit_hamony", typeof(System.Int32), "limit_hamony", false, false, false, false, null, null, true),
new Column("desc", typeof(System.String), "desc", false, false, false, false, null, null, true),
new Column("type", typeof(System.Int32), "type", false, false, false, false, null, null, true),
new Column("item_ids", typeof(System.Collections.Generic.List<System.Int32>), "item_ids", false, false, false, false, null, null, true),
new Column("item_num", typeof(System.Collections.Generic.List<System.Int32>), "item_num", false, false, false, false, null, null, true),
new Column("time_remain", typeof(System.Double), "time_remain", false, false, false, false, null, null, true),
new Column("monster_ids", typeof(System.Collections.Generic.List<System.Int32>), "monster_ids", false, false, false, false, null, null, true),
new Column("monster_num", typeof(System.Collections.Generic.List<System.Int32>), "monster_num", false, false, false, false, null, null, true),
new Column("sence", typeof(System.Int32), "sence", false, false, false, false, null, null, true),
new Column("npc_type", typeof(System.Int32), "npc_type", false, false, false, false, null, null, true),
new Column("npc_confirm", typeof(System.Collections.Generic.List<System.Int32>), "npc_confirm", false, false, false, false, null, null, true),
new Column("npc_ids", typeof(System.Collections.Generic.List<System.Int32>), "npc_ids", false, false, false, false, null, null, true),
new Column("npc_prob", typeof(System.Collections.Generic.List<System.Int32>), "npc_prob", false, false, false, false, null, null, true),
new Column("npc_value_min", typeof(System.Collections.Generic.List<System.Int32>), "npc_value_min", false, false, false, false, null, null, true),
new Column("cost_type", typeof(System.Int32), "cost_type", false, false, false, false, null, null, true),
new Column("cost_num", typeof(System.Int32), "cost_num", false, false, false, false, null, null, true),
new Column("actions", typeof(System.Collections.Generic.List<System.String>), "actions", false, false, false, false, null, null, true),
new Column("action1_name", typeof(System.String), "action1_name", false, false, false, false, null, null, true),
new Column("action1_reward_types", typeof(System.Collections.Generic.List<System.Int32>), "action1_reward_types", false, false, false, false, null, null, true),
new Column("action1_reward_ids", typeof(System.Collections.Generic.List<System.Int32>), "action1_reward_ids", false, false, false, false, null, null, true),
new Column("action1_reward_num", typeof(System.Collections.Generic.List<System.Int32>), "action1_reward_num", false, false, false, false, null, null, true),
new Column("action2_name", typeof(System.String), "action2_name", false, false, false, false, null, null, true),
new Column("action2_reward_types", typeof(System.Collections.Generic.List<System.Int32>), "action2_reward_types", false, false, false, false, null, null, true),
new Column("action2_reward_ids", typeof(System.Collections.Generic.List<System.Int32>), "action2_reward_ids", false, false, false, false, null, null, true),
new Column("action2_reward_num", typeof(System.Collections.Generic.List<System.Int32>), "action2_reward_num", false, false, false, false, null, null, true),
new Column("action3_name", typeof(System.String), "action3_name", false, false, false, false, null, null, true),
new Column("action3_reward_types", typeof(System.Collections.Generic.List<System.Int32>), "action3_reward_types", false, false, false, false, null, null, true),
new Column("action3_reward_ids", typeof(System.Collections.Generic.List<System.Int32>), "action3_reward_ids", false, false, false, false, null, null, true),
new Column("action3_reward_num", typeof(System.Collections.Generic.List<System.Int32>), "action3_reward_num", false, false, false, false, null, null, true),
new Column("action_dialog", typeof(System.String), "action_dialog", false, false, false, false, null, null, true),

            };

            this.GetByPrimaryKeySql = "SELECT * FROM \"EventData\" WHERE \"id\" = ?";

        }
        //Column Ctor
        public class Column : Sqlite3.Column
        {
            public Column(string prop_name, System.Type prop_type,
                    string name,
                    bool pk, bool auto_inc, bool unique,
                    bool not_null, string def_value,
                    int? max_len,
                    bool auto_create_ins)
            {
                this.PropertyName = prop_name;
                this.ColumnType = prop_type;

                this.Name = name;
                this.IsPK = pk;
                this.IsAutoInc = auto_inc;
                this.IsUnique = unique;
                this.IsNotNull = not_null;
                this.DefaultValue = def_value;
                this.MaxLength = max_len;
                this.IsAutoCreateIns = auto_create_ins;
            }
            public override void SetValue(object obj, object val)
            {
                var _obj = (EventData)obj;
                val = val ?? AutoCreateIns();
                switch (this.PropertyName)
                {
                   case "id":
                        _obj.id=(System.Int32)val;
                        break;
                  case "event_name":
                        _obj.event_name=(System.String)val;
                        break;
                  case "limit_level":
                        _obj.limit_level=(System.Int32)val;
                        break;
                  case "limit_reputation":
                        _obj.limit_reputation=(System.Int32)val;
                        break;
                  case "limit_hamony":
                        _obj.limit_hamony=(System.Int32)val;
                        break;
                  case "desc":
                        _obj.desc=(System.String)val;
                        break;
                  case "type":
                        _obj.type=(System.Int32)val;
                        break;
                  case "item_ids":
                        _obj.item_ids=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "item_num":
                        _obj.item_num=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "time_remain":
                        _obj.time_remain=(System.Double)val;
                        break;
                  case "monster_ids":
                        _obj.monster_ids=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "monster_num":
                        _obj.monster_num=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "sence":
                        _obj.sence=(System.Int32)val;
                        break;
                  case "npc_type":
                        _obj.npc_type=(System.Int32)val;
                        break;
                  case "npc_confirm":
                        _obj.npc_confirm=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "npc_ids":
                        _obj.npc_ids=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "npc_prob":
                        _obj.npc_prob=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "npc_value_min":
                        _obj.npc_value_min=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "cost_type":
                        _obj.cost_type=(System.Int32)val;
                        break;
                  case "cost_num":
                        _obj.cost_num=(System.Int32)val;
                        break;
                  case "actions":
                        _obj.actions=(System.Collections.Generic.List<System.String>)val;
                        break;
                  case "action1_name":
                        _obj.action1_name=(System.String)val;
                        break;
                  case "action1_reward_types":
                        _obj.action1_reward_types=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "action1_reward_ids":
                        _obj.action1_reward_ids=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "action1_reward_num":
                        _obj.action1_reward_num=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "action2_name":
                        _obj.action2_name=(System.String)val;
                        break;
                  case "action2_reward_types":
                        _obj.action2_reward_types=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "action2_reward_ids":
                        _obj.action2_reward_ids=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "action2_reward_num":
                        _obj.action2_reward_num=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "action3_name":
                        _obj.action3_name=(System.String)val;
                        break;
                  case "action3_reward_types":
                        _obj.action3_reward_types=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "action3_reward_ids":
                        _obj.action3_reward_ids=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "action3_reward_num":
                        _obj.action3_reward_num=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "action_dialog":
                        _obj.action_dialog=(System.String)val;
                        break;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            public override object GetValue(object obj)
            {
                var _obj = (EventData)obj;
                switch (this.PropertyName)
                {
                   case "id":
                        return _obj.id;
                  case "event_name":
                        return _obj.event_name;
                  case "limit_level":
                        return _obj.limit_level;
                  case "limit_reputation":
                        return _obj.limit_reputation;
                  case "limit_hamony":
                        return _obj.limit_hamony;
                  case "desc":
                        return _obj.desc;
                  case "type":
                        return _obj.type;
                  case "item_ids":
                        return _obj.item_ids;
                  case "item_num":
                        return _obj.item_num;
                  case "time_remain":
                        return _obj.time_remain;
                  case "monster_ids":
                        return _obj.monster_ids;
                  case "monster_num":
                        return _obj.monster_num;
                  case "sence":
                        return _obj.sence;
                  case "npc_type":
                        return _obj.npc_type;
                  case "npc_confirm":
                        return _obj.npc_confirm;
                  case "npc_ids":
                        return _obj.npc_ids;
                  case "npc_prob":
                        return _obj.npc_prob;
                  case "npc_value_min":
                        return _obj.npc_value_min;
                  case "cost_type":
                        return _obj.cost_type;
                  case "cost_num":
                        return _obj.cost_num;
                  case "actions":
                        return _obj.actions;
                  case "action1_name":
                        return _obj.action1_name;
                  case "action1_reward_types":
                        return _obj.action1_reward_types;
                  case "action1_reward_ids":
                        return _obj.action1_reward_ids;
                  case "action1_reward_num":
                        return _obj.action1_reward_num;
                  case "action2_name":
                        return _obj.action2_name;
                  case "action2_reward_types":
                        return _obj.action2_reward_types;
                  case "action2_reward_ids":
                        return _obj.action2_reward_ids;
                  case "action2_reward_num":
                        return _obj.action2_reward_num;
                  case "action3_name":
                        return _obj.action3_name;
                  case "action3_reward_types":
                        return _obj.action3_reward_types;
                  case "action3_reward_ids":
                        return _obj.action3_reward_ids;
                  case "action3_reward_num":
                        return _obj.action3_reward_num;
                  case "action_dialog":
                        return _obj.action_dialog;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            private object AutoCreateIns()
            {
                if(!this.IsAutoCreateIns)
                    return null;
                switch (this.PropertyName)
                {
                   case "item_ids":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "item_num":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "monster_ids":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "monster_num":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "npc_confirm":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "npc_ids":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "npc_prob":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "npc_value_min":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "actions":
                        return new System.Collections.Generic.List<System.String>();
                  case "action1_reward_types":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "action1_reward_ids":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "action1_reward_num":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "action2_reward_types":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "action2_reward_ids":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "action2_reward_num":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "action3_reward_types":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "action3_reward_ids":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "action3_reward_num":
                        return new System.Collections.Generic.List<System.Int32>();

                    default:
                        return null;
                }
            }
        }
    }
    public class TaskSectionDataMappingWarp : Sqlite3.TableMapping
    {
        //Ctor
        public TaskSectionDataMappingWarp()
        {
            
            this.MappedType = typeof(TaskSectionData);
            this.TableName = "TaskSectionData";
            //Columns
            this.PK = new Column("id", typeof(System.Int32), "id", true, false, false, false, null, null, true);
            this.Columns = new[]
            {
                this.PK,
new Column("task_name", typeof(System.String), "task_name", false, false, false, false, null, null, true),
new Column("description", typeof(System.String), "description", false, false, false, false, null, null, true),
new Column("icon", typeof(System.String), "icon", false, false, false, false, null, null, true),
new Column("npc_name", typeof(System.Int32), "npc_name", false, false, false, false, null, null, true),
new Column("npc_id", typeof(System.Int32), "npc_id", false, false, false, false, null, null, true),
new Column("group", typeof(System.Int32), "group", false, false, false, false, null, null, true),
new Column("limit_level", typeof(System.Int32), "limit_level", false, false, false, false, null, null, true),
new Column("type", typeof(System.Int32), "type", false, false, false, false, null, null, true),
new Column("condition", typeof(System.Collections.Generic.List<System.Int32>), "condition", false, false, false, false, null, null, true),
new Column("target_num", typeof(System.Collections.Generic.List<System.Int32>), "target_num", false, false, false, false, null, null, true),
new Column("recept_scene", typeof(System.Int32), "recept_scene", false, false, false, false, null, null, true),
new Column("after_id", typeof(System.Int32), "after_id", false, false, false, false, null, null, true),
new Column("reward_types", typeof(System.Collections.Generic.List<System.Int32>), "reward_types", false, false, false, false, null, null, true),
new Column("reward_ids", typeof(System.Collections.Generic.List<System.Int32>), "reward_ids", false, false, false, false, null, null, true),
new Column("reward_numbers", typeof(System.Collections.Generic.List<System.Int32>), "reward_numbers", false, false, false, false, null, null, true),
new Column("receiving_npc", typeof(System.Collections.Generic.List<System.Int32>), "receiving_npc", false, false, false, false, null, null, true),
new Column("receiving_content", typeof(System.Collections.Generic.List<System.Int32>), "receiving_content", false, false, false, false, null, null, true),
new Column("complete_npc", typeof(System.Collections.Generic.List<System.Int32>), "complete_npc", false, false, false, false, null, null, true),
new Column("complete_content", typeof(System.Collections.Generic.List<System.Int32>), "complete_content", false, false, false, false, null, null, true),
new Column("belong", typeof(System.Int32), "belong", false, false, false, false, null, null, true),
new Column("chatType", typeof(System.Int32), "chatType", false, false, false, false, null, null, true),
new Column("task_type", typeof(System.Int32), "task_type", false, false, false, false, null, null, true),

            };

            this.GetByPrimaryKeySql = "SELECT * FROM \"TaskSectionData\" WHERE \"id\" = ?";

        }
        //Column Ctor
        public class Column : Sqlite3.Column
        {
            public Column(string prop_name, System.Type prop_type,
                    string name,
                    bool pk, bool auto_inc, bool unique,
                    bool not_null, string def_value,
                    int? max_len,
                    bool auto_create_ins)
            {
                this.PropertyName = prop_name;
                this.ColumnType = prop_type;

                this.Name = name;
                this.IsPK = pk;
                this.IsAutoInc = auto_inc;
                this.IsUnique = unique;
                this.IsNotNull = not_null;
                this.DefaultValue = def_value;
                this.MaxLength = max_len;
                this.IsAutoCreateIns = auto_create_ins;
            }
            public override void SetValue(object obj, object val)
            {
                var _obj = (TaskSectionData)obj;
                val = val ?? AutoCreateIns();
                switch (this.PropertyName)
                {
                   case "id":
                        _obj.id=(System.Int32)val;
                        break;
                  case "task_name":
                        _obj.task_name=(System.String)val;
                        break;
                  case "description":
                        _obj.description=(System.String)val;
                        break;
                  case "icon":
                        _obj.icon=(System.String)val;
                        break;
                  case "npc_name":
                        _obj.npc_name=(System.Int32)val;
                        break;
                  case "npc_id":
                        _obj.npc_id=(System.Int32)val;
                        break;
                  case "group":
                        _obj.group=(System.Int32)val;
                        break;
                  case "limit_level":
                        _obj.limit_level=(System.Int32)val;
                        break;
                  case "type":
                        _obj.type=(System.Int32)val;
                        break;
                  case "condition":
                        _obj.condition=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "target_num":
                        _obj.target_num=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "recept_scene":
                        _obj.recept_scene=(System.Int32)val;
                        break;
                  case "after_id":
                        _obj.after_id=(System.Int32)val;
                        break;
                  case "reward_types":
                        _obj.reward_types=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "reward_ids":
                        _obj.reward_ids=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "reward_numbers":
                        _obj.reward_numbers=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "receiving_npc":
                        _obj.receiving_npc=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "receiving_content":
                        _obj.receiving_content=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "complete_npc":
                        _obj.complete_npc=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "complete_content":
                        _obj.complete_content=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "belong":
                        _obj.belong=(System.Int32)val;
                        break;
                  case "chatType":
                        _obj.chatType=(System.Int32)val;
                        break;
                  case "task_type":
                        _obj.task_type=(System.Int32)val;
                        break;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            public override object GetValue(object obj)
            {
                var _obj = (TaskSectionData)obj;
                switch (this.PropertyName)
                {
                   case "id":
                        return _obj.id;
                  case "task_name":
                        return _obj.task_name;
                  case "description":
                        return _obj.description;
                  case "icon":
                        return _obj.icon;
                  case "npc_name":
                        return _obj.npc_name;
                  case "npc_id":
                        return _obj.npc_id;
                  case "group":
                        return _obj.group;
                  case "limit_level":
                        return _obj.limit_level;
                  case "type":
                        return _obj.type;
                  case "condition":
                        return _obj.condition;
                  case "target_num":
                        return _obj.target_num;
                  case "recept_scene":
                        return _obj.recept_scene;
                  case "after_id":
                        return _obj.after_id;
                  case "reward_types":
                        return _obj.reward_types;
                  case "reward_ids":
                        return _obj.reward_ids;
                  case "reward_numbers":
                        return _obj.reward_numbers;
                  case "receiving_npc":
                        return _obj.receiving_npc;
                  case "receiving_content":
                        return _obj.receiving_content;
                  case "complete_npc":
                        return _obj.complete_npc;
                  case "complete_content":
                        return _obj.complete_content;
                  case "belong":
                        return _obj.belong;
                  case "chatType":
                        return _obj.chatType;
                  case "task_type":
                        return _obj.task_type;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            private object AutoCreateIns()
            {
                if(!this.IsAutoCreateIns)
                    return null;
                switch (this.PropertyName)
                {
                   case "condition":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "target_num":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "reward_types":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "reward_ids":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "reward_numbers":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "receiving_npc":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "receiving_content":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "complete_npc":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "complete_content":
                        return new System.Collections.Generic.List<System.Int32>();

                    default:
                        return null;
                }
            }
        }
    }
    public class NpcDataMappingWarp : Sqlite3.TableMapping
    {
        //Ctor
        public NpcDataMappingWarp()
        {
            
            this.MappedType = typeof(NpcData);
            this.TableName = "NpcData";
            //Columns
            this.PK = new Column("id", typeof(System.Int32), "id", true, false, false, false, null, null, true);
            this.Columns = new[]
            {
                this.PK,
new Column("npc_name", typeof(System.String), "npc_name", false, false, false, false, null, null, true),
new Column("description", typeof(System.String), "description", false, false, false, false, null, null, true),
new Column("level", typeof(System.Int32), "level", false, false, false, false, null, null, true),
new Column("parent", typeof(System.Collections.Generic.List<System.Int32>), "parent", false, false, false, false, null, null, true),
new Column("broder", typeof(System.Collections.Generic.List<System.Int32>), "broder", false, false, false, false, null, null, true),
new Column("teacher", typeof(System.Collections.Generic.List<System.Int32>), "teacher", false, false, false, false, null, null, true),
new Column("partner", typeof(System.Collections.Generic.List<System.Int32>), "partner", false, false, false, false, null, null, true),
new Column("iron_friend", typeof(System.Collections.Generic.List<System.Int32>), "iron_friend", false, false, false, false, null, null, true),
new Column("child", typeof(System.Collections.Generic.List<System.Int32>), "child", false, false, false, false, null, null, true),
new Column("younger_generation", typeof(System.Collections.Generic.List<System.Int32>), "younger_generation", false, false, false, false, null, null, true),
new Column("apprentice", typeof(System.Collections.Generic.List<System.Int32>), "apprentice", false, false, false, false, null, null, true),
new Column("enjoy", typeof(System.Collections.Generic.List<System.Int32>), "enjoy", false, false, false, false, null, null, true),
new Column("believe", typeof(System.Collections.Generic.List<System.Int32>), "believe", false, false, false, false, null, null, true),
new Column("benefactor", typeof(System.Collections.Generic.List<System.Int32>), "benefactor", false, false, false, false, null, null, true),
new Column("disguise", typeof(System.Collections.Generic.List<System.Int32>), "disguise", false, false, false, false, null, null, true),
new Column("hate", typeof(System.Collections.Generic.List<System.Int32>), "hate", false, false, false, false, null, null, true),
new Column("hatred", typeof(System.Collections.Generic.List<System.Int32>), "hatred", false, false, false, false, null, null, true),
new Column("gen_gu", typeof(System.Int32), "gen_gu", false, false, false, false, null, null, true),
new Column("wu_xing", typeof(System.Int32), "wu_xing", false, false, false, false, null, null, true),
new Column("mood", typeof(System.Int32), "mood", false, false, false, false, null, null, true),
new Column("health", typeof(System.Int32), "health", false, false, false, false, null, null, true),
new Column("attack", typeof(System.Int32), "attack", false, false, false, false, null, null, true),
new Column("defense", typeof(System.Int32), "defense", false, false, false, false, null, null, true),
new Column("critical", typeof(System.Int32), "critical", false, false, false, false, null, null, true),
new Column("hit", typeof(System.Int32), "hit", false, false, false, false, null, null, true),
new Column("speed", typeof(System.Int32), "speed", false, false, false, false, null, null, true),
new Column("dodge", typeof(System.Int32), "dodge", false, false, false, false, null, null, true),
new Column("fight_back", typeof(System.Int32), "fight_back", false, false, false, false, null, null, true),
new Column("earth", typeof(System.Int32), "earth", false, false, false, false, null, null, true),
new Column("fire", typeof(System.Int32), "fire", false, false, false, false, null, null, true),
new Column("water", typeof(System.Int32), "water", false, false, false, false, null, null, true),
new Column("wind", typeof(System.Int32), "wind", false, false, false, false, null, null, true),
new Column("lighting", typeof(System.Int32), "lighting", false, false, false, false, null, null, true),
new Column("parry", typeof(System.Int32), "parry", false, false, false, false, null, null, true),
new Column("star", typeof(System.Int32), "star", false, false, false, false, null, null, true),
new Column("reputation", typeof(System.Int32), "reputation", false, false, false, false, null, null, true),
new Column("reputation_value", typeof(System.Int32), "reputation_value", false, false, false, false, null, null, true),
new Column("status", typeof(System.Int32), "status", false, false, false, false, null, null, true),
new Column("status_value", typeof(System.Int32), "status_value", false, false, false, false, null, null, true),
new Column("favorite", typeof(System.Int32), "favorite", false, false, false, false, null, null, true),
new Column("age", typeof(System.Int32), "age", false, false, false, false, null, null, true),
new Column("gender", typeof(System.Int32), "gender", false, false, false, false, null, null, true),
new Column("can_see", typeof(System.Int32), "can_see", false, false, false, false, null, null, true),
new Column("level_inition", typeof(System.Int32), "level_inition", false, false, false, false, null, null, true),
new Column("level_max", typeof(System.Int32), "level_max", false, false, false, false, null, null, true),
new Column("levelup_available", typeof(System.Int32), "levelup_available", false, false, false, false, null, null, true),
new Column("levelup_type", typeof(System.Int32), "levelup_type", false, false, false, false, null, null, true),
new Column("icon", typeof(System.String), "icon", false, false, false, false, null, null, true),
new Column("outer_skill", typeof(System.Collections.Generic.List<System.Int32>), "outer_skill", false, false, false, false, null, null, true),
new Column("inner_skill", typeof(System.Collections.Generic.List<System.Int32>), "inner_skill", false, false, false, false, null, null, true),
new Column("shen_fa", typeof(System.Collections.Generic.List<System.Int32>), "shen_fa", false, false, false, false, null, null, true),
new Column("equipment_ids", typeof(System.Collections.Generic.List<System.Int32>), "equipment_ids", false, false, false, false, null, null, true),
new Column("bag_items_ids", typeof(System.Collections.Generic.List<System.Int32>), "bag_items_ids", false, false, false, false, null, null, true),
new Column("bag_item_num", typeof(System.Collections.Generic.List<System.Int32>), "bag_item_num", false, false, false, false, null, null, true),
new Column("charm_type", typeof(System.Int32), "charm_type", false, false, false, false, null, null, true),
new Column("charm_value", typeof(System.Int32), "charm_value", false, false, false, false, null, null, true),
new Column("location", typeof(System.Int32), "location", false, false, false, false, null, null, true),
new Column("model", typeof(System.Int32), "model", false, false, false, false, null, null, true),
new Column("npc_types", typeof(System.Int32), "npc_types", false, false, false, false, null, null, true),
new Column("can_competition", typeof(System.Int32), "can_competition", false, false, false, false, null, null, true),

            };

            this.GetByPrimaryKeySql = "SELECT * FROM \"NpcData\" WHERE \"id\" = ?";

        }
        //Column Ctor
        public class Column : Sqlite3.Column
        {
            public Column(string prop_name, System.Type prop_type,
                    string name,
                    bool pk, bool auto_inc, bool unique,
                    bool not_null, string def_value,
                    int? max_len,
                    bool auto_create_ins)
            {
                this.PropertyName = prop_name;
                this.ColumnType = prop_type;

                this.Name = name;
                this.IsPK = pk;
                this.IsAutoInc = auto_inc;
                this.IsUnique = unique;
                this.IsNotNull = not_null;
                this.DefaultValue = def_value;
                this.MaxLength = max_len;
                this.IsAutoCreateIns = auto_create_ins;
            }
            public override void SetValue(object obj, object val)
            {
                var _obj = (NpcData)obj;
                val = val ?? AutoCreateIns();
                switch (this.PropertyName)
                {
                   case "id":
                        _obj.id=(System.Int32)val;
                        break;
                  case "npc_name":
                        _obj.npc_name=(System.String)val;
                        break;
                  case "description":
                        _obj.description=(System.String)val;
                        break;
                  case "level":
                        _obj.level=(System.Int32)val;
                        break;
                  case "parent":
                        _obj.parent=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "broder":
                        _obj.broder=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "teacher":
                        _obj.teacher=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "partner":
                        _obj.partner=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "iron_friend":
                        _obj.iron_friend=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "child":
                        _obj.child=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "younger_generation":
                        _obj.younger_generation=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "apprentice":
                        _obj.apprentice=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "enjoy":
                        _obj.enjoy=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "believe":
                        _obj.believe=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "benefactor":
                        _obj.benefactor=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "disguise":
                        _obj.disguise=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "hate":
                        _obj.hate=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "hatred":
                        _obj.hatred=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "gen_gu":
                        _obj.gen_gu=(System.Int32)val;
                        break;
                  case "wu_xing":
                        _obj.wu_xing=(System.Int32)val;
                        break;
                  case "mood":
                        _obj.mood=(System.Int32)val;
                        break;
                  case "health":
                        _obj.health=(System.Int32)val;
                        break;
                  case "attack":
                        _obj.attack=(System.Int32)val;
                        break;
                  case "defense":
                        _obj.defense=(System.Int32)val;
                        break;
                  case "critical":
                        _obj.critical=(System.Int32)val;
                        break;
                  case "hit":
                        _obj.hit=(System.Int32)val;
                        break;
                  case "speed":
                        _obj.speed=(System.Int32)val;
                        break;
                  case "dodge":
                        _obj.dodge=(System.Int32)val;
                        break;
                  case "fight_back":
                        _obj.fight_back=(System.Int32)val;
                        break;
                  case "earth":
                        _obj.earth=(System.Int32)val;
                        break;
                  case "fire":
                        _obj.fire=(System.Int32)val;
                        break;
                  case "water":
                        _obj.water=(System.Int32)val;
                        break;
                  case "wind":
                        _obj.wind=(System.Int32)val;
                        break;
                  case "lighting":
                        _obj.lighting=(System.Int32)val;
                        break;
                  case "parry":
                        _obj.parry=(System.Int32)val;
                        break;
                  case "star":
                        _obj.star=(System.Int32)val;
                        break;
                  case "reputation":
                        _obj.reputation=(System.Int32)val;
                        break;
                  case "reputation_value":
                        _obj.reputation_value=(System.Int32)val;
                        break;
                  case "status":
                        _obj.status=(System.Int32)val;
                        break;
                  case "status_value":
                        _obj.status_value=(System.Int32)val;
                        break;
                  case "favorite":
                        _obj.favorite=(System.Int32)val;
                        break;
                  case "age":
                        _obj.age=(System.Int32)val;
                        break;
                  case "gender":
                        _obj.gender=(System.Int32)val;
                        break;
                  case "can_see":
                        _obj.can_see=(System.Int32)val;
                        break;
                  case "level_inition":
                        _obj.level_inition=(System.Int32)val;
                        break;
                  case "level_max":
                        _obj.level_max=(System.Int32)val;
                        break;
                  case "levelup_available":
                        _obj.levelup_available=(System.Int32)val;
                        break;
                  case "levelup_type":
                        _obj.levelup_type=(System.Int32)val;
                        break;
                  case "icon":
                        _obj.icon=(System.String)val;
                        break;
                  case "outer_skill":
                        _obj.outer_skill=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "inner_skill":
                        _obj.inner_skill=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "shen_fa":
                        _obj.shen_fa=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "equipment_ids":
                        _obj.equipment_ids=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "bag_items_ids":
                        _obj.bag_items_ids=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "bag_item_num":
                        _obj.bag_item_num=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "charm_type":
                        _obj.charm_type=(System.Int32)val;
                        break;
                  case "charm_value":
                        _obj.charm_value=(System.Int32)val;
                        break;
                  case "location":
                        _obj.location=(System.Int32)val;
                        break;
                  case "model":
                        _obj.model=(System.Int32)val;
                        break;
                  case "npc_types":
                        _obj.npc_types=(System.Int32)val;
                        break;
                  case "can_competition":
                        _obj.can_competition=(System.Int32)val;
                        break;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            public override object GetValue(object obj)
            {
                var _obj = (NpcData)obj;
                switch (this.PropertyName)
                {
                   case "id":
                        return _obj.id;
                  case "npc_name":
                        return _obj.npc_name;
                  case "description":
                        return _obj.description;
                  case "level":
                        return _obj.level;
                  case "parent":
                        return _obj.parent;
                  case "broder":
                        return _obj.broder;
                  case "teacher":
                        return _obj.teacher;
                  case "partner":
                        return _obj.partner;
                  case "iron_friend":
                        return _obj.iron_friend;
                  case "child":
                        return _obj.child;
                  case "younger_generation":
                        return _obj.younger_generation;
                  case "apprentice":
                        return _obj.apprentice;
                  case "enjoy":
                        return _obj.enjoy;
                  case "believe":
                        return _obj.believe;
                  case "benefactor":
                        return _obj.benefactor;
                  case "disguise":
                        return _obj.disguise;
                  case "hate":
                        return _obj.hate;
                  case "hatred":
                        return _obj.hatred;
                  case "gen_gu":
                        return _obj.gen_gu;
                  case "wu_xing":
                        return _obj.wu_xing;
                  case "mood":
                        return _obj.mood;
                  case "health":
                        return _obj.health;
                  case "attack":
                        return _obj.attack;
                  case "defense":
                        return _obj.defense;
                  case "critical":
                        return _obj.critical;
                  case "hit":
                        return _obj.hit;
                  case "speed":
                        return _obj.speed;
                  case "dodge":
                        return _obj.dodge;
                  case "fight_back":
                        return _obj.fight_back;
                  case "earth":
                        return _obj.earth;
                  case "fire":
                        return _obj.fire;
                  case "water":
                        return _obj.water;
                  case "wind":
                        return _obj.wind;
                  case "lighting":
                        return _obj.lighting;
                  case "parry":
                        return _obj.parry;
                  case "star":
                        return _obj.star;
                  case "reputation":
                        return _obj.reputation;
                  case "reputation_value":
                        return _obj.reputation_value;
                  case "status":
                        return _obj.status;
                  case "status_value":
                        return _obj.status_value;
                  case "favorite":
                        return _obj.favorite;
                  case "age":
                        return _obj.age;
                  case "gender":
                        return _obj.gender;
                  case "can_see":
                        return _obj.can_see;
                  case "level_inition":
                        return _obj.level_inition;
                  case "level_max":
                        return _obj.level_max;
                  case "levelup_available":
                        return _obj.levelup_available;
                  case "levelup_type":
                        return _obj.levelup_type;
                  case "icon":
                        return _obj.icon;
                  case "outer_skill":
                        return _obj.outer_skill;
                  case "inner_skill":
                        return _obj.inner_skill;
                  case "shen_fa":
                        return _obj.shen_fa;
                  case "equipment_ids":
                        return _obj.equipment_ids;
                  case "bag_items_ids":
                        return _obj.bag_items_ids;
                  case "bag_item_num":
                        return _obj.bag_item_num;
                  case "charm_type":
                        return _obj.charm_type;
                  case "charm_value":
                        return _obj.charm_value;
                  case "location":
                        return _obj.location;
                  case "model":
                        return _obj.model;
                  case "npc_types":
                        return _obj.npc_types;
                  case "can_competition":
                        return _obj.can_competition;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            private object AutoCreateIns()
            {
                if(!this.IsAutoCreateIns)
                    return null;
                switch (this.PropertyName)
                {
                   case "parent":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "broder":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "teacher":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "partner":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "iron_friend":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "child":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "younger_generation":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "apprentice":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "enjoy":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "believe":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "benefactor":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "disguise":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "hate":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "hatred":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "outer_skill":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "inner_skill":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "shen_fa":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "equipment_ids":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "bag_items_ids":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "bag_item_num":
                        return new System.Collections.Generic.List<System.Int32>();

                    default:
                        return null;
                }
            }
        }
    }
    public class HeroDataMappingWarp : Sqlite3.TableMapping
    {
        //Ctor
        public HeroDataMappingWarp()
        {
            
            this.MappedType = typeof(HeroData);
            this.TableName = "HeroData";
            //Columns
            this.PK = new Column("id", typeof(System.Int32), "id", true, false, false, false, null, null, true);
            this.Columns = new[]
            {
                this.PK,
new Column("hero_name", typeof(System.String), "hero_name", false, false, false, false, null, null, true),
new Column("level", typeof(System.Int32), "level", false, false, false, false, null, null, true),
new Column("health", typeof(System.Int32), "health", false, false, false, false, null, null, true),
new Column("attack", typeof(System.Int32), "attack", false, false, false, false, null, null, true),
new Column("defense", typeof(System.Int32), "defense", false, false, false, false, null, null, true),
new Column("critical", typeof(System.Int32), "critical", false, false, false, false, null, null, true),
new Column("hit", typeof(System.Int32), "hit", false, false, false, false, null, null, true),
new Column("speed", typeof(System.Int32), "speed", false, false, false, false, null, null, true),
new Column("dodge", typeof(System.Int32), "dodge", false, false, false, false, null, null, true),
new Column("fight_back", typeof(System.Int32), "fight_back", false, false, false, false, null, null, true),
new Column("parry", typeof(System.Int32), "parry", false, false, false, false, null, null, true),
new Column("auto_skills", typeof(System.Collections.Generic.List<System.Int32>), "auto_skills", false, false, false, false, null, null, true),
new Column("auto_skills_round", typeof(System.Collections.Generic.List<System.Int32>), "auto_skills_round", false, false, false, false, null, null, true),
new Column("not_auto_skills", typeof(System.Collections.Generic.List<System.Int32>), "not_auto_skills", false, false, false, false, null, null, true),
new Column("not_auto_skills_round", typeof(System.Collections.Generic.List<System.Int32>), "not_auto_skills_round", false, false, false, false, null, null, true),
new Column("five_attribute", typeof(System.Int32), "five_attribute", false, false, false, false, null, null, true),
new Column("out_skill", typeof(System.Collections.Generic.List<System.Int32>), "out_skill", false, false, false, false, null, null, true),
new Column("inner_skill", typeof(System.Collections.Generic.List<System.Int32>), "inner_skill", false, false, false, false, null, null, true),
new Column("shenfa_skill", typeof(System.Collections.Generic.List<System.Int32>), "shenfa_skill", false, false, false, false, null, null, true),
new Column("model", typeof(System.Int32), "model", false, false, false, false, null, null, true),
new Column("occupation_type", typeof(System.Int32), "occupation_type", false, false, false, false, null, null, true),

            };

            this.GetByPrimaryKeySql = "SELECT * FROM \"HeroData\" WHERE \"id\" = ?";

        }
        //Column Ctor
        public class Column : Sqlite3.Column
        {
            public Column(string prop_name, System.Type prop_type,
                    string name,
                    bool pk, bool auto_inc, bool unique,
                    bool not_null, string def_value,
                    int? max_len,
                    bool auto_create_ins)
            {
                this.PropertyName = prop_name;
                this.ColumnType = prop_type;

                this.Name = name;
                this.IsPK = pk;
                this.IsAutoInc = auto_inc;
                this.IsUnique = unique;
                this.IsNotNull = not_null;
                this.DefaultValue = def_value;
                this.MaxLength = max_len;
                this.IsAutoCreateIns = auto_create_ins;
            }
            public override void SetValue(object obj, object val)
            {
                var _obj = (HeroData)obj;
                val = val ?? AutoCreateIns();
                switch (this.PropertyName)
                {
                   case "id":
                        _obj.id=(System.Int32)val;
                        break;
                  case "hero_name":
                        _obj.hero_name=(System.String)val;
                        break;
                  case "level":
                        _obj.level=(System.Int32)val;
                        break;
                  case "health":
                        _obj.health=(System.Int32)val;
                        break;
                  case "attack":
                        _obj.attack=(System.Int32)val;
                        break;
                  case "defense":
                        _obj.defense=(System.Int32)val;
                        break;
                  case "critical":
                        _obj.critical=(System.Int32)val;
                        break;
                  case "hit":
                        _obj.hit=(System.Int32)val;
                        break;
                  case "speed":
                        _obj.speed=(System.Int32)val;
                        break;
                  case "dodge":
                        _obj.dodge=(System.Int32)val;
                        break;
                  case "fight_back":
                        _obj.fight_back=(System.Int32)val;
                        break;
                  case "parry":
                        _obj.parry=(System.Int32)val;
                        break;
                  case "auto_skills":
                        _obj.auto_skills=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "auto_skills_round":
                        _obj.auto_skills_round=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "not_auto_skills":
                        _obj.not_auto_skills=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "not_auto_skills_round":
                        _obj.not_auto_skills_round=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "five_attribute":
                        _obj.five_attribute=(System.Int32)val;
                        break;
                  case "out_skill":
                        _obj.out_skill=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "inner_skill":
                        _obj.inner_skill=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "shenfa_skill":
                        _obj.shenfa_skill=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "model":
                        _obj.model=(System.Int32)val;
                        break;
                  case "occupation_type":
                        _obj.occupation_type=(System.Int32)val;
                        break;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            public override object GetValue(object obj)
            {
                var _obj = (HeroData)obj;
                switch (this.PropertyName)
                {
                   case "id":
                        return _obj.id;
                  case "hero_name":
                        return _obj.hero_name;
                  case "level":
                        return _obj.level;
                  case "health":
                        return _obj.health;
                  case "attack":
                        return _obj.attack;
                  case "defense":
                        return _obj.defense;
                  case "critical":
                        return _obj.critical;
                  case "hit":
                        return _obj.hit;
                  case "speed":
                        return _obj.speed;
                  case "dodge":
                        return _obj.dodge;
                  case "fight_back":
                        return _obj.fight_back;
                  case "parry":
                        return _obj.parry;
                  case "auto_skills":
                        return _obj.auto_skills;
                  case "auto_skills_round":
                        return _obj.auto_skills_round;
                  case "not_auto_skills":
                        return _obj.not_auto_skills;
                  case "not_auto_skills_round":
                        return _obj.not_auto_skills_round;
                  case "five_attribute":
                        return _obj.five_attribute;
                  case "out_skill":
                        return _obj.out_skill;
                  case "inner_skill":
                        return _obj.inner_skill;
                  case "shenfa_skill":
                        return _obj.shenfa_skill;
                  case "model":
                        return _obj.model;
                  case "occupation_type":
                        return _obj.occupation_type;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            private object AutoCreateIns()
            {
                if(!this.IsAutoCreateIns)
                    return null;
                switch (this.PropertyName)
                {
                   case "auto_skills":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "auto_skills_round":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "not_auto_skills":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "not_auto_skills_round":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "out_skill":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "inner_skill":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "shenfa_skill":
                        return new System.Collections.Generic.List<System.Int32>();

                    default:
                        return null;
                }
            }
        }
    }
    public class SkillDataMappingWarp : Sqlite3.TableMapping
    {
        //Ctor
        public SkillDataMappingWarp()
        {
            
            this.MappedType = typeof(SkillData);
            this.TableName = "SkillData";
            //Columns
            this.PK = new Column("id", typeof(System.Int32), "id", true, false, false, false, null, null, true);
            this.Columns = new[]
            {
                this.PK,
new Column("skill_id", typeof(System.Int32), "skill_id", false, false, false, false, null, null, true),
new Column("skill_name", typeof(System.String), "skill_name", false, false, false, false, null, null, true),
new Column("description", typeof(System.String), "description", false, false, false, false, null, null, true),
new Column("icon", typeof(System.String), "icon", false, false, false, false, null, null, true),
new Column("skill_type", typeof(System.Int32), "skill_type", false, false, false, false, null, null, true),
new Column("skill_round", typeof(System.Int32), "skill_round", false, false, false, false, null, null, true),
new Column("condition", typeof(System.Int32), "condition", false, false, false, false, null, null, true),
new Column("target", typeof(System.Int32), "target", false, false, false, false, null, null, true),
new Column("range", typeof(System.Int32), "range", false, false, false, false, null, null, true),
new Column("buff_id", typeof(System.Int32), "buff_id", false, false, false, false, null, null, true),
new Column("buff_target", typeof(System.Int32), "buff_target", false, false, false, false, null, null, true),
new Column("buff_range", typeof(System.Int32), "buff_range", false, false, false, false, null, null, true),
new Column("damage_type", typeof(System.Int32), "damage_type", false, false, false, false, null, null, true),
new Column("damage_ratio", typeof(System.Int32), "damage_ratio", false, false, false, false, null, null, true),
new Column("attribute_type", typeof(System.Int32), "attribute_type", false, false, false, false, null, null, true),
new Column("fire_sound", typeof(System.Int32), "fire_sound", false, false, false, false, null, null, true),
new Column("hurt_sound", typeof(System.String), "hurt_sound", false, false, false, false, null, null, true),
new Column("model", typeof(System.Int32), "model", false, false, false, false, null, null, true),

            };

            this.GetByPrimaryKeySql = "SELECT * FROM \"SkillData\" WHERE \"id\" = ?";

        }
        //Column Ctor
        public class Column : Sqlite3.Column
        {
            public Column(string prop_name, System.Type prop_type,
                    string name,
                    bool pk, bool auto_inc, bool unique,
                    bool not_null, string def_value,
                    int? max_len,
                    bool auto_create_ins)
            {
                this.PropertyName = prop_name;
                this.ColumnType = prop_type;

                this.Name = name;
                this.IsPK = pk;
                this.IsAutoInc = auto_inc;
                this.IsUnique = unique;
                this.IsNotNull = not_null;
                this.DefaultValue = def_value;
                this.MaxLength = max_len;
                this.IsAutoCreateIns = auto_create_ins;
            }
            public override void SetValue(object obj, object val)
            {
                var _obj = (SkillData)obj;
                val = val ?? AutoCreateIns();
                switch (this.PropertyName)
                {
                   case "id":
                        _obj.id=(System.Int32)val;
                        break;
                  case "skill_id":
                        _obj.skill_id=(System.Int32)val;
                        break;
                  case "skill_name":
                        _obj.skill_name=(System.String)val;
                        break;
                  case "description":
                        _obj.description=(System.String)val;
                        break;
                  case "icon":
                        _obj.icon=(System.String)val;
                        break;
                  case "skill_type":
                        _obj.skill_type=(System.Int32)val;
                        break;
                  case "skill_round":
                        _obj.skill_round=(System.Int32)val;
                        break;
                  case "condition":
                        _obj.condition=(System.Int32)val;
                        break;
                  case "target":
                        _obj.target=(System.Int32)val;
                        break;
                  case "range":
                        _obj.range=(System.Int32)val;
                        break;
                  case "buff_id":
                        _obj.buff_id=(System.Int32)val;
                        break;
                  case "buff_target":
                        _obj.buff_target=(System.Int32)val;
                        break;
                  case "buff_range":
                        _obj.buff_range=(System.Int32)val;
                        break;
                  case "damage_type":
                        _obj.damage_type=(System.Int32)val;
                        break;
                  case "damage_ratio":
                        _obj.damage_ratio=(System.Int32)val;
                        break;
                  case "attribute_type":
                        _obj.attribute_type=(System.Int32)val;
                        break;
                  case "fire_sound":
                        _obj.fire_sound=(System.Int32)val;
                        break;
                  case "hurt_sound":
                        _obj.hurt_sound=(System.String)val;
                        break;
                  case "model":
                        _obj.model=(System.Int32)val;
                        break;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            public override object GetValue(object obj)
            {
                var _obj = (SkillData)obj;
                switch (this.PropertyName)
                {
                   case "id":
                        return _obj.id;
                  case "skill_id":
                        return _obj.skill_id;
                  case "skill_name":
                        return _obj.skill_name;
                  case "description":
                        return _obj.description;
                  case "icon":
                        return _obj.icon;
                  case "skill_type":
                        return _obj.skill_type;
                  case "skill_round":
                        return _obj.skill_round;
                  case "condition":
                        return _obj.condition;
                  case "target":
                        return _obj.target;
                  case "range":
                        return _obj.range;
                  case "buff_id":
                        return _obj.buff_id;
                  case "buff_target":
                        return _obj.buff_target;
                  case "buff_range":
                        return _obj.buff_range;
                  case "damage_type":
                        return _obj.damage_type;
                  case "damage_ratio":
                        return _obj.damage_ratio;
                  case "attribute_type":
                        return _obj.attribute_type;
                  case "fire_sound":
                        return _obj.fire_sound;
                  case "hurt_sound":
                        return _obj.hurt_sound;
                  case "model":
                        return _obj.model;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            private object AutoCreateIns()
            {
                if(!this.IsAutoCreateIns)
                    return null;
                switch (this.PropertyName)
                {
 
                    default:
                        return null;
                }
            }
        }
    }
    public class SkillCompundDataMappingWarp : Sqlite3.TableMapping
    {
        //Ctor
        public SkillCompundDataMappingWarp()
        {
            
            this.MappedType = typeof(SkillCompundData);
            this.TableName = "SkillCompundData";
            //Columns
            this.PK = new Column("id", typeof(System.Int32), "id", true, false, false, false, null, null, true);
            this.Columns = new[]
            {
                this.PK,
new Column("skill_name", typeof(System.String), "skill_name", false, false, false, false, null, null, true),
new Column("type", typeof(System.Int32), "type", false, false, false, false, null, null, true),
new Column("desc", typeof(System.String), "desc", false, false, false, false, null, null, true),
new Column("skill_ids", typeof(System.Collections.Generic.List<System.Int32>), "skill_ids", false, false, false, false, null, null, true),
new Column("star", typeof(System.Int32), "star", false, false, false, false, null, null, true),
new Column("quality", typeof(System.Int32), "quality", false, false, false, false, null, null, true),
new Column("five_attribute", typeof(System.Int32), "five_attribute", false, false, false, false, null, null, true),
new Column("star_quality_limit", typeof(System.Int32), "star_quality_limit", false, false, false, false, null, null, true),

            };

            this.GetByPrimaryKeySql = "SELECT * FROM \"SkillCompundData\" WHERE \"id\" = ?";

        }
        //Column Ctor
        public class Column : Sqlite3.Column
        {
            public Column(string prop_name, System.Type prop_type,
                    string name,
                    bool pk, bool auto_inc, bool unique,
                    bool not_null, string def_value,
                    int? max_len,
                    bool auto_create_ins)
            {
                this.PropertyName = prop_name;
                this.ColumnType = prop_type;

                this.Name = name;
                this.IsPK = pk;
                this.IsAutoInc = auto_inc;
                this.IsUnique = unique;
                this.IsNotNull = not_null;
                this.DefaultValue = def_value;
                this.MaxLength = max_len;
                this.IsAutoCreateIns = auto_create_ins;
            }
            public override void SetValue(object obj, object val)
            {
                var _obj = (SkillCompundData)obj;
                val = val ?? AutoCreateIns();
                switch (this.PropertyName)
                {
                   case "id":
                        _obj.id=(System.Int32)val;
                        break;
                  case "skill_name":
                        _obj.skill_name=(System.String)val;
                        break;
                  case "type":
                        _obj.type=(System.Int32)val;
                        break;
                  case "desc":
                        _obj.desc=(System.String)val;
                        break;
                  case "skill_ids":
                        _obj.skill_ids=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "star":
                        _obj.star=(System.Int32)val;
                        break;
                  case "quality":
                        _obj.quality=(System.Int32)val;
                        break;
                  case "five_attribute":
                        _obj.five_attribute=(System.Int32)val;
                        break;
                  case "star_quality_limit":
                        _obj.star_quality_limit=(System.Int32)val;
                        break;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            public override object GetValue(object obj)
            {
                var _obj = (SkillCompundData)obj;
                switch (this.PropertyName)
                {
                   case "id":
                        return _obj.id;
                  case "skill_name":
                        return _obj.skill_name;
                  case "type":
                        return _obj.type;
                  case "desc":
                        return _obj.desc;
                  case "skill_ids":
                        return _obj.skill_ids;
                  case "star":
                        return _obj.star;
                  case "quality":
                        return _obj.quality;
                  case "five_attribute":
                        return _obj.five_attribute;
                  case "star_quality_limit":
                        return _obj.star_quality_limit;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            private object AutoCreateIns()
            {
                if(!this.IsAutoCreateIns)
                    return null;
                switch (this.PropertyName)
                {
                   case "skill_ids":
                        return new System.Collections.Generic.List<System.Int32>();

                    default:
                        return null;
                }
            }
        }
    }
    public class SkillCompoundQualityDataMappingWarp : Sqlite3.TableMapping
    {
        //Ctor
        public SkillCompoundQualityDataMappingWarp()
        {
            
            this.MappedType = typeof(SkillCompoundQualityData);
            this.TableName = "SkillCompoundQualityData";
            //Columns
            this.PK = new Column("id", typeof(System.Int32), "id", true, false, false, false, null, null, true);
            this.Columns = new[]
            {
                this.PK,
new Column("quality_level", typeof(System.Int32), "quality_level", false, false, false, false, null, null, true),
new Column("range", typeof(System.Int32[]), "range", false, false, false, false, null, null, true),
new Column("experience", typeof(System.Int32), "experience", false, false, false, false, null, null, true),
new Column("attribute_value", typeof(System.Int32), "attribute_value", false, false, false, false, null, null, true),
new Column("gold_cost", typeof(System.Int32), "gold_cost", false, false, false, false, null, null, true),

            };

            this.GetByPrimaryKeySql = "SELECT * FROM \"SkillCompoundQualityData\" WHERE \"id\" = ?";

        }
        //Column Ctor
        public class Column : Sqlite3.Column
        {
            public Column(string prop_name, System.Type prop_type,
                    string name,
                    bool pk, bool auto_inc, bool unique,
                    bool not_null, string def_value,
                    int? max_len,
                    bool auto_create_ins)
            {
                this.PropertyName = prop_name;
                this.ColumnType = prop_type;

                this.Name = name;
                this.IsPK = pk;
                this.IsAutoInc = auto_inc;
                this.IsUnique = unique;
                this.IsNotNull = not_null;
                this.DefaultValue = def_value;
                this.MaxLength = max_len;
                this.IsAutoCreateIns = auto_create_ins;
            }
            public override void SetValue(object obj, object val)
            {
                var _obj = (SkillCompoundQualityData)obj;
                val = val ?? AutoCreateIns();
                switch (this.PropertyName)
                {
                   case "id":
                        _obj.id=(System.Int32)val;
                        break;
                  case "quality_level":
                        _obj.quality_level=(System.Int32)val;
                        break;
                  case "range":
                        _obj.range=(System.Int32[])val;
                        break;
                  case "experience":
                        _obj.experience=(System.Int32)val;
                        break;
                  case "attribute_value":
                        _obj.attribute_value=(System.Int32)val;
                        break;
                  case "gold_cost":
                        _obj.gold_cost=(System.Int32)val;
                        break;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            public override object GetValue(object obj)
            {
                var _obj = (SkillCompoundQualityData)obj;
                switch (this.PropertyName)
                {
                   case "id":
                        return _obj.id;
                  case "quality_level":
                        return _obj.quality_level;
                  case "range":
                        return _obj.range;
                  case "experience":
                        return _obj.experience;
                  case "attribute_value":
                        return _obj.attribute_value;
                  case "gold_cost":
                        return _obj.gold_cost;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            private object AutoCreateIns()
            {
                if(!this.IsAutoCreateIns)
                    return null;
                switch (this.PropertyName)
                {
                   case "range":
                        return new System.Int32[0];

                    default:
                        return null;
                }
            }
        }
    }
    public class ItemUseDataMappingWarp : Sqlite3.TableMapping
    {
        //Ctor
        public ItemUseDataMappingWarp()
        {
            
            this.MappedType = typeof(ItemUseData);
            this.TableName = "ItemUseData";
            //Columns
            this.PK = new Column("id", typeof(System.Int32), "id", true, false, false, false, null, null, true);
            this.Columns = new[]
            {
                this.PK,
new Column("can_use", typeof(System.Int32), "can_use", false, false, false, false, null, null, true),
new Column("use_get_types", typeof(System.Collections.Generic.List<System.Int32>), "use_get_types", false, false, false, false, null, null, true),
new Column("use_get_ids", typeof(System.Collections.Generic.List<System.Int32>), "use_get_ids", false, false, false, false, null, null, true),
new Column("use_get_nums", typeof(System.Collections.Generic.List<System.Int32>), "use_get_nums", false, false, false, false, null, null, true),
new Column("gen_gu", typeof(System.Int32), "gen_gu", false, false, false, false, null, null, true),
new Column("wu_xing", typeof(System.Int32), "wu_xing", false, false, false, false, null, null, true),
new Column("mood", typeof(System.Int32), "mood", false, false, false, false, null, null, true),
new Column("health", typeof(System.Int32), "health", false, false, false, false, null, null, true),
new Column("attack", typeof(System.Int32), "attack", false, false, false, false, null, null, true),
new Column("defense", typeof(System.Int32), "defense", false, false, false, false, null, null, true),
new Column("critical", typeof(System.Int32), "critical", false, false, false, false, null, null, true),
new Column("hit", typeof(System.Int32), "hit", false, false, false, false, null, null, true),
new Column("speed", typeof(System.Int32), "speed", false, false, false, false, null, null, true),
new Column("dodge", typeof(System.Int32), "dodge", false, false, false, false, null, null, true),
new Column("fight_back", typeof(System.Int32), "fight_back", false, false, false, false, null, null, true),
new Column("earth", typeof(System.Int32), "earth", false, false, false, false, null, null, true),
new Column("fire", typeof(System.Int32), "fire", false, false, false, false, null, null, true),
new Column("water", typeof(System.Int32), "water", false, false, false, false, null, null, true),
new Column("wind", typeof(System.Int32), "wind", false, false, false, false, null, null, true),
new Column("lighting", typeof(System.Int32), "lighting", false, false, false, false, null, null, true),
new Column("parry", typeof(System.Int32), "parry", false, false, false, false, null, null, true),
new Column("health_rate", typeof(System.Int32), "health_rate", false, false, false, false, null, null, true),
new Column("dialog_npc_ids", typeof(System.Collections.Generic.List<System.Int32>), "dialog_npc_ids", false, false, false, false, null, null, true),
new Column("dialog_ids", typeof(System.Collections.Generic.List<System.Int32>), "dialog_ids", false, false, false, false, null, null, true),

            };

            this.GetByPrimaryKeySql = "SELECT * FROM \"ItemUseData\" WHERE \"id\" = ?";

        }
        //Column Ctor
        public class Column : Sqlite3.Column
        {
            public Column(string prop_name, System.Type prop_type,
                    string name,
                    bool pk, bool auto_inc, bool unique,
                    bool not_null, string def_value,
                    int? max_len,
                    bool auto_create_ins)
            {
                this.PropertyName = prop_name;
                this.ColumnType = prop_type;

                this.Name = name;
                this.IsPK = pk;
                this.IsAutoInc = auto_inc;
                this.IsUnique = unique;
                this.IsNotNull = not_null;
                this.DefaultValue = def_value;
                this.MaxLength = max_len;
                this.IsAutoCreateIns = auto_create_ins;
            }
            public override void SetValue(object obj, object val)
            {
                var _obj = (ItemUseData)obj;
                val = val ?? AutoCreateIns();
                switch (this.PropertyName)
                {
                   case "id":
                        _obj.id=(System.Int32)val;
                        break;
                  case "can_use":
                        _obj.can_use=(System.Int32)val;
                        break;
                  case "use_get_types":
                        _obj.use_get_types=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "use_get_ids":
                        _obj.use_get_ids=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "use_get_nums":
                        _obj.use_get_nums=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "gen_gu":
                        _obj.gen_gu=(System.Int32)val;
                        break;
                  case "wu_xing":
                        _obj.wu_xing=(System.Int32)val;
                        break;
                  case "mood":
                        _obj.mood=(System.Int32)val;
                        break;
                  case "health":
                        _obj.health=(System.Int32)val;
                        break;
                  case "attack":
                        _obj.attack=(System.Int32)val;
                        break;
                  case "defense":
                        _obj.defense=(System.Int32)val;
                        break;
                  case "critical":
                        _obj.critical=(System.Int32)val;
                        break;
                  case "hit":
                        _obj.hit=(System.Int32)val;
                        break;
                  case "speed":
                        _obj.speed=(System.Int32)val;
                        break;
                  case "dodge":
                        _obj.dodge=(System.Int32)val;
                        break;
                  case "fight_back":
                        _obj.fight_back=(System.Int32)val;
                        break;
                  case "earth":
                        _obj.earth=(System.Int32)val;
                        break;
                  case "fire":
                        _obj.fire=(System.Int32)val;
                        break;
                  case "water":
                        _obj.water=(System.Int32)val;
                        break;
                  case "wind":
                        _obj.wind=(System.Int32)val;
                        break;
                  case "lighting":
                        _obj.lighting=(System.Int32)val;
                        break;
                  case "parry":
                        _obj.parry=(System.Int32)val;
                        break;
                  case "health_rate":
                        _obj.health_rate=(System.Int32)val;
                        break;
                  case "dialog_npc_ids":
                        _obj.dialog_npc_ids=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "dialog_ids":
                        _obj.dialog_ids=(System.Collections.Generic.List<System.Int32>)val;
                        break;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            public override object GetValue(object obj)
            {
                var _obj = (ItemUseData)obj;
                switch (this.PropertyName)
                {
                   case "id":
                        return _obj.id;
                  case "can_use":
                        return _obj.can_use;
                  case "use_get_types":
                        return _obj.use_get_types;
                  case "use_get_ids":
                        return _obj.use_get_ids;
                  case "use_get_nums":
                        return _obj.use_get_nums;
                  case "gen_gu":
                        return _obj.gen_gu;
                  case "wu_xing":
                        return _obj.wu_xing;
                  case "mood":
                        return _obj.mood;
                  case "health":
                        return _obj.health;
                  case "attack":
                        return _obj.attack;
                  case "defense":
                        return _obj.defense;
                  case "critical":
                        return _obj.critical;
                  case "hit":
                        return _obj.hit;
                  case "speed":
                        return _obj.speed;
                  case "dodge":
                        return _obj.dodge;
                  case "fight_back":
                        return _obj.fight_back;
                  case "earth":
                        return _obj.earth;
                  case "fire":
                        return _obj.fire;
                  case "water":
                        return _obj.water;
                  case "wind":
                        return _obj.wind;
                  case "lighting":
                        return _obj.lighting;
                  case "parry":
                        return _obj.parry;
                  case "health_rate":
                        return _obj.health_rate;
                  case "dialog_npc_ids":
                        return _obj.dialog_npc_ids;
                  case "dialog_ids":
                        return _obj.dialog_ids;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            private object AutoCreateIns()
            {
                if(!this.IsAutoCreateIns)
                    return null;
                switch (this.PropertyName)
                {
                   case "use_get_types":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "use_get_ids":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "use_get_nums":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "dialog_npc_ids":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "dialog_ids":
                        return new System.Collections.Generic.List<System.Int32>();

                    default:
                        return null;
                }
            }
        }
    }
    public class UserInfoMappingWarp : Sqlite3.TableMapping
    {
        //Ctor
        public UserInfoMappingWarp()
        {
            
            this.MappedType = typeof(UserInfo);
            this.TableName = "UserInfo";
            //Columns
            this.PK = new Column("id", typeof(System.Int32), "id", true, false, false, false, null, null, true);
            this.Columns = new[]
            {
                this.PK,
new Column("playerID", typeof(System.Int32), "playerID", false, false, false, false, null, null, true),
new Column("gender", typeof(System.Int32), "gender", false, false, false, false, null, null, true),
new Column("playerName", typeof(System.String), "playerName", false, false, false, false, null, null, true),
new Column("roleName", typeof(System.String), "roleName", false, false, false, false, null, null, true),
new Column("jewel", typeof(System.Int32), "jewel", false, false, false, false, null, null, true),
new Column("copperCash", typeof(System.Int32), "copperCash", false, false, false, false, null, null, true),
new Column("exchangeStone", typeof(System.Int32), "exchangeStone", false, false, false, false, null, null, true),
new Column("level", typeof(System.Int32), "level", false, false, false, false, null, null, true),
new Column("health", typeof(System.Int32), "health", false, false, false, false, null, null, true),
new Column("attack", typeof(System.Int32), "attack", false, false, false, false, null, null, true),
new Column("defense", typeof(System.Int32), "defense", false, false, false, false, null, null, true),
new Column("critical", typeof(System.Int32), "critical", false, false, false, false, null, null, true),
new Column("hit", typeof(System.Int32), "hit", false, false, false, false, null, null, true),
new Column("speed", typeof(System.Int32), "speed", false, false, false, false, null, null, true),
new Column("dodge", typeof(System.Int32), "dodge", false, false, false, false, null, null, true),
new Column("fight_back", typeof(System.Int32), "fight_back", false, false, false, false, null, null, true),
new Column("isFirst", typeof(System.Int32), "isFirst", false, false, false, false, null, null, true),
new Column("parry", typeof(System.Int32), "parry", false, false, false, false, null, null, true),
new Column("earth", typeof(System.Int32), "earth", false, false, false, false, null, null, true),
new Column("fire", typeof(System.Int32), "fire", false, false, false, false, null, null, true),
new Column("water", typeof(System.Int32), "water", false, false, false, false, null, null, true),
new Column("wind", typeof(System.Int32), "wind", false, false, false, false, null, null, true),
new Column("xin_jing", typeof(System.Int32), "xin_jing", false, false, false, false, null, null, true),
new Column("light", typeof(System.Int32), "light", false, false, false, false, null, null, true),
new Column("reputation", typeof(System.String), "reputation", false, false, false, false, null, null, true),
new Column("power", typeof(System.Int32), "power", false, false, false, false, null, null, true),
new Column("zhouYiEnergy", typeof(System.Int32), "zhouYiEnergy", false, false, false, false, null, null, true),
new Column("liuYunMenScore", typeof(System.Int32), "liuYunMenScore", false, false, false, false, null, null, true),
new Column("changKongQiuShuiScore", typeof(System.Int32), "changKongQiuShuiScore", false, false, false, false, null, null, true),
new Column("star", typeof(System.Int32), "star", false, false, false, false, null, null, true),
new Column("mood", typeof(System.String), "mood", false, false, false, false, null, null, true),
new Column("charm", typeof(System.Int32), "charm", false, false, false, false, null, null, true),
new Column("state", typeof(System.Int32), "state", false, false, false, false, null, null, true),
new Column("gen_gu", typeof(System.Int32), "gen_gu", false, false, false, false, null, null, true),
new Column("wu_xing", typeof(System.Int32), "wu_xing", false, false, false, false, null, null, true),
new Column("status", typeof(System.Int32), "status", false, false, false, false, null, null, true),
new Column("age", typeof(System.Int32), "age", false, false, false, false, null, null, true),
new Column("favorite", typeof(System.Int32), "favorite", false, false, false, false, null, null, true),
new Column("robotEnergy", typeof(System.Int32), "robotEnergy", false, false, false, false, null, null, true),
new Column("robotLevel", typeof(System.Int32), "robotLevel", false, false, false, false, null, null, true),
new Column("signDay", typeof(System.Int32), "signDay", false, false, false, false, null, null, true),
new Column("isFinishChatting", typeof(System.Boolean), "isFinishChatting", false, false, false, false, null, null, true),
new Column("step", typeof(System.Int32), "step", false, false, false, false, null, null, true),
new Column("distance", typeof(System.Int32), "distance", false, false, false, false, null, null, true),
new Column("sleep", typeof(System.Int32), "sleep", false, false, false, false, null, null, true),
new Column("scene", typeof(System.Int32), "scene", false, false, false, false, null, null, true),
new Column("timeRemain", typeof(System.Single), "timeRemain", false, false, false, false, null, null, true),
new Column("realFiveElement", typeof(System.String), "realFiveElement", false, false, false, false, null, null, true),
new Column("goldAttribute", typeof(System.Int32), "goldAttribute", false, false, false, false, null, null, true),
new Column("woodAttribute", typeof(System.Int32), "woodAttribute", false, false, false, false, null, null, true),
new Column("waterAttribute", typeof(System.Int32), "waterAttribute", false, false, false, false, null, null, true),
new Column("earthAttribute", typeof(System.Int32), "earthAttribute", false, false, false, false, null, null, true),
new Column("fireAttribute", typeof(System.Int32), "fireAttribute", false, false, false, false, null, null, true),
new Column("currentExperience", typeof(System.Int32), "currentExperience", false, false, false, false, null, null, true),
new Column("currentNeedExperience", typeof(System.Int32), "currentNeedExperience", false, false, false, false, null, null, true),
new Column("totalStep", typeof(System.Double), "totalStep", false, false, false, false, null, null, true),
new Column("totalDistance", typeof(System.Double), "totalDistance", false, false, false, false, null, null, true),
new Column("unusedStepEnergy", typeof(System.Int32), "unusedStepEnergy", false, false, false, false, null, null, true),
new Column("unusedDistanceEnergy", typeof(System.Single), "unusedDistanceEnergy", false, false, false, false, null, null, true),
new Column("currentTask", typeof(System.Int32), "currentTask", false, false, false, false, null, null, true),
new Column("dicOutter", typeof(System.Collections.Generic.Dictionary<System.Int32,System.Int32>), "dicOutter", false, false, false, false, null, null, true),
new Column("dicInner", typeof(System.Collections.Generic.Dictionary<System.Int32,System.Int32>), "dicInner", false, false, false, false, null, null, true),
new Column("dicShenFa", typeof(System.Collections.Generic.Dictionary<System.Int32,System.Int32>), "dicShenFa", false, false, false, false, null, null, true),
new Column("hobby", typeof(System.String), "hobby", false, false, false, false, null, null, true),
new Column("currentTaskScene", typeof(System.Int32), "currentTaskScene", false, false, false, false, null, null, true),
new Column("outterEnergyTotal", typeof(System.Int32), "outterEnergyTotal", false, false, false, false, null, null, true),
new Column("innerEnergyTotal", typeof(System.Int32), "innerEnergyTotal", false, false, false, false, null, null, true),
new Column("shenFaEnergyTotal", typeof(System.Int32), "shenFaEnergyTotal", false, false, false, false, null, null, true),
new Column("outterEnergyLeft", typeof(System.Int32), "outterEnergyLeft", false, false, false, false, null, null, true),
new Column("innerEnergyLeft", typeof(System.Int32), "innerEnergyLeft", false, false, false, false, null, null, true),
new Column("shenFaEnergyLeft", typeof(System.Int32), "shenFaEnergyLeft", false, false, false, false, null, null, true),
new Column("physicalEnergy", typeof(System.Int32), "physicalEnergy", false, false, false, false, null, null, true),
new Column("lottery", typeof(System.Int32), "lottery", false, false, false, false, null, null, true),
new Column("meltScore", typeof(System.Int32), "meltScore", false, false, false, false, null, null, true),
new Column("friendScore", typeof(System.Int32), "friendScore", false, false, false, false, null, null, true),
new Column("reachLevelId", typeof(System.Int32), "reachLevelId", false, false, false, false, null, null, true),
new Column("storyId", typeof(System.Int32), "storyId", false, false, false, false, null, null, true),
new Column("screctStone", typeof(System.Int32), "screctStone", false, false, false, false, null, null, true),
new Column("dicTeam", typeof(System.Collections.Generic.Dictionary<System.Int32,System.Int32>), "dicTeam", false, false, false, false, null, null, true),
new Column("dicEquipment", typeof(System.Collections.Generic.Dictionary<System.Int32,System.Int32>), "dicEquipment", false, false, false, false, null, null, true),

            };

            this.GetByPrimaryKeySql = "SELECT * FROM \"UserInfo\" WHERE \"id\" = ?";

        }
        //Column Ctor
        public class Column : Sqlite3.Column
        {
            public Column(string prop_name, System.Type prop_type,
                    string name,
                    bool pk, bool auto_inc, bool unique,
                    bool not_null, string def_value,
                    int? max_len,
                    bool auto_create_ins)
            {
                this.PropertyName = prop_name;
                this.ColumnType = prop_type;

                this.Name = name;
                this.IsPK = pk;
                this.IsAutoInc = auto_inc;
                this.IsUnique = unique;
                this.IsNotNull = not_null;
                this.DefaultValue = def_value;
                this.MaxLength = max_len;
                this.IsAutoCreateIns = auto_create_ins;
            }
            public override void SetValue(object obj, object val)
            {
                var _obj = (UserInfo)obj;
                val = val ?? AutoCreateIns();
                switch (this.PropertyName)
                {
                   case "id":
                        _obj.id=(System.Int32)val;
                        break;
                  case "playerID":
                        _obj.playerID=(System.Int32)val;
                        break;
                  case "gender":
                        _obj.gender=(System.Int32)val;
                        break;
                  case "playerName":
                        _obj.playerName=(System.String)val;
                        break;
                  case "roleName":
                        _obj.roleName=(System.String)val;
                        break;
                  case "jewel":
                        _obj.jewel=(System.Int32)val;
                        break;
                  case "copperCash":
                        _obj.copperCash=(System.Int32)val;
                        break;
                  case "exchangeStone":
                        _obj.exchangeStone=(System.Int32)val;
                        break;
                  case "level":
                        _obj.level=(System.Int32)val;
                        break;
                  case "health":
                        _obj.health=(System.Int32)val;
                        break;
                  case "attack":
                        _obj.attack=(System.Int32)val;
                        break;
                  case "defense":
                        _obj.defense=(System.Int32)val;
                        break;
                  case "critical":
                        _obj.critical=(System.Int32)val;
                        break;
                  case "hit":
                        _obj.hit=(System.Int32)val;
                        break;
                  case "speed":
                        _obj.speed=(System.Int32)val;
                        break;
                  case "dodge":
                        _obj.dodge=(System.Int32)val;
                        break;
                  case "fight_back":
                        _obj.fight_back=(System.Int32)val;
                        break;
                  case "isFirst":
                        _obj.isFirst=(System.Int32)val;
                        break;
                  case "parry":
                        _obj.parry=(System.Int32)val;
                        break;
                  case "earth":
                        _obj.earth=(System.Int32)val;
                        break;
                  case "fire":
                        _obj.fire=(System.Int32)val;
                        break;
                  case "water":
                        _obj.water=(System.Int32)val;
                        break;
                  case "wind":
                        _obj.wind=(System.Int32)val;
                        break;
                  case "xin_jing":
                        _obj.xin_jing=(System.Int32)val;
                        break;
                  case "light":
                        _obj.light=(System.Int32)val;
                        break;
                  case "reputation":
                        _obj.reputation=(System.String)val;
                        break;
                  case "power":
                        _obj.power=(System.Int32)val;
                        break;
                  case "zhouYiEnergy":
                        _obj.zhouYiEnergy=(System.Int32)val;
                        break;
                  case "liuYunMenScore":
                        _obj.liuYunMenScore=(System.Int32)val;
                        break;
                  case "changKongQiuShuiScore":
                        _obj.changKongQiuShuiScore=(System.Int32)val;
                        break;
                  case "star":
                        _obj.star=(System.Int32)val;
                        break;
                  case "mood":
                        _obj.mood=(System.String)val;
                        break;
                  case "charm":
                        _obj.charm=(System.Int32)val;
                        break;
                  case "state":
                        _obj.state=(System.Int32)val;
                        break;
                  case "gen_gu":
                        _obj.gen_gu=(System.Int32)val;
                        break;
                  case "wu_xing":
                        _obj.wu_xing=(System.Int32)val;
                        break;
                  case "status":
                        _obj.status=(System.Int32)val;
                        break;
                  case "age":
                        _obj.age=(System.Int32)val;
                        break;
                  case "favorite":
                        _obj.favorite=(System.Int32)val;
                        break;
                  case "robotEnergy":
                        _obj.robotEnergy=(System.Int32)val;
                        break;
                  case "robotLevel":
                        _obj.robotLevel=(System.Int32)val;
                        break;
                  case "signDay":
                        _obj.signDay=(System.Int32)val;
                        break;
                  case "isFinishChatting":
                        _obj.isFinishChatting=(System.Boolean)val;
                        break;
                  case "step":
                        _obj.step=(System.Int32)val;
                        break;
                  case "distance":
                        _obj.distance=(System.Int32)val;
                        break;
                  case "sleep":
                        _obj.sleep=(System.Int32)val;
                        break;
                  case "scene":
                        _obj.scene=(System.Int32)val;
                        break;
                  case "timeRemain":
                        _obj.timeRemain=(System.Single)val;
                        break;
                  case "realFiveElement":
                        _obj.realFiveElement=(System.String)val;
                        break;
                  case "goldAttribute":
                        _obj.goldAttribute=(System.Int32)val;
                        break;
                  case "woodAttribute":
                        _obj.woodAttribute=(System.Int32)val;
                        break;
                  case "waterAttribute":
                        _obj.waterAttribute=(System.Int32)val;
                        break;
                  case "earthAttribute":
                        _obj.earthAttribute=(System.Int32)val;
                        break;
                  case "fireAttribute":
                        _obj.fireAttribute=(System.Int32)val;
                        break;
                  case "currentExperience":
                        _obj.currentExperience=(System.Int32)val;
                        break;
                  case "currentNeedExperience":
                        _obj.currentNeedExperience=(System.Int32)val;
                        break;
                  case "totalStep":
                        _obj.totalStep=(System.Double)val;
                        break;
                  case "totalDistance":
                        _obj.totalDistance=(System.Double)val;
                        break;
                  case "unusedStepEnergy":
                        _obj.unusedStepEnergy=(System.Int32)val;
                        break;
                  case "unusedDistanceEnergy":
                        _obj.unusedDistanceEnergy=(System.Single)val;
                        break;
                  case "currentTask":
                        _obj.currentTask=(System.Int32)val;
                        break;
                  case "dicOutter":
                        _obj.dicOutter=(System.Collections.Generic.Dictionary<System.Int32,System.Int32>)val;
                        break;
                  case "dicInner":
                        _obj.dicInner=(System.Collections.Generic.Dictionary<System.Int32,System.Int32>)val;
                        break;
                  case "dicShenFa":
                        _obj.dicShenFa=(System.Collections.Generic.Dictionary<System.Int32,System.Int32>)val;
                        break;
                  case "hobby":
                        _obj.hobby=(System.String)val;
                        break;
                  case "currentTaskScene":
                        _obj.currentTaskScene=(System.Int32)val;
                        break;
                  case "outterEnergyTotal":
                        _obj.outterEnergyTotal=(System.Int32)val;
                        break;
                  case "innerEnergyTotal":
                        _obj.innerEnergyTotal=(System.Int32)val;
                        break;
                  case "shenFaEnergyTotal":
                        _obj.shenFaEnergyTotal=(System.Int32)val;
                        break;
                  case "outterEnergyLeft":
                        _obj.outterEnergyLeft=(System.Int32)val;
                        break;
                  case "innerEnergyLeft":
                        _obj.innerEnergyLeft=(System.Int32)val;
                        break;
                  case "shenFaEnergyLeft":
                        _obj.shenFaEnergyLeft=(System.Int32)val;
                        break;
                  case "physicalEnergy":
                        _obj.physicalEnergy=(System.Int32)val;
                        break;
                  case "lottery":
                        _obj.lottery=(System.Int32)val;
                        break;
                  case "meltScore":
                        _obj.meltScore=(System.Int32)val;
                        break;
                  case "friendScore":
                        _obj.friendScore=(System.Int32)val;
                        break;
                  case "reachLevelId":
                        _obj.reachLevelId=(System.Int32)val;
                        break;
                  case "storyId":
                        _obj.storyId=(System.Int32)val;
                        break;
                  case "screctStone":
                        _obj.screctStone=(System.Int32)val;
                        break;
                  case "dicTeam":
                        _obj.dicTeam=(System.Collections.Generic.Dictionary<System.Int32,System.Int32>)val;
                        break;
                  case "dicEquipment":
                        _obj.dicEquipment=(System.Collections.Generic.Dictionary<System.Int32,System.Int32>)val;
                        break;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            public override object GetValue(object obj)
            {
                var _obj = (UserInfo)obj;
                switch (this.PropertyName)
                {
                   case "id":
                        return _obj.id;
                  case "playerID":
                        return _obj.playerID;
                  case "gender":
                        return _obj.gender;
                  case "playerName":
                        return _obj.playerName;
                  case "roleName":
                        return _obj.roleName;
                  case "jewel":
                        return _obj.jewel;
                  case "copperCash":
                        return _obj.copperCash;
                  case "exchangeStone":
                        return _obj.exchangeStone;
                  case "level":
                        return _obj.level;
                  case "health":
                        return _obj.health;
                  case "attack":
                        return _obj.attack;
                  case "defense":
                        return _obj.defense;
                  case "critical":
                        return _obj.critical;
                  case "hit":
                        return _obj.hit;
                  case "speed":
                        return _obj.speed;
                  case "dodge":
                        return _obj.dodge;
                  case "fight_back":
                        return _obj.fight_back;
                  case "isFirst":
                        return _obj.isFirst;
                  case "parry":
                        return _obj.parry;
                  case "earth":
                        return _obj.earth;
                  case "fire":
                        return _obj.fire;
                  case "water":
                        return _obj.water;
                  case "wind":
                        return _obj.wind;
                  case "xin_jing":
                        return _obj.xin_jing;
                  case "light":
                        return _obj.light;
                  case "reputation":
                        return _obj.reputation;
                  case "power":
                        return _obj.power;
                  case "zhouYiEnergy":
                        return _obj.zhouYiEnergy;
                  case "liuYunMenScore":
                        return _obj.liuYunMenScore;
                  case "changKongQiuShuiScore":
                        return _obj.changKongQiuShuiScore;
                  case "star":
                        return _obj.star;
                  case "mood":
                        return _obj.mood;
                  case "charm":
                        return _obj.charm;
                  case "state":
                        return _obj.state;
                  case "gen_gu":
                        return _obj.gen_gu;
                  case "wu_xing":
                        return _obj.wu_xing;
                  case "status":
                        return _obj.status;
                  case "age":
                        return _obj.age;
                  case "favorite":
                        return _obj.favorite;
                  case "robotEnergy":
                        return _obj.robotEnergy;
                  case "robotLevel":
                        return _obj.robotLevel;
                  case "signDay":
                        return _obj.signDay;
                  case "isFinishChatting":
                        return _obj.isFinishChatting;
                  case "step":
                        return _obj.step;
                  case "distance":
                        return _obj.distance;
                  case "sleep":
                        return _obj.sleep;
                  case "scene":
                        return _obj.scene;
                  case "timeRemain":
                        return _obj.timeRemain;
                  case "realFiveElement":
                        return _obj.realFiveElement;
                  case "goldAttribute":
                        return _obj.goldAttribute;
                  case "woodAttribute":
                        return _obj.woodAttribute;
                  case "waterAttribute":
                        return _obj.waterAttribute;
                  case "earthAttribute":
                        return _obj.earthAttribute;
                  case "fireAttribute":
                        return _obj.fireAttribute;
                  case "currentExperience":
                        return _obj.currentExperience;
                  case "currentNeedExperience":
                        return _obj.currentNeedExperience;
                  case "totalStep":
                        return _obj.totalStep;
                  case "totalDistance":
                        return _obj.totalDistance;
                  case "unusedStepEnergy":
                        return _obj.unusedStepEnergy;
                  case "unusedDistanceEnergy":
                        return _obj.unusedDistanceEnergy;
                  case "currentTask":
                        return _obj.currentTask;
                  case "dicOutter":
                        return _obj.dicOutter;
                  case "dicInner":
                        return _obj.dicInner;
                  case "dicShenFa":
                        return _obj.dicShenFa;
                  case "hobby":
                        return _obj.hobby;
                  case "currentTaskScene":
                        return _obj.currentTaskScene;
                  case "outterEnergyTotal":
                        return _obj.outterEnergyTotal;
                  case "innerEnergyTotal":
                        return _obj.innerEnergyTotal;
                  case "shenFaEnergyTotal":
                        return _obj.shenFaEnergyTotal;
                  case "outterEnergyLeft":
                        return _obj.outterEnergyLeft;
                  case "innerEnergyLeft":
                        return _obj.innerEnergyLeft;
                  case "shenFaEnergyLeft":
                        return _obj.shenFaEnergyLeft;
                  case "physicalEnergy":
                        return _obj.physicalEnergy;
                  case "lottery":
                        return _obj.lottery;
                  case "meltScore":
                        return _obj.meltScore;
                  case "friendScore":
                        return _obj.friendScore;
                  case "reachLevelId":
                        return _obj.reachLevelId;
                  case "storyId":
                        return _obj.storyId;
                  case "screctStone":
                        return _obj.screctStone;
                  case "dicTeam":
                        return _obj.dicTeam;
                  case "dicEquipment":
                        return _obj.dicEquipment;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            private object AutoCreateIns()
            {
                if(!this.IsAutoCreateIns)
                    return null;
                switch (this.PropertyName)
                {
                   case "dicOutter":
                        return new System.Collections.Generic.Dictionary<System.Int32,System.Int32>();
                  case "dicInner":
                        return new System.Collections.Generic.Dictionary<System.Int32,System.Int32>();
                  case "dicShenFa":
                        return new System.Collections.Generic.Dictionary<System.Int32,System.Int32>();
                  case "dicTeam":
                        return new System.Collections.Generic.Dictionary<System.Int32,System.Int32>();
                  case "dicEquipment":
                        return new System.Collections.Generic.Dictionary<System.Int32,System.Int32>();

                    default:
                        return null;
                }
            }
        }
    }
    public class GroceryShopDataMappingWarp : Sqlite3.TableMapping
    {
        //Ctor
        public GroceryShopDataMappingWarp()
        {
            
            this.MappedType = typeof(GroceryShopData);
            this.TableName = "GroceryShopData";
            //Columns
            this.PK = new Column("id", typeof(System.Int32), "id", true, false, false, false, null, null, true);
            this.Columns = new[]
            {
                this.PK,
new Column("item_type", typeof(System.Int32), "item_type", false, false, false, false, null, null, true),
new Column("item_id", typeof(System.Int32), "item_id", false, false, false, false, null, null, true),
new Column("item_num", typeof(System.Int32), "item_num", false, false, false, false, null, null, true),
new Column("money_type", typeof(System.Int32), "money_type", false, false, false, false, null, null, true),
new Column("money_single_cost", typeof(System.Int32), "money_single_cost", false, false, false, false, null, null, true),

            };

            this.GetByPrimaryKeySql = "SELECT * FROM \"GroceryShopData\" WHERE \"id\" = ?";

        }
        //Column Ctor
        public class Column : Sqlite3.Column
        {
            public Column(string prop_name, System.Type prop_type,
                    string name,
                    bool pk, bool auto_inc, bool unique,
                    bool not_null, string def_value,
                    int? max_len,
                    bool auto_create_ins)
            {
                this.PropertyName = prop_name;
                this.ColumnType = prop_type;

                this.Name = name;
                this.IsPK = pk;
                this.IsAutoInc = auto_inc;
                this.IsUnique = unique;
                this.IsNotNull = not_null;
                this.DefaultValue = def_value;
                this.MaxLength = max_len;
                this.IsAutoCreateIns = auto_create_ins;
            }
            public override void SetValue(object obj, object val)
            {
                var _obj = (GroceryShopData)obj;
                val = val ?? AutoCreateIns();
                switch (this.PropertyName)
                {
                   case "id":
                        _obj.id=(System.Int32)val;
                        break;
                  case "item_type":
                        _obj.item_type=(System.Int32)val;
                        break;
                  case "item_id":
                        _obj.item_id=(System.Int32)val;
                        break;
                  case "item_num":
                        _obj.item_num=(System.Int32)val;
                        break;
                  case "money_type":
                        _obj.money_type=(System.Int32)val;
                        break;
                  case "money_single_cost":
                        _obj.money_single_cost=(System.Int32)val;
                        break;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            public override object GetValue(object obj)
            {
                var _obj = (GroceryShopData)obj;
                switch (this.PropertyName)
                {
                   case "id":
                        return _obj.id;
                  case "item_type":
                        return _obj.item_type;
                  case "item_id":
                        return _obj.item_id;
                  case "item_num":
                        return _obj.item_num;
                  case "money_type":
                        return _obj.money_type;
                  case "money_single_cost":
                        return _obj.money_single_cost;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            private object AutoCreateIns()
            {
                if(!this.IsAutoCreateIns)
                    return null;
                switch (this.PropertyName)
                {
 
                    default:
                        return null;
                }
            }
        }
    }
    public class RealworldHeroDataMappingWarp : Sqlite3.TableMapping
    {
        //Ctor
        public RealworldHeroDataMappingWarp()
        {
            
            this.MappedType = typeof(RealworldHeroData);
            this.TableName = "RealworldHeroData";
            //Columns
            this.PK = new Column("id", typeof(System.Int32), "id", true, false, false, false, null, null, true);
            this.Columns = new[]
            {
                this.PK,
new Column("hero_name", typeof(System.String), "hero_name", false, false, false, false, null, null, true),
new Column("level", typeof(System.Int32), "level", false, false, false, false, null, null, true),
new Column("health", typeof(System.Single), "health", false, false, false, false, null, null, true),
new Column("attack", typeof(System.Single), "attack", false, false, false, false, null, null, true),
new Column("defense", typeof(System.Single), "defense", false, false, false, false, null, null, true),
new Column("critical", typeof(System.Single), "critical", false, false, false, false, null, null, true),
new Column("hit", typeof(System.Single), "hit", false, false, false, false, null, null, true),
new Column("speed", typeof(System.Single), "speed", false, false, false, false, null, null, true),
new Column("dodge", typeof(System.Single), "dodge", false, false, false, false, null, null, true),
new Column("fight_back", typeof(System.Single), "fight_back", false, false, false, false, null, null, true),
new Column("parry", typeof(System.Single), "parry", false, false, false, false, null, null, true),
new Column("auto_skills", typeof(System.Collections.Generic.List<System.Int32>), "auto_skills", false, false, false, false, null, null, true),
new Column("auto_skills_round", typeof(System.Collections.Generic.List<System.Int32>), "auto_skills_round", false, false, false, false, null, null, true),
new Column("not_auto_skills", typeof(System.Collections.Generic.List<System.Int32>), "not_auto_skills", false, false, false, false, null, null, true),
new Column("not_auto_skills_round", typeof(System.Collections.Generic.List<System.Int32>), "not_auto_skills_round", false, false, false, false, null, null, true),
new Column("five_attribute", typeof(System.Int32), "five_attribute", false, false, false, false, null, null, true),
new Column("out_skill", typeof(System.Collections.Generic.List<System.Int32>), "out_skill", false, false, false, false, null, null, true),
new Column("inner_skill", typeof(System.Collections.Generic.List<System.Int32>), "inner_skill", false, false, false, false, null, null, true),
new Column("shenfa_skill", typeof(System.Collections.Generic.List<System.Int32>), "shenfa_skill", false, false, false, false, null, null, true),
new Column("model", typeof(System.Int32), "model", false, false, false, false, null, null, true),
new Column("occupation_type", typeof(System.Int32), "occupation_type", false, false, false, false, null, null, true),
new Column("geniu_skill", typeof(System.Int32), "geniu_skill", false, false, false, false, null, null, true),
new Column("quality", typeof(System.Int32), "quality", false, false, false, false, null, null, true),
new Column("melt_types", typeof(System.Collections.Generic.List<System.Int32>), "melt_types", false, false, false, false, null, null, true),
new Column("melt_ids", typeof(System.Collections.Generic.List<System.Int32>), "melt_ids", false, false, false, false, null, null, true),
new Column("melt_nums", typeof(System.Collections.Generic.List<System.Int32>), "melt_nums", false, false, false, false, null, null, true),
new Column("oringin_star", typeof(System.Int32), "oringin_star", false, false, false, false, null, null, true),
new Column("star_max_limit", typeof(System.Int32), "star_max_limit", false, false, false, false, null, null, true),
new Column("b2_hero_id", typeof(System.Int32), "b2_hero_id", false, false, false, false, null, null, true),

            };

            this.GetByPrimaryKeySql = "SELECT * FROM \"RealworldHeroData\" WHERE \"id\" = ?";

        }
        //Column Ctor
        public class Column : Sqlite3.Column
        {
            public Column(string prop_name, System.Type prop_type,
                    string name,
                    bool pk, bool auto_inc, bool unique,
                    bool not_null, string def_value,
                    int? max_len,
                    bool auto_create_ins)
            {
                this.PropertyName = prop_name;
                this.ColumnType = prop_type;

                this.Name = name;
                this.IsPK = pk;
                this.IsAutoInc = auto_inc;
                this.IsUnique = unique;
                this.IsNotNull = not_null;
                this.DefaultValue = def_value;
                this.MaxLength = max_len;
                this.IsAutoCreateIns = auto_create_ins;
            }
            public override void SetValue(object obj, object val)
            {
                var _obj = (RealworldHeroData)obj;
                val = val ?? AutoCreateIns();
                switch (this.PropertyName)
                {
                   case "id":
                        _obj.id=(System.Int32)val;
                        break;
                  case "hero_name":
                        _obj.hero_name=(System.String)val;
                        break;
                  case "level":
                        _obj.level=(System.Int32)val;
                        break;
                  case "health":
                        _obj.health=(System.Single)val;
                        break;
                  case "attack":
                        _obj.attack=(System.Single)val;
                        break;
                  case "defense":
                        _obj.defense=(System.Single)val;
                        break;
                  case "critical":
                        _obj.critical=(System.Single)val;
                        break;
                  case "hit":
                        _obj.hit=(System.Single)val;
                        break;
                  case "speed":
                        _obj.speed=(System.Single)val;
                        break;
                  case "dodge":
                        _obj.dodge=(System.Single)val;
                        break;
                  case "fight_back":
                        _obj.fight_back=(System.Single)val;
                        break;
                  case "parry":
                        _obj.parry=(System.Single)val;
                        break;
                  case "auto_skills":
                        _obj.auto_skills=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "auto_skills_round":
                        _obj.auto_skills_round=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "not_auto_skills":
                        _obj.not_auto_skills=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "not_auto_skills_round":
                        _obj.not_auto_skills_round=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "five_attribute":
                        _obj.five_attribute=(System.Int32)val;
                        break;
                  case "out_skill":
                        _obj.out_skill=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "inner_skill":
                        _obj.inner_skill=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "shenfa_skill":
                        _obj.shenfa_skill=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "model":
                        _obj.model=(System.Int32)val;
                        break;
                  case "occupation_type":
                        _obj.occupation_type=(System.Int32)val;
                        break;
                  case "geniu_skill":
                        _obj.geniu_skill=(System.Int32)val;
                        break;
                  case "quality":
                        _obj.quality=(System.Int32)val;
                        break;
                  case "melt_types":
                        _obj.melt_types=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "melt_ids":
                        _obj.melt_ids=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "melt_nums":
                        _obj.melt_nums=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "oringin_star":
                        _obj.oringin_star=(System.Int32)val;
                        break;
                  case "star_max_limit":
                        _obj.star_max_limit=(System.Int32)val;
                        break;
                  case "b2_hero_id":
                        _obj.b2_hero_id=(System.Int32)val;
                        break;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            public override object GetValue(object obj)
            {
                var _obj = (RealworldHeroData)obj;
                switch (this.PropertyName)
                {
                   case "id":
                        return _obj.id;
                  case "hero_name":
                        return _obj.hero_name;
                  case "level":
                        return _obj.level;
                  case "health":
                        return _obj.health;
                  case "attack":
                        return _obj.attack;
                  case "defense":
                        return _obj.defense;
                  case "critical":
                        return _obj.critical;
                  case "hit":
                        return _obj.hit;
                  case "speed":
                        return _obj.speed;
                  case "dodge":
                        return _obj.dodge;
                  case "fight_back":
                        return _obj.fight_back;
                  case "parry":
                        return _obj.parry;
                  case "auto_skills":
                        return _obj.auto_skills;
                  case "auto_skills_round":
                        return _obj.auto_skills_round;
                  case "not_auto_skills":
                        return _obj.not_auto_skills;
                  case "not_auto_skills_round":
                        return _obj.not_auto_skills_round;
                  case "five_attribute":
                        return _obj.five_attribute;
                  case "out_skill":
                        return _obj.out_skill;
                  case "inner_skill":
                        return _obj.inner_skill;
                  case "shenfa_skill":
                        return _obj.shenfa_skill;
                  case "model":
                        return _obj.model;
                  case "occupation_type":
                        return _obj.occupation_type;
                  case "geniu_skill":
                        return _obj.geniu_skill;
                  case "quality":
                        return _obj.quality;
                  case "melt_types":
                        return _obj.melt_types;
                  case "melt_ids":
                        return _obj.melt_ids;
                  case "melt_nums":
                        return _obj.melt_nums;
                  case "oringin_star":
                        return _obj.oringin_star;
                  case "star_max_limit":
                        return _obj.star_max_limit;
                  case "b2_hero_id":
                        return _obj.b2_hero_id;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            private object AutoCreateIns()
            {
                if(!this.IsAutoCreateIns)
                    return null;
                switch (this.PropertyName)
                {
                   case "auto_skills":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "auto_skills_round":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "not_auto_skills":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "not_auto_skills_round":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "out_skill":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "inner_skill":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "shenfa_skill":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "melt_types":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "melt_ids":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "melt_nums":
                        return new System.Collections.Generic.List<System.Int32>();

                    default:
                        return null;
                }
            }
        }
    }
    public class RealworldHeroActiveSkillDataMappingWarp : Sqlite3.TableMapping
    {
        //Ctor
        public RealworldHeroActiveSkillDataMappingWarp()
        {
            
            this.MappedType = typeof(RealworldHeroActiveSkillData);
            this.TableName = "RealworldHeroActiveSkillData";
            //Columns
            this.PK = new Column("id", typeof(System.Int32), "id", true, false, false, false, null, null, true);
            this.Columns = new[]
            {
                this.PK,
new Column("star", typeof(System.Int32), "star", false, false, false, false, null, null, true),
new Column("card_slot_num", typeof(System.Int32), "card_slot_num", false, false, false, false, null, null, true),
new Column("card_open_num", typeof(System.Int32), "card_open_num", false, false, false, false, null, null, true),
new Column("card_fixed_num", typeof(System.Int32), "card_fixed_num", false, false, false, false, null, null, true),
new Column("card_change_num", typeof(System.Int32), "card_change_num", false, false, false, false, null, null, true),

            };

            this.GetByPrimaryKeySql = "SELECT * FROM \"RealworldHeroActiveSkillData\" WHERE \"id\" = ?";

        }
        //Column Ctor
        public class Column : Sqlite3.Column
        {
            public Column(string prop_name, System.Type prop_type,
                    string name,
                    bool pk, bool auto_inc, bool unique,
                    bool not_null, string def_value,
                    int? max_len,
                    bool auto_create_ins)
            {
                this.PropertyName = prop_name;
                this.ColumnType = prop_type;

                this.Name = name;
                this.IsPK = pk;
                this.IsAutoInc = auto_inc;
                this.IsUnique = unique;
                this.IsNotNull = not_null;
                this.DefaultValue = def_value;
                this.MaxLength = max_len;
                this.IsAutoCreateIns = auto_create_ins;
            }
            public override void SetValue(object obj, object val)
            {
                var _obj = (RealworldHeroActiveSkillData)obj;
                val = val ?? AutoCreateIns();
                switch (this.PropertyName)
                {
                   case "id":
                        _obj.id=(System.Int32)val;
                        break;
                  case "star":
                        _obj.star=(System.Int32)val;
                        break;
                  case "card_slot_num":
                        _obj.card_slot_num=(System.Int32)val;
                        break;
                  case "card_open_num":
                        _obj.card_open_num=(System.Int32)val;
                        break;
                  case "card_fixed_num":
                        _obj.card_fixed_num=(System.Int32)val;
                        break;
                  case "card_change_num":
                        _obj.card_change_num=(System.Int32)val;
                        break;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            public override object GetValue(object obj)
            {
                var _obj = (RealworldHeroActiveSkillData)obj;
                switch (this.PropertyName)
                {
                   case "id":
                        return _obj.id;
                  case "star":
                        return _obj.star;
                  case "card_slot_num":
                        return _obj.card_slot_num;
                  case "card_open_num":
                        return _obj.card_open_num;
                  case "card_fixed_num":
                        return _obj.card_fixed_num;
                  case "card_change_num":
                        return _obj.card_change_num;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            private object AutoCreateIns()
            {
                if(!this.IsAutoCreateIns)
                    return null;
                switch (this.PropertyName)
                {
 
                    default:
                        return null;
                }
            }
        }
    }
    public class RealworldHeroSummonDataMappingWarp : Sqlite3.TableMapping
    {
        //Ctor
        public RealworldHeroSummonDataMappingWarp()
        {
            
            this.MappedType = typeof(RealworldHeroSummonData);
            this.TableName = "RealworldHeroSummonData";
            //Columns
            this.PK = new Column("id", typeof(System.Int32), "id", true, false, false, false, null, null, true);
            this.Columns = new[]
            {
                this.PK,
new Column("hero_ids", typeof(System.Collections.Generic.List<System.Int32>), "hero_ids", false, false, false, false, null, null, true),
new Column("hero_probs", typeof(System.Collections.Generic.List<System.Single>), "hero_probs", false, false, false, false, null, null, true),
new Column("belong", typeof(System.Int32), "belong", false, false, false, false, null, null, true),
new Column("unit_cost_types", typeof(System.Collections.Generic.List<System.Int32>), "unit_cost_types", false, false, false, false, null, null, true),
new Column("unit_cost_nums", typeof(System.Collections.Generic.List<System.Int32>), "unit_cost_nums", false, false, false, false, null, null, true),
new Column("ten_cost_types", typeof(System.Collections.Generic.List<System.Int32>), "ten_cost_types", false, false, false, false, null, null, true),
new Column("ten_cost_nums", typeof(System.Collections.Generic.List<System.Int32>), "ten_cost_nums", false, false, false, false, null, null, true),
new Column("free_summon_num", typeof(System.Int32), "free_summon_num", false, false, false, false, null, null, true),
new Column("refresh_time", typeof(System.String), "refresh_time", false, false, false, false, null, null, true),
new Column("max_summon", typeof(System.Int32), "max_summon", false, false, false, false, null, null, true),
new Column("sure_gain_num", typeof(System.Int32), "sure_gain_num", false, false, false, false, null, null, true),

            };

            this.GetByPrimaryKeySql = "SELECT * FROM \"RealworldHeroSummonData\" WHERE \"id\" = ?";

        }
        //Column Ctor
        public class Column : Sqlite3.Column
        {
            public Column(string prop_name, System.Type prop_type,
                    string name,
                    bool pk, bool auto_inc, bool unique,
                    bool not_null, string def_value,
                    int? max_len,
                    bool auto_create_ins)
            {
                this.PropertyName = prop_name;
                this.ColumnType = prop_type;

                this.Name = name;
                this.IsPK = pk;
                this.IsAutoInc = auto_inc;
                this.IsUnique = unique;
                this.IsNotNull = not_null;
                this.DefaultValue = def_value;
                this.MaxLength = max_len;
                this.IsAutoCreateIns = auto_create_ins;
            }
            public override void SetValue(object obj, object val)
            {
                var _obj = (RealworldHeroSummonData)obj;
                val = val ?? AutoCreateIns();
                switch (this.PropertyName)
                {
                   case "id":
                        _obj.id=(System.Int32)val;
                        break;
                  case "hero_ids":
                        _obj.hero_ids=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "hero_probs":
                        _obj.hero_probs=(System.Collections.Generic.List<System.Single>)val;
                        break;
                  case "belong":
                        _obj.belong=(System.Int32)val;
                        break;
                  case "unit_cost_types":
                        _obj.unit_cost_types=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "unit_cost_nums":
                        _obj.unit_cost_nums=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "ten_cost_types":
                        _obj.ten_cost_types=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "ten_cost_nums":
                        _obj.ten_cost_nums=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "free_summon_num":
                        _obj.free_summon_num=(System.Int32)val;
                        break;
                  case "refresh_time":
                        _obj.refresh_time=(System.String)val;
                        break;
                  case "max_summon":
                        _obj.max_summon=(System.Int32)val;
                        break;
                  case "sure_gain_num":
                        _obj.sure_gain_num=(System.Int32)val;
                        break;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            public override object GetValue(object obj)
            {
                var _obj = (RealworldHeroSummonData)obj;
                switch (this.PropertyName)
                {
                   case "id":
                        return _obj.id;
                  case "hero_ids":
                        return _obj.hero_ids;
                  case "hero_probs":
                        return _obj.hero_probs;
                  case "belong":
                        return _obj.belong;
                  case "unit_cost_types":
                        return _obj.unit_cost_types;
                  case "unit_cost_nums":
                        return _obj.unit_cost_nums;
                  case "ten_cost_types":
                        return _obj.ten_cost_types;
                  case "ten_cost_nums":
                        return _obj.ten_cost_nums;
                  case "free_summon_num":
                        return _obj.free_summon_num;
                  case "refresh_time":
                        return _obj.refresh_time;
                  case "max_summon":
                        return _obj.max_summon;
                  case "sure_gain_num":
                        return _obj.sure_gain_num;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            private object AutoCreateIns()
            {
                if(!this.IsAutoCreateIns)
                    return null;
                switch (this.PropertyName)
                {
                   case "hero_ids":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "hero_probs":
                        return new System.Collections.Generic.List<System.Single>();
                  case "unit_cost_types":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "unit_cost_nums":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "ten_cost_types":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "ten_cost_nums":
                        return new System.Collections.Generic.List<System.Int32>();

                    default:
                        return null;
                }
            }
        }
    }
    public class RealworldHeroUpgradeStarDataMappingWarp : Sqlite3.TableMapping
    {
        //Ctor
        public RealworldHeroUpgradeStarDataMappingWarp()
        {
            
            this.MappedType = typeof(RealworldHeroUpgradeStarData);
            this.TableName = "RealworldHeroUpgradeStarData";
            //Columns
            this.PK = new Column("id", typeof(System.Int32), "id", true, false, false, false, null, null, true);
            this.Columns = new[]
            {
                this.PK,
new Column("star_start", typeof(System.Int32), "star_start", false, false, false, false, null, null, true),
new Column("consume_hero_star", typeof(System.Int32), "consume_hero_star", false, false, false, false, null, null, true),
new Column("consume_hero_type", typeof(System.Int32), "consume_hero_type", false, false, false, false, null, null, true),
new Column("consume_hero_num", typeof(System.Int32), "consume_hero_num", false, false, false, false, null, null, true),

            };

            this.GetByPrimaryKeySql = "SELECT * FROM \"RealworldHeroUpgradeStarData\" WHERE \"id\" = ?";

        }
        //Column Ctor
        public class Column : Sqlite3.Column
        {
            public Column(string prop_name, System.Type prop_type,
                    string name,
                    bool pk, bool auto_inc, bool unique,
                    bool not_null, string def_value,
                    int? max_len,
                    bool auto_create_ins)
            {
                this.PropertyName = prop_name;
                this.ColumnType = prop_type;

                this.Name = name;
                this.IsPK = pk;
                this.IsAutoInc = auto_inc;
                this.IsUnique = unique;
                this.IsNotNull = not_null;
                this.DefaultValue = def_value;
                this.MaxLength = max_len;
                this.IsAutoCreateIns = auto_create_ins;
            }
            public override void SetValue(object obj, object val)
            {
                var _obj = (RealworldHeroUpgradeStarData)obj;
                val = val ?? AutoCreateIns();
                switch (this.PropertyName)
                {
                   case "id":
                        _obj.id=(System.Int32)val;
                        break;
                  case "star_start":
                        _obj.star_start=(System.Int32)val;
                        break;
                  case "consume_hero_star":
                        _obj.consume_hero_star=(System.Int32)val;
                        break;
                  case "consume_hero_type":
                        _obj.consume_hero_type=(System.Int32)val;
                        break;
                  case "consume_hero_num":
                        _obj.consume_hero_num=(System.Int32)val;
                        break;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            public override object GetValue(object obj)
            {
                var _obj = (RealworldHeroUpgradeStarData)obj;
                switch (this.PropertyName)
                {
                   case "id":
                        return _obj.id;
                  case "star_start":
                        return _obj.star_start;
                  case "consume_hero_star":
                        return _obj.consume_hero_star;
                  case "consume_hero_type":
                        return _obj.consume_hero_type;
                  case "consume_hero_num":
                        return _obj.consume_hero_num;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            private object AutoCreateIns()
            {
                if(!this.IsAutoCreateIns)
                    return null;
                switch (this.PropertyName)
                {
 
                    default:
                        return null;
                }
            }
        }
    }
    public class RealworldRelateB2DataMappingWarp : Sqlite3.TableMapping
    {
        //Ctor
        public RealworldRelateB2DataMappingWarp()
        {
            
            this.MappedType = typeof(RealworldRelateB2Data);
            this.TableName = "RealworldRelateB2Data";
            //Columns
            this.PK = new Column("id", typeof(System.Int32), "id", true, false, false, false, null, null, true);
            this.Columns = new[]
            {
                this.PK,
new Column("realworld_hero_id", typeof(System.Int32), "realworld_hero_id", false, false, false, false, null, null, true),
new Column("b2_hero_id", typeof(System.Int32), "b2_hero_id", false, false, false, false, null, null, true),

            };

            this.GetByPrimaryKeySql = "SELECT * FROM \"RealworldRelateB2Data\" WHERE \"id\" = ?";

        }
        //Column Ctor
        public class Column : Sqlite3.Column
        {
            public Column(string prop_name, System.Type prop_type,
                    string name,
                    bool pk, bool auto_inc, bool unique,
                    bool not_null, string def_value,
                    int? max_len,
                    bool auto_create_ins)
            {
                this.PropertyName = prop_name;
                this.ColumnType = prop_type;

                this.Name = name;
                this.IsPK = pk;
                this.IsAutoInc = auto_inc;
                this.IsUnique = unique;
                this.IsNotNull = not_null;
                this.DefaultValue = def_value;
                this.MaxLength = max_len;
                this.IsAutoCreateIns = auto_create_ins;
            }
            public override void SetValue(object obj, object val)
            {
                var _obj = (RealworldRelateB2Data)obj;
                val = val ?? AutoCreateIns();
                switch (this.PropertyName)
                {
                   case "id":
                        _obj.id=(System.Int32)val;
                        break;
                  case "realworld_hero_id":
                        _obj.realworld_hero_id=(System.Int32)val;
                        break;
                  case "b2_hero_id":
                        _obj.b2_hero_id=(System.Int32)val;
                        break;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            public override object GetValue(object obj)
            {
                var _obj = (RealworldRelateB2Data)obj;
                switch (this.PropertyName)
                {
                   case "id":
                        return _obj.id;
                  case "realworld_hero_id":
                        return _obj.realworld_hero_id;
                  case "b2_hero_id":
                        return _obj.b2_hero_id;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            private object AutoCreateIns()
            {
                if(!this.IsAutoCreateIns)
                    return null;
                switch (this.PropertyName)
                {
 
                    default:
                        return null;
                }
            }
        }
    }
    public class RealworldUnionDataMappingWarp : Sqlite3.TableMapping
    {
        //Ctor
        public RealworldUnionDataMappingWarp()
        {
            
            this.MappedType = typeof(RealworldUnionData);
            this.TableName = "RealworldUnionData";
            //Columns
            this.PK = new Column("id", typeof(System.Int32), "id", true, false, false, false, null, null, true);
            this.Columns = new[]
            {
                this.PK,
new Column("specify", typeof(System.Int32), "specify", false, false, false, false, null, null, true),
new Column("num", typeof(System.Int32), "num", false, false, false, false, null, null, true),
new Column("health", typeof(System.Int32), "health", false, false, false, false, null, null, true),
new Column("attack", typeof(System.Int32), "attack", false, false, false, false, null, null, true),
new Column("defense", typeof(System.Int32), "defense", false, false, false, false, null, null, true),
new Column("critical", typeof(System.Int32), "critical", false, false, false, false, null, null, true),
new Column("hit", typeof(System.Int32), "hit", false, false, false, false, null, null, true),
new Column("speed", typeof(System.Int32), "speed", false, false, false, false, null, null, true),
new Column("dodge", typeof(System.Int32), "dodge", false, false, false, false, null, null, true),
new Column("fight_back", typeof(System.Int32), "fight_back", false, false, false, false, null, null, true),
new Column("parry", typeof(System.Int32), "parry", false, false, false, false, null, null, true),
new Column("energy_change", typeof(System.Int32), "energy_change", false, false, false, false, null, null, true),

            };

            this.GetByPrimaryKeySql = "SELECT * FROM \"RealworldUnionData\" WHERE \"id\" = ?";

        }
        //Column Ctor
        public class Column : Sqlite3.Column
        {
            public Column(string prop_name, System.Type prop_type,
                    string name,
                    bool pk, bool auto_inc, bool unique,
                    bool not_null, string def_value,
                    int? max_len,
                    bool auto_create_ins)
            {
                this.PropertyName = prop_name;
                this.ColumnType = prop_type;

                this.Name = name;
                this.IsPK = pk;
                this.IsAutoInc = auto_inc;
                this.IsUnique = unique;
                this.IsNotNull = not_null;
                this.DefaultValue = def_value;
                this.MaxLength = max_len;
                this.IsAutoCreateIns = auto_create_ins;
            }
            public override void SetValue(object obj, object val)
            {
                var _obj = (RealworldUnionData)obj;
                val = val ?? AutoCreateIns();
                switch (this.PropertyName)
                {
                   case "id":
                        _obj.id=(System.Int32)val;
                        break;
                  case "specify":
                        _obj.specify=(System.Int32)val;
                        break;
                  case "num":
                        _obj.num=(System.Int32)val;
                        break;
                  case "health":
                        _obj.health=(System.Int32)val;
                        break;
                  case "attack":
                        _obj.attack=(System.Int32)val;
                        break;
                  case "defense":
                        _obj.defense=(System.Int32)val;
                        break;
                  case "critical":
                        _obj.critical=(System.Int32)val;
                        break;
                  case "hit":
                        _obj.hit=(System.Int32)val;
                        break;
                  case "speed":
                        _obj.speed=(System.Int32)val;
                        break;
                  case "dodge":
                        _obj.dodge=(System.Int32)val;
                        break;
                  case "fight_back":
                        _obj.fight_back=(System.Int32)val;
                        break;
                  case "parry":
                        _obj.parry=(System.Int32)val;
                        break;
                  case "energy_change":
                        _obj.energy_change=(System.Int32)val;
                        break;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            public override object GetValue(object obj)
            {
                var _obj = (RealworldUnionData)obj;
                switch (this.PropertyName)
                {
                   case "id":
                        return _obj.id;
                  case "specify":
                        return _obj.specify;
                  case "num":
                        return _obj.num;
                  case "health":
                        return _obj.health;
                  case "attack":
                        return _obj.attack;
                  case "defense":
                        return _obj.defense;
                  case "critical":
                        return _obj.critical;
                  case "hit":
                        return _obj.hit;
                  case "speed":
                        return _obj.speed;
                  case "dodge":
                        return _obj.dodge;
                  case "fight_back":
                        return _obj.fight_back;
                  case "parry":
                        return _obj.parry;
                  case "energy_change":
                        return _obj.energy_change;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            private object AutoCreateIns()
            {
                if(!this.IsAutoCreateIns)
                    return null;
                switch (this.PropertyName)
                {
 
                    default:
                        return null;
                }
            }
        }
    }
    public class TaskRealworldDailyDataMappingWarp : Sqlite3.TableMapping
    {
        //Ctor
        public TaskRealworldDailyDataMappingWarp()
        {
            
            this.MappedType = typeof(TaskRealworldDailyData);
            this.TableName = "TaskRealworldDailyData";
            //Columns
            this.PK = new Column("id", typeof(System.Int32), "id", true, false, false, false, null, null, true);
            this.Columns = new[]
            {
                this.PK,
new Column("task_name", typeof(System.String), "task_name", false, false, false, false, null, null, true),
new Column("description", typeof(System.String), "description", false, false, false, false, null, null, true),
new Column("icon", typeof(System.String), "icon", false, false, false, false, null, null, true),
new Column("limit_level", typeof(System.Int32), "limit_level", false, false, false, false, null, null, true),
new Column("action_type", typeof(System.Int32), "action_type", false, false, false, false, null, null, true),
new Column("action_num", typeof(System.Collections.Generic.List<System.Int32>), "action_num", false, false, false, false, null, null, true),
new Column("recept_scene", typeof(System.Int32), "recept_scene", false, false, false, false, null, null, true),
new Column("reward_types", typeof(System.Collections.Generic.List<System.Int32>), "reward_types", false, false, false, false, null, null, true),
new Column("reward_ids", typeof(System.Collections.Generic.List<System.Int32>), "reward_ids", false, false, false, false, null, null, true),
new Column("reward_numbers", typeof(System.Collections.Generic.List<System.Int32>), "reward_numbers", false, false, false, false, null, null, true),
new Column("type", typeof(System.Int32), "type", false, false, false, false, null, null, true),

            };

            this.GetByPrimaryKeySql = "SELECT * FROM \"TaskRealworldDailyData\" WHERE \"id\" = ?";

        }
        //Column Ctor
        public class Column : Sqlite3.Column
        {
            public Column(string prop_name, System.Type prop_type,
                    string name,
                    bool pk, bool auto_inc, bool unique,
                    bool not_null, string def_value,
                    int? max_len,
                    bool auto_create_ins)
            {
                this.PropertyName = prop_name;
                this.ColumnType = prop_type;

                this.Name = name;
                this.IsPK = pk;
                this.IsAutoInc = auto_inc;
                this.IsUnique = unique;
                this.IsNotNull = not_null;
                this.DefaultValue = def_value;
                this.MaxLength = max_len;
                this.IsAutoCreateIns = auto_create_ins;
            }
            public override void SetValue(object obj, object val)
            {
                var _obj = (TaskRealworldDailyData)obj;
                val = val ?? AutoCreateIns();
                switch (this.PropertyName)
                {
                   case "id":
                        _obj.id=(System.Int32)val;
                        break;
                  case "task_name":
                        _obj.task_name=(System.String)val;
                        break;
                  case "description":
                        _obj.description=(System.String)val;
                        break;
                  case "icon":
                        _obj.icon=(System.String)val;
                        break;
                  case "limit_level":
                        _obj.limit_level=(System.Int32)val;
                        break;
                  case "action_type":
                        _obj.action_type=(System.Int32)val;
                        break;
                  case "action_num":
                        _obj.action_num=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "recept_scene":
                        _obj.recept_scene=(System.Int32)val;
                        break;
                  case "reward_types":
                        _obj.reward_types=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "reward_ids":
                        _obj.reward_ids=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "reward_numbers":
                        _obj.reward_numbers=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "type":
                        _obj.type=(System.Int32)val;
                        break;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            public override object GetValue(object obj)
            {
                var _obj = (TaskRealworldDailyData)obj;
                switch (this.PropertyName)
                {
                   case "id":
                        return _obj.id;
                  case "task_name":
                        return _obj.task_name;
                  case "description":
                        return _obj.description;
                  case "icon":
                        return _obj.icon;
                  case "limit_level":
                        return _obj.limit_level;
                  case "action_type":
                        return _obj.action_type;
                  case "action_num":
                        return _obj.action_num;
                  case "recept_scene":
                        return _obj.recept_scene;
                  case "reward_types":
                        return _obj.reward_types;
                  case "reward_ids":
                        return _obj.reward_ids;
                  case "reward_numbers":
                        return _obj.reward_numbers;
                  case "type":
                        return _obj.type;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            private object AutoCreateIns()
            {
                if(!this.IsAutoCreateIns)
                    return null;
                switch (this.PropertyName)
                {
                   case "action_num":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "reward_types":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "reward_ids":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "reward_numbers":
                        return new System.Collections.Generic.List<System.Int32>();

                    default:
                        return null;
                }
            }
        }
    }
    public class ForbiddenDataMappingWarp : Sqlite3.TableMapping
    {
        //Ctor
        public ForbiddenDataMappingWarp()
        {
            
            this.MappedType = typeof(ForbiddenData);
            this.TableName = "ForbiddenData";
            //Columns
            this.PK = new Column("id", typeof(System.Int32), "id", true, false, false, false, null, null, true);
            this.Columns = new[]
            {
                this.PK,
new Column("type", typeof(System.String), "type", false, false, false, false, null, null, true),
new Column("word", typeof(System.String), "word", false, false, false, false, null, null, true),

            };

            this.GetByPrimaryKeySql = "SELECT * FROM \"ForbiddenData\" WHERE \"id\" = ?";

        }
        //Column Ctor
        public class Column : Sqlite3.Column
        {
            public Column(string prop_name, System.Type prop_type,
                    string name,
                    bool pk, bool auto_inc, bool unique,
                    bool not_null, string def_value,
                    int? max_len,
                    bool auto_create_ins)
            {
                this.PropertyName = prop_name;
                this.ColumnType = prop_type;

                this.Name = name;
                this.IsPK = pk;
                this.IsAutoInc = auto_inc;
                this.IsUnique = unique;
                this.IsNotNull = not_null;
                this.DefaultValue = def_value;
                this.MaxLength = max_len;
                this.IsAutoCreateIns = auto_create_ins;
            }
            public override void SetValue(object obj, object val)
            {
                var _obj = (ForbiddenData)obj;
                val = val ?? AutoCreateIns();
                switch (this.PropertyName)
                {
                   case "id":
                        _obj.id=(System.Int32)val;
                        break;
                  case "type":
                        _obj.type=(System.String)val;
                        break;
                  case "word":
                        _obj.word=(System.String)val;
                        break;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            public override object GetValue(object obj)
            {
                var _obj = (ForbiddenData)obj;
                switch (this.PropertyName)
                {
                   case "id":
                        return _obj.id;
                  case "type":
                        return _obj.type;
                  case "word":
                        return _obj.word;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            private object AutoCreateIns()
            {
                if(!this.IsAutoCreateIns)
                    return null;
                switch (this.PropertyName)
                {
 
                    default:
                        return null;
                }
            }
        }
    }
    public class RealworldAccidentDataMappingWarp : Sqlite3.TableMapping
    {
        //Ctor
        public RealworldAccidentDataMappingWarp()
        {
            
            this.MappedType = typeof(RealworldAccidentData);
            this.TableName = "RealworldAccidentData";
            //Columns
            this.PK = new Column("id", typeof(System.Int32), "id", true, false, false, false, null, null, true);
            this.Columns = new[]
            {
                this.PK,
new Column("robot_star", typeof(System.Int32), "robot_star", false, false, false, false, null, null, true),
new Column("robot_num", typeof(System.Int32), "robot_num", false, false, false, false, null, null, true),
new Column("item_ids", typeof(System.Collections.Generic.List<System.Int32>), "item_ids", false, false, false, false, null, null, true),
new Column("item_probs", typeof(System.Collections.Generic.List<System.Int32>), "item_probs", false, false, false, false, null, null, true),
new Column("item_nums", typeof(System.Collections.Generic.List<System.Int32>), "item_nums", false, false, false, false, null, null, true),

            };

            this.GetByPrimaryKeySql = "SELECT * FROM \"RealworldAccidentData\" WHERE \"id\" = ?";

        }
        //Column Ctor
        public class Column : Sqlite3.Column
        {
            public Column(string prop_name, System.Type prop_type,
                    string name,
                    bool pk, bool auto_inc, bool unique,
                    bool not_null, string def_value,
                    int? max_len,
                    bool auto_create_ins)
            {
                this.PropertyName = prop_name;
                this.ColumnType = prop_type;

                this.Name = name;
                this.IsPK = pk;
                this.IsAutoInc = auto_inc;
                this.IsUnique = unique;
                this.IsNotNull = not_null;
                this.DefaultValue = def_value;
                this.MaxLength = max_len;
                this.IsAutoCreateIns = auto_create_ins;
            }
            public override void SetValue(object obj, object val)
            {
                var _obj = (RealworldAccidentData)obj;
                val = val ?? AutoCreateIns();
                switch (this.PropertyName)
                {
                   case "id":
                        _obj.id=(System.Int32)val;
                        break;
                  case "robot_star":
                        _obj.robot_star=(System.Int32)val;
                        break;
                  case "robot_num":
                        _obj.robot_num=(System.Int32)val;
                        break;
                  case "item_ids":
                        _obj.item_ids=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "item_probs":
                        _obj.item_probs=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "item_nums":
                        _obj.item_nums=(System.Collections.Generic.List<System.Int32>)val;
                        break;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            public override object GetValue(object obj)
            {
                var _obj = (RealworldAccidentData)obj;
                switch (this.PropertyName)
                {
                   case "id":
                        return _obj.id;
                  case "robot_star":
                        return _obj.robot_star;
                  case "robot_num":
                        return _obj.robot_num;
                  case "item_ids":
                        return _obj.item_ids;
                  case "item_probs":
                        return _obj.item_probs;
                  case "item_nums":
                        return _obj.item_nums;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            private object AutoCreateIns()
            {
                if(!this.IsAutoCreateIns)
                    return null;
                switch (this.PropertyName)
                {
                   case "item_ids":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "item_probs":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "item_nums":
                        return new System.Collections.Generic.List<System.Int32>();

                    default:
                        return null;
                }
            }
        }
    }
    public class RealworldUserLevelupDataMappingWarp : Sqlite3.TableMapping
    {
        //Ctor
        public RealworldUserLevelupDataMappingWarp()
        {
            
            this.MappedType = typeof(RealworldUserLevelupData);
            this.TableName = "RealworldUserLevelupData";
            //Columns
            this.PK = new Column("id", typeof(System.Int32), "id", true, false, false, false, null, null, true);
            this.Columns = new[]
            {
                this.PK,
new Column("level", typeof(System.Int32), "level", false, false, false, false, null, null, true),
new Column("experience", typeof(System.Int32), "experience", false, false, false, false, null, null, true),

            };

            this.GetByPrimaryKeySql = "SELECT * FROM \"RealworldUserLevelupData\" WHERE \"id\" = ?";

        }
        //Column Ctor
        public class Column : Sqlite3.Column
        {
            public Column(string prop_name, System.Type prop_type,
                    string name,
                    bool pk, bool auto_inc, bool unique,
                    bool not_null, string def_value,
                    int? max_len,
                    bool auto_create_ins)
            {
                this.PropertyName = prop_name;
                this.ColumnType = prop_type;

                this.Name = name;
                this.IsPK = pk;
                this.IsAutoInc = auto_inc;
                this.IsUnique = unique;
                this.IsNotNull = not_null;
                this.DefaultValue = def_value;
                this.MaxLength = max_len;
                this.IsAutoCreateIns = auto_create_ins;
            }
            public override void SetValue(object obj, object val)
            {
                var _obj = (RealworldUserLevelupData)obj;
                val = val ?? AutoCreateIns();
                switch (this.PropertyName)
                {
                   case "id":
                        _obj.id=(System.Int32)val;
                        break;
                  case "level":
                        _obj.level=(System.Int32)val;
                        break;
                  case "experience":
                        _obj.experience=(System.Int32)val;
                        break;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            public override object GetValue(object obj)
            {
                var _obj = (RealworldUserLevelupData)obj;
                switch (this.PropertyName)
                {
                   case "id":
                        return _obj.id;
                  case "level":
                        return _obj.level;
                  case "experience":
                        return _obj.experience;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            private object AutoCreateIns()
            {
                if(!this.IsAutoCreateIns)
                    return null;
                switch (this.PropertyName)
                {
 
                    default:
                        return null;
                }
            }
        }
    }
    public class RealworldEquipmentQualityCompoundDataMappingWarp : Sqlite3.TableMapping
    {
        //Ctor
        public RealworldEquipmentQualityCompoundDataMappingWarp()
        {
            
            this.MappedType = typeof(RealworldEquipmentQualityCompoundData);
            this.TableName = "RealworldEquipmentQualityCompoundData";
            //Columns
            this.PK = new Column("id", typeof(System.Int32), "id", true, false, false, false, null, null, true);
            this.Columns = new[]
            {
                this.PK,
new Column("equipment_before_id", typeof(System.Int32), "equipment_before_id", false, false, false, false, null, null, true),
new Column("quality_compound_type", typeof(System.Int32), "quality_compound_type", false, false, false, false, null, null, true),
new Column("equipment_after_id", typeof(System.Int32), "equipment_after_id", false, false, false, false, null, null, true),
new Column("compound_type", typeof(System.Int32), "compound_type", false, false, false, false, null, null, true),
new Column("compound_num", typeof(System.Int32), "compound_num", false, false, false, false, null, null, true),

            };

            this.GetByPrimaryKeySql = "SELECT * FROM \"RealworldEquipmentQualityCompoundData\" WHERE \"id\" = ?";

        }
        //Column Ctor
        public class Column : Sqlite3.Column
        {
            public Column(string prop_name, System.Type prop_type,
                    string name,
                    bool pk, bool auto_inc, bool unique,
                    bool not_null, string def_value,
                    int? max_len,
                    bool auto_create_ins)
            {
                this.PropertyName = prop_name;
                this.ColumnType = prop_type;

                this.Name = name;
                this.IsPK = pk;
                this.IsAutoInc = auto_inc;
                this.IsUnique = unique;
                this.IsNotNull = not_null;
                this.DefaultValue = def_value;
                this.MaxLength = max_len;
                this.IsAutoCreateIns = auto_create_ins;
            }
            public override void SetValue(object obj, object val)
            {
                var _obj = (RealworldEquipmentQualityCompoundData)obj;
                val = val ?? AutoCreateIns();
                switch (this.PropertyName)
                {
                   case "id":
                        _obj.id=(System.Int32)val;
                        break;
                  case "equipment_before_id":
                        _obj.equipment_before_id=(System.Int32)val;
                        break;
                  case "quality_compound_type":
                        _obj.quality_compound_type=(System.Int32)val;
                        break;
                  case "equipment_after_id":
                        _obj.equipment_after_id=(System.Int32)val;
                        break;
                  case "compound_type":
                        _obj.compound_type=(System.Int32)val;
                        break;
                  case "compound_num":
                        _obj.compound_num=(System.Int32)val;
                        break;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            public override object GetValue(object obj)
            {
                var _obj = (RealworldEquipmentQualityCompoundData)obj;
                switch (this.PropertyName)
                {
                   case "id":
                        return _obj.id;
                  case "equipment_before_id":
                        return _obj.equipment_before_id;
                  case "quality_compound_type":
                        return _obj.quality_compound_type;
                  case "equipment_after_id":
                        return _obj.equipment_after_id;
                  case "compound_type":
                        return _obj.compound_type;
                  case "compound_num":
                        return _obj.compound_num;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            private object AutoCreateIns()
            {
                if(!this.IsAutoCreateIns)
                    return null;
                switch (this.PropertyName)
                {
 
                    default:
                        return null;
                }
            }
        }
    }
    public class RealworldEquipmentExchangeDataMappingWarp : Sqlite3.TableMapping
    {
        //Ctor
        public RealworldEquipmentExchangeDataMappingWarp()
        {
            
            this.MappedType = typeof(RealworldEquipmentExchangeData);
            this.TableName = "RealworldEquipmentExchangeData";
            //Columns
            this.PK = new Column("id", typeof(System.Int32), "id", true, false, false, false, null, null, true);
            this.Columns = new[]
            {
                this.PK,
new Column("item_id_before", typeof(System.Int32), "item_id_before", false, false, false, false, null, null, true),
new Column("item_id_after", typeof(System.Int32), "item_id_after", false, false, false, false, null, null, true),
new Column("consume_type", typeof(System.Int32), "consume_type", false, false, false, false, null, null, true),
new Column("consume_num", typeof(System.Int32), "consume_num", false, false, false, false, null, null, true),

            };

            this.GetByPrimaryKeySql = "SELECT * FROM \"RealworldEquipmentExchangeData\" WHERE \"id\" = ?";

        }
        //Column Ctor
        public class Column : Sqlite3.Column
        {
            public Column(string prop_name, System.Type prop_type,
                    string name,
                    bool pk, bool auto_inc, bool unique,
                    bool not_null, string def_value,
                    int? max_len,
                    bool auto_create_ins)
            {
                this.PropertyName = prop_name;
                this.ColumnType = prop_type;

                this.Name = name;
                this.IsPK = pk;
                this.IsAutoInc = auto_inc;
                this.IsUnique = unique;
                this.IsNotNull = not_null;
                this.DefaultValue = def_value;
                this.MaxLength = max_len;
                this.IsAutoCreateIns = auto_create_ins;
            }
            public override void SetValue(object obj, object val)
            {
                var _obj = (RealworldEquipmentExchangeData)obj;
                val = val ?? AutoCreateIns();
                switch (this.PropertyName)
                {
                   case "id":
                        _obj.id=(System.Int32)val;
                        break;
                  case "item_id_before":
                        _obj.item_id_before=(System.Int32)val;
                        break;
                  case "item_id_after":
                        _obj.item_id_after=(System.Int32)val;
                        break;
                  case "consume_type":
                        _obj.consume_type=(System.Int32)val;
                        break;
                  case "consume_num":
                        _obj.consume_num=(System.Int32)val;
                        break;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            public override object GetValue(object obj)
            {
                var _obj = (RealworldEquipmentExchangeData)obj;
                switch (this.PropertyName)
                {
                   case "id":
                        return _obj.id;
                  case "item_id_before":
                        return _obj.item_id_before;
                  case "item_id_after":
                        return _obj.item_id_after;
                  case "consume_type":
                        return _obj.consume_type;
                  case "consume_num":
                        return _obj.consume_num;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            private object AutoCreateIns()
            {
                if(!this.IsAutoCreateIns)
                    return null;
                switch (this.PropertyName)
                {
 
                    default:
                        return null;
                }
            }
        }
    }
    public class RealworldEventDataMappingWarp : Sqlite3.TableMapping
    {
        //Ctor
        public RealworldEventDataMappingWarp()
        {
            
            this.MappedType = typeof(RealworldEventData);
            this.TableName = "RealworldEventData";
            //Columns
            this.PK = new Column("id", typeof(System.Int32), "id", true, false, false, false, null, null, true);
            this.Columns = new[]
            {
                this.PK,
new Column("title", typeof(System.String), "title", false, false, false, false, null, null, true),
new Column("desc", typeof(System.Collections.Generic.List<System.Int32>), "desc", false, false, false, false, null, null, true),

            };

            this.GetByPrimaryKeySql = "SELECT * FROM \"RealworldEventData\" WHERE \"id\" = ?";

        }
        //Column Ctor
        public class Column : Sqlite3.Column
        {
            public Column(string prop_name, System.Type prop_type,
                    string name,
                    bool pk, bool auto_inc, bool unique,
                    bool not_null, string def_value,
                    int? max_len,
                    bool auto_create_ins)
            {
                this.PropertyName = prop_name;
                this.ColumnType = prop_type;

                this.Name = name;
                this.IsPK = pk;
                this.IsAutoInc = auto_inc;
                this.IsUnique = unique;
                this.IsNotNull = not_null;
                this.DefaultValue = def_value;
                this.MaxLength = max_len;
                this.IsAutoCreateIns = auto_create_ins;
            }
            public override void SetValue(object obj, object val)
            {
                var _obj = (RealworldEventData)obj;
                val = val ?? AutoCreateIns();
                switch (this.PropertyName)
                {
                   case "id":
                        _obj.id=(System.Int32)val;
                        break;
                  case "title":
                        _obj.title=(System.String)val;
                        break;
                  case "desc":
                        _obj.desc=(System.Collections.Generic.List<System.Int32>)val;
                        break;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            public override object GetValue(object obj)
            {
                var _obj = (RealworldEventData)obj;
                switch (this.PropertyName)
                {
                   case "id":
                        return _obj.id;
                  case "title":
                        return _obj.title;
                  case "desc":
                        return _obj.desc;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            private object AutoCreateIns()
            {
                if(!this.IsAutoCreateIns)
                    return null;
                switch (this.PropertyName)
                {
                   case "desc":
                        return new System.Collections.Generic.List<System.Int32>();

                    default:
                        return null;
                }
            }
        }
    }
    public class RealworldItemDropDataMappingWarp : Sqlite3.TableMapping
    {
        //Ctor
        public RealworldItemDropDataMappingWarp()
        {
            
            this.MappedType = typeof(RealworldItemDropData);
            this.TableName = "RealworldItemDropData";
            //Columns
            this.PK = new Column("id", typeof(System.Int32), "id", true, false, false, false, null, null, true);
            this.Columns = new[]
            {
                this.PK,
new Column("drop_types", typeof(System.Collections.Generic.List<System.Int32>), "drop_types", false, false, false, false, null, null, true),
new Column("drop_probs", typeof(System.Collections.Generic.List<System.Int32>), "drop_probs", false, false, false, false, null, null, true),
new Column("item_drop_probs", typeof(System.Collections.Generic.List<System.Int32>), "item_drop_probs", false, false, false, false, null, null, true),
new Column("item_sequence_ids", typeof(System.Collections.Generic.List<System.Int32>), "item_sequence_ids", false, false, false, false, null, null, true),
new Column("sequence", typeof(System.Int32), "sequence", false, false, false, false, null, null, true),

            };

            this.GetByPrimaryKeySql = "SELECT * FROM \"RealworldItemDropData\" WHERE \"id\" = ?";

        }
        //Column Ctor
        public class Column : Sqlite3.Column
        {
            public Column(string prop_name, System.Type prop_type,
                    string name,
                    bool pk, bool auto_inc, bool unique,
                    bool not_null, string def_value,
                    int? max_len,
                    bool auto_create_ins)
            {
                this.PropertyName = prop_name;
                this.ColumnType = prop_type;

                this.Name = name;
                this.IsPK = pk;
                this.IsAutoInc = auto_inc;
                this.IsUnique = unique;
                this.IsNotNull = not_null;
                this.DefaultValue = def_value;
                this.MaxLength = max_len;
                this.IsAutoCreateIns = auto_create_ins;
            }
            public override void SetValue(object obj, object val)
            {
                var _obj = (RealworldItemDropData)obj;
                val = val ?? AutoCreateIns();
                switch (this.PropertyName)
                {
                   case "id":
                        _obj.id=(System.Int32)val;
                        break;
                  case "drop_types":
                        _obj.drop_types=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "drop_probs":
                        _obj.drop_probs=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "item_drop_probs":
                        _obj.item_drop_probs=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "item_sequence_ids":
                        _obj.item_sequence_ids=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "sequence":
                        _obj.sequence=(System.Int32)val;
                        break;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            public override object GetValue(object obj)
            {
                var _obj = (RealworldItemDropData)obj;
                switch (this.PropertyName)
                {
                   case "id":
                        return _obj.id;
                  case "drop_types":
                        return _obj.drop_types;
                  case "drop_probs":
                        return _obj.drop_probs;
                  case "item_drop_probs":
                        return _obj.item_drop_probs;
                  case "item_sequence_ids":
                        return _obj.item_sequence_ids;
                  case "sequence":
                        return _obj.sequence;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            private object AutoCreateIns()
            {
                if(!this.IsAutoCreateIns)
                    return null;
                switch (this.PropertyName)
                {
                   case "drop_types":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "drop_probs":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "item_drop_probs":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "item_sequence_ids":
                        return new System.Collections.Generic.List<System.Int32>();

                    default:
                        return null;
                }
            }
        }
    }
    public class LevelDataMappingWarp : Sqlite3.TableMapping
    {
        //Ctor
        public LevelDataMappingWarp()
        {
            
            this.MappedType = typeof(LevelData);
            this.TableName = "LevelData";
            //Columns
            this.PK = new Column("id", typeof(System.Int32), "id", true, false, false, false, null, null, true);
            this.Columns = new[]
            {
                this.PK,
new Column("level_name", typeof(System.String), "level_name", false, false, false, false, null, null, true),
new Column("icon", typeof(System.String), "icon", false, false, false, false, null, null, true),
new Column("next_level", typeof(System.Int32), "next_level", false, false, false, false, null, null, true),
new Column("level_req", typeof(System.Int32), "level_req", false, false, false, false, null, null, true),
new Column("fight_limit", typeof(System.Int32), "fight_limit", false, false, false, false, null, null, true),
new Column("recommend_power", typeof(System.Int32), "recommend_power", false, false, false, false, null, null, true),
new Column("enemy_id", typeof(System.Collections.Generic.List<System.Int32>), "enemy_id", false, false, false, false, null, null, true),
new Column("enemy_levels", typeof(System.Collections.Generic.List<System.Int32>), "enemy_levels", false, false, false, false, null, null, true),
new Column("campaign", typeof(System.Int32), "campaign", false, false, false, false, null, null, true),
new Column("drop_id", typeof(System.Collections.Generic.List<System.Int32>), "drop_id", false, false, false, false, null, null, true),
new Column("drop_pro", typeof(System.Collections.Generic.List<System.Int32>), "drop_pro", false, false, false, false, null, null, true),
new Column("drop_num", typeof(System.Collections.Generic.List<System.Int32>), "drop_num", false, false, false, false, null, null, true),
new Column("first_reward_type", typeof(System.Collections.Generic.List<System.Int32>), "first_reward_type", false, false, false, false, null, null, true),
new Column("first_reward_id", typeof(System.Collections.Generic.List<System.Int32>), "first_reward_id", false, false, false, false, null, null, true),
new Column("first_reward_num", typeof(System.Collections.Generic.List<System.Int32>), "first_reward_num", false, false, false, false, null, null, true),
new Column("level_degress", typeof(System.Int32), "level_degress", false, false, false, false, null, null, true),

            };

            this.GetByPrimaryKeySql = "SELECT * FROM \"LevelData\" WHERE \"id\" = ?";

        }
        //Column Ctor
        public class Column : Sqlite3.Column
        {
            public Column(string prop_name, System.Type prop_type,
                    string name,
                    bool pk, bool auto_inc, bool unique,
                    bool not_null, string def_value,
                    int? max_len,
                    bool auto_create_ins)
            {
                this.PropertyName = prop_name;
                this.ColumnType = prop_type;

                this.Name = name;
                this.IsPK = pk;
                this.IsAutoInc = auto_inc;
                this.IsUnique = unique;
                this.IsNotNull = not_null;
                this.DefaultValue = def_value;
                this.MaxLength = max_len;
                this.IsAutoCreateIns = auto_create_ins;
            }
            public override void SetValue(object obj, object val)
            {
                var _obj = (LevelData)obj;
                val = val ?? AutoCreateIns();
                switch (this.PropertyName)
                {
                   case "id":
                        _obj.id=(System.Int32)val;
                        break;
                  case "level_name":
                        _obj.level_name=(System.String)val;
                        break;
                  case "icon":
                        _obj.icon=(System.String)val;
                        break;
                  case "next_level":
                        _obj.next_level=(System.Int32)val;
                        break;
                  case "level_req":
                        _obj.level_req=(System.Int32)val;
                        break;
                  case "fight_limit":
                        _obj.fight_limit=(System.Int32)val;
                        break;
                  case "recommend_power":
                        _obj.recommend_power=(System.Int32)val;
                        break;
                  case "enemy_id":
                        _obj.enemy_id=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "enemy_levels":
                        _obj.enemy_levels=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "campaign":
                        _obj.campaign=(System.Int32)val;
                        break;
                  case "drop_id":
                        _obj.drop_id=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "drop_pro":
                        _obj.drop_pro=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "drop_num":
                        _obj.drop_num=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "first_reward_type":
                        _obj.first_reward_type=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "first_reward_id":
                        _obj.first_reward_id=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "first_reward_num":
                        _obj.first_reward_num=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "level_degress":
                        _obj.level_degress=(System.Int32)val;
                        break;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            public override object GetValue(object obj)
            {
                var _obj = (LevelData)obj;
                switch (this.PropertyName)
                {
                   case "id":
                        return _obj.id;
                  case "level_name":
                        return _obj.level_name;
                  case "icon":
                        return _obj.icon;
                  case "next_level":
                        return _obj.next_level;
                  case "level_req":
                        return _obj.level_req;
                  case "fight_limit":
                        return _obj.fight_limit;
                  case "recommend_power":
                        return _obj.recommend_power;
                  case "enemy_id":
                        return _obj.enemy_id;
                  case "enemy_levels":
                        return _obj.enemy_levels;
                  case "campaign":
                        return _obj.campaign;
                  case "drop_id":
                        return _obj.drop_id;
                  case "drop_pro":
                        return _obj.drop_pro;
                  case "drop_num":
                        return _obj.drop_num;
                  case "first_reward_type":
                        return _obj.first_reward_type;
                  case "first_reward_id":
                        return _obj.first_reward_id;
                  case "first_reward_num":
                        return _obj.first_reward_num;
                  case "level_degress":
                        return _obj.level_degress;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            private object AutoCreateIns()
            {
                if(!this.IsAutoCreateIns)
                    return null;
                switch (this.PropertyName)
                {
                   case "enemy_id":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "enemy_levels":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "drop_id":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "drop_pro":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "drop_num":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "first_reward_type":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "first_reward_id":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "first_reward_num":
                        return new System.Collections.Generic.List<System.Int32>();

                    default:
                        return null;
                }
            }
        }
    }
    public class LevelReachDataMappingWarp : Sqlite3.TableMapping
    {
        //Ctor
        public LevelReachDataMappingWarp()
        {
            
            this.MappedType = typeof(LevelReachData);
            this.TableName = "LevelReachData";
            //Columns
            this.PK = new Column("id", typeof(System.Int32), "id", true, false, false, false, null, null, true);
            this.Columns = new[]
            {
                this.PK,
new Column("level_reach", typeof(System.Int32), "level_reach", false, false, false, false, null, null, true),
new Column("reward_item_ids", typeof(System.Collections.Generic.List<System.Int32>), "reward_item_ids", false, false, false, false, null, null, true),
new Column("reward_item_types", typeof(System.Collections.Generic.List<System.Int32>), "reward_item_types", false, false, false, false, null, null, true),
new Column("reward_item_nums", typeof(System.Collections.Generic.List<System.Int32>), "reward_item_nums", false, false, false, false, null, null, true),
new Column("reward_drop_probs", typeof(System.Collections.Generic.List<System.Int32>), "reward_drop_probs", false, false, false, false, null, null, true),
new Column("reward_drop_max", typeof(System.Collections.Generic.List<System.Int32>), "reward_drop_max", false, false, false, false, null, null, true),
new Column("reward_daily_drop_limit", typeof(System.Collections.Generic.List<System.Int32>), "reward_daily_drop_limit", false, false, false, false, null, null, true),
new Column("consume_type", typeof(System.Int32), "consume_type", false, false, false, false, null, null, true),
new Column("consume_id", typeof(System.Int32), "consume_id", false, false, false, false, null, null, true),
new Column("consume_num", typeof(System.Int32), "consume_num", false, false, false, false, null, null, true),
new Column("add_chance_consume_type", typeof(System.Int32), "add_chance_consume_type", false, false, false, false, null, null, true),
new Column("add_chance_consume_nums", typeof(System.Collections.Generic.List<System.Int32>), "add_chance_consume_nums", false, false, false, false, null, null, true),
new Column("consume_time", typeof(System.Int32), "consume_time", false, false, false, false, null, null, true),
new Column("fight_time_limit", typeof(System.Int32), "fight_time_limit", false, false, false, false, null, null, true),

            };

            this.GetByPrimaryKeySql = "SELECT * FROM \"LevelReachData\" WHERE \"id\" = ?";

        }
        //Column Ctor
        public class Column : Sqlite3.Column
        {
            public Column(string prop_name, System.Type prop_type,
                    string name,
                    bool pk, bool auto_inc, bool unique,
                    bool not_null, string def_value,
                    int? max_len,
                    bool auto_create_ins)
            {
                this.PropertyName = prop_name;
                this.ColumnType = prop_type;

                this.Name = name;
                this.IsPK = pk;
                this.IsAutoInc = auto_inc;
                this.IsUnique = unique;
                this.IsNotNull = not_null;
                this.DefaultValue = def_value;
                this.MaxLength = max_len;
                this.IsAutoCreateIns = auto_create_ins;
            }
            public override void SetValue(object obj, object val)
            {
                var _obj = (LevelReachData)obj;
                val = val ?? AutoCreateIns();
                switch (this.PropertyName)
                {
                   case "id":
                        _obj.id=(System.Int32)val;
                        break;
                  case "level_reach":
                        _obj.level_reach=(System.Int32)val;
                        break;
                  case "reward_item_ids":
                        _obj.reward_item_ids=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "reward_item_types":
                        _obj.reward_item_types=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "reward_item_nums":
                        _obj.reward_item_nums=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "reward_drop_probs":
                        _obj.reward_drop_probs=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "reward_drop_max":
                        _obj.reward_drop_max=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "reward_daily_drop_limit":
                        _obj.reward_daily_drop_limit=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "consume_type":
                        _obj.consume_type=(System.Int32)val;
                        break;
                  case "consume_id":
                        _obj.consume_id=(System.Int32)val;
                        break;
                  case "consume_num":
                        _obj.consume_num=(System.Int32)val;
                        break;
                  case "add_chance_consume_type":
                        _obj.add_chance_consume_type=(System.Int32)val;
                        break;
                  case "add_chance_consume_nums":
                        _obj.add_chance_consume_nums=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "consume_time":
                        _obj.consume_time=(System.Int32)val;
                        break;
                  case "fight_time_limit":
                        _obj.fight_time_limit=(System.Int32)val;
                        break;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            public override object GetValue(object obj)
            {
                var _obj = (LevelReachData)obj;
                switch (this.PropertyName)
                {
                   case "id":
                        return _obj.id;
                  case "level_reach":
                        return _obj.level_reach;
                  case "reward_item_ids":
                        return _obj.reward_item_ids;
                  case "reward_item_types":
                        return _obj.reward_item_types;
                  case "reward_item_nums":
                        return _obj.reward_item_nums;
                  case "reward_drop_probs":
                        return _obj.reward_drop_probs;
                  case "reward_drop_max":
                        return _obj.reward_drop_max;
                  case "reward_daily_drop_limit":
                        return _obj.reward_daily_drop_limit;
                  case "consume_type":
                        return _obj.consume_type;
                  case "consume_id":
                        return _obj.consume_id;
                  case "consume_num":
                        return _obj.consume_num;
                  case "add_chance_consume_type":
                        return _obj.add_chance_consume_type;
                  case "add_chance_consume_nums":
                        return _obj.add_chance_consume_nums;
                  case "consume_time":
                        return _obj.consume_time;
                  case "fight_time_limit":
                        return _obj.fight_time_limit;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            private object AutoCreateIns()
            {
                if(!this.IsAutoCreateIns)
                    return null;
                switch (this.PropertyName)
                {
                   case "reward_item_ids":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "reward_item_types":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "reward_item_nums":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "reward_drop_probs":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "reward_drop_max":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "reward_daily_drop_limit":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "add_chance_consume_nums":
                        return new System.Collections.Generic.List<System.Int32>();

                    default:
                        return null;
                }
            }
        }
    }
    public class MeltShopDataMappingWarp : Sqlite3.TableMapping
    {
        //Ctor
        public MeltShopDataMappingWarp()
        {
            
            this.MappedType = typeof(MeltShopData);
            this.TableName = "MeltShopData";
            //Columns
            this.PK = new Column("id", typeof(System.Int32), "id", true, false, false, false, null, null, true);
            this.Columns = new[]
            {
                this.PK,
new Column("shop_type", typeof(System.Int32), "shop_type", false, false, false, false, null, null, true),
new Column("item_type", typeof(System.Int32), "item_type", false, false, false, false, null, null, true),
new Column("item_id", typeof(System.Int32), "item_id", false, false, false, false, null, null, true),
new Column("money_type", typeof(System.Int32), "money_type", false, false, false, false, null, null, true),
new Column("money_single_cost", typeof(System.Int32), "money_single_cost", false, false, false, false, null, null, true),
new Column("buy_limit_num", typeof(System.Int32), "buy_limit_num", false, false, false, false, null, null, true),
new Column("world_types", typeof(System.Int32), "world_types", false, false, false, false, null, null, true),
new Column("item_num", typeof(System.Int32), "item_num", false, false, false, false, null, null, true),

            };

            this.GetByPrimaryKeySql = "SELECT * FROM \"MeltShopData\" WHERE \"id\" = ?";

        }
        //Column Ctor
        public class Column : Sqlite3.Column
        {
            public Column(string prop_name, System.Type prop_type,
                    string name,
                    bool pk, bool auto_inc, bool unique,
                    bool not_null, string def_value,
                    int? max_len,
                    bool auto_create_ins)
            {
                this.PropertyName = prop_name;
                this.ColumnType = prop_type;

                this.Name = name;
                this.IsPK = pk;
                this.IsAutoInc = auto_inc;
                this.IsUnique = unique;
                this.IsNotNull = not_null;
                this.DefaultValue = def_value;
                this.MaxLength = max_len;
                this.IsAutoCreateIns = auto_create_ins;
            }
            public override void SetValue(object obj, object val)
            {
                var _obj = (MeltShopData)obj;
                val = val ?? AutoCreateIns();
                switch (this.PropertyName)
                {
                   case "id":
                        _obj.id=(System.Int32)val;
                        break;
                  case "shop_type":
                        _obj.shop_type=(System.Int32)val;
                        break;
                  case "item_type":
                        _obj.item_type=(System.Int32)val;
                        break;
                  case "item_id":
                        _obj.item_id=(System.Int32)val;
                        break;
                  case "money_type":
                        _obj.money_type=(System.Int32)val;
                        break;
                  case "money_single_cost":
                        _obj.money_single_cost=(System.Int32)val;
                        break;
                  case "buy_limit_num":
                        _obj.buy_limit_num=(System.Int32)val;
                        break;
                  case "world_types":
                        _obj.world_types=(System.Int32)val;
                        break;
                  case "item_num":
                        _obj.item_num=(System.Int32)val;
                        break;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            public override object GetValue(object obj)
            {
                var _obj = (MeltShopData)obj;
                switch (this.PropertyName)
                {
                   case "id":
                        return _obj.id;
                  case "shop_type":
                        return _obj.shop_type;
                  case "item_type":
                        return _obj.item_type;
                  case "item_id":
                        return _obj.item_id;
                  case "money_type":
                        return _obj.money_type;
                  case "money_single_cost":
                        return _obj.money_single_cost;
                  case "buy_limit_num":
                        return _obj.buy_limit_num;
                  case "world_types":
                        return _obj.world_types;
                  case "item_num":
                        return _obj.item_num;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            private object AutoCreateIns()
            {
                if(!this.IsAutoCreateIns)
                    return null;
                switch (this.PropertyName)
                {
 
                    default:
                        return null;
                }
            }
        }
    }
    public class ShopDataMappingWarp : Sqlite3.TableMapping
    {
        //Ctor
        public ShopDataMappingWarp()
        {
            
            this.MappedType = typeof(ShopData);
            this.TableName = "ShopData";
            //Columns
            this.PK = new Column("id", typeof(System.Int32), "id", true, false, false, false, null, null, true);
            this.Columns = new[]
            {
                this.PK,
new Column("shop_type", typeof(System.Int32), "shop_type", false, false, false, false, null, null, true),
new Column("item_type", typeof(System.Int32), "item_type", false, false, false, false, null, null, true),
new Column("item_id", typeof(System.Int32), "item_id", false, false, false, false, null, null, true),
new Column("money_type", typeof(System.Int32), "money_type", false, false, false, false, null, null, true),
new Column("money_single_cost", typeof(System.Int32), "money_single_cost", false, false, false, false, null, null, true),
new Column("buy_limit_num", typeof(System.Int32), "buy_limit_num", false, false, false, false, null, null, true),
new Column("world_types", typeof(System.Int32), "world_types", false, false, false, false, null, null, true),
new Column("item_num", typeof(System.Int32), "item_num", false, false, false, false, null, null, true),

            };

            this.GetByPrimaryKeySql = "SELECT * FROM \"ShopData\" WHERE \"id\" = ?";

        }
        //Column Ctor
        public class Column : Sqlite3.Column
        {
            public Column(string prop_name, System.Type prop_type,
                    string name,
                    bool pk, bool auto_inc, bool unique,
                    bool not_null, string def_value,
                    int? max_len,
                    bool auto_create_ins)
            {
                this.PropertyName = prop_name;
                this.ColumnType = prop_type;

                this.Name = name;
                this.IsPK = pk;
                this.IsAutoInc = auto_inc;
                this.IsUnique = unique;
                this.IsNotNull = not_null;
                this.DefaultValue = def_value;
                this.MaxLength = max_len;
                this.IsAutoCreateIns = auto_create_ins;
            }
            public override void SetValue(object obj, object val)
            {
                var _obj = (ShopData)obj;
                val = val ?? AutoCreateIns();
                switch (this.PropertyName)
                {
                   case "id":
                        _obj.id=(System.Int32)val;
                        break;
                  case "shop_type":
                        _obj.shop_type=(System.Int32)val;
                        break;
                  case "item_type":
                        _obj.item_type=(System.Int32)val;
                        break;
                  case "item_id":
                        _obj.item_id=(System.Int32)val;
                        break;
                  case "money_type":
                        _obj.money_type=(System.Int32)val;
                        break;
                  case "money_single_cost":
                        _obj.money_single_cost=(System.Int32)val;
                        break;
                  case "buy_limit_num":
                        _obj.buy_limit_num=(System.Int32)val;
                        break;
                  case "world_types":
                        _obj.world_types=(System.Int32)val;
                        break;
                  case "item_num":
                        _obj.item_num=(System.Int32)val;
                        break;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            public override object GetValue(object obj)
            {
                var _obj = (ShopData)obj;
                switch (this.PropertyName)
                {
                   case "id":
                        return _obj.id;
                  case "shop_type":
                        return _obj.shop_type;
                  case "item_type":
                        return _obj.item_type;
                  case "item_id":
                        return _obj.item_id;
                  case "money_type":
                        return _obj.money_type;
                  case "money_single_cost":
                        return _obj.money_single_cost;
                  case "buy_limit_num":
                        return _obj.buy_limit_num;
                  case "world_types":
                        return _obj.world_types;
                  case "item_num":
                        return _obj.item_num;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            private object AutoCreateIns()
            {
                if(!this.IsAutoCreateIns)
                    return null;
                switch (this.PropertyName)
                {
 
                    default:
                        return null;
                }
            }
        }
    }
    public class BattleDataMappingWarp : Sqlite3.TableMapping
    {
        //Ctor
        public BattleDataMappingWarp()
        {
            
            this.MappedType = typeof(BattleData);
            this.TableName = "BattleData";
            //Columns
            this.PK = new Column("id", typeof(System.Int32), "id", true, false, false, false, null, null, true);
            this.Columns = new[]
            {
                this.PK,
new Column("round", typeof(System.Int32), "round", false, false, false, false, null, null, true),
new Column("attacker", typeof(System.Int32[]), "attacker", false, false, false, false, null, null, true),
new Column("be_attacker", typeof(System.Int32[]), "be_attacker", false, false, false, false, null, null, true),
new Column("is_attack_move", typeof(System.Int32), "is_attack_move", false, false, false, false, null, null, true),
new Column("teamA_damage_target", typeof(System.Collections.Generic.List<System.Int32>), "teamA_damage_target", false, false, false, false, null, null, true),
new Column("teamA_damages", typeof(System.Collections.Generic.List<System.Int32>), "teamA_damages", false, false, false, false, null, null, true),
new Column("teamB_damage_target", typeof(System.Collections.Generic.List<System.Int32>), "teamB_damage_target", false, false, false, false, null, null, true),
new Column("teamB_damages", typeof(System.Collections.Generic.List<System.Int32>), "teamB_damages", false, false, false, false, null, null, true),
new Column("teamA_total_health", typeof(System.Collections.Generic.List<System.Int32>), "teamA_total_health", false, false, false, false, null, null, true),
new Column("teamB_total_health", typeof(System.Collections.Generic.List<System.Int32>), "teamB_total_health", false, false, false, false, null, null, true),
new Column("teamA_healths", typeof(System.Collections.Generic.List<System.Int32>), "teamA_healths", false, false, false, false, null, null, true),
new Column("teamB__healths", typeof(System.Collections.Generic.List<System.Int32>), "teamB__healths", false, false, false, false, null, null, true),
new Column("teamA_energies", typeof(System.Collections.Generic.List<System.Int32>), "teamA_energies", false, false, false, false, null, null, true),
new Column("teamB_energies", typeof(System.Collections.Generic.List<System.Int32>), "teamB_energies", false, false, false, false, null, null, true),
new Column("teamA1_buffs_id", typeof(System.Collections.Generic.List<System.Int32>), "teamA1_buffs_id", false, false, false, false, null, null, true),
new Column("teamA1_buffs_round", typeof(System.Collections.Generic.List<System.Int32>), "teamA1_buffs_round", false, false, false, false, null, null, true),
new Column("teamA2_buffs_id", typeof(System.Collections.Generic.List<System.Int32>), "teamA2_buffs_id", false, false, false, false, null, null, true),
new Column("teamA2_buffs_round", typeof(System.Collections.Generic.List<System.Int32>), "teamA2_buffs_round", false, false, false, false, null, null, true),
new Column("teamA3_buffs_id", typeof(System.Collections.Generic.List<System.Int32>), "teamA3_buffs_id", false, false, false, false, null, null, true),
new Column("teamA3_buffs_round", typeof(System.Collections.Generic.List<System.Int32>), "teamA3_buffs_round", false, false, false, false, null, null, true),
new Column("teamA4_buffs_id", typeof(System.Collections.Generic.List<System.Int32>), "teamA4_buffs_id", false, false, false, false, null, null, true),
new Column("teamA4_buffs_round", typeof(System.Collections.Generic.List<System.Int32>), "teamA4_buffs_round", false, false, false, false, null, null, true),
new Column("teamA5_buffs_id", typeof(System.Collections.Generic.List<System.Int32>), "teamA5_buffs_id", false, false, false, false, null, null, true),
new Column("teamA5_buffs_round", typeof(System.Collections.Generic.List<System.Int32>), "teamA5_buffs_round", false, false, false, false, null, null, true),
new Column("teamB1_buffs_id", typeof(System.Collections.Generic.List<System.Int32>), "teamB1_buffs_id", false, false, false, false, null, null, true),
new Column("teamB1_buffs_round", typeof(System.Collections.Generic.List<System.Int32>), "teamB1_buffs_round", false, false, false, false, null, null, true),
new Column("teamB2_buffs_id", typeof(System.Collections.Generic.List<System.Int32>), "teamB2_buffs_id", false, false, false, false, null, null, true),
new Column("teamB2_buffs_round", typeof(System.Collections.Generic.List<System.Int32>), "teamB2_buffs_round", false, false, false, false, null, null, true),
new Column("teamB3_buffs_id", typeof(System.Collections.Generic.List<System.Int32>), "teamB3_buffs_id", false, false, false, false, null, null, true),
new Column("teamB3_buffs_round", typeof(System.Collections.Generic.List<System.Int32>), "teamB3_buffs_round", false, false, false, false, null, null, true),
new Column("teamB4_buffs_id", typeof(System.Collections.Generic.List<System.Int32>), "teamB4_buffs_id", false, false, false, false, null, null, true),
new Column("teamB4_buffs_round", typeof(System.Collections.Generic.List<System.Int32>), "teamB4_buffs_round", false, false, false, false, null, null, true),
new Column("teamB5_buffs_id", typeof(System.Collections.Generic.List<System.Int32>), "teamB5_buffs_id", false, false, false, false, null, null, true),
new Column("teamB5_buffs_round", typeof(System.Collections.Generic.List<System.Int32>), "teamB5_buffs_round", false, false, false, false, null, null, true),
new Column("teamA_death", typeof(System.Collections.Generic.List<System.Int32>), "teamA_death", false, false, false, false, null, null, true),
new Column("teamB_death", typeof(System.Collections.Generic.List<System.Int32>), "teamB_death", false, false, false, false, null, null, true),
new Column("round_finished_need_chat", typeof(System.Int32), "round_finished_need_chat", false, false, false, false, null, null, true),
new Column("chat_dialog_npcs", typeof(System.Collections.Generic.List<System.Int32>), "chat_dialog_npcs", false, false, false, false, null, null, true),
new Column("chat_dialogs", typeof(System.Collections.Generic.List<System.Int32>), "chat_dialogs", false, false, false, false, null, null, true),
new Column("round_add_heros", typeof(System.Collections.Generic.List<System.Int32>), "round_add_heros", false, false, false, false, null, null, true),
new Column("round_add_heros_position", typeof(System.Collections.Generic.List<System.Int32>), "round_add_heros_position", false, false, false, false, null, null, true),
new Column("winner", typeof(System.Int32), "winner", false, false, false, false, null, null, true),
new Column("battle_belong", typeof(System.Int32), "battle_belong", false, false, false, false, null, null, true),

            };

            this.GetByPrimaryKeySql = "SELECT * FROM \"BattleData\" WHERE \"id\" = ?";

        }
        //Column Ctor
        public class Column : Sqlite3.Column
        {
            public Column(string prop_name, System.Type prop_type,
                    string name,
                    bool pk, bool auto_inc, bool unique,
                    bool not_null, string def_value,
                    int? max_len,
                    bool auto_create_ins)
            {
                this.PropertyName = prop_name;
                this.ColumnType = prop_type;

                this.Name = name;
                this.IsPK = pk;
                this.IsAutoInc = auto_inc;
                this.IsUnique = unique;
                this.IsNotNull = not_null;
                this.DefaultValue = def_value;
                this.MaxLength = max_len;
                this.IsAutoCreateIns = auto_create_ins;
            }
            public override void SetValue(object obj, object val)
            {
                var _obj = (BattleData)obj;
                val = val ?? AutoCreateIns();
                switch (this.PropertyName)
                {
                   case "id":
                        _obj.id=(System.Int32)val;
                        break;
                  case "round":
                        _obj.round=(System.Int32)val;
                        break;
                  case "attacker":
                        _obj.attacker=(System.Int32[])val;
                        break;
                  case "be_attacker":
                        _obj.be_attacker=(System.Int32[])val;
                        break;
                  case "is_attack_move":
                        _obj.is_attack_move=(System.Int32)val;
                        break;
                  case "teamA_damage_target":
                        _obj.teamA_damage_target=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "teamA_damages":
                        _obj.teamA_damages=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "teamB_damage_target":
                        _obj.teamB_damage_target=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "teamB_damages":
                        _obj.teamB_damages=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "teamA_total_health":
                        _obj.teamA_total_health=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "teamB_total_health":
                        _obj.teamB_total_health=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "teamA_healths":
                        _obj.teamA_healths=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "teamB__healths":
                        _obj.teamB__healths=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "teamA_energies":
                        _obj.teamA_energies=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "teamB_energies":
                        _obj.teamB_energies=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "teamA1_buffs_id":
                        _obj.teamA1_buffs_id=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "teamA1_buffs_round":
                        _obj.teamA1_buffs_round=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "teamA2_buffs_id":
                        _obj.teamA2_buffs_id=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "teamA2_buffs_round":
                        _obj.teamA2_buffs_round=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "teamA3_buffs_id":
                        _obj.teamA3_buffs_id=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "teamA3_buffs_round":
                        _obj.teamA3_buffs_round=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "teamA4_buffs_id":
                        _obj.teamA4_buffs_id=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "teamA4_buffs_round":
                        _obj.teamA4_buffs_round=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "teamA5_buffs_id":
                        _obj.teamA5_buffs_id=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "teamA5_buffs_round":
                        _obj.teamA5_buffs_round=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "teamB1_buffs_id":
                        _obj.teamB1_buffs_id=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "teamB1_buffs_round":
                        _obj.teamB1_buffs_round=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "teamB2_buffs_id":
                        _obj.teamB2_buffs_id=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "teamB2_buffs_round":
                        _obj.teamB2_buffs_round=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "teamB3_buffs_id":
                        _obj.teamB3_buffs_id=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "teamB3_buffs_round":
                        _obj.teamB3_buffs_round=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "teamB4_buffs_id":
                        _obj.teamB4_buffs_id=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "teamB4_buffs_round":
                        _obj.teamB4_buffs_round=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "teamB5_buffs_id":
                        _obj.teamB5_buffs_id=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "teamB5_buffs_round":
                        _obj.teamB5_buffs_round=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "teamA_death":
                        _obj.teamA_death=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "teamB_death":
                        _obj.teamB_death=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "round_finished_need_chat":
                        _obj.round_finished_need_chat=(System.Int32)val;
                        break;
                  case "chat_dialog_npcs":
                        _obj.chat_dialog_npcs=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "chat_dialogs":
                        _obj.chat_dialogs=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "round_add_heros":
                        _obj.round_add_heros=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "round_add_heros_position":
                        _obj.round_add_heros_position=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "winner":
                        _obj.winner=(System.Int32)val;
                        break;
                  case "battle_belong":
                        _obj.battle_belong=(System.Int32)val;
                        break;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            public override object GetValue(object obj)
            {
                var _obj = (BattleData)obj;
                switch (this.PropertyName)
                {
                   case "id":
                        return _obj.id;
                  case "round":
                        return _obj.round;
                  case "attacker":
                        return _obj.attacker;
                  case "be_attacker":
                        return _obj.be_attacker;
                  case "is_attack_move":
                        return _obj.is_attack_move;
                  case "teamA_damage_target":
                        return _obj.teamA_damage_target;
                  case "teamA_damages":
                        return _obj.teamA_damages;
                  case "teamB_damage_target":
                        return _obj.teamB_damage_target;
                  case "teamB_damages":
                        return _obj.teamB_damages;
                  case "teamA_total_health":
                        return _obj.teamA_total_health;
                  case "teamB_total_health":
                        return _obj.teamB_total_health;
                  case "teamA_healths":
                        return _obj.teamA_healths;
                  case "teamB__healths":
                        return _obj.teamB__healths;
                  case "teamA_energies":
                        return _obj.teamA_energies;
                  case "teamB_energies":
                        return _obj.teamB_energies;
                  case "teamA1_buffs_id":
                        return _obj.teamA1_buffs_id;
                  case "teamA1_buffs_round":
                        return _obj.teamA1_buffs_round;
                  case "teamA2_buffs_id":
                        return _obj.teamA2_buffs_id;
                  case "teamA2_buffs_round":
                        return _obj.teamA2_buffs_round;
                  case "teamA3_buffs_id":
                        return _obj.teamA3_buffs_id;
                  case "teamA3_buffs_round":
                        return _obj.teamA3_buffs_round;
                  case "teamA4_buffs_id":
                        return _obj.teamA4_buffs_id;
                  case "teamA4_buffs_round":
                        return _obj.teamA4_buffs_round;
                  case "teamA5_buffs_id":
                        return _obj.teamA5_buffs_id;
                  case "teamA5_buffs_round":
                        return _obj.teamA5_buffs_round;
                  case "teamB1_buffs_id":
                        return _obj.teamB1_buffs_id;
                  case "teamB1_buffs_round":
                        return _obj.teamB1_buffs_round;
                  case "teamB2_buffs_id":
                        return _obj.teamB2_buffs_id;
                  case "teamB2_buffs_round":
                        return _obj.teamB2_buffs_round;
                  case "teamB3_buffs_id":
                        return _obj.teamB3_buffs_id;
                  case "teamB3_buffs_round":
                        return _obj.teamB3_buffs_round;
                  case "teamB4_buffs_id":
                        return _obj.teamB4_buffs_id;
                  case "teamB4_buffs_round":
                        return _obj.teamB4_buffs_round;
                  case "teamB5_buffs_id":
                        return _obj.teamB5_buffs_id;
                  case "teamB5_buffs_round":
                        return _obj.teamB5_buffs_round;
                  case "teamA_death":
                        return _obj.teamA_death;
                  case "teamB_death":
                        return _obj.teamB_death;
                  case "round_finished_need_chat":
                        return _obj.round_finished_need_chat;
                  case "chat_dialog_npcs":
                        return _obj.chat_dialog_npcs;
                  case "chat_dialogs":
                        return _obj.chat_dialogs;
                  case "round_add_heros":
                        return _obj.round_add_heros;
                  case "round_add_heros_position":
                        return _obj.round_add_heros_position;
                  case "winner":
                        return _obj.winner;
                  case "battle_belong":
                        return _obj.battle_belong;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            private object AutoCreateIns()
            {
                if(!this.IsAutoCreateIns)
                    return null;
                switch (this.PropertyName)
                {
                   case "attacker":
                        return new System.Int32[0];
                  case "be_attacker":
                        return new System.Int32[0];
                  case "teamA_damage_target":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "teamA_damages":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "teamB_damage_target":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "teamB_damages":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "teamA_total_health":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "teamB_total_health":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "teamA_healths":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "teamB__healths":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "teamA_energies":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "teamB_energies":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "teamA1_buffs_id":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "teamA1_buffs_round":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "teamA2_buffs_id":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "teamA2_buffs_round":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "teamA3_buffs_id":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "teamA3_buffs_round":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "teamA4_buffs_id":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "teamA4_buffs_round":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "teamA5_buffs_id":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "teamA5_buffs_round":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "teamB1_buffs_id":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "teamB1_buffs_round":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "teamB2_buffs_id":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "teamB2_buffs_round":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "teamB3_buffs_id":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "teamB3_buffs_round":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "teamB4_buffs_id":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "teamB4_buffs_round":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "teamB5_buffs_id":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "teamB5_buffs_round":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "teamA_death":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "teamB_death":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "chat_dialog_npcs":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "chat_dialogs":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "round_add_heros":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "round_add_heros_position":
                        return new System.Collections.Generic.List<System.Int32>();

                    default:
                        return null;
                }
            }
        }
    }
    public class RealworldStoryDataMappingWarp : Sqlite3.TableMapping
    {
        //Ctor
        public RealworldStoryDataMappingWarp()
        {
            
            this.MappedType = typeof(RealworldStoryData);
            this.TableName = "RealworldStoryData";
            //Columns
            this.PK = new Column("id", typeof(System.Int32), "id", true, false, false, false, null, null, true);
            this.Columns = new[]
            {
                this.PK,
new Column("npc_ids", typeof(System.Collections.Generic.List<System.Int32>), "npc_ids", false, false, false, false, null, null, true),
new Column("dialog_ids", typeof(System.Collections.Generic.List<System.Int32>), "dialog_ids", false, false, false, false, null, null, true),

            };

            this.GetByPrimaryKeySql = "SELECT * FROM \"RealworldStoryData\" WHERE \"id\" = ?";

        }
        //Column Ctor
        public class Column : Sqlite3.Column
        {
            public Column(string prop_name, System.Type prop_type,
                    string name,
                    bool pk, bool auto_inc, bool unique,
                    bool not_null, string def_value,
                    int? max_len,
                    bool auto_create_ins)
            {
                this.PropertyName = prop_name;
                this.ColumnType = prop_type;

                this.Name = name;
                this.IsPK = pk;
                this.IsAutoInc = auto_inc;
                this.IsUnique = unique;
                this.IsNotNull = not_null;
                this.DefaultValue = def_value;
                this.MaxLength = max_len;
                this.IsAutoCreateIns = auto_create_ins;
            }
            public override void SetValue(object obj, object val)
            {
                var _obj = (RealworldStoryData)obj;
                val = val ?? AutoCreateIns();
                switch (this.PropertyName)
                {
                   case "id":
                        _obj.id=(System.Int32)val;
                        break;
                  case "npc_ids":
                        _obj.npc_ids=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "dialog_ids":
                        _obj.dialog_ids=(System.Collections.Generic.List<System.Int32>)val;
                        break;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            public override object GetValue(object obj)
            {
                var _obj = (RealworldStoryData)obj;
                switch (this.PropertyName)
                {
                   case "id":
                        return _obj.id;
                  case "npc_ids":
                        return _obj.npc_ids;
                  case "dialog_ids":
                        return _obj.dialog_ids;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            private object AutoCreateIns()
            {
                if(!this.IsAutoCreateIns)
                    return null;
                switch (this.PropertyName)
                {
                   case "npc_ids":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "dialog_ids":
                        return new System.Collections.Generic.List<System.Int32>();

                    default:
                        return null;
                }
            }
        }
    }
    public class MonsterLevelDataMappingWarp : Sqlite3.TableMapping
    {
        //Ctor
        public MonsterLevelDataMappingWarp()
        {
            
            this.MappedType = typeof(MonsterLevelData);
            this.TableName = "MonsterLevelData";
            //Columns
            this.PK = new Column("id", typeof(System.Int32), "id", true, false, false, false, null, null, true);
            this.Columns = new[]
            {
                this.PK,
new Column("level", typeof(System.Int32), "level", false, false, false, false, null, null, true),
new Column("attack", typeof(System.Int32), "attack", false, false, false, false, null, null, true),
new Column("defense", typeof(System.Int32), "defense", false, false, false, false, null, null, true),
new Column("health", typeof(System.Int32), "health", false, false, false, false, null, null, true),
new Column("speed", typeof(System.Int32), "speed", false, false, false, false, null, null, true),
new Column("hit", typeof(System.Int32), "hit", false, false, false, false, null, null, true),
new Column("critical", typeof(System.Int32), "critical", false, false, false, false, null, null, true),
new Column("parry", typeof(System.Int32), "parry", false, false, false, false, null, null, true),
new Column("fight_back", typeof(System.Int32), "fight_back", false, false, false, false, null, null, true),
new Column("dodge", typeof(System.Int32), "dodge", false, false, false, false, null, null, true),

            };

            this.GetByPrimaryKeySql = "SELECT * FROM \"MonsterLevelData\" WHERE \"id\" = ?";

        }
        //Column Ctor
        public class Column : Sqlite3.Column
        {
            public Column(string prop_name, System.Type prop_type,
                    string name,
                    bool pk, bool auto_inc, bool unique,
                    bool not_null, string def_value,
                    int? max_len,
                    bool auto_create_ins)
            {
                this.PropertyName = prop_name;
                this.ColumnType = prop_type;

                this.Name = name;
                this.IsPK = pk;
                this.IsAutoInc = auto_inc;
                this.IsUnique = unique;
                this.IsNotNull = not_null;
                this.DefaultValue = def_value;
                this.MaxLength = max_len;
                this.IsAutoCreateIns = auto_create_ins;
            }
            public override void SetValue(object obj, object val)
            {
                var _obj = (MonsterLevelData)obj;
                val = val ?? AutoCreateIns();
                switch (this.PropertyName)
                {
                   case "id":
                        _obj.id=(System.Int32)val;
                        break;
                  case "level":
                        _obj.level=(System.Int32)val;
                        break;
                  case "attack":
                        _obj.attack=(System.Int32)val;
                        break;
                  case "defense":
                        _obj.defense=(System.Int32)val;
                        break;
                  case "health":
                        _obj.health=(System.Int32)val;
                        break;
                  case "speed":
                        _obj.speed=(System.Int32)val;
                        break;
                  case "hit":
                        _obj.hit=(System.Int32)val;
                        break;
                  case "critical":
                        _obj.critical=(System.Int32)val;
                        break;
                  case "parry":
                        _obj.parry=(System.Int32)val;
                        break;
                  case "fight_back":
                        _obj.fight_back=(System.Int32)val;
                        break;
                  case "dodge":
                        _obj.dodge=(System.Int32)val;
                        break;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            public override object GetValue(object obj)
            {
                var _obj = (MonsterLevelData)obj;
                switch (this.PropertyName)
                {
                   case "id":
                        return _obj.id;
                  case "level":
                        return _obj.level;
                  case "attack":
                        return _obj.attack;
                  case "defense":
                        return _obj.defense;
                  case "health":
                        return _obj.health;
                  case "speed":
                        return _obj.speed;
                  case "hit":
                        return _obj.hit;
                  case "critical":
                        return _obj.critical;
                  case "parry":
                        return _obj.parry;
                  case "fight_back":
                        return _obj.fight_back;
                  case "dodge":
                        return _obj.dodge;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            private object AutoCreateIns()
            {
                if(!this.IsAutoCreateIns)
                    return null;
                switch (this.PropertyName)
                {
 
                    default:
                        return null;
                }
            }
        }
    }
    public class JournalDataMappingWarp : Sqlite3.TableMapping
    {
        //Ctor
        public JournalDataMappingWarp()
        {
            
            this.MappedType = typeof(JournalData);
            this.TableName = "JournalData";
            //Columns
            this.PK = new Column("id", typeof(System.Int32), "id", true, false, false, false, null, null, true);
            this.Columns = new[]
            {
                this.PK,
new Column("scene", typeof(System.Int32), "scene", false, false, false, false, null, null, true),
new Column("monster_ids", typeof(System.Int32), "monster_ids", false, false, false, false, null, null, true),
new Column("item_ids", typeof(System.Collections.Generic.List<System.Int32>), "item_ids", false, false, false, false, null, null, true),
new Column("item_types", typeof(System.Collections.Generic.List<System.Int32>), "item_types", false, false, false, false, null, null, true),
new Column("item_ids_num", typeof(System.Collections.Generic.List<System.Int32>), "item_ids_num", false, false, false, false, null, null, true),
new Column("drop_probs", typeof(System.Collections.Generic.List<System.Int32>), "drop_probs", false, false, false, false, null, null, true),
new Column("item_drop_limit", typeof(System.Collections.Generic.List<System.Int32>), "item_drop_limit", false, false, false, false, null, null, true),

            };

            this.GetByPrimaryKeySql = "SELECT * FROM \"JournalData\" WHERE \"id\" = ?";

        }
        //Column Ctor
        public class Column : Sqlite3.Column
        {
            public Column(string prop_name, System.Type prop_type,
                    string name,
                    bool pk, bool auto_inc, bool unique,
                    bool not_null, string def_value,
                    int? max_len,
                    bool auto_create_ins)
            {
                this.PropertyName = prop_name;
                this.ColumnType = prop_type;

                this.Name = name;
                this.IsPK = pk;
                this.IsAutoInc = auto_inc;
                this.IsUnique = unique;
                this.IsNotNull = not_null;
                this.DefaultValue = def_value;
                this.MaxLength = max_len;
                this.IsAutoCreateIns = auto_create_ins;
            }
            public override void SetValue(object obj, object val)
            {
                var _obj = (JournalData)obj;
                val = val ?? AutoCreateIns();
                switch (this.PropertyName)
                {
                   case "id":
                        _obj.id=(System.Int32)val;
                        break;
                  case "scene":
                        _obj.scene=(System.Int32)val;
                        break;
                  case "monster_ids":
                        _obj.monster_ids=(System.Int32)val;
                        break;
                  case "item_ids":
                        _obj.item_ids=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "item_types":
                        _obj.item_types=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "item_ids_num":
                        _obj.item_ids_num=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "drop_probs":
                        _obj.drop_probs=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "item_drop_limit":
                        _obj.item_drop_limit=(System.Collections.Generic.List<System.Int32>)val;
                        break;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            public override object GetValue(object obj)
            {
                var _obj = (JournalData)obj;
                switch (this.PropertyName)
                {
                   case "id":
                        return _obj.id;
                  case "scene":
                        return _obj.scene;
                  case "monster_ids":
                        return _obj.monster_ids;
                  case "item_ids":
                        return _obj.item_ids;
                  case "item_types":
                        return _obj.item_types;
                  case "item_ids_num":
                        return _obj.item_ids_num;
                  case "drop_probs":
                        return _obj.drop_probs;
                  case "item_drop_limit":
                        return _obj.item_drop_limit;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            private object AutoCreateIns()
            {
                if(!this.IsAutoCreateIns)
                    return null;
                switch (this.PropertyName)
                {
                   case "item_ids":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "item_types":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "item_ids_num":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "drop_probs":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "item_drop_limit":
                        return new System.Collections.Generic.List<System.Int32>();

                    default:
                        return null;
                }
            }
        }
    }
    public class EquipEntityMappingWarp : Sqlite3.TableMapping
    {
        //Ctor
        public EquipEntityMappingWarp()
        {
            
            this.MappedType = typeof(EquipEntity);
            this.TableName = "EquipEntity";
            //Columns
            this.PK = new Column("id", typeof(System.Int32), "id", true, true, false, false, null, null, true);
            this.Columns = new[]
            {
                new Column("npc_id", typeof(System.Int32), "npc_id", false, false, false, false, null, null, true),
new Column("parent_id", typeof(System.Int32), "parent_id", false, false, false, false, null, null, true),
new Column("enhance_level", typeof(System.Int32), "enhance_level", false, false, false, false, null, null, true),
new Column("using_state", typeof(System.Int32), "using_state", false, false, false, false, null, null, true),
this.PK,
new Column("equip_name", typeof(System.String), "equip_name", false, false, false, false, null, null, true),
new Column("desc", typeof(System.String), "desc", false, false, false, false, null, null, true),
new Column("source", typeof(System.String), "source", false, false, false, false, null, null, true),
new Column("quality", typeof(System.Int32), "quality", false, false, false, false, null, null, true),
new Column("place", typeof(System.Int32), "place", false, false, false, false, null, null, true),
new Column("icon", typeof(System.String), "icon", false, false, false, false, null, null, true),
new Column("attack", typeof(System.Int32), "attack", false, false, false, false, null, null, true),
new Column("defense", typeof(System.Int32), "defense", false, false, false, false, null, null, true),
new Column("health", typeof(System.Int32), "health", false, false, false, false, null, null, true),
new Column("speed", typeof(System.Int32), "speed", false, false, false, false, null, null, true),
new Column("hit", typeof(System.Int32), "hit", false, false, false, false, null, null, true),
new Column("critical", typeof(System.Int32), "critical", false, false, false, false, null, null, true),
new Column("dodge", typeof(System.Int32), "dodge", false, false, false, false, null, null, true),
new Column("parry", typeof(System.Int32), "parry", false, false, false, false, null, null, true),
new Column("fight_back", typeof(System.Int32), "fight_back", false, false, false, false, null, null, true),
new Column("equip_group_id", typeof(System.Int32), "equip_group_id", false, false, false, false, null, null, true),
new Column("milt_receive", typeof(System.Int32), "milt_receive", false, false, false, false, null, null, true),
new Column("sold", typeof(System.Int32), "sold", false, false, false, false, null, null, true),
new Column("level_limit", typeof(System.Int32), "level_limit", false, false, false, false, null, null, true),

            };

            this.GetByPrimaryKeySql = "SELECT * FROM \"EquipEntity\" WHERE \"id\" = ?";

        }
        //Column Ctor
        public class Column : Sqlite3.Column
        {
            public Column(string prop_name, System.Type prop_type,
                    string name,
                    bool pk, bool auto_inc, bool unique,
                    bool not_null, string def_value,
                    int? max_len,
                    bool auto_create_ins)
            {
                this.PropertyName = prop_name;
                this.ColumnType = prop_type;

                this.Name = name;
                this.IsPK = pk;
                this.IsAutoInc = auto_inc;
                this.IsUnique = unique;
                this.IsNotNull = not_null;
                this.DefaultValue = def_value;
                this.MaxLength = max_len;
                this.IsAutoCreateIns = auto_create_ins;
            }
            public override void SetValue(object obj, object val)
            {
                var _obj = (EquipEntity)obj;
                val = val ?? AutoCreateIns();
                switch (this.PropertyName)
                {
                   case "npc_id":
                        _obj.npc_id=(System.Int32)val;
                        break;
                  case "parent_id":
                        _obj.parent_id=(System.Int32)val;
                        break;
                  case "enhance_level":
                        _obj.enhance_level=(System.Int32)val;
                        break;
                  case "using_state":
                        _obj.using_state=(System.Int32)val;
                        break;
                  case "id":
                        _obj.id=(System.Int32)val;
                        break;
                  case "equip_name":
                        _obj.equip_name=(System.String)val;
                        break;
                  case "desc":
                        _obj.desc=(System.String)val;
                        break;
                  case "source":
                        _obj.source=(System.String)val;
                        break;
                  case "quality":
                        _obj.quality=(System.Int32)val;
                        break;
                  case "place":
                        _obj.place=(System.Int32)val;
                        break;
                  case "icon":
                        _obj.icon=(System.String)val;
                        break;
                  case "attack":
                        _obj.attack=(System.Int32)val;
                        break;
                  case "defense":
                        _obj.defense=(System.Int32)val;
                        break;
                  case "health":
                        _obj.health=(System.Int32)val;
                        break;
                  case "speed":
                        _obj.speed=(System.Int32)val;
                        break;
                  case "hit":
                        _obj.hit=(System.Int32)val;
                        break;
                  case "critical":
                        _obj.critical=(System.Int32)val;
                        break;
                  case "dodge":
                        _obj.dodge=(System.Int32)val;
                        break;
                  case "parry":
                        _obj.parry=(System.Int32)val;
                        break;
                  case "fight_back":
                        _obj.fight_back=(System.Int32)val;
                        break;
                  case "equip_group_id":
                        _obj.equip_group_id=(System.Int32)val;
                        break;
                  case "milt_receive":
                        _obj.milt_receive=(System.Int32)val;
                        break;
                  case "sold":
                        _obj.sold=(System.Int32)val;
                        break;
                  case "level_limit":
                        _obj.level_limit=(System.Int32)val;
                        break;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            public override object GetValue(object obj)
            {
                var _obj = (EquipEntity)obj;
                switch (this.PropertyName)
                {
                   case "npc_id":
                        return _obj.npc_id;
                  case "parent_id":
                        return _obj.parent_id;
                  case "enhance_level":
                        return _obj.enhance_level;
                  case "using_state":
                        return _obj.using_state;
                  case "id":
                        return _obj.id;
                  case "equip_name":
                        return _obj.equip_name;
                  case "desc":
                        return _obj.desc;
                  case "source":
                        return _obj.source;
                  case "quality":
                        return _obj.quality;
                  case "place":
                        return _obj.place;
                  case "icon":
                        return _obj.icon;
                  case "attack":
                        return _obj.attack;
                  case "defense":
                        return _obj.defense;
                  case "health":
                        return _obj.health;
                  case "speed":
                        return _obj.speed;
                  case "hit":
                        return _obj.hit;
                  case "critical":
                        return _obj.critical;
                  case "dodge":
                        return _obj.dodge;
                  case "parry":
                        return _obj.parry;
                  case "fight_back":
                        return _obj.fight_back;
                  case "equip_group_id":
                        return _obj.equip_group_id;
                  case "milt_receive":
                        return _obj.milt_receive;
                  case "sold":
                        return _obj.sold;
                  case "level_limit":
                        return _obj.level_limit;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            private object AutoCreateIns()
            {
                if(!this.IsAutoCreateIns)
                    return null;
                switch (this.PropertyName)
                {
 
                    default:
                        return null;
                }
            }
        }
    }
    public class ItemEntityMappingWarp : Sqlite3.TableMapping
    {
        //Ctor
        public ItemEntityMappingWarp()
        {
            
            this.MappedType = typeof(ItemEntity);
            this.TableName = "ItemEntity";
            //Columns
            this.PK = new Column("id", typeof(System.Int32), "id", true, true, false, false, null, null, true);
            this.Columns = new[]
            {
                new Column("npc_id", typeof(System.Int32), "npc_id", false, false, false, false, null, null, true),
new Column("parent_id", typeof(System.Int32), "parent_id", false, false, false, false, null, null, true),
this.PK,
new Column("item_name", typeof(System.String), "item_name", false, false, false, false, null, null, true),
new Column("desc", typeof(System.String), "desc", false, false, false, false, null, null, true),
new Column("icon", typeof(System.Int32), "icon", false, false, false, false, null, null, true),
new Column("type", typeof(System.Int32), "type", false, false, false, false, null, null, true),
new Column("item_type", typeof(System.Collections.Generic.List<System.Int32>), "item_type", false, false, false, false, null, null, true),
new Column("item_id", typeof(System.Collections.Generic.List<System.Int32>), "item_id", false, false, false, false, null, null, true),
new Column("num", typeof(System.Int32), "num", false, false, false, false, null, null, true),
new Column("drop_pro", typeof(System.Collections.Generic.List<System.Int32>), "drop_pro", false, false, false, false, null, null, true),
new Column("drop_limit", typeof(System.Int32), "drop_limit", false, false, false, false, null, null, true),
new Column("quality", typeof(System.Int32), "quality", false, false, false, false, null, null, true),
new Column("level", typeof(System.Int32), "level", false, false, false, false, null, null, true),
new Column("key_id", typeof(System.Int32), "key_id", false, false, false, false, null, null, true),
new Column("source", typeof(System.String), "source", false, false, false, false, null, null, true),
new Column("pile", typeof(System.Int32), "pile", false, false, false, false, null, null, true),
new Column("can_use", typeof(System.Int32), "can_use", false, false, false, false, null, null, true),
new Column("hide", typeof(System.Int32), "hide", false, false, false, false, null, null, true),
new Column("item_num", typeof(System.Collections.Generic.List<System.Int32>), "item_num", false, false, false, false, null, null, true),
new Column("world_types", typeof(System.Int32), "world_types", false, false, false, false, null, null, true),

            };

            this.GetByPrimaryKeySql = "SELECT * FROM \"ItemEntity\" WHERE \"id\" = ?";

        }
        //Column Ctor
        public class Column : Sqlite3.Column
        {
            public Column(string prop_name, System.Type prop_type,
                    string name,
                    bool pk, bool auto_inc, bool unique,
                    bool not_null, string def_value,
                    int? max_len,
                    bool auto_create_ins)
            {
                this.PropertyName = prop_name;
                this.ColumnType = prop_type;

                this.Name = name;
                this.IsPK = pk;
                this.IsAutoInc = auto_inc;
                this.IsUnique = unique;
                this.IsNotNull = not_null;
                this.DefaultValue = def_value;
                this.MaxLength = max_len;
                this.IsAutoCreateIns = auto_create_ins;
            }
            public override void SetValue(object obj, object val)
            {
                var _obj = (ItemEntity)obj;
                val = val ?? AutoCreateIns();
                switch (this.PropertyName)
                {
                   case "npc_id":
                        _obj.npc_id=(System.Int32)val;
                        break;
                  case "parent_id":
                        _obj.parent_id=(System.Int32)val;
                        break;
                  case "id":
                        _obj.id=(System.Int32)val;
                        break;
                  case "item_name":
                        _obj.item_name=(System.String)val;
                        break;
                  case "desc":
                        _obj.desc=(System.String)val;
                        break;
                  case "icon":
                        _obj.icon=(System.Int32)val;
                        break;
                  case "type":
                        _obj.type=(System.Int32)val;
                        break;
                  case "item_type":
                        _obj.item_type=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "item_id":
                        _obj.item_id=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "num":
                        _obj.num=(System.Int32)val;
                        break;
                  case "drop_pro":
                        _obj.drop_pro=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "drop_limit":
                        _obj.drop_limit=(System.Int32)val;
                        break;
                  case "quality":
                        _obj.quality=(System.Int32)val;
                        break;
                  case "level":
                        _obj.level=(System.Int32)val;
                        break;
                  case "key_id":
                        _obj.key_id=(System.Int32)val;
                        break;
                  case "source":
                        _obj.source=(System.String)val;
                        break;
                  case "pile":
                        _obj.pile=(System.Int32)val;
                        break;
                  case "can_use":
                        _obj.can_use=(System.Int32)val;
                        break;
                  case "hide":
                        _obj.hide=(System.Int32)val;
                        break;
                  case "item_num":
                        _obj.item_num=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "world_types":
                        _obj.world_types=(System.Int32)val;
                        break;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            public override object GetValue(object obj)
            {
                var _obj = (ItemEntity)obj;
                switch (this.PropertyName)
                {
                   case "npc_id":
                        return _obj.npc_id;
                  case "parent_id":
                        return _obj.parent_id;
                  case "id":
                        return _obj.id;
                  case "item_name":
                        return _obj.item_name;
                  case "desc":
                        return _obj.desc;
                  case "icon":
                        return _obj.icon;
                  case "type":
                        return _obj.type;
                  case "item_type":
                        return _obj.item_type;
                  case "item_id":
                        return _obj.item_id;
                  case "num":
                        return _obj.num;
                  case "drop_pro":
                        return _obj.drop_pro;
                  case "drop_limit":
                        return _obj.drop_limit;
                  case "quality":
                        return _obj.quality;
                  case "level":
                        return _obj.level;
                  case "key_id":
                        return _obj.key_id;
                  case "source":
                        return _obj.source;
                  case "pile":
                        return _obj.pile;
                  case "can_use":
                        return _obj.can_use;
                  case "hide":
                        return _obj.hide;
                  case "item_num":
                        return _obj.item_num;
                  case "world_types":
                        return _obj.world_types;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            private object AutoCreateIns()
            {
                if(!this.IsAutoCreateIns)
                    return null;
                switch (this.PropertyName)
                {
                   case "item_type":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "item_id":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "drop_pro":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "item_num":
                        return new System.Collections.Generic.List<System.Int32>();

                    default:
                        return null;
                }
            }
        }
    }
    public class TaskEntityMappingWarp : Sqlite3.TableMapping
    {
        //Ctor
        public TaskEntityMappingWarp()
        {
            
            this.MappedType = typeof(TaskEntity);
            this.TableName = "TaskEntity";
            //Columns
            this.PK = new Column("id", typeof(System.Int32), "id", true, true, false, false, null, null, true);
            this.Columns = new[]
            {
                new Column("parent_id", typeof(System.Int32), "parent_id", false, false, false, false, null, null, true),
new Column("status", typeof(System.Int32), "status", false, false, false, false, null, null, true),
new Column("target_progress", typeof(System.Collections.Generic.List<System.Int32>), "target_progress", false, false, false, false, null, null, true),
this.PK,
new Column("task_name", typeof(System.String), "task_name", false, false, false, false, null, null, true),
new Column("description", typeof(System.String), "description", false, false, false, false, null, null, true),
new Column("icon", typeof(System.String), "icon", false, false, false, false, null, null, true),
new Column("npc_name", typeof(System.Int32), "npc_name", false, false, false, false, null, null, true),
new Column("npc_id", typeof(System.Int32), "npc_id", false, false, false, false, null, null, true),
new Column("group", typeof(System.Int32), "group", false, false, false, false, null, null, true),
new Column("limit_level", typeof(System.Int32), "limit_level", false, false, false, false, null, null, true),
new Column("type", typeof(System.Int32), "type", false, false, false, false, null, null, true),
new Column("condition", typeof(System.Collections.Generic.List<System.Int32>), "condition", false, false, false, false, null, null, true),
new Column("target_num", typeof(System.Collections.Generic.List<System.Int32>), "target_num", false, false, false, false, null, null, true),
new Column("recept_scene", typeof(System.Int32), "recept_scene", false, false, false, false, null, null, true),
new Column("after_id", typeof(System.Int32), "after_id", false, false, false, false, null, null, true),
new Column("reward_types", typeof(System.Collections.Generic.List<System.Int32>), "reward_types", false, false, false, false, null, null, true),
new Column("reward_ids", typeof(System.Collections.Generic.List<System.Int32>), "reward_ids", false, false, false, false, null, null, true),
new Column("reward_numbers", typeof(System.Collections.Generic.List<System.Int32>), "reward_numbers", false, false, false, false, null, null, true),
new Column("receiving_npc", typeof(System.Collections.Generic.List<System.Int32>), "receiving_npc", false, false, false, false, null, null, true),
new Column("receiving_content", typeof(System.Collections.Generic.List<System.Int32>), "receiving_content", false, false, false, false, null, null, true),
new Column("complete_npc", typeof(System.Collections.Generic.List<System.Int32>), "complete_npc", false, false, false, false, null, null, true),
new Column("complete_content", typeof(System.Collections.Generic.List<System.Int32>), "complete_content", false, false, false, false, null, null, true),
new Column("belong", typeof(System.Int32), "belong", false, false, false, false, null, null, true),
new Column("chatType", typeof(System.Int32), "chatType", false, false, false, false, null, null, true),
new Column("time_range", typeof(System.Int32[]), "time_range", false, false, false, false, null, null, true),
new Column("need_battle", typeof(System.Int32), "need_battle", false, false, false, false, null, null, true),
new Column("friends_team", typeof(System.Collections.Generic.List<System.Int32>), "friends_team", false, false, false, false, null, null, true),
new Column("friends_level", typeof(System.Collections.Generic.List<System.Int32>), "friends_level", false, false, false, false, null, null, true),
new Column("enemies_team", typeof(System.Collections.Generic.List<System.Int32>), "enemies_team", false, false, false, false, null, null, true),
new Column("enemies_level", typeof(System.Collections.Generic.List<System.Int32>), "enemies_level", false, false, false, false, null, null, true),
new Column("task_type", typeof(System.Int32), "task_type", false, false, false, false, null, null, true),
new Column("task_commit_type", typeof(System.Int32), "task_commit_type", false, false, false, false, null, null, true),

            };

            this.GetByPrimaryKeySql = "SELECT * FROM \"TaskEntity\" WHERE \"id\" = ?";

        }
        //Column Ctor
        public class Column : Sqlite3.Column
        {
            public Column(string prop_name, System.Type prop_type,
                    string name,
                    bool pk, bool auto_inc, bool unique,
                    bool not_null, string def_value,
                    int? max_len,
                    bool auto_create_ins)
            {
                this.PropertyName = prop_name;
                this.ColumnType = prop_type;

                this.Name = name;
                this.IsPK = pk;
                this.IsAutoInc = auto_inc;
                this.IsUnique = unique;
                this.IsNotNull = not_null;
                this.DefaultValue = def_value;
                this.MaxLength = max_len;
                this.IsAutoCreateIns = auto_create_ins;
            }
            public override void SetValue(object obj, object val)
            {
                var _obj = (TaskEntity)obj;
                val = val ?? AutoCreateIns();
                switch (this.PropertyName)
                {
                   case "parent_id":
                        _obj.parent_id=(System.Int32)val;
                        break;
                  case "status":
                        _obj.status=(System.Int32)val;
                        break;
                  case "target_progress":
                        _obj.target_progress=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "id":
                        _obj.id=(System.Int32)val;
                        break;
                  case "task_name":
                        _obj.task_name=(System.String)val;
                        break;
                  case "description":
                        _obj.description=(System.String)val;
                        break;
                  case "icon":
                        _obj.icon=(System.String)val;
                        break;
                  case "npc_name":
                        _obj.npc_name=(System.Int32)val;
                        break;
                  case "npc_id":
                        _obj.npc_id=(System.Int32)val;
                        break;
                  case "group":
                        _obj.group=(System.Int32)val;
                        break;
                  case "limit_level":
                        _obj.limit_level=(System.Int32)val;
                        break;
                  case "type":
                        _obj.type=(System.Int32)val;
                        break;
                  case "condition":
                        _obj.condition=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "target_num":
                        _obj.target_num=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "recept_scene":
                        _obj.recept_scene=(System.Int32)val;
                        break;
                  case "after_id":
                        _obj.after_id=(System.Int32)val;
                        break;
                  case "reward_types":
                        _obj.reward_types=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "reward_ids":
                        _obj.reward_ids=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "reward_numbers":
                        _obj.reward_numbers=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "receiving_npc":
                        _obj.receiving_npc=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "receiving_content":
                        _obj.receiving_content=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "complete_npc":
                        _obj.complete_npc=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "complete_content":
                        _obj.complete_content=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "belong":
                        _obj.belong=(System.Int32)val;
                        break;
                  case "chatType":
                        _obj.chatType=(System.Int32)val;
                        break;
                  case "time_range":
                        _obj.time_range=(System.Int32[])val;
                        break;
                  case "need_battle":
                        _obj.need_battle=(System.Int32)val;
                        break;
                  case "friends_team":
                        _obj.friends_team=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "friends_level":
                        _obj.friends_level=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "enemies_team":
                        _obj.enemies_team=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "enemies_level":
                        _obj.enemies_level=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "task_type":
                        _obj.task_type=(System.Int32)val;
                        break;
                  case "task_commit_type":
                        _obj.task_commit_type=(System.Int32)val;
                        break;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            public override object GetValue(object obj)
            {
                var _obj = (TaskEntity)obj;
                switch (this.PropertyName)
                {
                   case "parent_id":
                        return _obj.parent_id;
                  case "status":
                        return _obj.status;
                  case "target_progress":
                        return _obj.target_progress;
                  case "id":
                        return _obj.id;
                  case "task_name":
                        return _obj.task_name;
                  case "description":
                        return _obj.description;
                  case "icon":
                        return _obj.icon;
                  case "npc_name":
                        return _obj.npc_name;
                  case "npc_id":
                        return _obj.npc_id;
                  case "group":
                        return _obj.group;
                  case "limit_level":
                        return _obj.limit_level;
                  case "type":
                        return _obj.type;
                  case "condition":
                        return _obj.condition;
                  case "target_num":
                        return _obj.target_num;
                  case "recept_scene":
                        return _obj.recept_scene;
                  case "after_id":
                        return _obj.after_id;
                  case "reward_types":
                        return _obj.reward_types;
                  case "reward_ids":
                        return _obj.reward_ids;
                  case "reward_numbers":
                        return _obj.reward_numbers;
                  case "receiving_npc":
                        return _obj.receiving_npc;
                  case "receiving_content":
                        return _obj.receiving_content;
                  case "complete_npc":
                        return _obj.complete_npc;
                  case "complete_content":
                        return _obj.complete_content;
                  case "belong":
                        return _obj.belong;
                  case "chatType":
                        return _obj.chatType;
                  case "time_range":
                        return _obj.time_range;
                  case "need_battle":
                        return _obj.need_battle;
                  case "friends_team":
                        return _obj.friends_team;
                  case "friends_level":
                        return _obj.friends_level;
                  case "enemies_team":
                        return _obj.enemies_team;
                  case "enemies_level":
                        return _obj.enemies_level;
                  case "task_type":
                        return _obj.task_type;
                  case "task_commit_type":
                        return _obj.task_commit_type;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            private object AutoCreateIns()
            {
                if(!this.IsAutoCreateIns)
                    return null;
                switch (this.PropertyName)
                {
                   case "target_progress":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "condition":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "target_num":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "reward_types":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "reward_ids":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "reward_numbers":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "receiving_npc":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "receiving_content":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "complete_npc":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "complete_content":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "time_range":
                        return new System.Int32[0];
                  case "friends_team":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "friends_level":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "enemies_team":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "enemies_level":
                        return new System.Collections.Generic.List<System.Int32>();

                    default:
                        return null;
                }
            }
        }
    }
    public class EventEntityMappingWarp : Sqlite3.TableMapping
    {
        //Ctor
        public EventEntityMappingWarp()
        {
            
            this.MappedType = typeof(EventEntity);
            this.TableName = "EventEntity";
            //Columns
            this.PK = new Column("id", typeof(System.Int32), "id", true, true, false, false, null, null, true);
            this.Columns = new[]
            {
                new Column("parent_id", typeof(System.Int32), "parent_id", false, false, false, false, null, null, true),
new Column("status", typeof(System.Int32), "status", false, false, false, false, null, null, true),
new Column("target_progress", typeof(System.Collections.Generic.List<System.Int32>), "target_progress", false, false, false, false, null, null, true),
this.PK,
new Column("event_name", typeof(System.String), "event_name", false, false, false, false, null, null, true),
new Column("limit_level", typeof(System.Int32), "limit_level", false, false, false, false, null, null, true),
new Column("limit_reputation", typeof(System.Int32), "limit_reputation", false, false, false, false, null, null, true),
new Column("limit_hamony", typeof(System.Int32), "limit_hamony", false, false, false, false, null, null, true),
new Column("desc", typeof(System.String), "desc", false, false, false, false, null, null, true),
new Column("type", typeof(System.Int32), "type", false, false, false, false, null, null, true),
new Column("item_ids", typeof(System.Collections.Generic.List<System.Int32>), "item_ids", false, false, false, false, null, null, true),
new Column("item_num", typeof(System.Collections.Generic.List<System.Int32>), "item_num", false, false, false, false, null, null, true),
new Column("time_remain", typeof(System.Double), "time_remain", false, false, false, false, null, null, true),
new Column("monster_ids", typeof(System.Collections.Generic.List<System.Int32>), "monster_ids", false, false, false, false, null, null, true),
new Column("monster_num", typeof(System.Collections.Generic.List<System.Int32>), "monster_num", false, false, false, false, null, null, true),
new Column("sence", typeof(System.Int32), "sence", false, false, false, false, null, null, true),
new Column("npc_type", typeof(System.Int32), "npc_type", false, false, false, false, null, null, true),
new Column("npc_confirm", typeof(System.Collections.Generic.List<System.Int32>), "npc_confirm", false, false, false, false, null, null, true),
new Column("npc_ids", typeof(System.Collections.Generic.List<System.Int32>), "npc_ids", false, false, false, false, null, null, true),
new Column("npc_prob", typeof(System.Collections.Generic.List<System.Int32>), "npc_prob", false, false, false, false, null, null, true),
new Column("npc_value_min", typeof(System.Collections.Generic.List<System.Int32>), "npc_value_min", false, false, false, false, null, null, true),
new Column("cost_type", typeof(System.Int32), "cost_type", false, false, false, false, null, null, true),
new Column("cost_num", typeof(System.Int32), "cost_num", false, false, false, false, null, null, true),
new Column("actions", typeof(System.Collections.Generic.List<System.String>), "actions", false, false, false, false, null, null, true),
new Column("action1_name", typeof(System.String), "action1_name", false, false, false, false, null, null, true),
new Column("action1_reward_types", typeof(System.Collections.Generic.List<System.Int32>), "action1_reward_types", false, false, false, false, null, null, true),
new Column("action1_reward_ids", typeof(System.Collections.Generic.List<System.Int32>), "action1_reward_ids", false, false, false, false, null, null, true),
new Column("action1_reward_num", typeof(System.Collections.Generic.List<System.Int32>), "action1_reward_num", false, false, false, false, null, null, true),
new Column("action2_name", typeof(System.String), "action2_name", false, false, false, false, null, null, true),
new Column("action2_reward_types", typeof(System.Collections.Generic.List<System.Int32>), "action2_reward_types", false, false, false, false, null, null, true),
new Column("action2_reward_ids", typeof(System.Collections.Generic.List<System.Int32>), "action2_reward_ids", false, false, false, false, null, null, true),
new Column("action2_reward_num", typeof(System.Collections.Generic.List<System.Int32>), "action2_reward_num", false, false, false, false, null, null, true),
new Column("action3_name", typeof(System.String), "action3_name", false, false, false, false, null, null, true),
new Column("action3_reward_types", typeof(System.Collections.Generic.List<System.Int32>), "action3_reward_types", false, false, false, false, null, null, true),
new Column("action3_reward_ids", typeof(System.Collections.Generic.List<System.Int32>), "action3_reward_ids", false, false, false, false, null, null, true),
new Column("action3_reward_num", typeof(System.Collections.Generic.List<System.Int32>), "action3_reward_num", false, false, false, false, null, null, true),
new Column("action_dialog", typeof(System.String), "action_dialog", false, false, false, false, null, null, true),

            };

            this.GetByPrimaryKeySql = "SELECT * FROM \"EventEntity\" WHERE \"id\" = ?";

        }
        //Column Ctor
        public class Column : Sqlite3.Column
        {
            public Column(string prop_name, System.Type prop_type,
                    string name,
                    bool pk, bool auto_inc, bool unique,
                    bool not_null, string def_value,
                    int? max_len,
                    bool auto_create_ins)
            {
                this.PropertyName = prop_name;
                this.ColumnType = prop_type;

                this.Name = name;
                this.IsPK = pk;
                this.IsAutoInc = auto_inc;
                this.IsUnique = unique;
                this.IsNotNull = not_null;
                this.DefaultValue = def_value;
                this.MaxLength = max_len;
                this.IsAutoCreateIns = auto_create_ins;
            }
            public override void SetValue(object obj, object val)
            {
                var _obj = (EventEntity)obj;
                val = val ?? AutoCreateIns();
                switch (this.PropertyName)
                {
                   case "parent_id":
                        _obj.parent_id=(System.Int32)val;
                        break;
                  case "status":
                        _obj.status=(System.Int32)val;
                        break;
                  case "target_progress":
                        _obj.target_progress=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "id":
                        _obj.id=(System.Int32)val;
                        break;
                  case "event_name":
                        _obj.event_name=(System.String)val;
                        break;
                  case "limit_level":
                        _obj.limit_level=(System.Int32)val;
                        break;
                  case "limit_reputation":
                        _obj.limit_reputation=(System.Int32)val;
                        break;
                  case "limit_hamony":
                        _obj.limit_hamony=(System.Int32)val;
                        break;
                  case "desc":
                        _obj.desc=(System.String)val;
                        break;
                  case "type":
                        _obj.type=(System.Int32)val;
                        break;
                  case "item_ids":
                        _obj.item_ids=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "item_num":
                        _obj.item_num=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "time_remain":
                        _obj.time_remain=(System.Double)val;
                        break;
                  case "monster_ids":
                        _obj.monster_ids=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "monster_num":
                        _obj.monster_num=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "sence":
                        _obj.sence=(System.Int32)val;
                        break;
                  case "npc_type":
                        _obj.npc_type=(System.Int32)val;
                        break;
                  case "npc_confirm":
                        _obj.npc_confirm=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "npc_ids":
                        _obj.npc_ids=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "npc_prob":
                        _obj.npc_prob=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "npc_value_min":
                        _obj.npc_value_min=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "cost_type":
                        _obj.cost_type=(System.Int32)val;
                        break;
                  case "cost_num":
                        _obj.cost_num=(System.Int32)val;
                        break;
                  case "actions":
                        _obj.actions=(System.Collections.Generic.List<System.String>)val;
                        break;
                  case "action1_name":
                        _obj.action1_name=(System.String)val;
                        break;
                  case "action1_reward_types":
                        _obj.action1_reward_types=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "action1_reward_ids":
                        _obj.action1_reward_ids=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "action1_reward_num":
                        _obj.action1_reward_num=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "action2_name":
                        _obj.action2_name=(System.String)val;
                        break;
                  case "action2_reward_types":
                        _obj.action2_reward_types=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "action2_reward_ids":
                        _obj.action2_reward_ids=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "action2_reward_num":
                        _obj.action2_reward_num=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "action3_name":
                        _obj.action3_name=(System.String)val;
                        break;
                  case "action3_reward_types":
                        _obj.action3_reward_types=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "action3_reward_ids":
                        _obj.action3_reward_ids=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "action3_reward_num":
                        _obj.action3_reward_num=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "action_dialog":
                        _obj.action_dialog=(System.String)val;
                        break;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            public override object GetValue(object obj)
            {
                var _obj = (EventEntity)obj;
                switch (this.PropertyName)
                {
                   case "parent_id":
                        return _obj.parent_id;
                  case "status":
                        return _obj.status;
                  case "target_progress":
                        return _obj.target_progress;
                  case "id":
                        return _obj.id;
                  case "event_name":
                        return _obj.event_name;
                  case "limit_level":
                        return _obj.limit_level;
                  case "limit_reputation":
                        return _obj.limit_reputation;
                  case "limit_hamony":
                        return _obj.limit_hamony;
                  case "desc":
                        return _obj.desc;
                  case "type":
                        return _obj.type;
                  case "item_ids":
                        return _obj.item_ids;
                  case "item_num":
                        return _obj.item_num;
                  case "time_remain":
                        return _obj.time_remain;
                  case "monster_ids":
                        return _obj.monster_ids;
                  case "monster_num":
                        return _obj.monster_num;
                  case "sence":
                        return _obj.sence;
                  case "npc_type":
                        return _obj.npc_type;
                  case "npc_confirm":
                        return _obj.npc_confirm;
                  case "npc_ids":
                        return _obj.npc_ids;
                  case "npc_prob":
                        return _obj.npc_prob;
                  case "npc_value_min":
                        return _obj.npc_value_min;
                  case "cost_type":
                        return _obj.cost_type;
                  case "cost_num":
                        return _obj.cost_num;
                  case "actions":
                        return _obj.actions;
                  case "action1_name":
                        return _obj.action1_name;
                  case "action1_reward_types":
                        return _obj.action1_reward_types;
                  case "action1_reward_ids":
                        return _obj.action1_reward_ids;
                  case "action1_reward_num":
                        return _obj.action1_reward_num;
                  case "action2_name":
                        return _obj.action2_name;
                  case "action2_reward_types":
                        return _obj.action2_reward_types;
                  case "action2_reward_ids":
                        return _obj.action2_reward_ids;
                  case "action2_reward_num":
                        return _obj.action2_reward_num;
                  case "action3_name":
                        return _obj.action3_name;
                  case "action3_reward_types":
                        return _obj.action3_reward_types;
                  case "action3_reward_ids":
                        return _obj.action3_reward_ids;
                  case "action3_reward_num":
                        return _obj.action3_reward_num;
                  case "action_dialog":
                        return _obj.action_dialog;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            private object AutoCreateIns()
            {
                if(!this.IsAutoCreateIns)
                    return null;
                switch (this.PropertyName)
                {
                   case "target_progress":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "item_ids":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "item_num":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "monster_ids":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "monster_num":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "npc_confirm":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "npc_ids":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "npc_prob":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "npc_value_min":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "actions":
                        return new System.Collections.Generic.List<System.String>();
                  case "action1_reward_types":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "action1_reward_ids":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "action1_reward_num":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "action2_reward_types":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "action2_reward_ids":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "action2_reward_num":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "action3_reward_types":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "action3_reward_ids":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "action3_reward_num":
                        return new System.Collections.Generic.List<System.Int32>();

                    default:
                        return null;
                }
            }
        }
    }
    public class TaskSectionEntityMappingWarp : Sqlite3.TableMapping
    {
        //Ctor
        public TaskSectionEntityMappingWarp()
        {
            
            this.MappedType = typeof(TaskSectionEntity);
            this.TableName = "TaskSectionEntity";
            //Columns
            this.PK = new Column("id", typeof(System.Int32), "id", true, true, false, false, null, null, true);
            this.Columns = new[]
            {
                new Column("parent_id", typeof(System.Int32), "parent_id", false, false, false, false, null, null, true),
new Column("status", typeof(System.Int32), "status", false, false, false, false, null, null, true),
new Column("target_progress", typeof(System.Collections.Generic.List<System.Int32>), "target_progress", false, false, false, false, null, null, true),
this.PK,
new Column("task_name", typeof(System.String), "task_name", false, false, false, false, null, null, true),
new Column("description", typeof(System.String), "description", false, false, false, false, null, null, true),
new Column("icon", typeof(System.String), "icon", false, false, false, false, null, null, true),
new Column("npc_name", typeof(System.Int32), "npc_name", false, false, false, false, null, null, true),
new Column("npc_id", typeof(System.Int32), "npc_id", false, false, false, false, null, null, true),
new Column("group", typeof(System.Int32), "group", false, false, false, false, null, null, true),
new Column("limit_level", typeof(System.Int32), "limit_level", false, false, false, false, null, null, true),
new Column("type", typeof(System.Int32), "type", false, false, false, false, null, null, true),
new Column("condition", typeof(System.Collections.Generic.List<System.Int32>), "condition", false, false, false, false, null, null, true),
new Column("target_num", typeof(System.Collections.Generic.List<System.Int32>), "target_num", false, false, false, false, null, null, true),
new Column("recept_scene", typeof(System.Int32), "recept_scene", false, false, false, false, null, null, true),
new Column("after_id", typeof(System.Int32), "after_id", false, false, false, false, null, null, true),
new Column("reward_types", typeof(System.Collections.Generic.List<System.Int32>), "reward_types", false, false, false, false, null, null, true),
new Column("reward_ids", typeof(System.Collections.Generic.List<System.Int32>), "reward_ids", false, false, false, false, null, null, true),
new Column("reward_numbers", typeof(System.Collections.Generic.List<System.Int32>), "reward_numbers", false, false, false, false, null, null, true),
new Column("receiving_npc", typeof(System.Collections.Generic.List<System.Int32>), "receiving_npc", false, false, false, false, null, null, true),
new Column("receiving_content", typeof(System.Collections.Generic.List<System.Int32>), "receiving_content", false, false, false, false, null, null, true),
new Column("complete_npc", typeof(System.Collections.Generic.List<System.Int32>), "complete_npc", false, false, false, false, null, null, true),
new Column("complete_content", typeof(System.Collections.Generic.List<System.Int32>), "complete_content", false, false, false, false, null, null, true),
new Column("belong", typeof(System.Int32), "belong", false, false, false, false, null, null, true),
new Column("chatType", typeof(System.Int32), "chatType", false, false, false, false, null, null, true),
new Column("task_type", typeof(System.Int32), "task_type", false, false, false, false, null, null, true),

            };

            this.GetByPrimaryKeySql = "SELECT * FROM \"TaskSectionEntity\" WHERE \"id\" = ?";

        }
        //Column Ctor
        public class Column : Sqlite3.Column
        {
            public Column(string prop_name, System.Type prop_type,
                    string name,
                    bool pk, bool auto_inc, bool unique,
                    bool not_null, string def_value,
                    int? max_len,
                    bool auto_create_ins)
            {
                this.PropertyName = prop_name;
                this.ColumnType = prop_type;

                this.Name = name;
                this.IsPK = pk;
                this.IsAutoInc = auto_inc;
                this.IsUnique = unique;
                this.IsNotNull = not_null;
                this.DefaultValue = def_value;
                this.MaxLength = max_len;
                this.IsAutoCreateIns = auto_create_ins;
            }
            public override void SetValue(object obj, object val)
            {
                var _obj = (TaskSectionEntity)obj;
                val = val ?? AutoCreateIns();
                switch (this.PropertyName)
                {
                   case "parent_id":
                        _obj.parent_id=(System.Int32)val;
                        break;
                  case "status":
                        _obj.status=(System.Int32)val;
                        break;
                  case "target_progress":
                        _obj.target_progress=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "id":
                        _obj.id=(System.Int32)val;
                        break;
                  case "task_name":
                        _obj.task_name=(System.String)val;
                        break;
                  case "description":
                        _obj.description=(System.String)val;
                        break;
                  case "icon":
                        _obj.icon=(System.String)val;
                        break;
                  case "npc_name":
                        _obj.npc_name=(System.Int32)val;
                        break;
                  case "npc_id":
                        _obj.npc_id=(System.Int32)val;
                        break;
                  case "group":
                        _obj.group=(System.Int32)val;
                        break;
                  case "limit_level":
                        _obj.limit_level=(System.Int32)val;
                        break;
                  case "type":
                        _obj.type=(System.Int32)val;
                        break;
                  case "condition":
                        _obj.condition=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "target_num":
                        _obj.target_num=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "recept_scene":
                        _obj.recept_scene=(System.Int32)val;
                        break;
                  case "after_id":
                        _obj.after_id=(System.Int32)val;
                        break;
                  case "reward_types":
                        _obj.reward_types=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "reward_ids":
                        _obj.reward_ids=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "reward_numbers":
                        _obj.reward_numbers=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "receiving_npc":
                        _obj.receiving_npc=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "receiving_content":
                        _obj.receiving_content=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "complete_npc":
                        _obj.complete_npc=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "complete_content":
                        _obj.complete_content=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "belong":
                        _obj.belong=(System.Int32)val;
                        break;
                  case "chatType":
                        _obj.chatType=(System.Int32)val;
                        break;
                  case "task_type":
                        _obj.task_type=(System.Int32)val;
                        break;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            public override object GetValue(object obj)
            {
                var _obj = (TaskSectionEntity)obj;
                switch (this.PropertyName)
                {
                   case "parent_id":
                        return _obj.parent_id;
                  case "status":
                        return _obj.status;
                  case "target_progress":
                        return _obj.target_progress;
                  case "id":
                        return _obj.id;
                  case "task_name":
                        return _obj.task_name;
                  case "description":
                        return _obj.description;
                  case "icon":
                        return _obj.icon;
                  case "npc_name":
                        return _obj.npc_name;
                  case "npc_id":
                        return _obj.npc_id;
                  case "group":
                        return _obj.group;
                  case "limit_level":
                        return _obj.limit_level;
                  case "type":
                        return _obj.type;
                  case "condition":
                        return _obj.condition;
                  case "target_num":
                        return _obj.target_num;
                  case "recept_scene":
                        return _obj.recept_scene;
                  case "after_id":
                        return _obj.after_id;
                  case "reward_types":
                        return _obj.reward_types;
                  case "reward_ids":
                        return _obj.reward_ids;
                  case "reward_numbers":
                        return _obj.reward_numbers;
                  case "receiving_npc":
                        return _obj.receiving_npc;
                  case "receiving_content":
                        return _obj.receiving_content;
                  case "complete_npc":
                        return _obj.complete_npc;
                  case "complete_content":
                        return _obj.complete_content;
                  case "belong":
                        return _obj.belong;
                  case "chatType":
                        return _obj.chatType;
                  case "task_type":
                        return _obj.task_type;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            private object AutoCreateIns()
            {
                if(!this.IsAutoCreateIns)
                    return null;
                switch (this.PropertyName)
                {
                   case "target_progress":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "condition":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "target_num":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "reward_types":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "reward_ids":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "reward_numbers":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "receiving_npc":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "receiving_content":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "complete_npc":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "complete_content":
                        return new System.Collections.Generic.List<System.Int32>();

                    default:
                        return null;
                }
            }
        }
    }
    public class NpcEntityMappingWarp : Sqlite3.TableMapping
    {
        //Ctor
        public NpcEntityMappingWarp()
        {
            
            this.MappedType = typeof(NpcEntity);
            this.TableName = "NpcEntity";
            //Columns
            this.PK = new Column("id", typeof(System.Int32), "id", true, true, false, false, null, null, true);
            this.Columns = new[]
            {
                new Column("parent_id", typeof(System.Int32), "parent_id", false, false, false, false, null, null, true),
new Column("exp", typeof(System.Int32), "exp", false, false, false, false, null, null, true),
new Column("need_exp", typeof(System.Int32), "need_exp", false, false, false, false, null, null, true),
new Column("qulity", typeof(System.Int32), "qulity", false, false, false, false, null, null, true),
this.PK,
new Column("npc_name", typeof(System.String), "npc_name", false, false, false, false, null, null, true),
new Column("description", typeof(System.String), "description", false, false, false, false, null, null, true),
new Column("level", typeof(System.Int32), "level", false, false, false, false, null, null, true),
new Column("parent", typeof(System.Collections.Generic.List<System.Int32>), "parent", false, false, false, false, null, null, true),
new Column("broder", typeof(System.Collections.Generic.List<System.Int32>), "broder", false, false, false, false, null, null, true),
new Column("teacher", typeof(System.Collections.Generic.List<System.Int32>), "teacher", false, false, false, false, null, null, true),
new Column("partner", typeof(System.Collections.Generic.List<System.Int32>), "partner", false, false, false, false, null, null, true),
new Column("iron_friend", typeof(System.Collections.Generic.List<System.Int32>), "iron_friend", false, false, false, false, null, null, true),
new Column("child", typeof(System.Collections.Generic.List<System.Int32>), "child", false, false, false, false, null, null, true),
new Column("younger_generation", typeof(System.Collections.Generic.List<System.Int32>), "younger_generation", false, false, false, false, null, null, true),
new Column("apprentice", typeof(System.Collections.Generic.List<System.Int32>), "apprentice", false, false, false, false, null, null, true),
new Column("enjoy", typeof(System.Collections.Generic.List<System.Int32>), "enjoy", false, false, false, false, null, null, true),
new Column("believe", typeof(System.Collections.Generic.List<System.Int32>), "believe", false, false, false, false, null, null, true),
new Column("benefactor", typeof(System.Collections.Generic.List<System.Int32>), "benefactor", false, false, false, false, null, null, true),
new Column("disguise", typeof(System.Collections.Generic.List<System.Int32>), "disguise", false, false, false, false, null, null, true),
new Column("hate", typeof(System.Collections.Generic.List<System.Int32>), "hate", false, false, false, false, null, null, true),
new Column("hatred", typeof(System.Collections.Generic.List<System.Int32>), "hatred", false, false, false, false, null, null, true),
new Column("gen_gu", typeof(System.Int32), "gen_gu", false, false, false, false, null, null, true),
new Column("wu_xing", typeof(System.Int32), "wu_xing", false, false, false, false, null, null, true),
new Column("mood", typeof(System.Int32), "mood", false, false, false, false, null, null, true),
new Column("health", typeof(System.Int32), "health", false, false, false, false, null, null, true),
new Column("attack", typeof(System.Int32), "attack", false, false, false, false, null, null, true),
new Column("defense", typeof(System.Int32), "defense", false, false, false, false, null, null, true),
new Column("critical", typeof(System.Int32), "critical", false, false, false, false, null, null, true),
new Column("hit", typeof(System.Int32), "hit", false, false, false, false, null, null, true),
new Column("speed", typeof(System.Int32), "speed", false, false, false, false, null, null, true),
new Column("dodge", typeof(System.Int32), "dodge", false, false, false, false, null, null, true),
new Column("fight_back", typeof(System.Int32), "fight_back", false, false, false, false, null, null, true),
new Column("earth", typeof(System.Int32), "earth", false, false, false, false, null, null, true),
new Column("fire", typeof(System.Int32), "fire", false, false, false, false, null, null, true),
new Column("water", typeof(System.Int32), "water", false, false, false, false, null, null, true),
new Column("wind", typeof(System.Int32), "wind", false, false, false, false, null, null, true),
new Column("lighting", typeof(System.Int32), "lighting", false, false, false, false, null, null, true),
new Column("parry", typeof(System.Int32), "parry", false, false, false, false, null, null, true),
new Column("star", typeof(System.Int32), "star", false, false, false, false, null, null, true),
new Column("reputation", typeof(System.Int32), "reputation", false, false, false, false, null, null, true),
new Column("reputation_value", typeof(System.Int32), "reputation_value", false, false, false, false, null, null, true),
new Column("status", typeof(System.Int32), "status", false, false, false, false, null, null, true),
new Column("status_value", typeof(System.Int32), "status_value", false, false, false, false, null, null, true),
new Column("favorite", typeof(System.Int32), "favorite", false, false, false, false, null, null, true),
new Column("age", typeof(System.Int32), "age", false, false, false, false, null, null, true),
new Column("gender", typeof(System.Int32), "gender", false, false, false, false, null, null, true),
new Column("can_see", typeof(System.Int32), "can_see", false, false, false, false, null, null, true),
new Column("level_inition", typeof(System.Int32), "level_inition", false, false, false, false, null, null, true),
new Column("level_max", typeof(System.Int32), "level_max", false, false, false, false, null, null, true),
new Column("levelup_available", typeof(System.Int32), "levelup_available", false, false, false, false, null, null, true),
new Column("levelup_type", typeof(System.Int32), "levelup_type", false, false, false, false, null, null, true),
new Column("icon", typeof(System.String), "icon", false, false, false, false, null, null, true),
new Column("outer_skill", typeof(System.Collections.Generic.List<System.Int32>), "outer_skill", false, false, false, false, null, null, true),
new Column("inner_skill", typeof(System.Collections.Generic.List<System.Int32>), "inner_skill", false, false, false, false, null, null, true),
new Column("shen_fa", typeof(System.Collections.Generic.List<System.Int32>), "shen_fa", false, false, false, false, null, null, true),
new Column("equipment_ids", typeof(System.Collections.Generic.List<System.Int32>), "equipment_ids", false, false, false, false, null, null, true),
new Column("bag_items_ids", typeof(System.Collections.Generic.List<System.Int32>), "bag_items_ids", false, false, false, false, null, null, true),
new Column("bag_item_num", typeof(System.Collections.Generic.List<System.Int32>), "bag_item_num", false, false, false, false, null, null, true),
new Column("charm_type", typeof(System.Int32), "charm_type", false, false, false, false, null, null, true),
new Column("charm_value", typeof(System.Int32), "charm_value", false, false, false, false, null, null, true),
new Column("location", typeof(System.Int32), "location", false, false, false, false, null, null, true),
new Column("model", typeof(System.Int32), "model", false, false, false, false, null, null, true),
new Column("npc_types", typeof(System.Int32), "npc_types", false, false, false, false, null, null, true),
new Column("can_competition", typeof(System.Int32), "can_competition", false, false, false, false, null, null, true),

            };

            this.GetByPrimaryKeySql = "SELECT * FROM \"NpcEntity\" WHERE \"id\" = ?";

        }
        //Column Ctor
        public class Column : Sqlite3.Column
        {
            public Column(string prop_name, System.Type prop_type,
                    string name,
                    bool pk, bool auto_inc, bool unique,
                    bool not_null, string def_value,
                    int? max_len,
                    bool auto_create_ins)
            {
                this.PropertyName = prop_name;
                this.ColumnType = prop_type;

                this.Name = name;
                this.IsPK = pk;
                this.IsAutoInc = auto_inc;
                this.IsUnique = unique;
                this.IsNotNull = not_null;
                this.DefaultValue = def_value;
                this.MaxLength = max_len;
                this.IsAutoCreateIns = auto_create_ins;
            }
            public override void SetValue(object obj, object val)
            {
                var _obj = (NpcEntity)obj;
                val = val ?? AutoCreateIns();
                switch (this.PropertyName)
                {
                   case "parent_id":
                        _obj.parent_id=(System.Int32)val;
                        break;
                  case "exp":
                        _obj.exp=(System.Int32)val;
                        break;
                  case "need_exp":
                        _obj.need_exp=(System.Int32)val;
                        break;
                  case "qulity":
                        _obj.qulity=(System.Int32)val;
                        break;
                  case "id":
                        _obj.id=(System.Int32)val;
                        break;
                  case "npc_name":
                        _obj.npc_name=(System.String)val;
                        break;
                  case "description":
                        _obj.description=(System.String)val;
                        break;
                  case "level":
                        _obj.level=(System.Int32)val;
                        break;
                  case "parent":
                        _obj.parent=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "broder":
                        _obj.broder=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "teacher":
                        _obj.teacher=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "partner":
                        _obj.partner=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "iron_friend":
                        _obj.iron_friend=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "child":
                        _obj.child=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "younger_generation":
                        _obj.younger_generation=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "apprentice":
                        _obj.apprentice=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "enjoy":
                        _obj.enjoy=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "believe":
                        _obj.believe=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "benefactor":
                        _obj.benefactor=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "disguise":
                        _obj.disguise=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "hate":
                        _obj.hate=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "hatred":
                        _obj.hatred=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "gen_gu":
                        _obj.gen_gu=(System.Int32)val;
                        break;
                  case "wu_xing":
                        _obj.wu_xing=(System.Int32)val;
                        break;
                  case "mood":
                        _obj.mood=(System.Int32)val;
                        break;
                  case "health":
                        _obj.health=(System.Int32)val;
                        break;
                  case "attack":
                        _obj.attack=(System.Int32)val;
                        break;
                  case "defense":
                        _obj.defense=(System.Int32)val;
                        break;
                  case "critical":
                        _obj.critical=(System.Int32)val;
                        break;
                  case "hit":
                        _obj.hit=(System.Int32)val;
                        break;
                  case "speed":
                        _obj.speed=(System.Int32)val;
                        break;
                  case "dodge":
                        _obj.dodge=(System.Int32)val;
                        break;
                  case "fight_back":
                        _obj.fight_back=(System.Int32)val;
                        break;
                  case "earth":
                        _obj.earth=(System.Int32)val;
                        break;
                  case "fire":
                        _obj.fire=(System.Int32)val;
                        break;
                  case "water":
                        _obj.water=(System.Int32)val;
                        break;
                  case "wind":
                        _obj.wind=(System.Int32)val;
                        break;
                  case "lighting":
                        _obj.lighting=(System.Int32)val;
                        break;
                  case "parry":
                        _obj.parry=(System.Int32)val;
                        break;
                  case "star":
                        _obj.star=(System.Int32)val;
                        break;
                  case "reputation":
                        _obj.reputation=(System.Int32)val;
                        break;
                  case "reputation_value":
                        _obj.reputation_value=(System.Int32)val;
                        break;
                  case "status":
                        _obj.status=(System.Int32)val;
                        break;
                  case "status_value":
                        _obj.status_value=(System.Int32)val;
                        break;
                  case "favorite":
                        _obj.favorite=(System.Int32)val;
                        break;
                  case "age":
                        _obj.age=(System.Int32)val;
                        break;
                  case "gender":
                        _obj.gender=(System.Int32)val;
                        break;
                  case "can_see":
                        _obj.can_see=(System.Int32)val;
                        break;
                  case "level_inition":
                        _obj.level_inition=(System.Int32)val;
                        break;
                  case "level_max":
                        _obj.level_max=(System.Int32)val;
                        break;
                  case "levelup_available":
                        _obj.levelup_available=(System.Int32)val;
                        break;
                  case "levelup_type":
                        _obj.levelup_type=(System.Int32)val;
                        break;
                  case "icon":
                        _obj.icon=(System.String)val;
                        break;
                  case "outer_skill":
                        _obj.outer_skill=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "inner_skill":
                        _obj.inner_skill=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "shen_fa":
                        _obj.shen_fa=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "equipment_ids":
                        _obj.equipment_ids=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "bag_items_ids":
                        _obj.bag_items_ids=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "bag_item_num":
                        _obj.bag_item_num=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "charm_type":
                        _obj.charm_type=(System.Int32)val;
                        break;
                  case "charm_value":
                        _obj.charm_value=(System.Int32)val;
                        break;
                  case "location":
                        _obj.location=(System.Int32)val;
                        break;
                  case "model":
                        _obj.model=(System.Int32)val;
                        break;
                  case "npc_types":
                        _obj.npc_types=(System.Int32)val;
                        break;
                  case "can_competition":
                        _obj.can_competition=(System.Int32)val;
                        break;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            public override object GetValue(object obj)
            {
                var _obj = (NpcEntity)obj;
                switch (this.PropertyName)
                {
                   case "parent_id":
                        return _obj.parent_id;
                  case "exp":
                        return _obj.exp;
                  case "need_exp":
                        return _obj.need_exp;
                  case "qulity":
                        return _obj.qulity;
                  case "id":
                        return _obj.id;
                  case "npc_name":
                        return _obj.npc_name;
                  case "description":
                        return _obj.description;
                  case "level":
                        return _obj.level;
                  case "parent":
                        return _obj.parent;
                  case "broder":
                        return _obj.broder;
                  case "teacher":
                        return _obj.teacher;
                  case "partner":
                        return _obj.partner;
                  case "iron_friend":
                        return _obj.iron_friend;
                  case "child":
                        return _obj.child;
                  case "younger_generation":
                        return _obj.younger_generation;
                  case "apprentice":
                        return _obj.apprentice;
                  case "enjoy":
                        return _obj.enjoy;
                  case "believe":
                        return _obj.believe;
                  case "benefactor":
                        return _obj.benefactor;
                  case "disguise":
                        return _obj.disguise;
                  case "hate":
                        return _obj.hate;
                  case "hatred":
                        return _obj.hatred;
                  case "gen_gu":
                        return _obj.gen_gu;
                  case "wu_xing":
                        return _obj.wu_xing;
                  case "mood":
                        return _obj.mood;
                  case "health":
                        return _obj.health;
                  case "attack":
                        return _obj.attack;
                  case "defense":
                        return _obj.defense;
                  case "critical":
                        return _obj.critical;
                  case "hit":
                        return _obj.hit;
                  case "speed":
                        return _obj.speed;
                  case "dodge":
                        return _obj.dodge;
                  case "fight_back":
                        return _obj.fight_back;
                  case "earth":
                        return _obj.earth;
                  case "fire":
                        return _obj.fire;
                  case "water":
                        return _obj.water;
                  case "wind":
                        return _obj.wind;
                  case "lighting":
                        return _obj.lighting;
                  case "parry":
                        return _obj.parry;
                  case "star":
                        return _obj.star;
                  case "reputation":
                        return _obj.reputation;
                  case "reputation_value":
                        return _obj.reputation_value;
                  case "status":
                        return _obj.status;
                  case "status_value":
                        return _obj.status_value;
                  case "favorite":
                        return _obj.favorite;
                  case "age":
                        return _obj.age;
                  case "gender":
                        return _obj.gender;
                  case "can_see":
                        return _obj.can_see;
                  case "level_inition":
                        return _obj.level_inition;
                  case "level_max":
                        return _obj.level_max;
                  case "levelup_available":
                        return _obj.levelup_available;
                  case "levelup_type":
                        return _obj.levelup_type;
                  case "icon":
                        return _obj.icon;
                  case "outer_skill":
                        return _obj.outer_skill;
                  case "inner_skill":
                        return _obj.inner_skill;
                  case "shen_fa":
                        return _obj.shen_fa;
                  case "equipment_ids":
                        return _obj.equipment_ids;
                  case "bag_items_ids":
                        return _obj.bag_items_ids;
                  case "bag_item_num":
                        return _obj.bag_item_num;
                  case "charm_type":
                        return _obj.charm_type;
                  case "charm_value":
                        return _obj.charm_value;
                  case "location":
                        return _obj.location;
                  case "model":
                        return _obj.model;
                  case "npc_types":
                        return _obj.npc_types;
                  case "can_competition":
                        return _obj.can_competition;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            private object AutoCreateIns()
            {
                if(!this.IsAutoCreateIns)
                    return null;
                switch (this.PropertyName)
                {
                   case "parent":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "broder":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "teacher":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "partner":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "iron_friend":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "child":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "younger_generation":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "apprentice":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "enjoy":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "believe":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "benefactor":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "disguise":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "hate":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "hatred":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "outer_skill":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "inner_skill":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "shen_fa":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "equipment_ids":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "bag_items_ids":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "bag_item_num":
                        return new System.Collections.Generic.List<System.Int32>();

                    default:
                        return null;
                }
            }
        }
    }
    public class HeroEntityMappingWarp : Sqlite3.TableMapping
    {
        //Ctor
        public HeroEntityMappingWarp()
        {
            
            this.MappedType = typeof(HeroEntity);
            this.TableName = "HeroEntity";
            //Columns
            this.PK = new Column("id", typeof(System.Int32), "id", true, true, false, false, null, null, true);
            this.Columns = new[]
            {
                new Column("parent_id", typeof(System.Int32), "parent_id", false, false, false, false, null, null, true),
new Column("quality", typeof(System.Int32), "quality", false, false, false, false, null, null, true),
this.PK,
new Column("hero_name", typeof(System.String), "hero_name", false, false, false, false, null, null, true),
new Column("level", typeof(System.Int32), "level", false, false, false, false, null, null, true),
new Column("health", typeof(System.Int32), "health", false, false, false, false, null, null, true),
new Column("attack", typeof(System.Int32), "attack", false, false, false, false, null, null, true),
new Column("defense", typeof(System.Int32), "defense", false, false, false, false, null, null, true),
new Column("critical", typeof(System.Int32), "critical", false, false, false, false, null, null, true),
new Column("hit", typeof(System.Int32), "hit", false, false, false, false, null, null, true),
new Column("speed", typeof(System.Int32), "speed", false, false, false, false, null, null, true),
new Column("dodge", typeof(System.Int32), "dodge", false, false, false, false, null, null, true),
new Column("fight_back", typeof(System.Int32), "fight_back", false, false, false, false, null, null, true),
new Column("parry", typeof(System.Int32), "parry", false, false, false, false, null, null, true),
new Column("auto_skills", typeof(System.Collections.Generic.List<System.Int32>), "auto_skills", false, false, false, false, null, null, true),
new Column("auto_skills_round", typeof(System.Collections.Generic.List<System.Int32>), "auto_skills_round", false, false, false, false, null, null, true),
new Column("not_auto_skills", typeof(System.Collections.Generic.List<System.Int32>), "not_auto_skills", false, false, false, false, null, null, true),
new Column("not_auto_skills_round", typeof(System.Collections.Generic.List<System.Int32>), "not_auto_skills_round", false, false, false, false, null, null, true),
new Column("five_attribute", typeof(System.Int32), "five_attribute", false, false, false, false, null, null, true),
new Column("out_skill", typeof(System.Collections.Generic.List<System.Int32>), "out_skill", false, false, false, false, null, null, true),
new Column("inner_skill", typeof(System.Collections.Generic.List<System.Int32>), "inner_skill", false, false, false, false, null, null, true),
new Column("shenfa_skill", typeof(System.Collections.Generic.List<System.Int32>), "shenfa_skill", false, false, false, false, null, null, true),
new Column("model", typeof(System.Int32), "model", false, false, false, false, null, null, true),
new Column("occupation_type", typeof(System.Int32), "occupation_type", false, false, false, false, null, null, true),

            };

            this.GetByPrimaryKeySql = "SELECT * FROM \"HeroEntity\" WHERE \"id\" = ?";

        }
        //Column Ctor
        public class Column : Sqlite3.Column
        {
            public Column(string prop_name, System.Type prop_type,
                    string name,
                    bool pk, bool auto_inc, bool unique,
                    bool not_null, string def_value,
                    int? max_len,
                    bool auto_create_ins)
            {
                this.PropertyName = prop_name;
                this.ColumnType = prop_type;

                this.Name = name;
                this.IsPK = pk;
                this.IsAutoInc = auto_inc;
                this.IsUnique = unique;
                this.IsNotNull = not_null;
                this.DefaultValue = def_value;
                this.MaxLength = max_len;
                this.IsAutoCreateIns = auto_create_ins;
            }
            public override void SetValue(object obj, object val)
            {
                var _obj = (HeroEntity)obj;
                val = val ?? AutoCreateIns();
                switch (this.PropertyName)
                {
                   case "parent_id":
                        _obj.parent_id=(System.Int32)val;
                        break;
                  case "quality":
                        _obj.quality=(System.Int32)val;
                        break;
                  case "id":
                        _obj.id=(System.Int32)val;
                        break;
                  case "hero_name":
                        _obj.hero_name=(System.String)val;
                        break;
                  case "level":
                        _obj.level=(System.Int32)val;
                        break;
                  case "health":
                        _obj.health=(System.Int32)val;
                        break;
                  case "attack":
                        _obj.attack=(System.Int32)val;
                        break;
                  case "defense":
                        _obj.defense=(System.Int32)val;
                        break;
                  case "critical":
                        _obj.critical=(System.Int32)val;
                        break;
                  case "hit":
                        _obj.hit=(System.Int32)val;
                        break;
                  case "speed":
                        _obj.speed=(System.Int32)val;
                        break;
                  case "dodge":
                        _obj.dodge=(System.Int32)val;
                        break;
                  case "fight_back":
                        _obj.fight_back=(System.Int32)val;
                        break;
                  case "parry":
                        _obj.parry=(System.Int32)val;
                        break;
                  case "auto_skills":
                        _obj.auto_skills=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "auto_skills_round":
                        _obj.auto_skills_round=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "not_auto_skills":
                        _obj.not_auto_skills=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "not_auto_skills_round":
                        _obj.not_auto_skills_round=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "five_attribute":
                        _obj.five_attribute=(System.Int32)val;
                        break;
                  case "out_skill":
                        _obj.out_skill=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "inner_skill":
                        _obj.inner_skill=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "shenfa_skill":
                        _obj.shenfa_skill=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "model":
                        _obj.model=(System.Int32)val;
                        break;
                  case "occupation_type":
                        _obj.occupation_type=(System.Int32)val;
                        break;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            public override object GetValue(object obj)
            {
                var _obj = (HeroEntity)obj;
                switch (this.PropertyName)
                {
                   case "parent_id":
                        return _obj.parent_id;
                  case "quality":
                        return _obj.quality;
                  case "id":
                        return _obj.id;
                  case "hero_name":
                        return _obj.hero_name;
                  case "level":
                        return _obj.level;
                  case "health":
                        return _obj.health;
                  case "attack":
                        return _obj.attack;
                  case "defense":
                        return _obj.defense;
                  case "critical":
                        return _obj.critical;
                  case "hit":
                        return _obj.hit;
                  case "speed":
                        return _obj.speed;
                  case "dodge":
                        return _obj.dodge;
                  case "fight_back":
                        return _obj.fight_back;
                  case "parry":
                        return _obj.parry;
                  case "auto_skills":
                        return _obj.auto_skills;
                  case "auto_skills_round":
                        return _obj.auto_skills_round;
                  case "not_auto_skills":
                        return _obj.not_auto_skills;
                  case "not_auto_skills_round":
                        return _obj.not_auto_skills_round;
                  case "five_attribute":
                        return _obj.five_attribute;
                  case "out_skill":
                        return _obj.out_skill;
                  case "inner_skill":
                        return _obj.inner_skill;
                  case "shenfa_skill":
                        return _obj.shenfa_skill;
                  case "model":
                        return _obj.model;
                  case "occupation_type":
                        return _obj.occupation_type;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            private object AutoCreateIns()
            {
                if(!this.IsAutoCreateIns)
                    return null;
                switch (this.PropertyName)
                {
                   case "auto_skills":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "auto_skills_round":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "not_auto_skills":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "not_auto_skills_round":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "out_skill":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "inner_skill":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "shenfa_skill":
                        return new System.Collections.Generic.List<System.Int32>();

                    default:
                        return null;
                }
            }
        }
    }
    public class RealworldHeroEntityMappingWarp : Sqlite3.TableMapping
    {
        //Ctor
        public RealworldHeroEntityMappingWarp()
        {
            
            this.MappedType = typeof(RealworldHeroEntity);
            this.TableName = "RealworldHeroEntity";
            //Columns
            this.PK = new Column("id", typeof(System.Int32), "id", true, true, false, false, null, null, true);
            this.Columns = new[]
            {
                new Column("parent_id", typeof(System.Int32), "parent_id", false, false, false, false, null, null, true),
new Column("b2_hero_entity", typeof(System.Int32), "b2_hero_entity", false, false, false, false, null, null, true),
this.PK,
new Column("hero_name", typeof(System.String), "hero_name", false, false, false, false, null, null, true),
new Column("level", typeof(System.Int32), "level", false, false, false, false, null, null, true),
new Column("health", typeof(System.Single), "health", false, false, false, false, null, null, true),
new Column("attack", typeof(System.Single), "attack", false, false, false, false, null, null, true),
new Column("defense", typeof(System.Single), "defense", false, false, false, false, null, null, true),
new Column("critical", typeof(System.Single), "critical", false, false, false, false, null, null, true),
new Column("hit", typeof(System.Single), "hit", false, false, false, false, null, null, true),
new Column("speed", typeof(System.Single), "speed", false, false, false, false, null, null, true),
new Column("dodge", typeof(System.Single), "dodge", false, false, false, false, null, null, true),
new Column("fight_back", typeof(System.Single), "fight_back", false, false, false, false, null, null, true),
new Column("parry", typeof(System.Single), "parry", false, false, false, false, null, null, true),
new Column("auto_skills", typeof(System.Collections.Generic.List<System.Int32>), "auto_skills", false, false, false, false, null, null, true),
new Column("auto_skills_round", typeof(System.Collections.Generic.List<System.Int32>), "auto_skills_round", false, false, false, false, null, null, true),
new Column("not_auto_skills", typeof(System.Collections.Generic.List<System.Int32>), "not_auto_skills", false, false, false, false, null, null, true),
new Column("not_auto_skills_round", typeof(System.Collections.Generic.List<System.Int32>), "not_auto_skills_round", false, false, false, false, null, null, true),
new Column("five_attribute", typeof(System.Int32), "five_attribute", false, false, false, false, null, null, true),
new Column("out_skill", typeof(System.Collections.Generic.List<System.Int32>), "out_skill", false, false, false, false, null, null, true),
new Column("inner_skill", typeof(System.Collections.Generic.List<System.Int32>), "inner_skill", false, false, false, false, null, null, true),
new Column("shenfa_skill", typeof(System.Collections.Generic.List<System.Int32>), "shenfa_skill", false, false, false, false, null, null, true),
new Column("model", typeof(System.Int32), "model", false, false, false, false, null, null, true),
new Column("occupation_type", typeof(System.Int32), "occupation_type", false, false, false, false, null, null, true),
new Column("geniu_skill", typeof(System.Int32), "geniu_skill", false, false, false, false, null, null, true),
new Column("quality", typeof(System.Int32), "quality", false, false, false, false, null, null, true),
new Column("melt_types", typeof(System.Collections.Generic.List<System.Int32>), "melt_types", false, false, false, false, null, null, true),
new Column("melt_ids", typeof(System.Collections.Generic.List<System.Int32>), "melt_ids", false, false, false, false, null, null, true),
new Column("melt_nums", typeof(System.Collections.Generic.List<System.Int32>), "melt_nums", false, false, false, false, null, null, true),
new Column("oringin_star", typeof(System.Int32), "oringin_star", false, false, false, false, null, null, true),
new Column("star_max_limit", typeof(System.Int32), "star_max_limit", false, false, false, false, null, null, true),
new Column("b2_hero_id", typeof(System.Int32), "b2_hero_id", false, false, false, false, null, null, true),

            };

            this.GetByPrimaryKeySql = "SELECT * FROM \"RealworldHeroEntity\" WHERE \"id\" = ?";

        }
        //Column Ctor
        public class Column : Sqlite3.Column
        {
            public Column(string prop_name, System.Type prop_type,
                    string name,
                    bool pk, bool auto_inc, bool unique,
                    bool not_null, string def_value,
                    int? max_len,
                    bool auto_create_ins)
            {
                this.PropertyName = prop_name;
                this.ColumnType = prop_type;

                this.Name = name;
                this.IsPK = pk;
                this.IsAutoInc = auto_inc;
                this.IsUnique = unique;
                this.IsNotNull = not_null;
                this.DefaultValue = def_value;
                this.MaxLength = max_len;
                this.IsAutoCreateIns = auto_create_ins;
            }
            public override void SetValue(object obj, object val)
            {
                var _obj = (RealworldHeroEntity)obj;
                val = val ?? AutoCreateIns();
                switch (this.PropertyName)
                {
                   case "parent_id":
                        _obj.parent_id=(System.Int32)val;
                        break;
                  case "b2_hero_entity":
                        _obj.b2_hero_entity=(System.Int32)val;
                        break;
                  case "id":
                        _obj.id=(System.Int32)val;
                        break;
                  case "hero_name":
                        _obj.hero_name=(System.String)val;
                        break;
                  case "level":
                        _obj.level=(System.Int32)val;
                        break;
                  case "health":
                        _obj.health=(System.Single)val;
                        break;
                  case "attack":
                        _obj.attack=(System.Single)val;
                        break;
                  case "defense":
                        _obj.defense=(System.Single)val;
                        break;
                  case "critical":
                        _obj.critical=(System.Single)val;
                        break;
                  case "hit":
                        _obj.hit=(System.Single)val;
                        break;
                  case "speed":
                        _obj.speed=(System.Single)val;
                        break;
                  case "dodge":
                        _obj.dodge=(System.Single)val;
                        break;
                  case "fight_back":
                        _obj.fight_back=(System.Single)val;
                        break;
                  case "parry":
                        _obj.parry=(System.Single)val;
                        break;
                  case "auto_skills":
                        _obj.auto_skills=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "auto_skills_round":
                        _obj.auto_skills_round=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "not_auto_skills":
                        _obj.not_auto_skills=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "not_auto_skills_round":
                        _obj.not_auto_skills_round=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "five_attribute":
                        _obj.five_attribute=(System.Int32)val;
                        break;
                  case "out_skill":
                        _obj.out_skill=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "inner_skill":
                        _obj.inner_skill=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "shenfa_skill":
                        _obj.shenfa_skill=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "model":
                        _obj.model=(System.Int32)val;
                        break;
                  case "occupation_type":
                        _obj.occupation_type=(System.Int32)val;
                        break;
                  case "geniu_skill":
                        _obj.geniu_skill=(System.Int32)val;
                        break;
                  case "quality":
                        _obj.quality=(System.Int32)val;
                        break;
                  case "melt_types":
                        _obj.melt_types=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "melt_ids":
                        _obj.melt_ids=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "melt_nums":
                        _obj.melt_nums=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "oringin_star":
                        _obj.oringin_star=(System.Int32)val;
                        break;
                  case "star_max_limit":
                        _obj.star_max_limit=(System.Int32)val;
                        break;
                  case "b2_hero_id":
                        _obj.b2_hero_id=(System.Int32)val;
                        break;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            public override object GetValue(object obj)
            {
                var _obj = (RealworldHeroEntity)obj;
                switch (this.PropertyName)
                {
                   case "parent_id":
                        return _obj.parent_id;
                  case "b2_hero_entity":
                        return _obj.b2_hero_entity;
                  case "id":
                        return _obj.id;
                  case "hero_name":
                        return _obj.hero_name;
                  case "level":
                        return _obj.level;
                  case "health":
                        return _obj.health;
                  case "attack":
                        return _obj.attack;
                  case "defense":
                        return _obj.defense;
                  case "critical":
                        return _obj.critical;
                  case "hit":
                        return _obj.hit;
                  case "speed":
                        return _obj.speed;
                  case "dodge":
                        return _obj.dodge;
                  case "fight_back":
                        return _obj.fight_back;
                  case "parry":
                        return _obj.parry;
                  case "auto_skills":
                        return _obj.auto_skills;
                  case "auto_skills_round":
                        return _obj.auto_skills_round;
                  case "not_auto_skills":
                        return _obj.not_auto_skills;
                  case "not_auto_skills_round":
                        return _obj.not_auto_skills_round;
                  case "five_attribute":
                        return _obj.five_attribute;
                  case "out_skill":
                        return _obj.out_skill;
                  case "inner_skill":
                        return _obj.inner_skill;
                  case "shenfa_skill":
                        return _obj.shenfa_skill;
                  case "model":
                        return _obj.model;
                  case "occupation_type":
                        return _obj.occupation_type;
                  case "geniu_skill":
                        return _obj.geniu_skill;
                  case "quality":
                        return _obj.quality;
                  case "melt_types":
                        return _obj.melt_types;
                  case "melt_ids":
                        return _obj.melt_ids;
                  case "melt_nums":
                        return _obj.melt_nums;
                  case "oringin_star":
                        return _obj.oringin_star;
                  case "star_max_limit":
                        return _obj.star_max_limit;
                  case "b2_hero_id":
                        return _obj.b2_hero_id;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            private object AutoCreateIns()
            {
                if(!this.IsAutoCreateIns)
                    return null;
                switch (this.PropertyName)
                {
                   case "auto_skills":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "auto_skills_round":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "not_auto_skills":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "not_auto_skills_round":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "out_skill":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "inner_skill":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "shenfa_skill":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "melt_types":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "melt_ids":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "melt_nums":
                        return new System.Collections.Generic.List<System.Int32>();

                    default:
                        return null;
                }
            }
        }
    }
    public class SkillCompundEntityMappingWarp : Sqlite3.TableMapping
    {
        //Ctor
        public SkillCompundEntityMappingWarp()
        {
            
            this.MappedType = typeof(SkillCompundEntity);
            this.TableName = "SkillCompundEntity";
            //Columns
            this.PK = new Column("id", typeof(System.Int32), "id", true, true, false, false, null, null, true);
            this.Columns = new[]
            {
                new Column("npc_id", typeof(System.Int32), "npc_id", false, false, false, false, null, null, true),
new Column("parent_id", typeof(System.Int32), "parent_id", false, false, false, false, null, null, true),
new Column("level", typeof(System.Int32), "level", false, false, false, false, null, null, true),
new Column("exp", typeof(System.Int32), "exp", false, false, false, false, null, null, true),
new Column("need_exp", typeof(System.Int32), "need_exp", false, false, false, false, null, null, true),
new Column("using_state", typeof(System.Int32), "using_state", false, false, false, false, null, null, true),
this.PK,
new Column("skill_name", typeof(System.String), "skill_name", false, false, false, false, null, null, true),
new Column("type", typeof(System.Int32), "type", false, false, false, false, null, null, true),
new Column("desc", typeof(System.String), "desc", false, false, false, false, null, null, true),
new Column("skill_ids", typeof(System.Collections.Generic.List<System.Int32>), "skill_ids", false, false, false, false, null, null, true),
new Column("star", typeof(System.Int32), "star", false, false, false, false, null, null, true),
new Column("quality", typeof(System.Int32), "quality", false, false, false, false, null, null, true),
new Column("five_attribute", typeof(System.Int32), "five_attribute", false, false, false, false, null, null, true),
new Column("star_quality_limit", typeof(System.Int32), "star_quality_limit", false, false, false, false, null, null, true),

            };

            this.GetByPrimaryKeySql = "SELECT * FROM \"SkillCompundEntity\" WHERE \"id\" = ?";

        }
        //Column Ctor
        public class Column : Sqlite3.Column
        {
            public Column(string prop_name, System.Type prop_type,
                    string name,
                    bool pk, bool auto_inc, bool unique,
                    bool not_null, string def_value,
                    int? max_len,
                    bool auto_create_ins)
            {
                this.PropertyName = prop_name;
                this.ColumnType = prop_type;

                this.Name = name;
                this.IsPK = pk;
                this.IsAutoInc = auto_inc;
                this.IsUnique = unique;
                this.IsNotNull = not_null;
                this.DefaultValue = def_value;
                this.MaxLength = max_len;
                this.IsAutoCreateIns = auto_create_ins;
            }
            public override void SetValue(object obj, object val)
            {
                var _obj = (SkillCompundEntity)obj;
                val = val ?? AutoCreateIns();
                switch (this.PropertyName)
                {
                   case "npc_id":
                        _obj.npc_id=(System.Int32)val;
                        break;
                  case "parent_id":
                        _obj.parent_id=(System.Int32)val;
                        break;
                  case "level":
                        _obj.level=(System.Int32)val;
                        break;
                  case "exp":
                        _obj.exp=(System.Int32)val;
                        break;
                  case "need_exp":
                        _obj.need_exp=(System.Int32)val;
                        break;
                  case "using_state":
                        _obj.using_state=(System.Int32)val;
                        break;
                  case "id":
                        _obj.id=(System.Int32)val;
                        break;
                  case "skill_name":
                        _obj.skill_name=(System.String)val;
                        break;
                  case "type":
                        _obj.type=(System.Int32)val;
                        break;
                  case "desc":
                        _obj.desc=(System.String)val;
                        break;
                  case "skill_ids":
                        _obj.skill_ids=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "star":
                        _obj.star=(System.Int32)val;
                        break;
                  case "quality":
                        _obj.quality=(System.Int32)val;
                        break;
                  case "five_attribute":
                        _obj.five_attribute=(System.Int32)val;
                        break;
                  case "star_quality_limit":
                        _obj.star_quality_limit=(System.Int32)val;
                        break;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            public override object GetValue(object obj)
            {
                var _obj = (SkillCompundEntity)obj;
                switch (this.PropertyName)
                {
                   case "npc_id":
                        return _obj.npc_id;
                  case "parent_id":
                        return _obj.parent_id;
                  case "level":
                        return _obj.level;
                  case "exp":
                        return _obj.exp;
                  case "need_exp":
                        return _obj.need_exp;
                  case "using_state":
                        return _obj.using_state;
                  case "id":
                        return _obj.id;
                  case "skill_name":
                        return _obj.skill_name;
                  case "type":
                        return _obj.type;
                  case "desc":
                        return _obj.desc;
                  case "skill_ids":
                        return _obj.skill_ids;
                  case "star":
                        return _obj.star;
                  case "quality":
                        return _obj.quality;
                  case "five_attribute":
                        return _obj.five_attribute;
                  case "star_quality_limit":
                        return _obj.star_quality_limit;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            private object AutoCreateIns()
            {
                if(!this.IsAutoCreateIns)
                    return null;
                switch (this.PropertyName)
                {
                   case "skill_ids":
                        return new System.Collections.Generic.List<System.Int32>();

                    default:
                        return null;
                }
            }
        }
    }
    public class PlanData1MappingWarp : Sqlite3.TableMapping
    {
        //Ctor
        public PlanData1MappingWarp()
        {
            
            this.MappedType = typeof(PlanData1);
            this.TableName = "PlanData1";
            //Columns
            this.PK = new Column("id", typeof(System.Int32), "id", true, true, false, false, null, null, true);
            this.Columns = new[]
            {
                this.PK,
new Column("date", typeof(System.String), "date", false, false, false, false, null, null, true),
new Column("types", typeof(System.Collections.Generic.Dictionary<System.Int32,System.Int32>), "types", false, false, false, false, null, null, true),

            };

            this.GetByPrimaryKeySql = "SELECT * FROM \"PlanData1\" WHERE \"id\" = ?";

        }
        //Column Ctor
        public class Column : Sqlite3.Column
        {
            public Column(string prop_name, System.Type prop_type,
                    string name,
                    bool pk, bool auto_inc, bool unique,
                    bool not_null, string def_value,
                    int? max_len,
                    bool auto_create_ins)
            {
                this.PropertyName = prop_name;
                this.ColumnType = prop_type;

                this.Name = name;
                this.IsPK = pk;
                this.IsAutoInc = auto_inc;
                this.IsUnique = unique;
                this.IsNotNull = not_null;
                this.DefaultValue = def_value;
                this.MaxLength = max_len;
                this.IsAutoCreateIns = auto_create_ins;
            }
            public override void SetValue(object obj, object val)
            {
                var _obj = (PlanData1)obj;
                val = val ?? AutoCreateIns();
                switch (this.PropertyName)
                {
                   case "id":
                        _obj.id=(System.Int32)val;
                        break;
                  case "date":
                        _obj.date=(System.String)val;
                        break;
                  case "types":
                        _obj.types=(System.Collections.Generic.Dictionary<System.Int32,System.Int32>)val;
                        break;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            public override object GetValue(object obj)
            {
                var _obj = (PlanData1)obj;
                switch (this.PropertyName)
                {
                   case "id":
                        return _obj.id;
                  case "date":
                        return _obj.date;
                  case "types":
                        return _obj.types;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            private object AutoCreateIns()
            {
                if(!this.IsAutoCreateIns)
                    return null;
                switch (this.PropertyName)
                {
                   case "types":
                        return new System.Collections.Generic.Dictionary<System.Int32,System.Int32>();

                    default:
                        return null;
                }
            }
        }
    }
    public class RealworldItemEntityMappingWarp : Sqlite3.TableMapping
    {
        //Ctor
        public RealworldItemEntityMappingWarp()
        {
            
            this.MappedType = typeof(RealworldItemEntity);
            this.TableName = "RealworldItemEntity";
            //Columns
            this.PK = new Column("id", typeof(System.Int32), "id", true, true, false, false, null, null, true);
            this.Columns = new[]
            {
                new Column("npc_id", typeof(System.Int32), "npc_id", false, false, false, false, null, null, true),
new Column("parent_id", typeof(System.Int32), "parent_id", false, false, false, false, null, null, true),
this.PK,
new Column("item_name", typeof(System.String), "item_name", false, false, false, false, null, null, true),
new Column("desc", typeof(System.String), "desc", false, false, false, false, null, null, true),
new Column("icon", typeof(System.Int32), "icon", false, false, false, false, null, null, true),
new Column("type", typeof(System.Int32), "type", false, false, false, false, null, null, true),
new Column("item_type", typeof(System.Collections.Generic.List<System.Int32>), "item_type", false, false, false, false, null, null, true),
new Column("item_id", typeof(System.Collections.Generic.List<System.Int32>), "item_id", false, false, false, false, null, null, true),
new Column("num", typeof(System.Int32), "num", false, false, false, false, null, null, true),
new Column("drop_pro", typeof(System.Collections.Generic.List<System.Int32>), "drop_pro", false, false, false, false, null, null, true),
new Column("drop_limit", typeof(System.Int32), "drop_limit", false, false, false, false, null, null, true),
new Column("quality", typeof(System.Int32), "quality", false, false, false, false, null, null, true),
new Column("level", typeof(System.Int32), "level", false, false, false, false, null, null, true),
new Column("key_id", typeof(System.Int32), "key_id", false, false, false, false, null, null, true),
new Column("source", typeof(System.String), "source", false, false, false, false, null, null, true),
new Column("pile", typeof(System.Int32), "pile", false, false, false, false, null, null, true),
new Column("can_use", typeof(System.Int32), "can_use", false, false, false, false, null, null, true),
new Column("hide", typeof(System.Int32), "hide", false, false, false, false, null, null, true),
new Column("item_num", typeof(System.Collections.Generic.List<System.Int32>), "item_num", false, false, false, false, null, null, true),
new Column("world_types", typeof(System.Int32), "world_types", false, false, false, false, null, null, true),

            };

            this.GetByPrimaryKeySql = "SELECT * FROM \"RealworldItemEntity\" WHERE \"id\" = ?";

        }
        //Column Ctor
        public class Column : Sqlite3.Column
        {
            public Column(string prop_name, System.Type prop_type,
                    string name,
                    bool pk, bool auto_inc, bool unique,
                    bool not_null, string def_value,
                    int? max_len,
                    bool auto_create_ins)
            {
                this.PropertyName = prop_name;
                this.ColumnType = prop_type;

                this.Name = name;
                this.IsPK = pk;
                this.IsAutoInc = auto_inc;
                this.IsUnique = unique;
                this.IsNotNull = not_null;
                this.DefaultValue = def_value;
                this.MaxLength = max_len;
                this.IsAutoCreateIns = auto_create_ins;
            }
            public override void SetValue(object obj, object val)
            {
                var _obj = (RealworldItemEntity)obj;
                val = val ?? AutoCreateIns();
                switch (this.PropertyName)
                {
                   case "npc_id":
                        _obj.npc_id=(System.Int32)val;
                        break;
                  case "parent_id":
                        _obj.parent_id=(System.Int32)val;
                        break;
                  case "id":
                        _obj.id=(System.Int32)val;
                        break;
                  case "item_name":
                        _obj.item_name=(System.String)val;
                        break;
                  case "desc":
                        _obj.desc=(System.String)val;
                        break;
                  case "icon":
                        _obj.icon=(System.Int32)val;
                        break;
                  case "type":
                        _obj.type=(System.Int32)val;
                        break;
                  case "item_type":
                        _obj.item_type=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "item_id":
                        _obj.item_id=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "num":
                        _obj.num=(System.Int32)val;
                        break;
                  case "drop_pro":
                        _obj.drop_pro=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "drop_limit":
                        _obj.drop_limit=(System.Int32)val;
                        break;
                  case "quality":
                        _obj.quality=(System.Int32)val;
                        break;
                  case "level":
                        _obj.level=(System.Int32)val;
                        break;
                  case "key_id":
                        _obj.key_id=(System.Int32)val;
                        break;
                  case "source":
                        _obj.source=(System.String)val;
                        break;
                  case "pile":
                        _obj.pile=(System.Int32)val;
                        break;
                  case "can_use":
                        _obj.can_use=(System.Int32)val;
                        break;
                  case "hide":
                        _obj.hide=(System.Int32)val;
                        break;
                  case "item_num":
                        _obj.item_num=(System.Collections.Generic.List<System.Int32>)val;
                        break;
                  case "world_types":
                        _obj.world_types=(System.Int32)val;
                        break;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            public override object GetValue(object obj)
            {
                var _obj = (RealworldItemEntity)obj;
                switch (this.PropertyName)
                {
                   case "npc_id":
                        return _obj.npc_id;
                  case "parent_id":
                        return _obj.parent_id;
                  case "id":
                        return _obj.id;
                  case "item_name":
                        return _obj.item_name;
                  case "desc":
                        return _obj.desc;
                  case "icon":
                        return _obj.icon;
                  case "type":
                        return _obj.type;
                  case "item_type":
                        return _obj.item_type;
                  case "item_id":
                        return _obj.item_id;
                  case "num":
                        return _obj.num;
                  case "drop_pro":
                        return _obj.drop_pro;
                  case "drop_limit":
                        return _obj.drop_limit;
                  case "quality":
                        return _obj.quality;
                  case "level":
                        return _obj.level;
                  case "key_id":
                        return _obj.key_id;
                  case "source":
                        return _obj.source;
                  case "pile":
                        return _obj.pile;
                  case "can_use":
                        return _obj.can_use;
                  case "hide":
                        return _obj.hide;
                  case "item_num":
                        return _obj.item_num;
                  case "world_types":
                        return _obj.world_types;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            private object AutoCreateIns()
            {
                if(!this.IsAutoCreateIns)
                    return null;
                switch (this.PropertyName)
                {
                   case "item_type":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "item_id":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "drop_pro":
                        return new System.Collections.Generic.List<System.Int32>();
                  case "item_num":
                        return new System.Collections.Generic.List<System.Int32>();

                    default:
                        return null;
                }
            }
        }
    }
    public class DiaryEntityMappingWarp : Sqlite3.TableMapping
    {
        //Ctor
        public DiaryEntityMappingWarp()
        {
            
            this.MappedType = typeof(DiaryEntity);
            this.TableName = "DiaryEntity";
            //Columns
            this.PK = new Column("id", typeof(System.Int32), "id", true, true, false, false, null, null, true);
            this.Columns = new[]
            {
                this.PK,
new Column("title", typeof(System.String), "title", false, false, false, false, null, null, true),
new Column("content", typeof(System.String), "content", false, false, false, false, null, null, true),
new Column("step", typeof(System.Int32), "step", false, false, false, false, null, null, true),
new Column("distance", typeof(System.Single), "distance", false, false, false, false, null, null, true),
new Column("income", typeof(System.Int32), "income", false, false, false, false, null, null, true),
new Column("outcome", typeof(System.Int32), "outcome", false, false, false, false, null, null, true),
new Column("rank", typeof(System.Int32), "rank", false, false, false, false, null, null, true),
new Column("dayTime", typeof(System.String), "dayTime", false, false, false, false, null, null, true),
new Column("weather", typeof(System.String), "weather", false, false, false, false, null, null, true),
new Column("mood", typeof(System.String), "mood", false, false, false, false, null, null, true),
new Column("temperature", typeof(System.Int32), "temperature", false, false, false, false, null, null, true),
new Column("dicActivity", typeof(System.Collections.Generic.Dictionary<System.Int32,System.Int32>), "dicActivity", false, false, false, false, null, null, true),
new Column("seekTime", typeof(System.Int32), "seekTime", false, false, false, false, null, null, true),

            };

            this.GetByPrimaryKeySql = "SELECT * FROM \"DiaryEntity\" WHERE \"id\" = ?";

        }
        //Column Ctor
        public class Column : Sqlite3.Column
        {
            public Column(string prop_name, System.Type prop_type,
                    string name,
                    bool pk, bool auto_inc, bool unique,
                    bool not_null, string def_value,
                    int? max_len,
                    bool auto_create_ins)
            {
                this.PropertyName = prop_name;
                this.ColumnType = prop_type;

                this.Name = name;
                this.IsPK = pk;
                this.IsAutoInc = auto_inc;
                this.IsUnique = unique;
                this.IsNotNull = not_null;
                this.DefaultValue = def_value;
                this.MaxLength = max_len;
                this.IsAutoCreateIns = auto_create_ins;
            }
            public override void SetValue(object obj, object val)
            {
                var _obj = (DiaryEntity)obj;
                val = val ?? AutoCreateIns();
                switch (this.PropertyName)
                {
                   case "id":
                        _obj.id=(System.Int32)val;
                        break;
                  case "title":
                        _obj.title=(System.String)val;
                        break;
                  case "content":
                        _obj.content=(System.String)val;
                        break;
                  case "step":
                        _obj.step=(System.Int32)val;
                        break;
                  case "distance":
                        _obj.distance=(System.Single)val;
                        break;
                  case "income":
                        _obj.income=(System.Int32)val;
                        break;
                  case "outcome":
                        _obj.outcome=(System.Int32)val;
                        break;
                  case "rank":
                        _obj.rank=(System.Int32)val;
                        break;
                  case "dayTime":
                        _obj.dayTime=(System.String)val;
                        break;
                  case "weather":
                        _obj.weather=(System.String)val;
                        break;
                  case "mood":
                        _obj.mood=(System.String)val;
                        break;
                  case "temperature":
                        _obj.temperature=(System.Int32)val;
                        break;
                  case "dicActivity":
                        _obj.dicActivity=(System.Collections.Generic.Dictionary<System.Int32,System.Int32>)val;
                        break;
                  case "seekTime":
                        _obj.seekTime=(System.Int32)val;
                        break;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            public override object GetValue(object obj)
            {
                var _obj = (DiaryEntity)obj;
                switch (this.PropertyName)
                {
                   case "id":
                        return _obj.id;
                  case "title":
                        return _obj.title;
                  case "content":
                        return _obj.content;
                  case "step":
                        return _obj.step;
                  case "distance":
                        return _obj.distance;
                  case "income":
                        return _obj.income;
                  case "outcome":
                        return _obj.outcome;
                  case "rank":
                        return _obj.rank;
                  case "dayTime":
                        return _obj.dayTime;
                  case "weather":
                        return _obj.weather;
                  case "mood":
                        return _obj.mood;
                  case "temperature":
                        return _obj.temperature;
                  case "dicActivity":
                        return _obj.dicActivity;
                  case "seekTime":
                        return _obj.seekTime;

                    default:
                        throw new System.NotSupportedException("Error prop name: " + this.PropertyName);
                }
            }
            private object AutoCreateIns()
            {
                if(!this.IsAutoCreateIns)
                    return null;
                switch (this.PropertyName)
                {
                   case "dicActivity":
                        return new System.Collections.Generic.Dictionary<System.Int32,System.Int32>();

                    default:
                        return null;
                }
            }
        }
    }
}