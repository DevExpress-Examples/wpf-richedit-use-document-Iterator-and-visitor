Imports DevExpress.XtraRichEdit.API.Native
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes

Namespace DocumentIteratorExample
    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub SimpleButton_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim visitor As New MyVisitor()
            Dim iterator As New DocumentIterator(richEditControl1.Document, True)
            Do While iterator.MoveNext()
                iterator.Current.Accept(visitor)
            Loop
            textEdit1.Text = visitor.Text
        End Sub
    End Class
    Public Class MyVisitor
        Inherits DocumentVisitorBase


        Private ReadOnly buffer_Renamed As StringBuilder
        Public Sub New()
            Me.buffer_Renamed = New StringBuilder()
        End Sub
        Protected ReadOnly Property MyBuffer() As StringBuilder
            Get
                Return buffer_Renamed
            End Get
        End Property
        Public ReadOnly Property Text() As String
            Get
                Return MyBuffer.ToString()
            End Get
        End Property

        Public Overrides Sub Visit(ByVal text As DocumentText)
            Dim prefix As String = If(text.TextProperties.FontBold, "**", "")

            MyBuffer.Append(prefix)
            MyBuffer.Append(text.Text)
            MyBuffer.Append(prefix)
        End Sub
        Public Overrides Sub Visit(ByVal paragraphEnd As DocumentParagraphEnd)
            MyBuffer.AppendLine()
        End Sub
    End Class
End Namespace
