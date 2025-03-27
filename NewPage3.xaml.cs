namespace CAMBIOVENTANAS;

public partial class NewPage3 : ContentPage
{
	public NewPage3()
	{
		InitializeComponent();
	}
    private void DetallesBTN(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Detalles
        {

            BindingContext = new Class1 { Texto = "Los Dragones Rojos" ,
                                          Image1= "rojo.png",
                                          Description= "Los dragones rojos son los guerreros definitivos, con una fuerza imparable y una naturaleza feroz. " +
                                          "Son dominantes en combate y son temidos por su poder destructivo, " +
                                          "especialmente cuando se trata de misiones que requieren destruir al enemigo."
            }
            
        });
    }
}