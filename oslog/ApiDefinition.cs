using System;
using Foundation;

namespace oslog
{
	[BaseType(typeof(NSObject))]
	interface Logger
	{
		[Export("initWithSubsystemAndCategory:category:")]
		IntPtr Constructor(string subsystem, string category);

		[Export("Log:message:")]
		void Log(LogType type, [PlainString] string msg);
	}
}
