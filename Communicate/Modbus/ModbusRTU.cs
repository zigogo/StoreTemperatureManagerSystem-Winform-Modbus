using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Communicate.Modbus
{
    public class ModbusRTU : SerialPortBase
    {
        /// <summary>
        /// 构造函数实例化serialPort
        /// </summary>
        /// <param name="portName">串口名称</param>
        /// <param name="baudRate">波特率</param>
        /// <param name="dataBits">数据位</param>
        /// <param name="stopBits">停止位</param>
        /// <param name="parity">校验位</param>
        public ModbusRTU(string portName, int baudRate, int dataBits, StopBits stopBits, Parity parity) : 
            base(portName, baudRate, dataBits, stopBits, parity)
        {
        }

        public override async Task<List<ushort>> ReadUInt16(byte startAddress, byte slaveAddress = 1, byte funcCode = 3, ushort len = 1)
        {
            //拼装请求报文 01 03 00 00 00 0A
            List<byte> readCommand = this.GetReadCommandBytes(startAddress, slaveAddress, funcCode,len);
            //添加一个CRC校验码
            readCommand = CRC16(readCommand);
            //Send()发送报文并返回响应报文
            List<byte> responseMessage = await this.Send(readCommand, len);
            //校验响应报文.........
            //.........
            //处理响应报文
            if (responseMessage.Count > 0)
            {
                //剔除地址和功能码
                responseMessage.RemoveRange(0, 3);
                //剔除CRC校验码
                responseMessage.RemoveRange(responseMessage.Count-2, 2);
                //将数据部分转化为List<ushort>返回
                return this.ReadUint16(responseMessage);
            }
            return null;
        }

        /// <summary>
        /// 写单寄存器
        /// </summary>
        /// <param name="startAddress">起始地址</param>
        /// <param name="value">需要写入的值</param>
        /// <param name="slaveAddress">从站地址</param>
        /// <param name="funcCode">功能码：06写单寄存器</param>
        /// <returns></returns>
        public override async Task<bool> WriteUInt16(int startAddress, ushort value, byte slaveAddress = 1, byte funcCode = 6)
        {
            //拼装写入报文 01 06 XX(起始地址) XX(写入的值) XX XX(校验码)
            List<byte> writeCommand = this.GetWriteCommandBytes(startAddress, slaveAddress, funcCode, value);
            //添加一个CRC校验码
            writeCommand = CRC16(writeCommand);
            //Send()发送报文并返回响应报文
            List<byte> responseMessage = await this.Send(writeCommand, 0);
            if(responseMessage.Count == writeCommand.Count)
                return true;
            else
                return false;
        }


        /// <summary>
        /// CRC16校验码(给报文加上CRC校验码
        /// </summary>
        /// <param name="readCommand"></param>
        /// <param name="poly"></param>
        /// <param name="crcInit"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        private List<byte> CRC16(List<byte> readCommand,ushort poly = 0xA001, ushort crcInit = 0xFFFF)
        {
            if (readCommand == null || !readCommand.Any())
                throw new ArgumentException("");

            //运算
            ushort crc = crcInit;
            for (int i = 0; i < readCommand.Count; i++)
            {
                crc = (ushort)(crc ^ (readCommand[i]));
                for (int j = 0; j < 8; j++)
                {
                    crc = (crc & 1) != 0 ? (ushort)((crc >> 1) ^ poly) : (ushort)(crc >> 1);
                }
            }
            byte hi = (byte)((crc & 0xFF00) >> 8);  //高位置
            byte lo = (byte)(crc & 0x00FF);         //低位置

            List<byte> buffer = new List<byte>();
            buffer.AddRange(readCommand);
            buffer.Add(lo);
            buffer.Add(hi);
            return buffer;
        }
    }
}
