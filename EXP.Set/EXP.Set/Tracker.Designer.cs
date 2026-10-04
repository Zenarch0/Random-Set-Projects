namespace EXP.Set
{
    partial class Tracker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.exp_lbl = new System.Windows.Forms.Label();
            this.xp_box = new System.Windows.Forms.GroupBox();
            this.N_C = new System.Windows.Forms.RadioButton();
            this.xp_50 = new System.Windows.Forms.RadioButton();
            this.TS = new System.Windows.Forms.RadioButton();
            this.xp_10 = new System.Windows.Forms.RadioButton();
            this.xp_5 = new System.Windows.Forms.RadioButton();
            this.xp_1_1 = new System.Windows.Forms.RadioButton();
            this.xp_1 = new System.Windows.Forms.RadioButton();
            this.conf = new System.Windows.Forms.Button();
            this.show_lvl = new System.Windows.Forms.Label();
            this.levelDeetsDataSet = new EXP.Set.LevelDeetsDataSet();
            this.req_ExpBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.req_ExpTableAdapter = new EXP.Set.LevelDeetsDataSetTableAdapters.Req_ExpTableAdapter();
            this.tableAdapterManager = new EXP.Set.LevelDeetsDataSetTableAdapters.TableAdapterManager();
            this.leveled_UpTableAdapter = new EXP.Set.LevelDeetsDataSetTableAdapters.Leveled_UpTableAdapter();
            this.req_ExpDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leveled_UpBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.leveled_UpDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.total_lbl = new System.Windows.Forms.Label();
            this.xp_box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.levelDeetsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.req_ExpBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.req_ExpDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leveled_UpBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leveled_UpDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // exp_lbl
            // 
            this.exp_lbl.BackColor = System.Drawing.Color.Transparent;
            this.exp_lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.exp_lbl.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exp_lbl.Location = new System.Drawing.Point(95, 163);
            this.exp_lbl.Name = "exp_lbl";
            this.exp_lbl.Size = new System.Drawing.Size(122, 32);
            this.exp_lbl.TabIndex = 0;
            this.exp_lbl.Text = "0/0";
            this.exp_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // xp_box
            // 
            this.xp_box.Controls.Add(this.N_C);
            this.xp_box.Controls.Add(this.xp_50);
            this.xp_box.Controls.Add(this.TS);
            this.xp_box.Controls.Add(this.xp_10);
            this.xp_box.Controls.Add(this.xp_5);
            this.xp_box.Controls.Add(this.xp_1_1);
            this.xp_box.Controls.Add(this.xp_1);
            this.xp_box.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xp_box.Location = new System.Drawing.Point(36, 212);
            this.xp_box.Name = "xp_box";
            this.xp_box.Size = new System.Drawing.Size(190, 93);
            this.xp_box.TabIndex = 1;
            this.xp_box.TabStop = false;
            this.xp_box.Text = "Set";
            // 
            // N_C
            // 
            this.N_C.AutoSize = true;
            this.N_C.Checked = true;
            this.N_C.Location = new System.Drawing.Point(181, 45);
            this.N_C.Name = "N_C";
            this.N_C.Size = new System.Drawing.Size(14, 13);
            this.N_C.TabIndex = 5;
            this.N_C.TabStop = true;
            this.N_C.UseVisualStyleBackColor = true;
            this.N_C.Visible = false;
            // 
            // xp_50
            // 
            this.xp_50.AutoSize = true;
            this.xp_50.ForeColor = System.Drawing.Color.MidnightBlue;
            this.xp_50.Location = new System.Drawing.Point(67, 55);
            this.xp_50.Name = "xp_50";
            this.xp_50.Size = new System.Drawing.Size(43, 23);
            this.xp_50.TabIndex = 3;
            this.xp_50.Text = "50";
            this.xp_50.UseVisualStyleBackColor = true;
            // 
            // TS
            // 
            this.TS.AutoSize = true;
            this.TS.ForeColor = System.Drawing.Color.MidnightBlue;
            this.TS.Location = new System.Drawing.Point(117, 55);
            this.TS.Name = "TS";
            this.TS.Size = new System.Drawing.Size(43, 23);
            this.TS.TabIndex = 4;
            this.TS.Text = "TS";
            this.TS.UseVisualStyleBackColor = true;
            // 
            // xp_10
            // 
            this.xp_10.AutoSize = true;
            this.xp_10.ForeColor = System.Drawing.Color.MidnightBlue;
            this.xp_10.Location = new System.Drawing.Point(17, 55);
            this.xp_10.Name = "xp_10";
            this.xp_10.Size = new System.Drawing.Size(43, 23);
            this.xp_10.TabIndex = 3;
            this.xp_10.Text = "10";
            this.xp_10.UseVisualStyleBackColor = true;
            // 
            // xp_5
            // 
            this.xp_5.AutoSize = true;
            this.xp_5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.xp_5.Location = new System.Drawing.Point(67, 26);
            this.xp_5.Name = "xp_5";
            this.xp_5.Size = new System.Drawing.Size(35, 23);
            this.xp_5.TabIndex = 2;
            this.xp_5.Text = "5";
            this.xp_5.UseVisualStyleBackColor = true;
            // 
            // xp_1_1
            // 
            this.xp_1_1.AutoSize = true;
            this.xp_1_1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.xp_1_1.Location = new System.Drawing.Point(117, 26);
            this.xp_1_1.Name = "xp_1_1";
            this.xp_1_1.Size = new System.Drawing.Size(53, 23);
            this.xp_1_1.TabIndex = 1;
            this.xp_1_1.Text = "1+1";
            this.xp_1_1.UseVisualStyleBackColor = true;
            // 
            // xp_1
            // 
            this.xp_1.AutoSize = true;
            this.xp_1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.xp_1.Location = new System.Drawing.Point(17, 26);
            this.xp_1.Name = "xp_1";
            this.xp_1.Size = new System.Drawing.Size(35, 23);
            this.xp_1.TabIndex = 0;
            this.xp_1.Text = "1";
            this.xp_1.UseVisualStyleBackColor = true;
            // 
            // conf
            // 
            this.conf.BackColor = System.Drawing.Color.Transparent;
            this.conf.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conf.Location = new System.Drawing.Point(61, 311);
            this.conf.Name = "conf";
            this.conf.Size = new System.Drawing.Size(134, 42);
            this.conf.TabIndex = 2;
            this.conf.Text = "Confirm";
            this.conf.UseVisualStyleBackColor = false;
            this.conf.Click += new System.EventHandler(this.Conf_Click);
            // 
            // show_lvl
            // 
            this.show_lvl.BackColor = System.Drawing.Color.Transparent;
            this.show_lvl.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_lvl.ForeColor = System.Drawing.Color.MidnightBlue;
            this.show_lvl.Location = new System.Drawing.Point(12, 9);
            this.show_lvl.Name = "show_lvl";
            this.show_lvl.Size = new System.Drawing.Size(123, 26);
            this.show_lvl.TabIndex = 4;
            this.show_lvl.Text = "Level";
            this.show_lvl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // levelDeetsDataSet
            // 
            this.levelDeetsDataSet.DataSetName = "LevelDeetsDataSet";
            this.levelDeetsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // req_ExpBindingSource
            // 
            this.req_ExpBindingSource.DataMember = "Req_Exp";
            this.req_ExpBindingSource.DataSource = this.levelDeetsDataSet;
            // 
            // req_ExpTableAdapter
            // 
            this.req_ExpTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Leveled_UpTableAdapter = this.leveled_UpTableAdapter;
            this.tableAdapterManager.Req_ExpTableAdapter = this.req_ExpTableAdapter;
            this.tableAdapterManager.UpdateOrder = EXP.Set.LevelDeetsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // leveled_UpTableAdapter
            // 
            this.leveled_UpTableAdapter.ClearBeforeFill = true;
            // 
            // req_ExpDataGridView
            // 
            this.req_ExpDataGridView.AllowUserToAddRows = false;
            this.req_ExpDataGridView.AllowUserToDeleteRows = false;
            this.req_ExpDataGridView.AutoGenerateColumns = false;
            this.req_ExpDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.req_ExpDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.req_ExpDataGridView.DataSource = this.req_ExpBindingSource;
            this.req_ExpDataGridView.Location = new System.Drawing.Point(288, 6);
            this.req_ExpDataGridView.Name = "req_ExpDataGridView";
            this.req_ExpDataGridView.Size = new System.Drawing.Size(247, 182);
            this.req_ExpDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn5.HeaderText = "Id";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Experience";
            this.dataGridViewTextBoxColumn6.HeaderText = "Experience";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // leveled_UpBindingSource
            // 
            this.leveled_UpBindingSource.DataMember = "Leveled_Up";
            this.leveled_UpBindingSource.DataSource = this.levelDeetsDataSet;
            // 
            // leveled_UpDataGridView
            // 
            this.leveled_UpDataGridView.AllowUserToAddRows = false;
            this.leveled_UpDataGridView.AllowUserToDeleteRows = false;
            this.leveled_UpDataGridView.AutoGenerateColumns = false;
            this.leveled_UpDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.leveled_UpDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.leveled_UpDataGridView.DataSource = this.leveled_UpBindingSource;
            this.leveled_UpDataGridView.Location = new System.Drawing.Point(288, 194);
            this.leveled_UpDataGridView.Name = "leveled_UpDataGridView";
            this.leveled_UpDataGridView.Size = new System.Drawing.Size(247, 182);
            this.leveled_UpDataGridView.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn7.HeaderText = "Id";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn8.HeaderText = "Date";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(34, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "exp>>";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EXP.Set.Properties.Resources._250px_XCXDE_Miran_Archives_entry_strm_glossary_055_01;
            this.pictureBox1.Location = new System.Drawing.Point(9, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // total_lbl
            // 
            this.total_lbl.BackColor = System.Drawing.Color.Transparent;
            this.total_lbl.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_lbl.ForeColor = System.Drawing.Color.MidnightBlue;
            this.total_lbl.Location = new System.Drawing.Point(141, 9);
            this.total_lbl.Name = "total_lbl";
            this.total_lbl.Size = new System.Drawing.Size(123, 26);
            this.total_lbl.TabIndex = 9;
            this.total_lbl.Text = "Total:";
            this.total_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Tracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 378);
            this.Controls.Add(this.total_lbl);
            this.Controls.Add(this.exp_lbl);
            this.Controls.Add(this.show_lvl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.leveled_UpDataGridView);
            this.Controls.Add(this.req_ExpDataGridView);
            this.Controls.Add(this.conf);
            this.Controls.Add(this.xp_box);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Tracker";
            this.Text = "Tracker";
            this.Load += new System.EventHandler(this.Tracker_Load);
            this.xp_box.ResumeLayout(false);
            this.xp_box.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.levelDeetsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.req_ExpBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.req_ExpDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leveled_UpBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leveled_UpDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label exp_lbl;
        private System.Windows.Forms.GroupBox xp_box;
        private System.Windows.Forms.RadioButton xp_1_1;
        private System.Windows.Forms.RadioButton xp_1;
        private System.Windows.Forms.RadioButton xp_5;
        private System.Windows.Forms.RadioButton xp_10;
        private System.Windows.Forms.RadioButton TS;
        private System.Windows.Forms.Button conf;
        private System.Windows.Forms.RadioButton xp_50;
        private System.Windows.Forms.Label show_lvl;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private LevelDeetsDataSet levelDeetsDataSet;
        private System.Windows.Forms.BindingSource req_ExpBindingSource;
        private LevelDeetsDataSetTableAdapters.Req_ExpTableAdapter req_ExpTableAdapter;
        private LevelDeetsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView req_ExpDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private LevelDeetsDataSetTableAdapters.Leveled_UpTableAdapter leveled_UpTableAdapter;
        private System.Windows.Forms.BindingSource leveled_UpBindingSource;
        private System.Windows.Forms.DataGridView leveled_UpDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton N_C;
        private System.Windows.Forms.Label total_lbl;
    }
}

