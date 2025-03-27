namespace CAMBIOVENTANAS;
/// <summary>
/// clase que se encarga de mostrar la ventana de NewPage9, la del drag�n dorado.
/// </summary>
public partial class NewPage9 : ContentPage
{/// <summary>
 /// El constructor de la clase NewPage9, la del drag�n dorado.
 /// </summary>>
    public NewPage9()
	{
		InitializeComponent();
	}
    /// <summary>
    /// Permite cambiar de ventana al hacer click en el bot�n.
    /// Muestra los detalles del drag�n dorado.
    /// M�todo que se encarga de cambiar de ventana al hacer click en el bot�n.
    /// </summary>
    /// param name="sender">Objeto que activa el evento</param>
    /// param name="e">Argumentos del evento que ayuda a la funcion</param>
    private void DetallesBTN(object sender, EventArgs e)
    {
     
        Navigation.PushAsync(new Detalles
        {
            // Navega a la p�gina de detalles y asigna la informaci�n del drag�n dorado.
            BindingContext = new Class1
            {
                Texto = "Los Dragones Dorados",
                Image1 = "dorado.png",
                Description = "Los dragones dorados destacan por su velocidad y agilidad. \r\n\r\n" +
                "Son m�s peque�os en comparaci�n con otros tipos, pero compensan con su capacidad para maniobras r�pidas y evasivas. Son astutos y pueden superar a sus oponentes con destreza en lugar de fuerza.\r\n\r\n"

            }

        });
    }
}