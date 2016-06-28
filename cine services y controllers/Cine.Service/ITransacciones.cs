using Cine.Service.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Cine.Service.Data;

namespace Cine.Service
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "ITransacciones" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface ITransacciones
    {

        #region .COLABORADOR.
        [OperationContract]
        Colaborador crearColaborador(Colaborador nuevoColaborador);

        [OperationContract]
        IList<Colaborador> ListarColaborador();

        [OperationContract]
        Colaborador actualizarColaborador(Colaborador colaboradorActualizar);

        [OperationContract]
        Colaborador obtenerColaborador(int id);

        [OperationContract]
        Colaborador eliminarColaborador(Colaborador colaboradorEliminar);

        //[OperationContract]
        //bool Login(ColaUser cola);
        #endregion  

        #region .PELICULA .
        [OperationContract]
        Pelicula crearPelicula(Pelicula nuevaPelicula);

        [OperationContract]
        IList<Pelicula> ListarPelicula();

        [OperationContract]
        Pelicula  actualizarPelicula(Pelicula peliculaActualizar);

        [OperationContract]
        Pelicula obtenerPelicula(int id);

        //[OperationContract]
        //Pelicula eliminarPelicula(Pelicula peliculaEliminar);

        #endregion

        #region .ESPECTADOR.

        [OperationContract]
        Espectador crearEspectador(Espectador nuevoEspectador);

        [OperationContract]
        IList<Espectador> ListarEspectador();

        [OperationContract]
        Espectador actualizarEspectador(Espectador espectadorActualizar);

        [OperationContract]
        Espectador obtenerEspectador(int id);

        [OperationContract]
        Espectador eliminarEspectador(Espectador espectadorEliminar);


        #endregion

        #region -Combo-
        [OperationContract]
        Combo crearCombo(Combo nuevoCombo);

        [OperationContract]
        IList<Combo> ListarCombo();

        [OperationContract]
        Combo actualizarCombo(Combo ComboActualizar);

        [OperationContract]
        Combo obtenerCombo(int id);

        [OperationContract]
        Combo eliminarCombo(Combo ComboEliminar);
        #endregion

        #region -Producto-
        [OperationContract]
        Producto crearProducto(Producto nuevoProducto);

        [OperationContract]
        IList<Producto> ListarProducto();

        [OperationContract]
        Producto actualizarProducto(Producto ProductoActualizar);

        [OperationContract]
        Producto obtenerProducto(int id);

        [OperationContract]
        Producto eliminarProducto(Producto ProductoEliminar);
        #endregion

        #region .COMPRA.
        [OperationContract]
        Compra crearCompra(Compra nuevoCompra);

        [OperationContract]
        IList<Compra> ListarCompras();

        [OperationContract]
        Compra obtenerCompra(int id);

        #endregion

        #region .LOCAL.
             
        [OperationContract]
        IList<Local> ListarLocales();

        [OperationContract]
        Local actualizarLocal(Local localActualizar);

        [OperationContract]
        Local obtenerLocal(int id);

        #endregion

        #region .SALA.
        [OperationContract]
        Sala crearSala(Sala nuevaSala);

        [OperationContract]
        IList<Sala> ListarSala();

        [OperationContract]
        Sala actualizarSala(Sala salaActualizar);

        [OperationContract]
        Sala obtenerSala(int id);

        //[OperationContract]
        //Sala eliminarSala(Sala SalaEliminar);


        #endregion

        #region -Cargo-
        [OperationContract]
        Cargo crearcargo(Cargo nuevocargo);

        [OperationContract]
        IList<Cargo> ListaCargo();

        [OperationContract]
        Cargo actualizarCargo(Cargo cargoActualizar);
        [OperationContract]
        Cargo obtenerCargo(int id);
        #endregion

        #region -genero-
        [OperationContract]
        Genero crearGenero(Genero nuevoGenero);

        [OperationContract]
        IList<Genero> ListarGenero();

        [OperationContract]
        Genero actualizarGenero(Genero GeneroActualizar);

        [OperationContract]
        Genero obtenerGenero(int id);

        [OperationContract]
        Genero eliminarGenero(Genero GeneroEliminar);
        #endregion

        #region -CARTELERA-
        [OperationContract]
        Cartelera crearCartelera(Cartelera nuevaCartelera);

        [OperationContract]
        IList<Cartelera> ListarCartelera();

        [OperationContract]
        Cartelera actualizarCartelera(Cartelera CarteleraActualizar);

        [OperationContract]
        Cartelera obtenerCartelera(int id);

        [OperationContract]
        Cartelera eliminarCartelera(Cartelera CarteleraEliminar);
        #endregion
        #region -Estenos-
         [OperationContract]
        Estrenos crearEstrenos (Estrenos nuevoEstreno);

        [OperationContract]
        IList<Estrenos> ListarEstrenos();

        [OperationContract]
        Estrenos actualizarEstrenos(Estrenos EstrenosActualizar);

        [OperationContract]
        Estrenos obtenerEstrenos(int id);

        [OperationContract]

        void EliminarEstreno(string idEstrenos);
        #endregion




    }
}
