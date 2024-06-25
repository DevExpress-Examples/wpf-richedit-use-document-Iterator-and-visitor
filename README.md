<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/150736163/21.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T830510)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# Rich Text Editor for WPF - How to Use the Document Iterator and Visitor to Iterate Over Document Elements

## Implementation Details

This example creates a [DocumentIterator](https://docs.devexpress.com/OfficeFileAPI/DevExpress.XtraRichEdit.API.Native.DocumentIterator) instance for the current document and calls its [MoveNext](https://docs.devexpress.com/OfficeFileAPI/devexpress.xtrarichedit.api.native.documentiterator.movenext.overloads) method to iterate over document elements. A `Visitor` pattern is implemented to process a document element. The implementation is done by calling each element's [Accept](https://docs.devexpress.com/OfficeFileAPI/DevExpress.XtraRichEdit.API.Native.IDocumentElement.Accept(DevExpress.XtraRichEdit.API.Native.IDocumentVisitor)) method with the `MyVisitor` object instance as a parameter. `MyVisitor` is a custom class that descends from the `DocumentVisitorBase` class. `MyVisitor` class contains a method that processes [DocumentText](https://docs.devexpress.com/OfficeFileAPI/DevExpress.XtraRichEdit.API.Native.DocumentText) elements to enclose [Bold](https://docs.devexpress.com/OfficeFileAPI/DevExpress.XtraRichEdit.API.Native.CharacterPropertiesBase.Bold) text in asterisks and return all characters without formatting. Paragraph ends are replaced with newline symbols, other document elements are skipped.

You can customize the `MyVisitor` class to perform any operation with any type of element that the `DocumentIterator` encounters.

## Files to Review

* [MainWindow.xaml.cs](./CS/DocumentIteratorExample/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/DocumentIteratorExample/MainWindow.xaml.vb))

## More Examples

* [How to use Document Iterator to obtain a list of fonts that are used in a document](https://github.com/DevExpress-Examples/how-to-use-document-iterator-to-obtain-a-list-of-fonts-that-are-used-in-a-document-t438475)
* [Use DocumentIterator to Export a Document in a Custom Format](https://github.com/DevExpress-Examples/how-to-use-documentiterator-to-export-document-in-a-custom-format)

## Documentation

* [Layout API](https://docs.devexpress.com/WPF/114152/controls-and-libraries/rich-text-editor/page-layout/layout-api)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-richedit-use-document-iterator-and-visitor&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-richedit-use-document-iterator-and-visitor&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
