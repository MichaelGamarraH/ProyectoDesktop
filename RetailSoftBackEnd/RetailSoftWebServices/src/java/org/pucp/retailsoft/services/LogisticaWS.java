package org.pucp.retailsoft.services;

import java.util.ArrayList;
import java.util.Date;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import org.pucp.retailsoft.logistica.dao.AlmacenDAO;
import org.pucp.retailsoft.logistica.dao.AlmacenxVehiculoDAO;
import org.pucp.retailsoft.logistica.dao.CategoriaProductoDAO;
import org.pucp.retailsoft.logistica.dao.CriterioControlCalidadDAO;
import org.pucp.retailsoft.logistica.dao.LoteDAO;
import org.pucp.retailsoft.logistica.dao.LotexCriterioControlCalidadDAO;
import org.pucp.retailsoft.logistica.dao.MarcaProductoDAO;
import org.pucp.retailsoft.logistica.dao.ProductoDAO;
import org.pucp.retailsoft.logistica.dao.ProductoxPromocionDAO;
import org.pucp.retailsoft.logistica.dao.PromocionDAO;
import org.pucp.retailsoft.logistica.dao.ProveedorDAO;
import org.pucp.retailsoft.logistica.dao.SubcategoriaProductoDAO;
import org.pucp.retailsoft.logistica.dao.TipoVehiculoDAO;
import org.pucp.retailsoft.logistica.dao.TransportistaDAO;
import org.pucp.retailsoft.logistica.dao.VehiculoDAO;
import org.pucp.retailsoft.logistica.model.Almacen;
import org.pucp.retailsoft.logistica.model.AlmacenxVehiculo;
import org.pucp.retailsoft.logistica.model.CategoriaProducto;
import org.pucp.retailsoft.logistica.model.CriterioControlCalidad;
import org.pucp.retailsoft.logistica.model.Lote;
import org.pucp.retailsoft.logistica.model.LotexCriterioControlCalidad;
import org.pucp.retailsoft.logistica.model.MarcaProducto;
import org.pucp.retailsoft.logistica.model.Producto;
import org.pucp.retailsoft.logistica.model.ProductoxPromocion;
import org.pucp.retailsoft.logistica.model.Promocion;
import org.pucp.retailsoft.logistica.model.Proveedor;
import org.pucp.retailsoft.logistica.model.SubcategoriaProducto;
import org.pucp.retailsoft.logistica.model.TipoVehiculo;
import org.pucp.retailsoft.logistica.model.Transportista;
import org.pucp.retailsoft.logistica.model.Vehiculo;
import org.pucp.retailsoft.logistica.mysql.AlmacenMySQL;
import org.pucp.retailsoft.logistica.mysql.AlmacenxVehiculoMySQL;
import org.pucp.retailsoft.logistica.mysql.CategoriaProductoMySQL;
import org.pucp.retailsoft.logistica.mysql.CriterioControlCalidadMySQL;
import org.pucp.retailsoft.logistica.mysql.LoteMySQL;
import org.pucp.retailsoft.logistica.mysql.LotexCriterioControlCalidadMySQL;
import org.pucp.retailsoft.logistica.mysql.MarcaProductoMySQL;
import org.pucp.retailsoft.logistica.mysql.ProductoMySQL;
import org.pucp.retailsoft.logistica.mysql.ProductoxPromocionMySQL;
import org.pucp.retailsoft.logistica.mysql.PromocionMySQL;
import org.pucp.retailsoft.logistica.mysql.ProveedorMySQL;
import org.pucp.retailsoft.logistica.mysql.SubcategoriaProductoMySQL;
import org.pucp.retailsoft.logistica.mysql.TipoVehiculoMySQL;
import org.pucp.retailsoft.logistica.mysql.TransportistaMySQL;
import org.pucp.retailsoft.logistica.mysql.VehiculoMySQL;


/**
 *
 * @author JOHAN
 */
@WebService(serviceName = "LogisticaWS")
public class LogisticaWS {
    private SubcategoriaProductoDAO daoSubcategoriaProducto = new SubcategoriaProductoMySQL();
    private MarcaProductoDAO daoMarcaProducto = new MarcaProductoMySQL();
    private CriterioControlCalidadDAO daoCriterioControlCalidad = new CriterioControlCalidadMySQL();
    private ProductoDAO daoProducto = new ProductoMySQL();
    private ProveedorDAO daoProveedor = new ProveedorMySQL();
    private AlmacenDAO daoAlmacen = new AlmacenMySQL();
    private TipoVehiculoDAO daoTipoVehiculo = new TipoVehiculoMySQL();
    private VehiculoDAO daoVehiculo = new VehiculoMySQL();
    private CategoriaProductoDAO daoCategoriaProducto = new CategoriaProductoMySQL();
    private LoteDAO daoLote = new LoteMySQL();
    private AlmacenxVehiculoDAO daoAlmacenxVehiculo = new AlmacenxVehiculoMySQL();
    private PromocionDAO daoPromocion = new PromocionMySQL();
    private LotexCriterioControlCalidadDAO daoLotexCriterioControlCalidad = new LotexCriterioControlCalidadMySQL();
    private ProductoxPromocionDAO daoProductoxPromocion = new ProductoxPromocionMySQL();
    private TransportistaDAO daoTransportista = new TransportistaMySQL();
    
    @WebMethod(operationName = "listarCategoriasProducto")
    public ArrayList<CategoriaProducto> listarCategoriasProducto() {
        ArrayList<CategoriaProducto> categoriasProducto = new ArrayList<>();
        try{
            categoriasProducto = daoCategoriaProducto.listarCategoriaProductos();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return categoriasProducto;
    }
    
    @WebMethod(operationName = "listarSubcategoriasProducto")
    public ArrayList<SubcategoriaProducto> listarSubcategoriasProducto() {
        ArrayList<SubcategoriaProducto> subcategoriasProducto = new ArrayList<>();
        try{
            subcategoriasProducto = daoSubcategoriaProducto.listarSubcategoriasProducto();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return subcategoriasProducto;
    }
    
    @WebMethod(operationName = "listarSubcategoriasXCategoria")
    public ArrayList<SubcategoriaProducto> listarSubcategoriasXCategoria(@WebParam(name = "idCategoria")int idCategoria) {
        ArrayList<SubcategoriaProducto> subcategoriasProducto = new ArrayList<>();
        try{
            subcategoriasProducto = daoSubcategoriaProducto.listarSubcategoriasXCategoria(idCategoria);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return subcategoriasProducto;
    }

    @WebMethod(operationName = "listarMarcasProducto")
    public ArrayList<MarcaProducto> listarMarcasProducto() {
        ArrayList<MarcaProducto> marcasProducto = new ArrayList<>();
        try{
            marcasProducto = daoMarcaProducto.listarMarcasProducto();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return marcasProducto;
    }
    

    @WebMethod(operationName = "listarCriteriosControlCalidad")
    public ArrayList<CriterioControlCalidad> listarCriteriosControlCalidad() {
        ArrayList<CriterioControlCalidad> criteriosControlCalidad = new ArrayList<>();
        try{
            criteriosControlCalidad = daoCriterioControlCalidad.listarCriteriosControlCalidad();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return criteriosControlCalidad;
    }
        
    @WebMethod(operationName = "insertarProducto")
    public int insertarProducto(@WebParam(name = "producto")Producto producto) {
        int resultado = 0;
        try{
            resultado = daoProducto.insertar(producto);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "modificarProducto")
    public int modificarProducto(@WebParam(name = "producto")Producto producto) {
        int resultado = 0;
        try{
            resultado = daoProducto.modificar(producto);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "eliminarProducto")
    public int eliminarProducto(@WebParam(name = "producto")Producto producto) {
        int resultado = 0;
        try{
            resultado = daoProducto.eliminar(producto.getIdProducto());
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "listarProductos")
    public ArrayList<Producto> listarProductos() {
        ArrayList<Producto> productos = new ArrayList<>();
        try{
            productos = daoProducto.listarProductos();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return productos;
    }
    
    @WebMethod(operationName = "listarProductosxCategoria")
    public ArrayList<Producto> listarProductosxCategoria(@WebParam(name = "idCategoria")int idCategoria) {
        ArrayList<Producto> productos = new ArrayList<>();
        try{
            productos = daoProducto.listarProductosXCategoria(idCategoria);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return productos;
    }
    
    @WebMethod(operationName = "listarProductosxMarca")
    public ArrayList<Producto> listarProductosxMarca(@WebParam(name = "idMarca")int idMarca) {
        ArrayList<Producto> productos = new ArrayList<>();
        try{
            productos = daoProducto.listarProductosXMarca(idMarca);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return productos;
    }
    
    @WebMethod(operationName = "listarProductosxIdNombre")
    public ArrayList<Producto> listarProductosxIdNombre(@WebParam(name = "idNombre")String idNombre) {
        ArrayList<Producto> productos = new ArrayList<>();
        try{
            productos = daoProducto.listarProductosXIdNombre(idNombre);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return productos;
    }
    
    @WebMethod(operationName = "insertarLote")
    public int insertarLote(@WebParam(name = "lote")Lote lote) {
        int resultado = 0;
        try{
            resultado = daoLote.insertar(lote);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "modificarLote")
    public int modificarLote(@WebParam(name = "lote")Lote lote) {
        int resultado = 0;
        try{
            resultado = daoLote.modificar(lote);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "eliminarLote")
    public int eliminarLote(@WebParam(name = "lote")Lote lote) {
        int resultado = 0;
        try{
            resultado = daoLote.eliminar(lote.getIdLote());
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "listarLotes")
    public ArrayList<Lote> listarLotes() {
        ArrayList<Lote> lotes = new ArrayList<>();
        try{
            lotes = daoLote.listarLotes();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return lotes;
    }
    
    @WebMethod(operationName = "listarLotesXProveedor")
    public ArrayList<Lote> listarLotesXProveedor(@WebParam(name = "idProveedor")int idProveedor) {
        ArrayList<Lote> lotes = new ArrayList<>();
        try{
            lotes = daoLote.listarLotesXProveedor(idProveedor);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return lotes;
    }
    
    @WebMethod(operationName = "listarLotesXFechaCompra")
    public ArrayList<Lote> listarLotesXFechaCompra(@WebParam(name = "fechaInicio")Date fechaInicio,@WebParam(name = "fechaFin")Date fechaFin) {
        ArrayList<Lote> lotes = new ArrayList<>();
        try{
            lotes = daoLote.listarLotesXFechaCompra(fechaInicio, fechaFin);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return lotes;
    }
    
    @WebMethod(operationName = "listarLotesXFechaLlegada")
    public ArrayList<Lote> listarLotesXFechaLlegada(@WebParam(name = "fechaInicio")Date fechaInicio,@WebParam(name = "fechaFin")Date fechaFin) {
        ArrayList<Lote> lotes = new ArrayList<>();
        try{
            lotes = daoLote.listarLotesXFechaLlegada(fechaInicio, fechaFin);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return lotes;
    }
    
    @WebMethod(operationName = "listarLotesXIDProveedorAlmacen")
    public ArrayList<Lote> listarLotesXIDProveedorAlmacen(@WebParam(name = "idProveedorAlmacen")String idProveedorAlmacen) {
        ArrayList<Lote> lotes = new ArrayList<>();
        try{
            lotes = daoLote.listarLotesXIDProveedorAlmacen(idProveedorAlmacen);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return lotes;
    }
    
    @WebMethod(operationName = "listarLotexCriterioControlCalidad")
    public ArrayList<LotexCriterioControlCalidad> listarLotexCriterioControlCalidad(@WebParam(name = "idLote")int idLote) {
        ArrayList<LotexCriterioControlCalidad> lineasLoteCriterios = new ArrayList<>();
        try{
            lineasLoteCriterios = daoLotexCriterioControlCalidad.listarLotexCriterioControlCalidad(idLote);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return lineasLoteCriterios;
    }
    
    @WebMethod(operationName = "actualizarStock")
    public int actualizarStock(@WebParam(name = "idProducto")int idProducto,@WebParam(name = "stock")int stock) {
        int resultado = 0;
        try{
            resultado = daoProducto.actualizarStock(idProducto, stock);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "listadoProveedores")
    public ArrayList<Proveedor> listadoProveedores() {
        ArrayList<Proveedor> proveedores = new ArrayList<>();
        try{
            proveedores = daoProveedor.listarProveedores();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return proveedores;
    }
    
    @WebMethod(operationName = "listadoAlmacen")
    public ArrayList<Almacen> listadoAlmacen() {
        ArrayList<Almacen> almacenes = new ArrayList<>();
        try{
            almacenes = daoAlmacen.listarAlmacenes();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return almacenes;
    }
    
    @WebMethod(operationName = "listadoTipoVehiculos")
    public ArrayList<TipoVehiculo> listadoTipoVehiculos() {
        ArrayList<TipoVehiculo> tiposVehiculos = new ArrayList<>();
        try{
            tiposVehiculos = daoTipoVehiculo.listarTiposVehiculos();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return tiposVehiculos;
    }
    //VEHICULO,TRANSPORTISTA,CATEGORIA,FALTA
    
    @WebMethod(operationName = "listadoVehiculos")
    public ArrayList<Vehiculo> listadoVehiculos() {
        ArrayList<Vehiculo> vehiculos = new ArrayList<>();
        try{
            vehiculos = daoVehiculo.listarVehiculos();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return vehiculos;
    }
    
    @WebMethod(operationName = "insertarProveedor")
    public int insertarProveedor(@WebParam(name = "proveedor") 
                Proveedor proveedor){
        int resultado = 0;
        try{
            resultado = daoProveedor.insertar(proveedor);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "modificarProveedor")
    public int modificarProveedor(@WebParam(name = "proveedor") 
                Proveedor proveedor){
        int resultado = 0;
        try{
            resultado = daoProveedor.modificar(proveedor);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "eliminarProveedor")
    public int eliminarProveedor(@WebParam(name = "proveedor") 
                Proveedor proveedor){
        int resultado = 0;
        try{
            resultado = daoProveedor.eliminar(proveedor.getIdProveedor());
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    
    
    @WebMethod(operationName = "insertarAlmacen")
    public int insertarAlmacen(@WebParam(name = "almacen") 
                Almacen almacen){
        int resultado = 0;
        try{
            resultado = daoAlmacen.insertar(almacen);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    
    @WebMethod(operationName = "insertarVehiculo")
    public int insertarVehiculo(@WebParam(name = "vehiculo") 
                Vehiculo vehiculo){
        int resultado = 0;
        try{
            resultado = daoVehiculo.insertar(vehiculo);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "insertarTipoVehiculo")
    public int insertarTipoVehiculo(@WebParam(name = "vehiculoTipo") 
                TipoVehiculo vehiculoTipo){
        int resultado = 0;
        try{
            resultado = daoTipoVehiculo.insertar(vehiculoTipo);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "insertarAlmacenxVehiculo")
    public int insertarAlmacenxVehiculo(@WebParam(name = "almaxVehi")
            AlmacenxVehiculo almaxVehi){
        int resultado = 0;
        try{
            resultado = daoAlmacenxVehiculo.insertar(almaxVehi);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    @WebMethod(operationName = "insertarPromocion")
    public int insertarPromocion(@WebParam(name = "promocion")
            Promocion promocion){
        int resultado = 0;
        try{
            resultado = daoPromocion.insertar(promocion);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "modificarAlmacenxVehiculo")
    public int modificarAlmacenxVehiculo(@WebParam(name = "almaxVehi")
            AlmacenxVehiculo almaxVehi){
        int resultado = 0;
        try{
            resultado = daoAlmacenxVehiculo.modificar(almaxVehi);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "eliminarAlmacenxVehiculo")
    public int eliminarAlmacenxVehiculo(@WebParam(name = "almacenxVehiculo") 
                AlmacenxVehiculo almacenxVehiculo){
        int resultado = 0;
        try{
            resultado = daoAlmacenxVehiculo.eliminar(almacenxVehiculo.getIdAlmacenxVehiculo());
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "listadoAlmacenxVehiculo")
    public ArrayList<AlmacenxVehiculo> listadoAlmacenxVehiculo() {
        ArrayList<AlmacenxVehiculo> almaxVehi = new ArrayList<>();
        try{
            almaxVehi = daoAlmacenxVehiculo.listarAlmaVehiculo();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return almaxVehi;
    }
    
    @WebMethod(operationName = "listarPorIdAlmacen")
    public ArrayList<AlmacenxVehiculo> 
        listarPorIdAlmacen(@WebParam(name = "idAlmacen")
            int idAlmacen){
        ArrayList<AlmacenxVehiculo> almaVehi = new ArrayList<>();
        try{
            almaVehi = daoAlmacenxVehiculo.listarPorIdAlmacen(idAlmacen);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return almaVehi;
    }
    
    @WebMethod(operationName = "modificarAlmacen")
    public int modificarAlmacen(@WebParam(name = "almacen") 
                Almacen almacen){
        int resultado = 0;
        try{
            resultado = daoAlmacen.modificar(almacen);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
	
	@WebMethod(operationName = "listarPromocionesXCategoria")   
    public ArrayList<Promocion> listarPromocionesXCategoria(@WebParam(name = "idCategoria")int idCategoria){
        ArrayList<Promocion> promociones = new ArrayList<>();
        try{
            promociones = daoPromocion.listarPorCategoria(idCategoria);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return promociones;
    }
    @WebMethod(operationName = "listarProductosXPromocion")   
    public ArrayList<ProductoxPromocion> listarProductosXPromocion(@WebParam(name = "idPromocion")int idPromocion){
        ArrayList<ProductoxPromocion> productosxpromocion = new ArrayList<>();
        try{
            productosxpromocion = daoProductoxPromocion.listarProductoPorPromocion(idPromocion);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return productosxpromocion;
    }
    //COLOCADO NUEVO:
    @WebMethod(operationName = "listarPorNombreProveedor")
    public ArrayList<Proveedor> 
        listarPorNombreProveedor(@WebParam(name = "razonProveedor")
            String razonProveedor){
        ArrayList<Proveedor> proveedores = new ArrayList<>();
        try{
            proveedores = daoProveedor.listarPorNombreProveedores(razonProveedor);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return proveedores;
    } 
    
    @WebMethod(operationName = "listarProveedorEntreFechas")
    public ArrayList<Proveedor> 
        listarProveedorEntreFechas(@WebParam(name = "fechaInicial") Date fechaInicial,
                              @WebParam(name = "fechaFinal") Date fechaFinal){
        ArrayList<Proveedor> proveedores = new ArrayList<>();
        try{
            proveedores = daoProveedor.listarProveedorEntreFechas(fechaInicial,fechaFinal);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return proveedores;
    }
    @WebMethod(operationName = "listadoRecientesProveedores")
    public ArrayList<Proveedor> listadoRecientesProveedores() {
        ArrayList<Proveedor> proveedores = new ArrayList<>();
        try{
            proveedores = daoProveedor.listarProveedoresRecientes();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return proveedores;
    }    
    
    @WebMethod(operationName = "listadoAntiguosProveedores")
    public ArrayList<Proveedor> listadoAntiguosProveedores() {
        ArrayList<Proveedor> proveedores = new ArrayList<>();
        try{
            proveedores = daoProveedor.listarProveedoresAntiguos();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return proveedores;
    }    
    
    //Transportista:
    @WebMethod(operationName = "insertarTransportista")
    public int insertarTransportista(@WebParam(name = "transportista") 
                Transportista transportista){
        int resultado = 0;
        try{
            resultado = daoTransportista.insertar(transportista);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    @WebMethod(operationName = "modificarTransportista")
    public int modificarTransportista(@WebParam(name = "transportista") 
                Transportista transportista){
        int resultado = 0;
        try{
            resultado = daoTransportista.modificar(transportista);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
     
    @WebMethod(operationName = "eliminarTransportista")
    public int eliminarTransportista(@WebParam(name = "transportista") 
                Transportista transportista){
        int resultado = 0;
        try{
            resultado = daoTransportista.eliminar(transportista.getIdTransportista());
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "listadoTransportista")
    public ArrayList<Transportista> listadoTransportista() {
        ArrayList<Transportista> transportistas = new ArrayList<>();
        try{
            transportistas = daoTransportista.listarTransportistas();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return transportistas;
    }
    
    @WebMethod(operationName = "insertarCategoria")
    public int insertarCategoria(@WebParam(name = "categoria")CategoriaProducto categoria) {
        int resultado = 0;
        try{
            resultado = daoCategoriaProducto.insertar(categoria);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
        @WebMethod(operationName = "modificarCategoria")
    public int modificarCategoria(@WebParam(name = "categoria")CategoriaProducto categoria) {
        int resultado = 0;
        try{
            resultado = daoCategoriaProducto.modificar(categoria);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
}