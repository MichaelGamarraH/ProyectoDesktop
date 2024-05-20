package org.pucp.retailsoft.logistica.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.util.ArrayList;
import org.pucp.retailsoft.config.DBManager;
import org.pucp.retailsoft.logistica.dao.ProductoDAO;
import org.pucp.retailsoft.logistica.model.CategoriaProducto;
import org.pucp.retailsoft.logistica.model.MarcaProducto;
import org.pucp.retailsoft.logistica.model.Producto;
import org.pucp.retailsoft.logistica.model.Promocion;
import org.pucp.retailsoft.logistica.model.SubcategoriaProducto;

public class ProductoMySQL implements ProductoDAO {
    
    private Connection con;
    private String sql;
    private ResultSet rs;
    private CallableStatement cs;

    @Override
    public int insertar(Producto producto) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call INSERTAR_PRODUCTO(?,?,?,?,?,?,?,?,?,?) }");
            cs.registerOutParameter("_id_producto",java.sql.Types.INTEGER);
            cs.setString("_nombre", producto.getNombre());
            cs.setString("_descripcion", producto.getDescripcion());
            cs.setBytes("_imagen", producto.getImagen());
            cs.setInt("_stock", producto.getStock());
            cs.setString("_talla_modelo", producto.getTallaModelo());
            cs.setDouble("_precio", producto.getPrecio());
            cs.setBoolean("_estado", producto.isEstado());
            cs.setInt("_fid_marca_producto", producto.getMarcaProducto().getIdMarcaProducto());
            cs.setInt("_fid_subcategoria_producto", producto.getSubcategoriaProducto().getIdSubcategoriaProducto());
            cs.executeUpdate();
            producto.setIdProducto(cs.getInt("_id_producto"));
            resultado = producto.getIdProducto();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex)
            {System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int modificar(Producto producto) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call MODIFICAR_PRODUCTO(?,?,?,?,?,?,?,?,?,?) }");
            cs.setInt("_id_producto",producto.getIdProducto());
            cs.setString("_nombre", producto.getNombre());
            cs.setString("_descripcion", producto.getDescripcion());
            cs.setBytes("_imagen", producto.getImagen());
            cs.setInt("_stock", producto.getStock());
            cs.setString("_talla_modelo", producto.getTallaModelo());
            cs.setDouble("_precio", producto.getPrecio());
            cs.setBoolean("_estado", producto.isEstado());
            cs.setInt("_fid_marca_producto", producto.getMarcaProducto().getIdMarcaProducto());
            cs.setInt("_fid_subcategoria_producto", producto.getSubcategoriaProducto().getIdSubcategoriaProducto());
            resultado = cs.executeUpdate();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex)
            {System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int eliminar(int idProducto) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall(" { call ELIMINAR_PRODUCTO(?) }");
            cs.setInt("_id_producto", idProducto);
            resultado = cs.executeUpdate();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex)
            {System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public ArrayList<Producto> listarProductos() {
        ArrayList<Producto> productos = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_PRODUCTOS()}");
            rs = cs.executeQuery();
            while(rs.next()){
                Producto producto = new Producto();
                
                producto.setIdProducto(rs.getInt("id_producto"));
                producto.setNombre(rs.getString("nombre_producto"));
                producto.setDescripcion(rs.getString("descripcion"));
                producto.setImagen(rs.getBytes("imagen_producto"));
                producto.setStock(rs.getInt("stock"));
                producto.setTallaModelo(rs.getString("talla_modelo"));
                producto.setPrecio(rs.getDouble("precio"));
                producto.setEstado(rs.getBoolean("estado"));
                
                producto.setMarcaProducto(new MarcaProducto());
                producto.getMarcaProducto().setIdMarcaProducto(rs.getInt("id_marca_producto"));
                producto.getMarcaProducto().setNombre(rs.getString("nombre_marca"));
                producto.getMarcaProducto().setIcono(rs.getBytes("icono_marca"));
                
                producto.setSubcategoriaProducto(new SubcategoriaProducto());
                producto.getSubcategoriaProducto().setIdSubcategoriaProducto(rs.getInt("id_subcategoria_producto"));
                producto.getSubcategoriaProducto().setNombre(rs.getString("nombre_subcategoria"));
                producto.getSubcategoriaProducto().setIcono(rs.getBytes("icono_subcategoria"));
                
                producto.getSubcategoriaProducto().setCategoriaProducto(new CategoriaProducto());
                producto.getSubcategoriaProducto().getCategoriaProducto().setIdCategoriaProducto(rs.getInt("id_categoria_producto"));
                producto.getSubcategoriaProducto().getCategoriaProducto().setNombre(rs.getString("nombre_categoria"));
                producto.getSubcategoriaProducto().getCategoriaProducto().setIcono(rs.getBytes("icono_categoria"));
                
                producto.setActivo(true);
                productos.add(producto);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return productos;
    }

    @Override
    public ArrayList<Producto> listarProductosXCategoria(int idCategoria) {
        ArrayList<Producto> productos = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_PRODUCTOS_X_CATEGORIA(?)}");
            cs.setInt("_id_categoria",idCategoria);
            rs = cs.executeQuery();
            while(rs.next()){
                Producto producto = new Producto();
                
                producto.setIdProducto(rs.getInt("id_producto"));
                producto.setNombre(rs.getString("nombre_producto"));
                producto.setDescripcion(rs.getString("descripcion"));
                producto.setImagen(rs.getBytes("imagen_producto"));
                producto.setStock(rs.getInt("stock"));
                producto.setTallaModelo(rs.getString("talla_modelo"));
                producto.setPrecio(rs.getDouble("precio"));
                producto.setEstado(rs.getBoolean("estado"));
                
                producto.setMarcaProducto(new MarcaProducto());
                producto.getMarcaProducto().setIdMarcaProducto(rs.getInt("id_marca_producto"));
                producto.getMarcaProducto().setNombre(rs.getString("nombre_marca"));
                producto.getMarcaProducto().setIcono(rs.getBytes("icono_marca"));
                
                producto.setSubcategoriaProducto(new SubcategoriaProducto());
                producto.getSubcategoriaProducto().setIdSubcategoriaProducto(rs.getInt("id_subcategoria_producto"));
                producto.getSubcategoriaProducto().setNombre(rs.getString("nombre_subcategoria"));
                producto.getSubcategoriaProducto().setIcono(rs.getBytes("icono_subcategoria"));
                
                producto.getSubcategoriaProducto().setCategoriaProducto(new CategoriaProducto());
                producto.getSubcategoriaProducto().getCategoriaProducto().setIdCategoriaProducto(rs.getInt("id_categoria_producto"));
                producto.getSubcategoriaProducto().getCategoriaProducto().setNombre(rs.getString("nombre_categoria"));
                producto.getSubcategoriaProducto().getCategoriaProducto().setIcono(rs.getBytes("icono_categoria"));
                
                producto.setActivo(true);
                productos.add(producto);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return productos;
    }

    @Override
    public ArrayList<Producto> listarProductosXMarca(int idMarca) {
        ArrayList<Producto> productos = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_PRODUCTOS_X_MARCA(?)}");
            cs.setInt("_id_marca",idMarca);
            rs = cs.executeQuery();
            while(rs.next()){
                Producto producto = new Producto();
                
                producto.setIdProducto(rs.getInt("id_producto"));
                producto.setNombre(rs.getString("nombre_producto"));
                producto.setDescripcion(rs.getString("descripcion"));
                producto.setImagen(rs.getBytes("imagen_producto"));
                producto.setStock(rs.getInt("stock"));
                producto.setTallaModelo(rs.getString("talla_modelo"));
                producto.setPrecio(rs.getDouble("precio"));
                producto.setEstado(rs.getBoolean("estado"));
                
                producto.setMarcaProducto(new MarcaProducto());
                producto.getMarcaProducto().setIdMarcaProducto(rs.getInt("id_marca_producto"));
                producto.getMarcaProducto().setNombre(rs.getString("nombre_marca"));
                producto.getMarcaProducto().setIcono(rs.getBytes("icono_marca"));
                
                producto.setSubcategoriaProducto(new SubcategoriaProducto());
                producto.getSubcategoriaProducto().setIdSubcategoriaProducto(rs.getInt("id_subcategoria_producto"));
                producto.getSubcategoriaProducto().setNombre(rs.getString("nombre_subcategoria"));
                producto.getSubcategoriaProducto().setIcono(rs.getBytes("icono_subcategoria"));
                
                producto.getSubcategoriaProducto().setCategoriaProducto(new CategoriaProducto());
                producto.getSubcategoriaProducto().getCategoriaProducto().setIdCategoriaProducto(rs.getInt("id_categoria_producto"));
                producto.getSubcategoriaProducto().getCategoriaProducto().setNombre(rs.getString("nombre_categoria"));
                producto.getSubcategoriaProducto().getCategoriaProducto().setIcono(rs.getBytes("icono_categoria"));
                
                producto.setActivo(true);
                productos.add(producto);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return productos;
    }

    @Override
    public ArrayList<Producto> listarProductosXIdNombre(String idNombre) {
        ArrayList<Producto> productos = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_PRODUCTOS_X_IDNOMBRE(?)}");
            cs.setString("_id_nombre",idNombre);
            rs = cs.executeQuery();
            while(rs.next()){
                Producto producto = new Producto();
                
                producto.setIdProducto(rs.getInt("id_producto"));
                producto.setNombre(rs.getString("nombre_producto"));
                producto.setDescripcion(rs.getString("descripcion"));
                producto.setImagen(rs.getBytes("imagen_producto"));
                producto.setStock(rs.getInt("stock"));
                producto.setTallaModelo(rs.getString("talla_modelo"));
                producto.setPrecio(rs.getDouble("precio"));
                producto.setEstado(rs.getBoolean("estado"));
                
                producto.setMarcaProducto(new MarcaProducto());
                producto.getMarcaProducto().setIdMarcaProducto(rs.getInt("id_marca_producto"));
                producto.getMarcaProducto().setNombre(rs.getString("nombre_marca"));
                producto.getMarcaProducto().setIcono(rs.getBytes("icono_marca"));
                
                producto.setSubcategoriaProducto(new SubcategoriaProducto());
                producto.getSubcategoriaProducto().setIdSubcategoriaProducto(rs.getInt("id_subcategoria_producto"));
                producto.getSubcategoriaProducto().setNombre(rs.getString("nombre_subcategoria"));
                producto.getSubcategoriaProducto().setIcono(rs.getBytes("icono_subcategoria"));
                
                producto.getSubcategoriaProducto().setCategoriaProducto(new CategoriaProducto());
                producto.getSubcategoriaProducto().getCategoriaProducto().setIdCategoriaProducto(rs.getInt("id_categoria_producto"));
                producto.getSubcategoriaProducto().getCategoriaProducto().setNombre(rs.getString("nombre_categoria"));
                producto.getSubcategoriaProducto().getCategoriaProducto().setIcono(rs.getBytes("icono_categoria"));
                
                producto.setActivo(true);
                productos.add(producto);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return productos;
    }
	
	@Override
    public ArrayList<Producto> listarPorPromocion(int idPromocion){
        ArrayList<Producto> productos = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_PRODUCTOS_X_PROMOCION(?)}");
            cs.setInt("_id_promocion", idPromocion);
            rs = cs.executeQuery();
            while(rs.next()){
                Producto pro = new Producto();
                pro.setIdProducto(rs.getInt("id_producto"));
                pro.setPromocion(new Promocion());
                pro.getPromocion().setIdPromocion(rs.getInt("id_promocion"));
                pro.getPromocion().setDescuento(rs.getDouble("descuento"));
                pro.setNombre(rs.getString("nombre"));
                pro.setPrecio(rs.getDouble("precio"));
                pro.setImagen(rs.getBytes("imagen"));
                pro.setActivo(true);
                productos.add(pro);
   
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{rs.close();}catch(Exception ex){System.out.println(ex.getMessage());}
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return productos;
    }

    @Override
    public int actualizarStock(int idProducto, int stock) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call ACTUALIZAR_STOCK(?,?) }");
            cs.setInt("_id_producto",idProducto);
            cs.setInt("_stock", stock);
            resultado = cs.executeUpdate();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex)
            {System.out.println(ex.getMessage());}
        }
        return resultado;
    }
}