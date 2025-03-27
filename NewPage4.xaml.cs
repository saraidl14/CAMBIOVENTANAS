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
                "Se les asume como los dragones más listos e inteligentes de todos." +
                "Estos destacan por su agudo intelecto y su sentido del honor y el respeto. Además, son las armas de asedio perfectas. Se recomienda, en el caso de cruzarse con uno, que se baje la cabeza a modo de respeto y se suplique clemencia por su parte. Además, nunca se debe retroceder ante ellos.\r\n\r\nEstos dragones verdes tienen dos líneas descendientes:\r\n\r\nLa honorable línea Uaineloidsig que ofreció sus ancestrales lugares de eclosión para el bien de los dragones en lo que ahora es el Basgiath (el colegio de guerra)\r\nLa línea Cruaidhuaine, que tiene una conexión especialmente estable con la magia. Se cree que son el resultado de su naturaleza defensiva más razonable."
            }

        });
    }
}