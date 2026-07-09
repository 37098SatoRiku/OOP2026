namespace Exercise01 {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            btButton1 = new Button();
            btButton2 = new Button();
            btButton3 = new Button();
            tbOut1 = new TextBox();
            tbOut2 = new TextBox();
            tbOut3 = new TextBox();
            tbOut4 = new TextBox();
            btStart = new Button();
            btStop = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            btReset = new Button();
            button1 = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // btButton1
            // 
            btButton1.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btButton1.Location = new Point(31, 44);
            btButton1.Name = "btButton1";
            btButton1.Size = new Size(128, 60);
            btButton1.TabIndex = 0;
            btButton1.Text = "①";
            btButton1.UseVisualStyleBackColor = true;
            btButton1.Click += btButton1_Click;
            // 
            // btButton2
            // 
            btButton2.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btButton2.Location = new Point(31, 139);
            btButton2.Name = "btButton2";
            btButton2.Size = new Size(128, 60);
            btButton2.TabIndex = 0;
            btButton2.Text = "②";
            btButton2.UseVisualStyleBackColor = true;
            btButton2.Click += btButton2_Click;
            // 
            // btButton3
            // 
            btButton3.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btButton3.Location = new Point(31, 234);
            btButton3.Name = "btButton3";
            btButton3.Size = new Size(128, 60);
            btButton3.TabIndex = 0;
            btButton3.Text = "③";
            btButton3.UseVisualStyleBackColor = true;
            btButton3.Click += btButton3_Click;
            // 
            // tbOut1
            // 
            tbOut1.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            tbOut1.Location = new Point(199, 59);
            tbOut1.Name = "tbOut1";
            tbOut1.Size = new Size(308, 33);
            tbOut1.TabIndex = 1;
            // 
            // tbOut2
            // 
            tbOut2.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            tbOut2.Location = new Point(199, 151);
            tbOut2.Name = "tbOut2";
            tbOut2.Size = new Size(308, 33);
            tbOut2.TabIndex = 1;
            // 
            // tbOut3
            // 
            tbOut3.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            tbOut3.Location = new Point(199, 246);
            tbOut3.Name = "tbOut3";
            tbOut3.Size = new Size(308, 33);
            tbOut3.TabIndex = 1;
            // 
            // tbOut4
            // 
            tbOut4.Font = new Font("Yu Gothic UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 128);
            tbOut4.Location = new Point(12, 370);
            tbOut4.Name = "tbOut4";
            tbOut4.Size = new Size(425, 71);
            tbOut4.TabIndex = 1;
            // 
            // btStart
            // 
            btStart.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btStart.Location = new Point(12, 478);
            btStart.Name = "btStart";
            btStart.Size = new Size(128, 60);
            btStart.TabIndex = 0;
            btStart.Text = "スタート";
            btStart.UseVisualStyleBackColor = true;
            btStart.Click += btStart_Click;
            // 
            // btStop
            // 
            btStop.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btStop.Location = new Point(146, 478);
            btStop.Name = "btStop";
            btStop.Size = new Size(128, 60);
            btStop.TabIndex = 0;
            btStop.Text = "ストップ";
            btStop.UseVisualStyleBackColor = true;
            btStop.Click += btStop_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1;
            timer1.Tick += timer1_Tick;
            // 
            // btReset
            // 
            btReset.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btReset.Location = new Point(280, 479);
            btReset.Name = "btReset";
            btReset.Size = new Size(132, 59);
            btReset.TabIndex = 2;
            btReset.Text = "リセット";
            btReset.UseVisualStyleBackColor = true;
            btReset.Click += btReset_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            button1.Location = new Point(418, 478);
            button1.Name = "button1";
            button1.Size = new Size(127, 59);
            button1.TabIndex = 3;
            button1.Text = "ラップタイム";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Yu Gothic UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 128);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 65;
            listBox1.Location = new Point(443, 370);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(473, 69);
            listBox1.TabIndex = 4;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1611, 1044);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(btReset);
            Controls.Add(tbOut4);
            Controls.Add(tbOut3);
            Controls.Add(tbOut2);
            Controls.Add(tbOut1);
            Controls.Add(btStart);
            Controls.Add(btStop);
            Controls.Add(btButton3);
            Controls.Add(btButton2);
            Controls.Add(btButton1);
            Name = "Form1";
            Text = "問題9-1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btButton1;
        private Button btButton2;
        private Button btButton3;
        private TextBox tbOut1;
        private TextBox tbOut2;
        private TextBox tbOut3;
        private TextBox tbOut4;
        private Button btStart;
        private Button btStop;
        private System.Windows.Forms.Timer timer1;
        private Button btReset;
        private Button button1;
        private ListBox listBox1;
    }
}
