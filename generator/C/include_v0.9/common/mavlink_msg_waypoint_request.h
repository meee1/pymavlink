// MESSAGE WAYPOINT_REQUEST PACKING

#define MAVLINK_MSG_ID_WAYPOINT_REQUEST 40

typedef struct __mavlink_waypoint_request_t
{
 uint8_t target_system; ///< System ID
 uint8_t target_component; ///< Component ID
 uint16_t seq; ///< Sequence
} mavlink_waypoint_request_t;

/**
 * @brief Pack a waypoint_request message
 * @param system_id ID of this system
 * @param component_id ID of this component (e.g. 200 for IMU)
 * @param msg The MAVLink message to compress the data into
 *
 * @param target_system System ID
 * @param target_component Component ID
 * @param seq Sequence
 * @return length of the message in bytes (excluding serial stream start sign)
 */
static inline uint16_t mavlink_msg_waypoint_request_pack(uint8_t system_id, uint8_t component_id, mavlink_message_t* msg,
						       uint8_t target_system, uint8_t target_component, uint16_t seq)
{
	msg->msgid = MAVLINK_MSG_ID_WAYPOINT_REQUEST;

	put_uint8_t_by_index(target_system, 0,  msg->payload); // System ID
	put_uint8_t_by_index(target_component, 1,  msg->payload); // Component ID
	put_uint16_t_by_index(seq, 2,  msg->payload); // Sequence

	return mavlink_finalize_message(msg, system_id, component_id, 4, 138);
}

/**
 * @brief Pack a waypoint_request message on a channel
 * @param system_id ID of this system
 * @param component_id ID of this component (e.g. 200 for IMU)
 * @param chan The MAVLink channel this message was sent over
 * @param msg The MAVLink message to compress the data into
 * @param target_system System ID
 * @param target_component Component ID
 * @param seq Sequence
 * @return length of the message in bytes (excluding serial stream start sign)
 */
static inline uint16_t mavlink_msg_waypoint_request_pack_chan(uint8_t system_id, uint8_t component_id, uint8_t chan,
							   mavlink_message_t* msg,
						           uint8_t target_system,uint8_t target_component,uint16_t seq)
{
	msg->msgid = MAVLINK_MSG_ID_WAYPOINT_REQUEST;

	put_uint8_t_by_index(target_system, 0,  msg->payload); // System ID
	put_uint8_t_by_index(target_component, 1,  msg->payload); // Component ID
	put_uint16_t_by_index(seq, 2,  msg->payload); // Sequence

	return mavlink_finalize_message_chan(msg, system_id, component_id, chan, 4, 138);
}

#ifdef MAVLINK_USE_CONVENIENCE_FUNCTIONS

/**
 * @brief Pack a waypoint_request message on a channel and send
 * @param chan The MAVLink channel this message was sent over
 * @param msg The MAVLink message to compress the data into
 * @param target_system System ID
 * @param target_component Component ID
 * @param seq Sequence
 */
static inline void mavlink_msg_waypoint_request_pack_chan_send(mavlink_channel_t chan,
							   mavlink_message_t* msg,
						           uint8_t target_system,uint8_t target_component,uint16_t seq)
{
	msg->msgid = MAVLINK_MSG_ID_WAYPOINT_REQUEST;

	put_uint8_t_by_index(target_system, 0,  msg->payload); // System ID
	put_uint8_t_by_index(target_component, 1,  msg->payload); // Component ID
	put_uint16_t_by_index(seq, 2,  msg->payload); // Sequence

	mavlink_finalize_message_chan_send(msg, chan, 4, 138);
}
#endif // MAVLINK_USE_CONVENIENCE_FUNCTIONS


/**
 * @brief Encode a waypoint_request struct into a message
 *
 * @param system_id ID of this system
 * @param component_id ID of this component (e.g. 200 for IMU)
 * @param msg The MAVLink message to compress the data into
 * @param waypoint_request C-struct to read the message contents from
 */
static inline uint16_t mavlink_msg_waypoint_request_encode(uint8_t system_id, uint8_t component_id, mavlink_message_t* msg, const mavlink_waypoint_request_t* waypoint_request)
{
	return mavlink_msg_waypoint_request_pack(system_id, component_id, msg, waypoint_request->target_system, waypoint_request->target_component, waypoint_request->seq);
}

/**
 * @brief Send a waypoint_request message
 * @param chan MAVLink channel to send the message
 *
 * @param target_system System ID
 * @param target_component Component ID
 * @param seq Sequence
 */
#ifdef MAVLINK_USE_CONVENIENCE_FUNCTIONS

static inline void mavlink_msg_waypoint_request_send(mavlink_channel_t chan, uint8_t target_system, uint8_t target_component, uint16_t seq)
{
	MAVLINK_ALIGNED_MESSAGE(msg, 4);
	mavlink_msg_waypoint_request_pack_chan_send(chan, msg, target_system, target_component, seq);
}

#endif

// MESSAGE WAYPOINT_REQUEST UNPACKING


/**
 * @brief Get field target_system from waypoint_request message
 *
 * @return System ID
 */
static inline uint8_t mavlink_msg_waypoint_request_get_target_system(const mavlink_message_t* msg)
{
	return MAVLINK_MSG_RETURN_uint8_t(msg,  0);
}

/**
 * @brief Get field target_component from waypoint_request message
 *
 * @return Component ID
 */
static inline uint8_t mavlink_msg_waypoint_request_get_target_component(const mavlink_message_t* msg)
{
	return MAVLINK_MSG_RETURN_uint8_t(msg,  1);
}

/**
 * @brief Get field seq from waypoint_request message
 *
 * @return Sequence
 */
static inline uint16_t mavlink_msg_waypoint_request_get_seq(const mavlink_message_t* msg)
{
	return MAVLINK_MSG_RETURN_uint16_t(msg,  2);
}

/**
 * @brief Decode a waypoint_request message into a struct
 *
 * @param msg The message to decode
 * @param waypoint_request C-struct to decode the message contents into
 */
static inline void mavlink_msg_waypoint_request_decode(const mavlink_message_t* msg, mavlink_waypoint_request_t* waypoint_request)
{
#if MAVLINK_NEED_BYTE_SWAP
	waypoint_request->target_system = mavlink_msg_waypoint_request_get_target_system(msg);
	waypoint_request->target_component = mavlink_msg_waypoint_request_get_target_component(msg);
	waypoint_request->seq = mavlink_msg_waypoint_request_get_seq(msg);
#else
	memcpy(waypoint_request, msg->payload, 4);
#endif
}