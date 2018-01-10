using System;

namespace oslog
{
	public enum LogType : byte
	{
		Default = 0x00,
		Info = 0x01,
		Debug = 0x02,
		Error = 0x10,
		Fault = 0x11
	}
}
