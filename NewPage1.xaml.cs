namespace CAMBIOVENTANAS;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
	}
    private void DetallesBTN(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Detalles
        {

            BindingContext = new Class1 { Texto = "Los Dragones Marrones",
                Image1 = "marron2.png",
                Description = "Los dragones marrones son un armaz�n de carne y hueso. Son equilibrados en sus habilidades, " +
                "combinando fuerza y resistencia con una buena capacidad para la maniobra. " +
                "Su versatilidad los convierte en una opci�n s�lida para cualquier jinete."+
                "Como es bien sabido por todos, es mejor no mostrar miedo ante ellos, o podr�as acabar chamuscado y reducido a cenizas."+
                " Esto por supuesto aplica a todos los dragones."

            }

        });
    }
}