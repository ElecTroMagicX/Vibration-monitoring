using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace 震动监测系统
{
    static class controlconfig
    {
        //添加键为keyName、值为keyValue的项：
        public static void addItem(string keyName, string keyValue)
        {
            //添加配置文件的项，键为keyName，值为keyValue
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings.Add(keyName, keyValue);
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }

        //判断键为keyName的项是否存在：
        public static bool existItem(string keyName)
        {
            //判断配置文件中是否存在键为keyName的项
            foreach (string key in ConfigurationManager.AppSettings)
            {
                if (key == keyName)
                {
                    //存在
                    return true;
                }
            }
            return false;
        }

        //获取键为keyName的项的值：
        public static string valueItem(string keyName)
        {
            //返回配置文件中键为keyName的项的值
            return ConfigurationManager.AppSettings[keyName];
        }

        //修改键为keyName的项的值：
        public static void modifyItem(string keyName, string newKeyValue)
        {
            //修改配置文件中键为keyName的项的值
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings[keyName].Value = newKeyValue;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }

        //删除键为keyName的项：
        public static void removeItem(string keyName)
        {
            //删除配置文件键为keyName的项
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings.Remove(keyName);
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }

        /// <summary>
        /// 自动判断是否存在Item
        /// 若存在，修改值
        /// 不存在，添加值
        /// </summary>
        /// <param name="keyName"></param>
        public static void AddOrModifyItem(string keyName, string newKeyValue)
        {
            if (existItem(keyName))
            {
                modifyItem(keyName, newKeyValue);
            }
            else
            {
                addItem(keyName, newKeyValue);
            }
        }
    }
}
