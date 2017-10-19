namespace Quiz
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cb1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb2 = new System.Windows.Forms.CheckBox();
            this.cb3 = new System.Windows.Forms.CheckBox();
            this.cb4 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 75);
            this.label1.TabIndex = 0;
            this.label1.Text = "Управление ресурсами включает решение общих, не зависящих от типов ресурсов задач" +
    ".\r\nУкажите, какие из нижеприведенных задач являются лишними\r\n(следует отметить н" +
    "есколько вариантов)";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(100, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cb1
            // 
            this.cb1.AutoSize = true;
            this.cb1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cb1.Location = new System.Drawing.Point(12, 116);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(150, 17);
            this.cb1.TabIndex = 2;
            this.cb1.Text = "Планированние ресурса";
            this.cb1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(8, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Поставьте флажок в нужном месте и нажмите ОК";
            // 
            // cb2
            // 
            this.cb2.AutoSize = true;
            this.cb2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cb2.Location = new System.Drawing.Point(12, 139);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(196, 17);
            this.cb2.TabIndex = 4;
            this.cb2.Text = "Ослеживание состояния ресурса";
            this.cb2.UseVisualStyleBackColor = true;
            // 
            // cb3
            // 
            this.cb3.AutoSize = true;
            this.cb3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cb3.Location = new System.Drawing.Point(12, 162);
            this.cb3.Name = "cb3";
            this.cb3.Size = new System.Drawing.Size(191, 17);
            this.cb3.TabIndex = 5;
            this.cb3.Text = "Повышенние приоритета задачи";
            this.cb3.UseVisualStyleBackColor = true;
            // 
            // cb4
            // 
            this.cb4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cb4.Location = new System.Drawing.Point(12, 180);
            this.cb4.Name = "cb4";
            this.cb4.Size = new System.Drawing.Size(260, 34);
            this.cb4.TabIndex = 6;
            this.cb4.Text = "Синхронизация работы различных устройств компьютра";
            this.cb4.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cb4);
            this.Controls.Add(this.cb3);
            this.Controls.Add(this.cb2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вопрос2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox cb1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cb2;
        private System.Windows.Forms.CheckBox cb3;
        private System.Windows.Forms.CheckBox cb4;
    }
}