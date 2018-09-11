using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeTool.App_Code
{
    /// <summary>
    /// 
    /// </summary>
    public class ColumnInfo
    {
        /// <summary>
        /// 主键
        /// </summary>
        public string primaryKeyName { get; set; }
        /// <summary>
        /// 字段名称
        /// </summary>
        public string ColumnName { get; set; }
        /// <summary>
        /// 标识
        /// </summary>
        public bool ColumnIsIdentity { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        public string ColumnType { get; set; }
        /// <summary>
        /// 字段说明
        /// </summary>
        public string ColumnExplain { get; set; }
        /// <summary>
        /// 默认值
        /// </summary>
        public string ColumnDefaultValue { get; set; }
        /// <summary>
        /// 允许为空
        /// </summary>
        public bool ColumnIsEmpty { get; set; }
        /// <summary>
        /// 字段长度
        /// </summary>
        public string ColumnLength { get; set; }
        /// <summary>
        /// 占用字节
        /// </summary>
        public string ColumnByte { get; set; }

        /// <summary>
        /// 字段小数位数
        /// </summary>
        public string ColumnDecimal { get; set; }
    }

    /// <summary>
    /// 表信息
    /// </summary>
    public class TableInfo
    {
        /// <summary>
        /// 表名
        /// </summary>
        public string TableName { get; set; }
        /// <summary>
        /// 表说明
        /// </summary>
        public string TableExplain { get; set; }
    }
    /// <summary>
    ///数据库的信息
    /// </summary>
    public class DatabaseInfo
    {
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

    }

    /// <summary>
    /// 对象类型。可以是下列值之一
    /// </summary>
    public class DbType123123
    {
        /// <summary>
        ///  C = CHECK 约束 

        /// </summary>
        public string C = "C";

        /// <summary>
        ///  D = 默认值或 DEFAULT 约束
        /// </summary>
        public string D = "D";
        /// <summary>
        ///  F = FOREIGN KEY 约束 
        /// </summary>
        public string F = "F";
        /// <summary>
        /// S = 系统表
        /// </summary>
        public string S = "S";
        /// <summary>
        /// TF = 表函数
        /// </summary>
        public string TF = "TF";
        /// <summary>
        /// TR = 触发器
        /// </summary>
        public string TR = "TR";
        /// <summary>
        ///  U = 用户表
        /// </summary>
        public string U = "U";
        /// <summary>
        /// V = 视图
        /// </summary>
        public string V = "V";
        /// <summary>
        ///  X = 扩展存储过程
        /// </summary>
        public string X = "X";
        /// <summary>
        /// RF = 复制筛选存储过程 
        /// </summary>
        public string RF = "RF";
        /// <summary>
        /// R = 规则  
        /// </summary>
        public string R = "R";

        /// <summary>
        /// P = 存储过程 
        /// </summary>
        public string P = "P";
        /// <summary>
        /// L = 日志 
        /// </summary>
        public string L = "L";
        /// <summary>
        /// FN = 标量函数
        /// </summary>
        public string FN = "FN";
        /// <summary>
        /// IF = 内嵌表函数
        /// </summary>
        public string IF = "IF";
        /// <summary>
        ///  K = PRIMARY KEY 或 UNIQUE 约束 
        /// </summary>
        public string K = "IF";


    }

}
