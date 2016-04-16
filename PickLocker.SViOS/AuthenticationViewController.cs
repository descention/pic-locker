using Foundation;
using LocalAuthentication;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace PickLocker.SViOS
{
	partial class AuthenticationViewController : UIViewController
	{
        public AuthenticationViewController(IntPtr handle) : base(handle)
        { }

        partial void AuthenticateMe(UIButton sender)
        {
            var context = new LAContext();
            NSError AuthError;
            var myReason = new NSString("To add a new chore");


            if (context.CanEvaluatePolicy(LAPolicy.DeviceOwnerAuthenticationWithBiometrics, out AuthError))
            {
                var replyHandler = new LAContextReplyHandler((success, error) => {

                    this.InvokeOnMainThread(() => {
                        if (success)
                        {
                            Console.WriteLine("You logged in!");
                            PerformSegue("AuthenticationSegue", this);
                        }
                        else
                        {
                            //Show fallback mechanism here
                        }
                    });

                });
                context.EvaluatePolicy(LAPolicy.DeviceOwnerAuthenticationWithBiometrics, myReason, replyHandler);
            };
        }
    }
}
