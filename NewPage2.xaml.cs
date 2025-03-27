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
                                            "Son los más peligrosos de todos, son impredecibles y no se detendrán ante nada para lograr sus objetivos."

            }

        });
    }
}