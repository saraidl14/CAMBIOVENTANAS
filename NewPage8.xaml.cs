namespace CAMBIOVENTANAS;
/// <summary>
/// Clase que se encarga de mostrar la ventana de NewPage8, la del drag�n desconocido.
/// </summary>
public partial class NewPage8 : ContentPage
{
    /// <summary>
    /// Constructor de la clase NewPage8, dragones desconocidos.
    /// </summary>  
	public NewPage8()
	{
		InitializeComponent();
	}
    /// <summary>
    /// M�todo que se encarga de cambiar de ventana al hacer click en el bot�n.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void DetallesBTN(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Detalles
        {
            // Navega a la p�gina de detalles y asigna la informaci�n del drag�n desconocido.
            BindingContext = new Class1
            {
                Texto = "Los Dragones Desconocidos",
                Image1 = "desconocido.png",
                Description = "Hay un tipo de dragones del que no se sabe nada pues se cre�an extintos, unos con un linaje especial." +
                "Hay dragones cuyo color y habilidades espec�ficas no se conocen, lo que los convierte en un misterio. " +
                "Estos dragones pueden poseer habilidades �nicas que a�n no han sido descubiertas o reveladas.\r\n\r\n" +
                "Se los conoce como Iridos y no tienen un color como tal."

            }

        });
    }
}