Public Class TPoint
    Public X As Double
    Public Y As Double
    Public Z As Double
    Public W As Double

    Public Sub SetP(ByVal PX As Double, ByVal PY As Double, ByVal PZ As Double, ByVal PW As Double)
        X = PX
        Y = PY
        Z = PZ
        W = PW
    End Sub

End Class

Public Class TArrPoint
    Public N As Integer
    Public Elmt() As TPoint

    Sub Init()
        N = 0
        ReDim Elmt(-1)
    End Sub

    Public Overloads Sub InsLast(ByVal P As TPoint)
        ReDim Preserve Elmt(N)

        Elmt(N) = P
        N = N + 1
    End Sub

End Class

Public Class TLine
    Public P1 As Integer
    Public P2 As Integer

    Public Sub SetLine(ByVal L1 As Integer, ByVal L2 As Integer)
        P1 = L1
        P2 = L2
    End Sub

End Class

Public Class TArrLine
    Public N As Integer
    Public Elmt() As TLine

    Sub Init()
        N = 0
        ReDim Elmt(-1)
    End Sub

    Public Overloads Sub InsLast(ByVal P As TLine)
        ReDim Preserve Elmt(N)

        Elmt(N) = P
        N = N + 1
    End Sub

End Class

Public Class TPoly
    Public E1 As Integer
    Public E2 As Integer
    Public E3 As Integer

    Public Sub SetPoly(ByVal idx1 As Integer, ByVal idx2 As Integer, ByVal idx3 As Integer)
        E1 = idx1
        E2 = idx2
        E3 = idx3
    End Sub

End Class

Public Class TArrPoly
    Public N As Integer
    Public Elmt() As TPoly

    Sub Init()
        N = 0
        ReDim Elmt(-1)
    End Sub

    Public Overloads Sub InsLast(ByVal P As TPoly)
        ReDim Preserve Elmt(N)

        Elmt(N) = P
        N = N + 1
    End Sub

End Class

Public Class TRtt
    Public Axis As Integer
    Public Deg As Double

    Public Sub SetRot(ByVal A As Integer, ByVal D As Double)
        Axis = A
        Deg = D
    End Sub

End Class

Public Class TArrRtt
    Public N As Integer
    Public Elmt() As TRtt

    Sub Init()
        N = 0
        ReDim Elmt(-1)
    End Sub

    Public Overloads Sub InsLast(ByVal P As TRtt)
        ReDim Preserve Elmt(N)

        Elmt(N) = P
        N = N + 1
    End Sub

    Sub DelLast()
        N = N - 1
    End Sub

End Class