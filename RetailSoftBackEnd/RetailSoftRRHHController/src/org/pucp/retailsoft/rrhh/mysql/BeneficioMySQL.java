/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package org.pucp.retailsoft.rrhh.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.util.ArrayList;
import org.pucp.retailsoft.config.DBManager;
import org.pucp.retailsoft.rrhh.dao.BeneficioDAO;
import org.pucp.retailsoft.rrhh.model.Beneficio;

/**
 *
 * @author JOHAN
 */
public class BeneficioMySQL implements BeneficioDAO{
    private Connection con;
    private ResultSet rs;
    private CallableStatement cs;
    @Override
    public ArrayList<Beneficio> listar() {
        ArrayList<Beneficio> beneficios = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_BENEFICIOS()}");
            rs = cs.executeQuery();
            while(rs.next()){
                Beneficio beneficio = new Beneficio();
                beneficio.setIdBeneficio(rs.getInt("id_beneficio"));
                beneficio.setNombre(rs.getString("nombre"));
                beneficio.setDescripcion(rs.getString("descripcion"));
                beneficio.setMonto(rs.getDouble("monto"));
                beneficio.setActivo(true);
                beneficios.add(beneficio);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return beneficios;
    }
    
}
