namespace ThaiThanhNhat_buoi1
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
            btngiai = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnxoa = new Button();
            btnthoat = new Button();
            txtkq = new TextBox();
            txta = new TextBox();
            txtb = new TextBox();
            txtc = new TextBox();
            SuspendLayout();
            // 
            // btngiai
            // 
            btngiai.Location = new Point(162, 355);
            btngiai.Name = "btngiai";
            btngiai.Size = new Size(94, 29);
            btngiai.TabIndex = 0;
            btngiai.Text = "Giải";
            btngiai.UseVisualStyleBackColor = true;
            btngiai.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(217, 21);
            label1.Name = "label1";
            label1.Size = new Size(356, 41);
            label1.TabIndex = 1;
            label1.Text = "Giải Phương Trình Bậc 2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(94, 101);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 2;
            label2.Text = "Nhập Số A:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(94, 164);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 3;
            label3.Text = "Nhập Số B:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(94, 223);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 4;
            label4.Text = "Nhập Số C:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ControlLightLight;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(292, 270);
            label5.Name = "label5";
            label5.Size = new Size(74, 23);
            label5.TabIndex = 5;
            label5.Text = "Kết Quả";
            // 
            // btnxoa
            // 
            btnxoa.Location = new Point(282, 355);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(94, 29);
            btnxoa.TabIndex = 6;
            btnxoa.Text = "Xóa Trắng";
            btnxoa.UseVisualStyleBackColor = true;
            btnxoa.Click += btnxoa_Click;
            // 
            // btnthoat
            // 
            btnthoat.Location = new Point(409, 355);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(94, 29);
            btnthoat.TabIndex = 7;
            btnthoat.Text = "Thoát";
            btnthoat.UseVisualStyleBackColor = true;
            btnthoat.Click += btnthoat_Click;
            // 
            // txtkq
            // 
            txtkq.Location = new Point(94, 307);
            txtkq.Name = "txtkq";
            txtkq.Size = new Size(479, 27);
            txtkq.TabIndex = 8;
            // 
            // txta
            // 
            txta.Location = new Point(192, 98);
            txta.Name = "txta";
            txta.Size = new Size(223, 27);
            txta.TabIndex = 9;
            // 
            // txtb
            // 
            txtb.Location = new Point(192, 164);
            txtb.Name = "txtb";
            txtb.Size = new Size(223, 27);
            txtb.TabIndex = 10;
            // 
            // txtc
            // 
            txtc.Location = new Point(192, 220);
            txtc.Name = "txtc";
            txtc.Size = new Size(223, 27);
            txtc.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtc);
            Controls.Add(txtb);
            Controls.Add(txta);
            Controls.Add(txtkq);
            Controls.Add(btnthoat);
            Controls.Add(btnxoa);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btngiai);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btngiai;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnxoa;
        private Button btnthoat;
        private TextBox txtkq;
        private TextBox txta;
        private TextBox txtb;
        private TextBox txtc;
    }
}
