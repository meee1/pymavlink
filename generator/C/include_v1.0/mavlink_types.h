#ifndef MAVLINK_TYPES_H_
#define MAVLINK_TYPES_H_

#include "inttypes.h"

enum MAV_ACTION
{
    MAV_ACTION_HOLD = 0,
    MAV_ACTION_MOTORS_START = 1,
    MAV_ACTION_LAUNCH = 2,
    MAV_ACTION_RETURN = 3,
    MAV_ACTION_EMCY_LAND = 4,
    MAV_ACTION_EMCY_KILL = 5,
    MAV_ACTION_CONFIRM_KILL = 6,
    MAV_ACTION_CONTINUE = 7,
    MAV_ACTION_MOTORS_STOP = 8,
    MAV_ACTION_HALT = 9,
    MAV_ACTION_SHUTDOWN = 10,
    MAV_ACTION_REBOOT = 11,
    MAV_ACTION_SET_MANUAL = 12,
    MAV_ACTION_SET_AUTO = 13,
    MAV_ACTION_STORAGE_READ = 14,
    MAV_ACTION_STORAGE_WRITE = 15,
    MAV_ACTION_CALIBRATE_RC = 16,
    MAV_ACTION_CALIBRATE_GYRO = 17,
    MAV_ACTION_CALIBRATE_MAG = 18,
    MAV_ACTION_CALIBRATE_ACC = 19,
    MAV_ACTION_CALIBRATE_PRESSURE = 20,
    MAV_ACTION_REC_START = 21,
    MAV_ACTION_REC_PAUSE = 22,
    MAV_ACTION_REC_STOP = 23,
    MAV_ACTION_TAKEOFF = 24,
    MAV_ACTION_NAVIGATE = 25,
    MAV_ACTION_LAND = 26,
    MAV_ACTION_LOITER = 27,
    MAV_ACTION_SET_ORIGIN = 28,
    MAV_ACTION_RELAY_ON = 29,
    MAV_ACTION_RELAY_OFF = 30,
    MAV_ACTION_GET_IMAGE = 31,
    MAV_ACTION_VIDEO_START = 32,
    MAV_ACTION_VIDEO_STOP = 33,
    MAV_ACTION_RESET_MAP = 34,
    MAV_ACTION_RESET_PLAN = 35,
    MAV_ACTION_DELAY_BEFORE_COMMAND = 36,
    MAV_ACTION_ASCEND_AT_RATE = 37,
    MAV_ACTION_CHANGE_MODE = 38,
    MAV_ACTION_LOITER_MAX_TURNS = 39,
    MAV_ACTION_LOITER_MAX_TIME = 40,
    MAV_ACTION_START_HILSIM = 41,
    MAV_ACTION_STOP_HILSIM = 42,    
    MAV_ACTION_NB        ///< Number of MAV actions
};

#define MAVLINK_MAX_PAYLOAD_LEN 255 ///< Maximum payload length

#define MAVLINK_CORE_HEADER_LEN 5 ///< Length of core header (of the comm. layer): message length (1 byte) + message sequence (1 byte) + message system id (1 byte) + message component id (1 byte) + message type id (1 byte)
#define MAVLINK_NUM_HEADER_BYTES (MAVLINK_CORE_HEADER_LEN + 1) ///< Length of all header bytes, including core and checksum
#define MAVLINK_NUM_CHECKSUM_BYTES 2
#define MAVLINK_NUM_NON_PAYLOAD_BYTES (MAVLINK_NUM_HEADER_BYTES + MAVLINK_NUM_CHECKSUM_BYTES)

#define MAVLINK_MAX_PACKET_LEN (MAVLINK_MAX_PAYLOAD_LEN + MAVLINK_NUM_NON_PAYLOAD_BYTES) ///< Maximum packet length

typedef struct __mavlink_system {
    uint8_t sysid;   ///< Used by the MAVLink message_xx_send() convenience function
    uint8_t compid;  ///< Used by the MAVLink message_xx_send() convenience function
    uint8_t type;    ///< Unused, can be used by user to store the system's type
    uint8_t state;   ///< Unused, can be used by user to store the system's state
    uint8_t mode;    ///< Unused, can be used by user to store the system's mode
    uint8_t nav_mode;    ///< Unused, can be used by user to store the system's navigation mode
} mavlink_system_t;

typedef struct __mavlink_message {
    uint8_t magic;   ///< protocol magic marker
    uint8_t len;     ///< Length of payload
    uint8_t seq;     ///< Sequence of packet
    uint8_t sysid;   ///< ID of message sender system/aircraft
    uint8_t compid;  ///< ID of the message sender component
    uint8_t msgid;   ///< ID of message in payload
    uint8_t payload[MAVLINK_MAX_PAYLOAD_LEN+MAVLINK_NUM_CHECKSUM_BYTES]; ///< Payload data, ALIGNMENT IMPORTANT ON MCU
} mavlink_message_t;

// checksum is immediately after the payload bytes
#define mavlink_ck_a(msg) msg->payload[msg->len]
#define mavlink_ck_b(msg) msg->payload[msg->len+1]

typedef enum {
    MAVLINK_COMM_0,
    MAVLINK_COMM_1,
    MAVLINK_COMM_2,
    MAVLINK_COMM_3
} mavlink_channel_t;

/*
 * applications can set MAVLINK_COMM_NUM_BUFFERS to the maximum number
 * of buffers they will use. If more are used, then the result will be
 * a stack overrun
 */
#ifndef MAVLINK_COMM_NUM_BUFFERS
#if (defined linux) | (defined __linux) | (defined  __MACH__) | (defined _WIN32)
# define MAVLINK_COMM_NUM_BUFFERS 16
#else
# define MAVLINK_COMM_NUM_BUFFERS 4
#endif
#endif

typedef enum {
    MAVLINK_PARSE_STATE_UNINIT=0,
    MAVLINK_PARSE_STATE_IDLE,
    MAVLINK_PARSE_STATE_GOT_STX,
    MAVLINK_PARSE_STATE_GOT_SEQ,
    MAVLINK_PARSE_STATE_GOT_LENGTH,
    MAVLINK_PARSE_STATE_GOT_SYSID,
    MAVLINK_PARSE_STATE_GOT_COMPID,
    MAVLINK_PARSE_STATE_GOT_MSGID,
    MAVLINK_PARSE_STATE_GOT_PAYLOAD,
    MAVLINK_PARSE_STATE_GOT_CRC1
} mavlink_parse_state_t; ///< The state machine for the comm parser

typedef struct __mavlink_status {
    uint8_t ck_a;                       ///< Checksum byte 1
    uint8_t ck_b;                       ///< Checksum byte 2
    uint8_t msg_received;               ///< Number of received messages
    uint8_t buffer_overrun;             ///< Number of buffer overruns
    uint8_t parse_error;                ///< Number of parse errors
    mavlink_parse_state_t parse_state;  ///< Parsing state machine
    uint8_t packet_idx;                 ///< Index in current packet
    uint8_t current_rx_seq;             ///< Sequence number of last packet received
    uint8_t current_tx_seq;             ///< Sequence number of last packet sent
    uint16_t packet_rx_success_count;   ///< Received packets
    uint16_t packet_rx_drop_count;      ///< Number of packet drops
} mavlink_status_t;

#define MAVLINK_BIG_ENDIAN 0
#define MAVLINK_LITTLE_ENDIAN 1

#endif /* MAVLINK_TYPES_H_ */