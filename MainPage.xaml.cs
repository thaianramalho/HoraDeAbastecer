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

            try
            {

                double gasolina = Convert.ToDouble(txt_gasolina.Text);
                double etanol = Convert.ToDouble(txt_etanol.Text);

                double porcentagem = (etanol / gasolina) * 100;
                double diferenca = gasolina * 0.7 - etanol;

                string msg = $"O preço do etanol está a {porcentagem:F2}% do preço da gasolina.";
                string recomendacao;
                
                if(etanol <= gasolina * 0.7)
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
    }

}
