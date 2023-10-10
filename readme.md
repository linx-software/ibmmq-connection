# Background #

This console app tests connectivity to an IBM MQ queue manager and a related queue. It was developed to test different connectivity options.

The app uses the [IBMMQDotnetClient](https://www.ibm.com/docs/en/ibm-mq/9.3?topic=reference-mq-net-classes-interfaces).

# Usage #

Update the appsettings.json file with the configuration you want to test and run the app.

The default configuration is in the [appsettings](src/appsettings.json) file and looks something like this:

````
{
	"Settings": {
		"ConnectionProperties": {
			"CHANNEL_PROPERTY": "DEV.APP.SVRCONN",
			"HOST_NAME_PROPERTY": "127.0.0.1",
			"PASSWORD_PROPERTY": "passw0rd",
			"PORT_PROPERTY": "1414",
			"TRANSPORT_PROPERTY": "MQSeries Managed Client",
			"USER_ID_PROPERTY": "app"
		},
		"QueueManagerName": "QM1",
		"QueueName": "DEV.QUEUE.1",
		"QueueOpenOptions": 9
		}
}
````

From the [docs](https://www.ibm.com/docs/en/ibm-mq/9.3?topic=interfaces-mqqueuemanagernet-class#q111270___c), ConnectionProperties can be changed to any of these:
````
CONNECT_OPTIONS_PROPERTY
CONNECTION_NAME_PROPERTY
ENCRYPTION_POLICY_SUITE_B
HOST_NAME_PROPERTY
PORT_PROPERTY
CHANNEL_PROPERTY
SSL_CIPHER_SPEC_PROPERTY
SSL_PEER_NAME_PROPERTY
SSL_CERT_STORE_PROPERTY
SSL_CRYPTO_HARDWARE_PROPERTY
SECURITY_EXIT_PROPERTY
SECURITY_USERDATA_PROPERTY
SEND_EXIT_PROPERTY
SEND_USERDATA_PROPERTY
RECEIVE_EXIT_PROPERTY
RECEIVE_USERDATA_PROPERTY
USER_ID_PROPERTY
PASSWORD_PROPERTY
MQAIR_ARRAY
KEY_RESET_COUNT
FIPS_REQUIRED
HDR_CMP_LIST
MSG_CMP_LIST
TRANSPORT_PROPERTY
````

QueueOpenOptions can be any of the following. It's represented by an int so just add the numbers.
````
MQOO_BIND_AS_Q_DEF = 0;
MQOO_INPUT_AS_Q_DEF = 1;
MQOO_INPUT_SHARED = 2;
MQOO_INPUT_EXCLUSIVE = 4;
MQOO_BROWSE = 8;
MQOO_OUTPUT = 16;
MQOO_INQUIRE = 32;
MQOO_SET = 64;
MQOO_SAVE_ALL_CONTEXT = 128;
MQOO_PASS_IDENTITY_CONTEXT = 256;
MQOO_PASS_ALL_CONTEXT = 512;
MQOO_SET_IDENTITY_CONTEXT = 1024;
MQOO_SET_ALL_CONTEXT = 2048;
MQOO_ALTERNATE_USER_AUTHORITY = 4096;
MQOO_FAIL_IF_QUIESCING = 8192;
MQOO_BIND_ON_OPEN = 16384;
MQOO_BIND_NOT_FIXED = 32768;
````