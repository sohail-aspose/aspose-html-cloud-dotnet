# Aspose.HTML Cloud SDK for .NET [![NuGet](https://img.shields.io/nuget/v/Aspose.HTML-Cloud.svg)](https://www.nuget.org/packages/Aspose.HTML-Cloud/)
This repository contains Aspose.HTML Cloud SDK for .NET source code. This SDK allows you to work with Aspose.HTML Cloud REST APIs in your .NET applications quickly and easily, with zero initial cost.

# Key Features
* Conversion of HTML document into various formats; PDF, XPS document formats and JPEG, PNG, BMP, TIFF raster graphics formats are supported
* Conversion of MHTML document into the same formats that are supported for HTML
* Translation of HTML document between various human languages; the following language pairs are currently supported:
** English to German
** English to French
** English to Russian
** German to English
** Russian to English
* Extraction of HTML fragments using XPath queries
* Extraction of all HTML document images in a ZIP archive

See [API Reference](https://apireference.aspose.cloud/words/) for full API specification.

## How to use the SDK?
The complete source code is available in this repository folder. You can either directly use it in your project via source code or get [NuGet distribution](https://www.nuget.org/packages/Aspose.HTML-Cloud/) (recommended). For more details, please visit our [documentation website](https://docs.aspose.cloud/display/htmlcloud/Available+SDKs#AvailableSDKs-.NET).


### Prerequisites

To use Aspose HTML for Cloud .NET SDK you need to register an account with [Aspose Cloud](https://www.aspose.cloud/) and lookup/create App Key and SID at [Cloud Dashboard](https://dashboard.aspose.cloud/#/apps). There is free quota available. For more details, see [Aspose Cloud Pricing](https://purchase.aspose.cloud/pricing).


### Installation

#### Install Aspose.HTML-Cloud via NuGet

From the command line:

	nuget install Aspose.HTML-Cloud

From Package Manager:

	PM> Install-Package Aspose.HTML-Cloud

From within Visual Studio:

1. Open the Solution Explorer.
2. Right-click on a project within your solution.
3. Click on *Manage NuGet Packages...*
4. Click on the *Browse* tab and search for "Aspose.HTML-Cloud".
5. Click on the Aspose.HTML-Cloud package, select the appropriate version in the right-tab and click *Install*.

### Sample usage

The example below shows how your application have to translate the HTML document located by its URL using Aspose.HTML-Cloud library:

```csharp
using System;
using System.IO;
using Com.Aspose.Storage.Api;
using Com.Aspose.Storage.Model;
using Com.Aspose.Html.Api;

namespace MyAppNamespace
{
    public class Example
    {
        string APPKEY = "XXXXXXX"; // put here the app Key
        string APPSID = "XXXXXXX"; // put here the app SID
        string BASEPATH = "https://api.aspose.cloud/v.1.1";

        string sourceUrl = "https://www.le.ac.uk/oerresources/bdra/html/page_02.htm";
        // 
        string source_lang = "en";  // source language
        string result_lang = "fr";  // result language

        string resultFile = "page_02_en_fr.htm";

        static void Main(string[] args)
        {
            // create instance of the API class
            ITranslationApi trApi = new TranslationApi(APPKEY, APPSID, BASEPATH);
            // translate the HTML document by its URL
            Stream stream = trApi.GetTranslateDocumentByUrl(sourceUrl, source_lang, result_lang);
            // copy result to file 
            using (FileStream fs = new FileStream("page_02_en_fr.htm", FileMode.Create, FileAccess.Write))
            {
                stream.Position = 0;
                stream.CopyTo(fs);
                fs.Flush();
            }
        }
    }
}
```

## Contact Us
Your feedback is very important to us. Please feel free to contact us using our [Support Forums](https://forum.aspose.cloud/c/html).