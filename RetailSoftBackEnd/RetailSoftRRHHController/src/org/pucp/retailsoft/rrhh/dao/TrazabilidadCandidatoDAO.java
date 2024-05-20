package org.pucp.retailsoft.rrhh.dao;

import java.util.ArrayList;
import org.pucp.retailsoft.rrhh.model.TrazabilidadCandidato;

public interface TrazabilidadCandidatoDAO {
    int insertar(TrazabilidadCandidato traza);
    public TrazabilidadCandidato listarTrazabilidadActualIdCandidato(int idCand);
    public ArrayList<TrazabilidadCandidato> listarTrazabilidadXIdCandidato(int idCand);
}
