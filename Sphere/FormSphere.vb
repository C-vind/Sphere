Public Class FormSphere
    Const Phi As Double = 3.14285714
    Const Deg2Rad As Double = Phi / 180

    Dim Bmp As Bitmap
    Dim Pr(3, 3), Vt(3, 3), St(3, 3), Rt(3, 3), Tr(3, 3), AB(1), AC(1) As Double
    Dim Lat, Lon, Temp, Count, E1, E2, E3, Pt2, Pt3, A, B, C,
        ULat, ULon, URad, Rot, posneg, Trans, dis, disx, disy, disz As Integer
    Dim R, tetaLa, tetaLo, deg, PX, PY, PZ As Double
    Dim P As New TPoint
    Dim APoint, Vp, Vr, Vs As New TArrPoint
    Dim L1, L2, L3 As New TLine
    Dim ALine As New TArrLine
    Dim Poly As New TPoly
    Dim APoly As New TArrPoly
    Dim Rtt As New TRtt
    Dim ARtt As New TArrRtt

    Public Sub SetColMatrix(ByRef M(,) As Double, ByVal Col As Integer, ByVal A As Double, ByVal B As Double, ByVal C As Double, ByVal D As Double)
        M(0, Col) = A
        M(1, Col) = B
        M(2, Col) = C
        M(3, Col) = D
    End Sub

    Public Sub InitMatrix(ByVal M(,) As Double)
        SetColMatrix(M, 0, 1, 0, 0, 0)
        SetColMatrix(M, 1, 0, 1, 0, 0)
        SetColMatrix(M, 2, 0, 0, 1, 0)
        SetColMatrix(M, 3, 0, 0, 0, 1)
    End Sub

    Function MultiplyMatrix(ByVal P As TPoint, ByVal M(,) As Double) As TPoint
        Dim temp As New TPoint
        temp.X = P.X * M(0, 0) + P.Y * M(1, 0) + P.Z * M(2, 0) + P.W * M(3, 0)
        temp.Y = P.X * M(0, 1) + P.Y * M(1, 1) + P.Z * M(2, 1) + P.W * M(3, 1)
        temp.Z = P.X * M(0, 2) + P.Y * M(1, 2) + P.Z * M(2, 2) + P.W * M(3, 2)
        temp.W = P.X * M(0, 3) + P.Y * M(1, 3) + P.Z * M(2, 3) + P.W * M(3, 3)
        Return temp
    End Function

    Private Sub FormSphere_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        InitMatrix(Pr)
        Pr(2, 3) = -0.225

        InitMatrix(Vt)
        Vt(2, 2) = 0

        SetColMatrix(St, 0, 111, 0, 0, 222)
        SetColMatrix(St, 1, 0, -111, 0, 222)
        SetColMatrix(St, 2, 0, 0, 0, 0)
        SetColMatrix(St, 3, 0, 0, 0, 1)

        Rot = 0
        deg = 0
        URad = 0
        ULat = 0
        ULon = 0
        ARtt.Init()

        disx = 0
        disy = 0
        disz = 0
        InitMatrix(Tr)

        LblCenter.Text = "Center Coordinate : ( 0, 0, 0 )"
        DrawSphere()
    End Sub

    Private Sub BtnIncRad_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnIncRad.MouseDown
        Rot = 0
        URad = 1
        TimerDraw.Enabled = True
    End Sub

    Private Sub BtnIncRad_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnIncRad.MouseUp
        TimerDraw.Enabled = False
        URad = 0
    End Sub

    Private Sub BtnDecRad_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnDecRad.MouseDown
        Rot = 0
        URad = -1
        TimerDraw.Enabled = True
    End Sub

    Private Sub BtnDecRad_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnDecRad.MouseUp
        TimerDraw.Enabled = False
        URad = 0
    End Sub

    Private Sub BtnResRad_Click(sender As Object, e As EventArgs) Handles BtnResRad.Click
        TxtRad.Text = 1
        DrawSphere()
    End Sub

    Private Sub BtnIncLat_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnIncLat.MouseDown
        Rot = 0
        ULat = 1
        TimerDraw.Enabled = True
    End Sub

    Private Sub BtnIncLat_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnIncLat.MouseUp
        TimerDraw.Enabled = False
        ULat = 0
    End Sub

    Private Sub BtnDecLat_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnDecLat.MouseDown
        Rot = 0
        ULat = -1
        TimerDraw.Enabled = True
    End Sub

    Private Sub BtnDecLat_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnDecLat.MouseUp
        TimerDraw.Enabled = False
        ULat = 0
    End Sub

    Private Sub BtnResLat_Click(sender As Object, e As EventArgs) Handles BtnResLat.Click
        TxtLat.Text = 20
        DrawSphere()
    End Sub

    Private Sub BtnIncLon_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnIncLon.MouseDown
        Rot = 0
        ULon = 1
        TimerDraw.Enabled = True
    End Sub

    Private Sub BtnIncLon_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnIncLon.MouseUp
        TimerDraw.Enabled = False
        ULon = 0
    End Sub

    Private Sub BtnDecLon_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnDecLon.MouseDown
        Rot = 0
        ULon = -1
        TimerDraw.Enabled = True
    End Sub

    Private Sub BtnDecLon_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnDecLon.MouseUp
        TimerDraw.Enabled = False
        ULon = 0
    End Sub

    Private Sub BtnResLon_Click(sender As Object, e As EventArgs) Handles BtnResLon.Click
        TxtLon.Text = 20
        DrawSphere()
    End Sub

    Private Sub BtnIncRx_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnIncRx.MouseDown
        Rot = 1
        TimerDraw.Enabled = True
    End Sub

    Private Sub BtnIncRx_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnIncRx.MouseUp
        TimerDraw.Enabled = False
        Rot = 0
    End Sub

    Private Sub BtnDecRx_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnDecRx.MouseDown
        Rot = -1
        TimerDraw.Enabled = True
    End Sub

    Private Sub BtnDecRx_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnDecRx.MouseUp
        TimerDraw.Enabled = False
        Rot = 0
    End Sub

    Private Sub BtnIncRy_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnIncRy.MouseDown
        Rot = 2
        TimerDraw.Enabled = True
    End Sub

    Private Sub BtnIncRy_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnIncRy.MouseUp
        TimerDraw.Enabled = False
        Rot = 0
    End Sub

    Private Sub BtnDecRy_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnDecRy.MouseDown
        Rot = -2
        TimerDraw.Enabled = True
    End Sub

    Private Sub BtnDecRy_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnDecRy.MouseUp
        TimerDraw.Enabled = False
        Rot = 0
    End Sub

    Private Sub BtnIncRz_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnIncRz.MouseDown
        Rot = 3
        TimerDraw.Enabled = True
    End Sub

    Private Sub BtnIncRz_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnIncRz.MouseUp
        TimerDraw.Enabled = False
        Rot = 0
    End Sub

    Private Sub BtnDecRz_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnDecRz.MouseDown
        Rot = -3
        TimerDraw.Enabled = True
    End Sub

    Private Sub BtnDecRz_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnDecRz.MouseUp
        TimerDraw.Enabled = False
        Rot = 0
    End Sub

    Private Sub BtnResRot_Click(sender As Object, e As EventArgs) Handles BtnResRot.Click
        Rot = 0
        ARtt.Init()
        DrawSphere()
    End Sub

    Private Sub BtnIncTx_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnIncTx.MouseDown
        Trans = 1
        TimerDraw.Enabled = True
    End Sub

    Private Sub BtnIncTx_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnIncTx.MouseUp
        TimerDraw.Enabled = False
        Trans = 0
    End Sub

    Private Sub BtnDecTx_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnDecTx.MouseDown
        Trans = -1
        TimerDraw.Enabled = True
    End Sub

    Private Sub BtnDecTx_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnDecTx.MouseUp
        TimerDraw.Enabled = False
        Trans = 0
    End Sub

    Private Sub BtnIncTy_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnIncTy.MouseDown
        Trans = 2
        TimerDraw.Enabled = True
    End Sub

    Private Sub BtnIncTy_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnIncTy.MouseUp
        TimerDraw.Enabled = False
        Trans = 0
    End Sub

    Private Sub BtnDecTy_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnDecTy.MouseDown
        Trans = -2
        TimerDraw.Enabled = True
    End Sub

    Private Sub BtnDecTy_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnDecTy.MouseUp
        TimerDraw.Enabled = False
        Trans = 0
    End Sub

    Private Sub BtnIncTz_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnIncTz.MouseDown
        Trans = 3
        TimerDraw.Enabled = True
    End Sub

    Private Sub BtnIncTz_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnIncTz.MouseUp
        TimerDraw.Enabled = False
        Trans = 0
    End Sub

    Private Sub BtnDecTz_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnDecTz.MouseDown
        Trans = -3
        TimerDraw.Enabled = True
    End Sub

    Private Sub BtnDecTz_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnDecTz.MouseUp
        TimerDraw.Enabled = False
        Trans = 0
    End Sub

    Private Sub BtnTrans_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnTrans.MouseDown
        Trans = 4
        TimerDraw.Enabled = True
    End Sub

    Private Sub BtnTrans_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnTrans.MouseUp
        TimerDraw.Enabled = False
        Trans = 0
    End Sub

    Private Sub BtnResTrans_Click(sender As Object, e As EventArgs) Handles BtnResTrans.Click
        disx = 0
        disy = 0
        disz = 0
        InitMatrix(Tr)
        DrawSphere()
    End Sub

    Private Sub TimerDraw_Tick(sender As Object, e As EventArgs) Handles TimerDraw.Tick
        If URad = 1 And Val(TxtRad.Text) < 1.8 Then
            TxtRad.Text = Val(TxtRad.Text) + 0.1
        ElseIf URad = -1 And Val(TxtRad.Text) > 0.2 Then
            TxtRad.Text = Val(TxtRad.Text) - 0.1
        End If

        If ULat = 1 Then
            TxtLat.Text = Val(TxtLat.Text) + 2
        ElseIf ULat = -1 And Val(TxtLat.Text) > 2 Then
            TxtLat.Text = Val(TxtLat.Text) - 2
        End If

        If ULon = 1 Then
            TxtLon.Text = Val(TxtLon.Text) + 1
        ElseIf ULon = -1 And Val(TxtLon.Text) > 2 Then
            TxtLon.Text = Val(TxtLon.Text) - 1
        End If

        DrawSphere()
    End Sub

    Public Sub TranslateSphere()
        If Trans > 0 Then
            posneg = 1
        Else 'Trans <= 0
            posneg = -1
        End If

        If Trans = 1 Or Trans = -1 Or Trans = 4 Then
            dis = Val(TxtTx.Text) * posneg * 10
            If Math.Abs(disx + dis) <= 20 Then
                disx = disx + dis
            End If
        End If

        If Trans = 2 Or Trans = -2 Or Trans = 4 Then
            dis = Val(TxtTy.Text) * posneg * 10
            If Math.Abs(disy + dis) <= 20 Then
                disy = disy + dis
            End If
        End If

        If Trans = 3 Or Trans = -3 Or Trans = 4 Then
            dis = Val(TxtTz.Text) * posneg * 10
            If Math.Abs(disz + dis) <= 20 Then
                disz = disz + dis
            End If
        End If

        Tr(3, 0) = disx / 10
        Tr(3, 1) = disy / 10
        Tr(3, 2) = disz / 10

        For i = 0 To APoint.N - 1
            APoint.Elmt(i) = MultiplyMatrix(APoint.Elmt(i), Tr)
        Next

    End Sub

    Public Sub RotateSphere()
        If Rot = 1 Or Rot = -1 Then
            deg = Val(TxtRx.Text) * Rot
        ElseIf Rot = 2 Or Rot = -2 Then
            deg = Val(TxtRy.Text) * (Rot / 2)
        ElseIf Rot = 3 Or Rot = -3 Then
            deg = Val(TxtRz.Text) * (Rot / 3)
        End If

        If Rot <> 0 Then
            deg = deg * Deg2Rad
            If ARtt.N <= 0 OrElse ARtt.Elmt(ARtt.N - 1).Axis <> Math.Abs(Rot) OrElse ARtt.Elmt(ARtt.N - 1).Deg <> -deg Then
                Rtt = New TRtt
                Rtt.SetRot(Math.Abs(Rot), deg)
                ARtt.InsLast(Rtt)
            Else 'ARtt.N > 0 And ARtt.Elmt(ARtt.N - 1).Axis = Math.Abs(Rot) And ARtt.Elmt(ARtt.N - 1).Deg = -deg
                ARtt.DelLast()
            End If
        End If

        If ARtt.N >= 0 Then
            For i = 0 To APoint.N - 1
                For j = 0 To ARtt.N - 1
                    deg = ARtt.Elmt(j).Deg
                    InitMatrix(Rt)
                    If ARtt.Elmt(j).Axis = 1 Then
                        SetColMatrix(Rt, 1, 0, Math.Cos(deg), -Math.Sin(deg), 0)
                        SetColMatrix(Rt, 2, 0, Math.Sin(deg), Math.Cos(deg), 0)
                    ElseIf ARtt.Elmt(j).Axis = 2 Then
                        SetColMatrix(Rt, 0, Math.Cos(deg), 0, Math.Sin(deg), 0)
                        SetColMatrix(Rt, 2, -Math.Sin(deg), 0, Math.Cos(deg), 0)
                    ElseIf ARtt.Elmt(j).Axis = 3 Then
                        SetColMatrix(Rt, 0, Math.Cos(deg), -Math.Sin(deg), 0, 0)
                        SetColMatrix(Rt, 1, Math.Sin(deg), Math.Cos(deg), 0, 0)
                    End If

                    APoint.Elmt(i) = MultiplyMatrix(APoint.Elmt(i), Rt)
                Next
            Next
        End If

    End Sub

    Public Sub DrawSphere()
        Bmp = New Bitmap(PicBox.Width, PicBox.Height)

        GetPolyMesh()
        RotateSphere()
        TranslateSphere()

        Vp.Init()
        Vr.Init()
        Vs.Init()
        For i = 0 To APoint.N - 1
            Vp.InsLast(MultiplyMatrix(APoint.Elmt(i), Pr))
            Vp.Elmt(i).X = Vp.Elmt(i).X / Vp.Elmt(i).W
            Vp.Elmt(i).Y = Vp.Elmt(i).Y / Vp.Elmt(i).W
            Vp.Elmt(i).W = Vp.Elmt(i).W / Vp.Elmt(i).W

            Vr.InsLast(MultiplyMatrix(Vp.Elmt(i), Vt))
            Vs.InsLast(MultiplyMatrix(Vr.Elmt(i), St))
        Next

        Temp = (2 * Lat - 1) * Lon
        For i = 0 To APoly.N - 1
            Poly = New TPoly
            Poly = APoly.Elmt(i)

            E1 = Poly.E1
            E2 = Poly.E2
            E3 = Poly.E3

            L1 = New TLine
            L2 = New TLine
            L3 = New TLine

            L1 = ALine.Elmt(E1)
            L2 = ALine.Elmt(E2)
            L3 = ALine.Elmt(E3)

            If Normal(i) < 0 Then
                For j = 0 To 2
                    L3 = New TLine

                    If j = 0 Then
                        L3 = ALine.Elmt(E1)
                    ElseIf j = 1 Then
                        L3 = ALine.Elmt(E2)
                    Else 'j = 2
                        L3 = ALine.Elmt(E3)
                    End If

                    Pt2 = L3.P1
                    Pt3 = L3.P2
                    Drawline(Vs.Elmt(Pt2).X, Vs.Elmt(Pt2).Y, Vs.Elmt(Pt3).X, Vs.Elmt(Pt3).Y, Color.White)
                Next
            End If
        Next

        LblCenter.Text = "Center Coordinate : ( " & disx / 10 & ", " & disy / 10 & ", " & disz / 10 & " )"
        PicBox.Refresh()
        PicBox.Image = Bmp
    End Sub

    Function Normal(ByVal i As Integer) As Double
        Dim VN As Double

        If i < Temp Then
            If (i + 1) Mod 2 = 0 And i <= Temp - 1 - Lon Then
                A = L1.P2
                B = L1.P1
                C = L2.P1
            Else '(i + 1) Mod 2 <> 0 Or i > Temp - 1 - Lon
                A = L1.P1
                B = L1.P2
                C = L2.P2
            End If
        Else 'i >= Temp
            If i > APoly.N - 1 - Lon Then
                If Lat > 1 Then
                    A = L1.P1
                    B = L1.P2
                    C = L2.P2
                Else 'Lat <= 1
                    A = L1.P1
                    B = L1.P2
                    C = L2.P1
                End If
            Else 'i <= APoly.N - 1 - Lon
                If (i Mod 2) = (Temp Mod 2) Then
                    A = L3.P1
                    B = L3.P2
                    C = L1.P2
                Else '(i + 1) Mod 2 <> (Temp Mod 2)
                    A = L2.P2
                    B = L2.P1
                    C = L3.P1
                End If
            End If
        End If

        AB(0) = Vs.Elmt(B).X - Vs.Elmt(A).X
        AB(1) = Vs.Elmt(B).Y - Vs.Elmt(A).Y
        AC(0) = Vs.Elmt(C).X - Vs.Elmt(A).X
        AC(1) = Vs.Elmt(C).Y - Vs.Elmt(A).Y
        VN = (AB(0) * AC(1)) - (AC(0) * AB(1))

        Return VN
    End Function

    Public Sub GetPolyMesh()
        R = Val(TxtRad.Text)
        Lat = Val(TxtLat.Text) / 2
        Lon = Val(TxtLon.Text)

        tetaLa = (90 / Lat) * Deg2Rad
        tetaLo = (360 / Lon) * Deg2Rad

        APoint.Init()
        ALine.Init()
        APoly.Init()

        For i = 0 To Lat - 1
            For j = 0 To Lon - 1
                PX = R * Math.Cos(i * tetaLa) * Math.Sin(j * tetaLo)
                PY = R * Math.Sin(i * tetaLa)
                PZ = R * Math.Cos(i * tetaLa) * Math.Cos(j * tetaLo)
                P = New TPoint
                P.SetP(PX, PY, PZ, 1)
                APoint.InsLast(P)
            Next
        Next
        P = New TPoint
        P.SetP(0, R, 0, 1)
        APoint.InsLast(P)

        For i = 0 To APoint.N - 2 - Lon
            If (i + 1) Mod Lon = 0 Then
                Pt2 = i - Lon + 1
                Pt3 = i + 1
            Else '(i + 1) Mod Lon <> 0
                Pt2 = i + 1
                Pt3 = Pt2 + Lon
            End If

            L1 = New TLine
            L2 = New TLine
            L3 = New TLine

            L1.SetLine(i, Pt2)
            L2.SetLine(Pt2, Pt3)
            L3.SetLine(Pt3, i)

            ALine.InsLast(L1)
            ALine.InsLast(L2)
            ALine.InsLast(L3)
        Next
        Temp = ALine.N - 1

        For i = APoint.N - 1 - Lon To APoint.N - 2
            If i = APoint.N - 2 Then
                Pt2 = APoint.N - 1 - Lon
            Else 'i <> APoint.N - 2
                Pt2 = i + 1
            End If

            L1 = New TLine
            L2 = New TLine

            L1.SetLine(i, Pt2)
            L2.SetLine(Pt2, APoint.N - 1)

            ALine.InsLast(L1)
            ALine.InsLast(L2)
        Next

        Count = 1
        For i = 0 To Temp Step 3
            Poly = New TPoly
            Poly.SetPoly(i, i + 1, i + 2)
            APoly.InsLast(Poly)

            Poly = New TPoly
            E2 = i + 3 * Lon
            If i Mod 3 * Lon = 0 Then
                E3 = E2 - 2
            Else 'i Mod 3 * Lon <> 0
                If i > Temp - 3 * Lon Then
                    Count = Count + 2
                    E2 = Temp + Count
                End If
                E3 = i - 2
            End If
            Poly.SetPoly(i + 2, E2, E3)
            APoly.InsLast(Poly)
        Next

        For i = Temp + 1 To ALine.N - 1 Step 2
            Poly = New TPoly
            If i = Temp + 1 Then
                E3 = ALine.N - 1
            Else 'i <> Temp + 1
                E3 = i - 1
            End If
            Poly.SetPoly(i, i + 1, E3)
            APoly.InsLast(Poly)
        Next

        Temp = APoint.N - 1
        For i = Lon To Temp
            P = New TPoint
            P.SetP(APoint.Elmt(i).X, -APoint.Elmt(i).Y, APoint.Elmt(i).Z, 1)
            APoint.InsLast(P)
        Next

        If Lat > 1 Then
            Count = 0
            For i = Temp + 1 To APoint.N - 2
                Count = Count + 1
                If i <= Temp + Lon Then
                    If Count Mod Lon = 0 Then
                        Pt2 = 0
                        Pt3 = Lon - 1
                    Else 'Count Mod Lon <> 0
                        Pt2 = i - Lat * Lon
                        Pt3 = Pt2 - 1
                    End If
                Else 'i > Temp + Lon
                    Pt2 = i - Lon + 1
                    If Count Mod Lon = 0 Then
                        Pt2 = Pt2 - Lon
                    End If
                    Pt3 = i - Lon
                End If

                L1 = New TLine
                L1.SetLine(i, Pt2)
                ALine.InsLast(L1)

                If i > Temp + Lon Then
                    L2 = New TLine
                    L2.SetLine(Pt2, Pt3)
                    ALine.InsLast(L2)
                End If

                L3 = New TLine
                L3.SetLine(Pt3, i)
                ALine.InsLast(L3)
            Next

            For i = APoint.N - 1 - Lon To APoint.N - 2
                If i = APoint.N - 1 - Lon Then
                    Pt3 = APoint.N - 2
                Else 'i <> APoint.N - 1 - Lon
                    Pt3 = i - 1
                End If

                L1 = New TLine
                L1.SetLine(APoint.N - 1, i)
                ALine.InsLast(L1)

                L2 = New TLine
                L2.SetLine(i, Pt3)
                ALine.InsLast(L2)
            Next

            Temp = (3 * Lat + 1) * Lon
            Count = 0
            For i = Temp - 2 * Lon To Temp - 1 Step 2
                Poly = New TPoly
                Poly.SetPoly(i, Count, i + 1)
                APoly.InsLast(Poly)
                Count = Count + 3

                Poly = New TPoly
                If Count < 3 * Lon Then
                    If Lat > 2 Then
                        E1 = Temp - 2 + Count
                    Else 'Lat <= 2
                        E1 = i + 2 * Lon + 3
                    End If
                    E2 = i + 3
                Else 'Count >= 3 * Lon
                    If Lat > 2 Then
                        E1 = Temp + 3 * Lon - 2
                    Else 'Lat <=2
                        E1 = Temp + 1
                    End If
                    E2 = i - 2 * Lon + 3
                End If
                Poly.SetPoly(E1, E2, i)
                APoly.InsLast(Poly)
            Next

            If Lat > 2 Then
                Count = 0
                For i = Temp To ALine.N - 1 - 2 * Lon Step 3
                    Poly = New TPoly
                    Poly.SetPoly(i, i + 1, i + 2)
                    APoly.InsLast(Poly)

                    Poly = New TPoly
                    Count = Count + 2

                    If (Count / 2) Mod Lon = 0 Then
                        Count = 0
                        E2 = i - 3 * Lon + 5
                    Else '(Count / 2) Mod Lon <> 0
                        E2 = i + 5
                    End If

                    If i > ALine.N - 1 - 5 * Lon Then
                        E1 = ALine.N + 1 - 2 * Lon + Count
                    Else 'i <= ALine.N - 1 - 5 * Lon
                        E1 = i + 3 * Lon + 1
                    End If

                    Poly.SetPoly(E1, E2, i)
                    APoly.InsLast(Poly)
                Next
            End If

            For i = ALine.N - 2 * Lon To ALine.N - 1 Step 2
                Poly = New TPoly
                If i = ALine.N - 2 * Lon Then
                    E3 = ALine.N - 2
                Else 'i <> ALine.N - 2 * Lon
                    E3 = i - 2
                End If

                Poly.SetPoly(i, i + 1, E3)
                APoly.InsLast(Poly)
            Next
        Else 'Lat <= 1
            For i = 0 To APoint.N - 3
                L1 = New TLine
                L1.SetLine(APoint.N - 1, i)
                ALine.InsLast(L1)
            Next

            Count = 0
            For i = ALine.N - Lon To ALine.N - 1
                Poly = New TPoly
                If i = ALine.N - Lon Then
                    E2 = 2 * Lon - 2
                    E3 = ALine.N - 1
                Else 'i <> ALine.N - Lon
                    E2 = Count
                    E3 = i - 1
                    Count = Count + 2
                End If
                Poly.SetPoly(i, E2, E3)
                APoly.InsLast(Poly)
            Next
        End If

    End Sub

    Public Sub PSet(ByVal x As Double, ByVal y As Double, ByVal Color As System.Drawing.Color)
        If x > 0 And y > 0 And x < 444 And y < 444 Then
            Bmp.SetPixel(x, y, Color)
        End If
    End Sub

    Public Sub Drawline(ByVal px1 As Double, ByVal py1 As Double, ByVal px2 As Double, ByVal py2 As Double, ByVal Color As System.Drawing.Color)

        Dim dx, dy, tdy, tdx, d, dR, dUR, x, y, x1, y1, x2, y2 As Integer
        Dim c As Color

        x1 = px1
        y1 = py1
        x2 = px2
        y2 = py2
        c = Color
        dx = x2 - x1
        dy = y2 - y1
        x = x1
        y = y1

        tdx = Math.Abs(dx)
        tdy = Math.Abs(dy)

        If tdx >= tdy Then
            d = 2 * tdy - tdx
            dR = 2 * tdy
            dUR = 2 * (tdy - tdx)

            Do
                PSet(x, y, c)
                If dx > 0 Then
                    x = x + 1
                ElseIf dx < 0 Then
                    x = x - 1
                End If

                If d <= 0 Then
                    d = d + dR
                Else 'd > 0
                    d = d + dUR
                    If dy < 0 Then
                        y = y - 1
                    ElseIf dy > 0 Then
                        y = y + 1
                    End If
                End If
            Loop Until x = x2
        Else 'tdx  < tdy
            d = tdy - 2 * tdx
            dR = -2 * tdx
            dUR = 2 * (tdy - tdx)

            Do
                PSet(x, y, c)
                If dy > 0 Then
                    y = y + 1
                ElseIf dy < 0 Then
                    y = y - 1
                End If

                If d >= 0 Then
                    d = d + dR
                Else 'd < 0
                    d = d + dUR
                    If dx < 0 Then
                        x = x - 1
                    ElseIf dx > 0 Then
                        x = x + 1
                    End If
                End If
            Loop Until y = y2
        End If
    End Sub
End Class
