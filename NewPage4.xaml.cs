namespace CAMBIOVENTANAS;

public partial class NewPage4 : ContentPage
{
	public NewPage4()
	{
		InitializeComponent();
	}
    private void DetallesBTN(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Detalles
        {

            BindingContext = new Class1 { Texto = "Los dragones Verdes" ,
                Image1 = "verde2.png",
                Description = "Los dragones verdes se destacan por su conexión con la naturaleza y su capacidad de camuflaje. " +
                "Son excelentes en operaciones de sigilo y emboscadas, utilizando su entorno a su favor para sorprender a sus enemigos." +
                "Se les asume como los dragones más listos e inteligentes de todos."
            }

        });
    }
}