﻿using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Aspose.HTML.Cloud.Sdk.Tests.Base;
using Com.Aspose.Storage.Model;

namespace Aspose.HTML.Cloud.Sdk.Tests.Conversion
{
    [TestClass]
    public class ConversionStorageFileTest : BaseTestContext
    {
        private readonly string dataFolder = DirectoryHelper.GetPath("TestData", "HTML");

        [TestMethod]
        public void Test_GetHtmlConvert_Pdf_StorageToStream()
        {
            string name = "testpage1.html";
            string folder = "TempHtml";

            string srcPath = Path.Combine(dataFolder, name);
            string path = string.Format("{0}/{1}", folder, name);
            this.StorageApi.PutCreate(path, null, null, File.ReadAllBytes(srcPath));
            FileExistResponse resp = this.StorageApi.GetIsExist(path, null, null);
            Assert.IsTrue(resp.FileExist.IsExist);

            var response = this.ConversionApi.GetConvertDocumentToPdf(name, 800, 1200, null, null, null, null, folder);
            Assert.IsNotNull(response);
            Assert.IsTrue(response.GetType() == typeof(FileStream));
            Assert.IsTrue(File.Exists(((FileStream)response).Name));
        }

        [TestMethod]
        public void Test_GetHtmlConvert_Jpeg_StorageToStream()
        {
            string name = "testpage1.html";
            string folder = "TempHtml";

            string srcPath = Path.Combine(dataFolder, name);
            string path = string.Format("{0}/{1}", folder, name);
            this.StorageApi.PutCreate(path, null, null, File.ReadAllBytes(srcPath));
            FileExistResponse resp = this.StorageApi.GetIsExist(path, null, null);
            Assert.IsTrue(resp.FileExist.IsExist);

            var response = this.ConversionApi.GetConvertDocumentToImage(name, "jpeg", 800, 1200, null, null, null, null, null, null, folder);
            Assert.IsNotNull(response);
            Assert.IsTrue(response.GetType() == typeof(FileStream));
            Assert.IsTrue(File.Exists(((FileStream)response).Name));
        }
    }
}
