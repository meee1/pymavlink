// MESSAGE SET_MODE PACKING
using System;
using System.Runtime.InteropServices;

public partial class Mavlink
{

    public const byte MAVLINK_MSG_ID_SET_MODE = 11;

    [StructLayout(LayoutKind.Sequential,Pack=1)]
    public struct mavlink_set_mode_t
    {
         public  UInt16 custom_mode; /// The new autopilot-specific mode. This field can be ignored by an autopilot.
     public  byte target_system; /// The system setting the mode
     public  byte base_mode; /// The new base mode
    
    };

/**
 * @brief Pack a set_mode message
 * @param system_id ID of this system
 * @param component_id ID of this component (e.g. 200 for IMU)
 * @param msg The MAVLink message to compress the data into
 *
 * @param target_system The system setting the mode
 * @param base_mode The new base mode
 * @param custom_mode The new autopilot-specific mode. This field can be ignored by an autopilot.
 * @return length of the message in bytes (excluding serial stream start sign)
 */
 
public static UInt16 mavlink_msg_set_mode_pack(byte system_id, byte component_id, byte[] msg,
                               byte target_system, byte base_mode, UInt16 custom_mode)
{
if (MAVLINK_NEED_BYTE_SWAP || !MAVLINK_ALIGNED_FIELDS) {
	Array.Copy(BitConverter.GetBytes(custom_mode),0,msg,0,sizeof(UInt16));
	Array.Copy(BitConverter.GetBytes(target_system),0,msg,2,sizeof(byte));
	Array.Copy(BitConverter.GetBytes(base_mode),0,msg,3,sizeof(byte));

} else {
    mavlink_set_mode_t packet = new mavlink_set_mode_t();
	packet.custom_mode = custom_mode;
	packet.target_system = target_system;
	packet.base_mode = base_mode;

        
        int len = 4;
        msg = new byte[len];
        IntPtr ptr = Marshal.AllocHGlobal(len);
        Marshal.StructureToPtr(packet, ptr, true);
        Marshal.Copy(ptr, msg, 0, len);
        Marshal.FreeHGlobal(ptr);
}

    //msg.msgid = MAVLINK_MSG_ID_SET_MODE;
    //return mavlink_finalize_message(msg, system_id, component_id, 4, 197);
    return 0;
}

/**
 * @brief Pack a set_mode message on a channel
 * @param system_id ID of this system
 * @param component_id ID of this component (e.g. 200 for IMU)
 * @param chan The MAVLink channel this message was sent over
 * @param msg The MAVLink message to compress the data into
 * @param target_system The system setting the mode
 * @param base_mode The new base mode
 * @param custom_mode The new autopilot-specific mode. This field can be ignored by an autopilot.
 * @return length of the message in bytes (excluding serial stream start sign)
 */
 /*
static inline uint16_t mavlink_msg_set_mode_pack_chan(uint8_t system_id, uint8_t component_id, uint8_t chan,
                               mavlink_message_t* msg,
                                   byte public target_system,byte public base_mode,UInt16 public custom_mode)
{
#if MAVLINK_NEED_BYTE_SWAP || !MAVLINK_ALIGNED_FIELDS
    char buf[4];
	_mav_put_UInt16(buf, 0, custom_mode);
	_mav_put_byte(buf, 2, target_system);
	_mav_put_byte(buf, 3, base_mode);

        memcpy(_MAV_PAYLOAD(msg), buf, 4);
#else
    mavlink_set_mode_t packet;
	packet.custom_mode = custom_mode;
	packet.target_system = target_system;
	packet.base_mode = base_mode;

        memcpy(_MAV_PAYLOAD(msg), &packet, 4);
#endif

    msg->msgid = MAVLINK_MSG_ID_SET_MODE;
    return mavlink_finalize_message_chan(msg, system_id, component_id, chan, 4, 197);
}
*/
/**
 * @brief Encode a set_mode struct into a message
 *
 * @param system_id ID of this system
 * @param component_id ID of this component (e.g. 200 for IMU)
 * @param msg The MAVLink message to compress the data into
 * @param set_mode C-struct to read the message contents from
 *//*
static inline uint16_t mavlink_msg_set_mode_encode(uint8_t system_id, uint8_t component_id, mavlink_message_t* msg, const mavlink_set_mode_t* set_mode)
{
    return mavlink_msg_set_mode_pack(system_id, component_id, msg, set_mode->target_system, set_mode->base_mode, set_mode->custom_mode);
}
*/
/**
 * @brief Send a set_mode message
 * @param chan MAVLink channel to send the message
 *
 * @param target_system The system setting the mode
 * @param base_mode The new base mode
 * @param custom_mode The new autopilot-specific mode. This field can be ignored by an autopilot.
 *//*
#ifdef MAVLINK_USE_CONVENIENCE_FUNCTIONS

static inline void mavlink_msg_set_mode_send(mavlink_channel_t chan, byte public target_system, byte public base_mode, UInt16 public custom_mode)
{
#if MAVLINK_NEED_BYTE_SWAP || !MAVLINK_ALIGNED_FIELDS
    char buf[4];
	_mav_put_UInt16(buf, 0, custom_mode);
	_mav_put_byte(buf, 2, target_system);
	_mav_put_byte(buf, 3, base_mode);

    _mav_finalize_message_chan_send(chan, MAVLINK_MSG_ID_SET_MODE, buf, 4, 197);
#else
    mavlink_set_mode_t packet;
	packet.custom_mode = custom_mode;
	packet.target_system = target_system;
	packet.base_mode = base_mode;

    _mav_finalize_message_chan_send(chan, MAVLINK_MSG_ID_SET_MODE, (const char *)&packet, 4, 197);
#endif
}

#endif
*/
// MESSAGE SET_MODE UNPACKING


/**
 * @brief Get field target_system from set_mode message
 *
 * @return The system setting the mode
 */
public static byte mavlink_msg_set_mode_get_target_system(byte[] msg)
{
    return getByte(msg,  2);
}

/**
 * @brief Get field base_mode from set_mode message
 *
 * @return The new base mode
 */
public static byte mavlink_msg_set_mode_get_base_mode(byte[] msg)
{
    return getByte(msg,  3);
}

/**
 * @brief Get field custom_mode from set_mode message
 *
 * @return The new autopilot-specific mode. This field can be ignored by an autopilot.
 */
public static UInt16 mavlink_msg_set_mode_get_custom_mode(byte[] msg)
{
    return BitConverter.ToUInt16(msg,  0);
}

/**
 * @brief Decode a set_mode message into a struct
 *
 * @param msg The message to decode
 * @param set_mode C-struct to decode the message contents into
 */
public static void mavlink_msg_set_mode_decode(byte[] msg, ref mavlink_set_mode_t set_mode)
{
    if (MAVLINK_NEED_BYTE_SWAP) {
    	set_mode.custom_mode = mavlink_msg_set_mode_get_custom_mode(msg);
    	set_mode.target_system = mavlink_msg_set_mode_get_target_system(msg);
    	set_mode.base_mode = mavlink_msg_set_mode_get_base_mode(msg);
    
    } else {
        int len = 4; //Marshal.SizeOf(set_mode);
        IntPtr i = Marshal.AllocHGlobal(len);
        Marshal.Copy(msg, 0, i, len);
        set_mode = (mavlink_set_mode_t)Marshal.PtrToStructure(i, ((object)set_mode).GetType());
        Marshal.FreeHGlobal(i);
    }
}

}
