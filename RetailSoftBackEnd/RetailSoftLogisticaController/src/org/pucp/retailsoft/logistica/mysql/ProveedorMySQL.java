/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package org.pucp.retailsoft.logistica.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;

import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.Date;
import org.pucp.retailsoft.config.DBManager;
import org.pucp.retailsoft.logistica.dao.ProveedorDAO;
import org.pucp.retailsoft.logistica.model.CategoriaProducto;
import org.pucp.retailsoft.logistica.model.Proveedor;

/**
 *
 * @author Dell
 */
public class ProveedorMySQL implements ProveedorDAO{
    private Connection con;
    private String sql;
    private ResultSet rs;
    private CallableStatement cs;
    @Override
    public int insertar(Proveedor proveedor) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call INSERTAR_PROVEEDOR(?,?,?,?,?,?,?,?,?,?,?)}");
            cs.registerOutParameter("_id_proveedor",java.sql.Types.INTEGER);
            cs.setString("_razon_social", proveedor.getRazonSocial());
            cs.setString("_representante", proveedor.getRepresentante());
            cs.setString("_ruc", proveedor.getRUC());
            cs.setString("_direccion", proveedor.getDireccion());
            cs.setString("_telefono", proveedor.getTelefono());
            cs.setString("_correo", proveedor.getCorreo());
            cs.setInt("_fid_categoria_producto", proveedor.getCategoriaProducto().getIdCategoriaProducto());
            cs.setString("_sitio_web", proveedor.getSitioWeb());
            cs.setDate("_fecha_inicio", new java.sql.Date(proveedor.getFechaInicio().getTime()));
            cs.setString("_nota_proveedor", proveedor.getNotaProveedor());
            cs.executeUpdate();
            proveedor.setIdProveedor(cs.getInt("_id_proveedor"));
            resultado = proveedor.getIdProveedor();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex)
            {System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int modificar(Proveedor proveedor) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call MODIFICAR_PROVEEDOR(?,?,?,?,?,?,?,?,?,?,?) }");
            cs.setInt("_id_proveedor",proveedor.getIdProveedor());
            cs.setString("_razon_social", proveedor.getRazonSocial());
            cs.setString("_representante", proveedor.getRepresentante());
            cs.setString("_ruc", proveedor.getRUC());
            cs.setString("_direccion", proveedor.getDireccion());
            cs.setString("_telefono", proveedor.getTelefono());
            cs.setString("_correo", proveedor.getCorreo());
            cs.setInt("_fid_categoria_producto", proveedor.getCategoriaProducto().getIdCategoriaProducto());
            cs.setString("_sitio_web", proveedor.getSitioWeb());
            cs.setDate("_fecha_inicio", new java.sql.Date(proveedor.getFechaInicio().getTime()));
            cs.setString("_nota_proveedor", proveedor.getNotaProveedor());

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
    public int eliminar(int idProveedor) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall(" { call ELIMINAR_PROVEEDOR(?) }");
            cs.setInt("_id_proveedor", idProveedor);
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
    public ArrayList<Proveedor> listarProveedores() {
        ArrayList<Proveedor> proveedores = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_PROVEEDORES_TODOS()}");
            rs = cs.executeQuery();
            while(rs.next()){
                Proveedor proveedor = new Proveedor();
                proveedor.setIdProveedor(rs.getInt("id_proveedor"));
                proveedor.setRazonSocial(rs.getString("razon_social"));
                proveedor.setRepresentante(rs.getString("representante"));
                proveedor.setRUC(rs.getString("ruc"));
                proveedor.setDireccion(rs.getString("direccion"));
                proveedor.setTelefono(rs.getString("telefono"));
                proveedor.setCorreo(rs.getString("correo"));
                proveedor.setCategoriaProducto(new CategoriaProducto());
                proveedor.getCategoriaProducto().setIdCategoriaProducto(rs.getInt("fid_categoria_producto"));
                proveedor.getCategoriaProducto().setNombre(rs.getString("nombre"));
                proveedor.setSitioWeb(rs.getString("sitio_web"));
                proveedor.setFechaInicio(rs.getDate("fecha_inicio"));
                proveedor.setNotaProveedor(rs.getString("nota_proveedor"));
                proveedor.setActivo(true);
                proveedores.add(proveedor);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return proveedores;
    }

    @Override
    public ArrayList<Proveedor> listarPorNombreProveedores(String razonProveedor) {
        ArrayList<Proveedor> proveedores = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_PROVEEDORES_X_NOMBRE(?)}");
            cs.setString("_nombre_proveedor", razonProveedor);
            rs = cs.executeQuery();
            while(rs.next()){
                Proveedor proveedor = new Proveedor();
                
                proveedor.setIdProveedor(rs.getInt("id_proveedor"));
                proveedor.setRazonSocial(rs.getString("razon_social"));
                proveedor.setRepresentante(rs.getString("representante"));
                proveedor.setRUC(rs.getString("ruc"));
                proveedor.setDireccion(rs.getString("direccion"));
                proveedor.setTelefono(rs.getString("telefono"));
                proveedor.setCorreo(rs.getString("correo"));
                proveedor.setCategoriaProducto(new CategoriaProducto());
                proveedor.getCategoriaProducto().setIdCategoriaProducto(rs.getInt("fid_categoria_producto"));
                proveedor.getCategoriaProducto().setNombre(rs.getString("nombre"));
                proveedor.setSitioWeb(rs.getString("sitio_web"));
                proveedor.setFechaInicio(rs.getDate("fecha_inicio"));
                proveedor.setNotaProveedor(rs.getString("nota_proveedor"));
                proveedor.setActivo(true);
                proveedores.add(proveedor);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return proveedores;
    }

    @Override
    public ArrayList<Proveedor> listarProveedoresRecientes() {
        ArrayList<Proveedor> proveedores = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_PROVEEDORES_MAS_NUEVOS()}");
            rs = cs.executeQuery();
            while(rs.next()){
                Proveedor proveedor = new Proveedor();
                proveedor.setIdProveedor(rs.getInt("id_proveedor"));
                proveedor.setRazonSocial(rs.getString("razon_social"));
                proveedor.setRepresentante(rs.getString("representante"));
                proveedor.setRUC(rs.getString("ruc"));
                proveedor.setDireccion(rs.getString("direccion"));
                proveedor.setTelefono(rs.getString("telefono"));
                proveedor.setCorreo(rs.getString("correo"));
                proveedor.setCategoriaProducto(new CategoriaProducto());
                proveedor.getCategoriaProducto().setIdCategoriaProducto(rs.getInt("fid_categoria_producto"));
                proveedor.getCategoriaProducto().setNombre(rs.getString("nombre"));
                proveedor.setSitioWeb(rs.getString("sitio_web"));
                proveedor.setFechaInicio(rs.getDate("fecha_inicio"));
                proveedor.setNotaProveedor(rs.getString("nota_proveedor"));
                proveedor.setActivo(true);
                proveedores.add(proveedor);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return proveedores; 
    }

    @Override
    public ArrayList<Proveedor> listarProveedoresAntiguos() {
        ArrayList<Proveedor> proveedores = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_PROVEEDORES_MAS_ANTIGUOS()}");
            rs = cs.executeQuery();
            while(rs.next()){
                Proveedor proveedor = new Proveedor();
                proveedor.setIdProveedor(rs.getInt("id_proveedor"));
                proveedor.setRazonSocial(rs.getString("razon_social"));
                proveedor.setRepresentante(rs.getString("representante"));
                proveedor.setRUC(rs.getString("ruc"));
                proveedor.setDireccion(rs.getString("direccion"));
                proveedor.setTelefono(rs.getString("telefono"));
                proveedor.setCorreo(rs.getString("correo"));
                proveedor.setCategoriaProducto(new CategoriaProducto());
                proveedor.getCategoriaProducto().setIdCategoriaProducto(rs.getInt("fid_categoria_producto"));
                proveedor.getCategoriaProducto().setNombre(rs.getString("nombre"));
                proveedor.setSitioWeb(rs.getString("sitio_web"));
                proveedor.setFechaInicio(rs.getDate("fecha_inicio"));
                proveedor.setNotaProveedor(rs.getString("nota_proveedor"));
                proveedor.setActivo(true);
                proveedores.add(proveedor);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return proveedores; 
    }

    @Override
    public ArrayList<Proveedor> listarProveedorEntreFechas(Date fechaInicial, Date fechaFinal) {
        ArrayList<Proveedor> proveedores = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_PROVEEDORES_POR_RANGO_DE_FECHAS(?,?)}");
            cs.setDate("_fecha_inicio", new java.sql.Date(fechaInicial.getTime()));
            cs.setDate("_fecha_fin", new java.sql.Date(fechaFinal.getTime()));
            rs = cs.executeQuery();
            while(rs.next()){
                Proveedor proveedor = new Proveedor();
                proveedor.setIdProveedor(rs.getInt("id_proveedor"));
                proveedor.setRazonSocial(rs.getString("razon_social"));
                proveedor.setRepresentante(rs.getString("representante"));
                proveedor.setRUC(rs.getString("ruc"));
                proveedor.setDireccion(rs.getString("direccion"));
                proveedor.setTelefono(rs.getString("telefono"));
                proveedor.setCorreo(rs.getString("correo"));
                proveedor.setCategoriaProducto(new CategoriaProducto());
                proveedor.getCategoriaProducto().setIdCategoriaProducto(rs.getInt("fid_categoria_producto"));
                proveedor.getCategoriaProducto().setNombre(rs.getString("nombre"));
                proveedor.setSitioWeb(rs.getString("sitio_web"));
                proveedor.setFechaInicio(rs.getDate("fecha_inicio"));
                proveedor.setNotaProveedor(rs.getString("nota_proveedor"));
                proveedor.setActivo(true);
                proveedores.add(proveedor);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return proveedores;
    }
    
    
}
