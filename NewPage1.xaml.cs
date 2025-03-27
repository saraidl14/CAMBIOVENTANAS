namespace CAMBIOVENTANAS;

/// <summary>
/// Clase que se encarga de mostrar la ventana de NewPage1, la del drag�n marr�n.
/// </summary>
public partial class NewPage1 : ContentPage
{
    /// <summary>
    /// El constructor de la clase NewPage1
    /// </summary>
    public NewPage1()
	{
		InitializeComponent();
	}
    /// <summary>
    /// M�todo que se encarga de cambiar de ventana al hacer click en el bot�n.
    /// Es el que va a hacer que al clickar en detalles se nos muestren.
    /// </summary>
    /// <param name="sender">Objeto que activa el evento</param>
    /// <param name="e">Argumentos del evento que ayuda a la funcion</param>
    private void DetallesBTN(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Detalles
        {
            // Navega a la p�gina de detalles y asigna la informaci�n del drag�n marr�n.

            BindingContext = new Class1 { Texto = "Los Dragones Marrones",
                Image1 = "marron2.png",
                Description = "Los dragones marrones son un armaz�n de carne y hueso. Son equilibrados en sus habilidades, " +
                "combinando fuerza y resistencia con una buena capacidad para la maniobra. " +
                "Su versatilidad los convierte en una opci�n s�lida para cualquier jinete.\r\n\r\n" +
                "Poco se sabe realmente de esta raza de drag�n, pero una cosa es clara no muestres debilidad ante ellos. " +
                "Como es bien sabido por todos, es mejor no mostrar miedo ante ellos, o podr�as acabar chamuscado y reducido a cenizas.\r\n\r\n" +
                " Esto por supuesto aplica a todos los dragones." 
            }

        });
    }
}