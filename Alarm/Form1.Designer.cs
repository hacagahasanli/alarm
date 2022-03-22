
namespace Alarm
{
    partial class Alarm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alarm));
            this.tb_indi = new System.Windows.Forms.TextBox();
            this.text_box = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.timer_now = new System.Windows.Forms.Timer(this.components);
            this.tb_vaxt = new System.Windows.Forms.TextBox();
            this.btn_baslatt = new System.Windows.Forms.Button();
            this.timer_yoxlaa = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // tb_indi
            // 
            this.tb_indi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_indi.Location = new System.Drawing.Point(377, 606);
            this.tb_indi.Name = "tb_indi";
            this.tb_indi.Size = new System.Drawing.Size(202, 27);
            this.tb_indi.TabIndex = 0;
            this.tb_indi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_indi.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // text_box
            // 
            this.text_box.Name = "text_box";
            this.text_box.Size = new System.Drawing.Size(61, 4);
            // 
            // timer_now
            // 
            this.timer_now.Interval = 1000;
            this.timer_now.Tick += new System.EventHandler(this.timer_now_Tick);
            // 
            // tb_vaxt
            // 
            this.tb_vaxt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_vaxt.Location = new System.Drawing.Point(594, 606);
            this.tb_vaxt.Name = "tb_vaxt";
            this.tb_vaxt.Size = new System.Drawing.Size(202, 27);
            this.tb_vaxt.TabIndex = 2;
            // 
            // btn_baslatt
            // 
            this.btn_baslatt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_baslatt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_baslatt.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_baslatt.Location = new System.Drawing.Point(546, 649);
            this.btn_baslatt.Name = "btn_baslatt";
            this.btn_baslatt.Size = new System.Drawing.Size(79, 26);
            this.btn_baslatt.TabIndex = 3;
            this.btn_baslatt.Text = "Baslat";
            this.btn_baslatt.UseVisualStyleBackColor = false;
            // 
            // timer_yoxlaa
            // 
            this.timer_yoxlaa.Interval = 1000;
            this.timer_yoxlaa.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Alarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::Alarm.Properties.Resources.Alarm_clock_icon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1191, 698);
            this.Controls.Add(this.btn_baslatt);
            this.Controls.Add(this.tb_vaxt);
            this.Controls.Add(this.tb_indi);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Alarm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Alarm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_indi;
        private System.Windows.Forms.ContextMenuStrip text_box;
        private System.Windows.Forms.Timer timer_now;
        private System.Windows.Forms.TextBox tb_vaxt;
        private System.Windows.Forms.Button btn_baslatt;
        private System.Windows.Forms.Timer timer_yoxlaa;
    }
}

