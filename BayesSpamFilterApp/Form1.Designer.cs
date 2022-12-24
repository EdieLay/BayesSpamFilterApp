namespace BayesSpamFilterApp
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
            this.radioButton_Z = new System.Windows.Forms.RadioButton();
            this.groupBox_stemmers = new System.Windows.Forms.GroupBox();
            this.radioButton_Stemka = new System.Windows.Forms.RadioButton();
            this.button_checkmsg = new System.Windows.Forms.Button();
            this.groupBox_filtering = new System.Windows.Forms.GroupBox();
            this.button_tip = new System.Windows.Forms.Button();
            this.radioButton_harsh = new System.Windows.Forms.RadioButton();
            this.radioButton_mid = new System.Windows.Forms.RadioButton();
            this.radioButton_soft = new System.Windows.Forms.RadioButton();
            this.toolTip_harshness = new System.Windows.Forms.ToolTip(this.components);
            this.label_result = new System.Windows.Forms.Label();
            this.openFileDialog_file = new System.Windows.Forms.OpenFileDialog();
            this.button_file = new System.Windows.Forms.Button();
            this.groupBox_stemmers.SuspendLayout();
            this.groupBox_filtering.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_input
            // 
            this.label_input.AutoSize = true;
            this.label_input.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_input.Location = new System.Drawing.Point(12, 23);
            this.label_input.Name = "label_input";
            this.label_input.Size = new System.Drawing.Size(672, 41);
            this.label_input.TabIndex = 0;
            this.label_input.Text = "Вставьте сообщение для проверки на спам или";
            // 
            // textBox_message
            // 
            this.textBox_message.Location = new System.Drawing.Point(12, 80);
            this.textBox_message.Multiline = true;
            this.textBox_message.Name = "textBox_message";
            this.textBox_message.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_message.Size = new System.Drawing.Size(633, 480);
            this.textBox_message.TabIndex = 1;
            // 
            // radioButton_Porter
            // 
            this.radioButton_Porter.AutoSize = true;
            this.radioButton_Porter.Checked = true;
            this.radioButton_Porter.Location = new System.Drawing.Point(13, 32);
            this.radioButton_Porter.Name = "radioButton_Porter";
            this.radioButton_Porter.Size = new System.Drawing.Size(156, 24);
            this.radioButton_Porter.TabIndex = 2;
            this.radioButton_Porter.TabStop = true;
            this.radioButton_Porter.Text = "Стеммер Портера";
            this.radioButton_Porter.UseVisualStyleBackColor = true;
            // 
            // radioButton_Z
            // 
            this.radioButton_Z.AutoSize = true;
            this.radioButton_Z.Location = new System.Drawing.Point(13, 62);
            this.radioButton_Z.Name = "radioButton_Z";
            this.radioButton_Z.Size = new System.Drawing.Size(105, 24);
            this.radioButton_Z.TabIndex = 3;
            this.radioButton_Z.TabStop = true;
            this.radioButton_Z.Text = "Стеммер Z";
            this.radioButton_Z.UseVisualStyleBackColor = true;
            // 
            // groupBox_stemmers
            // 
            this.groupBox_stemmers.Controls.Add(this.radioButton_Stemka);
            this.groupBox_stemmers.Controls.Add(this.radioButton_Porter);
            this.groupBox_stemmers.Controls.Add(this.radioButton_Z);
            this.groupBox_stemmers.Location = new System.Drawing.Point(651, 80);
            this.groupBox_stemmers.Name = "groupBox_stemmers";
            this.groupBox_stemmers.Size = new System.Drawing.Size(277, 129);
            this.groupBox_stemmers.TabIndex = 4;
            this.groupBox_stemmers.TabStop = false;
            this.groupBox_stemmers.Text = "Выберите стеммер";
            // 
            // radioButton_Stemka
            // 
            this.radioButton_Stemka.AutoSize = true;
            this.radioButton_Stemka.Location = new System.Drawing.Point(14, 92);
            this.radioButton_Stemka.Name = "radioButton_Stemka";
            this.radioButton_Stemka.Size = new System.Drawing.Size(79, 24);
            this.radioButton_Stemka.TabIndex = 4;
            this.radioButton_Stemka.TabStop = true;
            this.radioButton_Stemka.Text = "Stemka";
            this.radioButton_Stemka.UseVisualStyleBackColor = true;
            // 
            // button_checkmsg
            // 
            this.button_checkmsg.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_checkmsg.Location = new System.Drawing.Point(651, 346);
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
            this.groupBox_filtering.Controls.Add(this.radioButton_harsh);
            this.groupBox_filtering.Controls.Add(this.radioButton_mid);
            this.groupBox_filtering.Controls.Add(this.radioButton_soft);
            this.groupBox_filtering.Location = new System.Drawing.Point(651, 215);
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
            // radioButton_harsh
            // 
            this.radioButton_harsh.AutoSize = true;
            this.radioButton_harsh.Location = new System.Drawing.Point(14, 86);
            this.radioButton_harsh.Name = "radioButton_harsh";
            this.radioButton_harsh.Size = new System.Drawing.Size(89, 24);
            this.radioButton_harsh.TabIndex = 2;
            this.radioButton_harsh.Text = "Жесткий";
            this.radioButton_harsh.UseVisualStyleBackColor = true;
            // 
            // radioButton_mid
            // 
            this.radioButton_mid.AutoSize = true;
            this.radioButton_mid.Location = new System.Drawing.Point(14, 56);
            this.radioButton_mid.Name = "radioButton_mid";
            this.radioButton_mid.Size = new System.Drawing.Size(91, 24);
            this.radioButton_mid.TabIndex = 1;
            this.radioButton_mid.Text = "Средний";
            this.radioButton_mid.UseVisualStyleBackColor = true;
            // 
            // radioButton_soft
            // 
            this.radioButton_soft.AutoSize = true;
            this.radioButton_soft.Checked = true;
            this.radioButton_soft.Location = new System.Drawing.Point(14, 26);
            this.radioButton_soft.Name = "radioButton_soft";
            this.radioButton_soft.Size = new System.Drawing.Size(82, 24);
            this.radioButton_soft.TabIndex = 0;
            this.radioButton_soft.TabStop = true;
            this.radioButton_soft.Text = "Мягкий";
            this.radioButton_soft.UseVisualStyleBackColor = true;
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
            this.label_result.Location = new System.Drawing.Point(651, 433);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(287, 95);
            this.label_result.TabIndex = 7;
            this.label_result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openFileDialog_file
            // 
            this.openFileDialog_file.FileName = "openFileDialog1";
            // 
            // button_file
            // 
            this.button_file.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_file.Location = new System.Drawing.Point(677, 23);
            this.button_file.Name = "button_file";
            this.button_file.Size = new System.Drawing.Size(174, 41);
            this.button_file.TabIndex = 8;
            this.button_file.Text = "Выберите файл";
            this.button_file.UseVisualStyleBackColor = true;
            this.button_file.Click += new System.EventHandler(this.button_file_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 572);
            this.Controls.Add(this.button_file);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.groupBox_filtering);
            this.Controls.Add(this.button_checkmsg);
            this.Controls.Add(this.groupBox_stemmers);
            this.Controls.Add(this.textBox_message);
            this.Controls.Add(this.label_input);
            this.Name = "Form1";
            this.Text = "к";
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
        private RadioButton radioButton_Z;
        private GroupBox groupBox_stemmers;
        private Button button_checkmsg;
        private GroupBox groupBox_filtering;
        private RadioButton radioButton_harsh;
        private RadioButton radioButton_mid;
        private RadioButton radioButton_soft;
        private Button button_tip;
        private ToolTip toolTip_harshness;
        private Label label_result;
        private RadioButton radioButton_Stemka;
        private OpenFileDialog openFileDialog_file;
        private Button button_file;
    }
}