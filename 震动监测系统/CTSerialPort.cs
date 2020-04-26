using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;

namespace 震动监测系统
{
    static class CTSerialPort
    {
        
        static SerialPort sp = new SerialPort();

        /// <summary>
        /// 设置串口通信参数
        /// </summary>
        /// <param name="comnum"串口号></param>
        /// <param name="bodenum"波特率></param>
        /// <param name="datanum"数据位></param>
        /// <param name="stopnum"停止位></param>
        public static bool SetSP()
        {
            if (controlconfig.existItem("portnum")
                && controlconfig.existItem("bodenum")
                && controlconfig.existItem("datanum")
                && controlconfig.existItem("stopnum"))
            {
                if (controlconfig.valueItem("portnum") != null
                    && controlconfig.valueItem("bodenum") != null
                    && controlconfig.valueItem("datanum") != null
                    && controlconfig.valueItem("stopnum") != null)
                {
                    SetSP(controlconfig.valueItem("portnum"),
                        controlconfig.valueItem("bodenum"),
                        controlconfig.valueItem("datanum"),
                        controlconfig.valueItem("stopnum"));
                    return true;
                }  
            }
            return false;
        }
        public static bool SetSP(string comnum, int bodenum, int datanum, string stopnum)
        {
            if (sp.IsOpen)
            {
                sp.Close();
            }
            if (datanum > 8 || datanum < 5)
            {
                MessageBox.Show("数据位参数范围为[5,8]");
                return false;
            }
            sp.ReadBufferSize = 1;
            sp.PortName = comnum;
            sp.BaudRate = bodenum;
            sp.DataBits = datanum;
            switch (stopnum)
            {
                case "1":
                    sp.StopBits = StopBits.One;
                    break;
                case "2":
                    sp.StopBits = StopBits.Two;
                    break;
                case "1.5":
                    sp.StopBits = StopBits.OnePointFive;
                    break;
                default:
                    MessageBox.Show("停止位参数错误");
                    break;
            }
            //sp.Encoding = UTF8Encoding.UTF8;
            return true;
        }
        public static bool SetSP(string comnum, string bodenum, string datanum, string stopnum)
        {
            if (sp.IsOpen)
            {
                sp.Close();
            }
            int bodenumInt, datanumInt;
            if (!int.TryParse(bodenum, out bodenumInt))
            {
                MessageBox.Show("波特率参数错误");
                return false;
            }
            if (!int.TryParse(datanum, out datanumInt))
            {
                MessageBox.Show("数据位参数错误");
                return false;
            }
            if (datanumInt > 8 || datanumInt < 5)
            {
                MessageBox.Show("数据位参数范围为[5,8]");
                return false;
            }
            //sp.ReadBufferSize = 1;
            sp.PortName = comnum;
            sp.BaudRate = int.Parse(bodenum);
            sp.DataBits = int.Parse(datanum);
            switch (stopnum)
            {
                case "1":
                    sp.StopBits = StopBits.One;
                    break;
                case "2":
                    sp.StopBits = StopBits.Two;
                    break;
                case "1.5":
                    sp.StopBits = StopBits.OnePointFive;
                    break;
                default:
                    MessageBox.Show("停止位参数错误");
                    return false;
            }
            return true;
        }


        /// <summary>
        /// 打开串口
        /// </summary>
        /// <param name="comnum"></param>
        /// <param name="bodenum"></param>
        /// <param name="datanum"></param>
        /// <param name="stopnum"></param>
        /// <returns></returns>
        public static bool OpenSP()
        {
            if (sp.IsOpen)
            {
                sp.Close();
            }
            else
            {
                try
                {
                    sp.Open();
                }
                catch (Exception)
                {
                    return false;
                    throw;
                }
            }
            return true;
        }


        /// <summary>
        /// 关闭串口
        /// true：关闭成功
        /// false：关闭失败
        /// </summary>
        /// <returns></returns>
        public static bool CloseSP()
        {
            sp.Close();
            return !sp.IsOpen;
        }


        /// <summary>
        /// 判断串口开闭状态
        /// true：打开状态
        /// false：关闭状态
        /// </summary>
        /// <returns></returns>
        public static bool IsComOpen()
        {
            return sp.IsOpen;
        }


        /// <summary>
        /// 读取串口数据，缓冲区足够bfSize字节读取一次
        /// </summary>
        /// <returns></returns>
        public static bool ReadSP(ref byte[] readData, int bfSize)
        {
            if (sp.BytesToRead >= bfSize)
            {
                sp.Read(readData, 0, bfSize);
                //Console.WriteLine("这是readExisting:" + sp.BytesToRead.ToString() + "\r\n" + readData);
                //sp.DiscardInBuffer();
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool ReadSP(ref byte[] readData, ref string time, int bfSize)
        {
            if (sp.BytesToRead >= bfSize)
            {
                time = DateTime.Now.ToString() + DateTime.Now.Millisecond.ToString();
                sp.Read(readData, 0, bfSize);
                //Console.WriteLine("这是readExisting:" + sp.BytesToRead.ToString() + "\r\n" + readData);
                //sp.DiscardInBuffer();
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 发送串口数据
        /// </summary>
        /// <param name="sendData"></param>
        /// <returns></returns>
        public static bool SendSP(string sendData)
        {
            sp.Write(sendData);
            return true;
        }

        /// <summary>
        /// 清空输入缓存区
        /// </summary>
        public static void ClearInBuffer()
        {
            sp.DiscardInBuffer();
        }
    }
}
