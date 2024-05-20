package org.pucp.retailsoft.logistica.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.util.ArrayList;
import org.pucp.retailsoft.config.DBManager;
import org.pucp.retailsoft.logistica.dao.AlmacenDAO;
import org.pucp.retailsoft.logistica.model.Almacen;

/**
 *
 * @author Dell
 */
public class AlmacenMySQL implements AlmacenDAO{
    private Connection con;
    private String sql;
    private ResultSet rs;
    private CallableStatement cs;
    @Override
    public int insertar(Almacen almacen) {
         int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call INSERTAR_ALMACEN(?,?,?,?,?,?,?,?,?,?,?,?)}");
            cs.registerOutParameter("_id_almacen",java.sql.Types.INTEGER);
            
            cs.setString("_nombre", almacen.getNombre());
            cs.setString("_responsable", almacen.getResponsable());
            cs.setString("_direccion", almacen.getDireccion());
            cs.setInt("_capacidad",almacen.getCapacidad());
            cs.setDate("_fecha_actualizacion", new java.sql.Date(almacen.getFechaActualizacion().getTime()));
            cs.setDate("_fecha_mantenimiento", new java.sql.Date(almacen.getFecha_mantenimiento().getTime()));
            cs.setString("_descripcion",almacen.getDescripcion());
            cs.setBoolean("_espacio_pickpack", almacen.isEspacio_pickpack());
            cs.setBoolean("_stand_ajustable", almacen.isStand_ajustable());
            cs.setBoolean("_sistema_iluminacion", almacen.isSistema_iluminacion());
            cs.setBoolean("_control_calidad", almacen.isControl_calidad());
            cs.executeUpdate();
            almacen.setIdAlmacen(cs.getInt("_id_almacen"));   
            resultado = almacen.getIdAlmacen();
           
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex)
            {System.out.println(ex.getMessage());}
        }
        return resultado;   
    }

    @Override
    public int modificar(Almacen almacen) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call MODIFICAR_ALMACEN(?,?,?,?,?,?,?,?,?,?,?,?)}");
            cs.setInt("_id_almacen",almacen.getIdAlmacen());
            cs.setString("_nombre", almacen.getNombre());
            cs.setString("_responsable", almacen.getResponsable());
            cs.setString("_direccion", almacen.getDireccion());
            cs.setInt("_capacidad",almacen.getCapacidad());
            cs.setDate("_fecha_actualizacion", new java.sql.Date(almacen.getFechaActualizacion().getTime()));
            cs.setDate("_fecha_mantenimiento", new java.sql.Date(almacen.getFecha_mantenimiento().getTime()));
            cs.setString("_descripcion",almacen.getDescripcion());
            cs.setBoolean("_espacio_pickpack", almacen.isEspacio_pickpack());
            cs.setBoolean("_stand_ajustable", almacen.isStand_ajustable());
            cs.setBoolean("_sistema_iluminacion", almacen.isSistema_iluminacion());
            cs.setBoolean("_control_calidad", almacen.isControl_calidad());
            cs.executeUpdate();
            resultado = almacen.getIdAlmacen();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex)
            {System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int eliminar(int idAlmacen) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call ELIMINAR_ALMACEN(?)}");
            cs.setInt("_id_almacen", idAlmacen);
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
    public ArrayList<Almacen> listarAlmacenes() {
        ArrayList<Almacen> almacenes = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_ALMACENES_TODOS()}");
            rs = cs.executeQuery();
            while(rs.next()){
                Almacen almacen = new Almacen();
                almacen.setIdAlmacen(rs.getInt("id_almacen"));
                almacen.setNombre(rs.getString("nombre"));
                almacen.setResponsable(rs.getString("responsable"));
                almacen.setDireccion(rs.getString("direccion"));
                almacen.setCapacidad(rs.getInt("capacidad"));
                almacen.setFechaActualizacion(rs.getDate("fecha_actualizacion"));
                almacen.setFecha_mantenimiento(rs.getDate("fecha_mantenimiento"));
                almacen.setDescripcion(rs.getString("descripcion"));
                almacen.setEspacio_pickpack(rs.getBoolean("espacio_pickpack"));
                almacen.setStand_ajustable(rs.getBoolean("stand_ajustable"));
                almacen.setSistema_iluminacion(rs.getBoolean("sistema_iluminacion"));
                almacen.setControl_calidad(rs.getBoolean("control_calidad"));
                almacen.setActivo(true);
                almacenes.add(almacen);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return almacenes;
    }
    
}
