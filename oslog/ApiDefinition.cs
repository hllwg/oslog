﻿using System;
using Foundation;

namespace OSLog
{
	[BaseType(typeof(NSObject))]
	interface Logger
	{
		[Export("initWithSubsystemAndCategory:category:")]
		IntPtr Constructor([PlainString] string subsystem, [PlainString] string category);

		[Export("Log:message:")]
		void Log(LogType type,[PlainString] string msg);

		[Export("IsEnabled:")]
		bool IsEnabled(LogType type);
	}
}
