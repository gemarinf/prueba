using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;


/// <summary>
/// Descripción breve de clsentrenador
/// </summary>
public class clsentrenador: clsconexion
{
    string tabla = "entrenador"; //nombre de la tabla
    protected string nombre, direccion, telefono;
    protected int identificacion;
    public clsentrenador(int identificacion, string nombre, string direccion, string telefono)
    {
        this.identificacion = identificacion;
        this.nombre = nombre;
        this.direccion = direccion;
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
        fila["identificacion"] = Identificacion;
        fila["nombre"] = Nombre;
        fila["direccion"] = Direccion;
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
                Direccion = fila["direccion"].ToString();
                Telefono = fila["telefono"].ToString();
                return true;
            }
        }
        return false;
    }

}
