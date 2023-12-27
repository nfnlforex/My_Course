Imports System.Diagnostics.Eventing.Reader
Imports System.Reflection.Emit

Public Class Form1

    Private Sub bKetQua_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Object
        Dim b As Object
        Dim c As Object
        Dim Denta As Object


        If String.IsNullOrEmpty(IA.Text) = True Or String.IsNullOrEmpty(IB.Text) Or String.IsNullOrEmpty(IC.Text) Then

            IKQ.Text = "Không được bỏ trống"


        Else
            a = Double.Parse(IA.Text)
            b = Double.Parse(IB.Text)
            c = Double.Parse(IC.Text)
            If (a = 0) Then
                IKQ.Text = String.Format("Giá trị không hợp lệ, A phải khác 0")
            Else
                Denta = b * b - 4 * a * c
                If (Denta < 0) Then
                    IKQ.Text = "Phương trình vô nghiệm"
                End If

                If (Denta = 0) Then
                    IKQ.Text = String.Format("Phương trình có nghiệm kép X1 = X2 = {0}", XuLyKetQua(-b / (2 * a)))
                End If
                If (Denta > 0) Then
                    IKQ.Text = String.Format("Phương trình có hai nghiệm X1 = {0} và X2 = {1}", XuLyKetQua((-b + Math.Sqrt(Denta)) / (2 * a)), XuLyKetQua((-b - Math.Sqrt(Denta)) / (2 * a)))
                End If



            End If
        End If






    End Sub
    Private Sub bThoat_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub bXoa_Click(sender As Object, e As EventArgs) Handles bXoa.Click
        IKQ.Text = ""
        IA.Text = ""
        IB.Text = ""
        IC.Text = ""
    End Sub
    'hàm xử lý số nguyên hay thập phân
    Function XuLyKetQua(input As Object) As Object
        If TypeOf input Is Integer Then
            Return DirectCast(input, Integer)
        ElseIf TypeOf input Is Double Then

            Return Math.Round(DirectCast(input, Double), 4)
        Else
            Return "Không phải là số"
        End If
    End Function


End Class
