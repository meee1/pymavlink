// MESSAGE RC_CHANNELS_SCALED PACKING

#define MAVLINK_MSG_ID_RC_CHANNELS_SCALED 36

typedef struct __mavlink_rc_channels_scaled_t
{
 int16_t chan1_scaled; ///< RC channel 1 value scaled, (-100%) -10000, (0%) 0, (100%) 10000
 int16_t chan2_scaled; ///< RC channel 2 value scaled, (-100%) -10000, (0%) 0, (100%) 10000
 int16_t chan3_scaled; ///< RC channel 3 value scaled, (-100%) -10000, (0%) 0, (100%) 10000
 int16_t chan4_scaled; ///< RC channel 4 value scaled, (-100%) -10000, (0%) 0, (100%) 10000
 int16_t chan5_scaled; ///< RC channel 5 value scaled, (-100%) -10000, (0%) 0, (100%) 10000
 int16_t chan6_scaled; ///< RC channel 6 value scaled, (-100%) -10000, (0%) 0, (100%) 10000
 int16_t chan7_scaled; ///< RC channel 7 value scaled, (-100%) -10000, (0%) 0, (100%) 10000
 int16_t chan8_scaled; ///< RC channel 8 value scaled, (-100%) -10000, (0%) 0, (100%) 10000
 uint8_t rssi; ///< Receive signal strength indicator, 0: 0%, 255: 100%
} mavlink_rc_channels_scaled_t;

/**
 * @brief Pack a rc_channels_scaled message
 * @param system_id ID of this system
 * @param component_id ID of this component (e.g. 200 for IMU)
 * @param msg The MAVLink message to compress the data into
 *
 * @param chan1_scaled RC channel 1 value scaled, (-100%) -10000, (0%) 0, (100%) 10000
 * @param chan2_scaled RC channel 2 value scaled, (-100%) -10000, (0%) 0, (100%) 10000
 * @param chan3_scaled RC channel 3 value scaled, (-100%) -10000, (0%) 0, (100%) 10000
 * @param chan4_scaled RC channel 4 value scaled, (-100%) -10000, (0%) 0, (100%) 10000
 * @param chan5_scaled RC channel 5 value scaled, (-100%) -10000, (0%) 0, (100%) 10000
 * @param chan6_scaled RC channel 6 value scaled, (-100%) -10000, (0%) 0, (100%) 10000
 * @param chan7_scaled RC channel 7 value scaled, (-100%) -10000, (0%) 0, (100%) 10000
 * @param chan8_scaled RC channel 8 value scaled, (-100%) -10000, (0%) 0, (100%) 10000
 * @param rssi Receive signal strength indicator, 0: 0%, 255: 100%
 * @return length of the message in bytes (excluding serial stream start sign)
 */
static inline uint16_t mavlink_msg_rc_channels_scaled_pack(uint8_t system_id, uint8_t component_id, mavlink_message_t* msg,
						       int16_t chan1_scaled, int16_t chan2_scaled, int16_t chan3_scaled, int16_t chan4_scaled, int16_t chan5_scaled, int16_t chan6_scaled, int16_t chan7_scaled, int16_t chan8_scaled, uint8_t rssi)
{
	msg->msgid = MAVLINK_MSG_ID_RC_CHANNELS_SCALED;

	put_int16_t_by_index(chan1_scaled, 0,  msg->payload); // RC channel 1 value scaled, (-100%) -10000, (0%) 0, (100%) 10000
	put_int16_t_by_index(chan2_scaled, 2,  msg->payload); // RC channel 2 value scaled, (-100%) -10000, (0%) 0, (100%) 10000
	put_int16_t_by_index(chan3_scaled, 4,  msg->payload); // RC channel 3 value scaled, (-100%) -10000, (0%) 0, (100%) 10000
	put_int16_t_by_index(chan4_scaled, 6,  msg->payload); // RC channel 4 value scaled, (-100%) -10000, (0%) 0, (100%) 10000
	put_int16_t_by_index(chan5_scaled, 8,  msg->payload); // RC channel 5 value scaled, (-100%) -10000, (0%) 0, (100%) 10000
	put_int16_t_by_index(chan6_scaled, 10,  msg->payload); // RC channel 6 value scaled, (-100%) -10000, (0%) 0, (100%) 10000
	put_int16_t_by_index(chan7_scaled, 12,  msg->payload); // RC channel 7 value scaled, (-100%) -10000, (0%) 0, (100%) 10000
	put_int16_t_by_index(chan8_scaled, 14,  msg->payload); // RC channel 8 value scaled, (-100%) -10000, (0%) 0, (100%) 10000
	put_uint8_t_by_index(rssi, 16,  msg->payload); // Receive signal strength indicator, 0: 0%, 255: 100%

	return mavlink_finalize_message(msg, system_id, component_id, 17, 92);
}

/**
 * @brief Pack a rc_channels_scaled message on a channel
 * @param system_id ID of this system
 * @param component_id ID of this component (e.g. 200 for IMU)
 * @param chan The MAVLink channel this message was sent over
 * @param msg The MAVLink message to compress the data into
 * @param chan1_scaled RC channel 1 value scaled, (-100%) -10000, (0%) 0, (100%) 10000
 * @param chan2_scaled RC channel 2 value scaled, (-100%) -10000, (0%) 0, (100%) 10000
 * @param chan3_scaled RC channel 3 value scaled, (-100%) -10000, (0%) 0, (100%) 10000
 * @param chan4_scaled RC channel 4 value scaled, (-100%) -10000, (0%) 0, (100%) 10000
 * @param chan5_scaled RC channel 5 value scaled, (-100%) -10000, (0%) 0, (100%) 10000
 * @param chan6_scaled RC channel 6 value scaled, (-100%) -10000, (0%) 0, (100%) 10000
 * @param chan7_scaled RC channel 7 value scaled, (-100%) -10000, (0%) 0, (100%) 10000
 * @param chan8_scaled RC channel 8 value scaled, (-100%) -10000, (0%) 0, (100%) 10000
 * @param rssi Receive signal strength indicator, 0: 0%, 255: 100%
 * @return length of the message in bytes (excluding serial stream start sign)
 */
static inline uint16_t mavlink_msg_rc_channels_scaled_pack_chan(uint8_t system_id, uint8_t component_id, uint8_t chan,
							   mavlink_message_t* msg,
						           int16_t chan1_scaled,int16_t chan2_scaled,int16_t chan3_scaled,int16_t chan4_scaled,int16_t chan5_scaled,int16_t chan6_scaled,int16_t chan7_scaled,int16_t chan8_scaled,uint8_t rssi)
{
	msg->msgid = MAVLINK_MSG_ID_RC_CHANNELS_SCALED;

	put_int16_t_by_index(chan1_scaled, 0,  msg->payload); // RC channel 1 value scaled, (-100%) -10000, (0%) 0, (100%) 10000
	put_int16_t_by_index(chan2_scaled, 2,  msg->payload); // RC channel 2 value scaled, (-100%) -10000, (0%) 0, (100%) 10000
	put_int16_t_by_index(chan3_scaled, 4,  msg->payload); // RC channel 3 value scaled, (-100%) -10000, (0%) 0, (100%) 10000
	put_int16_t_by_index(chan4_scaled, 6,  msg->payload); // RC channel 4 value scaled, (-100%) -10000, (0%) 0, (100%) 10000
	put_int16_t_by_index(chan5_scaled, 8,  msg->payload); // RC channel 5 value scaled, (-100%) -10000, (0%) 0, (100%) 10000
	put_int16_t_by_index(chan6_scaled, 10,  msg->payload); // RC channel 6 value scaled, (-100%) -10000, (0%) 0, (100%) 10000
	put_int16_t_by_index(chan7_scaled, 12,  msg->payload); // RC channel 7 value scaled, (-100%) -10000, (0%) 0, (100%) 10000
	put_int16_t_by_index(chan8_scaled, 14,  msg->payload); // RC channel 8 value scaled, (-100%) -10000, (0%) 0, (100%) 10000
	put_uint8_t_by_index(rssi, 16,  msg->payload); // Receive signal strength indicator, 0: 0%, 255: 100%

	return mavlink_finalize_message_chan(msg, system_id, component_id, chan, 17, 92);
}

#ifdef MAVLINK_USE_CONVENIENCE_FUNCTIONS

/**
 * @brief Pack a rc_channels_scaled message on a channel and send
 * @param chan The MAVLink channel this message was sent over
 * @param msg The MAVLink message to compress the data into
 * @param chan1_scaled RC channel 1 value scaled, (-100%) -10000, (0%) 0, (100%) 10000
 * @param chan2_scaled RC channel 2 value scaled, (-100%) -10000, (0%) 0, (100%) 10000
 * @param chan3_scaled RC channel 3 value scaled, (-100%) -10000, (0%) 0, (100%) 10000
 * @param chan4_scaled RC channel 4 value scaled, (-100%) -10000, (0%) 0, (100%) 10000
 * @param chan5_scaled RC channel 5 value scaled, (-100%) -10000, (0%) 0, (100%) 10000
 * @param chan6_scaled RC channel 6 value scaled, (-100%) -10000, (0%) 0, (100%) 10000
 * @param chan7_scaled RC channel 7 value scaled, (-100%) -10000, (0%) 0, (100%) 10000
 * @param chan8_scaled RC channel 8 value scaled, (-100%) -10000, (0%) 0, (100%) 10000
 * @param rssi Receive signal strength indicator, 0: 0%, 255: 100%
 */
static inline void mavlink_msg_rc_channels_scaled_pack_chan_send(mavlink_channel_t chan,
							   mavlink_message_t* msg,
						           int16_t chan1_scaled,int16_t chan2_scaled,int16_t chan3_scaled,int16_t chan4_scaled,int16_t chan5_scaled,int16_t chan6_scaled,int16_t chan7_scaled,int16_t chan8_scaled,uint8_t rssi)
{
	msg->msgid = MAVLINK_MSG_ID_RC_CHANNELS_SCALED;

	put_int16_t_by_index(chan1_scaled, 0,  msg->payload); // RC channel 1 value scaled, (-100%) -10000, (0%) 0, (100%) 10000
	put_int16_t_by_index(chan2_scaled, 2,  msg->payload); // RC channel 2 value scaled, (-100%) -10000, (0%) 0, (100%) 10000
	put_int16_t_by_index(chan3_scaled, 4,  msg->payload); // RC channel 3 value scaled, (-100%) -10000, (0%) 0, (100%) 10000
	put_int16_t_by_index(chan4_scaled, 6,  msg->payload); // RC channel 4 value scaled, (-100%) -10000, (0%) 0, (100%) 10000
	put_int16_t_by_index(chan5_scaled, 8,  msg->payload); // RC channel 5 value scaled, (-100%) -10000, (0%) 0, (100%) 10000
	put_int16_t_by_index(chan6_scaled, 10,  msg->payload); // RC channel 6 value scaled, (-100%) -10000, (0%) 0, (100%) 10000
	put_int16_t_by_index(chan7_scaled, 12,  msg->payload); // RC channel 7 value scaled, (-100%) -10000, (0%) 0, (100%) 10000
	put_int16_t_by_index(chan8_scaled, 14,  msg->payload); // RC channel 8 value scaled, (-100%) -10000, (0%) 0, (100%) 10000
	put_uint8_t_by_index(rssi, 16,  msg->payload); // Receive signal strength indicator, 0: 0%, 255: 100%

	mavlink_finalize_message_chan_send(msg, chan, 17, 92);
}
#endif // MAVLINK_USE_CONVENIENCE_FUNCTIONS


/**
 * @brief Encode a rc_channels_scaled struct into a message
 *
 * @param system_id ID of this system
 * @param component_id ID of this component (e.g. 200 for IMU)
 * @param msg The MAVLink message to compress the data into
 * @param rc_channels_scaled C-struct to read the message contents from
 */
static inline uint16_t mavlink_msg_rc_channels_scaled_encode(uint8_t system_id, uint8_t component_id, mavlink_message_t* msg, const mavlink_rc_channels_scaled_t* rc_channels_scaled)
{
	return mavlink_msg_rc_channels_scaled_pack(system_id, component_id, msg, rc_channels_scaled->chan1_scaled, rc_channels_scaled->chan2_scaled, rc_channels_scaled->chan3_scaled, rc_channels_scaled->chan4_scaled, rc_channels_scaled->chan5_scaled, rc_channels_scaled->chan6_scaled, rc_channels_scaled->chan7_scaled, rc_channels_scaled->chan8_scaled, rc_channels_scaled->rssi);
}

/**
 * @brief Send a rc_channels_scaled message
 * @param chan MAVLink channel to send the message
 *
 * @param chan1_scaled RC channel 1 value scaled, (-100%) -10000, (0%) 0, (100%) 10000
 * @param chan2_scaled RC channel 2 value scaled, (-100%) -10000, (0%) 0, (100%) 10000
 * @param chan3_scaled RC channel 3 value scaled, (-100%) -10000, (0%) 0, (100%) 10000
 * @param chan4_scaled RC channel 4 value scaled, (-100%) -10000, (0%) 0, (100%) 10000
 * @param chan5_scaled RC channel 5 value scaled, (-100%) -10000, (0%) 0, (100%) 10000
 * @param chan6_scaled RC channel 6 value scaled, (-100%) -10000, (0%) 0, (100%) 10000
 * @param chan7_scaled RC channel 7 value scaled, (-100%) -10000, (0%) 0, (100%) 10000
 * @param chan8_scaled RC channel 8 value scaled, (-100%) -10000, (0%) 0, (100%) 10000
 * @param rssi Receive signal strength indicator, 0: 0%, 255: 100%
 */
#ifdef MAVLINK_USE_CONVENIENCE_FUNCTIONS

static inline void mavlink_msg_rc_channels_scaled_send(mavlink_channel_t chan, int16_t chan1_scaled, int16_t chan2_scaled, int16_t chan3_scaled, int16_t chan4_scaled, int16_t chan5_scaled, int16_t chan6_scaled, int16_t chan7_scaled, int16_t chan8_scaled, uint8_t rssi)
{
	MAVLINK_ALIGNED_MESSAGE(msg, 17);
	mavlink_msg_rc_channels_scaled_pack_chan_send(chan, msg, chan1_scaled, chan2_scaled, chan3_scaled, chan4_scaled, chan5_scaled, chan6_scaled, chan7_scaled, chan8_scaled, rssi);
}

#endif

// MESSAGE RC_CHANNELS_SCALED UNPACKING


/**
 * @brief Get field chan1_scaled from rc_channels_scaled message
 *
 * @return RC channel 1 value scaled, (-100%) -10000, (0%) 0, (100%) 10000
 */
static inline int16_t mavlink_msg_rc_channels_scaled_get_chan1_scaled(const mavlink_message_t* msg)
{
	return MAVLINK_MSG_RETURN_int16_t(msg,  0);
}

/**
 * @brief Get field chan2_scaled from rc_channels_scaled message
 *
 * @return RC channel 2 value scaled, (-100%) -10000, (0%) 0, (100%) 10000
 */
static inline int16_t mavlink_msg_rc_channels_scaled_get_chan2_scaled(const mavlink_message_t* msg)
{
	return MAVLINK_MSG_RETURN_int16_t(msg,  2);
}

/**
 * @brief Get field chan3_scaled from rc_channels_scaled message
 *
 * @return RC channel 3 value scaled, (-100%) -10000, (0%) 0, (100%) 10000
 */
static inline int16_t mavlink_msg_rc_channels_scaled_get_chan3_scaled(const mavlink_message_t* msg)
{
	return MAVLINK_MSG_RETURN_int16_t(msg,  4);
}

/**
 * @brief Get field chan4_scaled from rc_channels_scaled message
 *
 * @return RC channel 4 value scaled, (-100%) -10000, (0%) 0, (100%) 10000
 */
static inline int16_t mavlink_msg_rc_channels_scaled_get_chan4_scaled(const mavlink_message_t* msg)
{
	return MAVLINK_MSG_RETURN_int16_t(msg,  6);
}

/**
 * @brief Get field chan5_scaled from rc_channels_scaled message
 *
 * @return RC channel 5 value scaled, (-100%) -10000, (0%) 0, (100%) 10000
 */
static inline int16_t mavlink_msg_rc_channels_scaled_get_chan5_scaled(const mavlink_message_t* msg)
{
	return MAVLINK_MSG_RETURN_int16_t(msg,  8);
}

/**
 * @brief Get field chan6_scaled from rc_channels_scaled message
 *
 * @return RC channel 6 value scaled, (-100%) -10000, (0%) 0, (100%) 10000
 */
static inline int16_t mavlink_msg_rc_channels_scaled_get_chan6_scaled(const mavlink_message_t* msg)
{
	return MAVLINK_MSG_RETURN_int16_t(msg,  10);
}

/**
 * @brief Get field chan7_scaled from rc_channels_scaled message
 *
 * @return RC channel 7 value scaled, (-100%) -10000, (0%) 0, (100%) 10000
 */
static inline int16_t mavlink_msg_rc_channels_scaled_get_chan7_scaled(const mavlink_message_t* msg)
{
	return MAVLINK_MSG_RETURN_int16_t(msg,  12);
}

/**
 * @brief Get field chan8_scaled from rc_channels_scaled message
 *
 * @return RC channel 8 value scaled, (-100%) -10000, (0%) 0, (100%) 10000
 */
static inline int16_t mavlink_msg_rc_channels_scaled_get_chan8_scaled(const mavlink_message_t* msg)
{
	return MAVLINK_MSG_RETURN_int16_t(msg,  14);
}

/**
 * @brief Get field rssi from rc_channels_scaled message
 *
 * @return Receive signal strength indicator, 0: 0%, 255: 100%
 */
static inline uint8_t mavlink_msg_rc_channels_scaled_get_rssi(const mavlink_message_t* msg)
{
	return MAVLINK_MSG_RETURN_uint8_t(msg,  16);
}

/**
 * @brief Decode a rc_channels_scaled message into a struct
 *
 * @param msg The message to decode
 * @param rc_channels_scaled C-struct to decode the message contents into
 */
static inline void mavlink_msg_rc_channels_scaled_decode(const mavlink_message_t* msg, mavlink_rc_channels_scaled_t* rc_channels_scaled)
{
#if MAVLINK_NEED_BYTE_SWAP
	rc_channels_scaled->chan1_scaled = mavlink_msg_rc_channels_scaled_get_chan1_scaled(msg);
	rc_channels_scaled->chan2_scaled = mavlink_msg_rc_channels_scaled_get_chan2_scaled(msg);
	rc_channels_scaled->chan3_scaled = mavlink_msg_rc_channels_scaled_get_chan3_scaled(msg);
	rc_channels_scaled->chan4_scaled = mavlink_msg_rc_channels_scaled_get_chan4_scaled(msg);
	rc_channels_scaled->chan5_scaled = mavlink_msg_rc_channels_scaled_get_chan5_scaled(msg);
	rc_channels_scaled->chan6_scaled = mavlink_msg_rc_channels_scaled_get_chan6_scaled(msg);
	rc_channels_scaled->chan7_scaled = mavlink_msg_rc_channels_scaled_get_chan7_scaled(msg);
	rc_channels_scaled->chan8_scaled = mavlink_msg_rc_channels_scaled_get_chan8_scaled(msg);
	rc_channels_scaled->rssi = mavlink_msg_rc_channels_scaled_get_rssi(msg);
#else
	memcpy(rc_channels_scaled, msg->payload, 17);
#endif
}