namespace Juchuhyou_study
{
    partial class FormMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.reportDataSet = new System.Data.DataSet();
            this.JuchuReport = new System.Data.DataTable();
            this.JuchuBango = new System.Data.DataColumn();
            this.Juchubi = new System.Data.DataColumn();
            this.Nouki = new System.Data.DataColumn();
            this.Tokuisaki = new System.Data.DataColumn();
            this.Nounyusaki = new System.Data.DataColumn();
            this.Hinban = new System.Data.DataColumn();
            this.Hinmei = new System.Data.DataColumn();
            this.Suryo = new System.Data.DataColumn();
            this.Tanka = new System.Data.DataColumn();
            this.Kingaku = new System.Data.DataColumn();
            this.Syukkabi = new System.Data.DataColumn();
            this.GyoNo = new System.Data.DataColumn();
            this.flexReport = new C1.Win.FlexReport.C1FlexReport();
            this.tokuisakiName = new System.Windows.Forms.TextBox();
            this.juchuhyouTableAdapter = new Juchuhyou_study.JuchuhyouDataSetTableAdapters.JuchuhyouMainTableAdapter();
            this.juchuhyouDataSet = new Juchuhyou_study.JuchuhyouDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JuchuReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.juchuhyouDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Meiryo UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(16, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "得意先名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Meiryo UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(24, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 35);
            this.label4.TabIndex = 3;
            this.label4.Text = "受注表の印刷";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(432, 72);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 32);
            this.button2.TabIndex = 14;
            this.button2.Text = "検索";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // reportDataSet
            // 
            this.reportDataSet.DataSetName = "dataSet";
            this.reportDataSet.Tables.AddRange(new System.Data.DataTable[] {
            this.JuchuReport});
            // 
            // JuchuReport
            // 
            this.JuchuReport.Columns.AddRange(new System.Data.DataColumn[] {
            this.JuchuBango,
            this.Juchubi,
            this.Nouki,
            this.Tokuisaki,
            this.Nounyusaki,
            this.Hinban,
            this.Hinmei,
            this.Suryo,
            this.Tanka,
            this.Kingaku,
            this.Syukkabi,
            this.GyoNo});
            this.JuchuReport.TableName = "JuchuReport";
            // 
            // JuchuBango
            // 
            this.JuchuBango.ColumnName = "JuchuBango";
            // 
            // Juchubi
            // 
            this.Juchubi.ColumnName = "Juchubi";
            // 
            // Nouki
            // 
            this.Nouki.ColumnName = "Nouki";
            // 
            // Tokuisaki
            // 
            this.Tokuisaki.ColumnName = "Tokuisaki";
            // 
            // Nounyusaki
            // 
            this.Nounyusaki.ColumnName = "Nounyusaki";
            // 
            // Hinban
            // 
            this.Hinban.ColumnName = "Hinban";
            // 
            // Hinmei
            // 
            this.Hinmei.ColumnName = "Hinmei";
            // 
            // Suryo
            // 
            this.Suryo.ColumnName = "Suryo";
            // 
            // Tanka
            // 
            this.Tanka.ColumnName = "Tanka";
            // 
            // Kingaku
            // 
            this.Kingaku.ColumnName = "Kingaku";
            // 
            // Syukkabi
            // 
            this.Syukkabi.ColumnName = "Syukkabi";
            // 
            // GyoNo
            // 
            this.GyoNo.ColumnName = "GyoNo";
            // 
            // flexReport
            // 
            this.flexReport.ReportDefinition = resources.GetString("flexReport.ReportDefinition");
            this.flexReport.ReportName = "Juchuhyo";
            // 
            // tokuisakiName
            // 
            this.tokuisakiName.Location = new System.Drawing.Point(120, 80);
            this.tokuisakiName.Name = "tokuisakiName";
            this.tokuisakiName.Size = new System.Drawing.Size(280, 19);
            this.tokuisakiName.TabIndex = 19;
            // 
            // juchuhyouTableAdapter
            // 
            this.juchuhyouTableAdapter.ClearBeforeFill = true;
            // 
            // juchuhyouDataSet
            // 
            this.juchuhyouDataSet.DataSetName = "JuchuhyouDataSet";
            this.juchuhyouDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 143);
            this.Controls.Add(this.tokuisakiName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JuchuReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.juchuhyouDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Data.DataSet reportDataSet;
        private C1.Win.FlexReport.C1FlexReport flexReport;
        private System.Windows.Forms.TextBox tokuisakiName;
        private System.Data.DataTable JuchuReport;
        private System.Data.DataColumn JuchuBango;
        private System.Data.DataColumn Juchubi;
        private System.Data.DataColumn Nouki;
        private System.Data.DataColumn Tokuisaki;
        private System.Data.DataColumn Nounyusaki;
        private System.Data.DataColumn Hinban;
        private System.Data.DataColumn Hinmei;
        private System.Data.DataColumn Suryo;
        private System.Data.DataColumn Tanka;
        private System.Data.DataColumn Kingaku;
        private System.Data.DataColumn Syukkabi;
        private JuchuhyouDataSetTableAdapters.JuchuhyouMainTableAdapter juchuhyouTableAdapter;
        private System.Data.DataColumn GyoNo;
        private JuchuhyouDataSet juchuhyouDataSet;
    }
}

