﻿
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SistemaClubDeportivo
{

    public class Conexion
  {
       private string baseDatos;
       private string servidor;
       private string puerto;
       private string usuario;
       private string clave;
       public static Conexion? con = null;

     private Conexion()
   {
      this.baseDatos = "ClubDeportivo";
      this.servidor = "LocalHost";
      this.puerto = "3306";
      this.usuario = "root";
      this.clave = "";
   }

    public MySqlConnection CrearConexion()
   { 
      MySqlConnection? cadena = new MySqlConnection();
    try
    {
    
         cadena.ConnectionString = "datasource=" + this.servidor + 
                                   ";port=" + this.puerto +
                                   ";username=" + this.usuario +
                                   ";password=" + this.clave +
                                   ";Database=" + this.baseDatos;
                    
    
    }
    catch (Exception ex)
    {
      cadena=null;
      throw;
    }
    return cadena;
    }
  public static Conexion getInstancia()
  {
     if(con==null)
     {
        con = new Conexion();
     }
     return con;
   }
 }
}

