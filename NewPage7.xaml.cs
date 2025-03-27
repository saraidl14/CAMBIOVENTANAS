namespace CAMBIOVENTANAS;

public partial class NewPage7 : ContentPage
{
	public NewPage7()
	{
		InitializeComponent();
	}
    private void DetallesBTN(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Detalles
        {

            BindingContext = new Class1
            {
                Texto = "Los Dragones Azules",
                Image1 = "azul2.png",
                Description = "Los dragones azules son rápidos y esquivos. Su capacidad para maniobrar en el aire es sobresaliente, lo que los hace casi invencibles en combates aéreos.\r\n\r\n " +
                "Suelen ser los preferidos para misiones que requieren rapidez y precisión." +
                "Estos son dragones de gran tamaño, también se considera que son los más despiadados de todas las razas. Especialmente el Cola de daga azul, que es el mas raro de ellos. \r\n\r\n" +
                "Las púas de su cola, que tienen forma de cuchillas afiladas podrían destripar a cualquier enemigo con un solo movimiento. Por ello es mejor no acercarse a ningún dragón azul. Estos provienen de la línea Gormfaileas.\r\n\r\n"

            }

        });
    }
}