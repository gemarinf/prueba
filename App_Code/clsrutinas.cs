using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Descripción breve de clsrutinas
/// </summary>
public class clsrutinas: clsconexion
{
    string tabla = "rutinas"; //nombre de la tabla
    protected string ejercicio, finalidad, fecha;
    protected int   cantidad, repeticion, cedula ;
    public clsrutinas(int cedula, int cantidad,int repeticion,  string finalidad, string ejercicio, string cliente, string fecha)
    {
        this.cedula = cedula;
        this.ejercicio = ejercicio;
        this.cantidad = cantidad;
        this.repeticion = repeticion;
        this.finalidad = finalidad;
        this.fecha = fecha;

    }
    //metodos para establecer y recuperar datos
    public string Ejercicio
    {
        set { ejercicio = value; }
        get { return ejercicio; }
    }
    public int Cantidad
    {
        set { cantidad = value; }
        get { return cantidad; }
    }
    public int Repeticion
    {
        set { repeticion = value; }
        get { return repeticion; }
    }
    public String Finalidad
    {
        set { finalidad = value; }
        get { return finalidad; }
    }
    public int Cedula
    {
        set { cedula = value; }
        get { return cedula; }
    }
    public String Fecha
    {
        set { fecha = value; }
        get { return fecha; }
    }
    //metodo agregar registro cliente
    public void agregar()
    {
        conectar(tabla);
        DataRow fila;
        fila = Data.Tables[tabla].NewRow();
        fila["ejercicio"] = Ejercicio;
        fila["cantidad"] = Cantidad;
        fila["repeticion"] = Repeticion;
        fila["finalidad"] = Finalidad;
        fila["cedula"] = Cedula;
        fila["fecha"] = fecha;


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

            if (int.Parse(fila["cedula"].ToString()) == valor)
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
            if (int.Parse(fila["cedula"].ToString()) == valor)
            {
                Cedula = int.Parse(fila["cedula"].ToString());
                Ejercicio = fila["ejercicio"].ToString();
                Cantidad = int.Parse(fila["cantidad"].ToString());
                Repeticion = int.Parse(fila["repeticion"].ToString());
                Finalidad = fila["finalidad"].ToString();
                Fecha = fila["fecha"].ToString();

                return true;
            }
        }
        return false;
    }

}
