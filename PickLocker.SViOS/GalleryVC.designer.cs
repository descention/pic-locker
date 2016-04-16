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
	[Register ("GalleryVC")]
	partial class GalleryVC
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UICollectionView GalleryCollectionUI { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (GalleryCollectionUI != null) {
				GalleryCollectionUI.Dispose ();
				GalleryCollectionUI = null;
			}
		}
	}
}
