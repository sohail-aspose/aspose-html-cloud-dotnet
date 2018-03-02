﻿using System.IO;
using Com.Aspose.Html.Api;

namespace Aspose.HTML.Cloud.Examples.SDK.HtmlDocument
{
    public class GetDocumentSdk : ISdkRunner
    {
        public void Run()
        {
            var name = "zero.txt";
            string folder = null;
            string storage = null;

            DocumentApi api = new DocumentApi(CommonSettings.AppKey, CommonSettings.AppSID, CommonSettings.BasePath);
            var result = api.GetDocument(name, storage, folder);
            if (result != null && typeof(FileStream) == result.GetType())
            {

            }
        }
    }
}
