using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //byte to uint16 输入顺序需注意为低位在前
            //byte x1 = Convert.ToByte(255), x2 = Convert.ToByte(0), x3 = Convert.ToByte(0), x4 = Convert.ToByte(255);
            //byte[] bt = { 255, 0, 0, 255 };
            //UInt16 a = BitConverter.ToUInt16(bt, 0);
            //UInt16 b = BitConverter.ToUInt16(bt, 2);
            //Console.WriteLine(byte.MaxValue.ToString(), byte.MinValue.ToString());
            //Console.WriteLine("touint16:{0}" ,a);
            //Console.WriteLine("touint16:{0}", b);

            //另一种方法
            //byte bb = 255, cc = 255;
            //int bb1 = bb * 256;
            //Console.WriteLine("touint16:{0}", bb1);
            //bb1 += cc;
            //Console.WriteLine("touint16:{0}", bb1);

            //string to uint16
            //string str = "0xff01";
            //UInt16 stra;
            //stra = Convert.ToUInt16(str, 16);
            //Console.WriteLine("touint16:{0}", stra);
            //str = "65535";
            //stra = Convert.ToUInt16(str);
            //Console.WriteLine("touint16:{0}", stra);
            //uint16 to byte 输出顺序为低位在前
            //byte[] bt = BitConverter.GetBytes(stra);
            //Console.WriteLine("uint16tobyte:{0}", bt[0].ToString());
            //Console.WriteLine("uint16tobyte:{0}", bt[1].ToString());

            //随机数
            //UInt16 mid = 30000, range = 100;
            //Random r = new Random();
            //UInt16 s = (UInt16)r.Next(mid - range / 2, mid + range / 2);
            //Console.WriteLine(s.ToString());

            //将百微秒转为H:M:S:MS:US形式
            //uint ms = 42326548;
            ////Console.WriteLine("ms: " + ms.ToString());
            ////string msstr = ms.ToString();
            ////ms = Convert.ToSingle(msstr);
            //Console.WriteLine("ms: " + ms.ToString());
            //Console.WriteLine(DateTime.Now.ToString() + "." + DateTime.Now.Millisecond.ToString());
            //uint hour = Convert.ToUInt32( ms / 36000000 );
            //uint min = Convert.ToUInt32((ms % 36000000) / 600000);
            //uint sec = Convert.ToUInt32(((ms % 36000000) % 600000) / 10000);
            //uint msec = Convert.ToUInt32(((ms % 36000000) % 600000) % 10000 / 10);
            //uint usec = Convert.ToUInt32(((ms % 36000000) % 600000) % 10000 % 10);
            //Console.WriteLine("hour: " + hour.ToString() + 
            //    " min: " + min.ToString() + 
            //    " sec: " + sec.ToString() + 
            //    " msec: " + msec.ToString() + 
            //    " usec: " + (usec*100).ToString());
            //Console.WriteLine(DateTime.Now.ToString() + "." + DateTime.Now.Millisecond.ToString());

            //uint16 to hex
            UInt16[] n = new ushort[4] { 12, 11, 10, 9 };
            Console.WriteLine(n[0].ToString("X4"));
            
        }
    }
}
