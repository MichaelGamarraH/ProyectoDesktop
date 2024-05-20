package org.pucp.retailsoft.services;

import java.awt.Image;
import java.sql.Connection;
import java.util.Date;
import java.util.HashMap;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import javax.swing.ImageIcon;
import net.sf.jasperreports.engine.JasperExportManager;
import net.sf.jasperreports.engine.JasperFillManager;
import net.sf.jasperreports.engine.JasperPrint;
import net.sf.jasperreports.engine.JasperReport;
import net.sf.jasperreports.engine.util.JRLoader;
import org.pucp.retailsoft.config.DBManager;
import org.pucp.retailsoft.servlet.ReporteProveedores;

@WebService(serviceName = "ReporteWS")
public class ReporteWS {
    
    @WebMethod(operationName = "generarReporteProveedores")
    public byte[] generarReporteProveedores(@WebParam(name = "fechaInicio") Date fechaInicio,
            @WebParam(name = "fechaFin") Date fechaFin){
        byte[] archivoPDF = null;
        try{
            Connection con = DBManager.getInstance().getConnection();
            JasperReport jr = (JasperReport) JRLoader.loadObject(
              ReporteProveedores.class.getResource("/org/pucp/retailsoft/reportes/ReporteProveedores.jasper"));
            
            String rutaImagen = ReporteProveedores.class.getResource("/org/pucp/retailsoft/img/logoRIG.png").getPath();
            Image img = (new ImageIcon(rutaImagen)).getImage();
            String rutaSubreporte = ReporteProveedores.class.getResource(
                        "/org/pucp/retailsoft/reportes/SubreporteLotes.jasper").getPath();
            String rutaSubreporteGrafico = ReporteProveedores.class.getResource(
                        "/org/pucp/retailsoft/reportes/SubreporteGrafico.jasper").getPath();
            
            HashMap hm = new HashMap();
            hm.put("logo",img);
            hm.put("rutaSubreporte",rutaSubreporte);
            hm.put("rutaSubreporteGrafico",rutaSubreporteGrafico);
            hm.put("fechaInicio", fechaInicio);
            hm.put("fechaFin", fechaFin);
            JasperPrint jp = JasperFillManager.fillReport(jr, hm, con);
            con.close();
            archivoPDF = JasperExportManager.exportReportToPdf(jp);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return archivoPDF;
    }
    
}
