namespace TestTask_VPNApp.UI
{
    partial class AvailableCountriesForm
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Республика Беларусь", 0);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Республика Молдова", 1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AvailableCountriesForm));
            this.lstvw_CountryList = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // lstvw_CountryList
            // 
            this.lstvw_CountryList.Dock = System.Windows.Forms.DockStyle.Top;
            this.lstvw_CountryList.FullRowSelect = true;
            this.lstvw_CountryList.HideSelection = false;
            listViewItem1.Tag = "BY";
            listViewItem2.Tag = "MD";
            this.lstvw_CountryList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.lstvw_CountryList.LargeImageList = this.imageList1;
            this.lstvw_CountryList.Location = new System.Drawing.Point(0, 0);
            this.lstvw_CountryList.Name = "lstvw_CountryList";
            this.lstvw_CountryList.Size = new System.Drawing.Size(248, 316);
            this.lstvw_CountryList.SmallImageList = this.imageList1;
            this.lstvw_CountryList.TabIndex = 0;
            this.lstvw_CountryList.UseCompatibleStateImageBehavior = false;
            this.lstvw_CountryList.View = System.Windows.Forms.View.List;
            this.lstvw_CountryList.SelectedIndexChanged += new System.EventHandler(this.lstvw_CountryList_SelectedIndexChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "BY.png");
            this.imageList1.Images.SetKeyName(1, "md.png");
            // 
            // AvailableCountriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 327);
            this.Controls.Add(this.lstvw_CountryList);
            this.Name = "AvailableCountriesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Доступные страны";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstvw_CountryList;
        private System.Windows.Forms.ImageList imageList1;
    }
}