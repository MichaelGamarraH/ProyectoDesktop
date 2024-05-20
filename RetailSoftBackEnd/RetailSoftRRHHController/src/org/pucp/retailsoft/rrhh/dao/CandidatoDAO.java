package org.pucp.retailsoft.rrhh.dao;

import java.util.ArrayList;
import org.pucp.retailsoft.rrhh.model.Candidato;

public interface CandidatoDAO {
   int insertar(Candidato candidato);
   int modificar(Candidato candidato);
   int eliminar(int idCandidato);
   ArrayList<Candidato> listarCandidatos();
   ArrayList<Candidato> listarCandidatosXidPuesto(int idPuesto);
   ArrayList<Candidato> listarCandidatosXnombreDNIidPuesto(String nombreDNI,int idPuesto);
}

