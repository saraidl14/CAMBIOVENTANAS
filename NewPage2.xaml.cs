namespace CAMBIOVENTANAS;

public partial class NewPage2 : ContentPage
{
	public NewPage2()
	{
		InitializeComponent();
	}
    private void DetallesBTN(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Detalles
        {

            BindingContext = new Class1 { Texto = "Los Dragones Naranjas" ,
                                            Image1 = "naranja2.png",
                                            Description = "Los dragones naranjas son extremadamente letales, conocidos por su capacidad para atacar con ferocidad. " +
                                            "Su color vibrante refleja su naturaleza agresiva y su aptitud para misiones ofensivas, donde la fuerza bruta es esencial."+
                                            "Son los m�s peligrosos de todos, son impredecibles y no se detendr�n ante nada para lograr sus objetivos." +
                                            "Estos son los m�s impredecibles y suponen un gran riesgo. Su tono puede variar much�simo desde el tono albaricoque hasta la zanahoria. Se cree que los Esbens del Norte fueron el lugar de eclosi�n antes de la unificaci�n, aunque su naturaleza impredecible hace que elijan nuevos valles en el mismo rango. Estos provienen de la la l�nea Fhaicorain, Clady, Baide, Light  y Glane pertenecen a esta raza.\r\n\r\n"

            }

        });
    }
}