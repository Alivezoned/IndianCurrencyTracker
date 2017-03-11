using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data.SqlServerCe;

namespace CurrencyTracker
{
    class DatabaseModule
    {
        public String DataSource { get; set; }
        public String TableName { get; set; }

        public DatabaseModule(String dataSource)
        {
            DataSource = dataSource;
        }

        public Boolean AddData(String columnNames, String[] values)
        {
            Boolean status = false;

            String query = "INSERT INTO "+TableName+"("+columnNames+") VALUES ("+valuesString(values)+")";

            using (SqlCeConnection c = new SqlCeConnection(DataSource))
            {
                c.Open();

                using (SqlCeCommand cmd = new SqlCeCommand(query, c))
                {
                    for (int i = 0; i < values.Length; i++)
                    {
                        cmd.Parameters.AddWithValue("@value" + i, values[i]);
                    }

                    cmd.CommandType = System.Data.CommandType.Text;

                    int RowsAffected = cmd.ExecuteNonQuery();
                    if (RowsAffected > 0)
                    {
                        status = true;
                    }
                }

                c.Close();
            }

            return status;
        }

        public String GetData(String query, int columnNumber, Boolean isNumber)
        {
            String data = "";

            using (SqlCeConnection c = new SqlCeConnection(DataSource))
            {
                c.Open();

                using (SqlCeCommand cmd = new SqlCeCommand(query, c))
                {
                    using (SqlCeDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (isNumber)
                            {
                                data = "" + reader.GetInt32(columnNumber);
                            }
                            else
                            {
                                data = reader.GetString(columnNumber);
                            }
                        }

                        reader.Close();
                    }
                }

                c.Close();
            }

            return data;
        }

        public List<float> GetCurrencyList()
        {
            List<float> floatList = new List<float>();

            using (SqlCeConnection c = new SqlCeConnection(DataSource))
            {
                c.Open();
                using (SqlCeCommand cmd = new SqlCeCommand("SELECT * FROM "+TableName, c))
                {
                    using (SqlCeDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            String value = reader.GetValue(1)+"";
                            float v = float.Parse(value);
                            floatList.Add(v);
                        }
                    }
                }
                c.Close();
            }

            return floatList;
        }

        private String valuesString(String[] values)
        {
            String valueList = "";

            for (int i = 0; i < values.Length; i++)
            {
                if (i == (values.Length - 1))
                {
                    valueList += "@value" + i;
                }
                else
                {
                    valueList += "@value" + i + ",";
                }
            }

            return valueList;
        }
    }
}
