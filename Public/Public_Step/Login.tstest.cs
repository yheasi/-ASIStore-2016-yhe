using Telerik.TestingFramework.Controls.KendoUI;
using Telerik.WebAii.Controls.Html;
using Telerik.WebAii.Controls.Xaml;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using ArtOfTest.Common.UnitTesting;
using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.Controls.HtmlControls;
using ArtOfTest.WebAii.Controls.HtmlControls.HtmlAsserts;
using ArtOfTest.WebAii.Design;
using ArtOfTest.WebAii.Design.Execution;
using ArtOfTest.WebAii.ObjectModel;
using ArtOfTest.WebAii.Silverlight;
using ArtOfTest.WebAii.Silverlight.UI;

namespace Distributor_Membership__Staging_
{

    public class Login : BaseWebAiiTest
    {
        #region [ Dynamic Pages Reference ]

        private Pages _pages;

        /// <summary>
        /// Gets the Pages object that has references
        /// to all the elements, frames or regions
        /// in this project.
        /// </summary>
        public Pages Pages
        {
            get
            {
                if (_pages == null)
                {
                    _pages = new Pages(Manager.Current);
                }
                return _pages;
            }
        }

        #endregion
        
        // Add your test methods here...
    
        [CodedStep(@"Enter random gmail in 'EmailText'")]
        public void Purchase_As_Guest_CodedStep()
        {
            // Enter random gmail in 'EmailText'
            
            StringBuilder sb = new StringBuilder();
            Random rnd = new Random();
            char ch;
            for (int ctr = 0; ctr < 9; ctr++)
             
            {
             
            ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * rnd.NextDouble() + 97)));
             
            sb.Append(ch);
             
            }
             
            sb.Append("@gmail.com");
             
            Actions.SetText(Pages.DistributorStoreLogin6.EmailText, sb.ToString());
            
        }
    }
}
