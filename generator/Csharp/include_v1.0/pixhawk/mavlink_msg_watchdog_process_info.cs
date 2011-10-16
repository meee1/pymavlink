// MESSAGE WATCHDOG_PROCESS_INFO PACKING
using System;
using System.Runtime.InteropServices;

public partial class Mavlink
{

    public const byte MAVLINK_MSG_ID_WATCHDOG_PROCESS_INFO = 181;

    [StructLayout(LayoutKind.Sequential,Pack=1)]
    public struct mavlink_watchdog_process_info_t
    {
         public  Int32 timeout; /// Timeout (seconds)
     public  UInt16 watchdog_id; /// Watchdog ID
     public  UInt16 process_id; /// Process ID
     [MarshalAs(UnmanagedType.ByValArray,SizeConst=100)]
 public string name; /// Process name
     [MarshalAs(UnmanagedType.ByValArray,SizeConst=147)]
 public string arguments; /// Process arguments
    
    };

/**
 * @brief Pack a watchdog_process_info message
 * @param system_id ID of this system
 * @param component_id ID of this component (e.g. 200 for IMU)
 * @param msg The MAVLink message to compress the data into
 *
 * @param watchdog_id Watchdog ID
 * @param process_id Process ID
 * @param name Process name
 * @param arguments Process arguments
 * @param timeout Timeout (seconds)
 * @return length of the message in bytes (excluding serial stream start sign)
 */
 /*
static uint16 mavlink_msg_watchdog_process_info_pack(byte system_id, byte component_id, ref byte[] msg,
                               UInt16 public watchdog_id, UInt16 public process_id, const string [MarshalAs(UnmanagedType.ByValArray,SizeConst=100)]
 publicname, const string [MarshalAs(UnmanagedType.ByValArray,SizeConst=147)]
 publicarguments, Int32 public timeout)
{
#if MAVLINK_NEED_BYTE_SWAP || !MAVLINK_ALIGNED_FIELDS
    byte buf[255];
	_mav_put_Int32(buf, 0, timeout);
	_mav_put_UInt16(buf, 4, watchdog_id);
	_mav_put_UInt16(buf, 6, process_id);
	_mav_put_string_array(buf, 8, name, 100);
	_mav_put_string_array(buf, 108, arguments, 147);
        memcpy(_MAV_PAYLOAD(msg), buf, 255);
#else
    mavlink_watchdog_process_info_t packet;
	packet.timeout = timeout;
	packet.watchdog_id = watchdog_id;
	packet.process_id = process_id;
	memcpy(packet.name, name, sizeof(string)*100);
	memcpy(packet.arguments, arguments, sizeof(string)*147);
        memcpy(_MAV_PAYLOAD(msg), &packet, 255);
#endif

    msg->msgid = MAVLINK_MSG_ID_WATCHDOG_PROCESS_INFO;
    return mavlink_finalize_message(msg, system_id, component_id, 255, 16);
}
*/
/**
 * @brief Pack a watchdog_process_info message on a channel
 * @param system_id ID of this system
 * @param component_id ID of this component (e.g. 200 for IMU)
 * @param chan The MAVLink channel this message was sent over
 * @param msg The MAVLink message to compress the data into
 * @param watchdog_id Watchdog ID
 * @param process_id Process ID
 * @param name Process name
 * @param arguments Process arguments
 * @param timeout Timeout (seconds)
 * @return length of the message in bytes (excluding serial stream start sign)
 */
 /*
static inline uint16_t mavlink_msg_watchdog_process_info_pack_chan(uint8_t system_id, uint8_t component_id, uint8_t chan,
                               mavlink_message_t* msg,
                                   UInt16 public watchdog_id,UInt16 public process_id,const string [MarshalAs(UnmanagedType.ByValArray,SizeConst=100)]
 publicname,const string [MarshalAs(UnmanagedType.ByValArray,SizeConst=147)]
 publicarguments,Int32 public timeout)
{
#if MAVLINK_NEED_BYTE_SWAP || !MAVLINK_ALIGNED_FIELDS
    char buf[255];
	_mav_put_Int32(buf, 0, timeout);
	_mav_put_UInt16(buf, 4, watchdog_id);
	_mav_put_UInt16(buf, 6, process_id);
	_mav_put_string_array(buf, 8, name, 100);
	_mav_put_string_array(buf, 108, arguments, 147);
        memcpy(_MAV_PAYLOAD(msg), buf, 255);
#else
    mavlink_watchdog_process_info_t packet;
	packet.timeout = timeout;
	packet.watchdog_id = watchdog_id;
	packet.process_id = process_id;
	memcpy(packet.name, name, sizeof(string)*100);
	memcpy(packet.arguments, arguments, sizeof(string)*147);
        memcpy(_MAV_PAYLOAD(msg), &packet, 255);
#endif

    msg->msgid = MAVLINK_MSG_ID_WATCHDOG_PROCESS_INFO;
    return mavlink_finalize_message_chan(msg, system_id, component_id, chan, 255, 16);
}
*/
/**
 * @brief Encode a watchdog_process_info struct into a message
 *
 * @param system_id ID of this system
 * @param component_id ID of this component (e.g. 200 for IMU)
 * @param msg The MAVLink message to compress the data into
 * @param watchdog_process_info C-struct to read the message contents from
 *//*
static inline uint16_t mavlink_msg_watchdog_process_info_encode(uint8_t system_id, uint8_t component_id, mavlink_message_t* msg, const mavlink_watchdog_process_info_t* watchdog_process_info)
{
    return mavlink_msg_watchdog_process_info_pack(system_id, component_id, msg, watchdog_process_info->watchdog_id, watchdog_process_info->process_id, watchdog_process_info->name, watchdog_process_info->arguments, watchdog_process_info->timeout);
}
*/
/**
 * @brief Send a watchdog_process_info message
 * @param chan MAVLink channel to send the message
 *
 * @param watchdog_id Watchdog ID
 * @param process_id Process ID
 * @param name Process name
 * @param arguments Process arguments
 * @param timeout Timeout (seconds)
 *//*
#ifdef MAVLINK_USE_CONVENIENCE_FUNCTIONS

static inline void mavlink_msg_watchdog_process_info_send(mavlink_channel_t chan, UInt16 public watchdog_id, UInt16 public process_id, const string [MarshalAs(UnmanagedType.ByValArray,SizeConst=100)]
 publicname, const string [MarshalAs(UnmanagedType.ByValArray,SizeConst=147)]
 publicarguments, Int32 public timeout)
{
#if MAVLINK_NEED_BYTE_SWAP || !MAVLINK_ALIGNED_FIELDS
    char buf[255];
	_mav_put_Int32(buf, 0, timeout);
	_mav_put_UInt16(buf, 4, watchdog_id);
	_mav_put_UInt16(buf, 6, process_id);
	_mav_put_string_array(buf, 8, name, 100);
	_mav_put_string_array(buf, 108, arguments, 147);
    _mav_finalize_message_chan_send(chan, MAVLINK_MSG_ID_WATCHDOG_PROCESS_INFO, buf, 255, 16);
#else
    mavlink_watchdog_process_info_t packet;
	packet.timeout = timeout;
	packet.watchdog_id = watchdog_id;
	packet.process_id = process_id;
	memcpy(packet.name, name, sizeof(string)*100);
	memcpy(packet.arguments, arguments, sizeof(string)*147);
    _mav_finalize_message_chan_send(chan, MAVLINK_MSG_ID_WATCHDOG_PROCESS_INFO, (const char *)&packet, 255, 16);
#endif
}

#endif
*/
// MESSAGE WATCHDOG_PROCESS_INFO UNPACKING


/**
 * @brief Get field watchdog_id from watchdog_process_info message
 *
 * @return Watchdog ID
 */
public static UInt16 mavlink_msg_watchdog_process_info_get_watchdog_id(byte[] msg)
{
    return BitConverter.ToUInt16(msg,  4);
}

/**
 * @brief Get field process_id from watchdog_process_info message
 *
 * @return Process ID
 */
public static UInt16 mavlink_msg_watchdog_process_info_get_process_id(byte[] msg)
{
    return BitConverter.ToUInt16(msg,  6);
}

/**
 * @brief Get field name from watchdog_process_info message
 *
 * @return Process name
 */
public static string mavlink_msg_watchdog_process_info_get_name(byte[] msg)
{
    return System.Text.ASCIIEncoding.ASCII.GetString(msg,8,100); //(msg, 100,  8);
}

/**
 * @brief Get field arguments from watchdog_process_info message
 *
 * @return Process arguments
 */
public static string mavlink_msg_watchdog_process_info_get_arguments(byte[] msg)
{
    return System.Text.ASCIIEncoding.ASCII.GetString(msg,108,147); //(msg, 147,  108);
}

/**
 * @brief Get field timeout from watchdog_process_info message
 *
 * @return Timeout (seconds)
 */
public static Int32 mavlink_msg_watchdog_process_info_get_timeout(byte[] msg)
{
    return BitConverter.ToInt32(msg,  0);
}

/**
 * @brief Decode a watchdog_process_info message into a struct
 *
 * @param msg The message to decode
 * @param watchdog_process_info C-struct to decode the message contents into
 */
public static void mavlink_msg_watchdog_process_info_decode(byte[] msg, ref mavlink_watchdog_process_info_t watchdog_process_info)
{
if (MAVLINK_NEED_BYTE_SWAP) {
	watchdog_process_info.timeout = mavlink_msg_watchdog_process_info_get_timeout(msg);
	watchdog_process_info.watchdog_id = mavlink_msg_watchdog_process_info_get_watchdog_id(msg);
	watchdog_process_info.process_id = mavlink_msg_watchdog_process_info_get_process_id(msg);
	watchdog_process_info.name = mavlink_msg_watchdog_process_info_get_name(msg);
	watchdog_process_info.arguments = mavlink_msg_watchdog_process_info_get_arguments(msg);
} else {
    int len = 255; //Marshal.SizeOf(watchdog_process_info);
    IntPtr i = Marshal.AllocHGlobal(len);
    Marshal.Copy(msg, 0, i, len);
    watchdog_process_info = (mavlink_watchdog_process_info_t)Marshal.PtrToStructure(i, ((object)watchdog_process_info).GetType());
    Marshal.FreeHGlobal(i);
}
}

}
