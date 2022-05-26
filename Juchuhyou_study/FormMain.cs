using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Juchuhyou_study
{
    public partial class FormMain : Form
    {
        SqlConnection connection = null;

        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// データの作成
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            string strTokuisakiName = tokuisakiName.Text;

            //データベース接続
            if (dBConnect(ref connection) == true)
            {
                //SQL文
                string strSql = "SELECT * FROM JuchuhyouMain where TokuisakiName = @tokuisakiName";

                try
                {

                    SqlCommand command = connection.CreateCommand();
                    command.CommandText = @strSql;
                    command.Parameters.Add(new SqlParameter("@tokuisakiName", strTokuisakiName));
                    var adapter = new SqlDataAdapter(command);
                    adapter.Fill(juchuhyouDataSet.JuchuhyouMain);


                    /*
                    SqlCommand command = connection.CreateCommand();
                    command.CommandText = @strSql;
                    command.Parameters.Add(new SqlParameter("@tokuisakiName", strTokuisakiName));
                    var adapter = new SqlDataAdapter(command);
                    adapter.Fill(JuchuReport);
                    */

                }
                catch
                {
                    MessageBox.Show("データの取得に失敗しました。");
                }
                if (juchuhyouDataSet.JuchuhyouMain.Rows.Count == 0)
                //if (JuchuReport.Rows.Count == 0)
                {
                    MessageBox.Show("印刷する情報がありません", "情報", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
                else if (juchuhyouDataSet.JuchuhyouMain.Rows.Count >= 1)
                //else if (JuchuReport.Rows.Count >= 1)
                {

                    //データを格納
                    int intRowCount = 0;
                    int intRow = 0;
                    DataRow dataRow = null;

                    for (int i = 1; i <= juchuhyouDataSet.JuchuhyouMain.Rows.Count; i++)
                    {
                        // Windowsキューを実行
                        if ((i % 15) == 0)
                        {
                            Application.DoEvents();
                        }

                        intRow = i - 1;
                        intRowCount = intRowCount + 1;

                        //情報の代入
                        dataRow = JuchuReport2.NewRow();
                        dataRow["kaiPageGroup"] = stringReturn(juchuhyouDataSet.JuchuhyouMain[intRow]["TokuiCode"]) + "::" + stringReturn(juchuhyouDataSet.JuchuhyouMain[intRow]["NounyusakiCode"]);
                        dataRow["GyoNo"] = intRowCount.ToString("##0");
                        dataRow["TokuiCode"] = stringReturn(juchuhyouDataSet.JuchuhyouMain[intRow]["TokuiCode"]);
                        dataRow["TokuiName"] = stringReturn(juchuhyouDataSet.JuchuhyouMain[intRow]["TokuisakiName"]);
                        dataRow["NounyubasoCode"] = stringReturn(juchuhyouDataSet.JuchuhyouMain[intRow]["NounyusakiCode"]);

                        dataRow["Juchubi"] = juchuhyouDataSet.JuchuhyouMain[intRow]["Juchubi"];
                        dataRow["JuchuBango"] = stringReturn(juchuhyouDataSet.JuchuhyouMain[intRow]["JuchuBango"]);
                        dataRow["Hinban"] = stringReturn(juchuhyouDataSet.JuchuhyouMain[intRow]["Hinban"]);
                        dataRow["Suryo"] = stringReturn(juchuhyouDataSet.JuchuhyouMain[intRow]["Suryo"]);
                        //dataRow["Nouki"] = juchuhyouDataSet.JuchuhyouMain[intRow]["Juchubi"];
                        dataRow["Nouki"] = juchuhyouDataSet.JuchuhyouMain[intRow]["Juchubi"];
                        dataRow["TokuisakiName"] = juchuhyouDataSet.JuchuhyouMain[intRow]["Tokuisakiname"];

                        JuchuReport2.Rows.Add(dataRow);

                    }
                    //プレビュー
                    /*
                    C1.Win.FlexReport.C1FlexReport frReport = new C1.Win.FlexReport.C1FlexReport();
                    C1.Win.FlexViewer.C1FlexViewerDialog svDialog = new C1.Win.FlexViewer.C1FlexViewerDialog();
                    flexReport.Save("juchuhyouDataSet");
                    frReport.Load("juchuhyouDataSet", "Juchuhyo");
                    frReport.DataSource.Recordset = null;
                    frReport.DataSource.Recordset = juchuhyouDataSet.JuchuhyouMain;
                    svDialog.DocumentSource = frReport;
                    svDialog.Show();
                    */

                    /*
                    C1.Win.FlexReport.C1FlexReport frReport = new C1.Win.FlexReport.C1FlexReport();
                    C1.Win.FlexViewer.C1FlexViewerDialog svDialog = new C1.Win.FlexViewer.C1FlexViewerDialog();
                    flexReport.Save("juchuhyouDataSet");
                    frReport.Load("juchuhyouDataSet", "Juchuhyo");
                    frReport.DataSource.Recordset = null;
                    frReport.DataSource.Recordset = JuchuReport;
                    svDialog.DocumentSource = frReport;
                    svDialog.Show();
                    */

                    C1.Win.FlexReport.C1FlexReport frReport = new C1.Win.FlexReport.C1FlexReport();
                    C1.Win.FlexViewer.C1FlexViewerDialog svDialog = new C1.Win.FlexViewer.C1FlexViewerDialog();
                    flexReport.Save("juchuhyouDataSet");
                    frReport.Load("juchuhyouDataSet", "Juchuhyo");
                    frReport.DataSource.Recordset = null;
                    frReport.DataSource.Recordset = JuchuReport2;
                    svDialog.DocumentSource = frReport;
                    svDialog.Show();



                }
            }
        }
        /// <summary>
        /// データベースに接続
        /// </summary>
        /// <param name="connection"></param>
        /// <returns></returns>
        private Boolean dBConnect(ref SqlConnection connection)
        {
            //データベース接続文字列
            string constr = @"Data Source=GOTO-W10\SQLEXPRESS01;Initial Catalog=Juchuhyou;Integrated Security=True";

            connection = new SqlConnection(constr);

            try
            {
                //データベースに接続
                connection.Open();

            }
            catch (SqlException)
            {
                MessageBox.Show("データベースの接続に失敗しました。", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        /// <summary>
        /// string型に変換
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private string stringReturn(object value)
        {
            string strReturn = "";

            if (value == null)
            {
                strReturn = string.Empty;
            }
            else
            {
                strReturn = value.ToString();
            }

            return strReturn;
        }

        /// <summary>
        /// DateTime型を整形日付のみに変更しstring型で返す
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private string strDate(DateTime value)
        {
            string returnDate = "";

            if (value == null)
            {
                return returnDate;
            }
            else
            {
                returnDate = value.ToString("yyyy/MM/dd");
                return returnDate;
            }

        }
    }
}
