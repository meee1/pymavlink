// MESSAGE RC_CHANNELS_RAW PACKING
using System;
using System.Runtime.InteropServices;

public partial class Mavlink
{

    public const byte MAVLINK_MSG_ID_RC_CHANNELS_RAW = 35;

    [StructLayout(LayoutKind.Sequential,Pack=1)]
    public struct mavlink_rc_channels_raw_t
    {
         public  UInt32 time_boot_ms; /// Timestamp (milliseconds since system boot)
     public  UInt16 chan1_raw; /// RC channel 1 value, in microseconds
     public  UInt16 chan2_raw; /// RC channel 2 value, in microseconds
     public  UInt16 chan3_raw; /// RC channel 3 value, in microseconds
     public  UInt16 chan4_raw; /// RC channel 4 value, in microseconds
     public  UInt16 chan5_raw; /// RC channel 5 value, in microseconds
     public  UInt16 chan6_raw; /// RC channel 6 value, in microseconds
     public  UInt16 chan7_raw; /// RC channel 7 value, in microseconds
     public  UInt16 chan8_raw; /// RC channel 8 value, in microseconds
     public  byte port; /// Servo output port (set of 8 outputs = 1 port). Most MAVs will just use one, but this allows to encode more than 8 servos.
     public  byte rssi; /// Receive signal strength indicator, 0: 0%, 255: 100%
    
    };

/**
 * @brief Pack a rc_channels_raw message
 * @param system_id ID of this system
 * @param component_id ID of this component (e.g. 200 for IMU)
 * @param msg The MAVLink message to compress the data into
 *
 * @param time_boot_ms Timestamp (milliseconds since system boot)
 * @param port Servo output port (set of 8 outputs = 1 port). Most MAVs will just use one, but this allows to encode more than 8 servos.
 * @param chan1_raw RC channel 1 value, in microseconds
 * @param chan2_raw RC channel 2 value, in microseconds
 * @param chan3_raw RC channel 3 value, in microseconds
 * @param chan4_raw RC channel 4 value, in microseconds
 * @param chan5_raw RC channel 5 value, in microseconds
 * @param chan6_raw RC channel 6 value, in microseconds
 * @param chan7_raw RC channel 7 value, in microseconds
 * @param chan8_raw RC channel 8 value, in microseconds
 * @param rssi Receive signal strength indicator, 0: 0%, 255: 100%
 * @return length of the message in bytes (excluding serial stream start sign)
 */
 
public static UInt16 mavlink_msg_rc_channels_raw_pack(byte system_id, byte component_id, byte[] msg,
                               UInt32 time_boot_ms, byte port, UInt16 chan1_raw, UInt16 chan2_raw, UInt16 chan3_raw, UInt16 chan4_raw, UInt16 chan5_raw, UInt16 chan6_raw, UInt16 chan7_raw, UInt16 chan8_raw, byte rssi)
{
if (MAVLINK_NEED_BYTE_SWAP || !MAVLINK_ALIGNED_FIELDS) {
	Array.Copy(BitConverter.GetBytes(time_boot_ms),0,msg,0,sizeof(UInt32));
	Array.Copy(BitConverter.GetBytes(chan1_raw),0,msg,4,sizeof(UInt16));
	Array.Copy(BitConverter.GetBytes(chan2_raw),0,msg,6,sizeof(UInt16));
	Array.Copy(BitConverter.GetBytes(chan3_raw),0,msg,8,sizeof(UInt16));
	Array.Copy(BitConverter.GetBytes(chan4_raw),0,msg,10,sizeof(UInt16));
	Array.Copy(BitConverter.GetBytes(chan5_raw),0,msg,12,sizeof(UInt16));
	Array.Copy(BitConverter.GetBytes(chan6_raw),0,msg,14,sizeof(UInt16));
	Array.Copy(BitConverter.GetBytes(chan7_raw),0,msg,16,sizeof(UInt16));
	Array.Copy(BitConverter.GetBytes(chan8_raw),0,msg,18,sizeof(UInt16));
	Array.Copy(BitConverter.GetBytes(port),0,msg,20,sizeof(byte));
	Array.Copy(BitConverter.GetBytes(rssi),0,msg,21,sizeof(byte));

} else {
    mavlink_rc_channels_raw_t packet = new mavlink_rc_channels_raw_t();
	packet.time_boot_ms = time_boot_ms;
	packet.chan1_raw = chan1_raw;
	packet.chan2_raw = chan2_raw;
	packet.chan3_raw = chan3_raw;
	packet.chan4_raw = chan4_raw;
	packet.chan5_raw = chan5_raw;
	packet.chan6_raw = chan6_raw;
	packet.chan7_raw = chan7_raw;
	packet.chan8_raw = chan8_raw;
	packet.port = port;
	packet.rssi = rssi;

        
        int len = 22;
        msg = new byte[len];
        IntPtr ptr = Marshal.AllocHGlobal(len);
        Marshal.StructureToPtr(packet, ptr, true);
        Marshal.Copy(ptr, msg, 0, len);
        Marshal.FreeHGlobal(ptr);
}

    //msg.msgid = MAVLINK_MSG_ID_RC_CHANNELS_RAW;
    //return mavlink_finalize_message(msg, system_id, component_id, 22, 244);
    return 0;
}

/**
 * @brief Pack a rc_channels_raw message on a channel
 * @param system_id ID of this system
 * @param component_id ID of this component (e.g. 200 for IMU)
 * @param chan The MAVLink channel this message was sent over
 * @param msg The MAVLink message to compress the data into
 * @param time_boot_ms Timestamp (milliseconds since system boot)
 * @param port Servo output port (set of 8 outputs = 1 port). Most MAVs will just use one, but this allows to encode more than 8 servos.
 * @param chan1_raw RC channel 1 value, in microseconds
 * @param chan2_raw RC channel 2 value, in microseconds
 * @param chan3_raw RC channel 3 value, in microseconds
 * @param chan4_raw RC channel 4 value, in microseconds
 * @param chan5_raw RC channel 5 value, in microseconds
 * @param chan6_raw RC channel 6 value, in microseconds
 * @param chan7_raw RC channel 7 value, in microseconds
 * @param chan8_raw RC channel 8 value, in microseconds
 * @param rssi Receive signal strength indicator, 0: 0%, 255: 100%
 * @return length of the message in bytes (excluding serial stream start sign)
 */
 /*
static inline uint16_t mavlink_msg_rc_channels_raw_pack_chan(uint8_t system_id, uint8_t component_id, uint8_t chan,
                               mavlink_message_t* msg,
                                   UInt32 public time_boot_ms,byte public port,UInt16 public chan1_raw,UInt16 public chan2_raw,UInt16 public chan3_raw,UInt16 public chan4_raw,UInt16 public chan5_raw,UInt16 public chan6_raw,UInt16 public chan7_raw,UInt16 public chan8_raw,byte public rssi)
{
#if MAVLINK_NEED_BYTE_SWAP || !MAVLINK_ALIGNED_FIELDS
    char buf[22];
	_mav_put_UInt32(buf, 0, time_boot_ms);
	_mav_put_UInt16(buf, 4, chan1_raw);
	_mav_put_UInt16(buf, 6, chan2_raw);
	_mav_put_UInt16(buf, 8, chan3_raw);
	_mav_put_UInt16(buf, 10, chan4_raw);
	_mav_put_UInt16(buf, 12, chan5_raw);
	_mav_put_UInt16(buf, 14, chan6_raw);
	_mav_put_UInt16(buf, 16, chan7_raw);
	_mav_put_UInt16(buf, 18, chan8_raw);
	_mav_put_byte(buf, 20, port);
	_mav_put_byte(buf, 21, rssi);

        memcpy(_MAV_PAYLOAD(msg), buf, 22);
#else
    mavlink_rc_channels_raw_t packet;
	packet.time_boot_ms = time_boot_ms;
	packet.chan1_raw = chan1_raw;
	packet.chan2_raw = chan2_raw;
	packet.chan3_raw = chan3_raw;
	packet.chan4_raw = chan4_raw;
	packet.chan5_raw = chan5_raw;
	packet.chan6_raw = chan6_raw;
	packet.chan7_raw = chan7_raw;
	packet.chan8_raw = chan8_raw;
	packet.port = port;
	packet.rssi = rssi;

        memcpy(_MAV_PAYLOAD(msg), &packet, 22);
#endif

    msg->msgid = MAVLINK_MSG_ID_RC_CHANNELS_RAW;
    return mavlink_finalize_message_chan(msg, system_id, component_id, chan, 22, 244);
}
*/
/**
 * @brief Encode a rc_channels_raw struct into a message
 *
 * @param system_id ID of this system
 * @param component_id ID of this component (e.g. 200 for IMU)
 * @param msg The MAVLink message to compress the data into
 * @param rc_channels_raw C-struct to read the message contents from
 *//*
static inline uint16_t mavlink_msg_rc_channels_raw_encode(uint8_t system_id, uint8_t component_id, mavlink_message_t* msg, const mavlink_rc_channels_raw_t* rc_channels_raw)
{
    return mavlink_msg_rc_channels_raw_pack(system_id, component_id, msg, rc_channels_raw->time_boot_ms, rc_channels_raw->port, rc_channels_raw->chan1_raw, rc_channels_raw->chan2_raw, rc_channels_raw->chan3_raw, rc_channels_raw->chan4_raw, rc_channels_raw->chan5_raw, rc_channels_raw->chan6_raw, rc_channels_raw->chan7_raw, rc_channels_raw->chan8_raw, rc_channels_raw->rssi);
}
*/
/**
 * @brief Send a rc_channels_raw message
 * @param chan MAVLink channel to send the message
 *
 * @param time_boot_ms Timestamp (milliseconds since system boot)
 * @param port Servo output port (set of 8 outputs = 1 port). Most MAVs will just use one, but this allows to encode more than 8 servos.
 * @param chan1_raw RC channel 1 value, in microseconds
 * @param chan2_raw RC channel 2 value, in microseconds
 * @param chan3_raw RC channel 3 value, in microseconds
 * @param chan4_raw RC channel 4 value, in microseconds
 * @param chan5_raw RC channel 5 value, in microseconds
 * @param chan6_raw RC channel 6 value, in microseconds
 * @param chan7_raw RC channel 7 value, in microseconds
 * @param chan8_raw RC channel 8 value, in microseconds
 * @param rssi Receive signal strength indicator, 0: 0%, 255: 100%
 *//*
#ifdef MAVLINK_USE_CONVENIENCE_FUNCTIONS

static inline void mavlink_msg_rc_channels_raw_send(mavlink_channel_t chan, UInt32 public time_boot_ms, byte public port, UInt16 public chan1_raw, UInt16 public chan2_raw, UInt16 public chan3_raw, UInt16 public chan4_raw, UInt16 public chan5_raw, UInt16 public chan6_raw, UInt16 public chan7_raw, UInt16 public chan8_raw, byte public rssi)
{
#if MAVLINK_NEED_BYTE_SWAP || !MAVLINK_ALIGNED_FIELDS
    char buf[22];
	_mav_put_UInt32(buf, 0, time_boot_ms);
	_mav_put_UInt16(buf, 4, chan1_raw);
	_mav_put_UInt16(buf, 6, chan2_raw);
	_mav_put_UInt16(buf, 8, chan3_raw);
	_mav_put_UInt16(buf, 10, chan4_raw);
	_mav_put_UInt16(buf, 12, chan5_raw);
	_mav_put_UInt16(buf, 14, chan6_raw);
	_mav_put_UInt16(buf, 16, chan7_raw);
	_mav_put_UInt16(buf, 18, chan8_raw);
	_mav_put_byte(buf, 20, port);
	_mav_put_byte(buf, 21, rssi);

    _mav_finalize_message_chan_send(chan, MAVLINK_MSG_ID_RC_CHANNELS_RAW, buf, 22, 244);
#else
    mavlink_rc_channels_raw_t packet;
	packet.time_boot_ms = time_boot_ms;
	packet.chan1_raw = chan1_raw;
	packet.chan2_raw = chan2_raw;
	packet.chan3_raw = chan3_raw;
	packet.chan4_raw = chan4_raw;
	packet.chan5_raw = chan5_raw;
	packet.chan6_raw = chan6_raw;
	packet.chan7_raw = chan7_raw;
	packet.chan8_raw = chan8_raw;
	packet.port = port;
	packet.rssi = rssi;

    _mav_finalize_message_chan_send(chan, MAVLINK_MSG_ID_RC_CHANNELS_RAW, (const char *)&packet, 22, 244);
#endif
}

#endif
*/
// MESSAGE RC_CHANNELS_RAW UNPACKING


/**
 * @brief Get field time_boot_ms from rc_channels_raw message
 *
 * @return Timestamp (milliseconds since system boot)
 */
public static UInt32 mavlink_msg_rc_channels_raw_get_time_boot_ms(byte[] msg)
{
    return BitConverter.ToUInt32(msg,  0);
}

/**
 * @brief Get field port from rc_channels_raw message
 *
 * @return Servo output port (set of 8 outputs = 1 port). Most MAVs will just use one, but this allows to encode more than 8 servos.
 */
public static byte mavlink_msg_rc_channels_raw_get_port(byte[] msg)
{
    return getByte(msg,  20);
}

/**
 * @brief Get field chan1_raw from rc_channels_raw message
 *
 * @return RC channel 1 value, in microseconds
 */
public static UInt16 mavlink_msg_rc_channels_raw_get_chan1_raw(byte[] msg)
{
    return BitConverter.ToUInt16(msg,  4);
}

/**
 * @brief Get field chan2_raw from rc_channels_raw message
 *
 * @return RC channel 2 value, in microseconds
 */
public static UInt16 mavlink_msg_rc_channels_raw_get_chan2_raw(byte[] msg)
{
    return BitConverter.ToUInt16(msg,  6);
}

/**
 * @brief Get field chan3_raw from rc_channels_raw message
 *
 * @return RC channel 3 value, in microseconds
 */
public static UInt16 mavlink_msg_rc_channels_raw_get_chan3_raw(byte[] msg)
{
    return BitConverter.ToUInt16(msg,  8);
}

/**
 * @brief Get field chan4_raw from rc_channels_raw message
 *
 * @return RC channel 4 value, in microseconds
 */
public static UInt16 mavlink_msg_rc_channels_raw_get_chan4_raw(byte[] msg)
{
    return BitConverter.ToUInt16(msg,  10);
}

/**
 * @brief Get field chan5_raw from rc_channels_raw message
 *
 * @return RC channel 5 value, in microseconds
 */
public static UInt16 mavlink_msg_rc_channels_raw_get_chan5_raw(byte[] msg)
{
    return BitConverter.ToUInt16(msg,  12);
}

/**
 * @brief Get field chan6_raw from rc_channels_raw message
 *
 * @return RC channel 6 value, in microseconds
 */
public static UInt16 mavlink_msg_rc_channels_raw_get_chan6_raw(byte[] msg)
{
    return BitConverter.ToUInt16(msg,  14);
}

/**
 * @brief Get field chan7_raw from rc_channels_raw message
 *
 * @return RC channel 7 value, in microseconds
 */
public static UInt16 mavlink_msg_rc_channels_raw_get_chan7_raw(byte[] msg)
{
    return BitConverter.ToUInt16(msg,  16);
}

/**
 * @brief Get field chan8_raw from rc_channels_raw message
 *
 * @return RC channel 8 value, in microseconds
 */
public static UInt16 mavlink_msg_rc_channels_raw_get_chan8_raw(byte[] msg)
{
    return BitConverter.ToUInt16(msg,  18);
}

/**
 * @brief Get field rssi from rc_channels_raw message
 *
 * @return Receive signal strength indicator, 0: 0%, 255: 100%
 */
public static byte mavlink_msg_rc_channels_raw_get_rssi(byte[] msg)
{
    return getByte(msg,  21);
}

/**
 * @brief Decode a rc_channels_raw message into a struct
 *
 * @param msg The message to decode
 * @param rc_channels_raw C-struct to decode the message contents into
 */
public static void mavlink_msg_rc_channels_raw_decode(byte[] msg, ref mavlink_rc_channels_raw_t rc_channels_raw)
{
    if (MAVLINK_NEED_BYTE_SWAP) {
    	rc_channels_raw.time_boot_ms = mavlink_msg_rc_channels_raw_get_time_boot_ms(msg);
    	rc_channels_raw.chan1_raw = mavlink_msg_rc_channels_raw_get_chan1_raw(msg);
    	rc_channels_raw.chan2_raw = mavlink_msg_rc_channels_raw_get_chan2_raw(msg);
    	rc_channels_raw.chan3_raw = mavlink_msg_rc_channels_raw_get_chan3_raw(msg);
    	rc_channels_raw.chan4_raw = mavlink_msg_rc_channels_raw_get_chan4_raw(msg);
    	rc_channels_raw.chan5_raw = mavlink_msg_rc_channels_raw_get_chan5_raw(msg);
    	rc_channels_raw.chan6_raw = mavlink_msg_rc_channels_raw_get_chan6_raw(msg);
    	rc_channels_raw.chan7_raw = mavlink_msg_rc_channels_raw_get_chan7_raw(msg);
    	rc_channels_raw.chan8_raw = mavlink_msg_rc_channels_raw_get_chan8_raw(msg);
    	rc_channels_raw.port = mavlink_msg_rc_channels_raw_get_port(msg);
    	rc_channels_raw.rssi = mavlink_msg_rc_channels_raw_get_rssi(msg);
    
    } else {
        int len = 22; //Marshal.SizeOf(rc_channels_raw);
        IntPtr i = Marshal.AllocHGlobal(len);
        Marshal.Copy(msg, 0, i, len);
        rc_channels_raw = (mavlink_rc_channels_raw_t)Marshal.PtrToStructure(i, ((object)rc_channels_raw).GetType());
        Marshal.FreeHGlobal(i);
    }
}

}
