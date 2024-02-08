using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace mysql
{
    public partial class Form1 : Form
    {
        private int time_flow1 = 0;
        int limit_time1 = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main_tm.Start();
            Main_tm.Interval = 100; //주기 0.1초
            Main_tm.Tick += new EventHandler(Main_tm_Tick);
        }

        private void Main_tm_Tick(object sender, EventArgs e)
        {
            string test = test_tb.Text;
            //리미트타임 초기화

            MySqlConnection con = new MySqlConnection("Server = 127.0.0.1; Database = chart_data; Uid = root; Pwd = 8520");
            con.Open();

            //쿼리 선택
            string selectQuery = "SELECT * FROM fake_data WHERE name = \'" + test + "\'";

            MySqlCommand SelectCom = new MySqlCommand(selectQuery, con);
            MySqlDataReader reader = SelectCom.ExecuteReader();

            /*
            if (con.Ping() == true)
                Console.WriteLine("연결--");
            else
                Console.WriteLine("연결실패--");
            */

            while (reader.Read())
            {
                int db_time1 = Convert.ToInt32(reader["time"]);
                BathSolution1_lb.Text = reader["name"].ToString();

                if (test == (string)reader["name"]) 
                {
                    limit_time1 = db_time1;

                    vath1_ct.Series["Series1"].Points.Clear();
                    vath1_ct.Series["Series1"].Points.AddXY("투입경과", time_flow1);
                    vath1_ct.Series["Series1"].Points.AddXY("남은시간", limit_time1 - time_flow1);
                    time_flow1++;

                    if (time_flow1 > limit_time1)
                    {
                        Main_tm.Stop();
                        break;
                    }

                };
            }

            reader.Close();
            con.Close();
        }

        //2번 베스

        private void Form1_Load(object sender, EventArgs e)
        {

            BathSolution2_lb.Text = "인산";

            Bath2_tm.Start();
            Bath2_tm.Interval = 100; //주기 1초
            Bath2_tm.Tick += new EventHandler(Bath2_tm_Tick);
        }

        int time_flow2 = 0;

        private void Bath2_tm_Tick(object sender, EventArgs e)
        {
 

            MySqlConnection con = new MySqlConnection("Server = 127.0.0.1; Database = chart_data; Uid = root; Pwd = 8520");
            con.Open();

            //쿼리 선택
            //string selectQuery = "SELECT * FROM sequence_data WHERE solution = \'" + BathSolution2_lb.Text + "\' ORDER BY outday";
            //string selectQuery = "SELECT * FROM sequence_data WHERE solution = @solution AND outday = (SELECT MAX(outday) FROM sequence_data WHERE solution = @solution)";
            string selectQuery = "SELECT * FROM sequence_data WHERE solution = @solution ORDER BY outday ASC LIMIT 1";

            MySqlCommand SelectCom = new MySqlCommand(selectQuery, con);
            SelectCom.Parameters.AddWithValue("@solution", BathSolution2_lb.Text);
           
            MySqlDataReader reader = SelectCom.ExecuteReader();

            while (reader.Read())
            {
                int limit_time2 = Convert.ToInt32(reader["time"]);
                BathPoroduct2_lb.Text = reader["product"].ToString();

                    if (time_flow2 == limit_time2)
                    {
                        Bath2_ct.Series["Series1"].Points.Clear();
                        Bath2_ct.Series["Series1"].Points.AddXY("투입경과", time_flow2);
                        time_flow2++;
                    }
                    else if (time_flow2 > limit_time2)
                    {
                        Bath2_tm.Stop();
                        break;
                    }
                    else
                    {
                        Bath2_ct.Series["Series1"].Points.Clear();
                        Bath2_ct.Series["Series1"].Points.AddXY("투입경과", time_flow2);
                        Bath2_ct.Series["Series1"].Points.AddXY("남은시간", limit_time2 - time_flow2);
                        time_flow2++;
                    }
                /*
                //이전 코드
                Bath2_ct.Series["Series1"].Points.Clear();
                Bath2_ct.Series["Series1"].Points.AddXY("투입경과", time_flow2);
                Bath2_ct.Series["Series1"].Points.AddXY("남은시간", limit_time2 - time_flow2);
                time_flow2++;

                if (time_flow2 > limit_time2)
                {
                    Bath2_tm.Stop();
                    break;
                }
                */
            }
            reader.Close();
            con.Close();
            /*
            //쿼리삭제
            MySqlConnection connection = new MySqlConnection("Server = 127.0.0.1; Database = chart_data; Uid = root; Pwd = 8520");
            connection.Open();
            string deleteQuery = "DELETE FROM sequence_data WHERE solution = @solution ORDER BY outday ASC LIMIT 1";
            MySqlCommand com = new MySqlCommand(deleteQuery, connection);
            com.Parameters.AddWithValue("@product", BathPoroduct2_lb.Text);
            com.Parameters.AddWithValue("@solution", BathSolution2_lb.Text);
            com.ExecuteNonQuery();
            
            connection.Close();
            */
        }
    }
}
