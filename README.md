InteractúaMóvil SDK DotNet
==========================

SDK DotNet para el API SMS de InteractúaMóvil.

Es necesario poseer un **API_KEY**, un **API_SECRET_KEY** y **API_URL**
para utilizar el API.

Ejemplo de creación de instancia del api:
       
    sdk = new SmsApi(key, secret, url);

Para hacer llamadas al API puede utilizarse `Contacts`, `Groups`, `Messages`  en el objeto de api:

        
        private static void SendSingleContactoMessage()
        {
            Console.WriteLine();
            Console.WriteLine("==============================================");
            Console.WriteLine("Prueba Envio Mensaje");
            ResponseObjects.ApiResponse<ResponseObjects.MessageToGroupResponse> response = sdk.Messages.SendToContact(msisdn, "Prueba de mensaje");
            Console.WriteLine("HTTP Response [{0}]: {1}", (int)response.httpCode, response.httpDescription);
            Console.WriteLine("JSON: {0}", response.response);
            Console.WriteLine("----");

            if (response.isOk)
            {
                Console.WriteLine("Enviado: {0}", response.data.sms_sent);
                Console.WriteLine("Mensaje: {0}", response.data.sms_message);
            }
            else
            {
                Console.WriteLine("Error[{0}]: {1}", response.errorCode, response.errorDescription);
            }

        }

Para ver el ejemplo completo visita [ApiExample/Program.cs](https://github.com/interactuamovil/im-contactosms-sdk-dotnet/blob/master/sdk/ApiExample/Program.cs)

Descarga
--------
Para ver las últimas versiones y descargar fuentes y binarios (dlls): [Descargas](https://github.com/interactuamovil/im-contactosms-sdk-dotnet/releases)


