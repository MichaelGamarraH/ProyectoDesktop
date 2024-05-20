package org.pucp.retailsoft.rrhh.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import static java.sql.Types.INTEGER;
import java.util.ArrayList;
import java.util.Date;
import org.pucp.retailsoft.config.DBManager;
import org.pucp.retailsoft.rrhh.dao.PuestoTrabajoDAO;
import org.pucp.retailsoft.rrhh.model.PuestoTrabajo;

public class PuestoTrabajoMySQL implements PuestoTrabajoDAO{
    private Connection con;
    private ResultSet rs;
    private CallableStatement cs;
    
    @Override
    public int insertar(PuestoTrabajo puesto) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call INSERTAR_PUESTO_TRABAJO(?,?,?,?,?,?,?,?)}");
            cs.registerOutParameter("_id_puesto_trabajo", INTEGER);
            cs.setString("_nombre", puesto.getNombre());
            cs.setString("_descripcion",puesto.getDescripcion());
            cs.setString("_requisitos", puesto.getRequisitos());
            cs.setInt("_vacantes", puesto.getVacantes());
            cs.setDate("_fecha_publicacion", new java.sql.Date(puesto.getFechaPublicacion().getTime()));
            cs.setDate("_fecha_limite", new java.sql.Date(puesto.getFechaLimite().getTime()));
            cs.setString("_correo_responsable", puesto.getCorreoResponsable());
            cs.executeUpdate();
            puesto.setIdPuestoTrabajo(cs.getInt("_id_puesto_trabajo"));
            resultado = puesto.getIdPuestoTrabajo();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int modificar(PuestoTrabajo puesto) {
        int resultado = 0;
	try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call MODIFICAR_PUESTO_TRABAJO(?,?,?,?,?,?,?,?)}");
            cs.setInt("_id_puesto_trabajo",puesto.getIdPuestoTrabajo());
            cs.setString("_nombre", puesto.getNombre());
            cs.setString("_descripcion",puesto.getDescripcion());
            cs.setString("_requisitos", puesto.getRequisitos());
            cs.setInt("_vacantes", puesto.getVacantes());
            cs.setDate("_fecha_publicacion", new java.sql.Date(puesto.getFechaPublicacion().getTime()));
            cs.setDate("_fecha_limite", new java.sql.Date(puesto.getFechaLimite().getTime()));
            cs.setString("_correo_responsable", puesto.getCorreoResponsable());
            resultado=cs.executeUpdate();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
	}finally{
		try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
	}
	return resultado;
    }

    @Override
    public int eliminar(int idPuesto) {
        int resultado = 0;
	try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call ELIMINAR_PUESTO_TRABAJO(?)}");
            cs.setInt("_id_puesto_trabajo", idPuesto);
            resultado=cs.executeUpdate();
	}catch(Exception ex){
		System.out.println(ex.getMessage());
	}finally{
		try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
	}
	return resultado;
    }

    @Override
    public ArrayList<PuestoTrabajo> listar() {
        ArrayList<PuestoTrabajo> puestos = new ArrayList<>();
	try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_PUESTOS_TRABAJO()}");
            rs = cs.executeQuery();
            while(rs.next()){
                PuestoTrabajo puesto = new PuestoTrabajo();
                puesto.setIdPuestoTrabajo(rs.getInt("id_puesto_trabajo"));
                puesto.setNombre(rs.getString("nombre"));
                puesto.setDescripcion(rs.getString("descripcion"));
                puesto.setRequisitos(rs.getString("requisitos"));
                puesto.setVacantes(rs.getInt("vacantes"));
                puesto.setFechaPublicacion(rs.getDate("fecha_publicacion"));
                puesto.setFechaLimite(rs.getDate("fecha_limite"));
                puesto.setCorreoResponsable(rs.getString("correo_responsable"));
                puesto.setActivo(true);
                puestos.add(puesto);
            }
	}catch(Exception ex){
		System.out.println(ex.getMessage());
	}finally{
		try{rs.close();}catch(Exception ex){System.out.println(ex.getMessage());}
		try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
	}
	return puestos;
    }

    @Override
    public ArrayList<PuestoTrabajo> listarPorNombre(String nombre) {
        ArrayList<PuestoTrabajo> puestos = new ArrayList<>();
	try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_PUESTOS_TRABAJO_POR_NOMBRE(?)}");
            cs.setString("_nombre", nombre);
            rs = cs.executeQuery();
            while(rs.next()){
                PuestoTrabajo puesto = new PuestoTrabajo();
                puesto.setIdPuestoTrabajo(rs.getInt("id_puesto_trabajo"));
                puesto.setNombre(rs.getString("nombre"));
                puesto.setDescripcion(rs.getString("descripcion"));
                puesto.setRequisitos(rs.getString("requisitos"));
                puesto.setVacantes(rs.getInt("vacantes"));
                puesto.setFechaPublicacion(rs.getDate("fecha_publicacion"));
                puesto.setFechaLimite(rs.getDate("fecha_limite"));
                puesto.setCorreoResponsable(rs.getString("correo_responsable"));
                puesto.setActivo(true);
                puestos.add(puesto);
            }
	}catch(Exception ex){
		System.out.println(ex.getMessage());
	}finally{
		try{rs.close();}catch(Exception ex){System.out.println(ex.getMessage());}
		try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
	}
	return puestos;
    }

    @Override
    public ArrayList<PuestoTrabajo> listarPorFechaPublicacion(Date fechaInicio, Date fechaFin) {
        ArrayList<PuestoTrabajo> puestos = new ArrayList<>();
	try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_PUESTOS_TRABAJO_X_FECHA_PUBLICACION(?,?)}");
            cs.setDate("_fecha_inicio", new java.sql.Date(fechaInicio.getTime()));
            cs.setDate("_fecha_fin", new java.sql.Date(fechaFin.getTime()));
            rs = cs.executeQuery();
            while(rs.next()){
                PuestoTrabajo puesto = new PuestoTrabajo();
                puesto.setIdPuestoTrabajo(rs.getInt("id_puesto_trabajo"));
                puesto.setNombre(rs.getString("nombre"));
                puesto.setDescripcion(rs.getString("descripcion"));
                puesto.setRequisitos(rs.getString("requisitos"));
                puesto.setVacantes(rs.getInt("vacantes"));
                puesto.setFechaPublicacion(rs.getDate("fecha_publicacion"));
                puesto.setFechaLimite(rs.getDate("fecha_limite"));
                puesto.setCorreoResponsable(rs.getString("correo_responsable"));
                puesto.setActivo(true);
                puestos.add(puesto);
            }
	}catch(Exception ex){
		System.out.println(ex.getMessage());
	}finally{
		try{rs.close();}catch(Exception ex){System.out.println(ex.getMessage());}
		try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
	}
	return puestos;
    }

    @Override
    public ArrayList<PuestoTrabajo> listarPorFechaLimite(Date fechaInicio, Date fechaFin) {
        ArrayList<PuestoTrabajo> puestos = new ArrayList<>();
	try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_PUESTOS_TRABAJO_X_FECHA_LIMITE(?,?)}");
            cs.setDate("_fecha_inicio", new java.sql.Date(fechaInicio.getTime()));
            cs.setDate("_fecha_fin", new java.sql.Date(fechaFin.getTime()));
            rs = cs.executeQuery();
            while(rs.next()){
                PuestoTrabajo puesto = new PuestoTrabajo();
                puesto.setIdPuestoTrabajo(rs.getInt("id_puesto_trabajo"));
                puesto.setNombre(rs.getString("nombre"));
                puesto.setDescripcion(rs.getString("descripcion"));
                puesto.setRequisitos(rs.getString("requisitos"));
                puesto.setVacantes(rs.getInt("vacantes"));
                puesto.setFechaPublicacion(rs.getDate("fecha_publicacion"));
                puesto.setFechaLimite(rs.getDate("fecha_limite"));
                puesto.setCorreoResponsable(rs.getString("correo_responsable"));
                puesto.setActivo(true);
                puestos.add(puesto);
            }
	}catch(Exception ex){
		System.out.println(ex.getMessage());
	}finally{
		try{rs.close();}catch(Exception ex){System.out.println(ex.getMessage());}
		try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
	}
	return puestos;
    }
}
