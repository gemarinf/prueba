using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Clase cliente
/// </summary>
public class clscliente : clsconexion
{
    string tabla = "cliente"; //nombre de la tabla
    protected string nombre, apellidos, direccion, telefono;
    protected int idcliente;
    public clscliente(int idcliente, string nombre,string apellidos, string direccion, string telefono)
    {
        this.idcliente = idcliente;
        this.nombre = nombre;
        this.apellidos = apellidos;
        this.direccion = direccion;
        this.telefono = telefono;
    }
    //metodos para establecer y recuperar datos
    public int Idcliente
    {
        set { idcliente = value; }
        get { return idcliente; }
    }
    public String Nombre
    {
        set { nombre = value; }
        get { return nombre; }
    }
    public String Apellidos
    {
        set { apellidos = value; }
        get { return apellidos; }
    }
    public String Direccion
    {
        set { direccion = value; }
        get { return direccion; }
    }
    public string Telefono
    {
        set { telefono = value; }
        get { return telefono; }
    }

    //metodo agregar registro cliente
    public void agregar()
    {
        conectar(tabla);
        DataRow fila;
        fila = Data.Tables[tabla].NewRow();
        fila["idcliente"] = Idcliente;
        fila["nombre"] = Nombre;
        fila["apellidos"] = Apellidos;
        fila["direccion"] = Direccion;
        fila["telefono"] = Telefono;

        Data.Tables[tabla].Rows.Add(fila);
        AdaptadorDatos.Update(Data, tabla);
    }

    public bool eliminar(int valor) {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];

            if (int.Parse(fila["idcliente"].ToString()) == valor){
                fila = Data.Tables[tabla].Rows[i];
                fila.Delete();
                DataTable tablaborrados;
                tablaborrados = Data.Tables[tabla].GetChanges(DataRowState.Deleted);
                AdaptadorDatos.Update(tablaborrados);
                Data.Tables[tabla].AcceptChanges();
                return true;
            }
        }
        return false;
     }

     public bool existe(int valor)
     {
     conectar(tabla);
       DataRow fila;
      int x = Data.Tables[tabla].Rows.Count - 1;
           for (int i = 0; i <= x; i++)
     {
              fila = Data.Tables[tabla].Rows[i];
               if (int.Parse(fila["idcliente"].ToString()) == valor)
               {
                Idcliente = int.Parse(fila["idcliente"].ToString());
               Nombre = fila["nombre"].ToString();
                Apellidos = fila["apellidos"].ToString();
                Direccion = fila["direccion"].ToString();
            Telefono = fila["telefono"].ToString();
            return true;
        }
           }
    return false;
     }
   
}
   