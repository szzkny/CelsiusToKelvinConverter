namespace CelsiusToKelvinConverter
{
    public partial class form_converter : Form
    {

        double kelvinValue = 273.25;
        double result = 0;

        public form_converter()
        {
            InitializeComponent();
        }

        private void btn_convert_Click(object sender, EventArgs e)
        {
            result = kelvinValue + Double.Parse(txt_input.Text);
            lbl_result.Text = result.ToString();
        }
    }
}