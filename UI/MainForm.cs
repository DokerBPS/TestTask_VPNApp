using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestTask_VPNApp.UI;
using TestTask_VPNApp.VPN;

namespace TestTask_VPNApp
{
    public partial class MainForm : Form
    {
        string countryCode, countryName;
        AvailableCountriesForm availableCountriesForm;
        VPNManager vpn_context;
        TimeSpan connectionTime;

        public MainForm()
        {
            InitializeComponent();

            availableCountriesForm = new AvailableCountriesForm();
            vpn_context = new VPNManager();
            connectionTime = new TimeSpan();

            btn_Connect.Enabled = false;
            btn_Disconnect.Visible = false;
        }

        private void tsmi_ChooseCountry_Click(object sender, EventArgs e)
        {
            availableCountriesForm.ClearSelectrion();
            availableCountriesForm.ShowDialog();

            lbl_ChoosedCountry.Text = countryName = availableCountriesForm.CountryName;
            countryCode = availableCountriesForm.CountryCode;

            pcbx_CountryFlag.Image = Image.FromFile(@"Resources\Images\" + countryCode.ToLower() + ".png");

            btn_Connect.Enabled = true;
        }

        private void tsmi_About_Click(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() =>
            {
                connectionTime = connectionTime.Add(new TimeSpan(0, 0, 0, 0, 100));

                btn_Connect.Invoke(new Action(() =>
                {
                    btn_Connect.Text = "Подключение.....";

                    if (connectionTime.Milliseconds % 200 == 0)
                        btn_Connect.BackColor = Color.Cornsilk;
                    else
                        btn_Connect.BackColor = Control.DefaultBackColor;

                }));

                if (connectionTime.Seconds == 5)
                {
                    connectionTime = new TimeSpan();
                    timer.Stop();

                    btn_Connect.Invoke(new Action(() =>
                    {
                        if (vpn_context.ConnectionState.isConnected)
                        {
                            btn_Connect.BackColor = Control.DefaultBackColor;
                            //btn_Connect.Text = "Подключиться";

                            btn_Connect.Text = "Подключено";
                        }
                        else
                        {
                            MessageBox.Show(vpn_context.ConnectionState.errorMessage, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }));
                    btn_Disconnect.Invoke(new Action(() => { btn_Disconnect.Visible = true; }));
                }
            });
        }

        private void btn_Disconnect_Click(object sender, EventArgs e)
        {
            btn_Disconnect.Visible = false;
            btn_Connect.Enabled = true;
            btn_Connect.Text = "Подключиться";
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            bool isAvailableConnect = true; // вызов метода проверки тарифного плана пользователя, для тестирования стоит true

            if (isAvailableConnect == true)
            {
                btn_Connect.Enabled = false;
                vpn_context.ConnectToVPN(countryName: countryName, countryCode: countryCode);
                timer.Start();
            }
            else
                MessageBox.Show("Текущий тарифный план не позволяет подключаться к данной стране", "Тарифный план", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
