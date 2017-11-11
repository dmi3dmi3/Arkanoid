namespace Arkanoid
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PlayPnl = new System.Windows.Forms.Panel();
            this.PlayBtn = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.PlayPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlayPnl
            // 
            this.PlayPnl.BackColor = System.Drawing.SystemColors.Window;
            this.PlayPnl.Controls.Add(this.PlayBtn);
            this.PlayPnl.Location = new System.Drawing.Point(10, 10);
            this.PlayPnl.Name = "PlayPnl";
            this.PlayPnl.Size = new System.Drawing.Size(400, 420);
            this.PlayPnl.TabIndex = 0;
            // 
            // PlayBtn
            // 
            this.PlayBtn.Location = new System.Drawing.Point(135, 124);
            this.PlayBtn.Name = "PlayBtn";
            this.PlayBtn.Size = new System.Drawing.Size(133, 68);
            this.PlayBtn.TabIndex = 0;
            this.PlayBtn.Text = "Play";
            this.PlayBtn.UseVisualStyleBackColor = true;
            this.PlayBtn.Click += new System.EventHandler(this.PlayBtn_Click);
            // 
            // timer
            // 
            this.timer.Interval = 16;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 442);
            this.Controls.Add(this.PlayPnl);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Arkanoid";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.PlayPnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PlayPnl;
        private System.Windows.Forms.Button PlayBtn;
        private System.Windows.Forms.Timer timer;
    }
}

