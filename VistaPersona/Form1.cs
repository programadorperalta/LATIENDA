using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using VistaPersona.Models.Request;

namespace VistaPersona
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string url = "https://localhost:44346/api/Persona";
            PersonaRequest oPersona = new PersonaRequest();
            oPersona.Nombre = txtNombre.Text;

            string resultado = Send<PersonaRequest>(url, oPersona, "POST");

            MessageBox.Show(resultado);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public string Send<T>(string url, T objectRequest, string method = "POST")
        {
            string result = "";

            try
            {
                JavaScriptSerializer js = new JavaScriptSerializer();

                //serializamos el objeto
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(objectRequest);//envio la persona 

                //peticion
                WebRequest request = WebRequest.Create(url); // hace la solicitud
                //headers
                request.Method = method;
                request.PreAuthenticate = true;
                request.ContentType = "application/json;charset=utf-8'";
                request.Timeout = 10000; //esto es opcional

                using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                {
                    streamWriter.Write(json); // escribirlo en el body 
                    streamWriter.Flush(); 
                }

                var httpResponse = (HttpWebResponse)request.GetResponse(); //envia la respuesta EXITO si salio todo bien 
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                   result = streamReader.ReadToEnd();
                }
                //oReply.success = 1;
                ////y aquí va nuestra respuesta, la cual es lo que nos regrese el sitio solicitado
                //oReply.data = result;
            }
            catch (Exception e)
            {

                //oReply.result = 0;
                ////en caso de error lo manejamos en el mensaje
                //oReply.menssage = e.Message;
                result = e.Message;

            }
            return result;
        }
    }

}


