using Biblioteca.Mock;

namespace Biblioteca
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            MockAutor.CarregaAutor();
            MockEditora.CarregaEditora();
            MockGenero.CarregaGenero();
            MockIdioma.CarregaIdioma();
            MockLivro.CarregaLivro();
            MockUsuario.CarregaUsuario();
            Application.Run(new FrmMenu());
        }
    }
}