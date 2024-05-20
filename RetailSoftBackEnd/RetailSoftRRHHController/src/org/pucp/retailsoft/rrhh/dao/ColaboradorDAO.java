package org.pucp.retailsoft.rrhh.dao;

import java.util.ArrayList;
import org.pucp.retailsoft.rrhh.model.Colaborador;

public interface ColaboradorDAO {
   int insertar(Colaborador colaborador);
   int modificar(Colaborador colaborador);
   int eliminar(int idColaborador);
   ArrayList<Colaborador> listar(); 
   ArrayList<Colaborador> listarxnombredni(String nombreDNI);
   ArrayList<Colaborador> listarxidcargo(int idCargo);
   ArrayList<Colaborador> listarxdnidesc();
   ArrayList<Colaborador> listarxapellidodesc();
   Colaborador verificarCuenta(String usuario, String contrasenha);
}

