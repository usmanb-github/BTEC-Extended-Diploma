Public Class MyClass1

    'Functions
    Public Function Labour(ByVal h As Double)
        Labour = Format((h) * (40), "0.00")
    End Function
    Public Function Travel(ByVal mile As Double)
        Travel = Format((mile) * (1), "0.00")
    End Function
    Public Function PlasticPipes(ByVal mile As Double)
        PlasticPipes = Format((mile) * (2), "0.00")
    End Function
    Public Function CopperPipes(ByVal mile As Double)
        CopperPipes = Format((mile) * (3), "0.00")
    End Function
    Public Function ChromePipes(ByVal mile As Double)
        ChromePipes = Format((mile) * (4), "0.00")
    End Function
End Class

