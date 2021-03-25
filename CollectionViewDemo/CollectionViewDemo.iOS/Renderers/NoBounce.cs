using CollectionViewDemo.iOS.Renderers;
using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CollectionView), typeof(NoBounce))]
namespace CollectionViewDemo.iOS.Renderers
{


    class NoBounce : CollectionViewRenderer
    {
        public NoBounce()
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<GroupableItemsView> e)
        {
            base.OnElementChanged(e);


            if (e.NewElement != null)

                Controller.CollectionView.Bounces = false;

        }
    }
}