Public Module TerrainGeneration
    Function GenerateOverachingGrid(ByRef size_in_x As Integer, ByRef size_in_y As Integer) As Integer(,)
        Dim arr(-1, -1) As Integer
        ReDim arr(size_in_x, size_in_y)
        Randomize()
        Dim randomGenerator As New Random
        For Each value In arr
            value = randomGenerator.Next(-5, 10)
        Next
        Return arr
    End Function

    Function Smoothgrid(ByRef input As Integer(,))
        For Each value As Integer In input

        Next
    End Function
End Module

Public Module SettlementGeneration

End Module

Public Module PersonGeneration
    Public Class NPCGeneration


    End Class
End Module
