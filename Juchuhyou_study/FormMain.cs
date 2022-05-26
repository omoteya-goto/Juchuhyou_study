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
                //SqlDataAdapter sDAdapter = new SqlDataAdapter();

                //SQL文
                string strSql = "SELECT * FROM JuchuhyouMain where TokuisakiName = @tokuisakiName";

                try
                {

                    SqlCommand command = connection.CreateCommand();
                    command.CommandText = @strSql;
                    command.Parameters.Add(new SqlParameter("@tokuisakiName", strTokuisakiName));
                    //juchuhyouTableAdapter.Fill(juchuhyouDataSet.JuchuhyouMain);
                    var adapter = new SqlDataAdapter(command);
                    adapter.Fill(juchuhyouDataSet.JuchuhyouMain);
                }
                catch
                {
                    MessageBox.Show("データの取得に失敗しました。");
                }
                if (juchuhyouDataSet.JuchuhyouMain.Rows.Count == 0)
                {
                    MessageBox.Show("印刷する情報がありません", "情報", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
                else if (juchuhyouDataSet.JuchuhyouMain.Rows.Count >= 1)
                {
                    //プレビュー
                    C1.Win.FlexReport.C1FlexReport frReport = new C1.Win.FlexReport.C1FlexReport();
                    C1.Win.FlexViewer.C1FlexViewerDialog svDialog = new C1.Win.FlexViewer.C1FlexViewerDialog();
                    flexReport.Save("juchuhyouDataSet");
                    frReport.Load("juchuhyouDataSet", "Juchuhyo");
                    frReport.DataSource.Recordset = null;
                    frReport.DataSource.Recordset = juchuhyouDataSet.JuchuhyouMain;
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
    }
}
