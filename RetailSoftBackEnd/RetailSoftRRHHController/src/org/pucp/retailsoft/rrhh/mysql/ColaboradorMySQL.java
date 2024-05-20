package org.pucp.retailsoft.rrhh.mysql;
import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import static java.sql.Types.INTEGER;
import java.util.ArrayList;
import org.pucp.retailsoft.config.DBManager;
import org.pucp.retailsoft.rrhh.dao.ColaboradorDAO;
import org.pucp.retailsoft.rrhh.model.Cargo;
import org.pucp.retailsoft.rrhh.model.Colaborador;

public class ColaboradorMySQL implements ColaboradorDAO {
    private Connection con;
    private ResultSet rs;
    private CallableStatement cs;
    @Override
    public int insertar(Colaborador colaborador) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call INSERTAR_COLABORADOR(?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)}");
            //cs = con.prepareCall("{call INSERTAR_EMPLEADO(?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)}"); XDXD
            cs.registerOutParameter("_id_colaborador", INTEGER);
            cs.setString("_nombre", colaborador.getNombre());
            cs.setString("_documento_identidad",colaborador.getDni());
            cs.setString("_apellido_paterno", colaborador.getApellidoPaterno());
            cs.setString("_apellido_materno", colaborador.getApellidoMaterno());
            cs.setString("_genero", String.valueOf(colaborador.getGenero()));
            cs.setDate("_fecha_nacimiento", new java.sql.Date(colaborador.getFechaNacimiento().getTime()));
            cs.setString("_telefono", colaborador.getTelefono());
            cs.setString("_correo_electronico", colaborador.getCorreoElectronico());
            cs.setInt("_fid_cargo", colaborador.getCargo().getIdCargo());
            cs.setTime("_hora_ingreso",colaborador.getHoraIngreso());
            cs.setTime("_hora_salida",colaborador.getHoraSalida());
            cs.setBytes("_imagen", colaborador.getImagen());
            cs.setString("_usuario", colaborador.getUsuario());
            cs.setString("_contrasenha", colaborador.getContrasenha());
            cs.executeUpdate();
            
            colaborador.setIdPersona(cs.getInt("_id_colaborador"));   
            resultado = colaborador.getIdPersona(); 
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int modificar(Colaborador colaborador) {
        int resultado = 0;
	try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call MODIFICAR_COLABORADOR(?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)}");
            cs.setInt("_id_colaborador",colaborador.getIdPersona());
            cs.setString("_nombre", colaborador.getNombre());
            cs.setString("_documento_identidad",colaborador.getDni());
            cs.setString("_apellido_paterno", colaborador.getApellidoPaterno());
            cs.setString("_apellido_materno", colaborador.getApellidoMaterno());
            cs.setString("_genero", String.valueOf(colaborador.getGenero()));
            cs.setDate("_fecha_nacimiento", new java.sql.Date(colaborador.getFechaNacimiento().getTime()));
            cs.setString("_telefono", colaborador.getTelefono());
            cs.setString("_correo_electronico", colaborador.getCorreoElectronico());

            cs.setInt("_fid_cargo", colaborador.getCargo().getIdCargo());
            cs.setTime("_hora_ingreso",colaborador.getHoraIngreso());
            cs.setTime("_hora_salida",colaborador.getHoraSalida());
            cs.setBytes("_imagen", colaborador.getImagen());
            cs.setString("_usuario", colaborador.getUsuario());
            cs.setString("_contrasenha", colaborador.getContrasenha());
            resultado=cs.executeUpdate();
	}catch(Exception ex){
		System.out.println(ex.getMessage());
	}finally{
		try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
	}
	return resultado;
    }

    @Override
    public int eliminar(int idColaborador) {
        int resultado = 0;
	try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call ELIMINAR_COLABORADOR(?)}");
            cs.setInt("_id_colaborador", idColaborador);
            resultado=cs.executeUpdate();
	}catch(Exception ex){
		System.out.println(ex.getMessage());
	}finally{
		try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
	}
	return resultado;
    }

    @Override
    public ArrayList<Colaborador> listar() {
        ArrayList<Colaborador> colaboradores = new ArrayList<>();
	try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_COLABORADORES()}");
            rs = cs.executeQuery();
            while(rs.next()){
                Colaborador c = new Colaborador();
                c.setIdPersona(rs.getInt("id_persona"));
                c.setNombre(rs.getString("nombre"));
                c.setApellidoPaterno(rs.getString("apellido_paterno"));
                c.setApellidoMaterno(rs.getString("apellido_materno"));
                c.setDni(rs.getString("documento_identidad"));
                c.setGenero(rs.getString("genero").charAt(0));
                c.setFechaNacimiento(rs.getDate("fecha_nacimiento"));
                c.setTelefono(rs.getString("telefono"));
                c.setCorreoElectronico(rs.getString("correo_electronico"));
                c.setCargo(new Cargo());
                c.getCargo().setIdCargo(rs.getInt("id_cargo"));
                c.getCargo().setTipoCargo(rs.getString("tipo_cargo"));
                c.getCargo().setActivo(true);
                c.setHoraIngreso(rs.getTime("hora_ingreso"));
                c.setHoraSalida(rs.getTime("hora_salida"));
                c.setUsuario(rs.getString("usuario"));
                c.setImagen(rs.getBytes("imagen"));
                c.setActivo(true);
                colaboradores.add(c);
            }
	}catch(Exception ex){
		System.out.println(ex.getMessage());
	}finally{
		try{rs.close();}catch(Exception ex){System.out.println(ex.getMessage());}
		try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
	}
	return colaboradores;
    }

    @Override
    public ArrayList<Colaborador> listarxnombredni(String nombreDNI) {
        ArrayList<Colaborador> colaboradores = new ArrayList<>();
	try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_COLABORADORES_X_NOMBREDNI(?)}");
            cs.setString("_nombreDNI", nombreDNI);
            rs = cs.executeQuery();
            while(rs.next()){
                Colaborador c = new Colaborador();
                c.setIdPersona(rs.getInt("id_persona"));
                c.setNombre(rs.getString("nombre"));
                c.setApellidoPaterno(rs.getString("apellido_paterno"));
                c.setApellidoMaterno(rs.getString("apellido_materno"));
                c.setDni(rs.getString("documento_identidad"));
                c.setGenero(rs.getString("genero").charAt(0));
                c.setFechaNacimiento(rs.getDate("fecha_nacimiento"));
                c.setTelefono(rs.getString("telefono"));
                c.setCorreoElectronico(rs.getString("correo_electronico"));
                c.setCargo(new Cargo());
                c.getCargo().setIdCargo(rs.getInt("id_cargo"));
                c.getCargo().setTipoCargo(rs.getString("tipo_cargo"));
                c.getCargo().setActivo(true);
                c.setHoraIngreso(rs.getTime("hora_ingreso"));
                c.setHoraSalida(rs.getTime("hora_salida"));
                c.setUsuario(rs.getString("usuario"));
                c.setImagen(rs.getBytes("imagen"));
                c.setActivo(true);
                colaboradores.add(c);
            }
	}catch(Exception ex){
		System.out.println(ex.getMessage());
	}finally{
		try{rs.close();}catch(Exception ex){System.out.println(ex.getMessage());}
		try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
	}
	return colaboradores;
    }
    
    @Override
    public ArrayList<Colaborador> listarxidcargo(int idCargo) {
        ArrayList<Colaborador> colaboradores = new ArrayList<>();
	try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_COLABORADORES_X_ID_CARGO(?)}");
            cs.setInt("_id_cargo", idCargo);
            rs = cs.executeQuery();
            while(rs.next()){
                Colaborador c = new Colaborador();
                c.setIdPersona(rs.getInt("id_persona"));
                c.setNombre(rs.getString("nombre"));
                c.setApellidoPaterno(rs.getString("apellido_paterno"));
                c.setApellidoMaterno(rs.getString("apellido_materno"));
                c.setDni(rs.getString("documento_identidad"));
                c.setGenero(rs.getString("genero").charAt(0));
                c.setFechaNacimiento(rs.getDate("fecha_nacimiento"));
                c.setTelefono(rs.getString("telefono"));
                c.setCorreoElectronico(rs.getString("correo_electronico"));
                c.setCargo(new Cargo());
                c.getCargo().setIdCargo(rs.getInt("id_cargo"));
                c.getCargo().setTipoCargo(rs.getString("tipo_cargo"));
                c.getCargo().setActivo(true);
                c.setHoraIngreso(rs.getTime("hora_ingreso"));
                c.setHoraSalida(rs.getTime("hora_salida"));
                c.setUsuario(rs.getString("usuario"));
                c.setImagen(rs.getBytes("imagen"));
                c.setActivo(true);
                colaboradores.add(c);
            }
	}catch(Exception ex){
		System.out.println(ex.getMessage());
	}finally{
		try{rs.close();}catch(Exception ex){System.out.println(ex.getMessage());}
		try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
	}
	return colaboradores;
    }
    
    @Override
    public ArrayList<Colaborador> listarxdnidesc() {
        ArrayList<Colaborador> colaboradores = new ArrayList<>();
	try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_COLABORADORES_X_DNI_DESC()}");
            rs = cs.executeQuery();
            while(rs.next()){
                Colaborador c = new Colaborador();
                c.setIdPersona(rs.getInt("id_persona"));
                c.setNombre(rs.getString("nombre"));
                c.setApellidoPaterno(rs.getString("apellido_paterno"));
                c.setApellidoMaterno(rs.getString("apellido_materno"));
                c.setDni(rs.getString("documento_identidad"));
                c.setGenero(rs.getString("genero").charAt(0));
                c.setFechaNacimiento(rs.getDate("fecha_nacimiento"));
                c.setTelefono(rs.getString("telefono"));
                c.setCorreoElectronico(rs.getString("correo_electronico"));
                c.setCargo(new Cargo());
                c.getCargo().setIdCargo(rs.getInt("id_cargo"));
                c.getCargo().setTipoCargo(rs.getString("tipo_cargo"));
                c.getCargo().setActivo(true);
                c.setHoraIngreso(rs.getTime("hora_ingreso"));
                c.setHoraSalida(rs.getTime("hora_salida"));
                c.setUsuario(rs.getString("usuario"));
                c.setImagen(rs.getBytes("imagen"));
                c.setActivo(true);
                colaboradores.add(c);
            }
	}catch(Exception ex){
		System.out.println(ex.getMessage());
	}finally{
		try{rs.close();}catch(Exception ex){System.out.println(ex.getMessage());}
		try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
	}
	return colaboradores;
    }
    
    @Override
    public ArrayList<Colaborador> listarxapellidodesc() {
        ArrayList<Colaborador> colaboradores = new ArrayList<>();
	try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_COLABORADORES_X_APELLIDO_DESC()}");
            rs = cs.executeQuery();
            while(rs.next()){
                Colaborador c = new Colaborador();
                c.setIdPersona(rs.getInt("id_persona"));
                c.setNombre(rs.getString("nombre"));
                c.setApellidoPaterno(rs.getString("apellido_paterno"));
                c.setApellidoMaterno(rs.getString("apellido_materno"));
                c.setDni(rs.getString("documento_identidad"));
                c.setGenero(rs.getString("genero").charAt(0));
                c.setFechaNacimiento(rs.getDate("fecha_nacimiento"));
                c.setTelefono(rs.getString("telefono"));
                c.setCorreoElectronico(rs.getString("correo_electronico"));
                c.setCargo(new Cargo());
                c.getCargo().setIdCargo(rs.getInt("id_cargo"));
                c.getCargo().setTipoCargo(rs.getString("tipo_cargo"));
                c.getCargo().setActivo(true);
                c.setHoraIngreso(rs.getTime("hora_ingreso"));
                c.setHoraSalida(rs.getTime("hora_salida"));
                c.setUsuario(rs.getString("usuario"));
                c.setImagen(rs.getBytes("imagen"));
                c.setActivo(true);
                colaboradores.add(c);
            }
	}catch(Exception ex){
		System.out.println(ex.getMessage());
	}finally{
		try{rs.close();}catch(Exception ex){System.out.println(ex.getMessage());}
		try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
	}
	return colaboradores;
    }

    @Override
    public Colaborador verificarCuenta(String usuario, String contrasenha) {
        Colaborador c = new Colaborador();
	try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call VERIFICAR_CUENTA_COLABORADOR(?,?)}");
            cs.setString("_usuario", usuario);
            cs.setString("_contrasenha", contrasenha);
            rs = cs.executeQuery();
            while(rs.next()){
                c.setIdPersona(rs.getInt("id_persona"));
                c.setNombre(rs.getString("nombre"));
                c.setApellidoPaterno(rs.getString("apellido_paterno"));
                c.setApellidoMaterno(rs.getString("apellido_materno"));
                c.setDni(rs.getString("documento_identidad"));
                c.setGenero(rs.getString("genero").charAt(0));
                c.setFechaNacimiento(rs.getDate("fecha_nacimiento"));
                c.setTelefono(rs.getString("telefono"));
                c.setCorreoElectronico(rs.getString("correo_electronico"));
                c.setCargo(new Cargo());
                c.getCargo().setIdCargo(rs.getInt("id_cargo"));
                c.getCargo().setTipoCargo(rs.getString("tipo_cargo"));
                c.getCargo().setActivo(true);
                c.setHoraIngreso(rs.getTime("hora_ingreso"));
                c.setHoraSalida(rs.getTime("hora_salida"));
                c.setUsuario(rs.getString("usuario"));
                c.setImagen(rs.getBytes("imagen"));
                c.setActivo(true);
            }
	}catch(Exception ex){
		System.out.println(ex.getMessage());
	}finally{
		try{rs.close();}catch(Exception ex){System.out.println(ex.getMessage());}
		try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
	}
	return c;
    }
}
