package org.pucp.retailsoft.logistica.dao;

import java.util.ArrayList;
import org.pucp.retailsoft.logistica.model.LotexCriterioControlCalidad;

public interface LotexCriterioControlCalidadDAO {
    ArrayList<LotexCriterioControlCalidad> listarLotexCriterioControlCalidad(int idLote);
}
