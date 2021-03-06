﻿using Umbraco.Core.Models;
using Umbraco.Web;
using Umbraco.Web.Models;
using WebBlocks.API;
using WebBlocks.Providers;
using WebBlocks.Utilities.Cache;
using WebBlocks.Utilities.Umbraco;
using WebBlocks.Utilities.WebBlocks;

namespace WebBlocks.ViewTemplates
{
    public class WebBlocksTemplatePage : Umbraco.Web.Mvc.UmbracoTemplatePage
    {
        new public dynamic CurrentPage
        {
            get
            {
                return WebBlocksUtility.CurrentPageContent.AsDynamic();
            }
        }

        public dynamic CurrentBlock
        {
            get
            {
                //return published model
                return WebBlocksUtility.CurrentBlockContent.AsDynamic();
            }
        }

        public WebBlocksAPI WebBlocks = new WebBlocksAPI();

        public bool IsInBuilder()
        {
            return WebBlocksUtility.IsInBuilder;
        }


        public override void Execute()
        {
            
        }
    }
}