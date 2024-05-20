package org.pucp.retailsoft.rrhh.dao;

import java.util.ArrayList;
import java.util.Date;
import org.pucp.retailsoft.rrhh.model.Evento;

public interface EventoDAO {
   int insertar(Evento evento);
   int modificar(Evento evento);
   int eliminar(int idEvento);
   ArrayList<Evento> listar();
   ArrayList<Evento> listarxnombre(String nombre);
   ArrayList<Evento> listarxfecha(Date fechaInicio, Date fechaFin);
}
