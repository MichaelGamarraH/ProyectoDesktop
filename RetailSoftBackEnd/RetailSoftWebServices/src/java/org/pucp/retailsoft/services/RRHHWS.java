package org.pucp.retailsoft.services;

import java.util.ArrayList;
import java.util.Date;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import org.pucp.retailsoft.rrhh.dao.AsistenciaColaboradorDAO;
import org.pucp.retailsoft.rrhh.dao.BeneficioDAO;
import org.pucp.retailsoft.rrhh.dao.BeneficioxColaboradorDAO;
import org.pucp.retailsoft.rrhh.dao.CandidatoDAO;
import org.pucp.retailsoft.rrhh.dao.CargoDAO;
import org.pucp.retailsoft.rrhh.dao.ColaboradorDAO;
import org.pucp.retailsoft.rrhh.dao.ColaboradorxEventoDAO;
import org.pucp.retailsoft.rrhh.dao.EstadoCandidatoDAO;
import org.pucp.retailsoft.rrhh.dao.EventoDAO;
import org.pucp.retailsoft.rrhh.dao.PuestoTrabajoDAO;
import org.pucp.retailsoft.rrhh.dao.SalarioDAO;
import org.pucp.retailsoft.rrhh.dao.TrazabilidadCandidatoDAO;
import org.pucp.retailsoft.rrhh.model.AsistenciaColaborador;
import org.pucp.retailsoft.rrhh.model.Beneficio;
import org.pucp.retailsoft.rrhh.model.BeneficioxColaborador;
import org.pucp.retailsoft.rrhh.model.Candidato;
import org.pucp.retailsoft.rrhh.model.Cargo;
import org.pucp.retailsoft.rrhh.model.Colaborador;
import org.pucp.retailsoft.rrhh.model.ColaboradorxEvento;
import org.pucp.retailsoft.rrhh.model.EstadoCandidato;
import org.pucp.retailsoft.rrhh.model.Evento;
import org.pucp.retailsoft.rrhh.model.PuestoTrabajo;
import org.pucp.retailsoft.rrhh.model.Salario;
import org.pucp.retailsoft.rrhh.model.TrazabilidadCandidato;
import org.pucp.retailsoft.rrhh.mysql.AsistenciaColaboradorMySQL;
import org.pucp.retailsoft.rrhh.mysql.BeneficioMySQL;
import org.pucp.retailsoft.rrhh.mysql.BeneficioxColaboradorMySQL;
import org.pucp.retailsoft.rrhh.mysql.CandidatoMySQL;
import org.pucp.retailsoft.rrhh.mysql.CargoMySQL;
import org.pucp.retailsoft.rrhh.mysql.ColaboradorMySQL;
import org.pucp.retailsoft.rrhh.mysql.ColaboradorxEventoMySQL;
import org.pucp.retailsoft.rrhh.mysql.EstadoCandidatoMySQL;
import org.pucp.retailsoft.rrhh.mysql.EventoMySQL;
import org.pucp.retailsoft.rrhh.mysql.PuestoTrabajoMySQL;
import org.pucp.retailsoft.rrhh.mysql.SalarioMySQL;
import org.pucp.retailsoft.rrhh.mysql.TrazabilidadCandidatoMySQL;

/**
 *
 * @author JOHAN
 */
@WebService(serviceName = "RRHHWS")
public class RRHHWS {
    
    private CargoDAO daoCargo = new CargoMySQL();
    private ColaboradorDAO daoColaborador = new ColaboradorMySQL();
    private SalarioDAO daoSalario = new SalarioMySQL();
    private BeneficioDAO daoBeneficio = new BeneficioMySQL();
    private BeneficioxColaboradorDAO daoBenxColab = new BeneficioxColaboradorMySQL();
    private EventoDAO daoEvento = new EventoMySQL();
    private ColaboradorxEventoDAO daoColabXEvento = new ColaboradorxEventoMySQL();
    private AsistenciaColaboradorDAO daoAsistenciaxColab = new AsistenciaColaboradorMySQL();
    private PuestoTrabajoDAO daoPuestoTrabajo = new PuestoTrabajoMySQL();
    private CandidatoDAO daoCandidato = new CandidatoMySQL();
    private EstadoCandidatoDAO daoEstadoCandidato = new EstadoCandidatoMySQL();
    private TrazabilidadCandidatoDAO daoTrazabilidad = new TrazabilidadCandidatoMySQL();
    
    @WebMethod(operationName = "listarTodosCargos")
    public ArrayList<Cargo> listarTodosCargos() {
        ArrayList<Cargo> cargos = new ArrayList<>();
        try{
            cargos = daoCargo.listarCargos();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return cargos;
    }
    
    
    @WebMethod(operationName = "insertarColaborador")
    public int insertarColaborador(@WebParam(name = "colaborador")
            Colaborador colaborador){
        int resultado = 0;
        try{
            resultado = daoColaborador.insertar(colaborador);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "listarColaboradoresTodos")
    public ArrayList<Colaborador> listarColaboradoresTodos(){
        ArrayList<Colaborador> colaboradores = new ArrayList<>();
        try{
            colaboradores = daoColaborador.listar();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return colaboradores;
    }
    
    @WebMethod(operationName = "listarColaboradoresPorDNINombre")
    public ArrayList<Colaborador> 
        listarEmpleadosPorDNINombre(@WebParam(name = "DNInombre")
            String DNINombre){
        ArrayList<Colaborador> colaboradores = new ArrayList<>();
        try{
            colaboradores = daoColaborador.listarxnombredni(DNINombre);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return colaboradores;
    }
        
    @WebMethod(operationName = "insertarSalario")
    public int insertarSalario(@WebParam(name = "salario")
            Salario salario){
        int resultado = 0;
        try{
            resultado = daoSalario.insertar(salario);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
        
    @WebMethod(operationName = "listarBeneficiosTodos")
    public ArrayList<Beneficio> listarBeneficiosTodos(){
        ArrayList<Beneficio> beneficios = new ArrayList<>();
        try{
            beneficios = daoBeneficio.listar();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return beneficios;
    } 
    
    @WebMethod(operationName = "insertarBeneficioxColaborador")
    public int insertarBeneficioxColaborador(@WebParam(name = "benxcolab")
            BeneficioxColaborador benxcolab){
        int resultado = 0;
        try{
            resultado = daoBenxColab.insertar(benxcolab);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "listarBeneficiosPorIdColaborador")
    public ArrayList<BeneficioxColaborador> 
        listarBeneficiosPorIdColaborador(@WebParam(name = "idColab")
            int idColab){
        ArrayList<BeneficioxColaborador> beneficios = new ArrayList<>();
        try{
            beneficios = daoBenxColab.listarxidcolab(idColab);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return beneficios;
    }
        
    @WebMethod(operationName = "getSalarioPorIdColaborador")
    public Salario getSalarioPorIdColaborador(@WebParam(name = "idColab")
            int idColab){
        Salario salario = new Salario();
        try{
            salario = daoSalario.listarxidcolab(idColab);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return salario;
    }
    
    @WebMethod(operationName = "listarColaboradoresPorIdCargo")
    public ArrayList<Colaborador> 
        listarColaboradoresPorIdCargo(@WebParam(name = "idCargo")
            int idCargo){
        ArrayList<Colaborador> colaboradores = new ArrayList<>();
        try{
            colaboradores = daoColaborador.listarxidcargo(idCargo);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return colaboradores;
    }
    
    @WebMethod(operationName = "actualizarColaborador")
    public int actualizarColaborador(@WebParam(name = "colaborador")
            Colaborador colaborador){
        int resultado = 0;
        try{
            resultado = daoColaborador.modificar(colaborador);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "eliminarSalario")
    public int eliminarSalario(@WebParam(name = "idSalario")
            int idSalario){
        int resultado = 0;
        try{
            resultado = daoSalario.eliminar(idSalario);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "eliminarBeneficioXColaborador")
    public int eliminarBeneficioXColaborador(@WebParam(name = "idBenxcolab")
            int idBenxcolab){
        int resultado = 0;
        try{
            resultado = daoBenxColab.eliminar(idBenxcolab);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "eliminarColaborador")
    public int eliminarColaborador(@WebParam(name = "idColaborador")
            int idColaborador){
        int resultado = 0;
        try{
            resultado = daoColaborador.eliminar(idColaborador);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "insertarEvento")
    public int insertarEvento(@WebParam(name = "evento")
            Evento evento){
        int resultado = 0;
        try{
            resultado = daoEvento.insertar(evento);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "listarEventosTodos")
    public ArrayList<Evento> listarEventosTodos(){
        ArrayList<Evento> eventos = new ArrayList<>();
        try{
            eventos = daoEvento.listar();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return eventos;
    }
    
    @WebMethod(operationName = "insertarColaboradorXEvento")
    public int insertarColaboradorXEvento(@WebParam(name = "colabxevento")
            ColaboradorxEvento colabxevento){
        int resultado = 0;
        try{
            resultado = daoColabXEvento.insertar(colabxevento);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "listarColaboradoresPorDNIDesc")
    public ArrayList<Colaborador> listarColaboradoresPorDNIDesc(){
        ArrayList<Colaborador> colaboradores = new ArrayList<>();
        try{
            colaboradores = daoColaborador.listarxdnidesc();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return colaboradores;
    }
    
    @WebMethod(operationName = "listarColaboradoresPorApellidoDesc")
    public ArrayList<Colaborador> listarColaboradoresPorApellidoDesc(){
        ArrayList<Colaborador> colaboradores = new ArrayList<>();
        try{
            colaboradores = daoColaborador.listarxapellidodesc();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return colaboradores;
    }
    
    @WebMethod(operationName = "listarColaboradoresPorIdEvento")
    public ArrayList<ColaboradorxEvento> 
        listarColaboradoresPorIdEvento(@WebParam(name = "idEvento")
            int idEvento){
        ArrayList<ColaboradorxEvento> colaboradores = new ArrayList<>();
        try{
            colaboradores = daoColabXEvento.listarxidEvento(idEvento);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return colaboradores;
    }
      
    @WebMethod(operationName = "actualizarEvento")
    public int actualizarEvento(@WebParam(name = "evento")
            Evento evento){
        int resultado = 0;
        try{
            resultado = daoEvento.modificar(evento);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "eliminarColaboradorXEvento")
    public int eliminarColaboradorXEvento(@WebParam(name = "idColabxEvento")
            int idColabxEvento){
        int resultado = 0;
        try{
            resultado = daoColabXEvento.eliminar(idColabxEvento);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "listarEventosPorNombre")
    public ArrayList<Evento> listarEventosPorNombre(@WebParam(name = "nombre")
        String nombre){
        ArrayList<Evento> eventos = new ArrayList<>();
        try{
            eventos = daoEvento.listarxnombre(nombre);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return eventos;
    }
    
    @WebMethod(operationName = "listarEventosPorFecha")
    public ArrayList<Evento> listarEventosPorFecha(@WebParam(name = "fechaInicio")
        Date fechaInicio,@WebParam(name = "fechaFin") Date fechaFin){
        ArrayList<Evento> eventos = new ArrayList<>();
        try{
            eventos = daoEvento.listarxfecha(fechaInicio,fechaFin);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return eventos;
    }
    
    @WebMethod(operationName = "insertarAsistenciaColaborador")
    public int insertarAsistenciaColaborador(@WebParam(name = "asistencia")
            AsistenciaColaborador asistencia){
        int resultado = 0;
        try{
            resultado = daoAsistenciaxColab.insertar(asistencia);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "actualizarAsistencia")
    public int actualizarAsistencia(@WebParam(name = "asistencia")
            AsistenciaColaborador asistencia){
        int resultado = 0;
        try{
            resultado = daoAsistenciaxColab.modificar(asistencia);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "listarAsistenciaPorColaborador")
    public AsistenciaColaborador listarAsistenciaPorColaborador(@WebParam(name = "colaborador")
        int idColab){
        AsistenciaColaborador asist = null;
        try{
            asist = daoAsistenciaxColab.listarxidColaborador(idColab);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return asist;
    }
    
    @WebMethod(operationName = "listarAsistencias")
    public ArrayList<AsistenciaColaborador> listarAsistencias(){
        ArrayList<AsistenciaColaborador> asistencias = new ArrayList<>();
        try{
            asistencias = daoAsistenciaxColab.listarAsistenciaColaborador();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return asistencias;
    }
    
    @WebMethod(operationName = "eliminarEvento")
    public int eliminarEvento(@WebParam(name = "idEvento")
            int idEvento){
        int resultado = 0;
        try{
            resultado = daoEvento.eliminar(idEvento);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "insertarPuestoTrabajo")
    public int insertarPuestoTrabajo(@WebParam(name = "puesto")
            PuestoTrabajo puesto){
        int resultado = 0;
        try{
            resultado = daoPuestoTrabajo.insertar(puesto);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "listarPuestos")
    public ArrayList<PuestoTrabajo> listarPuestos(){
        ArrayList<PuestoTrabajo> puestos = new ArrayList<>();
        try{
            puestos = daoPuestoTrabajo.listar();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return puestos;
    }
    
    @WebMethod(operationName = "listarPuestosPorNombre")
    public ArrayList<PuestoTrabajo> listarPuestosNombre(@WebParam(name = "nombre")
        String nombre){
        ArrayList<PuestoTrabajo> puestos = new ArrayList<>();
        try{
            puestos = daoPuestoTrabajo.listarPorNombre(nombre);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return puestos;
    }
    
    @WebMethod(operationName = "insertarCandidato")
    public int insertarCandidato(@WebParam(name = "candidato")
            Candidato candidato){
        int resultado = 0;
        try{
            resultado = daoCandidato.insertar(candidato);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "listarEstadosCandidato")
    public ArrayList<EstadoCandidato> listarEstadosCandidato(){
        ArrayList<EstadoCandidato> estados = new ArrayList<>();
        try{
            estados = daoEstadoCandidato.listar();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return estados;
    }
    
    @WebMethod(operationName = "insertarTrazabilidadCandidato")
    public int insertarTrazabilidadCandidato(@WebParam(name = "traza")
            TrazabilidadCandidato traza){
        int resultado = 0;
        try{
            resultado = daoTrazabilidad.insertar(traza);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "listarTrazaActualIdCandidato")
    public TrazabilidadCandidato listarTrazaActualIdCandidato(@WebParam(name = "idCand")
        int idCand){
        TrazabilidadCandidato traza = null;
        try{
            traza = daoTrazabilidad.listarTrazabilidadActualIdCandidato(idCand);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return traza;
    }
    
    @WebMethod(operationName = "actualizarCandidato")
    public int actualizarCandidato(@WebParam(name = "candidato")
            Candidato candidato){
        int resultado = 0;
        try{
            resultado = daoCandidato.modificar(candidato);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "listarTrazaXIdCandidato")
    public ArrayList<TrazabilidadCandidato> listarTrazaXIdCandidato(@WebParam(name = "idCand")
        int idCand){
        ArrayList<TrazabilidadCandidato> trazas = new ArrayList<>();
        try{
            trazas = daoTrazabilidad.listarTrazabilidadXIdCandidato(idCand);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return trazas;
    }
    
    @WebMethod(operationName = "listarCandidatosXidPuesto")
    public ArrayList<Candidato> listarCandidatosXidPuesto(@WebParam(name = "idPuesto")
        int idPuesto){
        ArrayList<Candidato> candidatos = new ArrayList<>();
        try{
            candidatos = daoCandidato.listarCandidatosXidPuesto(idPuesto);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return candidatos;
    }
    
    @WebMethod(operationName = "listarCandidatosXnombreDNIidPuesto")
    public ArrayList<Candidato> listarCandidatosXnombreDNIidPuesto(
            @WebParam(name = "nombre") String nombre,
            @WebParam(name = "idPuesto") int idPuesto){
        ArrayList<Candidato> candidatos = new ArrayList<>();
        try{
            candidatos = daoCandidato.listarCandidatosXnombreDNIidPuesto(nombre,idPuesto);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return candidatos;
    }
    
    @WebMethod(operationName = "listarPuestosPorFechaPublicacion")
    public ArrayList<PuestoTrabajo> listarPuestosPorFechaPublicacion(@WebParam(name = "fechaInicio")
        Date fechaInicio,@WebParam(name = "fechaFin") Date fechaFin){
        ArrayList<PuestoTrabajo> puestos = new ArrayList<>();
        try{
            puestos = daoPuestoTrabajo.listarPorFechaPublicacion(fechaInicio,fechaFin);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return puestos;
    }
    
    @WebMethod(operationName = "listarPuestosPorFechaLimite")
    public ArrayList<PuestoTrabajo> listarPuestosPorFechaLimite(@WebParam(name = "fechaInicio")
        Date fechaInicio,@WebParam(name = "fechaFin") Date fechaFin){
        ArrayList<PuestoTrabajo> puestos = new ArrayList<>();
        try{
            puestos = daoPuestoTrabajo.listarPorFechaLimite(fechaInicio,fechaFin);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return puestos;
    }
    
    @WebMethod(operationName = "eliminarPuesto")
    public int eliminarPuesto(@WebParam(name = "idPuesto")
            int idPuesto){
        int resultado = 0;
        try{
            resultado = daoPuestoTrabajo.eliminar(idPuesto);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "actualizarPuestoTrabajo")
    public int actualizarPuestoTrabajo(@WebParam(name = "puesto")
            PuestoTrabajo puesto){
        int resultado = 0;
        try{
            resultado = daoPuestoTrabajo.modificar(puesto);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "verificarCuenta")
    public Colaborador 
        verificarCuenta(@WebParam(name = "usuario")
            String usuario,@WebParam(name = "contrasenha")
            String contrasenha){
        Colaborador colaborador = new Colaborador();
        try{
            colaborador = daoColaborador.verificarCuenta(usuario,contrasenha);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return colaborador;
    }
}
