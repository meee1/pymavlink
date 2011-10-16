// MESSAGE WATCHDOG_PROCESS_STATUS PACKING
using System;
using System.Runtime.InteropServices;

public partial class Mavlink
{

    public const byte MAVLINK_MSG_ID_WATCHDOG_PROCESS_STATUS = 182;

    [StructLayout(LayoutKind.Sequential,Pack=1)]
    public struct mavlink_watchdog_process_status_t
    {
         public  Int32 pid; /// PID
     public  UInt16 watchdog_id; /// Watchdog ID
     public  UInt16 process_id; /// Process ID
     public  UInt16 crashes; /// Number of crashes
     public  byte state; /// Is running / finished / suspended / crashed
     public  byte muted; /// Is muted
    
    };

/**
 * @brief Pack a watchdog_process_status message
 * @param system_id ID of this system
 * @param component_id ID of this component (e.g. 200 for IMU)
 * @param msg The MAVLink message to compress the data into
 *
 * @param watchdog_id Watchdog ID
 * @param process_id Process ID
 * @param state Is running / finished / suspended / crashed
 * @param muted Is muted
 * @param pid PID
 * @param crashes Number of crashes
 * @return length of the message in bytes (excluding serial stream start sign)
 */
 /*
static uint16 mavlink_msg_watchdog_process_status_pack(byte system_id, byte component_id, ref byte[] msg,
                               UInt16 public watchdog_id, UInt16 public process_id, byte public state, byte public muted, Int32 public pid, UInt16 public crashes)
{
#if MAVLINK_NEED_BYTE_SWAP || !MAVLINK_ALIGNED_FIELDS
    byte buf[12];
	_mav_put_Int32(buf, 0, pid);
	_mav_put_UInt16(buf, 4, watchdog_id);
	_mav_put_UInt16(buf, 6, process_id);
	_mav_put_UInt16(buf, 8, crashes);
	_mav_put_byte(buf, 10, state);
	_mav_put_byte(buf, 11, muted);

        memcpy(_MAV_PAYLOAD(msg), buf, 12);
#else
    mavlink_watchdog_process_status_t packet;
	packet.pid = pid;
	packet.watchdog_id = watchdog_id;
	packet.process_id = process_id;
	packet.crashes = crashes;
	packet.state = state;
	packet.muted = muted;

        memcpy(_MAV_PAYLOAD(msg), &packet, 12);
#endif

    msg->msgid = MAVLINK_MSG_ID_WATCHDOG_PROCESS_STATUS;
    return mavlink_finalize_message(msg, system_id, component_id, 12, 29);
}
*/
/**
 * @brief Pack a watchdog_process_status message on a channel
 * @param system_id ID of this system
 * @param component_id ID of this component (e.g. 200 for IMU)
 * @param chan The MAVLink channel this message was sent over
 * @param msg The MAVLink message to compress the data into
 * @param watchdog_id Watchdog ID
 * @param process_id Process ID
 * @param state Is running / finished / suspended / crashed
 * @param muted Is muted
 * @param pid PID
 * @param crashes Number of crashes
 * @return length of the message in bytes (excluding serial stream start sign)
 */
 /*
static inline uint16_t mavlink_msg_watchdog_process_status_pack_chan(uint8_t system_id, uint8_t component_id, uint8_t chan,
                               mavlink_message_t* msg,
                                   UInt16 public watchdog_id,UInt16 public process_id,byte public state,byte public muted,Int32 public pid,UInt16 public crashes)
{
#if MAVLINK_NEED_BYTE_SWAP || !MAVLINK_ALIGNED_FIELDS
    char buf[12];
	_mav_put_Int32(buf, 0, pid);
	_mav_put_UInt16(buf, 4, watchdog_id);
	_mav_put_UInt16(buf, 6, process_id);
	_mav_put_UInt16(buf, 8, crashes);
	_mav_put_byte(buf, 10, state);
	_mav_put_byte(buf, 11, muted);

        memcpy(_MAV_PAYLOAD(msg), buf, 12);
#else
    mavlink_watchdog_process_status_t packet;
	packet.pid = pid;
	packet.watchdog_id = watchdog_id;
	packet.process_id = process_id;
	packet.crashes = crashes;
	packet.state = state;
	packet.muted = muted;

        memcpy(_MAV_PAYLOAD(msg), &packet, 12);
#endif

    msg->msgid = MAVLINK_MSG_ID_WATCHDOG_PROCESS_STATUS;
    return mavlink_finalize_message_chan(msg, system_id, component_id, chan, 12, 29);
}
*/
/**
 * @brief Encode a watchdog_process_status struct into a message
 *
 * @param system_id ID of this system
 * @param component_id ID of this component (e.g. 200 for IMU)
 * @param msg The MAVLink message to compress the data into
 * @param watchdog_process_status C-struct to read the message contents from
 *//*
static inline uint16_t mavlink_msg_watchdog_process_status_encode(uint8_t system_id, uint8_t component_id, mavlink_message_t* msg, const mavlink_watchdog_process_status_t* watchdog_process_status)
{
    return mavlink_msg_watchdog_process_status_pack(system_id, component_id, msg, watchdog_process_status->watchdog_id, watchdog_process_status->process_id, watchdog_process_status->state, watchdog_process_status->muted, watchdog_process_status->pid, watchdog_process_status->crashes);
}
*/
/**
 * @brief Send a watchdog_process_status message
 * @param chan MAVLink channel to send the message
 *
 * @param watchdog_id Watchdog ID
 * @param process_id Process ID
 * @param state Is running / finished / suspended / crashed
 * @param muted Is muted
 * @param pid PID
 * @param crashes Number of crashes
 *//*
#ifdef MAVLINK_USE_CONVENIENCE_FUNCTIONS

static inline void mavlink_msg_watchdog_process_status_send(mavlink_channel_t chan, UInt16 public watchdog_id, UInt16 public process_id, byte public state, byte public muted, Int32 public pid, UInt16 public crashes)
{
#if MAVLINK_NEED_BYTE_SWAP || !MAVLINK_ALIGNED_FIELDS
    char buf[12];
	_mav_put_Int32(buf, 0, pid);
	_mav_put_UInt16(buf, 4, watchdog_id);
	_mav_put_UInt16(buf, 6, process_id);
	_mav_put_UInt16(buf, 8, crashes);
	_mav_put_byte(buf, 10, state);
	_mav_put_byte(buf, 11, muted);

    _mav_finalize_message_chan_send(chan, MAVLINK_MSG_ID_WATCHDOG_PROCESS_STATUS, buf, 12, 29);
#else
    mavlink_watchdog_process_status_t packet;
	packet.pid = pid;
	packet.watchdog_id = watchdog_id;
	packet.process_id = process_id;
	packet.crashes = crashes;
	packet.state = state;
	packet.muted = muted;

    _mav_finalize_message_chan_send(chan, MAVLINK_MSG_ID_WATCHDOG_PROCESS_STATUS, (const char *)&packet, 12, 29);
#endif
}

#endif
*/
// MESSAGE WATCHDOG_PROCESS_STATUS UNPACKING


/**
 * @brief Get field watchdog_id from watchdog_process_status message
 *
 * @return Watchdog ID
 */
public static UInt16 mavlink_msg_watchdog_process_status_get_watchdog_id(byte[] msg)
{
    return BitConverter.ToUInt16(msg,  4);
}

/**
 * @brief Get field process_id from watchdog_process_status message
 *
 * @return Process ID
 */
public static UInt16 mavlink_msg_watchdog_process_status_get_process_id(byte[] msg)
{
    return BitConverter.ToUInt16(msg,  6);
}

/**
 * @brief Get field state from watchdog_process_status message
 *
 * @return Is running / finished / suspended / crashed
 */
public static byte mavlink_msg_watchdog_process_status_get_state(byte[] msg)
{
    return getByte(msg,  10);
}

/**
 * @brief Get field muted from watchdog_process_status message
 *
 * @return Is muted
 */
public static byte mavlink_msg_watchdog_process_status_get_muted(byte[] msg)
{
    return getByte(msg,  11);
}

/**
 * @brief Get field pid from watchdog_process_status message
 *
 * @return PID
 */
public static Int32 mavlink_msg_watchdog_process_status_get_pid(byte[] msg)
{
    return BitConverter.ToInt32(msg,  0);
}

/**
 * @brief Get field crashes from watchdog_process_status message
 *
 * @return Number of crashes
 */
public static UInt16 mavlink_msg_watchdog_process_status_get_crashes(byte[] msg)
{
    return BitConverter.ToUInt16(msg,  8);
}

/**
 * @brief Decode a watchdog_process_status message into a struct
 *
 * @param msg The message to decode
 * @param watchdog_process_status C-struct to decode the message contents into
 */
public static void mavlink_msg_watchdog_process_status_decode(byte[] msg, ref mavlink_watchdog_process_status_t watchdog_process_status)
{
if (MAVLINK_NEED_BYTE_SWAP) {
	watchdog_process_status.pid = mavlink_msg_watchdog_process_status_get_pid(msg);
	watchdog_process_status.watchdog_id = mavlink_msg_watchdog_process_status_get_watchdog_id(msg);
	watchdog_process_status.process_id = mavlink_msg_watchdog_process_status_get_process_id(msg);
	watchdog_process_status.crashes = mavlink_msg_watchdog_process_status_get_crashes(msg);
	watchdog_process_status.state = mavlink_msg_watchdog_process_status_get_state(msg);
	watchdog_process_status.muted = mavlink_msg_watchdog_process_status_get_muted(msg);
} else {
    int len = 12; //Marshal.SizeOf(watchdog_process_status);
    IntPtr i = Marshal.AllocHGlobal(len);
    Marshal.Copy(msg, 0, i, len);
    watchdog_process_status = (mavlink_watchdog_process_status_t)Marshal.PtrToStructure(i, ((object)watchdog_process_status).GetType());
    Marshal.FreeHGlobal(i);
}
}

}
