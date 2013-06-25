public function XML() {

    // declare and build String containing XML
    $xmlString = �<KnowWho><Customer> � </FormData></KnowWho>�;

    // declare new instance of the service
    $client = new SoapClient(http://www.knowwho.info/Services/ElectedOfficialsCommunicationService.asmx);

    // call the appropriate function, passing the string
    $returnedXml = $client->GetService(array(�InputString� => $ xmlString));

    // if all was successful, $returnedXml now contains a string representation of the returned XML
}

public function JSON() {
    // declare and build String containing JSON
    $jsonString = "{ KnowWho: { Customer: { ... }, FormData: { ... } } }";

    // declare new instance of the service
    $client = new SoapClient(http://www.knowwho.info/Services/ElectedOfficialsCommunicationService.asmx);

    // call the appropriate function, passing the string
    $returnedJson = $client->GetService(array(�InputString� => $ jsonString));

    // if all was successful, $returnedJson now contains a string representation of the returned JSON
}
