Imports System.Net.Sockets '使用到TcpListen类
Imports System.IO '使用到StreamWriter类
Imports System.Net '使用IPAddress类、IPHostEntry类等
Public Class Calcolator
    ' Private swWriter As StreamWriter
    '用以向网络基础数据流传送数据
    '  Private nsStream As NetworkStream
    '创建发送数据的网络基础数据流
    '  Private tcpClient As TcpClient
    '通过它实现向远程主机提出TCP连接申请
    ' Private tcpConnect As Boolean = False
    '定义标识符，用以表示TCP连接是否建立
    ' Private srRead As StreamReader
    '从网络基础数据流中读取数据
    ' Private blistener As Boolean = True
    '设定标示位，判断侦听状态

    Private Sub Calcolator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        XS1.Text = "0"
    End Sub

    Private Sub DToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DToolStripMenuItem.Click

    End Sub

    Private Sub RechargeToolStripMenuItem_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub BackToTheWelcomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToTheWelcomeToolStripMenuItem.Click
        Me.Hide()
        Welcome.Show()
    End Sub

    Private Sub CloseCompleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseCompleteToolStripMenuItem.Click
        End

    End Sub



    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If Val(XS1.Text) > 0 Then
            XS1.Text = "-" + XS1.Text
        Else
            XS1.Text = -Val(XS1.Text)
        End If
        p = 0
    End Sub

    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
        If t >= 1 Then XS1.Text = ""
        t = 0
        If XS1.Text = "0" Then
            XS1.Text = "1"
        Else
            XS1.Text = XS1.Text + "1"
        End If
        p = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        If t >= 1 Then XS1.Text = ""
        t = 0
        If XS1.Text <> "0" Then XS1.Text = XS1.Text + "0"
        p = 0
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles spoint.Click
        If t >= 1 Then XS1.Text = "0"
        t = 0
        XS1.Text = XS1.Text + "."
        spoint.Enabled = False
        p = 0
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        spoint.Enabled = True
        If p = 0 Then
            bb = Val(XS1.Text)
        End If
        Select Case m
            Case 1
                Tv.Text = aa + "+" + bb
            Case 2
                Tv.Text = aa + "-" + bb
            Case 3
                Tv.Text = aa + "×" + bb
            Case 4
                Tv.Text = aa + "÷" + bb
        End Select
        t = 2
        p = 1
        send()


        'XS1.Text = ab

        ' YS1.Text = ""
    End Sub
    Private Sub send() ''''''''''''''''''''''''''''''''''''''''''''''''修改过参考源文档修改
        If （Label1.Text = "CONNECTED!"） Then
            If (Tv.Text <> "") Then
                swWriter.WriteLine(Tv.Text)
                '刷新当前数据流中的数据
                swWriter.Flush()
            Else
                MessageBox.Show("发送信息不能为空！", "错误提示！")
            End If
            srRead = New StreamReader(nsStream)
            '以得到的网络基础数据流来初始化StreamReader实例
            Dim sMessage As String = srRead.ReadLine()
            '从网络基础数据流中读取一行数据
            XS1.Text = sMessage
            aa = XS1.Text
        Else
            MessageBox.Show("服务器尚未连接", "错误提示！")
        End If

    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        aa = Val(XS1.Text)
        t = 1
        m = 1
        spoint.Enabled = True
        p = 0
        YS1.Text = XS1.Text + "+"
    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        If t >= 1 Then XS1.Text = ""
        t = 0
        If XS1.Text = "0" Then
            XS1.Text = "3"
        Else
            XS1.Text = XS1.Text + "3"
        End If
        p = 0
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        If t >= 1 Then XS1.Text = ""
        t = 0
        If XS1.Text = "0" Then
            XS1.Text = "2"
        Else
            XS1.Text = XS1.Text + "2"
        End If
        p = 0
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        If t >= 1 Then XS1.Text = ""
        t = 0
        If XS1.Text = "0" Then
            XS1.Text = "4"
        Else
            XS1.Text = XS1.Text + "4"
        End If
        p = 0
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        If t >= 1 Then XS1.Text = ""
        t = 0
        If XS1.Text = "0" Then
            XS1.Text = "5"
        Else
            XS1.Text = XS1.Text + "5"
        End If
        p = 0
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        If t >= 1 Then XS1.Text = ""
        t = 0
        If XS1.Text = "0" Then
            XS1.Text = "6"
        Else
            XS1.Text = XS1.Text + "6"
        End If
        p = 0
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        aa = Val(XS1.Text)
        t = 1
        m = 2
        spoint.Enabled = True
        p = 0
        YS1.Text = XS1.Text + "-"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        aa = Val(XS1.Text)
        t = 1
        m = 3
        spoint.Enabled = True
        p = 0
        YS1.Text = XS1.Text + "×"
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        If t >= 1 Then XS1.Text = ""
        t = 0
        If XS1.Text = "0" Then
            XS1.Text = "9"
        Else
            XS1.Text = XS1.Text + "9"
        End If
        p = 0
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        If t >= 1 Then XS1.Text = ""
        t = 0
        If XS1.Text = "0" Then
            XS1.Text = "8"
        Else
            XS1.Text = XS1.Text + "8"
        End If
        p = 0
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        If t >= 1 Then XS1.Text = ""
        t = 0
        If XS1.Text = "0" Then
            XS1.Text = "7"
        Else
            XS1.Text = XS1.Text + "7"
        End If
        p = 0
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        XS1.Text = ""
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        XS1.Text = "0"
        t = 0
        spoint.Enabled = True
        p = 0
        aa = 0
        bb = 0
        ab = 0
        m = 0
        YS1.Text = ""
        Tv.Text = ""
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        dy = XS1.Text
        If (Len(dy) > 0) Then
            XS1.Text = Strings.Left(dy, (Len(dy) - 1))
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        aa = Val(XS1.Text)
        t = 1
        m = 4
        spoint.Enabled = True
        p = 0
        YS1.Text = XS1.Text + "÷"
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        ab = 1 / Val(XS1.Text)

        XS1.Text = ab

        t = 2
        p = 0
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        spoint.Enabled = True
        bb = Val(XS1.Text)
        YS1.Text = XS1.Text + "^2"
        Tv.Text = YS1.Text
        ab = bb * bb
        XS1.Text = ab
        t = 2
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        spoint.Enabled = True
        bb = Val(XS1.Text)
        YS1.Text = "sqrt(" + XS1.Text + ")"
        Tv.Text = YS1.Text
        ab = Math.Sqrt(bb)
        XS1.Text = ab
        t = 2
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub YS1_TextChanged(sender As Object, e As EventArgs) Handles YS1.TextChanged

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub ys2_TextChanged(sender As Object, e As EventArgs) Handles Tv.TextChanged

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If t >= 1 Then XS1.Text = ""
        t = 0
        If XS1.Text <> "0" Then XS1.Text = XS1.Text + "0"
        p = 0
    End Sub
End Class