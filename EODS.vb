Public Function XML()

    // declare and build String containing XML
    Dim xmlString As String
    xmlString = "<KnowWho><Customer> ... </Customer><Address> ... </Address></KnowWho>";

    // declare new instance of the service
    Dim serviceInstance As New Namespace.ReferenceName.ElectedOfficialsDirectoryService()

    // call the appropriate function, passing the String
    Dim returnedXml As String
    returnedXml = serviceInstance.GetService(xmlString)

    // if all was successful, returnedXml now contains a string representation of the returned XML

End Function

Public Function JSON()

    // declare and build String containing JSON
    Dim jsonString As String
    jsonString = "{ KnowWho: { Customer: { ... }, Address: { ... } } }";

    // declare new instance of the service
    Dim serviceInstance As New Namespace.ReferenceName.ElectedOfficialsDirectoryService()

    // call the appropriate function, passing the String
    Dim returnedJson As String
    returnedJson = serviceInstance.GetService(jsonString)

    // if all was successful, returnedJson now contains a string representation of the returned JSON

End Function
