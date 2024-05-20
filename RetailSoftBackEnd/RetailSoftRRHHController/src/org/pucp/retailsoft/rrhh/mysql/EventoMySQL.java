package org.pucp.retailsoft.rrhh.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import static java.sql.Types.INTEGER;
import java.util.ArrayList;
import java.util.Date;
import org.pucp.retailsoft.config.DBManager;
import org.pucp.retailsoft.rrhh.dao.EventoDAO;
import org.pucp.retailsoft.rrhh.model.Evento;

public class EventoMySQL implements EventoDAO{
    private Connection con;
    private ResultSet rs;
    private CallableStatement cs;
    
    @Override
    public int insertar(Evento evento) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call INSERTAR_EVENTO(?,?,?,?,?,?,?,?,?)}");
            cs.registerOutParameter("_id_evento", INTEGER);
            cs.setString("_nombre", evento.getNombre());
            cs.setString("_lugar",evento.getLugar());
            cs.setString("_descripcion", evento.getDescripcion());
            cs.setBytes("_imagen", evento.getImagen());
            cs.setDate("_fecha_realizacion", new java.sql.Date(evento.getFechaRealizacion().getTime()));
            cs.setTime("_hora_inicio",evento.getHoraInicio());
            cs.setTime("_hora_fin",evento.getHoraFin());
            cs.setInt("_total_invitados", evento.getTotalInvitados());
            cs.executeUpdate();
            evento.setIdEvento(cs.getInt("_id_evento"));
            resultado = evento.getIdEvento();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int modificar(Evento evento) {
        int resultado = 0;
	try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call MODIFICAR_EVENTO(?,?,?,?,?,?,?,?,?)}");
            cs.setInt("_id_evento",evento.getIdEvento());
            cs.setString("_nombre", evento.getNombre());
            cs.setString("_lugar",evento.getLugar());
            cs.setString("_descripcion", evento.getDescripcion());
            cs.setBytes("_imagen", evento.getImagen());
            cs.setDate("_fecha_realizacion", new java.sql.Date(evento.getFechaRealizacion().getTime()));
            cs.setTime("_hora_inicio",evento.getHoraInicio());
            cs.setTime("_hora_fin",evento.getHoraFin());
            cs.setInt("_total_invitados", evento.getTotalInvitados());
            resultado=cs.executeUpdate();
	}catch(Exception ex){
		System.out.println(ex.getMessage());
	}finally{
		try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
	}
	return resultado;
    }

    @Override
    public int eliminar(int idEvento) {
        int resultado = 0;
	try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call ELIMINAR_EVENTO(?)}");
            cs.setInt("_id_evento", idEvento);
            resultado=cs.executeUpdate();
	}catch(Exception ex){
		System.out.println(ex.getMessage());
	}finally{
		try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
	}
	return resultado;
    }

    @Override
    public ArrayList<Evento> listar() {
        ArrayList<Evento> eventos = new ArrayList<>();
	try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_EVENTOS()}");
            rs = cs.executeQuery();
            while(rs.next()){
                Evento evento = new Evento();
                evento.setIdEvento(rs.getInt("id_evento"));
                evento.setNombre(rs.getString("nombre"));
                evento.setLugar(rs.getString("lugar"));
                evento.setDescripcion(rs.getString("descripcion"));
                evento.setImagen(rs.getBytes("imagen"));
                evento.setFechaRealizacion(rs.getDate("fecha_realizacion"));
                evento.setHoraInicio(rs.getTime("hora_inicio"));
                evento.setHoraFin(rs.getTime("hora_fin"));
                evento.setTotalInvitados(rs.getInt("total_invitados"));
                evento.setActivo(true);
                eventos.add(evento);
            }
	}catch(Exception ex){
		System.out.println(ex.getMessage());
	}finally{
		try{rs.close();}catch(Exception ex){System.out.println(ex.getMessage());}
		try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
	}
	return eventos;
    }

    @Override
    public ArrayList<Evento> listarxnombre(String nombre) {
        ArrayList<Evento> eventos = new ArrayList<>();
	try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_EVENTOS_X_NOMBRE(?)}");
            cs.setString("_nombre", nombre);
            rs = cs.executeQuery();
            while(rs.next()){
                Evento evento = new Evento();
                evento.setIdEvento(rs.getInt("id_evento"));
                evento.setNombre(rs.getString("nombre"));
                evento.setLugar(rs.getString("lugar"));
                evento.setDescripcion(rs.getString("descripcion"));
                evento.setImagen(rs.getBytes("imagen"));
                evento.setFechaRealizacion(rs.getDate("fecha_realizacion"));
                evento.setHoraInicio(rs.getTime("hora_inicio"));
                evento.setHoraFin(rs.getTime("hora_fin"));
                evento.setTotalInvitados(rs.getInt("total_invitados"));
                evento.setActivo(true);
                eventos.add(evento);
            }
	}catch(Exception ex){
		System.out.println(ex.getMessage());
	}finally{
		try{rs.close();}catch(Exception ex){System.out.println(ex.getMessage());}
		try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
	}
	return eventos;
    }

    @Override
    public ArrayList<Evento> listarxfecha(Date fechaInicio, Date fechaFin) {
        ArrayList<Evento> eventos = new ArrayList<>();
	try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_EVENTO_X_FECHA(?,?)}");
            cs.setDate("_fecha_inicio", new java.sql.Date(fechaInicio.getTime()));
            cs.setDate("_fecha_fin", new java.sql.Date(fechaFin.getTime()));
            rs = cs.executeQuery();
            while(rs.next()){
                Evento evento = new Evento();
                evento.setIdEvento(rs.getInt("id_evento"));
                evento.setNombre(rs.getString("nombre"));
                evento.setLugar(rs.getString("lugar"));
                evento.setDescripcion(rs.getString("descripcion"));
                evento.setImagen(rs.getBytes("imagen"));
                evento.setFechaRealizacion(rs.getDate("fecha_realizacion"));
                evento.setHoraInicio(rs.getTime("hora_inicio"));
                evento.setHoraFin(rs.getTime("hora_fin"));
                evento.setTotalInvitados(rs.getInt("total_invitados"));
                evento.setActivo(true);
                eventos.add(evento);
            }
	}catch(Exception ex){
		System.out.println(ex.getMessage());
	}finally{
		try{rs.close();}catch(Exception ex){System.out.println(ex.getMessage());}
		try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
	}
	return eventos;
    }
    
}
