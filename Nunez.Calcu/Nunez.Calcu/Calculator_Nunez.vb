Public Class Calculator_Nunez

    Dim a As Double
    Private Sub OpEquals_Click(sender As Object, e As EventArgs) Handles OpEquals.Click

        Dim equation As String = output.Text
        Dim result = New DataTable().Compute(equation, Nothing)


        Try
            output.Text = result


        Catch ex As Exception
            output.Text = "Math Error"
        End Try

    End Sub


    Private Sub OpSin_Click(sender As Object, e As EventArgs) Handles OpSin.Click
        output.Text = Math.Sin(Convert.ToDouble(output.Text) * (Math.PI / 180)).ToString
    End Sub


    Private Sub OpTan_Click(sender As Object, e As EventArgs) Handles OpTan.Click
        output.Text = Math.Tan(Convert.ToDouble(output.Text) * (Math.PI / 180)).ToString
    End Sub

    Private Sub OpCos_Click(sender As Object, e As EventArgs) Handles OpCos.Click
        output.Text = Math.Cos(Convert.ToDouble(output.Text) * (Math.PI / 180)).ToString
    End Sub

    Private Sub OpLog_Click_1(sender As Object, e As EventArgs) Handles OpLog.Click
        a = Math.Log10(Convert.ToDouble(output.Text)).ToString
        output.Text = a

    End Sub

    Private Sub OpLn_Click(sender As Object, e As EventArgs) Handles OpLn.Click
        output.Text = Math.Log(Convert.ToDouble(output.Text)).ToString
    End Sub

    Private Sub OpRoot_Click(sender As Object, e As EventArgs) Handles OpRoot.Click
        a = Math.Sqrt(Convert.ToDouble(output.Text)).ToString
        output.Text = a

    End Sub


    Private Sub Calculator_Nunez_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub OpSquared_Click(sender As Object, e As EventArgs) Handles OpSquared.Click
        output.Text = (Convert.ToDouble(output.Text) * Convert.ToDouble(output.Text)).ToString

    End Sub

    Private Sub OpCubed_Click(sender As Object, e As EventArgs) Handles OpCubed.Click
        output.Text = (Convert.ToDouble(output.Text) * Convert.ToDouble(output.Text) * Convert.ToDouble(output.Text)).ToString
    End Sub

    Private Sub OpClearLeft_Click(sender As Object, e As EventArgs) Handles OpClearLeft.Click
        If Not output.Text.Length <= 0 Then
            output.Text = output.Text.Remove(output.Text.Length - 1, 1)
        End If
    End Sub

    Private Sub NumAndOper_Click(sender As Object, e As EventArgs) Handles num0.Click, num1.Click, num2.Click, num3.Click, num4.Click, num5.Click, num6.Click, num7.Click, num8.Click, num9.Click, OpPlus.Click, OpMinus.Click, OpDivide.Click, OpMultiply.Click, OpClear.Click, OpDel.Click
        Dim button As Button = CType(sender, Button)
        If output.Text = "0" Then
            output.Clear()
        End If
        If button.Name = "num1" Then
            output.Text = output.Text + "1"
        End If
        If button.Name = "num2" Then
            output.Text = output.Text + "2"
        End If
        If button.Name = "num3" Then
            output.Text = output.Text + "3"
        End If
        If button.Name = "num4" Then
            output.Text = output.Text + "4"
        End If
        If button.Name = "num5" Then
            output.Text = output.Text + "5"
        End If
        If button.Name = "num6" Then
            output.Text = output.Text + "6"
        End If
        If button.Name = "num8" Then
            output.Text = output.Text + "8"
        End If
        If button.Name = "num9" Then
            output.Text = output.Text + "9"
        End If
        If button.Name = "num0" Then
            output.Text = output.Text + "0"
        End If
        If button.Name = "num7" Then
            output.Text = output.Text + "7"
        End If
        If button.Name = "Dot" Then
            output.Text = output.Text + "."
        End If
        If button.Name = "OpPlus" Then
            output.Text = output.Text + "+"
        End If
        If button.Name = "OpMinus" Then
            output.Text = output.Text + "-"
        End If
        If button.Name = "OpMultiply" Then
            output.Text = output.Text + "*"
        End If
        If button.Name = "OpDivide" Then
            output.Text = output.Text + "/"
        End If
        If button.Name = "OpClear" Then
            output.Text = ""
        End If
        If button.Name = "OpDel" Then
            output.Text = "0"
        End If

    End Sub

    Private Sub OpParenOpen_Click(sender As Object, e As EventArgs) Handles OpParenOpen.Click
        output.Text += "("
    End Sub

    Private Sub OpParenClose_Click(sender As Object, e As EventArgs) Handles OpParenClose.Click
        output.Text += ")"
    End Sub

    Private Sub Op1overX_Click(sender As Object, e As EventArgs) Handles Op1overX.Click
        output.Text = (1 / Convert.ToDouble(output.Text)).ToString
    End Sub

    Private Sub OpPi_Click(sender As Object, e As EventArgs) Handles OpPi.Click
        output.Text *= Math.PI

    End Sub

    Private Sub OpE_Click(sender As Object, e As EventArgs) Handles OpE.Click
        output.Text *= Math.E
    End Sub

    Private Sub Abs_Click(sender As Object, e As EventArgs) Handles Abs.Click
        output.Text = Math.Abs(Val(output.Text))
    End Sub

    Private Sub root3_Click(sender As Object, e As EventArgs)
        output.Text = (Convert.ToDouble(output.Text) ^ (1 / 3)).ToString
    End Sub

    Private Sub OpFact_Click(sender As Object, e As EventArgs) Handles OpFact.Click
        Dim n, i, f As Integer
        f = 1
        n = Val(output.Text)

        If output.Text < 0 Then
            output.Text = "Factorial Not Possible"
        ElseIf output.Text = 0 Or output.Text = 1 Then
            output.Text = "1"
        Else
            For i = 1 To n
                f = f * i
            Next
            output.Text = f
        End If
    End Sub

    Private Sub output_TextChanged(sender As Object, e As EventArgs) Handles output.TextChanged

    End Sub
End Class
