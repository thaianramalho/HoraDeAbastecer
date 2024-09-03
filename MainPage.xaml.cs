namespace HoraDeAbastecer
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCalcularClicked(object sender, EventArgs e)
        {

            if (double.TryParse(txt_gasolina.Text, out double gasolina) && double.TryParse(txt_etanol.Text, out double etanol))
            {

                try
                {

                    double porcentagem = (etanol / gasolina) * 100;
                    double diferenca = gasolina * 0.7 - etanol;

                    string msg = $"O preço do etanol está a {porcentagem:F2}% do preço da gasolina.";
                    string recomendacao;

                    if (etanol <= gasolina * 0.7)
                    {
                        recomendacao = "Recomendação: abasteça com etanol.";
                    }
                    else
                    {
                        recomendacao = "Recomendação: abasteça com gasolina.";
                    }

                    string msgFinal = $"{msg}\n\n{recomendacao}\nDiferença: R$ {diferenca:F2}";


                    DisplayAlert("Resultado", msgFinal, "Ok");

                }
                catch (Exception ex)
                {
                    DisplayAlert("Ocorreu um erro!", "Erro:" + ex.Message, "Fechar");

                }

            }
            else
            {
                DisplayAlert("Erro de Entrada", "Por favor, insira valores numéricos válidos para gasolina e etanol.", "Ok");
            }
        }

    }

}
