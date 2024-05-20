/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/WebServices/WebService.java to edit this template
 */
package org.pucp.retailsoft.services;

import java.util.ArrayList;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import org.pucp.retailsoft.ventas.dao.LineaVentaDAO;
import org.pucp.retailsoft.ventas.dao.VentaDAO;
import org.pucp.retailsoft.ventas.model.LineaVenta;
import org.pucp.retailsoft.ventas.model.Venta;
import org.pucp.retailsoft.ventas.mysql.LineaVentaMySQL;
import org.pucp.retailsoft.ventas.mysql.VentaMySQL;
/**
 *
 * @author ABerrocalS
 */
@WebService(serviceName = "VentasWS")
public class VentasWS {
    private VentaDAO daoVenta = new VentaMySQL();
    private LineaVentaDAO daoLineaVenta = new LineaVentaMySQL();
    
    @WebMethod(operationName = "insertarVenta")
    public int insertarVenta(@WebParam(name = "venta") 
            Venta venta){
        int resultado = 0;
        try{
            resultado = daoVenta.insertar(venta);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "listarVentasXIdDNICliente")
    public ArrayList<Venta> listarVentasXIdDNICliente(@WebParam(name = "idDNICliente")String idDNICliente) {
        ArrayList<Venta> ventas = new ArrayList<>();
        try{
            ventas = daoVenta.listarPorIdDNICliente(idDNICliente);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return ventas;
    }
    
        @WebMethod(operationName = "listarVentasXIdVenta")
    public ArrayList<LineaVenta> listarVentasXIdVenta(@WebParam(name = "idVenta")String idVenta) {
        ArrayList<LineaVenta> ventas = new ArrayList<>();
        try{
            ventas = daoLineaVenta.listarPorIdVenta(idVenta);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return ventas;
    }
    
            
            
    
}
