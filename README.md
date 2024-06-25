<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/150736163/18.1.6%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T830510)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# How to use the Document Iterator and Visitor to iterate over document elements

This example creates a <a href="http://help.devexpress.com/#CoreLibraries/clsDevExpressXtraRichEditAPINativeDocumentIteratortopic">DocumentIterator</a> instance for the current document and calls its <a href="http://help.devexpress.com/#CoreLibraries/DevExpressXtraRichEditAPINativeDocumentIterator_MoveNexttopic">MoveNext</a> method to iterate over document elements. A <strong>Visitor pattern </strong>is implemented to process a document element. The implementation is done by calling each element's <a href="http://help.devexpress.com/#CoreLibraries/DevExpressXtraRichEditAPINativeIDocumentElement_Accepttopic">Accept</a> method with the <strong>MyVisitor</strong> object instance as a parameter. <strong><br>MyVisitor </strong>is a custom class which descends from the <strong>DocumentVisitorBase </strong>class and provides a method that processes <a href="http://help.devexpress.com/#CoreLibraries/clsDevExpressXtraRichEditAPINativeDocumentTexttopic">DocumentText</a> elements to enclose <a href="http://help.devexpress.com/#CoreLibraries/DevExpressXtraRichEditAPINativeCharacterPropertiesBase_Boldtopic">Bold</a> text in asterisks and return all characters without formatting. Paragraph ends are replaced with newline symbols, other document elements are skipped.<br>You can customize MyVisitor class to perform any operation with any type of element which the DocumentIterator encounters.
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-richedit-use-document-iterator-and-visitor&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-richedit-use-document-iterator-and-visitor&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
