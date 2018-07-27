using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace common
{
    public class SqlHelpers
    {
        //初始化数据连接
        public static string ConnectionString = null;

        /// <summary>
        /// 执行插入或更新sql
        /// </summary>
        /// <param name="sql">sql</param>
        /// <param name="par">可变防注入参数数组</param>
        /// <returns>返回受影响行数</returns>
        public static int ExecuteNonQuery(string sql, params SqlParameter[] par)
        {
            try
            {
                //建立数据连接
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand cmd = con.CreateCommand())
                    {
                        //打开数据连接
                        if (con.State != ConnectionState.Open) con.Open();
                        //超时设置
                        cmd.CommandTimeout = 6000;
                        cmd.Parameters.AddRange(par);
                        cmd.CommandText = sql;
                        //执行
                        int effectrows = cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                        cmd.Dispose();
                        //返回受影响行数
                        return effectrows;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// 查询数据，返回DataTable
        /// </summary>
        /// <param name="sql">sql</param>
        /// <param name="par">可变防注入参数数组</param>
        /// <returns>数据集DataTable</returns>
        public static DataTable Query(string sql, params SqlParameter[] par)
        {
            try
            {
                //建立数据连接
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand cmd = con.CreateCommand())
                    {
                        //打开数据连接
                        if (con.State != ConnectionState.Open) con.Open();
                        //超时设置
                        cmd.CommandTimeout = 6000;
                        cmd.Parameters.AddRange(par);
                        cmd.CommandText = sql;
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable result = new DataTable();
                            da.Fill(result);
                            //返回数据集
                            return result;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// 查询数据，返回DataSet
        /// </summary>
        /// <param name="sql">sql</param>
        /// <param name="par">可变防注入参数数组</param>
        /// <returns>数据集DataTable</returns>
        public static DataSet Query_dataset(string sql, params SqlParameter[] par)
        {
            try
            {
                //建立数据连接
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand cmd = con.CreateCommand())
                    {
                        //打开数据连接
                        if (con.State != ConnectionState.Open) con.Open();
                        //超时设置
                        cmd.CommandTimeout = 6000;
                        cmd.Parameters.AddRange(par);
                        cmd.CommandText = sql;
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataSet result = new DataSet();
                            da.Fill(result);
                            //返回数据集
                            return result;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        /// <summary>
        /// 查询数据,返回object
        /// </summary>
        /// <param name="sql">sql</param>
        /// <param name="par">可变防注入参数数组</param>
        /// <returns>object</returns>
        public static object ExecuteScalar(string sql, params SqlParameter[] par)
        {
            try
            {
                //建立数据连接
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand cmd = con.CreateCommand())
                    {
                        //打开数据连接
                        if (con.State != ConnectionState.Open) con.Open();
                        //超时设置
                        cmd.CommandTimeout = 6000;
                        cmd.Parameters.AddRange(par);
                        cmd.CommandText = sql;
                        //执行
                        object result = cmd.ExecuteScalar();
                        cmd.Parameters.Clear();
                        cmd.Dispose();
                        //返回查询结果
                        return result;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


    }
}
