using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;

namespace WebApplication.ws
{
    [ServiceContract(Namespace = "BusService")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class BusService
    {
        // Para usar HTTP GET, agregue el atributo [WebGet]. (El valor predeterminado de ResponseFormat es WebMessageFormat.Json)
        // Para crear una operación que devuelva XML,
        //     agregue [WebGet(ResponseFormat=WebMessageFormat.Xml)]
        //     e incluya la siguiente línea en el cuerpo de la operación:
        //         WebOperationContext.Current.OutgoingResponse.ContentType = "text/xml";
        [OperationContract]
        public void DoWork()
        {
            // Agregue aquí la implementación de la operación
            return;
        }
        [OperationContract]
        [WebInvoke(Method = "POST",  BodyStyle = WebMessageBodyStyle.Wrapped,  ResponseFormat = WebMessageFormat.Json )]
        public void Prueba(string x) {

            string z = string.Empty;
                z=x;
        }

        // Agregue aquí más operaciones y márquelas con [OperationContract]
    }
}
