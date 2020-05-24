using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestTask_VPNApp.UI
{
    public partial class AvailableCountriesForm : Form
    {
        /// <summary>
        /// Код выбранной страны
        /// </summary>
        public string CountryCode { get; set; }
        /// <summary>
        /// Наименование страны
        /// </summary>
        public string CountryName { get; set; }

        public AvailableCountriesForm()
        {
            InitializeComponent();
        }

        private void lstvw_CountryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            CountryCode = (sender as ListView).SelectedItems[0].Tag.ToString();
            CountryName = (sender as ListView).SelectedItems[0].Text;

            this.Close();
        }

        /// <summary>
        /// Очистка выбранных элементов
        /// </summary>
        public void ClearSelectrion()
        {
            for (int i = 0; i < this.lstvw_CountryList.SelectedIndices.Count; i++)
            {
                this.lstvw_CountryList.Items[this.lstvw_CountryList.SelectedIndices[i]].Selected = false;
                this.lstvw_CountryList.Items[this.lstvw_CountryList.SelectedIndices[i]].Focused = false;
            }
        }
    }
}
