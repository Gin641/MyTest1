﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace MyTest1
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The RecordingSale recording.
    /// </summary>
    [TestModule("0ef59385-dff3-4fcd-af02-c263e8feeb28", ModuleType.Recording, 1)]
    public partial class RecordingSale : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyTest1Repository repository.
        /// </summary>
        public static MyTest1Repository repo = MyTest1Repository.Instance;

        static RecordingSale instance = new RecordingSale();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public RecordingSale()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static RecordingSale Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'ApplicationUnderTest.ProductSale.Product' at Center.", repo.ApplicationUnderTest.ProductSale.ProductInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.ProductSale.Product.MoveTo();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Homefeatured.AddToCart' at 59;19.", repo.ApplicationUnderTest.Homefeatured.AddToCartInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.Homefeatured.AddToCart.Click("59;19");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ContinueShopping' at 68;18.", repo.ApplicationUnderTest.ContinueShoppingInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.ContinueShopping.Click("68;18");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'ApplicationUnderTest.ProductSale.Product1' at Center.", repo.ApplicationUnderTest.ProductSale.Product1Info, new RecordItemIndex(3));
            repo.ApplicationUnderTest.ProductSale.Product1.MoveTo();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Homefeatured.AddToCart' at 48;10.", repo.ApplicationUnderTest.Homefeatured.AddToCartInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.Homefeatured.AddToCart.Click("48;10");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ContinueShopping' at 108;16.", repo.ApplicationUnderTest.ContinueShoppingInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.ContinueShopping.Click("108;16");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'ApplicationUnderTest.Cart' at Center.", repo.ApplicationUnderTest.CartInfo, new RecordItemIndex(6));
            repo.ApplicationUnderTest.Cart.MoveTo();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Products.SpanTagCheckOut' at 77;19.", repo.ApplicationUnderTest.Products.SpanTagCheckOutInfo, new RecordItemIndex(7));
            repo.ApplicationUnderTest.Products.SpanTagCheckOut.Click("77;19");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.CenterColumn1.ProceedToCheckout1' at 87;20.", repo.ApplicationUnderTest.CenterColumn1.ProceedToCheckout1Info, new RecordItemIndex(8));
            repo.ApplicationUnderTest.CenterColumn1.ProceedToCheckout1.Click("87;20");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.CenterColumn1.ProceedToCheckout' at 31;25.", repo.ApplicationUnderTest.CenterColumn1.ProceedToCheckoutInfo, new RecordItemIndex(9));
            repo.ApplicationUnderTest.CenterColumn1.ProceedToCheckout.Click("31;25");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Products.InputTagCgv' at 4;7.", repo.ApplicationUnderTest.Products.InputTagCgvInfo, new RecordItemIndex(10));
            repo.ApplicationUnderTest.Products.InputTagCgv.Click("4;7");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.SpanTagProceedToCheckout1' at 84;10.", repo.ApplicationUnderTest.SpanTagProceedToCheckout1Info, new RecordItemIndex(11));
            repo.ApplicationUnderTest.SpanTagProceedToCheckout1.Click("84;10");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.CenterColumn1.PayByBankWire' at 498;53.", repo.ApplicationUnderTest.CenterColumn1.PayByBankWireInfo, new RecordItemIndex(12));
            repo.ApplicationUnderTest.CenterColumn1.PayByBankWire.Click("498;53");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.IConfirmMyOrder' at 47;29.", repo.ApplicationUnderTest.IConfirmMyOrderInfo, new RecordItemIndex(13));
            repo.ApplicationUnderTest.IConfirmMyOrder.Click("47;29");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'ApplicationUnderTest.CenterColumn1.YourOrderOnMyStoreIsComplete'.", repo.ApplicationUnderTest.CenterColumn1.YourOrderOnMyStoreIsCompleteInfo, new RecordItemIndex(14));
            Validate.AttributeEqual(repo.ApplicationUnderTest.CenterColumn1.YourOrderOnMyStoreIsCompleteInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
