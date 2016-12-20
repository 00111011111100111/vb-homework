Imports System.Net.Sockets
'使用到TcpListen类
Imports System.IO
'使用到StreamWriter类
Imports System.Net
'使用IPAddress类、IPHostEntry类等
Public Class TCPIP
    Private swWriter As StreamWriter
    '用以向网络基础数据流传送数据
    Private nsStream As NetworkStream
    '创建发送数据的网络基础数据流
    Private tcpClient As TcpClient
    '通过它实现向远程主机提出TCP连接申请
    Private tcpConnect As Boolean = False
    '定义标识符，用以表示TCP连接是否建立
End Class
