'********************************************************************
'
' Download evaluation version: https://bytescout.com/download/web-installer
'
' Signup Cloud API free trial: https://secure.bytescout.com/users/sign_up
'
' Copyright © 2017 ByteScout Inc. All rights reserved.
' http://www.bytescout.com
'                                                                   
'********************************************************************


Imports Bytescout.BarCode

Module Module1

    Sub Main()
        ' Create new barcode
        Dim barcode As New Barcode()

        ' Set symbology
        Barcode.Symbology = SymbologyType.Codabar
        ' Set value
        Barcode.Value = "123456"

        ' Set bar height
        barcode.BarHeight = 500

        ' Save barcode to image
        Barcode.SaveImage("result.png")

        ' Show image in default image viewer
        Process.Start("result.png")

    End Sub

End Module
