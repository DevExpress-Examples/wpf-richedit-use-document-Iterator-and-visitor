Imports DevExpress.XtraRichEdit.API.Native
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls

Namespace DocumentIteratorExample

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Private Sub SimpleButton_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim visitor As MyVisitor = New MyVisitor()
            Dim iterator As DocumentIterator = New DocumentIterator(Me.richEditControl1.Document, True)
            While iterator.MoveNext()
                iterator.Current.Accept(visitor)
            End While

            Me.textEdit1.Text = visitor.Text
        End Sub
    End Class

    Public Class MyVisitor
        Inherits DocumentVisitorBase

        Private ReadOnly bufferField As StringBuilder

        Public Sub New()
            bufferField = New StringBuilder()
        End Sub

        Protected ReadOnly Property Buffer As StringBuilder
            Get
                Return bufferField
            End Get
        End Property

        Public ReadOnly Property Text As String
            Get
                Return Buffer.ToString()
            End Get
        End Property

        Public Overrides Sub Visit(ByVal text As DocumentText)
            Dim prefix As String = If(text.TextProperties.FontBold, "**", "")
            Buffer.Append(prefix)
            Buffer.Append(text.Text)
            Buffer.Append(prefix)
        End Sub

        Public Overrides Sub Visit(ByVal paragraphEnd As DocumentParagraphEnd)
            Buffer.AppendLine()
        End Sub
    End Class
End Namespace
