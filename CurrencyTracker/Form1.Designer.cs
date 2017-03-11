namespace CurrencyTracker
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_top = new System.Windows.Forms.Panel();
            this.label_app_title = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.currency = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_fetch_rupee_value = new System.Windows.Forms.Button();
            this.btn_list_values = new System.Windows.Forms.Button();
            this.btn_write_to_file = new System.Windows.Forms.Button();
            this.label_status = new System.Windows.Forms.Label();
            this.label_average = new System.Windows.Forms.Label();
            this.btn_one_day_avg = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::CurrencyTracker.Properties.Resources.IndianRupee;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel_top.Controls.Add(this.label_app_title);
            this.panel_top.Controls.Add(this.pictureBox1);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(496, 33);
            this.panel_top.TabIndex = 1;
            // 
            // label_app_title
            // 
            this.label_app_title.AutoSize = true;
            this.label_app_title.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_app_title.Font = new System.Drawing.Font("BankGothic", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_app_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(144)))), ((int)(((byte)(144)))));
            this.label_app_title.Location = new System.Drawing.Point(36, 0);
            this.label_app_title.Margin = new System.Windows.Forms.Padding(50, 0, 10, 0);
            this.label_app_title.Name = "label_app_title";
            this.label_app_title.Size = new System.Drawing.Size(332, 23);
            this.label_app_title.TabIndex = 1;
            this.label_app_title.Text = "Indian Currency Tracker";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.currency,
            this.date});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listView1.Location = new System.Drawing.Point(0, 130);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(496, 238);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.Width = 50;
            // 
            // currency
            // 
            this.currency.Text = "1$ into Rupee";
            this.currency.Width = 80;
            // 
            // date
            // 
            this.date.Text = "Date-Time";
            this.date.Width = 145;
            // 
            // btn_fetch_rupee_value
            // 
            this.btn_fetch_rupee_value.Location = new System.Drawing.Point(0, 101);
            this.btn_fetch_rupee_value.Name = "btn_fetch_rupee_value";
            this.btn_fetch_rupee_value.Size = new System.Drawing.Size(132, 23);
            this.btn_fetch_rupee_value.TabIndex = 4;
            this.btn_fetch_rupee_value.Text = "Fetch Rupee Value";
            this.btn_fetch_rupee_value.UseVisualStyleBackColor = true;
            this.btn_fetch_rupee_value.Click += new System.EventHandler(this.btn_fetch_rupee_value_Click);
            // 
            // btn_list_values
            // 
            this.btn_list_values.Location = new System.Drawing.Point(138, 101);
            this.btn_list_values.Name = "btn_list_values";
            this.btn_list_values.Size = new System.Drawing.Size(132, 23);
            this.btn_list_values.TabIndex = 5;
            this.btn_list_values.Text = "List Values";
            this.btn_list_values.UseVisualStyleBackColor = true;
            this.btn_list_values.Click += new System.EventHandler(this.btn_list_values_Click);
            // 
            // btn_write_to_file
            // 
            this.btn_write_to_file.Location = new System.Drawing.Point(276, 101);
            this.btn_write_to_file.Name = "btn_write_to_file";
            this.btn_write_to_file.Size = new System.Drawing.Size(97, 23);
            this.btn_write_to_file.TabIndex = 6;
            this.btn_write_to_file.Text = "Write to file";
            this.btn_write_to_file.UseVisualStyleBackColor = true;
            this.btn_write_to_file.Click += new System.EventHandler(this.btn_write_to_file_Click);
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Font = new System.Drawing.Font("Khmer UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_status.ForeColor = System.Drawing.Color.Gray;
            this.label_status.Location = new System.Drawing.Point(12, 36);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(83, 19);
            this.label_status.TabIndex = 7;
            this.label_status.Text = "Label Status";
            // 
            // label_average
            // 
            this.label_average.AutoSize = true;
            this.label_average.Font = new System.Drawing.Font("Khmer UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_average.ForeColor = System.Drawing.Color.Gray;
            this.label_average.Location = new System.Drawing.Point(12, 67);
            this.label_average.Name = "label_average";
            this.label_average.Size = new System.Drawing.Size(95, 19);
            this.label_average.TabIndex = 8;
            this.label_average.Text = "Label Average";
            // 
            // btn_one_day_avg
            // 
            this.btn_one_day_avg.Location = new System.Drawing.Point(379, 101);
            this.btn_one_day_avg.Name = "btn_one_day_avg";
            this.btn_one_day_avg.Size = new System.Drawing.Size(105, 23);
            this.btn_one_day_avg.TabIndex = 9;
            this.btn_one_day_avg.Text = "One Day Avg";
            this.btn_one_day_avg.UseVisualStyleBackColor = true;
            this.btn_one_day_avg.Click += new System.EventHandler(this.btn_one_day_avg_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(496, 368);
            this.Controls.Add(this.btn_one_day_avg);
            this.Controls.Add(this.label_average);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.btn_write_to_file);
            this.Controls.Add(this.btn_list_values);
            this.Controls.Add(this.btn_fetch_rupee_value);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Currency Tracker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Label label_app_title;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.Button btn_fetch_rupee_value;
        private System.Windows.Forms.Button btn_list_values;
        private System.Windows.Forms.ColumnHeader currency;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.Button btn_write_to_file;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.Label label_average;
        private System.Windows.Forms.Button btn_one_day_avg;
    }
}

