using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Communicate.Modbus
{
    /// <summary>
    /// 串行端口
    /// </summary>
    public class SerialPortBase : ModbusBase
    {
        SerialPort serialPort = null;//串口对象
        /// <summary>
        /// 构造函数实例化serialPort
        /// </summary>
        /// <param name="portName">串口名称</param>
        /// <param name="baudRate">波特率</param>
        /// <param name="dataBits">数据位</param>
        /// <param name="stopBits">停止位</param>
        /// <param name="parity">校验位</param>
        public SerialPortBase(string portName, int baudRate, int dataBits, StopBits stopBits, Parity parity)
        {
            if (serialPort == null)
                serialPort = new SerialPort();
            serialPort.PortName = portName;
            serialPort.BaudRate = baudRate;
            serialPort.DataBits = dataBits;
            serialPort.StopBits = stopBits;
            serialPort.Parity = parity;
        }
        /// <summary>
        /// 打开连接
        /// </summary>
        /// <returns></returns>
        public override bool Open()
        {
            try
            {
                serialPort.Open();
                return true;
            }
            catch (Exception e)
            {
                throw new Exception("打开连接失败",e);
            }
        }
        /// <summary>
        ///关闭连接
        /// </summary>
        public override void Close()
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
            }
        }
        /// <summary>
        /// 发送报文并返回响应报文
        /// </summary>
        /// <param name="command"></param>
        /// <param name="len"></param>
        /// <returns>返回响应报文</returns>
        public override async Task<List<byte>> Send(List<byte> command, int len)
        {
            serialPort.Write(command.ToArray(),0,command.Count);
            //等待0.1秒
            await Task.Delay(100);
            //延时处理
            if(serialPort.BytesToRead == 0)
                await Task.Delay(20);
            if (serialPort.BytesToRead == 0)
                await Task.Delay(40);
            if (serialPort.BytesToRead == 0)
                await Task.Delay(80);
            if (serialPort.BytesToRead == 0)
                return new List<byte>();
            //读取串口数据
            byte[] buffer = new byte[serialPort.BytesToRead];
            serialPort.Read(buffer, 0, buffer.Length);
            serialPort.DiscardInBuffer();
            return new List<byte>(buffer);
        }


    }
}
