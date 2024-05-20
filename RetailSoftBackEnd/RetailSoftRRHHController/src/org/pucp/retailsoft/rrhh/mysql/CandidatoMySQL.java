package org.pucp.retailsoft.rrhh.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import static java.sql.Types.INTEGER;
import java.util.ArrayList;
import org.pucp.retailsoft.config.DBManager;
import org.pucp.retailsoft.rrhh.dao.CandidatoDAO;
import org.pucp.retailsoft.rrhh.model.Candidato;
import org.pucp.retailsoft.rrhh.model.PuestoTrabajo;

public class CandidatoMySQL implements CandidatoDAO {

    private Connection con;
    private ResultSet rs;
    private CallableStatement cs;
    @Override
    public int insertar(Candidato candidato) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call INSERTAR_CANDIDATO(?,?,?,?,?,?,?,?,?,?,?)}");
            cs.registerOutParameter("_id_candidato", INTEGER);
            cs.setString("_nombre", candidato.getNombre());
            cs.setString("_documento_identidad",candidato.getDni());
            cs.setString("_apellido_paterno", candidato.getApellidoPaterno());
            cs.setString("_apellido_materno", candidato.getApellidoMaterno());
            cs.setString("_genero", String.valueOf(candidato.getGenero()));
            cs.setDate("_fecha_nacimiento", new java.sql.Date(candidato.getFechaNacimiento().getTime()));
            cs.setString("_telefono", candidato.getTelefono());
            cs.setString("_correo_electronico", candidato.getCorreoElectronico());
            cs.setInt("_fid_puesto_trabajo", candidato.getPuestoTrabajo().getIdPuestoTrabajo());
            cs.setBytes("_CV", candidato.getCv());
            cs.executeUpdate();
            candidato.setIdPersona(cs.getInt("_id_candidato"));
            resultado =  candidato.getIdPersona();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int modificar(Candidato candidato) {
        int resultado = 0;
	try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call MODIFICAR_CANDIDATO(?,?,?,?,?,?,?,?,?,?,?)}");
            cs.setInt("_id_candidato",candidato.getIdPersona());
            cs.setString("_nombre", candidato.getNombre());
            cs.setString("_documento_identidad",candidato.getDni());
            cs.setString("_apellido_paterno", candidato.getApellidoPaterno());
            cs.setString("_apellido_materno", candidato.getApellidoMaterno());
            cs.setString("_genero", String.valueOf(candidato.getGenero()));
            cs.setDate("_fecha_nacimiento", new java.sql.Date(candidato.getFechaNacimiento().getTime()));
            cs.setString("_telefono", candidato.getTelefono());
            cs.setString("_correo_electronico", candidato.getCorreoElectronico());
            cs.setInt("_fid_puesto_trabajo", candidato.getPuestoTrabajo().getIdPuestoTrabajo());
            cs.setBytes("_CV", candidato.getCv());
            resultado=cs.executeUpdate();
	}catch(Exception ex){
		System.out.println(ex.getMessage());
	}finally{
		try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
	}
	return resultado;
    }

    @Override
    public int eliminar(int idCandidato) {
        int resultado = 0;
	try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call ELIMINAR_CANDIDATO(?)}");
            cs.setInt("_id_candidato", idCandidato);
            resultado=cs.executeUpdate();
	}catch(Exception ex){
		System.out.println(ex.getMessage());
	}finally{
		try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
	}
	return resultado;
    }

    @Override
    public ArrayList<Candidato> listarCandidatos() {
        ArrayList<Candidato> candidatos = new ArrayList<>();
	try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_CANDIDATOS()}");
            rs = cs.executeQuery();
            while(rs.next()){
                Candidato c = new Candidato();
                c.setIdPersona(rs.getInt("id_persona"));
                c.setNombre(rs.getString("nombre"));
                c.setApellidoPaterno(rs.getString("apellido_paterno"));
                c.setApellidoMaterno(rs.getString("apellido_materno"));
                c.setDni(rs.getString("documento_identidad"));
                c.setGenero(rs.getString("genero").charAt(0));
                c.setFechaNacimiento(rs.getDate("fecha_nacimiento"));
                c.setTelefono(rs.getString("telefono"));
                c.setCorreoElectronico(rs.getString("correo_electronico"));
                c.setCv(rs.getBytes("CV"));
                c.setPuestoTrabajo(new PuestoTrabajo());
                c.getPuestoTrabajo().setIdPuestoTrabajo(rs.getInt("id_puesto_trabajo"));
                c.getPuestoTrabajo().setNombre(rs.getString("nombre_puesto"));
                c.getPuestoTrabajo().setActivo(true);
                c.setActivo(true);
                candidatos.add(c);
            }
	}catch(Exception ex){
		System.out.println(ex.getMessage());
	}finally{
		try{rs.close();}catch(Exception ex){System.out.println(ex.getMessage());}
		try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
	}
	return candidatos;
    }

    @Override
    public ArrayList<Candidato> listarCandidatosXidPuesto(int idPuesto) {
        ArrayList<Candidato> candidatos = new ArrayList<>();
	try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_CANDIDATOS_X_ID_PUESTO(?)}");
            cs.setInt("_id_puesto", idPuesto);
            rs = cs.executeQuery();
            while(rs.next()){
                Candidato c = new Candidato();
                c.setIdPersona(rs.getInt("id_persona"));
                c.setNombre(rs.getString("nombre"));
                c.setApellidoPaterno(rs.getString("apellido_paterno"));
                c.setApellidoMaterno(rs.getString("apellido_materno"));
                c.setDni(rs.getString("documento_identidad"));
                c.setGenero(rs.getString("genero").charAt(0));
                c.setFechaNacimiento(rs.getDate("fecha_nacimiento"));
                c.setTelefono(rs.getString("telefono"));
                c.setCorreoElectronico(rs.getString("correo_electronico"));
                c.setCv(rs.getBytes("CV"));
                c.setPuestoTrabajo(new PuestoTrabajo());
                c.getPuestoTrabajo().setIdPuestoTrabajo(rs.getInt("id_puesto_trabajo"));
                c.getPuestoTrabajo().setNombre(rs.getString("nombre_puesto"));
                c.getPuestoTrabajo().setActivo(true);
                c.setActivo(true);
                candidatos.add(c);
            }
	}catch(Exception ex){
		System.out.println(ex.getMessage());
	}finally{
		try{rs.close();}catch(Exception ex){System.out.println(ex.getMessage());}
		try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
	}
	return candidatos;
    }

    @Override
    public ArrayList<Candidato> listarCandidatosXnombreDNIidPuesto(String nombreDNI, int idPuesto) {
        ArrayList<Candidato> candidatos = new ArrayList<>();
	try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_CANDIDATOS_X_NOMBRE_DNI_ID_PUESTO(?,?)}");
            cs.setString("_nombreDNI", nombreDNI);
            cs.setInt("_id_puesto", idPuesto);
            rs = cs.executeQuery();
            while(rs.next()){
                Candidato c = new Candidato();
                c.setIdPersona(rs.getInt("id_persona"));
                c.setNombre(rs.getString("nombre"));
                c.setApellidoPaterno(rs.getString("apellido_paterno"));
                c.setApellidoMaterno(rs.getString("apellido_materno"));
                c.setDni(rs.getString("documento_identidad"));
                c.setGenero(rs.getString("genero").charAt(0));
                c.setFechaNacimiento(rs.getDate("fecha_nacimiento"));
                c.setTelefono(rs.getString("telefono"));
                c.setCorreoElectronico(rs.getString("correo_electronico"));
                c.setCv(rs.getBytes("CV"));
                c.setPuestoTrabajo(new PuestoTrabajo());
                c.getPuestoTrabajo().setIdPuestoTrabajo(rs.getInt("id_puesto_trabajo"));
                c.getPuestoTrabajo().setNombre(rs.getString("nombre_puesto"));
                c.getPuestoTrabajo().setActivo(true);
                c.setActivo(true);
                candidatos.add(c);
            }
	}catch(Exception ex){
		System.out.println(ex.getMessage());
	}finally{
		try{rs.close();}catch(Exception ex){System.out.println(ex.getMessage());}
		try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
	}
	return candidatos;
    }
}

