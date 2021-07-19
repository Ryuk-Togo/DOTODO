using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;

namespace DOTODO
{
    static class DbInitialize
    {
        
       static  public bool Init()
        {
            SQLiteConnection con;
            bool isDbCreate = false;

            // DBが無ければ作成
            try
            {
                con = new SQLiteConnection("Data Source=todo.sqlite;Version=3;");
            }
            catch (Exception e)
            {
                SQLiteConnection.CreateFile("todo.sqlite");
                con = new SQLiteConnection("Data Source=todo.sqlite;Version=3;");
                isDbCreate = true;
            }

            con.Open();

            // DBを
            try
            {
                string sql;
                SQLiteCommand com;

                // 
                sql = "create table t_do (id int, do_name varchar(256), name varchar(256))";
                com = new SQLiteCommand(sql, con);
                com.ExecuteNonQuery();

                sql = "create table t_todo (id int, do_id int, todo_name varchar(256))";
                com = new SQLiteCommand(sql, con);
                com.ExecuteNonQuery();

            }
            catch (Exception se)
            {
                throw se;
            }

            con.Close();

        }
    }
}
