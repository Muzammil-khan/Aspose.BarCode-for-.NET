﻿using System;
using System.Diagnostics;
using System.Drawing.Imaging;
using Aspose.BarCode.Generation;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.BarCode.Examples.CSharp.CreateAndManageTwoDBarcodes
{
    class CreateMultipleMacroPdf417
    {
        public static void Run()
        {
            //ExStart:CreateMultipleMacroPdf417
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_CreateAndManage2DBarCodes();

            // Create array for storing multiple barcodes
            const int nSize = 4;
            string[] lstCodeText = new[] { "code-1", "code-2", "code-3", "code-4" };
            const int strFileId = 1;

            // Instantiate barcode object and set CodeText & Barcode Symbology
            using (BarCodeBuilder builder = new BarCodeBuilder("1234567890",EncodeTypes.MacroPdf417))
            {
                for (int nCount = 1; nCount <= nSize; nCount++)
                {
                    builder.CodeText = lstCodeText[nCount - 1];

                    // FileID should be same for all the generated bar codes
                    builder.MacroPdf417FileID = strFileId;

                    // Assign segmentID in increasing order (1,2,3,....) and Set the segments count
                    builder.MacroPdf417SegmentID = nCount;
                    builder.MacroPdf417SegmentsCount = nSize;
                   
                    try
                    {
                        // Save the barcode (fileid_segmentid.png)
                        builder.Save(dataDir + strFileId + "_" + nCount + "_out.png", ImageFormat.Png);
                        Process.Start(dataDir + strFileId + "_" + nCount + "_out.png");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            //ExEnd:CreateMultipleMacroPdf417
        }
    }
}