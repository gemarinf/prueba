using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Descripción breve de clsadministrador
/// </summary>
public class clsadministrador : clsconexion
{
    string tabla = "Administrador"; //nombre de la tabla
    protected string nombre, telefono;
    protected int identificacion;
    public clsadministrador(int identificacion, string nombre, string telefono)
    {
        this.identificacion = identificacion;
        this.nombre = nombre;
        this.telefono = telefono;
    }
    //metodos para establecer y recuperar datos
    public int Identificacion
    {
        set { identificacion = value; }
        get { return identificacion; }
    }
    public String Nombre
    {
        set { nombre = value; }
        get { return nombre; }
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
        fila["identificacion"] = Identificacion;
        fila["nombre"] = Nombre;
        fila["telefono"] = Telefono;

        Data.Tables[tabla].Rows.Add(fila);
        AdaptadorDatos.Update(Data, tabla);
    }

    public bool eliminar(int valor)
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];

            if (int.Parse(fila["identificacion"].ToString()) == valor)
            {
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
            if (int.Parse(fila["identificacion"].ToString()) == valor)
            {
                Identificacion = int.Parse(fila["identificacion"].ToString());
                Nombre = fila["nombre"].ToString();
                Telefono = fila["telefono"].ToString();
                return true;
            }
        }
        return false;
    }

}
