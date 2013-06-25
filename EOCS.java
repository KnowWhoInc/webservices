public void EOCS() throws MalformedURLException, IOException {
 
    String responseString = "";
    String outputString = "";
    String wsURL = "http://www.knowwho.info/Services/ElectedOfficialsCommunicationService.asmx";
    URL url = new URL(wsURL);
    URLConnection connection = url.openConnection();
    HttpURLConnection httpConn = (HttpURLConnection)connection;
    ByteArrayOutputStream bout = new ByteArrayOutputStream();
    String xmlInput =
        "  <soapenv:Envelope xmlns:soapenv=\"http://schemas.xmlsoap.org/soap/envelope/\">\n" +
        "   <soapenv:Header/>\n" +
        "   <soapenv:Body>\n" +
        "      <web:GetService>\n" +
        "         <web:KnowWho>...</web:KnowWho>\n" +
        "      </web:GetService>\n" +
        "   </soapenv:Body>\n" +
        "  </soapenv:Envelope>";
 
    byte[] buffer = new byte[xmlInput.length()];
    buffer = xmlInput.getBytes();
    bout.write(buffer);
    byte[] b = bout.toByteArray();
    String SOAPAction =
        "http://knowwho.info/Services/GetService";
    httpConn.setRequestProperty("Content-Length",
                                String.valueOf(b.length));
    httpConn.setRequestProperty("Content-Type", "text/xml; charset=utf-8");
    httpConn.setRequestProperty("SOAPAction", SOAPAction);
    httpConn.setRequestMethod("POST");
    httpConn.setDoOutput(true);
    httpConn.setDoInput(true);
    OutputStream out = httpConn.getOutputStream();
    out.write(b);
    out.close();
 
    InputStreamReader isr =
        new InputStreamReader(httpConn.getInputStream());
    BufferedReader in = new BufferedReader(isr);
 
    while ((responseString = in.readLine()) != null) {
        outputString = outputString + responseString;
    }
}
