Imports System.Net.Sockets '使用到TcpListen类
Imports System.IO '使用到StreamWriter类
Imports System.Net '使用IPAddress类、IPHostEntry类等
Public Class Welcome
    'Private swWriter As StreamWriter
    '用以向网络基础数据流传送数据
    'Private nsStream As NetworkStream
    '创建发送数据的网络基础数据流
    'Private tcpClient As TcpClient
    '通过它实现向远程主机提出TCP连接申请
    'Private tcpConnect As Boolean = False
    '定义标识符，用以表示TCP连接是否建立

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim a = 0
        While a < 101
            If TextBox1.Text = "" Then
                MessageBox.Show("Input your Account Please", "ERROR1")
                Exit While
            End If
            If TextBox1.Text = Account(a) Then
                If TextBox2.Text = "" Then
                    MessageBox.Show("Input the Password Please", "ERROE3")   'can not get the message with any action
                    Exit While
                ElseIf TextBox2.Text <> Password(a) Then
                    MessageBox.Show("There's no such a Account or with Wrong Password,Please Rewrite or Register a New Account", "ERROE2")
                    Exit While
                ElseIf TextBox2.Text = Password(a) Then
                    If r(a) = 1 Then
                        d = 1
                        Exit While
                    Else
                        MessageBox.Show("Your Account not Charged!", "ERROE3")
                        Exit While
                    End If


                End If
            Else a = a + 1
            End If
            If a = 101 Then

                MessageBox.Show("There's no such a Account or with Wrong Password,Please Rewrite or Register a New Account", "ERROR3")
                Exit While
            End If
        End While

        If d = 1 Then

            MessageBox.Show("Wait a Minute,Connecting Now", "")
            ' Call TCPIP_Init()
            Try
                ipRemote = IPAddress.Parse(f)
            Catch
                MessageBox.Show("Wrong IP address！", "")
                Return
                '判断给定的IP地址的合法性
            End Try
            Try
                tcpClient = New TcpClient(f, 8000)
                '对远程主机的8000端口提出TCP连接申请
                nsStream = tcpClient.GetStream()
                '通过申请，并获取传送数据的网络基础数据流
                swWriter = New StreamWriter(nsStream)
                '使用获取的网络基础数据流来初始化StreamWriter实例
                tcpConnect = True
                MessageBox.Show("Connect Successfully！", "")
            Catch
                MessageBox.Show("Can not Connect to the Server,Check you Network！", "")
                c = 1
                Return
            End Try
        End If
        If c = 1 Then
            c = 0
            Exit Sub
        ElseIf c = 0 And d = 1 Then
            d = 0
            Me.Hide()
            Calcolator.Show()
        End If
        Exit Sub

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
    End Sub

    Private Sub Welcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Account(0) = "admin"
        Password(0) = "admin"
        Account(1) = "1"
        Password(1) = "1"
        Account(2) = "2"
        Password(2) = "2"
        Account(3) = "1351783"
        Password(3) = "1351783"
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Sign_in.Show()
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        f = TextBox3.Text()
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Charge.Show()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

    End Sub
End Class
