// MESSAGE CTRL_SRFC_PT PACKING

#define MAVLINK_MSG_ID_CTRL_SRFC_PT 181

typedef struct __mavlink_ctrl_srfc_pt_t
{
 uint16_t bitfieldPt; ///< Bitfield containing the PT configuration
 uint8_t target; ///< The system setting the commands
} mavlink_ctrl_srfc_pt_t;

/**
 * @brief Pack a ctrl_srfc_pt message
 * @param system_id ID of this system
 * @param component_id ID of this component (e.g. 200 for IMU)
 * @param msg The MAVLink message to compress the data into
 *
 * @param target The system setting the commands
 * @param bitfieldPt Bitfield containing the PT configuration
 * @return length of the message in bytes (excluding serial stream start sign)
 */
static inline uint16_t mavlink_msg_ctrl_srfc_pt_pack(uint8_t system_id, uint8_t component_id, mavlink_message_t* msg,
						       uint8_t target, uint16_t bitfieldPt)
{
	msg->msgid = MAVLINK_MSG_ID_CTRL_SRFC_PT;

	put_uint16_t_by_index(bitfieldPt, 0,  MAVLINK_PAYLOAD(msg)); // Bitfield containing the PT configuration
	put_uint8_t_by_index(target, 2,  MAVLINK_PAYLOAD(msg)); // The system setting the commands

	return mavlink_finalize_message(msg, system_id, component_id, 3, 57);
}

/**
 * @brief Pack a ctrl_srfc_pt message on a channel
 * @param system_id ID of this system
 * @param component_id ID of this component (e.g. 200 for IMU)
 * @param chan The MAVLink channel this message was sent over
 * @param msg The MAVLink message to compress the data into
 * @param target The system setting the commands
 * @param bitfieldPt Bitfield containing the PT configuration
 * @return length of the message in bytes (excluding serial stream start sign)
 */
static inline uint16_t mavlink_msg_ctrl_srfc_pt_pack_chan(uint8_t system_id, uint8_t component_id, uint8_t chan,
							   mavlink_message_t* msg,
						           uint8_t target,uint16_t bitfieldPt)
{
	msg->msgid = MAVLINK_MSG_ID_CTRL_SRFC_PT;

	put_uint16_t_by_index(bitfieldPt, 0,  MAVLINK_PAYLOAD(msg)); // Bitfield containing the PT configuration
	put_uint8_t_by_index(target, 2,  MAVLINK_PAYLOAD(msg)); // The system setting the commands

	return mavlink_finalize_message_chan(msg, system_id, component_id, chan, 3, 57);
}

#ifdef MAVLINK_USE_CONVENIENCE_FUNCTIONS

/**
 * @brief Pack a ctrl_srfc_pt message on a channel and send
 * @param chan The MAVLink channel this message was sent over
 * @param msg The MAVLink message to compress the data into
 * @param target The system setting the commands
 * @param bitfieldPt Bitfield containing the PT configuration
 */
static inline void mavlink_msg_ctrl_srfc_pt_pack_chan_send(mavlink_channel_t chan,
							   mavlink_message_t* msg,
						           uint8_t target,uint16_t bitfieldPt)
{
	msg->msgid = MAVLINK_MSG_ID_CTRL_SRFC_PT;

	put_uint16_t_by_index(bitfieldPt, 0,  MAVLINK_PAYLOAD(msg)); // Bitfield containing the PT configuration
	put_uint8_t_by_index(target, 2,  MAVLINK_PAYLOAD(msg)); // The system setting the commands

	mavlink_finalize_message_chan_send(msg, chan, 3, 57);
}
#endif // MAVLINK_USE_CONVENIENCE_FUNCTIONS


/**
 * @brief Encode a ctrl_srfc_pt struct into a message
 *
 * @param system_id ID of this system
 * @param component_id ID of this component (e.g. 200 for IMU)
 * @param msg The MAVLink message to compress the data into
 * @param ctrl_srfc_pt C-struct to read the message contents from
 */
static inline uint16_t mavlink_msg_ctrl_srfc_pt_encode(uint8_t system_id, uint8_t component_id, mavlink_message_t* msg, const mavlink_ctrl_srfc_pt_t* ctrl_srfc_pt)
{
	return mavlink_msg_ctrl_srfc_pt_pack(system_id, component_id, msg, ctrl_srfc_pt->target, ctrl_srfc_pt->bitfieldPt);
}

/**
 * @brief Send a ctrl_srfc_pt message
 * @param chan MAVLink channel to send the message
 *
 * @param target The system setting the commands
 * @param bitfieldPt Bitfield containing the PT configuration
 */
#ifdef MAVLINK_USE_CONVENIENCE_FUNCTIONS

static inline void mavlink_msg_ctrl_srfc_pt_send(mavlink_channel_t chan, uint8_t target, uint16_t bitfieldPt)
{
	MAVLINK_ALIGNED_MESSAGE(msg, 3);
	mavlink_msg_ctrl_srfc_pt_pack_chan_send(chan, msg, target, bitfieldPt);
}

#endif

// MESSAGE CTRL_SRFC_PT UNPACKING


/**
 * @brief Get field target from ctrl_srfc_pt message
 *
 * @return The system setting the commands
 */
static inline uint8_t mavlink_msg_ctrl_srfc_pt_get_target(const mavlink_message_t* msg)
{
	return MAVLINK_MSG_RETURN_uint8_t(msg,  2);
}

/**
 * @brief Get field bitfieldPt from ctrl_srfc_pt message
 *
 * @return Bitfield containing the PT configuration
 */
static inline uint16_t mavlink_msg_ctrl_srfc_pt_get_bitfieldPt(const mavlink_message_t* msg)
{
	return MAVLINK_MSG_RETURN_uint16_t(msg,  0);
}

/**
 * @brief Decode a ctrl_srfc_pt message into a struct
 *
 * @param msg The message to decode
 * @param ctrl_srfc_pt C-struct to decode the message contents into
 */
static inline void mavlink_msg_ctrl_srfc_pt_decode(const mavlink_message_t* msg, mavlink_ctrl_srfc_pt_t* ctrl_srfc_pt)
{
#if MAVLINK_NEED_BYTE_SWAP
	ctrl_srfc_pt->bitfieldPt = mavlink_msg_ctrl_srfc_pt_get_bitfieldPt(msg);
	ctrl_srfc_pt->target = mavlink_msg_ctrl_srfc_pt_get_target(msg);
#else
	memcpy(ctrl_srfc_pt, MAVLINK_PAYLOAD(msg), 3);
#endif
}
