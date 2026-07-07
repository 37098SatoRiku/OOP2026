namespace Section01 {
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
            dtpDate = new DateTimePicker();
            btGet = new Button();
            nmudDay = new NumericUpDown();
            label1 = new Label();
            tbOut = new TextBox();
            dtpBirth = new DateTimePicker();
            btBirthCulc = new Button();
            label2 = new Label();
            tbOut2 = new TextBox();
            tbOut3 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)nmudDay).BeginInit();
            SuspendLayout();
            // 
            // dtpDate
            // 
            dtpDate.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            dtpDate.Location = new Point(55, 88);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(200, 39);
            dtpDate.TabIndex = 0;
            // 
            // btGet
            // 
            btGet.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btGet.Location = new Point(302, 88);
            btGet.Name = "btGet";
            btGet.Size = new Size(82, 39);
            btGet.TabIndex = 1;
            btGet.Text = "計算";
            btGet.UseVisualStyleBackColor = true;
            btGet.Click += btGet_Click;
            // 
            // nmudDay
            // 
            nmudDay.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            nmudDay.Location = new Point(119, 157);
            nmudDay.Name = "nmudDay";
            nmudDay.Size = new Size(136, 33);
            nmudDay.TabIndex = 3;
            nmudDay.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label1.Location = new Point(261, 159);
            label1.Name = "label1";
            label1.Size = new Size(50, 25);
            label1.TabIndex = 4;
            label1.Text = "日後";
            // 
            // tbOut
            // 
            tbOut.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            tbOut.Location = new Point(103, 295);
            tbOut.Name = "tbOut";
            tbOut.Size = new Size(304, 33);
            tbOut.TabIndex = 5;
            // 
            // dtpBirth
            // 
            dtpBirth.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            dtpBirth.Location = new Point(55, 245);
            dtpBirth.Name = "dtpBirth";
            dtpBirth.Size = new Size(200, 33);
            dtpBirth.TabIndex = 6;
            // 
            // btBirthCulc
            // 
            btBirthCulc.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btBirthCulc.Location = new Point(301, 245);
            btBirthCulc.Name = "btBirthCulc";
            btBirthCulc.Size = new Size(83, 33);
            btBirthCulc.TabIndex = 7;
            btBirthCulc.Text = "計算";
            btBirthCulc.UseVisualStyleBackColor = true;
            btBirthCulc.Click += btBirthCulc_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 227);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 8;
            label2.Text = "生年月日";
            // 
            // tbOut2
            // 
            tbOut2.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            tbOut2.Location = new Point(103, 348);
            tbOut2.Name = "tbOut2";
            tbOut2.Size = new Size(304, 33);
            tbOut2.TabIndex = 5;
            // 
            // tbOut3
            // 
            tbOut3.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            tbOut3.Location = new Point(103, 405);
            tbOut3.Multiline = true;
            tbOut3.Name = "tbOut3";
            tbOut3.Size = new Size(304, 71);
            tbOut3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(73, 416);
            label3.Name = "label3";
            label3.Size = new Size(24, 15);
            label3.TabIndex = 10;
            label3.Text = "メモ";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 359);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 10;
            label4.Text = "経過日数";
            label4.Click += label3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(70, 306);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 10;
            label5.Text = "年齢";
            label5.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 508);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btBirthCulc);
            Controls.Add(dtpBirth);
            Controls.Add(tbOut3);
            Controls.Add(tbOut2);
            Controls.Add(tbOut);
            Controls.Add(label1);
            Controls.Add(nmudDay);
            Controls.Add(btGet);
            Controls.Add(dtpDate);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nmudDay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private OpenFileDialog ofdOpen;
        private DateTimePicker dtpDate;
        private Button btGet;
        private NumericUpDown nmudDay;
        private Label label1;
        private TextBox tbOut;
        private DateTimePicker dtpBirth;
        private Button btBirthCulc;
        private Label label2;
        private TextBox tbOut2;
        private TextBox tbOut3;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
