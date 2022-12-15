﻿namespace BayesSpamFilterApp
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
            this.components = new System.ComponentModel.Container();
            this.label_input = new System.Windows.Forms.Label();
            this.textBox_message = new System.Windows.Forms.TextBox();
            this.radioButton_Porter = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox_stemmers = new System.Windows.Forms.GroupBox();
            this.button_checkmsg = new System.Windows.Forms.Button();
            this.groupBox_filtering = new System.Windows.Forms.GroupBox();
            this.button_tip = new System.Windows.Forms.Button();
            this.radioButton_high = new System.Windows.Forms.RadioButton();
            this.radioButton_middle = new System.Windows.Forms.RadioButton();
            this.radioButton_low = new System.Windows.Forms.RadioButton();
            this.toolTip_harshness = new System.Windows.Forms.ToolTip(this.components);
            this.label_result = new System.Windows.Forms.Label();
            this.groupBox_stemmers.SuspendLayout();
            this.groupBox_filtering.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_input
            // 
            this.label_input.AutoSize = true;
            this.label_input.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_input.Location = new System.Drawing.Point(31, 23);
            this.label_input.Name = "label_input";
            this.label_input.Size = new System.Drawing.Size(614, 41);
            this.label_input.TabIndex = 0;
            this.label_input.Text = "Вставьте сообщение для проверки на спам";
            // 
            // textBox_message
            // 
            this.textBox_message.Location = new System.Drawing.Point(12, 80);
            this.textBox_message.Multiline = true;
            this.textBox_message.Name = "textBox_message";
            this.textBox_message.Size = new System.Drawing.Size(633, 480);
            this.textBox_message.TabIndex = 1;
            // 
            // radioButton_Porter
            // 
            this.radioButton_Porter.AutoSize = true;
            this.radioButton_Porter.Checked = true;
            this.radioButton_Porter.Location = new System.Drawing.Point(15, 32);
            this.radioButton_Porter.Name = "radioButton_Porter";
            this.radioButton_Porter.Size = new System.Drawing.Size(156, 24);
            this.radioButton_Porter.TabIndex = 2;
            this.radioButton_Porter.TabStop = true;
            this.radioButton_Porter.Text = "Стеммер Портера";
            this.radioButton_Porter.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(15, 62);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(157, 24);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Какой-то стеммер";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox_stemmers
            // 
            this.groupBox_stemmers.Controls.Add(this.radioButton_Porter);
            this.groupBox_stemmers.Controls.Add(this.radioButton2);
            this.groupBox_stemmers.Location = new System.Drawing.Point(651, 80);
            this.groupBox_stemmers.Name = "groupBox_stemmers";
            this.groupBox_stemmers.Size = new System.Drawing.Size(277, 109);
            this.groupBox_stemmers.TabIndex = 4;
            this.groupBox_stemmers.TabStop = false;
            this.groupBox_stemmers.Text = "Выберите стеммер";
            // 
            // button_checkmsg
            // 
            this.button_checkmsg.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_checkmsg.Location = new System.Drawing.Point(651, 326);
            this.button_checkmsg.Name = "button_checkmsg";
            this.button_checkmsg.Size = new System.Drawing.Size(277, 79);
            this.button_checkmsg.TabIndex = 5;
            this.button_checkmsg.Text = "Проверить";
            this.button_checkmsg.UseVisualStyleBackColor = true;
            this.button_checkmsg.Click += new System.EventHandler(this.button_checkmsg_Click);
            // 
            // groupBox_filtering
            // 
            this.groupBox_filtering.Controls.Add(this.button_tip);
            this.groupBox_filtering.Controls.Add(this.radioButton_high);
            this.groupBox_filtering.Controls.Add(this.radioButton_middle);
            this.groupBox_filtering.Controls.Add(this.radioButton_low);
            this.groupBox_filtering.Location = new System.Drawing.Point(651, 195);
            this.groupBox_filtering.Name = "groupBox_filtering";
            this.groupBox_filtering.Size = new System.Drawing.Size(277, 125);
            this.groupBox_filtering.TabIndex = 6;
            this.groupBox_filtering.TabStop = false;
            this.groupBox_filtering.Text = "Выберите жесткость отбора спама";
            // 
            // button_tip
            // 
            this.button_tip.BackColor = System.Drawing.Color.Navy;
            this.button_tip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_tip.Cursor = System.Windows.Forms.Cursors.Help;
            this.button_tip.FlatAppearance.BorderSize = 0;
            this.button_tip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_tip.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button_tip.Location = new System.Drawing.Point(248, 21);
            this.button_tip.Name = "button_tip";
            this.button_tip.Size = new System.Drawing.Size(23, 29);
            this.button_tip.TabIndex = 7;
            this.button_tip.Text = "?";
            this.toolTip_harshness.SetToolTip(this.button_tip, "Чем больше жесткость, тем больше вероятность, что сообщение будет отнесено к спам" +
        "у");
            this.button_tip.UseVisualStyleBackColor = false;
            // 
            // radioButton_high
            // 
            this.radioButton_high.AutoSize = true;
            this.radioButton_high.Location = new System.Drawing.Point(14, 86);
            this.radioButton_high.Name = "radioButton_high";
            this.radioButton_high.Size = new System.Drawing.Size(89, 24);
            this.radioButton_high.TabIndex = 2;
            this.radioButton_high.Text = "Жесткий";
            this.radioButton_high.UseVisualStyleBackColor = true;
            // 
            // radioButton_middle
            // 
            this.radioButton_middle.AutoSize = true;
            this.radioButton_middle.Location = new System.Drawing.Point(14, 56);
            this.radioButton_middle.Name = "radioButton_middle";
            this.radioButton_middle.Size = new System.Drawing.Size(91, 24);
            this.radioButton_middle.TabIndex = 1;
            this.radioButton_middle.Text = "Средний";
            this.radioButton_middle.UseVisualStyleBackColor = true;
            // 
            // radioButton_low
            // 
            this.radioButton_low.AutoSize = true;
            this.radioButton_low.Checked = true;
            this.radioButton_low.Location = new System.Drawing.Point(14, 26);
            this.radioButton_low.Name = "radioButton_low";
            this.radioButton_low.Size = new System.Drawing.Size(82, 24);
            this.radioButton_low.TabIndex = 0;
            this.radioButton_low.TabStop = true;
            this.radioButton_low.Text = "Мягкий";
            this.radioButton_low.UseVisualStyleBackColor = true;
            // 
            // toolTip_harshness
            // 
            this.toolTip_harshness.AutomaticDelay = 100;
            this.toolTip_harshness.AutoPopDelay = 10000;
            this.toolTip_harshness.InitialDelay = 100;
            this.toolTip_harshness.ReshowDelay = 20;
            // 
            // label_result
            // 
            this.label_result.Font = new System.Drawing.Font("Ustroke", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_result.ForeColor = System.Drawing.Color.Red;
            this.label_result.Location = new System.Drawing.Point(664, 413);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(253, 46);
            this.label_result.TabIndex = 7;
            this.label_result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 572);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.groupBox_filtering);
            this.Controls.Add(this.button_checkmsg);
            this.Controls.Add(this.groupBox_stemmers);
            this.Controls.Add(this.textBox_message);
            this.Controls.Add(this.label_input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox_stemmers.ResumeLayout(false);
            this.groupBox_stemmers.PerformLayout();
            this.groupBox_filtering.ResumeLayout(false);
            this.groupBox_filtering.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_input;
        private TextBox textBox_message;
        private RadioButton radioButton_Porter;
        private RadioButton radioButton2;
        private GroupBox groupBox_stemmers;
        private Button button_checkmsg;
        private GroupBox groupBox_filtering;
        private RadioButton radioButton_high;
        private RadioButton radioButton_middle;
        private RadioButton radioButton_low;
        private Button button_tip;
        private ToolTip toolTip_harshness;
        private Label label_result;
    }
}