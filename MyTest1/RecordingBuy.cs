///////////////////////////////////////////////////////////////////////////////
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
    ///The RecordingBuy recording.
    /// </summary>
    [TestModule("3e6fbc0d-ab01-4d56-9b31-a369d607c41c", ModuleType.Recording, 1)]
    public partial class RecordingBuy : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyTest1Repository repository.
        /// </summary>
        public static MyTest1Repository repo = MyTest1Repository.Instance;

        static RecordingBuy instance = new RecordingBuy();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public RecordingBuy()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static RecordingBuy Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'ApplicationUnderTest.Products.product' at Center.", repo.ApplicationUnderTest.Products.productInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.Products.product.MoveTo();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Homefeatured.AddToCart' at 21;13.", repo.ApplicationUnderTest.Homefeatured.AddToCartInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.Homefeatured.AddToCart.Click("21;13");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ContinueShopping' at 84;14.", repo.ApplicationUnderTest.ContinueShoppingInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.ContinueShopping.Click("84;14");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'ApplicationUnderTest.Products.product2' at Center.", repo.ApplicationUnderTest.Products.product2Info, new RecordItemIndex(3));
            repo.ApplicationUnderTest.Products.product2.MoveTo();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Homefeatured.AddToCart' at 61;9.", repo.ApplicationUnderTest.Homefeatured.AddToCartInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.Homefeatured.AddToCart.Click("61;9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ContinueShopping' at 53;14.", repo.ApplicationUnderTest.ContinueShoppingInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.ContinueShopping.Click("53;14");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'ApplicationUnderTest.Cart' at Center.", repo.ApplicationUnderTest.CartInfo, new RecordItemIndex(6));
            repo.ApplicationUnderTest.Cart.MoveTo();
            Delay.Milliseconds(0);
            
            totalProduct(repo.ApplicationUnderTest.Products.ProductsInfo, repo.ApplicationUnderTest.Products.TotalProductInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Products.SpanTagCheckOut' at 126;3.", repo.ApplicationUnderTest.Products.SpanTagCheckOutInfo, new RecordItemIndex(8));
            repo.ApplicationUnderTest.Products.SpanTagCheckOut.Click("126;3");
            Delay.Milliseconds(0);
            
            total(repo.ApplicationUnderTest.Products.TotalProductsInfo, repo.ApplicationUnderTest.Products.TotalShippingInfo, repo.ApplicationUnderTest.Products.TaxInfo, repo.ApplicationUnderTest.Products.TotalInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.CenterColumn1.ProceedToCheckout1' at 16;18.", repo.ApplicationUnderTest.CenterColumn1.ProceedToCheckout1Info, new RecordItemIndex(10));
            repo.ApplicationUnderTest.CenterColumn1.ProceedToCheckout1.Click("16;18");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.CenterColumn1.ProceedToCheckout' at 55;13.", repo.ApplicationUnderTest.CenterColumn1.ProceedToCheckoutInfo, new RecordItemIndex(11));
            repo.ApplicationUnderTest.CenterColumn1.ProceedToCheckout.Click("55;13");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Products.InputTagCgv' at 6;10.", repo.ApplicationUnderTest.Products.InputTagCgvInfo, new RecordItemIndex(12));
            repo.ApplicationUnderTest.Products.InputTagCgv.Click("6;10");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.SpanTagProceedToCheckout1' at 124;27.", repo.ApplicationUnderTest.SpanTagProceedToCheckout1Info, new RecordItemIndex(13));
            repo.ApplicationUnderTest.SpanTagProceedToCheckout1.Click("124;27");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.CenterColumn1.PayByBankWire' at 313;15.", repo.ApplicationUnderTest.CenterColumn1.PayByBankWireInfo, new RecordItemIndex(14));
            repo.ApplicationUnderTest.CenterColumn1.PayByBankWire.Click("313;15");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.IConfirmMyOrder' at 92;17.", repo.ApplicationUnderTest.IConfirmMyOrderInfo, new RecordItemIndex(15));
            repo.ApplicationUnderTest.IConfirmMyOrder.Click("92;17");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'ApplicationUnderTest.CenterColumn1.YourOrderOnMyStoreIsComplete'.", repo.ApplicationUnderTest.CenterColumn1.YourOrderOnMyStoreIsCompleteInfo, new RecordItemIndex(16));
            Validate.AttributeEqual(repo.ApplicationUnderTest.CenterColumn1.YourOrderOnMyStoreIsCompleteInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
