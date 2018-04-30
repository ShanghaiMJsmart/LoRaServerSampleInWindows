namespace LoRaServerSampleInWindows
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBoxport = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxmacaddr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxusername = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DevEUI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppEUI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DevAddr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rssi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Snr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConfirmRequest = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Confirm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LED = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(576, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(403, 322);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // textBoxport
            // 
            this.textBoxport.Location = new System.Drawing.Point(248, 12);
            this.textBoxport.Name = "textBoxport";
            this.textBoxport.Size = new System.Drawing.Size(44, 21);
            this.textBoxport.TabIndex = 2;
            this.textBoxport.Text = "1883";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(463, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "连接服务器";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxip
            // 
            this.textBoxip.Location = new System.Drawing.Point(71, 12);
            this.textBoxip.Name = "textBoxip";
            this.textBoxip.Size = new System.Drawing.Size(100, 21);
            this.textBoxip.TabIndex = 4;
            this.textBoxip.Text = "101.132.97.241";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "服务器IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "服务器端口";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DevEUI,
            this.AppEUI,
            this.DevAddr,
            this.Rssi,
            this.Snr,
            this.ConfirmRequest,
            this.Confirm,
            this.LED});
            this.dataGridView1.Location = new System.Drawing.Point(12, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(558, 259);
            this.dataGridView1.TabIndex = 7;
            // 
            // textBoxmacaddr
            // 
            this.textBoxmacaddr.Location = new System.Drawing.Point(357, 12);
            this.textBoxmacaddr.Name = "textBoxmacaddr";
            this.textBoxmacaddr.Size = new System.Drawing.Size(100, 21);
            this.textBoxmacaddr.TabIndex = 8;
            this.textBoxmacaddr.Text = "0CEFAFD18B08";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(298, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "网关地址";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "用户名";
            // 
            // textBoxusername
            // 
            this.textBoxusername.Location = new System.Drawing.Point(71, 38);
            this.textBoxusername.Name = "textBoxusername";
            this.textBoxusername.Size = new System.Drawing.Size(100, 21);
            this.textBoxusername.TabIndex = 11;
            this.textBoxusername.Text = "MJ-Modem";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(177, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "密码";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(212, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = "www.colt.xin";
            // 
            // DevEUI
            // 
            this.DevEUI.HeaderText = "DevEUI";
            this.DevEUI.Name = "DevEUI";
            this.DevEUI.Width = 66;
            // 
            // AppEUI
            // 
            this.AppEUI.HeaderText = "AppEUI";
            this.AppEUI.Name = "AppEUI";
            this.AppEUI.Width = 66;
            // 
            // DevAddr
            // 
            this.DevAddr.HeaderText = "DevAddr";
            this.DevAddr.Name = "DevAddr";
            this.DevAddr.Width = 72;
            // 
            // Rssi
            // 
            this.Rssi.HeaderText = "Rssi";
            this.Rssi.Name = "Rssi";
            this.Rssi.Width = 54;
            // 
            // Snr
            // 
            this.Snr.HeaderText = "Snr";
            this.Snr.Name = "Snr";
            this.Snr.Width = 48;
            // 
            // ConfirmRequest
            // 
            this.ConfirmRequest.HeaderText = "ConfirmRequest";
            this.ConfirmRequest.Name = "ConfirmRequest";
            this.ConfirmRequest.Width = 95;
            // 
            // Confirm
            // 
            this.Confirm.HeaderText = "Confirm";
            this.Confirm.Name = "Confirm";
            this.Confirm.Width = 72;
            // 
            // LED
            // 
            this.LED.HeaderText = "LED";
            this.LED.Name = "LED";
            this.LED.Width = 39;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 346);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxusername);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxmacaddr);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxip);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxport);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBoxport;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxmacaddr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxusername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DevEUI;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppEUI;
        private System.Windows.Forms.DataGridViewTextBoxColumn DevAddr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rssi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Snr;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ConfirmRequest;
        private System.Windows.Forms.DataGridViewTextBoxColumn Confirm;
        private System.Windows.Forms.DataGridViewComboBoxColumn LED;
    }
}

