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
import org.pucp.retailsoft.logistica.dao.TipoVehiculoDAO;
import org.pucp.retailsoft.logistica.model.TipoVehiculo;

/**
 *
 * @author Dell
 */
public class TipoVehiculoMySQL implements TipoVehiculoDAO{
    private Connection con;
    private String sql;
    private ResultSet rs;
    private CallableStatement cs;
    @Override
    public int insertar(TipoVehiculo tipoVehiculo) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call INSERTAR_TIPO_VEHICULO(?,?,?) }");
            cs.registerOutParameter("_id_tipo_vehiculo",java.sql.Types.INTEGER);
            cs.setString("_nombre", tipoVehiculo.getNombre());
            cs.setString("_descripcion",tipoVehiculo.getDescripcion());
            resultado = cs.executeUpdate();
            tipoVehiculo.setIdTipoVehiculo(cs.getInt("_id_tipo_vehiculo"));
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex)
            {System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int modificar(TipoVehiculo tipoVehiculo) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call INSERTAR_TIPO_VEHICULO(?,?,?) }");
            cs.setInt("_id_tipo_vehiculo",tipoVehiculo.getIdTipoVehiculo());
            cs.setString("_nombre", tipoVehiculo.getNombre());
            cs.setString("_descripcion",tipoVehiculo.getDescripcion());
            
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
    public int eliminar(int idTipoVehiculo) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall(" { call ELIMINAR_TIPO_VEHICULO(?) }");
            cs.setInt("_id_tipo_vehiculo", idTipoVehiculo);
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
    public ArrayList<TipoVehiculo> listarTiposVehiculos() {
        ArrayList<TipoVehiculo> tiposVehiculos = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_TIPO_VEHICULOS_TODOS()}");
            rs = cs.executeQuery();
            while(rs.next()){
                TipoVehiculo tipoVehiculo = new TipoVehiculo();
                tipoVehiculo.setIdTipoVehiculo(rs.getInt("id_tipo_vehiculo"));
                tipoVehiculo.setNombre(rs.getString("nombre"));
                tipoVehiculo.setDescripcion(rs.getString("descripcion"));
                
                tipoVehiculo.setActivo(true);
                tiposVehiculos.add(tipoVehiculo);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return tiposVehiculos;
    }
    
}
