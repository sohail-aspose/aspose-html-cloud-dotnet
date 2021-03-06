﻿using System;
using System.IO;
using Com.Aspose.Storage.Api;
using Com.Aspose.Html.Api;
using Com.Aspose.Html.Api.Interfaces;

namespace Aspose.HTML.Cloud.Examples.SDK.HtmlDocument
{
    /// <summary>
    /// Aspose.HTML Cloud for .NET SDK - examples.
    /// =========================================
    /// Example that demonstrates how to extract the HTML fragments by XPath query 
    /// from the HTML document in the cloud storage.
    /// </summary>
    public class ExtractHtmlFragmentsByXPath : ISdkRunner
    {
        public void Run()
        {
            var name = "testpage3_embcss.html";
            var xPath = "//ol/li";
            StorageApi storageApi = new StorageApi(CommonSettings.AppKey, CommonSettings.AppSID, CommonSettings.BasePath);
            // Upload source file to cloud storage (default is AmazonS3)
            var srcPath = Path.Combine(CommonSettings.DataFolder, name);
            if (File.Exists(srcPath))
                storageApi.PutCreate(name, null, null, File.ReadAllBytes(srcPath));
            else
                throw new Exception(string.Format("Error: file {0} not found.", srcPath));

            var response = storageApi.GetIsExist(name, null, null);

            IDocumentApi docApi = new DocumentApi(CommonSettings.AppKey, CommonSettings.AppSID, CommonSettings.BasePath);
            // call the SDK method that returns a query result in the response stream.
            Stream stream = docApi.GetDocumentFragmentByXPath(name, xPath, "json", null, null);
            if (stream != null && typeof(FileStream) == stream.GetType())
            {
                string outFile = $"{Path.GetFileNameWithoutExtension(name)}_fragments.json";
                string outPath = Path.Combine(CommonSettings.OutDirectory, outFile);
                using (FileStream fstr = new FileStream(outPath, FileMode.Create, FileAccess.Write))
                {
                    stream.Position = 0;
                    stream.CopyTo(fstr);
                    fstr.Flush();
                    Console.WriteLine(string.Format("\nResult file downloaded to: {0}", outPath));
                }
            }
        }
    }
}
