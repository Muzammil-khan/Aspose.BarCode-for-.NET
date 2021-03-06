﻿using Aspose.BarCode.Generation;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/
namespace Aspose.BarCode.Examples.CSharp.ManageBarCodes
{
    class SwissPostParcelSymbology
    {
        public static void Run()
        {
            // ExStart:SwissPostParcelSymbology
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageBarCodes();

            // Generate the barcode and Save barcode on local
            BarCodeBuilder builder = new BarCodeBuilder("0610", EncodeTypes.SwissPostParcel);
            builder.Save(dataDir + "SwissPostParcelSymbology_out.png");
            // ExEnd:SwissPostParcelSymbology
        }
    }
}