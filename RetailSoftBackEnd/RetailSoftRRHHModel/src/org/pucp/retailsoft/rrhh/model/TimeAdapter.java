/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package org.pucp.retailsoft.rrhh.model;

import java.sql.Time;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import javax.xml.bind.annotation.adapters.XmlAdapter;

/**
 *
 * @author JOHAN
 */
public class TimeAdapter extends XmlAdapter<String, Time> {

    @Override
    public Time unmarshal(String v) throws Exception {
        ArrayList<SimpleDateFormat> patrones = new ArrayList<>();
        patrones.add(new SimpleDateFormat("HH:mm:ss"));
        patrones.add(new SimpleDateFormat("HH:mm"));
        patrones.add(new SimpleDateFormat("H:mm:ss"));
        patrones.add(new SimpleDateFormat("mm:ss"));
        patrones.add(new SimpleDateFormat("m:ss"));
        patrones.add(new SimpleDateFormat("ss"));
        patrones.add(new SimpleDateFormat("s"));
        for(SimpleDateFormat sdf : patrones){
            try{
                long ms = sdf.parse(v).getTime();
                Time t = (new Time(ms));
                return t;
            }catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return null;
    }

    @Override
    public String marshal(Time v) throws Exception {
        return v.toString();
    }
    
}
