using System.Collections.Generic;

namespace CodeTool.Common.Model
{
    /// <summary>
    /// 数据库表
    /// </summary>
    public class Table
    {
        /// <summary>
        /// 构造一个空数据库表
        /// </summary>
        public Table()
        {
            this.Fields = new List<Field>();
        }

      
        /// <summary>
        /// 表所属的库
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        public Database Database { get; set; }

        /// <summary>
        /// 表的名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 是否是视图
        /// </summary>
        public bool IsView { get; set; }

        /// <summary>
        /// 表中的所有列
        /// </summary>
        public List<Field> Fields { get; set; }
      
        /// <summary>
        /// 添加一个字段
        /// </summary>
        public void AddField(Field field)
        {
            field.Table = this;
            Fields.Add(field);
        }

        /// <summary>
        /// 转化为字符串
        /// </summary>
        /// <returns>返回表名</returns>
        public override string ToString()
        {
            return this.Name;
        }
      
    }
}
