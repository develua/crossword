namespace CrosswordCall
{
    partial class Call
    {
        /// <summary>
        /// Требуется переменная конструктора.
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте 
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.letterCall = new System.Windows.Forms.Label();
            this.numberTop = new System.Windows.Forms.Label();
            this.numberBottom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // letterCall
            // 
            this.letterCall.Dock = System.Windows.Forms.DockStyle.Fill;
            this.letterCall.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.letterCall.Location = new System.Drawing.Point(0, 14);
            this.letterCall.Name = "letterCall";
            this.letterCall.Size = new System.Drawing.Size(35, 7);
            this.letterCall.TabIndex = 0;
            this.letterCall.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numberTop
            // 
            this.numberTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.numberTop.ForeColor = System.Drawing.Color.Red;
            this.numberTop.Location = new System.Drawing.Point(0, 0);
            this.numberTop.Margin = new System.Windows.Forms.Padding(0);
            this.numberTop.Name = "numberTop";
            this.numberTop.Size = new System.Drawing.Size(35, 14);
            this.numberTop.TabIndex = 1;
            this.numberTop.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // numberBottom
            // 
            this.numberBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.numberBottom.ForeColor = System.Drawing.Color.Blue;
            this.numberBottom.Location = new System.Drawing.Point(0, 21);
            this.numberBottom.Margin = new System.Windows.Forms.Padding(0);
            this.numberBottom.Name = "numberBottom";
            this.numberBottom.Size = new System.Drawing.Size(35, 14);
            this.numberBottom.TabIndex = 2;
            this.numberBottom.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // Call
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.letterCall);
            this.Controls.Add(this.numberBottom);
            this.Controls.Add(this.numberTop);
            this.Name = "Call";
            this.Size = new System.Drawing.Size(35, 35);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label letterCall;
        private System.Windows.Forms.Label numberTop;
        private System.Windows.Forms.Label numberBottom;
    }
}
