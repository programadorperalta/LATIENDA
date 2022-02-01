using LATIENDA.Dominio.Entidades;
using LATIENDA.Infraestructura.Cliente.AccesoExterno.AFIPService;
using LATIENDA.Infraestructura.Cliente.AccesoExterno.LoginService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LATIENDA.Infraestructura.Cliente.AccesoExterno
{
    public static  class Adaptador
    {
        public static Autorizacion ObtenerAutorizacion(string GUID)
        {
            using (var servicio = new LoginService.LoginServiceClient())
            {
                if (servicio != null)
                {
                    return servicio.SolicitarAutorizacion(GUID);
                }

                return null;

            }
        }

        public static FECAEResponse ObtenerCAEResponse(Autorizacion autorizacion, Comprobante comprobante)
        {
            using (var serviceAFIP = new AFIPService.ServiceSoapClient())
            {

                var FEAuthRequest = new AFIPService.FEAuthRequest();
                var FECAERequest = new AFIPService.FECAERequest();
                var FECAECABRequest = new AFIPService.FECAECabRequest();
                var FEDETReq = new AFIPService.FEDetRequest();

                //FEAuthRequest 
                FEAuthRequest.Cuit = autorizacion.Cuit;
                FEAuthRequest.Sign = autorizacion.Sign;
                FEAuthRequest.Token = autorizacion.Token;
                FEAuthRequest.ExtensionData = autorizacion.ExtensionData;

                //FECAECABRequest
                //FECAECABRequest.CantReg = comprobante.Venta.Productos.Count();
                FECAECABRequest.CbteTipo = comprobante.TipodeComprobante.GetHashCode();
                FECAECABRequest.PtoVta = 16;

                //FEDETReq
                FECAERequest.FeCabReq = FECAECABRequest;


                if (serviceAFIP != null)
                {
                    var TIP = serviceAFIP.FECompUltimoAutorizado(FEAuthRequest, 16, 3);
                    int numeroComprobante = TIP.CbteNro;


                    return serviceAFIP.FECAESolicitar(FEAuthRequest, FECAERequest);
                }

                return null;

            }
        }




    }
}
