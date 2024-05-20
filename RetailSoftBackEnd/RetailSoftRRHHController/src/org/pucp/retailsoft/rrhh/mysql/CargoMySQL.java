package org.pucp.retailsoft.rrhh.mysql;
import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.util.ArrayList;
import org.pucp.retailsoft.config.DBManager;
import org.pucp.retailsoft.rrhh.dao.CargoDAO;
import org.pucp.retailsoft.rrhh.model.Cargo;

public class CargoMySQL implements CargoDAO {
    private Connection con;
    private ResultSet rs;
    private CallableStatement cs;
    
    @Override
    public int insertar(Cargo cargo) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call INSERTAR_CARGO(?,?) }");
            cs.registerOutParameter("id_cargo", 
            java.sql.Types.INTEGER);
            cs.setString("tipo_cargo", cargo.getTipoCargo());
            resultado = cs.executeUpdate();
            cargo.setIdCargo(cs.getInt("id_cargo"));
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex)
            {System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int modificar(Cargo cargo) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call MODIFICAR_CARGO(?,?)}");
            cs.setInt("id_cargo", cargo.getIdCargo());
            cs.setString("tipo_cargo", cargo.getTipoCargo());
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
    public int eliminar(int idCargo) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("call ELIMINAR_CARGO(?)");
            cs.setInt("id_cargo", idCargo);
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
    public ArrayList<Cargo> listarCargos() {
        ArrayList<Cargo> cargos = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_CARGOS()}");
            rs = cs.executeQuery();
            while(rs.next()){
                Cargo cargo = new Cargo();
                cargo.setIdCargo(rs.getInt("id_cargo"));
                cargo.setTipoCargo(rs.getString("tipo_cargo"));
                cargo.setActivo(true);
                cargos.add(cargo);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return cargos;
    }
    
}
