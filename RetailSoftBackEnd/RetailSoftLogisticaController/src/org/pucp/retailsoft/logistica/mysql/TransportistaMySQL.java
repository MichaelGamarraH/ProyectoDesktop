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
import org.pucp.retailsoft.logistica.dao.TransportistaDAO;
import org.pucp.retailsoft.logistica.model.Transportista;
import org.pucp.retailsoft.logistica.model.Vehiculo;

/**
 *
 * @author Dell
 */
public class TransportistaMySQL implements TransportistaDAO{
    private Connection con;
    private String sql;
    private ResultSet rs;
    private CallableStatement cs;
    @Override
    public int insertar(Transportista transportista) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call INSERTAR_TRANSPORTISTA(?,?,?,?,?)}");
            cs.registerOutParameter("_id_transportista",java.sql.Types.INTEGER);
            cs.setInt("_fid_vehiculo", transportista.getVehiculo().getIdVehiculo());
            cs.setString("_num_brevete", transportista.getNumBrevete());
            cs.setString("_tipo_brevete", transportista.getTipoBrevete());
            cs.setBytes("_brevete", transportista.getBrevete());
            cs.executeUpdate();
            transportista.setIdTransportista(cs.getInt("_id_transportista"));   
            resultado = transportista.getIdTransportista();
           
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex)
            {System.out.println(ex.getMessage());}
        }
        return resultado;   
    }

    @Override
    public int modificar(Transportista transportista) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call MODIFICAR_TRANSPORTISTA(?,?,?,?,?)}");
            cs.setInt("_id_transportista",transportista.getIdTransportista());
            cs.setInt("_fid_vehiculo", transportista.getVehiculo().getIdVehiculo());
            cs.setString("_num_brevete", transportista.getNumBrevete());
            cs.setString("_tipo_brevete", transportista.getTipoBrevete());
            cs.setBytes("_brevete", transportista.getBrevete());  
            cs.executeUpdate();
            resultado = transportista.getIdTransportista();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex)
            {System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int eliminar(int idTransportista) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall(" { call ELIMINAR_TRANSPORTISTA(?) }");
            cs.setInt("_id_transportista", idTransportista);
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
    public ArrayList<Transportista> listarTransportistas() {
        ArrayList<Transportista> transportistas = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_TRANSPORTISTA_TODOS()}");
            rs = cs.executeQuery();
            while(rs.next()){
                Transportista transportista = new Transportista();
                transportista.setIdTransportista(rs.getInt("id_transportista"));
                transportista.setNumBrevete(rs.getString("num_brevete"));
                transportista.setTipoBrevete(rs.getString("tipo_brevete"));
                transportista.setBrevete(rs.getBytes("brevete")); 
                transportista.setVehiculo(new Vehiculo());
                transportista.getVehiculo().setIdVehiculo(rs.getInt("fid_vehiculo"));
                transportista.setActivo(true);
                transportistas.add(transportista);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return transportistas;
    }
    
}
