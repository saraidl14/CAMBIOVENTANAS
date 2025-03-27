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
                                          "especialmente cuando se trata de misiones que requieren destruir al enemigo." +
                                          "Los dragones rojos son conocidos por su alto temperamento, especialmente los colas de escorpión, si por mala fortuna llegas a ofender a uno, te puedes considerar muerto. Es por ello que se debe tener un respéto máximo hacia ellos y nunca mirarle a los ojos. Ice, Slice, Cath, Ghrian y Thoirt son dragones rojos.\r\n\r\n"
            }
            
        });
    }
}