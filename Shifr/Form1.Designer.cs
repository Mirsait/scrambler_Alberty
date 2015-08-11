namespace Shifr
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
            this.tbOpenText = new System.Windows.Forms.TextBox();
            this.tbShText = new System.Windows.Forms.TextBox();
            this.btnCod = new System.Windows.Forms.Button();
            this.btnDecod = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbRU = new System.Windows.Forms.RadioButton();
            this.rbENG = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbOpenText
            // 
            this.tbOpenText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbOpenText.Location = new System.Drawing.Point(13, 30);
            this.tbOpenText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbOpenText.Multiline = true;
            this.tbOpenText.Name = "tbOpenText";
            this.tbOpenText.Size = new System.Drawing.Size(296, 73);
            this.tbOpenText.TabIndex = 0;
            this.tbOpenText.Text = "Любой текст";
            // 
            // tbShText
            // 
            this.tbShText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbShText.Location = new System.Drawing.Point(13, 143);
            this.tbShText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbShText.Multiline = true;
            this.tbShText.Name = "tbShText";
            this.tbShText.Size = new System.Drawing.Size(296, 73);
            this.tbShText.TabIndex = 1;
            this.tbShText.Text = "Какой-то текст";
            // 
            // btnCod
            // 
            this.btnCod.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnCod.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCod.Location = new System.Drawing.Point(10, 105);
            this.btnCod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCod.Name = "btnCod";
            this.btnCod.Size = new System.Drawing.Size(119, 29);
            this.btnCod.TabIndex = 2;
            this.btnCod.Text = "Шифровать";
            this.btnCod.UseVisualStyleBackColor = true;
            this.btnCod.Click += new System.EventHandler(this.btnCod_Click);
            // 
            // btnDecod
            // 
            this.btnDecod.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnDecod.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDecod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDecod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDecod.Location = new System.Drawing.Point(10, 143);
            this.btnDecod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDecod.Name = "btnDecod";
            this.btnDecod.Size = new System.Drawing.Size(119, 29);
            this.btnDecod.TabIndex = 3;
            this.btnDecod.Text = "Дешифровать";
            this.btnDecod.UseVisualStyleBackColor = true;
            this.btnDecod.Click += new System.EventHandler(this.btnDecod_Click);
            // 
            // btnClear
            // 
            this.btnClear.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClear.Location = new System.Drawing.Point(10, 187);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(119, 29);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tbKey
            // 
            this.tbKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbKey.Location = new System.Drawing.Point(10, 33);
            this.tbKey.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(119, 22);
            this.tbKey.TabIndex = 5;
            this.tbKey.Text = "ключ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Открытый текст";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Шифрованный текст";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ключ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbENG);
            this.panel1.Controls.Add(this.rbRU);
            this.panel1.Controls.Add(this.btnDecod);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnCod);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.tbKey);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(316, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(141, 242);
            this.panel1.TabIndex = 9;
            // 
            // rbRU
            // 
            this.rbRU.AutoSize = true;
            this.rbRU.Checked = true;
            this.rbRU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbRU.Location = new System.Drawing.Point(10, 68);
            this.rbRU.Name = "rbRU";
            this.rbRU.Size = new System.Drawing.Size(45, 20);
            this.rbRU.TabIndex = 9;
            this.rbRU.TabStop = true;
            this.rbRU.Text = "RU";
            this.rbRU.UseVisualStyleBackColor = true;
            // 
            // rbENG
            // 
            this.rbENG.AutoSize = true;
            this.rbENG.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.rbENG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbENG.Location = new System.Drawing.Point(75, 68);
            this.rbENG.Name = "rbENG";
            this.rbENG.Size = new System.Drawing.Size(54, 20);
            this.rbENG.TabIndex = 10;
            this.rbENG.Text = "ENG";
            this.rbENG.UseVisualStyleBackColor = true;
            this.rbENG.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 242);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbShText);
            this.Controls.Add(this.tbOpenText);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.95D;
            this.Text = "Шифратор Альберти";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbOpenText;
        private System.Windows.Forms.TextBox tbShText;
        private System.Windows.Forms.Button btnCod;
        private System.Windows.Forms.Button btnDecod;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox tbKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbENG;
        private System.Windows.Forms.RadioButton rbRU;
    }
}

