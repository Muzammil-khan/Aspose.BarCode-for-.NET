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
    class SetHeightOfBarsInDataBarStackedOmniDirectional
    {
        public static void Run()
        {
            // ExStart:SetHeightOfBarsInDataBarStackedOmniDirectional  
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageBarCodes();

            // Instantiate barcode object and Set the SymbologyType and Height and Resolution for barcode
            BarCodeBuilder builder = new BarCodeBuilder("(01)90013670000396(3200)15(11)150819",EncodeTypes.DatabarStackedOmniDirectional)
            {
                xDimension = 0.330f,
                BarHeight = 27.77f,
                Resolution = new Resolution(1200.0f, 1200.0f, ResolutionMode.Customized)
            };

            // Save the image to your system and set its image format to Jpeg
            builder.Save(dataDir + "Barheight_out.png", BarCodeImageFormat.Png);
            // ExEnd:SetHeightOfBarsInDataBarStackedOmniDirectional  
        }
    }
}
