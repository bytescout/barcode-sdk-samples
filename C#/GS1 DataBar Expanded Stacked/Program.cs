//*******************************************************************
//
// Download evaluation version: https://bytescout.com/download/web-installer
//
// Signup Cloud API free trial: https://secure.bytescout.com/users/sign_up
//
// Copyright © 2017 ByteScout Inc. All rights reserved.
// http://www.bytescout.com
//                                                                   
//*******************************************************************


using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

using Bytescout.BarCode;

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create new barcode
            Barcode barcode = new Barcode();

            // Set symbology
            barcode.Symbology = SymbologyType.GS1_DataBar_Expanded_Stacked;
            // Set value
            barcode.Value = "(01)04512345678906(3930)3921980(17)091225(10)10000";
            
            // Set the number of segments in line
			barcode.Options.GS1ExpandedStackedSegmentsNumber = 6;

            // Save barcode to image
            barcode.SaveImage("result.png");

            // Show image in default image viewer
            Process.Start("result.png");
        }
    }
}
