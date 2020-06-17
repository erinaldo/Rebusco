Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.IO
Imports System.Reflection
Imports ClosedXML.Excel

Public Class ExcelWorkbookService

    Public Shared Function GenerateExcel(Of TElement) _
        (ByVal elementList As List(Of TElement), ByVal workBookName As String,
         Optional ByVal columnList As List(Of String) = Nothing) As MemoryStream

        Dim excelStream = New MemoryStream

        Dim workbook As New XLWorkbook
        Dim workSheet As IXLWorksheet = workbook.Worksheets.Add(workBookName)

        Dim Pre_propertyList = GetType(TElement).GetProperties().ToList()
        Dim propertyList As New List(Of PropertyInfo)

        For Each item In Pre_propertyList

            Dim NameAttribute As DisplayNameAttribute = CType(Attribute.GetCustomAttribute(item, GetType(DisplayNameAttribute)), DisplayNameAttribute)
            If NameAttribute IsNot Nothing Then
                propertyList.Add(item)
            End If
        Next

        If columnList Is Nothing Then
            CreateColumnHeaders(propertyList, workSheet)
        Else
            AddColumnHeaders(columnList, workSheet)
        End If

        CreateWorksheetData(propertyList, elementList, workSheet)

        workSheet.Columns.AdjustToContents()
        workbook.SaveAs(excelStream)

        Return excelStream
    End Function

    Private Shared Sub CreateWorksheetData(Of TElement)(ByVal propertyList As List(Of PropertyInfo),
                                                 ByVal elementList As List(Of TElement),
                                                 ByVal worksheet As IXLWorksheet)



        Dim row = 2
        For Each element In elementList



            Dim column = 1
            For Each propertyInfo In propertyList


                Dim value = propertyInfo.GetValue(element, Nothing)

                worksheet.Cell(row, column).Value = value
                With worksheet.Cell(row, column).Style.Border
                    .RightBorder = XLBorderStyleValues.Thin
                    .LeftBorder = XLBorderStyleValues.Thin
                    .BottomBorder = XLBorderStyleValues.Thin
                    .TopBorder = XLBorderStyleValues.Thin
                End With
                column += 1
            Next propertyInfo

            row += 1
        Next element
    End Sub

    Private Shared Sub CreateColumnHeaders(ByVal propertyList As List(Of PropertyInfo), ByVal workSheet As IXLWorksheet)

        Dim column = 1
        For Each propertyInfo In propertyList

            Dim excelColumn As IXLColumn = workSheet.Column(column)

            With workSheet.Cell(1, column)
                .Value = propertyInfo.Name
                Dim NameAttribute As DisplayNameAttribute = CType(Attribute.GetCustomAttribute(propertyInfo, GetType(DisplayNameAttribute)), DisplayNameAttribute)

                If NameAttribute IsNot Nothing Then
                    .Value = NameAttribute.DisplayName
                End If

                With .Style
                    .Alignment.Vertical = XLAlignmentVerticalValues.Center
                    .Alignment.Horizontal = XLAlignmentHorizontalValues.Center
                    .Fill.BackgroundColor = XLColor.LightGreen
                    .Font.Bold = True

                    .Border.RightBorder = XLBorderStyleValues.Thin
                    .Border.LeftBorder = XLBorderStyleValues.Thin
                    .Border.BottomBorder = XLBorderStyleValues.Thin
                    .Border.TopBorder = XLBorderStyleValues.Thin

                End With
                column += 1
            End With
        Next

    End Sub


    Private Shared Sub AddColumnHeaders(ByVal columnList As List(Of String), ByVal workSheet As IXLWorksheet)

        Dim column = 1
        For Each columnName In columnList

            Dim excelColumn As IXLColumn = workSheet.Column(column)

            With workSheet.Cell(1, column)
                .Value = columnName

                With .Style
                    .Alignment.Vertical = XLAlignmentVerticalValues.Center
                    .Alignment.Horizontal = XLAlignmentHorizontalValues.Center
                    .Fill.BackgroundColor = XLColor.LightGreen
                    .Font.Bold = True

                    .Border.RightBorder = XLBorderStyleValues.Thin
                    .Border.LeftBorder = XLBorderStyleValues.Thin
                    .Border.BottomBorder = XLBorderStyleValues.Thin
                    .Border.TopBorder = XLBorderStyleValues.Thin

                End With
                column += 1
            End With
        Next

    End Sub

End Class
