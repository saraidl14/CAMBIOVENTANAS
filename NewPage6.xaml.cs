namespace CAMBIOVENTANAS;

public partial class NewPage6 : ContentPage
{
	public NewPage6()
	{
		InitializeComponent();
	}
    private void DetallesBTN(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Detalles
        {

            BindingContext = new Class1
            {
                Texto = "Los Dragones Negros",
                Image1 = "negro2.png",
                Description = "Estos son los m�s raros de su especie. Tambi�n son los m�s astutos, inteligente y exigentes. " +
                "Esto hace que sea pr�cticamente imposible enga�arlos. Originalmente, eclosionaban en el " +
                "Valle sobre Riorson House, que estaba calentado por la energ�a t�rmica de la zona. Todos ellos descienden de la  la astuta l�nea Dubhmadinn.\r\n\r\n" +
                "Los dragones negros son conocidos por su poder y resistencia. Son dragones imponentes, con una gran capacidad para la batalla. " +
                "Son temidos por su fuerza bruta y habilidad en combate, lo que los convierte en protectores formidables y letales en el aire.\r\n\r\n" +
                "Son conocidos por su poder y resistencia. Son dragones imponentes, con una gran capacidad para la batalla. Son temidos por su fuerza bruta y habilidad en combate, lo que los convierte en protectores formidables y letales en el aire.\r\n\r\n"

            }

        });
    }
}