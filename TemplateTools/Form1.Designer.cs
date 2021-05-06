
namespace TemplateTools
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_connection = new System.Windows.Forms.TextBox();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_pwd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_namespace = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_tables = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_selecttables = new System.Windows.Forms.Button();
            this.tb_lib = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(125, 331);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "生成";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "数据库连接";
            // 
            // tb_connection
            // 
            this.tb_connection.Location = new System.Drawing.Point(177, 51);
            this.tb_connection.Name = "tb_connection";
            this.tb_connection.Size = new System.Drawing.Size(240, 23);
            this.tb_connection.TabIndex = 2;
            this.tb_connection.Text = "10.100.4.154";
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(177, 97);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(240, 23);
            this.tb_username.TabIndex = 4;
            this.tb_username.Text = "bpmuser";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "用户名";
            // 
            // tb_pwd
            // 
            this.tb_pwd.Location = new System.Drawing.Point(177, 144);
            this.tb_pwd.Name = "tb_pwd";
            this.tb_pwd.Size = new System.Drawing.Size(240, 23);
            this.tb_pwd.TabIndex = 6;
            this.tb_pwd.Text = "123456";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "密码";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "表";
            // 
            // tb_namespace
            // 
            this.tb_namespace.Location = new System.Drawing.Point(177, 278);
            this.tb_namespace.Name = "tb_namespace";
            this.tb_namespace.Size = new System.Drawing.Size(240, 23);
            this.tb_namespace.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(127, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "空间名";
            // 
            // cmb_tables
            // 
            this.cmb_tables.FormattingEnabled = true;
            this.cmb_tables.Location = new System.Drawing.Point(176, 233);
            this.cmb_tables.Name = "cmb_tables";
            this.cmb_tables.Size = new System.Drawing.Size(240, 25);
            this.cmb_tables.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(125, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "数据库";
            // 
            // btn_selecttables
            // 
            this.btn_selecttables.Location = new System.Drawing.Point(443, 235);
            this.btn_selecttables.Name = "btn_selecttables";
            this.btn_selecttables.Size = new System.Drawing.Size(75, 23);
            this.btn_selecttables.TabIndex = 14;
            this.btn_selecttables.Text = "获取表";
            this.btn_selecttables.UseVisualStyleBackColor = true;
            this.btn_selecttables.Click += new System.EventHandler(this.btn_selecttables_Click);
            // 
            // tb_lib
            // 
            this.tb_lib.Location = new System.Drawing.Point(176, 188);
            this.tb_lib.Name = "tb_lib";
            this.tb_lib.Size = new System.Drawing.Size(241, 23);
            this.tb_lib.TabIndex = 15;
            this.tb_lib.Text = "BPM_LongYa";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_lib);
            this.Controls.Add(this.btn_selecttables);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmb_tables);
            this.Controls.Add(this.tb_namespace);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_pwd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_connection);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_save);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_connection;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_pwd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_namespace;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_tables;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_selecttables;
        private System.Windows.Forms.TextBox tb_lib;
    }
}

