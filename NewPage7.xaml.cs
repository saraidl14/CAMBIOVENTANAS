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
                Description = "Los dragones azules son r�pidos y esquivos. Su capacidad para maniobrar en el aire es sobresaliente, lo que los hace casi invencibles en combates a�reos.\r\n\r\n " +
                "Suelen ser los preferidos para misiones que requieren rapidez y precisi�n." +
                "Estos son dragones de gran tama�o, tambi�n se considera que son los m�s despiadados de todas las razas. Especialmente el Cola de daga azul, que es el mas raro de ellos. \r\n\r\n" +
                "Las p�as de su cola, que tienen forma de cuchillas afiladas podr�an destripar a cualquier enemigo con un solo movimiento. Por ello es mejor no acercarse a ning�n drag�n azul. Estos provienen de la l�nea Gormfaileas.\r\n\r\n"

            }

        });
    }
}