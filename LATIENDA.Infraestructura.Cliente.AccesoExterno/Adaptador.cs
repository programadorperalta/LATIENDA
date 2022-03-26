using LATIENDA.Dominio.Entidades;
using LATIENDA.Infraestructura.Cliente.AccesoExterno.AFIPService;
using LATIENDA.Infraestructura.Cliente.AccesoExterno.LoginService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LATIENDA.Dominio;


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

        public static FECAEResponse ObtenerCAEResponse(Autorizacion autorizacion, Venta venta)
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

                var TIP = serviceAFIP.FECompUltimoAutorizado(FEAuthRequest, 16, venta.Comprobante.TipodeComprobante.GetHashCode());

                var response = serviceAFIP.FEDummy();

                var acumulador =+ TIP.CbteNro;

                //FECAECABRequest
                FECAECABRequest.CantReg = venta.LineasdeVenta.Count();
                FECAECABRequest.CbteTipo = venta.Comprobante.TipodeComprobante.GetHashCode();
                FECAECABRequest.PtoVta = 16;


                switch (venta.Cliente.TipoDeDocumento)
                {
                    case TipoDeDocumento.CUIL:
                        FECAEDETRequest.DocTipo = TipoDeDocumento.CUIL.GetHashCode();
                        break;

                    case TipoDeDocumento.CUIT:
                        FECAEDETRequest.DocTipo = TipoDeDocumento.CUIT.GetHashCode();
                        break;
                }


                //FECAEDETRequest
                FECAEDETRequest.Concepto =1;//PRODUCTOS 
                //FECAEDETRequest.DocTipo = 80;
                FECAEDETRequest.DocNro = venta.Cliente.Cuit;
                FECAEDETRequest.CbteDesde = acumulador;
                FECAEDETRequest.CbteHasta = acumulador;
                //CbteDesde y Hasta tienen que tener el mismo valor en este caso. 
                FECAEDETRequest.CbteFch = $"{venta.Comprobante.Fecha}";
                FECAEDETRequest.ImpTotal = venta.Pago.MontoAPagar;
                FECAEDETRequest.ImpTotConc = venta.LineasdeVenta.Sum(x=>x.Stock.Producto.Costo);
                FECAEDETRequest.ImpNeto = venta.LineasdeVenta.Sum(x=>x.Stock.Producto.NetoGravado);
                FECAEDETRequest.ImpOpEx = venta.LineasdeVenta.Sum(x => x.Stock.Producto.NetoGravado);
                FECAEDETRequest.ImpTrib = venta.LineasdeVenta.Sum(x => x.Stock.Producto.NetoGravado) * ReglasDeNegocio.IVA;
                FECAEDETRequest.ImpIVA = venta.LineasdeVenta.Sum(x=>x.Stock.Producto.CostoConIva);
                FECAEDETRequest.MonId = "PES";
                FECAEDETRequest.MonCotiz = 1;

                //for (int i = 0; i < venta.LineasdeVenta.Count(); i++)
                //{
                //    detalle[i] = FECAEDETRequest;
                //}

                detalle[0] = FECAEDETRequest;

                //FEDETReq
                FECAERequest.FeCabReq = FECAECABRequest;
                FECAERequest.FeDetReq = detalle;

                if (serviceAFIP != null)
                {
                    return serviceAFIP.FECAESolicitar(FEAuthRequest, FECAERequest);
                }

                return null;

            }
        }




    }
}
