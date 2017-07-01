using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TmpDemo
{
    class ConneDB
    {
        public  MySqlConnection getMySqlCon()
        {
			String mysqlStr = "Database=sim;Data Source=127.0.0.1;User Id=root;Password=root;pooling=false;CharSet=utf8;port=3306";
            // String mySqlCon = ConfigurationManager.ConnectionStrings["MySqlCon"].ConnectionString;
            MySqlConnection mysql = new MySqlConnection(mysqlStr);
            return mysql;
        }

        public  MySqlCommand getSqlCommand(String sql, MySqlConnection mysql)
        {
            MySqlCommand mySqlCommand = new MySqlCommand(sql, mysql);
            //  MySqlCommand mySqlCommand = new MySqlCommand(sql);
            // mySqlCommand.Connection = mysql;
            return mySqlCommand;
        }
        public  List<DataEntity> getResultset(MySqlCommand mySqlCommand)
        {
            List<DataEntity> dataList = new List<DataEntity>();
            
            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    if (reader.HasRows)
                    {
                        DataEntity dataEntity = new DataEntity();

                        dataEntity.setID(reader.GetInt32(0));
                        dataEntity.setValid(reader.GetInt32(1));
                        dataEntity.setTemperature(reader.GetFloat(2));
                        dataEntity.setAddTime(reader.GetString(3));
                        dataEntity.setDevID(reader.GetString(4));

                        dataList.Add(dataEntity);
                        //Console.WriteLine("id:" + reader.GetInt32(0) + "temperature:" + reader.GetFloat(2) + "addTime:" + reader.GetString(3) + "devID:" + reader.GetString(4));
                    }
                }
                //return dataList;
            }
            catch (Exception)
            {
                //Console.WriteLine("查询失败了！");
                MessageBox.Show("数据库查询失败");
            }
            finally
            {
                reader.Close();
            }
            return dataList;
        }



        public List<DataEntity> getList()
        {
            String mysqlStr = "select * from t_temperature";

            MySqlConnection mysql = getMySqlCon();
            
            MySqlCommand cmd = getSqlCommand(mysqlStr,mysql);
            try
            {
                mysql.Open();
            }
            catch(Exception)
            {
                MessageBox.Show("数据库连接失败");
            }
            List<DataEntity> dataList = getResultset(cmd);
            if (dataList == null)
                MessageBox.Show("qwer");
            mysql.Close();
            return dataList;
        }

    }
}