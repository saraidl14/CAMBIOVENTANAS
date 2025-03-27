namespace CAMBIOVENTANAS;
/// <summary>
/// Clase que se encarga de mostrar la ventana de NewPage1, la del drag�n marr�n.
/// </summary>
public partial class NewPage4 : ContentPage
{
    /// <summary>
    /// El constructor de la clase NewPage4, la del drag�n verde.
    /// </summary>
	public NewPage4()
	{
		InitializeComponent();
	}
    private void DetallesBTN(object sender, EventArgs e)
    /// <summary>
    /// M�todo que se encarga de cambiar de ventana al hacer click en el bot�n.
    /// Es el que va a hacer que al clickar en detalles se nos muestren.
    /// </summary>
    /// param name="sender">Objeto que activa el evento</param>
    /// param name="e">Argumentos del evento que ayuda a la funcion</param>
    {
        Navigation.PushAsync(new Detalles
        {
            // Navega a la p�gina de detalles y asigna la informaci�n del drag�n verde.

            BindingContext = new Class1 { Texto = "Los dragones Verdes" ,
                Image1 = "verde2.png",
                Description = "Los dragones verdes se destacan por su conexi�n con la naturaleza y su capacidad de camuflaje. " +
                "Son excelentes en operaciones de sigilo y emboscadas, utilizando su entorno a su favor para sorprender a sus enemigos." +
                "Se les asume como los dragones m�s listos e inteligentes de todos.\r\n\r\n" +
                "Estos destacan por su agudo intelecto y su sentido del honor y el respeto. Adem�s, son las armas de asedio perfectas. Se recomienda, en el caso de cruzarse con uno, que se baje la cabeza a modo de respeto y se suplique clemencia por su parte. Adem�s, nunca se debe retroceder ante ellos.\r\n\r\nEstos dragones verdes tienen dos l�neas descendientes:\r\n\r\nLa honorable l�nea Uaineloidsig que ofreci� sus ancestrales lugares de eclosi�n para el bien de los dragones en lo que ahora es el Basgiath (el colegio de guerra)\r\nLa l�nea Cruaidhuaine, que tiene una conexi�n especialmente estable con la magia. Se cree que son el resultado de su naturaleza defensiva m�s razonable."
            }

        });
    }
}