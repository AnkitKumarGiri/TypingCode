namespace UI_Form
{
    partial class TypingCodeForm
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
            this.components = new System.ComponentModel.Container();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtPane = new System.Windows.Forms.TextBox();
            this.lblHead = new System.Windows.Forms.Label();
            this.lblStats = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(436, 425);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(319, 39);
            this.txtInput.TabIndex = 0;
            this.txtInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtInput_KeyUp);
            // 
            // txtPane
            // 
            this.txtPane.Enabled = false;
            this.txtPane.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPane.Location = new System.Drawing.Point(247, 247);
            this.txtPane.Name = "txtPane";
            this.txtPane.Size = new System.Drawing.Size(755, 39);
            this.txtPane.TabIndex = 2;
            // 
            // lblHead
            // 
            this.lblHead.AutoSize = true;
            this.lblHead.Font = new System.Drawing.Font("Consolas", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHead.Location = new System.Drawing.Point(202, 42);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(856, 56);
            this.lblHead.TabIndex = 3;
            this.lblHead.Text = "Practice your code typing skills";
            // 
            // lblStats
            // 
            this.lblStats.AutoSize = true;
            this.lblStats.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStats.Location = new System.Drawing.Point(552, 540);
            this.lblStats.Name = "lblStats";
            this.lblStats.Size = new System.Drawing.Size(0, 28);
            this.lblStats.TabIndex = 4;
            this.lblStats.Click += new System.EventHandler(this.lblStats_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(856, 427);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(75, 33);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "Time";
            // 
            // TypingCodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 763);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblStats);
            this.Controls.Add(this.lblHead);
            this.Controls.Add(this.txtPane);
            this.Controls.Add(this.txtInput);
            this.Name = "TypingCodeForm";
            this.Text = "TypingCodeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtPane;
        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.Label lblStats;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblTime;
    }
}

