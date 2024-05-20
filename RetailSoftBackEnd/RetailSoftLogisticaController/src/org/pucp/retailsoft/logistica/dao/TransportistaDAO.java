/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package org.pucp.retailsoft.logistica.dao;

import java.util.ArrayList;
import org.pucp.retailsoft.logistica.model.Transportista;

/**
 *
 * @author Dell
 */
public interface TransportistaDAO {
    int insertar(Transportista transportista);
    int modificar(Transportista transportista);
    int eliminar(int idTransportista);
    ArrayList<Transportista> listarTransportistas();
}
