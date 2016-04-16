// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace PickLocker.SViOS
{
	[Register ("AuthenticationViewController")]
	partial class AuthenticationViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIView Authen { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField PwdField { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton TouchIDCaller { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (Authen != null) {
				Authen.Dispose ();
				Authen = null;
			}
			if (PwdField != null) {
				PwdField.Dispose ();
				PwdField = null;
			}
			if (TouchIDCaller != null) {
				TouchIDCaller.Dispose ();
				TouchIDCaller = null;
			}
		}
	}
}
