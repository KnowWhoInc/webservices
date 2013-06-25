public void XML()
{
    string content = "";
    string inputXml = "<KnowWho><Customer>...</Customer><Address>...</Address></KnowWho>";
            
    ElectedOfficialsDirectoryService.ElectedOfficialsDirectoryService srvce = new ElectedOfficialsDirectoryService.ElectedOfficialsDirectoryService();
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
    string inputJson = "{ KnowWho: { Customer: { ... }, Address: { ... } } }";
            
    ElectedOfficialsDirectoryService.ElectedOfficialsDirectoryService srvce = new ElectedOfficialsDirectoryService.ElectedOfficialsDirectoryService();
    try
    {
        content = srvce.GetService(inputJson);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}