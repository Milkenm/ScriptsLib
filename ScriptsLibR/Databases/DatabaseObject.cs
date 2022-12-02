using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

using ScriptsLibR.Extensions;

using UnityEngine;
/*
namespace ScriptsLibR.Databases
{
	public abstract class DatabaseObject
	{
		private long? Id;
		private Type DbClass;
		private String TableName;

		public DatabaseObject(Type dbClass, String tableName)
		{
			this.DbClass = dbClass;
			this.TableName = tableName;
		}

		public List<MethodInfo> GetGetters()
		{
			List<MethodInfo> getters = new List<MethodInfo>();
			foreach (MethodInfo method in this.GetType().GetMethods())
			{
				if (method.GetCustomAttributes<DbGetter>().Count() == 1)
				{
					getters.Add(method);
				}
			}
			return getters;
		}

		public List<MethodInfo> GetSetters()
		{
			List<MethodInfo> setters = new List<MethodInfo>();
			foreach (MethodInfo method in this.GetType().GetMethods())
			{
				if (method.GetCustomAttributes<DbSetter>().Count() == 1)
				{
					setters.Add(method);
				}
			}
			return setters;
		}

	public String GetTableName()
	{
		return this.TableName;
	}

	public long SaveToDatabase()
	{
		// GET TABLE FIELDS \\
		List<MethodInfo> getters = this.GetGetters();

		if (this.Id == null)
		{
			StringBuilder sb = new StringBuilder();
			for (int i = 0; i < getters.Count; i++)
			{
				if (i > 0)
				{
					sb.Append(",");
				}
				sb.Append("?");
			}

			String sql = "INSERT INTO " + this.GetTableName() + " (" + sb + ") VALUES (" + sb + ")";
			foreach (MethodInfo getter in getters)
			{
				sql = sql.ReplaceFirst("\\?", getter.GetCustomAttribute<DbGetter>().ColumnName);
			}

PreparedStatement ps = DatabasesManager.getInstance().getDatabase(this.dbClass).prepareStatement(sql);
fillStatement(ps, getters);
try
{
	DebugUtils.debug(ps.getParameterMetaData());
	DebugUtils.debug(ps.toString());
}
catch (SQLException e)
{
	throw new RuntimeException(e);
}
DatabasesManager.getInstance().runPreparedStatement(ps, false);

try
{
	this.id = DatabasesManager.getInstance().getDatabase(this.dbClass).getTableLastRowId(this.getTableName());
}
catch (Exception ex)
{
	throw DebugUtils.error(ex);
}
} else
{
	StringBuilder sbUpdate = new StringBuilder();
	for (int i = 0; i < getters.size(); i++)
	{
		if (i > 0)
		{
			sbUpdate.append(", ");
		}
		sbUpdate.append(getters.get(i).getAnnotation(DbGetter.class).columnName()).append("=?");
			}

			 PreparedStatement ps = DatabasesManager.getInstance().getDatabase(this.dbClass).prepareStatement("UPDATE " + this.getTableName() + " SET " + sbUpdate + " WHERE ID=" + id);
this.fillStatement(ps, getters);

DatabasesManager.getInstance().runPreparedStatement(ps, false);
		}
		return this.id;
	}

	public void loadFromDatabase(long id)
{
	// SELECT ROW \\
	ResultSet rs = DatabasesManager.getInstance().getDatabase(this.dbClass).executeSql("SELECT * FROM " + this.getTableName() + " WHERE ID='" + id + "'", true);
	Objects.requireNonNull(rs);

	try
	{
		for (Method method : this.getSetters()) {
	// GET METHOD ANNOTATION \\
	DbSetter setter = method.getAnnotation(DbSetter.class);
DebugUtils.debug("invoke method: " + method.getName() + " for column: " + setter.columnName());
// SET VALUE IN COLUMN \\
Object value = rs.getObject(setter.columnName());

// SPECIFIC TYPE CONVERTIONS \\
// BOOLEAN \\
if (setter.requiredType() == Boolean.class || setter.requiredType() == boolean.class) {
	boolean val = integerToBool((Integer)value);
	method.invoke(this, val);
	continue;
}
				// LONG \\
				else if (setter.requiredType() == Long.class) {

	String val = String.valueOf(value);
	if (StringUtils.isEmpty(val, false))
	{
		method.invoke(this, (Long)null);
		continue;
	}
	method.invoke(this, Long.parseLong(val));
	continue;
}
				// PRIMITIVE LONG \\
				else if (setter.requiredType() == long.class) {

	long val = Long.parseLong(String.valueOf(value));
	method.invoke(this, val);
	continue;
}
				// FLOAT \\
				else if (setter.requiredType() == Float.class) {

	String val = String.valueOf(value);
	if (StringUtils.isEmpty(val, false))
	{
		method.invoke(this, (Float)null);
		continue;
	}
	method.invoke(this, BigDecimal.valueOf((Double)value).floatValue());
	continue;
}
				// PRIMITIVE FLOAT \\
				else if (setter.requiredType() == float.class) {

	float val = BigDecimal.valueOf((Double)value).floatValue();
	method.invoke(this, val);
	continue;
}
				// DOUBLE \\
				else if (setter.requiredType() == Double.class) {
	String val = String.valueOf(value);
	if (StringUtils.isEmpty(val, false))
	{
		method.invoke(this, (Double)null);
		continue;
	}
	method.invoke(this, BigDecimal.valueOf((Double)value).doubleValue());
	continue;
}
				// PRIMITIVE DOUBLE \\
				else if (setter.requiredType() == double.class) {

	double val = BigDecimal.valueOf((Double)value).doubleValue();
	method.invoke(this, val);
	continue;
}
				// INT - WIERD BUG \\
				else if (setter.requiredType() == int.class) {

	int val = Integer.valueOf(rs.getInt(setter.columnName())).intValue();
	method.invoke(this, val);
	continue;
}
				// STRING \\
				else if (setter.requiredType() == String.class) {

	String val = String.valueOf(value);
	method.invoke(this, val);
	continue;
}

// CALL SETTER (GLOBAL TYPE) \\
method.invoke(this, setter.requiredType().cast(value));
			}

			this.id = id;
		} catch (Exception ex)
{
	throw DebugUtils.error(ex);
}
ly
{
	JavaUtils.closeResultSet(rs);
}
	}

	public void deleteFromDatabase()
{
	if (this.id == null)
	{
		return;
	}

	DatabasesManager.getInstance().getDatabase(this.dbClass).executeSql("DELETE FROM " + this.getTableName() + " WHERE ID='" + this.id + "'", true);
}
}

}
*/