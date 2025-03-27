namespace CAMBIOVENTANAS;

public partial class NewPage9 : ContentPage
{
	public NewPage9()
	{
		InitializeComponent();
	}
    private void DetallesBTN(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Detalles
        {

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