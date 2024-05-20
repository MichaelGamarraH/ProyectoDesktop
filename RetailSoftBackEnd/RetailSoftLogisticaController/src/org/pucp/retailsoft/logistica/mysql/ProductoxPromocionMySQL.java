package org.pucp.retailsoft.logistica.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.util.ArrayList;
import org.pucp.retailsoft.config.DBManager;
import org.pucp.retailsoft.logistica.dao.ProductoxPromocionDAO;
import org.pucp.retailsoft.logistica.model.MarcaProducto;
import org.pucp.retailsoft.logistica.model.Producto;
import org.pucp.retailsoft.logistica.model.ProductoxPromocion;
import org.pucp.retailsoft.logistica.model.Promocion;

public class ProductoxPromocionMySQL implements ProductoxPromocionDAO {
    private Connection con;
    private String sql;
    private ResultSet rs;
    private CallableStatement cs;

    @Override
    public ArrayList<ProductoxPromocion> listarProductoPorPromocion(int idPromocion){
        ArrayList<ProductoxPromocion> productosxpromocion = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_PRODUCTOS_X_PROMOCION(?)}");
            cs.setInt("_id_promocion", idPromocion);
            rs = cs.executeQuery();
            while(rs.next()){
                ProductoxPromocion propro = new ProductoxPromocion();
                propro.setIdProductoxPromocion(rs.getInt("id_promocion_producto"));
               
                propro.setProducto(new Producto());
                propro.getProducto().setIdProducto(rs.getInt("p.id_producto")); 
                propro.getProducto().setNombre(rs.getString("p.nombre"));  
                propro.getProducto().setPrecio(rs.getDouble("p.precio"));
                propro.getProducto().setImagen(rs.getBytes("p.imagen"));
                
                propro.getProducto().setMarcaProducto(new MarcaProducto()); 
                propro.getProducto().getMarcaProducto().setIdMarcaProducto(rs.getInt("m.id_marca_producto"));
                propro.getProducto().getMarcaProducto().setNombre(rs.getString("m.nombre"));

                
                propro.setPromocion(new Promocion());
                propro.getPromocion().setIdPromocion(rs.getInt("pro.id_promocion"));
                propro.getPromocion().setDescuento(rs.getDouble("pro.descuento"));
                
                propro.getPromocion().setFechaInicio(rs.getDate("pro.fecha_inicio"));
                propro.getPromocion().setFechaFin(rs.getDate("pro.fecha_fin"));
           
                
                propro.setActivo(true);
                productosxpromocion.add(propro);
   
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{rs.close();}catch(Exception ex){System.out.println(ex.getMessage());}
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return productosxpromocion;
    }   
}
