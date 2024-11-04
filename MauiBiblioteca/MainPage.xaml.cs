using Biblioteca.Modelo;

namespace MauiBiblioteca;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnAdicionarLivroClicked(object sender, EventArgs e)
	{
		Livro livro = new()
		{

			LivroId = count++,
			Titulo = TituloEntry.Text,
			Autor = AutorEntry.Text,
			Genero = GeneroEntry.Text,
			Disponivel = DisponivelSwitch.IsToggled,
		};

		ResultadoLabel.Text = livro.ToString();
	}
}

