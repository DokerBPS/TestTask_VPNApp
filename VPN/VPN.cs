using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTask_VPNApp.Helpers;

namespace TestTask_VPNApp.VPN
{
    public class VPNManager
    {
        /// <summary>
        /// Состояние подключения к VPN серверу
        /// </summary>
        public VPNConnectionResult ConnectionState { get; set; }

        /// <summary>
        /// Создание подключения к выбранному серверу
        /// </summary>
        /// <param name="countryName">Наименование страны</param>
        /// <param name="countryCode">Код страны</param>
        public void ConnectToVPN(string countryName, string countryCode)
        {
            try
            {
                // реализация подключения к VPN серверу

                ConnectionState = new VPNConnectionResult() { errorMessage = "", isConnected = true };
            }
            catch (Exception ex)
            {
                Log.Logger.WriteError(DateTime.Now, "VPN.ConnectToVPN", ex.ToString());
                ConnectionState = new VPNConnectionResult() { errorMessage = ex.Message, isConnected = false };
            }
        }
    }
}
