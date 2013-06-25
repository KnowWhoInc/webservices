public void XML()
{
    string content = "";
    string inputXml = "<KnowWho><Customer>...</Customer><FormData>...</FormData></KnowWho>";
            
    ElectedOfficialsCommunicationService.ElectedOfficialsCommunicationService srvce = new ElectedOfficialsCommunicationService.ElectedOfficialsCommunicationService();
    try
    {
        content = srvce.GetService(inputXml);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}

public void JSON()
{
    string content = "";
    string inputJson = "{ KnowWho: { Customer: { ... }, FormData: { ... }}}";
            
    ElectedOfficialsCommunicationService.ElectedOfficialsCommunicationService srvce = new ElectedOfficialsCommunicationService.ElectedOfficialsCommunicationService();
    try
    {
        content = srvce.GetService(inputJson);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}
