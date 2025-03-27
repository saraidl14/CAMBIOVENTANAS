namespace CAMBIOVENTANAS
{
    /// <summary>
    /// Clase que representa un modelo de datos para una p�gina de contenido.
    /// Hereda de ContentPage para poder ser utilizada en la interfaz de usuario.
    /// Esta clase se utiliza para mostrar la informaci�n de un drag�n en la p�gina de detalles.
    /// </summary>

    public class Class1 : ContentPage
	{
        /// <summary>
        /// Propiedad que almacena el texto que se mostrar� en la p�gina de detalles.
        /// </summary>
        public String Texto { get; set; }
        /// <summary>
        /// Propiedad que almacena la ruta de la imagen que se mostrar� en la p�gina de detalles.
        /// </summary>
		public String Image1 { get; set; }
        /// <summary>
        /// Propiedad que almacena la descripci�n que se mostrar� en la p�gina de detalles.
        /// </summary>
        public String Description { get; set; }
        
    }
}