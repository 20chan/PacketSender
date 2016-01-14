namespace PacketSender
{
    partial class PacketSender
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.CB_Method = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_URL = new System.Windows.Forms.TextBox();
            this.TB_Referer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_UA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_Cookie = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_ContentTYpe = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BTN_SEnd = new System.Windows.Forms.Button();
            this.TB_Result = new System.Windows.Forms.TextBox();
            this.TB_Data = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BTN_Clipboard = new System.Windows.Forms.Button();
            this.BTN_NotePad = new System.Windows.Forms.Button();
            this.BTN_Save = new System.Windows.Forms.Button();
            this.BTN_Load = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CB_Method
            // 
            this.CB_Method.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Method.Font = new System.Drawing.Font("나눔고딕코딩", 9F);
            this.CB_Method.FormattingEnabled = true;
            this.CB_Method.Items.AddRange(new object[] {
            "GET",
            "POST"});
            this.CB_Method.Location = new System.Drawing.Point(126, 10);
            this.CB_Method.Name = "CB_Method";
            this.CB_Method.Size = new System.Drawing.Size(404, 20);
            this.CB_Method.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Request Method : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Url :  ";
            // 
            // TB_URL
            // 
            this.TB_URL.Location = new System.Drawing.Point(126, 36);
            this.TB_URL.Name = "TB_URL";
            this.TB_URL.Size = new System.Drawing.Size(404, 19);
            this.TB_URL.TabIndex = 3;
            // 
            // TB_Referer
            // 
            this.TB_Referer.Location = new System.Drawing.Point(126, 86);
            this.TB_Referer.Name = "TB_Referer";
            this.TB_Referer.Size = new System.Drawing.Size(404, 19);
            this.TB_Referer.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Referer : ";
            // 
            // TB_UA
            // 
            this.TB_UA.Location = new System.Drawing.Point(126, 61);
            this.TB_UA.Name = "TB_UA";
            this.TB_UA.Size = new System.Drawing.Size(404, 19);
            this.TB_UA.TabIndex = 7;
            this.TB_UA.Text = "Mozilla/5.0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "User-Agent : ";
            // 
            // TB_Cookie
            // 
            this.TB_Cookie.Location = new System.Drawing.Point(126, 111);
            this.TB_Cookie.Name = "TB_Cookie";
            this.TB_Cookie.Size = new System.Drawing.Size(404, 19);
            this.TB_Cookie.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cookie : ";
            // 
            // TB_ContentTYpe
            // 
            this.TB_ContentTYpe.Location = new System.Drawing.Point(126, 136);
            this.TB_ContentTYpe.Name = "TB_ContentTYpe";
            this.TB_ContentTYpe.Size = new System.Drawing.Size(404, 19);
            this.TB_ContentTYpe.TabIndex = 11;
            this.TB_ContentTYpe.Text = "application/x-www-form-urlencoded";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "Content-Type : ";
            // 
            // BTN_SEnd
            // 
            this.BTN_SEnd.Location = new System.Drawing.Point(237, 321);
            this.BTN_SEnd.Name = "BTN_SEnd";
            this.BTN_SEnd.Size = new System.Drawing.Size(293, 23);
            this.BTN_SEnd.TabIndex = 12;
            this.BTN_SEnd.Text = "Send";
            this.BTN_SEnd.UseVisualStyleBackColor = true;
            this.BTN_SEnd.Click += new System.EventHandler(this.button1_Click);
            // 
            // TB_Result
            // 
            this.TB_Result.Location = new System.Drawing.Point(536, 10);
            this.TB_Result.Multiline = true;
            this.TB_Result.Name = "TB_Result";
            this.TB_Result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TB_Result.Size = new System.Drawing.Size(501, 305);
            this.TB_Result.TabIndex = 13;
            // 
            // TB_Data
            // 
            this.TB_Data.Location = new System.Drawing.Point(126, 259);
            this.TB_Data.Multiline = true;
            this.TB_Data.Name = "TB_Data";
            this.TB_Data.Size = new System.Drawing.Size(404, 56);
            this.TB_Data.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 12);
            this.label7.TabIndex = 15;
            this.label7.Text = "Data : ";
            // 
            // BTN_Clipboard
            // 
            this.BTN_Clipboard.Location = new System.Drawing.Point(536, 321);
            this.BTN_Clipboard.Name = "BTN_Clipboard";
            this.BTN_Clipboard.Size = new System.Drawing.Size(247, 23);
            this.BTN_Clipboard.TabIndex = 16;
            this.BTN_Clipboard.Text = "Copy to Clipboard";
            this.BTN_Clipboard.UseVisualStyleBackColor = true;
            this.BTN_Clipboard.Click += new System.EventHandler(this.BTN_Clipboard_Click);
            // 
            // BTN_NotePad
            // 
            this.BTN_NotePad.Location = new System.Drawing.Point(789, 321);
            this.BTN_NotePad.Name = "BTN_NotePad";
            this.BTN_NotePad.Size = new System.Drawing.Size(248, 23);
            this.BTN_NotePad.TabIndex = 17;
            this.BTN_NotePad.Text = "Save to File";
            this.BTN_NotePad.UseVisualStyleBackColor = true;
            this.BTN_NotePad.Click += new System.EventHandler(this.BTN_NotePad_Click);
            // 
            // BTN_Save
            // 
            this.BTN_Save.Location = new System.Drawing.Point(15, 321);
            this.BTN_Save.Name = "BTN_Save";
            this.BTN_Save.Size = new System.Drawing.Size(105, 23);
            this.BTN_Save.TabIndex = 18;
            this.BTN_Save.Text = "Save";
            this.BTN_Save.UseVisualStyleBackColor = true;
            this.BTN_Save.Click += new System.EventHandler(this.BTN_Save_Click);
            // 
            // BTN_Load
            // 
            this.BTN_Load.Location = new System.Drawing.Point(126, 321);
            this.BTN_Load.Name = "BTN_Load";
            this.BTN_Load.Size = new System.Drawing.Size(105, 23);
            this.BTN_Load.TabIndex = 19;
            this.BTN_Load.Text = "Load";
            this.BTN_Load.UseVisualStyleBackColor = true;
            this.BTN_Load.Click += new System.EventHandler(this.BTN_Load_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(126, 161);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(404, 19);
            this.textBox1.TabIndex = 21;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 161);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(96, 19);
            this.textBox2.TabIndex = 22;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 186);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(96, 19);
            this.textBox3.TabIndex = 24;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(126, 186);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(404, 19);
            this.textBox4.TabIndex = 23;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(12, 211);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(96, 19);
            this.textBox5.TabIndex = 26;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(126, 211);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(404, 19);
            this.textBox6.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "헤더 추가";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // PacketSender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 354);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BTN_Load);
            this.Controls.Add(this.BTN_Save);
            this.Controls.Add(this.BTN_NotePad);
            this.Controls.Add(this.BTN_Clipboard);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TB_Data);
            this.Controls.Add(this.TB_Result);
            this.Controls.Add(this.BTN_SEnd);
            this.Controls.Add(this.TB_ContentTYpe);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TB_Cookie);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TB_UA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TB_Referer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_URL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CB_Method);
            this.Font = new System.Drawing.Font("나눔고딕코딩", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PacketSender";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_Method;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_URL;
        private System.Windows.Forms.TextBox TB_Referer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_UA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_Cookie;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_ContentTYpe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BTN_SEnd;
        private System.Windows.Forms.TextBox TB_Result;
        private System.Windows.Forms.TextBox TB_Data;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BTN_Clipboard;
        private System.Windows.Forms.Button BTN_NotePad;
        private System.Windows.Forms.Button BTN_Save;
        private System.Windows.Forms.Button BTN_Load;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button1;
    }
}

