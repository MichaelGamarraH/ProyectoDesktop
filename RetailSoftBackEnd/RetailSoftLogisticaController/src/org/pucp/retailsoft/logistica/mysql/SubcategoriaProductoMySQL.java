package org.pucp.retailsoft.logistica.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.util.ArrayList;
import org.pucp.retailsoft.config.DBManager;
import org.pucp.retailsoft.logistica.dao.SubcategoriaProductoDAO;
import org.pucp.retailsoft.logistica.model.CategoriaProducto;
import org.pucp.retailsoft.logistica.model.SubcategoriaProducto;

public class SubcategoriaProductoMySQL implements SubcategoriaProductoDAO {
    
    private Connection con;
    private String sql;
    private ResultSet rs;
    private CallableStatement cs;

    @Override
    public ArrayList<SubcategoriaProducto> listarSubcategoriasProducto() {
        ArrayList<SubcategoriaProducto> subcategoriasProducto = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_SUBCATEGORIA_PRODUCTO()}");
            rs = cs.executeQuery();
            while(rs.next()){
                SubcategoriaProducto subcategoriaProducto = new SubcategoriaProducto();
                
                subcategoriaProducto.setIdSubcategoriaProducto(rs.getInt("id_subcategoria_producto"));
                subcategoriaProducto.setNombre(rs.getString("nombre_subcategoria"));
                subcategoriaProducto.setIcono(rs.getBytes("icono_subcategoria"));
                
                subcategoriaProducto.setCategoriaProducto(new CategoriaProducto());
                subcategoriaProducto.getCategoriaProducto().setNombre(rs.getString("nombre_categoria"));
                subcategoriaProducto.getCategoriaProducto().setIcono(rs.getBytes("icono_categoria"));
                
                subcategoriaProducto.setActivo(true);
                subcategoriasProducto.add(subcategoriaProducto);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return subcategoriasProducto;
    }
    
    @Override
    public ArrayList<SubcategoriaProducto> listarSubcategoriasXCategoria(int idCategoria) {
        ArrayList<SubcategoriaProducto> subcategoriasProducto = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_SUBCATEGORIAS_X_CATEGORIA(?)}");
            cs.setInt("_id_categoria", idCategoria);
            rs = cs.executeQuery();
            while(rs.next()){
                SubcategoriaProducto subcategoriaProducto = new SubcategoriaProducto();
                
                subcategoriaProducto.setIdSubcategoriaProducto(rs.getInt("id_subcategoria_producto"));
                subcategoriaProducto.setNombre(rs.getString("nombre_subcategoria"));
                subcategoriaProducto.setIcono(rs.getBytes("icono_subcategoria"));
                
                subcategoriaProducto.setCategoriaProducto(new CategoriaProducto());
                subcategoriaProducto.getCategoriaProducto().setNombre(rs.getString("nombre_categoria"));
                subcategoriaProducto.getCategoriaProducto().setIcono(rs.getBytes("icono_categoria"));
                
                subcategoriaProducto.setActivo(true);
                subcategoriasProducto.add(subcategoriaProducto);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return subcategoriasProducto;
       
    }
}
