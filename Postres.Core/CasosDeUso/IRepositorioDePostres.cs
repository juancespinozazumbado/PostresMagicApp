

using Postres.Core.Dominio;

namespace Postres.Core.CasosDeUso
{
    public interface IRepositorioDePostres
    {
        void AgregarUnPostre(Postre postre);
        Postre[] ObtenerListaDePostres();
        Postre ObtenerUnPostrePorId(string Id);
        Postre[] ObtenerUnPostrePorNombre(string nombre);

        void AgregarUnIngrediente(string Id, Ingrediente ingrediente);
        void EliminarUnIngrediente(string Id_Postre, string Id_Ingrediente);    
        bool DarDeAltaUnPostre(string Id);
        bool DarDeBajaUnPostre(string Id);
    }
}
