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
            this.btKensaku = new System.Windows.Forms.Button();
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
            this.JuchuReport2 = new System.Data.DataTable();
            this.kaiPageGroup = new System.Data.DataColumn();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.dataColumn7 = new System.Data.DataColumn();
            this.dataColumn8 = new System.Data.DataColumn();
            this.dataColumn9 = new System.Data.DataColumn();
            this.dataColumn10 = new System.Data.DataColumn();
            this.dataColumn11 = new System.Data.DataColumn();
            this.dataColumn12 = new System.Data.DataColumn();
            this.dataColumn13 = new System.Data.DataColumn();
            this.flexReport = new C1.Win.FlexReport.C1FlexReport();
            this.tokuisakiName = new System.Windows.Forms.TextBox();
            this.juchuhyouTableAdapter = new Juchuhyou_study.JuchuhyouDataSetTableAdapters.JuchuhyouMainTableAdapter();
            this.juchuhyouDataSet = new Juchuhyou_study.JuchuhyouDataSet();
            this.tbBegin = new System.Windows.Forms.TextBox();
            this.tbFin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JuchuReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JuchuReport2)).BeginInit();
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
            // btKensaku
            // 
            this.btKensaku.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btKensaku.Location = new System.Drawing.Point(440, 128);
            this.btKensaku.Name = "btKensaku";
            this.btKensaku.Size = new System.Drawing.Size(75, 32);
            this.btKensaku.TabIndex = 14;
            this.btKensaku.Text = "検索";
            this.btKensaku.UseVisualStyleBackColor = true;
            this.btKensaku.Click += new System.EventHandler(this.btKensaku_Click);
            // 
            // reportDataSet
            // 
            this.reportDataSet.DataSetName = "dataSet";
            this.reportDataSet.Tables.AddRange(new System.Data.DataTable[] {
            this.JuchuReport,
            this.JuchuReport2});
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
            // JuchuReport2
            // 
            this.JuchuReport2.Columns.AddRange(new System.Data.DataColumn[] {
            this.kaiPageGroup,
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn5,
            this.dataColumn6,
            this.dataColumn7,
            this.dataColumn8,
            this.dataColumn9,
            this.dataColumn10,
            this.dataColumn11,
            this.dataColumn12,
            this.dataColumn13});
            this.JuchuReport2.TableName = "JuchuReport2";
            // 
            // kaiPageGroup
            // 
            this.kaiPageGroup.ColumnName = "kaiPageGroup";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "GyoNo";
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "TokuiCode";
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "TokuiName";
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "NounyubasoCode";
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "Juchubi";
            // 
            // dataColumn6
            // 
            this.dataColumn6.ColumnName = "JuchuBango";
            // 
            // dataColumn7
            // 
            this.dataColumn7.ColumnName = "Hinban";
            // 
            // dataColumn8
            // 
            this.dataColumn8.ColumnName = "Suryo";
            // 
            // dataColumn9
            // 
            this.dataColumn9.ColumnName = "Nouki";
            // 
            // dataColumn10
            // 
            this.dataColumn10.ColumnName = "TokuisakiName";
            // 
            // dataColumn11
            // 
            this.dataColumn11.ColumnName = "Hinmei";
            // 
            // dataColumn12
            // 
            this.dataColumn12.ColumnName = "Tanka";
            // 
            // dataColumn13
            // 
            this.dataColumn13.ColumnName = "Kingaku";
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
            // tbBegin
            // 
            this.tbBegin.Location = new System.Drawing.Point(120, 120);
            this.tbBegin.Name = "tbBegin";
            this.tbBegin.Size = new System.Drawing.Size(100, 19);
            this.tbBegin.TabIndex = 20;
            // 
            // tbFin
            // 
            this.tbFin.Location = new System.Drawing.Point(304, 120);
            this.tbFin.Name = "tbFin";
            this.tbFin.Size = new System.Drawing.Size(100, 19);
            this.tbFin.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Meiryo UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(16, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 24);
            this.label1.TabIndex = 22;
            this.label1.Text = "納期";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Meiryo UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(248, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 24);
            this.label2.TabIndex = 23;
            this.label2.Text = "～";
            // 
            // btReset
            // 
            this.btReset.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btReset.Location = new System.Drawing.Point(440, 88);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(75, 32);
            this.btReset.TabIndex = 24;
            this.btReset.Text = "リセット";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 166);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbFin);
            this.Controls.Add(this.tbBegin);
            this.Controls.Add(this.tokuisakiName);
            this.Controls.Add(this.btKensaku);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JuchuReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JuchuReport2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.juchuhyouDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btKensaku;
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
        private System.Data.DataTable JuchuReport2;
        private System.Data.DataColumn kaiPageGroup;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn5;
        private System.Data.DataColumn dataColumn6;
        private System.Data.DataColumn dataColumn7;
        private System.Data.DataColumn dataColumn8;
        private System.Data.DataColumn dataColumn9;
        private System.Data.DataColumn dataColumn10;
        private System.Data.DataColumn dataColumn11;
        private System.Data.DataColumn dataColumn12;
        private System.Data.DataColumn dataColumn13;
        private System.Windows.Forms.TextBox tbBegin;
        private System.Windows.Forms.TextBox tbFin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btReset;
    }
}

