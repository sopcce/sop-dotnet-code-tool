using System;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace CodeTool.Common.Model
{
    /// <summary>
    /// 字段
    /// </summary>
    public class Field : IComparable
    {
        private string _descn;

        /// <summary>
        /// 所属的数据库表
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        public Table Table { get; set; }

        /// <summary>
        /// 字段序列
        /// </summary>
        public int Pos { get; set; }

        /// <summary>
        /// 字段名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 是否是标识
        /// </summary>
        public bool IsId { get; set; }

        /// <summary>
        /// 是否是主键
        /// </summary>
        public bool IsKey { get; set; }

        /// <summary>
        /// 占用字节数
        /// </summary>
        public int Size { get; set; }

        /// <summary>
        /// 长度
        /// </summary>
        public long Length { get; set; }

        /// <summary>
        /// 是否允许空
        /// </summary>
        public bool AllowNull { get; set; }

        /// <summary>
        /// 默认值
        /// </summary>
        public string DefaultValue { get; set; }

        /// <summary>
        /// 字段说明
        /// </summary>
        public string Descn
        {
            get => !string.IsNullOrEmpty(_descn) ? _descn : Name;
            set => _descn = Regex.Replace(value, @"\s*[\n]+\s*", "");
        }

        /// <summary>
        /// 字段数据类型
        /// </summary>
        public string FieldType { get; set; }

        #region IComparable 成员

        public int CompareTo(object obj)
        {
            Field field = obj as Field;

            if (field != null)
                return this.Pos.CompareTo(field.Pos);
            return Pos;
        }

        #endregion
    }
}
