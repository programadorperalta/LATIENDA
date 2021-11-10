﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LATIENDA.Dominio;
using LATIENDA.Dominio.Entidades;
using LATIENDA.Infraestructura.Datos;
using LATIENDA.Presentacion.Interfaces;
using LATIENDA.Presentacion.Tareas;

namespace LATIENDA.Presentacion.Presentadores
{
    public class ModificarProductoPresentador : PresentadorBase<ProductoTarea, IModificarProductoVista>
    {
        private readonly IRepositorio _repositorio;
        private Producto _productoSource;

        public override ProductoTarea Tarea
        {
            get => base.Tarea;
            set
            {
                base.Tarea = value;
                EnviarProductoSource();
            }
        }

        public ModificarProductoPresentador(IModificarProductoVista vista, 
            IRepositorio repositorio) : base(vista)
        {
            _repositorio = repositorio;
        }

        private void EnviarProductoSource()
        {
            _productoSource = new Producto(_repositorio.BuscarProducto(Tarea.ProductoId));
            Vista.RecibirProducto(_productoSource);
        }

        public void ModificarProducto()
        {
            try
            {
                _repositorio.ModificarProducto(Tarea.ProductoId, _productoSource);
                Vista.MostrarMensaje("Producto modificado con exito.", Mensaje.EXITO);
            }
            catch (FormatException formatoExcepcion)
            {
                Vista.MostrarMensaje(formatoExcepcion.Message, Mensaje.ERROR);
            }
            catch (Exception existenciaException)
            {
                Vista.MostrarMensaje(existenciaException.Message, Mensaje.ERROR);
            }
        }
    }
}
