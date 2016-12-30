Imports System.Net.Sockets '使用到TcpListen类
Imports System.IO '使用到StreamWriter类
Imports System.Net '使用IPAddress类、IPHostEntry类等

''' <summary>
''' 
''' </summary>
Module Module1
    Public Account(100), Password(100) As String
    Public b = 0, c = 0, d = 0
    Public f As String
    Public q(100), w(100) As String
    Public i, j, k, n, r(100), tim As Integer
    Public t, m, p, ysblank As Integer
    Public aa, bb, ab As String
    Public dy
    ' Public Sub TCPIP_Init()
    Public swWriter As StreamWriter
    '用以向网络基础数据流传送数据
    Public nsStream As NetworkStream
    '创建发送数据的网络基础数据流
    Public tcpClient As TcpClient
    '通过它实现向远程主机提出TCP连接申请
    Public tcpConnect As Boolean = False
    '定义标识符，用以表示TCP连接是否建立
    Public ipRemote As IPAddress
    Public srRead As StreamReader
    Public blistener As Boolean = True

    ' Dim tcpClient As TcpClient 
    '     Try
    '         ipRemote = IPAddress.Parse(f)
    'Catch
    '        MessageBox.Show("Wrong IP address！", "")
    'Return
    '判断给定的IP地址的合法性
    'End Try
    '  Try
    '       tcpClient = New TcpClient(f, 8000)
    '对远程主机的8000端口提出TCP连接申请
    '       nsStream = tcpClient.GetStream()
    '通过申请，并获取传送数据的网络基础数据流
    '      swWriter = New StreamWriter(nsStream)
    '使用获取的网络基础数据流来初始化StreamWriter实例
    '      tcpConnect = True
    '      MessageBox.Show("Connect Successfully！", "")
    'Catch
    '     MessageBox.Show("Can not Connect to the Server,Check you Network！", "")
    '     c = 1
    'Return
    '       End Try
    '  End Sub
End Module

