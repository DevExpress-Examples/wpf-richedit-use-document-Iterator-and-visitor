using DevExpress.XtraRichEdit.API.Native;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DocumentIteratorExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SimpleButton_Click(object sender, RoutedEventArgs e)
        {
            MyVisitor visitor = new MyVisitor();
            DocumentIterator iterator = new DocumentIterator(richEditControl1.Document, true);
            while (iterator.MoveNext())
                iterator.Current.Accept(visitor);
            textEdit1.Text = visitor.Text;
        }
    }
    public class MyVisitor : DocumentVisitorBase
    {
        readonly StringBuilder buffer;
        public MyVisitor() { this.buffer = new StringBuilder(); }
        protected StringBuilder Buffer { get { return buffer; } }
        public string Text { get { return Buffer.ToString(); } }

        public override void Visit(DocumentText text)
        {
            string prefix = (text.TextProperties.FontBold) ? "**" : "";
            
            Buffer.Append(prefix);
            Buffer.Append(text.Text);
            Buffer.Append(prefix);
        }
        public override void Visit(DocumentParagraphEnd paragraphEnd)
        {
            Buffer.AppendLine();
        }
    }
}
