﻿using Aspose.BarCode.Generation;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.BarCode.Examples.CSharp.ManageAndOptimizeBarCodeRecognition
{
    class ECCTypeToEnCodeBarcode
    {
        public static void Run()
        {
            // ExStart:ECCTypeToEnCodeBarcode
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageAndOptimizeBarcodeRecognition();

            // Generate barcode (Sample 1) Initialize BarCode builder class object
            BarCodeBuilder builder1 = new BarCodeBuilder("BASE-41 ONLY ALPHA, DIGITS AND PUNCTUATION",EncodeTypes.DataMatrix)
            {
                // Set ECC level
                DatamatrixEcc = DataMatrixEccType.Ecc050
            };

            builder1.Save(dataDir + "SampleBarcode1_out.png");
            // Generate barcode (Sample 2) Initialize BarCode builder class object and Set ECC level.
            BarCodeBuilder builder2 = new BarCodeBuilder("BASE-41 ONLY ALPHA, DIGITS AND PUNCTUATION.", EncodeTypes.DataMatrix)
            {
                DatamatrixEcc = DataMatrixEccType.Ecc050,
            };
            builder2.Save(dataDir + "SampleBarcode2_out.png");
            // ExEnd:ECCTypeToEnCodeBarcode
        }
    }
}

