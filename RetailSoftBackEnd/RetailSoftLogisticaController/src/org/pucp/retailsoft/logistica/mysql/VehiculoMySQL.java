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
import org.pucp.retailsoft.logistica.dao.VehiculoDAO;
import org.pucp.retailsoft.logistica.model.Almacen;
import org.pucp.retailsoft.logistica.model.TipoVehiculo;
import org.pucp.retailsoft.logistica.model.Vehiculo;

/**
 *
 * @author Dell
 */
public class VehiculoMySQL implements VehiculoDAO {
    private Connection con;
    private String sql;
    private ResultSet rs;
    private CallableStatement cs;
    @Override
    public int insertar(Vehiculo vehiculo) {
         int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call INSERTAR_VEHICULO(?,?,?,?,?,?) }");
            cs.registerOutParameter("_id_vehiculo",java.sql.Types.INTEGER);
            cs.setInt("_fid_almacen",vehiculo.getAlmacen().getIdAlmacen());
            cs.setInt("_fid_tipo_vehiculo",vehiculo.getTipoVehiculo().getIdTipoVehiculo());        
            cs.setString("_placa", vehiculo.getPlaca());        
            cs.setString("_descripcion", vehiculo.getDescripcion()); 
            cs.setNull("_soat", java.sql.Types.NULL);
            
             
            resultado = cs.executeUpdate();
            vehiculo.setIdVehiculo(cs.getInt("_id_vehiculo"));
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex)
            {System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int modificar(Vehiculo vehiculo) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call MODIFICAR_VEHICULO(?,?,?,?,?,?) }");
            cs.setInt("_id_vehiculo", vehiculo.getIdVehiculo());
            cs.setInt("_fid_almacen",vehiculo.getAlmacen().getIdAlmacen());
            cs.setInt("_fid_tipo_vehiculo",vehiculo.getTipoVehiculo().getIdTipoVehiculo());        
            cs.setString("_placa", vehiculo.getPlaca());        
            cs.setString("_descripcion", vehiculo.getDescripcion()); 
            cs.setNull("_soat", java.sql.Types.NULL);
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
    public int eliminar(int idVehiculo) {
         int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall(" { call ELIMINAR_VEHICULO(?) }");
            cs.setInt("_id_vehiculo", idVehiculo);
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
    public ArrayList<Vehiculo> listarVehiculos() {
        ArrayList<Vehiculo> vehiculos = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_VEHICULOS_TODOS()}");
            rs = cs.executeQuery();
            while(rs.next()){
                Vehiculo vehiculo = new Vehiculo();
                 
                vehiculo.setIdVehiculo(rs.getInt("id_vehiculo"));
                vehiculo.setPlaca(rs.getString("placa"));
                vehiculo.setDescripcion(rs.getString("descripcion"));
                vehiculo.setSOAT(rs.getBytes("soat"));

                vehiculo.setTipoVehiculo(new TipoVehiculo());
                vehiculo.getTipoVehiculo().setNombre(rs.getString("nombre_tipo_vehiculo"));
                vehiculo.getTipoVehiculo().setDescripcion(rs.getString("descripcion_tipo"));
                
                vehiculo.setAlmacen(new Almacen());
                vehiculo.getAlmacen().setNombre(rs.getString("nombre_almacen"));
                vehiculo.getAlmacen().setCapacidad(rs.getInt("capacidad"));
                vehiculo.getAlmacen().setDireccion(rs.getString("direccion"));
                
                
                vehiculo.setActivo(true);
                vehiculos.add(vehiculo);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return vehiculos;
    }
    
}
