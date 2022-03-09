using LATIENDA.Dominio;
using LATIENDA.Presentacion.Tareas;

namespace LATIENDA.Presentacion.Presentadores
{
    /// <summary>
    /// Extensión genérica de la interfaz <see cref="IPresentador"/>.
    /// Tiene asociaciones fuertemente tipadas a la tarea y a la vista del presentador
    /// para evitar conversiones de tipos.
    /// <para>
    /// En vez de implementar esta interfaz directamente conviene heredar de la clase
    /// <see cref="PresentadorBase{Task, View}"/> que la implementa.
    /// </para>
    /// </summary>
    /// <typeparam name="TTask">Representa el tipo de la tarea asociada. Debe ser un 
    /// subtipo de <see cref="ITarea"/></typeparam>
    /// <typeparam name="TView">Representa el tipo de la vista asociada.</typeparam>
    public interface IPresentador<TTask, TView,TSesion> : IPresentador
        where TTask : ITarea
        where TView : class
        where TSesion : ISesion
    {
        /// <summary>
        /// Propiedad para acceder a la tarea asociada al tipo genérico.
        /// <para>
        /// Utiliza la palabra reservada new para reutilizar el nombre de la propiedad
        /// definido en la interfaz <see cref="IPresentador"/>
        /// </para>
        /// </summary>
        new TTask Tarea { get; set; }
        /// <summary>
        /// Propiedad para acceder a la vista asociada al tipo genérico.
        /// <para>
        /// Utiliza la palabra reservada new para reutilizar el nombre de la propiedad
        /// definido en la interfaz <see cref="IPresentador"/>
        /// </para>
        /// </summary>
        new TView Vista { get; set; }
        new TSesion Sesion { get; set; }
    }
}
