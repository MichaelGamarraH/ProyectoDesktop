/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package org.pucp.retailsoft.logistica.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.util.ArrayList;
import org.pucp.retailsoft.config.DBManager;
import org.pucp.retailsoft.logistica.dao.CategoriaProductoDAO;
import org.pucp.retailsoft.logistica.model.CategoriaProducto;
import org.pucp.retailsoft.logistica.model.SubcategoriaProducto;

/**
 *
 * @author Dell
 */
public class CategoriaProductoMySQL implements CategoriaProductoDAO{
    private Connection con;
    private String sql;
    private ResultSet rs;
    private CallableStatement cs;
    @Override
    public int insertar(CategoriaProducto categoriaProducto) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call INSERTAR_CATEGORIA_PRODUCTO(?,?,?) }");
            cs.registerOutParameter("_id_categoria_producto",java.sql.Types.INTEGER);
            cs.setString("_nombre", categoriaProducto.getNombre());
            cs.setBytes("_icono", categoriaProducto.getIcono());
            
            resultado = cs.executeUpdate();
            categoriaProducto.setIdCategoriaProducto(cs.getInt("_id_categoria_producto"));
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex)
            {System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int modificar(CategoriaProducto categoriaProducto) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call MODIFICAR_CATEGORIA_PRODUCTO(?,?,?) }");
            cs.setInt("_id_categoria_producto",categoriaProducto.getIdCategoriaProducto());
            cs.setString("_nombre", categoriaProducto.getNombre());
            cs.setBytes("_icono", categoriaProducto.getIcono());
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
    public int eliminar(int idCategoriaProducto) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall(" { call ELIMINAR_PRODUCTO(?) }");
            cs.setInt("_id_categoria_producto", idCategoriaProducto);
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
    public ArrayList<CategoriaProducto> listarCategoriaProductos() {
        ArrayList<CategoriaProducto> categorias = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_CATEGORIA_TODOS()}");
            rs = cs.executeQuery();
            while(rs.next()){
                CategoriaProducto categoria = new CategoriaProducto();
 
                
                categoria.setIdCategoriaProducto(rs.getInt("id_categoria_producto"));
                categoria.setNombre(rs.getString("nombre"));
                categoria.setIcono(rs.getBytes("icono"));
                
                categoria.setActivo(true);
                categorias.add(categoria);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return categorias;
    }
    
}