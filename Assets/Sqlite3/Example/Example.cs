using Sqlite3.Attribute;
using Sqlite3;
using UnityEngine;
using UnityEngine.UI;

public class Example : MonoBehaviour
{
    public InputField m_PathInput;

    private DBConnection conn;

    void Awake()
    {
        ReadPath();
        InitListeners();
    }
    void OnDestroy()
    {
        //Close Connect
        conn?.Close();
    }

    public void Click(string menu)
    {
        switch (menu?.ToLower())
        {
            case "create file":
                DBConnection.CreateFile(m_PathInput.text);
                break;
            //Connection
            case "open conn":
                conn?.Close();
                conn = new DBConnection(m_PathInput.text);
                conn.Open();
                Debug.Log("open conn");
                break;
            case "close conn":
                conn?.Close();
                conn = null;
                Debug.Log("close conn");
                break;
            //Insert/Delete/Update/Query
            case "insert all":
                conn.DropTable<Data>();
                conn.CreateTable<Data>();
                conn.InsertAll(new[]{
                    new Data { id = 1 ,name = "Tom", age = 30 },
                    new Data { id = 2 ,name = "Eric", age = 25 },
                    new Data { id = 3 ,name = "John", age = 41 },
                    new Data { id = 4 ,name = "Ellie", age = 25 },
                });
                Debug.Log("insert all done");
                break;
            case "query":
                Debug.Log(string.Join(" , ", conn.Table<Data>()));
                break;
            case "query by age":
                Debug.Log(string.Join(" , ", conn.Table<Data>().Where(o => o.age == 25)));
                Debug.Log(string.Join(" , ", conn.Table<Data>().Where(o => o.age == 25 && o.name == "Eric")));
                break;
            default:
                Debug.LogWarning("Unkonw menu " + menu);
                break;
        }
    }

    void Test()
    {
        var conn = new DBConnection("your database path");
        conn.Open();

        //表操作
        conn.DropTable<Data>();
        conn.CreateTable<Data>();

        //插入记录
        var data = new Data { id = 1, name = "Tom", age = 30 };
        conn.Insert(data);
        conn.InsertAll(new[]{
            new Data { id = 2 ,name = "Eric", age = 25 },
            new Data { id = 3 ,name = "John", age = 41 },
            new Data { id = 4 ,name = "Ellie", age = 25 },
        });

        //查询记录
        //如果有主键, 将以主键作为where条件
        data = conn.Get<Data>(1);
        //没有主键, 使用TableQuery查询
        var datas = conn.Table<Data>()
            .Where(o => o.age == 25);


        //更新记录
        //如果有主键, 将以主键作为where条件
        conn.Update(data);
        //没有主键, 使用TableQuery查询
        conn.Table<Data>()
            .Where(d => d.id == data.id)
            .Update(data);

        //删除记录
        //如果有主键, 将以主键作为where条件
        conn.Delete(data);
        //没有主键, 使用TableQuery查询
        conn.Table<Data>()
            .Where(d => d.id == data.id)
            .Delete();
    }

    void InitListeners()
    {
        m_PathInput.onEndEdit.AddListener(text =>
        {
            SavePath();
        });
    }

    void ReadPath() => m_PathInput.text = PlayerPrefs.GetString("Example.dbPath", "");
    void SavePath() => PlayerPrefs.SetString("Example.dbPath", m_PathInput.text);

    [Table("Test_Data")]
    public class Data
    {
        [PrimaryKey]
        [AutoIncrement]
        public int id { get; set; }
        public string name { get; set; }
        [Column("Test_age")]
        public int age { get; set; }

        public override string ToString()
        {
            return string.Format("{{id:{0},name:{1},agr:{2}}}", id, name, age);
        }
    }
}
