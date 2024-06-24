using AtrapameEntidades;
using System.Reflection.Metadata;

namespace Ejercicio_I02___Atrapame_si_puedes
{
    //Este ejercicio esta logrado.
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtKilometros.Text == "" || txtLitros.Text == "")
                {
                    throw new ParametrosVaciosException("Se ingreso algun dato vacio");
                }

                richTextBox1.Text = $"Kl / Li: {Calculador.Calcular(int.Parse(txtKilometros.Text), int.Parse(txtLitros.Text))}";
            }
            catch (ParametrosVaciosException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(DivideByZeroException)
            {
                MessageBox.Show("El divisor no puede ser 0");
            }
            catch(ArgumentNullException)
            {
                MessageBox.Show("Se quizo dividir algo null");
            }
            catch(FormatException)
            {
                MessageBox.Show("El formato de entrada no es el correcto");
            }
            catch(OverflowException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
             

        }
    }
}
