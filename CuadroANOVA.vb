﻿Module CuadroANOVA
    Public Sub cuadroANOVAmet()
        On Error Resume Next

        Dim filaInicial As String
        Dim filaFinal As String
        Dim titulo As String

        filaInicial = Globals.ThisAddIn.Application.ActiveSheet.Cells(1, 1).Value
        filaFinal = Globals.ThisAddIn.Application.ActiveSheet.Cells(29, 1).Value
        titulo = Globals.ThisAddIn.Application.ActiveSheet.Cells(1, 5).Value

        With Globals.ThisAddIn.Application
            If filaInicial = "DETERMINACION DE BETAS" And filaFinal = "SEC" _
            And titulo = "PRUEBAS DE HIPOTESIS, TABLAS RESUMEN, CUADROS ANOVA, P VALOR Y INTERVALOS DE CONFIANZA" Then

                .Cells(Globals.ThisAddIn.Application.ActiveSheet.Rows.Count, 5).Select()
                .ActiveCell.End(Microsoft.Office.Interop.Excel.XlDirection.xlUp).Select()
                .ActiveCell.Offset(3, 0).Select()
                .ActiveCell.Value = "AV"
                .ActiveCell.AddComment("ANÁLISIS DE LA VARIANZA.")
                With .ActiveCell
                    .HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter
                    .Font.Bold = True
                    .Font.ColorIndex = 2
                    .Interior.ColorIndex = 49
                End With

                .ActiveCell.Offset(0, 1).Value = "SC"
                .ActiveCell.Offset(0, 1).AddComment("SUMA DE CUADRADOS.")
                With .ActiveCell.Offset(0, 1)
                    .HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter
                    .Font.Bold = True
                    .Font.ColorIndex = 2
                    .Interior.ColorIndex = 49
                End With

                .ActiveCell.Offset(0, 2).Value = "GL"
                .ActiveCell.Offset(0, 2).AddComment("GRADOS DE LIBERTAD.")
                With .ActiveCell.Offset(0, 2)
                    .HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter
                    .Font.Bold = True
                    .Font.ColorIndex = 2
                    .Interior.ColorIndex = 49
                End With

                .ActiveCell.Offset(0, 3).Value = "SP"
                .ActiveCell.Offset(0, 3).AddComment("SUMA DE PROMEDIOS.")
                With .ActiveCell.Offset(0, 3)
                    .HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter
                    .Font.Bold = True
                    .Font.ColorIndex = 2
                    .Interior.ColorIndex = 49
                End With

                .ActiveCell.Offset(0, 4).Value = "F"
                .ActiveCell.Offset(0, 4).AddComment("PRUEBA F.")
                With .ActiveCell.Offset(0, 4)
                    .HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter
                    .Font.Bold = True
                    .Font.ColorIndex = 2
                    .Interior.ColorIndex = 49
                End With

                .ActiveCell.Offset(0, 5).Value = "Prob."
                .ActiveCell.Offset(0, 5).AddComment("PROBABILIDAD DE F")
                With .ActiveCell.Offset(0, 5)
                    .HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter
                    .Font.Bold = True
                    .Font.ColorIndex = 2
                    .Interior.ColorIndex = 49
                End With
                'FILA REGRESION
                .ActiveCell.Offset(1, 0).Value = "Regresión"
                .ActiveCell.Offset(1, 1).FormulaR1C1 = "=R29C2"
                .ActiveCell.Offset(1, 2).FormulaR1C1 = "1"
                .ActiveCell.Offset(1, 3).Value = .ActiveCell.Offset(1, 1).Value / .ActiveCell.Offset(1, 2).Value
                .ActiveCell.Offset(1, 4).FormulaR1C1 = "=RC[-1]/R[1]C[-1]"
                .ActiveCell.Offset(1, 5).FormulaR1C1 = "=F.DIST.RT(RC[-1],RC[-3],R[1]C[-3])"

                'FILA RESIDUOS
                .ActiveCell.Offset(2, 0).Value = "Residuos"
                .ActiveCell.Offset(2, 1).FormulaR1C1 = "=R28C2"
                .ActiveCell.Offset(2, 2).FormulaR1C1 = "=R10C2"
                .ActiveCell.Offset(2, 3).Value = .ActiveCell.Offset(2, 1).Value / .ActiveCell.Offset(2, 2).Value

                .Range(.Selection, .Selection.End(Microsoft.Office.Interop.Excel.XlDirection.xlToRight)).Select()
                .Range(.Selection, .Selection.End(Microsoft.Office.Interop.Excel.XlDirection.xlDown)).Select()
                .Selection.Borders(Microsoft.Office.Interop.Excel.XlBordersIndex.xlDiagonalDown).LineStyle = Microsoft.Office.Interop.Excel.Constants.xlNone
                .Selection.Borders(Microsoft.Office.Interop.Excel.XlBordersIndex.xlDiagonalUp).LineStyle = Microsoft.Office.Interop.Excel.Constants.xlNone
                With .Selection.Borders(Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeLeft)
                    .LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous
                    .ColorIndex = Microsoft.Office.Interop.Excel.Constants.xlAutomatic
                    .TintAndShade = 0
                    .Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlMedium
                End With
                With .Selection.Borders(Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeTop)
                    .LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous
                    .ColorIndex = Microsoft.Office.Interop.Excel.Constants.xlAutomatic
                    .TintAndShade = 0
                    .Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlMedium
                End With
                With .Selection.Borders(Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeBottom)
                    .LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous
                    .ColorIndex = Microsoft.Office.Interop.Excel.Constants.xlAutomatic
                    .TintAndShade = 0
                    .Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlMedium
                End With
                With .Selection.Borders(Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeRight)
                    .LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous
                    .ColorIndex = Microsoft.Office.Interop.Excel.Constants.xlAutomatic
                    .TintAndShade = 0
                    .Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlMedium
                End With
                With .Selection.Borders(Microsoft.Office.Interop.Excel.XlBordersIndex.xlInsideVertical)
                    .LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous
                    .ColorIndex = Microsoft.Office.Interop.Excel.Constants.xlAutomatic
                    .TintAndShade = 0
                    .Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlMedium
                End With
                With .Selection.Borders(Microsoft.Office.Interop.Excel.XlBordersIndex.xlInsideHorizontal)
                    .LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous
                    .ColorIndex = Microsoft.Office.Interop.Excel.Constants.xlAutomatic
                    .TintAndShade = 0
                    .Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlMedium
                End With
            Else
                MsgBox("LA HOJA NO ESTA LISTA PARA EJECUTAR ESTE PROCEDIMIENTO")
            End If

        End With
    End Sub
End Module
