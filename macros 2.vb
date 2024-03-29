Private Sub CommandButton1_Click()
    Worksheets(1).Range("A1:A10").Value = "Hello World!!"
    
    'Assigning a background color to a cells
    Worksheets(1).Range("A1:A10").Interior.Color = RGB(89, 155, 190)
    
    ' Shrink the text that it can fits in the cell
    Worksheets(1).Range("A1:A10").ShrinkToFit = False
    
    ' AutoFit of the column
    Worksheets(1).Range("A1:A10").Columns.AutoFit
    
    ' spliting the "H,e,l,l,o, ,W,o,r,l,d,!,!" by commas
    ' making them an array
    greet = Split("H,e,l,l,o, ,W,o,r,l,d,!,!", ",")
    
    'MsgBox greet(0)
    'MsgBox UBound(greet)
    
    ' Assigning each letter to one cell: way 1
    For i = 0 To UBound(greet)
        Worksheets(1).Cells(i + 1, 8).HorizontalAlignment = xlHAlignCenter
        Worksheets(1).Cells(i + 1, 8).Value = greet(i)
    Next i
    Worksheets(1).Range("H1:H13").Columns.AutoFit
    
    ' Assigning each letter to one cell: way 2
    For i = 0 To UBound(greet)
        Worksheets(1).Range("J" & i + 1).HorizontalAlignment = xlHAlignCenter
        Worksheets(1).Range("J" & i + 1).Value = greet(i)
    Next i
    Worksheets(1).Range("J1:J13").Columns.AutoFit
    
    ' Assigning to the cells numbers from 1 to 10
    For i = 1 To 10
        Worksheets(1).Range("B" & i).Value = i
    Next i
    
    ' center alignment
    Worksheets(1).Range("B1:B10").HorizontalAlignment = xlHAlignCenter
    
    ' ------------------------
    ' Excercise: Make a sum (A20:B40)
    ' Generating values automatic
    For c = 1 To 2
        For r = 20 To 40
            Worksheets(1).Cells(r, c).Value = Round(Rnd() * 100, 2)
        Next r
    Next c
    
    ' Summing up all the values
    Sum = 0
    For c = 1 To 2
        For r = 20 To 40
            Worksheets(1).Cells(r, c).NumberFormat = "0.00"
            Worksheets(1).Cells(r, c).HorizontalAlignment = xlHAlignCenter
            Sum = Sum + Worksheets(1).Cells(r, c).Value
        Next r
    Next c
    
    ' Assigning the sum to the cell
    Worksheets(1).Range("C40").Value = Sum
    
    ' Second way to make the sum
    Range("C41").Value = Application.Sum(Range(Cells(20, 1), Cells(40, 2)))
    
    ' Third way to make the sum
    Range("C42").Value = Application.Sum(Range("A20:B40"))
    
    ' Fourth way to make the sum
    x = WorksheetFunction.Sum(Worksheets(1).Range("A20:A40,B20:B40"))
    Worksheets(1).Range("C43").Value = x
    
    ' Assing a formula to cell c44 to sum the cells A20 to A40
    Worksheets(1).Range("C44").Formula = "=SUM(A20:B40)"
    
    ' Fill in cells A50:A60 and B50:B60 with random numbers
    Worksheets(1).Range("A50:B60").HorizontalAlignment = xlHAlignCenter
    Worksheets(1).Range("A50:B60").Formula = "=RANDBETWEEN(0,100)"
    
    ' Insert a "scatter" chart in D50 for the data recorded in A50:A60 and B50:B60
    

End Sub
