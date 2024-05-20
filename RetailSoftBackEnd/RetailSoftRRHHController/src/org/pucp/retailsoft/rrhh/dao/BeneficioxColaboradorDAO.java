package org.pucp.retailsoft.rrhh.dao;

import java.util.ArrayList;
import org.pucp.retailsoft.rrhh.model.BeneficioxColaborador;

/**
 *
 * @author JOHAN
 */
public interface BeneficioxColaboradorDAO {
    int insertar(BeneficioxColaborador benxcolab);
    int eliminar(int idBenxcolab);
    ArrayList<BeneficioxColaborador> listarxidcolab(int idColab);
}
