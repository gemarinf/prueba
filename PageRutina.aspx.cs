using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PageClientes : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnagregar_Click(object sender, EventArgs e)
    {
        try
        {
            clsrutinas clte = new clsrutinas(0,0, 0,"","","","");
            clte.Cedula = int.Parse(txtcedula.Text.Trim());
            clte.Ejercicio = txtejercicio.Text;
            clte.Cantidad = int.Parse(txtcantidad.Text.Trim());
            clte.Repeticion = int.Parse(txtrepeticion.Text.Trim());
            clte.Finalidad = txtfinalidad.Text;
            clte.Fecha = txtfecha.Text;
            clte.agregar();
            lblestado.Text = "Registro Agregado con exito";
            txtcedula.Text = "";
            txtejercicio.Text = "";
            txtcantidad.Text = "";
            txtrepeticion.Text = "";
            txtfinalidad.Text = "";
            txtfecha.Text = "";
        }
        catch
        {
            lblestado.Text = "Se ha generado una excepción";
        }
    }

    protected void btneliminar_Click(object sender, EventArgs e)
    {
        clsrutinas clte = new clsrutinas(0,0, 0, "", "", "","");
        if (clte.eliminar(int.Parse(txtcedula.Text)))
        {
            lblestado.Text = "El registro se eliminó con exito";
            txtcedula.Text = "";
            txtejercicio.Text = "";
            txtcantidad.Text = "";
            txtrepeticion.Text = "";
            txtfinalidad.Text = "";
            txtfecha.Text = "";
        }
        else { lblestado.Text = "El registro No se eliminó"; }
    }
    protected void btnbuscar_Click(object sender, EventArgs e)
    {
        clsrutinas clte = new clsrutinas(0, 0,0, "", "", "","");
        if (clte.existe(int.Parse(txtcedula.Text)))
        {
            txtcedula.Text = clte.Cedula.ToString();
            txtrepeticion.Text = clte.Repeticion.ToString();
            txtejercicio.Text = clte.Ejercicio;
            txtcantidad.Text = clte.Cantidad.ToString();
            txtfinalidad.Text = clte.Finalidad;
            txtfecha.Text = clte.Fecha;
            lblestado.Text = "Registro encontrado";
        }
        else
        {
            lblestado.Text = "Registro no Encontrado";
        }
    }

    protected void DropCedula_SelectedIndexChanged(object sender, EventArgs e)
    {
        clsrutinas clte = new clsrutinas(0,0,0, "", "", "", "");
        if (clte.existe(int.Parse(DropCedula.SelectedValue)))
        {
            txtcedula.Text = clte.Cedula.ToString();
            txtejercicio.Text = clte.Ejercicio;
            txtrepeticion.Text = clte.Repeticion.ToString();
            txtcantidad.Text = clte.Cantidad.ToString();
            txtfinalidad.Text = clte.Finalidad;
            txtfecha.Text = clte.Fecha;
            lblestado.Text = "Registro encontrado";
        }
        else
        {
            lblestado.Text = "Registro no Encontrado";
        }
    }
}


