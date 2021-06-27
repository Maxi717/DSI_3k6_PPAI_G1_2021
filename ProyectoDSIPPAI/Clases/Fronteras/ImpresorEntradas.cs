using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Reporting.WinForms;
using ProyectoDSIPPAI.Clases.Entidades;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace ProyectoDSIPPAI.Clases.Fronteras
{
    class ImpresorEntradas
    {
        public void imprimir(Entrada entrada)
        {
            Microsoft.Reporting.WinForms.ReportViewer viewer = new Microsoft.Reporting.WinForms.ReportViewer();
            LocalReport reporteEntrada = new LocalReport();
            viewer.LocalReport.ReportEmbeddedResource = "pruebaImpresora.Clases.Fronteras.Entrada.rdlc";
            DataTable datosEntrada = new DataTable();
            datosEntrada.Columns.Add("fechaVenta");
            datosEntrada.Columns.Add("horaVenta");
            datosEntrada.Columns.Add("numero");
            datosEntrada.Columns.Add("monto");
            datosEntrada.Columns.Add("nombreTipoEntrada");
            datosEntrada.Columns.Add("nombreTipoVisita");
            datosEntrada.Columns.Add("nombreSede");
            DataRow datosEntradaImprimir = datosEntrada.NewRow();
            datosEntradaImprimir["fechaVenta"] = "Fecha: " + entrada.GetFechaVenta.Date.ToString("d");
            datosEntradaImprimir["horaVenta"] = "Hora: " + entrada.GetHoraVenta.ToString().Remove(5);
            datosEntradaImprimir["numero"] = "N°: " + entrada.GetNumero.ToString();
            datosEntradaImprimir["monto"] = "Precio: $" + entrada.GetMonto.ToString();
            datosEntradaImprimir["nombreTipoEntrada"] = entrada.GetTarifa.ConocerTipoEntrada().ToString();
            datosEntradaImprimir["nombreTipoVisita"] = entrada.GetTarifa.ConocerTipoVisita().ToString();
            datosEntradaImprimir["nombreSede"] = entrada.GetSede.Nombre.ToString();
            datosEntrada.Rows.Add(datosEntradaImprimir);

            ReportDataSource ds = new ReportDataSource("dataSetEntrada", datosEntrada);
            viewer.LocalReport.DataSources.Clear();
            viewer.LocalReport.DataSources.Add(ds);
            viewer.LocalReport.Refresh();
            var x = viewer.LocalReport.ListRenderingExtensions();
            byte[] viewerPDF = viewer.LocalReport.Render("PDF");
            //viewer.ExportDialog(x[3]);
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.FileName = "entrada" + entrada.GetNumero.ToString() + ".pdf";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                FileStream newFile = new FileStream(dialog.FileName, FileMode.Create);
                newFile.Write(viewerPDF, 0, viewerPDF.Length);
                newFile.Close();
            }

        }
    }
}
