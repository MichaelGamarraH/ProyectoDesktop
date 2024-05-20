/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package org.pucp.retailsoft.logistica.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.Date;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import org.pucp.retailsoft.config.DBManager;
import org.pucp.retailsoft.logistica.model.CategoriaProducto;
import org.pucp.retailsoft.logistica.dao.PromocionDAO;
import org.pucp.retailsoft.logistica.model.ProductoxPromocion;
import org.pucp.retailsoft.logistica.model.Promocion;

/**
 *
 * @author ABerrocalS
 */
public class PromocionMySQL implements PromocionDAO {
    private Connection con;
    private PreparedStatement ps;
    private ResultSet rs;
    private CallableStatement cs;
    
    @Override
    public int insertar(Promocion promocion) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call INSERTAR_PROMOCION(?,?,?,?,?,?,?,?,?)}");
            cs.registerOutParameter("_id_promocion", java.sql.Types.INTEGER);
            cs.setString("_nombre", promocion.getNombre());
            cs.setDouble("_descuento", promocion.getDescuento());
            cs.setDouble("_precio_promocion", promocion.getPrecioPromocion());     
            cs.setString("_descripcion", "prueba descripcion");
                
            cs.setDate("_fecha_inicio", new java.sql.Date(promocion.getFechaInicio().getTime()));
            cs.setDate("_fecha_fin", new java.sql.Date(promocion.getFechaFin().getTime()));
            
            cs.setInt("_fid_categoria", promocion.getCategoriaProducto().getIdCategoriaProducto());
            cs.setBytes("_imagen",promocion.getImagen());
            cs.executeUpdate();
            promocion.setIdPromocion(cs.getInt("_id_promocion"));
            
            for(ProductoxPromocion lineaProdPromo : promocion.getProductosXpromocion()){
                
                cs = con.prepareCall("{call INSERTAR_PROD_PROMO(?,?,?)}");
                cs.registerOutParameter("_id_prod_prom", java.sql.Types.INTEGER);
                cs.setInt("_fid_promocion", promocion.getIdPromocion());
                cs.setInt("_fid_producto", lineaProdPromo.getProducto().getIdProducto());
                cs.executeUpdate();
            }
            resultado = promocion.getIdPromocion();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int modificar(Promocion promocion) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call MODIFICAR_PROMOCION(?,?,?,?,?,?,?)}");
            cs.setInt("_id_promocion", promocion.getIdPromocion());
            cs.setString("_nombre", promocion.getNombre());
            cs.setDouble("_descuento", promocion.getDescuento());
            cs.setDouble("_precio_promocion", promocion.getPrecioPromocion());
            cs.setString("_descripcion", promocion.getDescripcion());
            cs.setDate("_fecha_inicio", new java.sql.Date(promocion.getFechaInicio().getTime()));
            cs.setDate("_fecha_fin", new java.sql.Date(promocion.getFechaFin().getTime()));

            cs.executeUpdate();
            resultado = 1;
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }
    
    @Override
    public int eliminar(int idPromocion) {
                int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call ELIMINAR_PROMOCION(?)}");
            cs.setInt("_id_promocion", idPromocion);
            cs.executeUpdate();
            resultado = 1;
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }


    @Override
    public ArrayList<Promocion> listarPorCategoria(int idCategoria){
        ArrayList<Promocion> promociones = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_PROMOCIONES_X_CATEGORIA(?)}");
            cs.setInt("_id_categoria_producto", idCategoria);
            rs = cs.executeQuery();
            while(rs.next()){
                Promocion prom = new Promocion();
                prom.setIdPromocion(rs.getInt("id_promocion"));
                prom.setCategoriaProducto(new CategoriaProducto());
                prom.getCategoriaProducto().setIdCategoriaProducto(rs.getInt("id_categoria_producto"));
                prom.setNombre(rs.getString("nombre"));
                prom.setDescuento(rs.getDouble("descuento"));
                prom.setImagen(rs.getBytes("imagen"));
                prom.setActivo(true);
                promociones.add(prom);
   
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{rs.close();}catch(Exception ex){System.out.println(ex.getMessage());}
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return promociones;
    }
}
