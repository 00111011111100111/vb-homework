Imports System.Net.Sockets
'使用到TcpListen类
Imports System.Threading
'使用到线程
Imports System.IO
'使用到StreamReader类
Imports System.Net

Public Class Server


    Private iPort As Integer = 8000
    '定义侦听端口号
    Private thThreadRead As Thread
    '创建线程，用以侦听端口号，接收信息
    Private tlTcpListen As TcpListener
    '侦听端口号
    Private blistener As Boolean = True
    '设定标示位，判断侦听状态
    Private nsStream As NetworkStream
    '创建接收的基本数据流
    Private srRead As StreamReader
    '从网络基础数据流中读取数据
    Private tcClient As TcpClient
    Private localaddr As IPAddress

    Private swWriter As StreamWriter

    '用以向网络基础数据流传送数据

    Dim st As String
    Dim Str_IP As String = ""
    Dim ipa As System.Net.IPAddress()
    Dim HostName As String = System.Net.Dns.GetHostName

    Dim count = 0
    Dim n, i, k As Integer
    Dim aa, bb, ab As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        thThreadRead = New Thread(New ThreadStart(AddressOf Listen))
        '以Listen过程来初始化线程实例
        thThreadRead.Start()
        '启动线程
        Button1.Enabled = False
        Label1.Text = "service started！"
        Label1.ForeColor = Color.Red

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Server_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Listen()
        Control.CheckForIllegalCrossThreadCalls = False
        Try
            localaddr = IPAddress.Parse(TextBox1.Text)
        Catch
            MessageBox.Show("Wrong IP address！", "")
            Return
            '判断给定的IP地址的合法性
        End Try
        Try
            localaddr = IPAddress.Parse(TextBox1.Text)  '169.254.247.173
            tlTcpListen = New TcpListener(localaddr, 8000)
            '以8000端口号来初始化TcpListener实例
            tlTcpListen.Start()
            '开始监听
            ToolStripStatusLabel1.Text = "Monitoring..."
            tcClient = tlTcpListen.AcceptTcpClient()
            '通过TCP连接请求
            nsStream = tcClient.GetStream()
            '获取用以发送、接收数据的网络基础数据流
            srRead = New StreamReader(nsStream)
            '以得到的网络基础数据流来初始化StreamReader实例
            ToolStripStatusLabel1.Text = "TCP Connected！"
            '循环侦听
            While blistener
                Dim sMessage As String = srRead.ReadLine()
                '从网络基础数据流中读取一行数据
                If (sMessage = "STOP") Then
                    tlTcpListen.Stop()
                    '关闭侦听
                    Button1.Enabled = True
                    nsStream.Close()
                    srRead.Close()
                    '释放资源
                    ToolStripStatusLabel1.Text = "No Connect！"
                    thThreadRead.Abort()
                    '中止线程
                    Return
                Else
                    '判断是否为断开TCP连接控制码
                    Dim sTime As String = DateTime.Now.ToShortTimeString()
                    '获取接收数据时的时间
                    ListBox1.Items.Add(sTime + " " + sMessage)
                    TextBox2.Text = sMessage
                    caculate()
                End If
            End While
        Catch ex As System.Security.SecurityException
            MessageBox.Show("Monitor Failed！", "ERROR")
        End Try
    End Sub
    Private Sub caculate()

        If （ToolStripStatusLabel1.Text = "TCP Connected！"） Then
            st = TextBox2.Text
            n = Len(st)
            For i = 0 To n - 1
                If st(i) = "+" Or st(i) = "-" Or st(i) = "×" Or st(i) = "÷" Then
                    k = i
                End If
            Next
            aa = Strings.Left(st, k)
            bb = Strings.Right(st, n - k - 1)
            Select Case st(k)
                Case "+"
                    ab = Val(aa) + Val(bb)
                Case "-"
                    ab = Val(aa) - Val(bb)
                Case "×"
                    ab = Val(aa) * Val(bb)
                Case "÷"
                    ab = Val(aa) / Val(bb)
            End Select

            If (ab <> "") Then
                nsStream = tcClient.GetStream()
                '通过申请，并获取传送数据的网络基础数据流
                swWriter = New StreamWriter(nsStream)
                '使用获取的网络基础数据流来初始化StreamWriter实例
                swWriter.WriteLine(ab)
                '刷新当前数据流中的数据
                swWriter.Flush()
                TextBox1.Text = ab
            Else
                MessageBox.Show("Send message can not be empty！", "ERROR！")
            End If
        Else
            MessageBox.Show("No Connect!", "错误提示！")
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs)
        If （ToolStripStatusLabel1.Text = "TCP Connected！"） Then
            If (TextBox1.Text <> "") Then
                nsStream = tcClient.GetStream()
                '通过申请，并获取传送数据的网络基础数据流
                swWriter = New StreamWriter(nsStream)
                '使用获取的网络基础数据流来初始化StreamWriter实例
                swWriter.WriteLine(TextBox1.Text)
                '刷新当前数据流中的数据
                swWriter.Flush()
                TextBox1.Text = ""
            Else
                MessageBox.Show("Send message can not be empty！", "ERROR！")
            End If
        Else
            MessageBox.Show("No Connect", "ERROR！")
        End If
    End Sub
End Class
