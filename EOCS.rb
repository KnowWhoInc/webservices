require 'soap/wsdlDriver'

def XML
    # declare and build String containing XML
    _xmlString = "<KnowWho><Customer> ... </Customer><FormData> ... </FormData></KnowWho>";

    # declare new instance of the service and call the appropriate function, passing the string
    _returnedXml = SOAP::WSDLDriverFactory.new("http://knowwho.info/Services/ElectedOfficialsCommunicationsService.asmx?WSDL").GetService({ 'InputString' => _xmlString }).GetServiceResult;

    # if all was successful, returnedXml now contains a string representation of the returned XML
end

def JSON
    # declare and build String containing JSON
    _jsonString = "{ KnowWho: { Customer: { ... }, FormData: { ... } } }";

    # declare new instance of the service and call the appropriate function, passing the string
    _returnedJson = SOAP::WSDLDriverFactory.new("http://knowwho.info/Services/ElectedOfficialsCommunicationsService.asmx?WSDL").GetService({ 'InputString' => _jsonString }).GetServiceResult;

    # if all was successful, returnedJson now contains a string representation of the returned JSON
end
