using System;
using System.ComponentModel;
using System.Windows.Forms;
using CodeTool.Common.Model;
using CodeTool.Config;
using Fabrics;

namespace CodeTool.Forms
{
	public partial class ConnectionForm : Form
	{
		public ConnectionForm()
		{
			InitializeComponent();
			LoadConnectionFromFile();
		}
		#region  LoadConnectionFromFile && SaveConnectionToFile
		private Schema GetSchema()
		{
			Schema schema;
			switch (tcDatabase.SelectedIndex)
			{
			case 0:
				schema = new Schema(accessConn1.ConnectionString, DatabaseTypes.Access);
				return schema;
			case 2:
				schema = new Schema(mySqlConn1.ConnectionString, DatabaseTypes.MySql);
				return schema;
			case 3:
				schema = new Schema(oracleConn1.ConnectionString, DatabaseTypes.Oracle);
				return schema;
			case 4:
				schema = new Schema(sqLiteConn1.ConnectionString, DatabaseTypes.SQLite);
				return schema;
			case 5:
				schema = new Schema(aseConn1.ConnectionString, DatabaseTypes.Ase);
				return schema;
			case 6:
				schema = new Schema(dB2Conn1.ConnectionString, DatabaseTypes.DB2);
				return schema;
			case 7:
				schema = new Schema(postgreSqlConn1.ConnectionString, DatabaseTypes.PostgreSql);
				return schema;
			}
			schema = new Schema();
			schema.ConnectionString = sqlConn1.ConnectionString;
			if (sqlConn1.IsSql2005)
			{
				schema.Type = DatabaseTypes.Sql2005;
			}
			else
			{
				schema.Type = DatabaseTypes.Sql2000;
			}
			return schema;
		}
	  
		private void LoadConnectionFromFile()
		{
			try
			{
				History history = History.Load();
				if (!string.IsNullOrEmpty(history.AccessConn))
				{
					accessConn1.ConnectionString = history.AccessConn;
				}
				if (!string.IsNullOrEmpty(history.SqlServerConn))
				{
					sqlConn1.ConnectionString = history.SqlServerConn;
					sqlConn1.IsSql2005 = (history.DatabaseType == DatabaseTypes.Sql2005);
				}
				if (!string.IsNullOrEmpty(history.MySqlConn))
				{
					mySqlConn1.ConnectionString = history.MySqlConn;
				}
				if (!string.IsNullOrEmpty(history.OracleConn))
				{
					oracleConn1.ConnectionString = history.OracleConn;
				}
				if (!string.IsNullOrEmpty(history.SQLiteConn))
				{
					sqLiteConn1.ConnectionString = history.SQLiteConn;
				}
				if (!string.IsNullOrEmpty(history.AseConn))
				{
					aseConn1.ConnectionString = history.AseConn;
				}
				if (!string.IsNullOrEmpty(history.DB2Conn))
				{
					dB2Conn1.ConnectionString = history.DB2Conn;
				}
				if (!string.IsNullOrEmpty(history.PostgreSqlConn))
				{
					postgreSqlConn1.ConnectionString = history.PostgreSqlConn;
				}
				switch (history.DatabaseType)
				{
					case DatabaseTypes.Access:
						tcDatabase.SelectedIndex = 0;
						goto IL_13E;
					case DatabaseTypes.MySql:
						tcDatabase.SelectedIndex = 2;
						goto IL_13E;
					case DatabaseTypes.Oracle:
						tcDatabase.SelectedIndex = 3;
						goto IL_13E;
					case DatabaseTypes.SQLite:
						tcDatabase.SelectedIndex = 4;
						goto IL_13E;
					case DatabaseTypes.Ase:
						tcDatabase.SelectedIndex = 5;
						goto IL_13E;
					case DatabaseTypes.DB2:
						tcDatabase.SelectedIndex = 6;
						goto IL_13E;
					case DatabaseTypes.PostgreSql:
						tcDatabase.SelectedIndex = 7;
						goto IL_13E;
				}
				tcDatabase.SelectedIndex = 1;
				IL_13E:;
			}
			catch
			{
			}
		}
		private void SaveConnectionToFile()
		{
			History history = History.Load();
			switch (tcDatabase.SelectedIndex)
			{
				case 0:
					history.DatabaseType = DatabaseTypes.Access;
					history.AccessConn = accessConn1.ConnectionString;
					goto IL_CE;
				case 2:
					history.DatabaseType = DatabaseTypes.MySql;
					history.MySqlConn = mySqlConn1.ConnectionString;
					goto IL_CE;
				case 3:
					history.DatabaseType = DatabaseTypes.Oracle;
					history.OracleConn = oracleConn1.ConnectionString;
					goto IL_CE;
				case 4:
					history.DatabaseType = DatabaseTypes.SQLite;
					history.SQLiteConn = sqLiteConn1.ConnectionString;
					goto IL_CE;
				case 5:
					history.DatabaseType = DatabaseTypes.Ase;
					history.AseConn = aseConn1.ConnectionString;
					goto IL_CE;
				case 6:
					history.DatabaseType = DatabaseTypes.DB2;
					history.DB2Conn = dB2Conn1.ConnectionString;
					goto IL_CE;
				case 7:
					history.DatabaseType = DatabaseTypes.PostgreSql;
					history.PostgreSqlConn = postgreSqlConn1.ConnectionString;
					goto IL_CE;
			}
			history.DatabaseType = (sqlConn1.IsSql2005 ? DatabaseTypes.Sql2005 : DatabaseTypes.Sql2000);
			history.SqlServerConn = sqlConn1.ConnectionString;
			IL_CE:
			History.Save(history);
		} 
		#endregion

		private void btnCancel_Click(object sender, EventArgs e)
		{
			if (backgroundWorker1.IsBusy)
			{
				backgroundWorker1.CancelAsync();
			}
			else
			{
				base.DialogResult = DialogResult.Cancel;
				base.Close();
			}
		}
		private void btnConnect_Click(object sender, EventArgs e)
		{
			pictureBox1.Visible = true;
			btnConnect.Enabled = false;
			Schema schema = GetSchema();
			backgroundWorker1.RunWorkerAsync(schema);
		}
		private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
		{
			Schema schema = e.Argument as Schema;
			Database schema2 = schema.GetSchema();
			if (backgroundWorker1.CancellationPending)
			{
				e.Cancel = true;
			}
			else
			{
				e.Result = schema2;
			}
		}
		private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			pictureBox1.Visible = false;
			btnConnect.Enabled = true;
			if (!e.Cancelled)
			{
				if (e.Error != null)
				{
					MessageBoxMessage.Error("连接失败！错误：" + e.Error.Message);
				}
				else
				{
					if (e.Result == null)
					{
						MessageBoxMessage.Error("连接失败！");
					}
					else
					{
						database = (e.Result as Database);
						SaveConnectionToFile();
						base.DialogResult = DialogResult.OK;
						base.Close();
					}
				}
			}
		}
	}
}
