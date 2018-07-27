using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace common
{
    public class ModelHelper
    {/// <summary>
     /// 将一个实体类复制到另一个实体类
     /// </summary>
     /// <param name="objectsrc">源实体类</param>
     /// <param name="objectdest">复制到的实体类</param>
     /// <param name="excudeFields">不复制的属性</param>
        public void EntityToEntity(object objectsrc, object objectdest, params string[] excudeFields)
        {
            var sourceType = objectsrc.GetType();
            var destType = objectdest.GetType();
            foreach (var item in destType.GetProperties())
            {
                if (excudeFields.Any(x => x.ToUpper() == item.Name))
                    continue;
                item.SetValue(objectdest, sourceType.GetProperty(item.ToString().ToLower()).GetValue(objectsrc, null), null);
            }
        }
        /// <summary>
        /// 将多个实体类复制到另一个实体类
        /// </summary>
        /// <param name="objectsrcList">源实体类列表</param>
        /// <param name="objectdest">复制到的实体类</param>
        /// <param name="excudeFields">不复制的属性</param>
        public static object EntityToEntity(List<object> objectsrcList, object objectdest, params string[] excudeFields)
        {
            foreach (var objectsrc in objectsrcList)
            {
                var sourceType = objectsrc.GetType();
                var destType = objectdest.GetType();
                foreach (var item in destType.GetProperties())
                {
                    if (excudeFields.Any(x => x.ToUpper() == item.Name))
                        continue;
                    item.SetValue(objectdest, sourceType.GetProperty(item.ToString().ToLower()).GetValue(objectsrc, null), null);
                }
            }
            return objectdest;
        }
        /// <summary>
        /// 将多个实体类复制到另一个实体类
        /// </summary>
        /// <param name="objectsrcList">源实体类列表</param>
        /// <param name="objectdest">复制到的实体类</param>
        /// <param name="excudeFields">不复制的属性</param>
        public static object EntityToEntity(object objectsrc, object objectsrcs, object objectdest, params string[] excudeFields)
        {
            var sourceType = objectsrc.GetType();
            var sourcesType = objectsrcs.GetType();
            var destType = objectdest.GetType();
            foreach (var item in destType.GetProperties())
            {
                if (excudeFields.Any(x => x.ToUpper() == item.Name))
                    continue;
                item.SetValue(objectdest, sourceType.GetProperty(item.ToString().ToLower()).GetValue(objectsrc, null), null);
            }
            foreach (var item in destType.GetProperties())
            {
                if (excudeFields.Any(x => x.ToUpper() == item.Name))
                    continue;
                item.SetValue(objectdest, sourcesType.GetProperty(item.ToString().ToLower()).GetValue(objectsrc, null), null);
            }
            return objectdest;
        }
        public static object GetModel(DataTable dt, object model)
        {

            foreach (DataRow row in dt.Rows)
            {
                foreach (var item in model.GetType().GetProperties())
                {
                    if (row.Table.Columns.Contains(item.Name))
                    {
                        if (DBNull.Value != row[item.Name])
                        {
                            item.SetValue(model, Convert.ChangeType(row[item.Name], item.PropertyType), null);
                        }

                    }
                }
            }
            return model;
        }
        /// <summary>
        /// 转Model,指定转换的数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        /// <param name="ds"></param>
        /// <param name="noPase">指定转换的数据</param>
        /// <returns></returns>
        public static List<T> PutAllVal<T>(T entity, DataSet ds, string[] noPase) where T : new()
        {
            List<T> lists = new List<T>();
            for (int i=0;i<ds.Tables.Count;i++)
            {
                if (ds.Tables[i].Rows.Count > 0)
                {
                    foreach (DataRow row in ds.Tables[i].Rows)
                    {
                        lists.Add(PutVal(new T(), row, noPase));
                    }
                }
            }
            return lists;
        }
        public static List<T> PutAllVal<T>(T entity, DataTable dt, string[] noPase) where T : new()
        {
            List<T> lists = new List<T>();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    lists.Add(PutVal(new T(), row, noPase));
                }
            }
            return lists;
        }
        public static T PutVal<T>(T entity, DataRow row, string[] noPase) where T : new()
        {
            //初始化 如果为null
            if (entity == null)
            {
                entity = new T();
            }
            //得到类型
            Type type = typeof(T);
            //取得属性集合
            PropertyInfo[] pi = type.GetProperties();
            foreach (PropertyInfo item in pi)
            {
                try
                {
                    //给属性赋值
                    if (Array.IndexOf<string>(noPase, item.Name) != -1 && row[item.Name] != null && row[item.Name] != DBNull.Value)
                    {
                        if (item.PropertyType == typeof(System.Nullable<System.DateTime>))
                        {
                            item.SetValue(entity, Convert.ToDateTime(row[item.Name].ToString()), null);
                        }
                        else
                        {
                            item.SetValue(entity, Convert.ChangeType(row[item.Name], item.PropertyType), null);
                        }
                    }
                }
                catch (Exception ex)
                {
                }
            }
            return entity;
        }

        /// <summary>
        /// 转MOdel，转换所有，不指定
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        /// <param name="ds"></param>
        /// <returns></returns>
        public static List<T> PutAllVal<T>(T entity, DataSet ds ) where T : new()
        {
            List<T> lists = new List<T>();
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    lists.Add(PutVal(new T(), row));
                }
            }
            return lists;
        }
        public static List<T> PutAllVal<T>(T entity, DataTable dt ) where T : new()
        {
            List<T> lists = new List<T>();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    lists.Add(PutVal(new T(), row));
                }
            }
            return lists;
        }
        public static T PutVal<T>(T entity, DataRow row) where T : new()
        {
            //初始化 如果为null
            if (entity == null)
            {
                entity = new T();
            }
            //得到类型
            Type type = typeof(T);
            //取得属性集合
            PropertyInfo[] pi = type.GetProperties();
            foreach (PropertyInfo item in pi)
            {
                //给属性赋值
                if ( row[item.Name] != null && row[item.Name] != DBNull.Value)
                {
                    if (item.PropertyType == typeof(System.Nullable<System.DateTime>))
                    {
                        item.SetValue(entity, Convert.ToDateTime(row[item.Name].ToString()), null);
                    }
                    else
                    {
                        item.SetValue(entity, Convert.ChangeType(row[item.Name], item.PropertyType), null);
                    }
                }
            }
            return entity;
        }
    }
}
