using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using PetaPoco;
using System.Configuration;
using System.Text.RegularExpressions;

using System.Xml;
using System.Data;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CodeTool.App_Code
{
    public class ConfigHelper
    {
        public static readonly string ConnectionString = "connectionString";

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static DbType GetDbType(string dbType)
        {
            DbType rusult = DbType.SqlServer;
            switch (dbType)
            {
                case "MySql":
                    rusult = DbType.MySql;
                    break;
                case "Oracle":
                    rusult = DbType.Oracle;
                    break;
                case "SqlServer":
                    rusult = DbType.SqlServer;
                    break; 
            }
            return rusult; 
        }

        public static string GetDataBaseInfo(DbType dbType)
        {
            string rusult = "";
            switch (dbType)
            {
                case DbType.MySql:
                    rusult = "show databases ";
                    break;
                case DbType.Oracle:
                    rusult = "select name from v$tablespace";
                    break;
                case DbType.SqlServer:
                    rusult = "select name from sysdatabases";
                    break;
            }
            return rusult;
        }

        public static string GetTableInfo(DbType dbType)
        {
            string rusult = "";
            switch (dbType)
            {
                case DbType.MySql:
                    rusult = @"select table_name as TableName,TABLE_COMMENT as  TableExplain from information_schema.tables 
                    where table_schema='test' and table_type='base table';
 ";
                    break;
                case DbType.Oracle:
                    rusult = "select   name as TableName,id as TableExplain  from user_tables;";
                    break;
                case DbType.SqlServer:
                    rusult = "select name as TableName,id as TableExplain from sysobjects where xtype='U'";
                    break;
            }
            return rusult;
        }

        #region 语句
        public static readonly string TableName = "^TableName^";
        #region 查询表信息语句 测试支持SQL SERVER
        public static readonly string SqlTableInfo = string.Format(@"
SELECT 
ID=a.colorder,
Tablename=CASE WHEN a.colorder=1 THEN d.name ELSE '' END ,
TableExplain =CASE WHEN a.colorder=1 THEN ISNULL(f.value,'') ELSE '' END,
ColumnName =a.name ,
ColumnIsIdentity =CASE WHEN COLUMNPROPERTY( a.id,a.name,'IsIdentity')=1 THEN 'true'ELSE 'false' END ,
ColumnPrimaryKeyName =CASE WHEN EXISTS(SELECT 1 FROM sysobjects WHERE xtype='PK' AND name IN ( SELECT name FROM sysindexes WHERE indid IN(  SELECT indid FROM sysindexkeys WHERE id = a.id AND colid=a.colid  ))) THEN 'true' ELSE 'false' END  ,
ColumnType=b.name  ,
ColumnByte=a.length  ,
ColumnLength =COLUMNPROPERTY(a.id,a.name,'PRECISION') ,
ColumnDecimal=ISNULL(COLUMNPROPERTY(a.id,a.name,'Scale'),0) ,
ColumnIsEmpty =CASE WHEN a.isnullable=1 THEN 'true'ELSE 'false' END ,
ColumnDefaultValue =ISNULL(e.text,'')  ,
ColumnExplain=ISNULL(g.[value],'') 
 FROM syscolumns a 
 LEFT JOIN systypes b ON a.xusertype=b.xusertype 
 INNER JOIN sysobjects d ON a.id=d.id AND d.xtype='U' AND d.name<>'dtproperties' 
 LEFT JOIN syscomments e ON a.cdefault=e.id
 LEFT JOIN sys.extended_properties g ON a.id=g.major_id AND a.colid=g.minor_id 
 LEFT JOIN sys.extended_properties f ON d.id=f.major_id AND f.minor_id=0 
 WHERE d.name='{0}'  ORDER BY a.id,a.colorder 
", TableName);
        #endregion

        public static readonly string sqlDbInfo = " ";

        //select column_name,data_type,* from test_528.information_schema.columns where table_name='tel'

        #region 查询存储过程

        public static readonly string sqlTempSelect = string.Format(@"CREATE PROCEDURE [dbo].[{0}_Select]
@sqltype int = 1,
@ID int  = 0,
@where_sql nvarchar(max)=null, --查询字段以及条件
@order_by nvarchar(max) =null, 	--排序
@columns  nvarchar(max) =null,  
@CurrentIndex int=1,				--当前页
@PageSize int=10					--当前页显示个数
as
declare @sqlTem nvarchar(max)
declare  @Currenttablename varchar(128)
set @Currenttablename='{0}' ---定义当前操作的主表
if @columns is null
	begin 
		set @columns=' * '
	end
 -----查询主键
 if(@sqltype = 1)
 begin
 	
set @sqlTem = '	select '+@columns+' from  '+@Currenttablename
set @sqlTem = @sqlTem + ' where ID=' +Cast(@ID as nvarchar(50))
--print(@sqltem)
exec(@sqltem)
end
--查询where_sql
if ( @sqltype =2 )
begin

set @sqlTem = '	select '+@columns+' from  '+@Currenttablename
if(@where_sql is not null)
	begin
		set @sqlTem = @sqlTem + ' where '+ @where_sql
	end
if(@order_by is not null) 
	begin
		set @sqlTem= @sqlTem+ ' Order By '+ @order_by
	end
	--print(@sqltem)
exec(@sqltem)
end
----查询 分页的 where_sql
if(@sqltype=3)
begin 
declare  @RecordCount int
declare  @PageCount int 
 
set @CurrentIndex = @CurrentIndex-1
begin
	--创建临时表
	CREATE  TABLE #TempTable
	(	 
		 Counts	 INT 	 
	)
	SET  @sqlTem = 'INSERT INTO #TempTable
	(
		 Counts	  	
	)
	SELECT  Count(ID) as Counts	FROM  '+@Currenttablename
	IF @where_sql IS NOT NULL
		BEGIN
		  SET @sqlTem = @sqlTem + '  WHERE '  + @where_sql
		END
		if @order_by is null
		BEGIN
		  SET  @order_by=' ID desc'
		END
	exec(@sqlTem)

	SELECT @RecordCount =Counts  from #TempTable  /*计算页面数据*/
	SET @PageCount = CEILING(@RecordCount * 1.0 / @PageSize)/* 基于SQL SERVER 2005 */

	set @sqlTem='
	SELECT * FROM(
		SELECT *,ROW_NUMBER() OVER (ORDER BY '+@order_by+') AS SN ,
		'+str(@RecordCount)+' as RecordCount,
		'+str(@PageCount)+' as PageCount
		FROM '+@Currenttablename
		IF @where_sql is not null
		BEGIN
		  SET @sqlTem = @sqlTem + '  where '  + @where_sql
		END

		set @sqlTem = @sqlTem +' ) AS T WHERE T.SN > ('+str(@CurrentIndex)+' * '+str(@PageSize)+') and T.SN <= (('+str(@CurrentIndex)+'+1) * '+str(@PageSize)+') '
	 
	 print @sqlTem
	exec (@sqlTem)
end

end", TableName);
        #endregion


        #endregion
       
       
        public enum DbType
        {
            [Description("MySql")]
            MySql,
            [Description("Oracle")]
            Oracle,
            [Description("SqlServer")]
            SqlServer,
        }

    }
}
