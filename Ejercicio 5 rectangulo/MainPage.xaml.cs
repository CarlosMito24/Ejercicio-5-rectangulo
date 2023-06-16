namespace Ejercicio_5_rectangulo;

///<Summary>
///<Createddate> 2022/06/16 </Createddate>
///<company> INDEL </company>
///<lastmodificationdate> 2022/06/16 </lastmodificationdate>
///<lastmodificationdescription>
/// Se realizo el diseño y se configuró el código cs de la app
///</lastmodificationdescription>
///<lastmodifierautor> Carlos Mito </lastmodifierautor>
///</Summary>

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void OnButtonClicked(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(Base.Text) && !string.IsNullOrEmpty(Altura.Text))
        {
            double b, h, area, perimetro, bdoble, hdoble;
            b = Convert.ToDouble(Base.Text);
            h = Convert.ToDouble(Altura.Text);
            area = b * h;
            bdoble = b * 2;
            hdoble = h * 2;
            perimetro = bdoble + hdoble;
            AreaFinal.Text = Convert.ToString(area);
            PerimetroFinal.Text = Convert.ToString(perimetro);
        }
        else
        {
            DisplayAlert("Error", "Introduce todos los números", "Ok");
        }
    }
}