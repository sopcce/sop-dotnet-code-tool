namespace CodeTool
{
    
    /// <summary>
    /// 步骤节点
    /// </summary>
    public enum Step
    {
        /// <summary>
        /// 设置连接信息
        /// </summary>
        SetConnection,

        /// <summary>
        /// 选择数据库
        /// </summary>
        SelectDataBase,

        /// <summary>
        /// 选择数据表
        /// </summary>
        SelectTables,

        /// <summary>
        /// 选择视图
        /// </summary>
        SelectViews,

        /// <summary>
        /// 设置路径等其他设置
        /// </summary>
        SetOption,

        /// <summary>
        /// 执行
        /// </summary>
        Execute
    }
}
