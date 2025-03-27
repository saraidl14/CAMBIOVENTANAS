namespace CAMBIOVENTANAS;

public partial class NewPage8 : ContentPage
{
	public NewPage8()
	{
		InitializeComponent();
	}
    private void DetallesBTN(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Detalles
        {

            BindingContext = new Class1
            {
                Texto = "Los Dragones Desconocidos",
                Image1 = "desconocido.png",
                Description = "Hay un tipo de dragones del que no se sabe nada pues se creían extintos, unos con un linaje especial." +
                "Hay dragones cuyo color y habilidades específicas no se conocen, lo que los convierte en un misterio. Estos dragones pueden poseer habilidades únicas que aún no han sido descubiertas o reveladas.\r\n\r\n" +
                "Se los conoce como Iridos y no tienen un color como tal."

            }

        });
    }
}