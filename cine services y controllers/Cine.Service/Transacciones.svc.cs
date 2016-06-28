using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Cine.Service.Persistencia;
using Cine.Service.Dominio;




namespace Cine.Service
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Transacciones" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Transacciones.svc o Transacciones.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Transacciones : ITransacciones
    {


        #region .DAO.
        /// COLABORADOR
        /// COLABORADOR
        private ColaboradorDAO colaboradorDAO = null;
        private ColaboradorDAO ColaboradorDAO
        {
            get
            {
                if (colaboradorDAO == null)
                    colaboradorDAO = new ColaboradorDAO();
                return colaboradorDAO;
            }
        }


        /// PELICULA
        /// PELICULA
        private PeliculaDAO peliculaDAO = null;
        private PeliculaDAO PeliculaDAO
        {
            get 
            {
                if (peliculaDAO == null)
                    peliculaDAO = new PeliculaDAO();
                return peliculaDAO;            
            }
        }

        /// ESPECTADOR
        ///  ESPECTADOR
        private EspectadorDAO espectadorDAO = null;
        private EspectadorDAO EspectadorDAO
        {
            get 
            {
                if (espectadorDAO == null)
                    espectadorDAO = new EspectadorDAO();
                return espectadorDAO;
            }                
        }

        /// COMPRA
        /// COMPRA
        private CompraDAO compraDAO = null;
        private CompraDAO CompraDAO
        {
            get
            {
                if (compraDAO == null)
                    compraDAO = new CompraDAO();
                return compraDAO;
            }
        }

        ///LOCAL
        ///LOCAL
        private LocalDAO localDAO = null;
        private LocalDAO LocalDAO
        {
            get
            {
                if (localDAO == null)
                    localDAO = new LocalDAO();
                return localDAO;
            }
        }


        ///SALA
        ///SALA
        private SalaDAO salaDAO = null;
        private SalaDAO SalaDAO
        {
            get
            {
                if (salaDAO == null)
                    salaDAO = new SalaDAO();
                return salaDAO;
            }
        }


        ///Cargo
        ///Cargo
        private CargoDAO cargoDAO = null;
        private CargoDAO CargoDAO
        {
            get
            {
                if (cargoDAO == null)
                    cargoDAO = new CargoDAO();
                return cargoDAO;
            }
        }

        /// COMBO
        /// COMBO
        private ComboDAO comboDAO = null;
        private ComboDAO ComboDAO
        {
            get
            {
                if (comboDAO == null)
                    comboDAO = new ComboDAO();
                return comboDAO;
            }
        }

        /// PRODUCTO
        /// PRODUCTO
        private ProductoDAO productoDAO = null;
        private ProductoDAO ProductoDAO
        {
            get
            {
                if (productoDAO == null)
                    productoDAO = new ProductoDAO();
                return productoDAO;
            }
        }

        /// GENERO
        /// GENERO
        private GeneroDAO generoDAO = null;
        private GeneroDAO GeneroDAO
        {
            get
            {
                if (generoDAO == null)
                    generoDAO = new GeneroDAO();
                return generoDAO;
            }
        }

         /// CARTELERA
        /// CARTELERA
        private CarteleraDAO carteleraDAO = null;
        private CarteleraDAO CarteleraDAO
        {
            get
            {
                if (carteleraDAO == null)
                    carteleraDAO = new CarteleraDAO();
                return carteleraDAO;
            }
        }

        /// ESTENOS
        /// ESTRENOS
        private EstrenosDAO estrenosDAO = null;
        private EstrenosDAO EstrenosDAO
        {
            get
            {
                if (estrenosDAO == null)
                    estrenosDAO = new EstrenosDAO();
                return estrenosDAO;
            }
        }
        
        #endregion

        #region .TCOLABORADOR.

        public Colaborador crearColaborador(Colaborador nuevoColaborador)
        {
            return ColaboradorDAO.Crear(nuevoColaborador);
        }

        public IList<Colaborador> ListarColaborador()
        {
            return ColaboradorDAO.ListarTodos();
        }

        public Colaborador actualizarColaborador(Colaborador colaboradorActualizar)
        {
            throw new NotImplementedException();
        }

        public Colaborador obtenerColaborador(int id)
        {
            throw new NotImplementedException();
        }

        public Colaborador eliminarColaborador(Colaborador colaboradorEliminar)
        {
            throw new NotImplementedException();
        }

        //public bool Login(ColaUser cola)
        //{
        //    Usuario dao = new Usuario();
        //    return dao.validar_user(cola);
            
        //}

        #endregion

        #region .PELICULA.
        public Pelicula crearPelicula(Pelicula nuevaPelicula)
        {
            return PeliculaDAO.Crear(nuevaPelicula);
        }

        public IList<Pelicula> ListarPelicula()
        {
            return PeliculaDAO.ListarTodos();
        }

        public Pelicula actualizarPelicula(Pelicula peliculaActualizar)
        {
            return PeliculaDAO.Modificar(peliculaActualizar);
        }

        public Pelicula obtenerPelicula(int id)
        {
            return PeliculaDAO.Obtener(id);
        }
        #endregion
        
        #region .TESPECTADOR.
        public Espectador crearEspectador(Espectador nuevoEspectador)
        {
            throw new NotImplementedException();
        }

        public IList<Espectador> ListarEspectador()
        {
            throw new NotImplementedException();
        }

        public Espectador actualizarEspectador(Espectador espectadorActualizar)
        {
            throw new NotImplementedException();
        }

        public Espectador obtenerEspectador(int id)
        {
            throw new NotImplementedException();
        }

        public Espectador eliminarEspectador(Espectador espectadorEliminar)
        {
            throw new NotImplementedException();
        }
        #endregion
        
        #region .TCOMPRA.
        public Compra crearCompra(Compra nuevoCompra)
        {
            throw new NotImplementedException();
        }

        public IList<Compra> ListarCompras()
        {
            throw new NotImplementedException();
        }

        public Compra obtenerCompra(int id)
        {
            throw new NotImplementedException();
        }
        #endregion
        
        #region .LOCAL.
        public IList<Local> ListarLocales()
        {
            throw new NotImplementedException();
        }

        public Local actualizarLocal(Local localActualizar)
        {
            throw new NotImplementedException();
        }

        public Local obtenerLocal(int id)
        {
            throw new NotImplementedException();
        }
        #endregion
        
        #region .SALA.
        public Sala crearSala(Sala nuevaSala)
        {
            throw new NotImplementedException();
        }

        public IList<Sala> ListarSala()
        {
            throw new NotImplementedException();
        }

        public Sala actualizarSala(Sala salaActualizar)
        {
            throw new NotImplementedException();
        }

        public Sala obtenerSala(int id)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region -Cargo-

        public Cargo crearcargo(Cargo nuevocargo)
        {
            return CargoDAO.Crear(nuevocargo);
        }

        public IList<Cargo> ListaCargo()
        {
            return CargoDAO.ListarTodos();
        }

        public Cargo actualizarCargo(Cargo cargoActualizar)
        {
            throw new NotImplementedException();
        }
       public Cargo obtenerCargo(int id)
        {
            return CargoDAO.Obtener(id);
            
        }
        #endregion

       #region -Combo-
       public Combo crearCombo(Combo nuevoCombo)
       {
           return ComboDAO.Crear(nuevoCombo);
       }

       public IList<Combo> ListarCombo()
       {
           return ComboDAO.ListarTodos();
       }

       public Combo actualizarCombo(Combo ComboActualizar)
       {
           return ComboDAO.Modificar(ComboActualizar);
       }

       public Combo obtenerCombo(int id)
       {
           return ComboDAO.Obtener(id);
       }

       public Combo eliminarCombo(Combo ComboEliminar)
       {
           throw new NotImplementedException();
       }

       #endregion

       #region -PRODUCTO-
       public Producto crearProducto(Producto nuevoProducto)
       {
           return ProductoDAO.Crear(nuevoProducto);
       }

       public IList<Producto> ListarProducto()
       {
           return ProductoDAO.ListarTodos();
       }

       public Producto actualizarProducto(Producto ProductoActualizar)
       {
           throw new NotImplementedException();
       }

       public Producto obtenerProducto(int id)
       {
           throw new NotImplementedException();
       }

       public Producto eliminarProducto(Producto ProductoEliminar)
       {
           throw new NotImplementedException();
       }

#endregion


        #region -GENERO-
       public Genero crearGenero(Genero nuevoGenero)
       {
           return GeneroDAO.Crear(nuevoGenero);
       }

       public IList<Genero> ListarGenero()
       {
           return GeneroDAO.ListarTodos();
       }

       public Genero actualizarGenero(Genero GeneroActualizar)
       {
           throw new NotImplementedException();
       }

       public Genero obtenerGenero(int id)
       {
           return GeneroDAO.Obtener(id);
       }

       public Genero eliminarGenero(Genero GeneroEliminar)
       {
           throw new NotImplementedException();
       }
        #endregion


       #region -Cartelera-
       public Cartelera crearCartelera(Cartelera nuevaCartelera)
       {
           return CarteleraDAO.Crear(nuevaCartelera);
       }

       public IList<Cartelera> ListarCartelera()
       {
           return CarteleraDAO.ListarTodos();
       }

       public Cartelera actualizarCartelera(Cartelera CarteleraActualizar)
       {
           return CarteleraDAO.Modificar(CarteleraActualizar);
       }

       public Cartelera obtenerCartelera(int id)
       {
           return CarteleraDAO.Obtener(id);
       }

       public Cartelera eliminarCartelera(Cartelera CarteleraEliminar)
       {
           throw new NotImplementedException();
       }
       #endregion



       #region -Estrenos-
       public Estrenos crearEstrenos(Estrenos nuevoEstreno)
       {
           return EstrenosDAO.Crear(nuevoEstreno);
       }

       public IList<Estrenos> ListarEstrenos()
       {
           return EstrenosDAO.ListarTodos();
       }

       public Estrenos actualizarEstrenos(Estrenos EstrenosActualizar)
       {
           return EstrenosDAO.Modificar(EstrenosActualizar);
       }

       public Estrenos obtenerEstrenos(int id)
       {
           return EstrenosDAO.Obtener(id);
       }

       public void EliminarEstreno(string idEstrenos)
       {
           int idPelicula = int.Parse(idEstrenos);
           var es = EstrenosDAO.Obtener(idPelicula);
           EstrenosDAO.Eliminar(es);
       }
       #endregion



      
    }
}
