﻿using System;

using Foundation;
using WatchKit;

namespace WatchComplication
{
	[Register ("ExtensionDelegate")]
	public class ExtensionDelegate : WKExtensionDelegate
	{
		public ExtensionDelegate() {}
		public ExtensionDelegate (IntPtr p) : base (p) 
		{
		}

		public override void ApplicationDidBecomeActive ()
		{
			Console.WriteLine ("{0} ApplicationDidBecomeActive", this);
		}
		public override void ApplicationDidFinishLaunching ()
		{
			Console.WriteLine ("{0} ApplicationDidFinishLaunching", this);
		}
		public override void ApplicationWillResignActive ()
		{
			Console.WriteLine ("{0} ApplicationWillResignActive", this);
		}
	}
}


