
namespace Ejercicio1;

public partial class FormFeriados : Form
{
    public FormFeriados()
    {
        InitializeComponent();
    }

    private void mCCalendario_DateSelected(object sender, DateRangeEventArgs e)
    {
        DialogResult = DialogResult.Retry;
    }
}
