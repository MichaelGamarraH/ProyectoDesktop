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
import org.pucp.retailsoft.logistica.dao.AlmacenxVehiculoDAO;
import org.pucp.retailsoft.logistica.model.Almacen;
import org.pucp.retailsoft.logistica.model.AlmacenxVehiculo;
import org.pucp.retailsoft.logistica.model.Vehiculo;

/**
 *
 * @author Dell
 */
public class AlmacenxVehiculoMySQL implements AlmacenxVehiculoDAO{
    private Connection con;
    private ResultSet rs;
    private CallableStatement cs;
    
    @Override
    public int insertar(AlmacenxVehiculo almaxveh) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call INSERTAR_ALMACEN_X_VEHICULO(?,?,?)}");
            cs.registerOutParameter("_id_almacen_vehiculo", 
            java.sql.Types.INTEGER);
            cs.setInt("_fid_almacen", almaxveh.getAlmacen().getIdAlmacen());
            cs.setInt("_fid_vehiculo", almaxveh.getVehiculo().getIdVehiculo());
            resultado = cs.executeUpdate();
            almaxveh.setIdAlmacenxVehiculo(cs.getInt("_id_almacen_vehiculo"));
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex)
            {System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public ArrayList<AlmacenxVehiculo> listarAlmaVehiculo() {
        ArrayList<AlmacenxVehiculo> vehiculosAlma = new ArrayList<>();
	try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_ALMACEN_X_VEHICULO()}");
            rs = cs.executeQuery();
            while(rs.next()){
                AlmacenxVehiculo av = new AlmacenxVehiculo();
                av.setAlmacen(new Almacen());
                av.setVehiculo(new Vehiculo());
                av.setIdAlmacenxVehiculo(rs.getInt("id_almacen_vehiculo"));
 
                av.getAlmacen().setIdAlmacen(rs.getInt("fid_almacen"));
                //av.getAlmacen().setNombre(rs.getString("nombre"));
                //av.getAlmacen().setDireccion(rs.getString("direccion"));
                
                av.getVehiculo().setIdVehiculo(rs.getInt("fid_vehiculo"));
                av.setActivo(true);
                //av.getVehiculo().setDescripcion(rs.getString("descripcion"));
                vehiculosAlma.add(av);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return vehiculosAlma;
    }

    @Override
    public ArrayList<AlmacenxVehiculo> listarPorIdAlmacen(int idAlmacen) {
        ArrayList<AlmacenxVehiculo> vehiculosAlma = new ArrayList<>();
	try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_VEHICULOS_X_ID_ALMACEN(?)}");
            cs.setInt("_id_almacen", idAlmacen);
            rs = cs.executeQuery();
            while(rs.next()){
                AlmacenxVehiculo av = new AlmacenxVehiculo();
                av.setAlmacen(new Almacen());
                av.setVehiculo(new Vehiculo());
                av.setIdAlmacenxVehiculo(rs.getInt("id_almacen_vehiculo"));
                av.getAlmacen().setIdAlmacen(rs.getInt("fid_almacen"));
                av.getVehiculo().setIdVehiculo(rs.getInt("fid_vehiculo"));
                av.getVehiculo().setPlaca(rs.getString("placa"));
                av.getVehiculo().setDescripcion(rs.getString("descripcion"));
                av.setActivo(true);
                vehiculosAlma.add(av);
            }
	}catch(Exception ex){
		System.out.println(ex.getMessage());
	}finally{
		try{rs.close();}catch(Exception ex){System.out.println(ex.getMessage());}
		 
	}
	return vehiculosAlma;
    }

    @Override
    public int modificar(AlmacenxVehiculo almaxveh) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call MODIFICAR_ALMACEN_X_VEHICULO(?,?,?)}");
            cs.setInt("_id_almacen_vehiculo",almaxveh.getIdAlmacenxVehiculo());
            cs.setInt("_fid_almacen", almaxveh.getAlmacen().getIdAlmacen());
            cs.setInt("_fid_vehiculo", almaxveh.getVehiculo().getIdVehiculo());
            cs.executeUpdate();
            resultado = almaxveh.getIdAlmacenxVehiculo();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex)
            {System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int eliminar(int id_almacen_vehiculo) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call ELIMINAR_ALMACEN_X_VEHICULO(?)}");
            cs.setInt("_id_almacen_vehiculo", id_almacen_vehiculo);
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