namespace CAMBIOVENTANAS;
/// <summary>
/// clase que se encarga de mostrar la ventana de NewPage9, la del dragón dorado.
/// </summary>
public partial class NewPage9 : ContentPage
{/// <summary>
 /// El constructor de la clase NewPage9, la del dragón dorado.
 /// </summary>>
    public NewPage9()
	{
		InitializeComponent();
	}
    /// <summary>
    /// Permite cambiar de ventana al hacer click en el botón.
    /// Muestra los detalles del dragón dorado.
    /// Método que se encarga de cambiar de ventana al hacer click en el botón.
    /// </summary>
    /// param name="sender">Objeto que activa el evento</param>
    /// param name="e">Argumentos del evento que ayuda a la funcion</param>
    private void DetallesBTN(object sender, EventArgs e)
    {
     
        Navigation.PushAsync(new Detalles
        {
            // Navega a la página de detalles y asigna la información del dragón dorado.
            BindingContext = new Class1
            {
                Texto = "Los Dragones Dorados",
                Image1 = "dorado.png",
                Description = "Los dragones dorados destacan por su velocidad y agilidad. \r\n\r\n" +
                "Son más pequeños en comparación con otros tipos, pero compensan con su capacidad para maniobras rápidas y evasivas. Son astutos y pueden superar a sus oponentes con destreza en lugar de fuerza.\r\n\r\n"

            }

        });
    }
}