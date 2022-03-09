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
    public static class Adaptador 
    {

        public static Autorizacion ObtenerAutorizacion()
        {
            string GUID = "267A16AF-7368-403C-A161-D037A8E92774";

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
                FECAERequest FECAERequest = new AFIPService.FECAERequest();
                var FECAECABRequest = new AFIPService.FECAECabRequest();
                var FEDETReq = new AFIPService.FEDetRequest();
                var FECAEDETRequest = new AFIPService.FECAEDetRequest();
                FECAEDetRequest[] detalle = new AFIPService.FECAEDetRequest[1];


                //FEAuthRequest 
                FEAuthRequest.Cuit = autorizacion.Cuit;
                FEAuthRequest.Sign = autorizacion.Sign;
                FEAuthRequest.Token = autorizacion.Token;


                //FECAECABRequest
                FECAECABRequest.CantReg = comprobante.Venta.LineasdeVenta.Count();
                FECAECABRequest.CbteTipo = comprobante.TipodeComprobante.GetHashCode();
                FECAECABRequest.PtoVta = 2;


                //FECAEDETRequest
                FECAEDETRequest.Concepto =1;//PRODUCTOS 
                FECAEDETRequest.DocTipo = 80;
                FECAEDETRequest.DocNro = comprobante.Venta.Cliente.Cuit;
                FECAEDETRequest.CbteDesde = 1;
                FECAEDETRequest.CbteHasta = 1;
                FECAEDETRequest.CbteFch = $"{comprobante.Fecha}";
                FECAEDETRequest.ImpTotal = comprobante.Venta.Pago.MontoAPagar;
                FECAEDETRequest.ImpTotConc = comprobante.Venta.LineasdeVenta.Sum(x=>x.Stock.Producto.Costo);
                FECAEDETRequest.ImpNeto = comprobante.Venta.LineasdeVenta.Sum(x=>x.Stock.Producto.NetoGravado);
                FECAEDETRequest.ImpOpEx = comprobante.Venta.LineasdeVenta.Sum(x => x.Stock.Producto.NetoGravado);
                FECAEDETRequest.ImpTrib = comprobante.Venta.LineasdeVenta.Sum(x => x.Stock.Producto.NetoGravado) * ReglasDeNegocio.IVA;
                FECAEDETRequest.ImpIVA = ReglasDeNegocio.IVA;
                FECAEDETRequest.MonId = "PES";
                FECAEDETRequest.MonCotiz = 1;

                detalle[0] = FECAEDETRequest;

                //FEDETReq
                FECAERequest.FeCabReq = FECAECABRequest;
                FECAERequest.FeDetReq = detalle;

                if (serviceAFIP != null)
                {
                    var TIP = serviceAFIP.FECompUltimoAutorizado(FEAuthRequest,2,comprobante.TipodeComprobante.GetHashCode());

                    if (TIP!=null)
                    {
                        return serviceAFIP.FECAESolicitar(FEAuthRequest, FECAERequest);
                    }
                   
                }

                return null;

            }
        }




    }
}
