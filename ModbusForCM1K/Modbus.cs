using System;

public class Modbus
{
    public const uint SIZE_RX_BUFFER = 254;
    public const uint SIZE_TX_BUFFER = 254;
    public const uint SIZE_TX_FRAME = 6;
    public const uint SIZE_RX_FRAME = 5;
    // Коды команд 
    public const byte READ_REGISTER   = 0x03;
    public const byte WRITE_REGISTER  = 0x06;
    public const byte WRITE_REGISTERS = 0x10;
    // Старший байт номера регистра определяет группу параметров
    public const byte CLOCK_REGISTER_MASK   = 0x01;
    public const byte CM1K_REGISTER_MASK    = 0x00;
    public const byte PARAM_REGISTER_MASK   = 0x02;
    // Адрес устройства
    public const byte NODE_ADDRESS = 0x01;
    // Адреса регистров
    public const uint CONTROL_COMMAND_ADDRESS   = 0x1000;
    public const uint INVERTER_STATE_ADDRESS    = 0x1001;

    // Адреса часовых регистров 

    public const byte CLOCK_FIRST_ADDRESS   = 0x00;
    public const byte CLOCK_SECOND_ADDRESS  = 0x00;
    public const byte CLOCK_MINUTE_ADDRESS  = 0x01;
    public const byte CLOCK_HUOR_ADDRESS    = 0x02;
    public const byte CLOCK_DAY_ADDRESS     = 0x03;
    public const byte CLOCK_DATE_ADDRESS    = 0x04;
    public const byte CLOCK_MONTH_ADDRESS   = 0x05;
    public const byte CLOCK_YEAR_ADDRESS    = 0x06;

    public static uint CRC16(byte[] frame, uint data_length)
	{
        uint i, x;
        uint crc_value = 0xFFFF;

        for (i = 0; i < data_length; i++)
        {
            crc_value ^= frame[i];
            for (x = 0; x < 8; x++ )
            {
                if ((crc_value & 0x0001) > 0)
                {
                    crc_value = (crc_value >> 1) ^ (0xA001);
                }
                else
                {
                    crc_value = (crc_value >> 1);
                }
            }
        }
        return crc_value;
	}

    public static byte ConvertDateTimeToBCD(byte value)
    {
        byte low = 0, high = 0, result = 0;

        high = (byte)(value / 10);
        low = (byte)(value - (high * 10));
        high = (byte)(high << 4);
        result = (byte)(high | low);
        return result;
    }

}
