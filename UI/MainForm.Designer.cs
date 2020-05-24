namespace TestTask_VPNApp
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmi_ChooseCountry = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_ChoosedCountry = new System.Windows.Forms.Label();
            this.pcbx_CountryFlag = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btn_Disconnect = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbx_CountryFlag)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_ChooseCountry});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(330, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmi_ChooseCountry
            // 
            this.tsmi_ChooseCountry.Name = "tsmi_ChooseCountry";
            this.tsmi_ChooseCountry.Size = new System.Drawing.Size(106, 20);
            this.tsmi_ChooseCountry.Text = "Выбрать страну";
            this.tsmi_ChooseCountry.Click += new System.EventHandler(this.tsmi_ChooseCountry_Click);
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(12, 180);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(306, 62);
            this.btn_Connect.TabIndex = 1;
            this.btn_Connect.Text = "Подключиться";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выбранная страна:";
            // 
            // lbl_ChoosedCountry
            // 
            this.lbl_ChoosedCountry.AutoSize = true;
            this.lbl_ChoosedCountry.Location = new System.Drawing.Point(123, 69);
            this.lbl_ChoosedCountry.Name = "lbl_ChoosedCountry";
            this.lbl_ChoosedCountry.Size = new System.Drawing.Size(113, 13);
            this.lbl_ChoosedCountry.TabIndex = 3;
            this.lbl_ChoosedCountry.Text = "...страна не выбрана";
            // 
            // pcbx_CountryFlag
            // 
            this.pcbx_CountryFlag.Location = new System.Drawing.Point(15, 85);
            this.pcbx_CountryFlag.Name = "pcbx_CountryFlag";
            this.pcbx_CountryFlag.Size = new System.Drawing.Size(303, 89);
            this.pcbx_CountryFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbx_CountryFlag.TabIndex = 4;
            this.pcbx_CountryFlag.TabStop = false;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btn_Disconnect
            // 
            this.btn_Disconnect.Location = new System.Drawing.Point(12, 248);
            this.btn_Disconnect.Name = "btn_Disconnect";
            this.btn_Disconnect.Size = new System.Drawing.Size(306, 23);
            this.btn_Disconnect.TabIndex = 5;
            this.btn_Disconnect.Text = "Отключиться";
            this.btn_Disconnect.UseVisualStyleBackColor = true;
            this.btn_Disconnect.Click += new System.EventHandler(this.btn_Disconnect_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 283);
            this.Controls.Add(this.btn_Disconnect);
            this.Controls.Add(this.pcbx_CountryFlag);
            this.Controls.Add(this.lbl_ChoosedCountry);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Connect);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VPN";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbx_CountryFlag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmi_ChooseCountry;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_ChoosedCountry;
        private System.Windows.Forms.PictureBox pcbx_CountryFlag;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btn_Disconnect;
    }
}

