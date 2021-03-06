﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using M77;

namespace ControlDeReparacion
{
    class libOrigen
    {
        public DataGridView grid;
        public TextBox txt;

        public void load()
        {
            grid.Rows.Clear();

            Mysql sql = new Mysql();
            DataTable dt = sql.Select(@"Select id,origen from origen where id_sector = '" + Operador.sector_id + "' order by origen");
            if (sql.rows)
            {
                foreach (DataRow r in dt.Rows)
                {
                    grid.Rows.Add(
                        r["id"].ToString(),
                        r["origen"].ToString()
                    );
                }
            }
        }
  
        public void add()
        {
            Mysql sql = new Mysql();
            bool rs = sql.Ejecutar("INSERT INTO `origen` (`origen`,`id_sector`) VALUES ('" + txt.Text + "','" + Operador.sector_id + "');");
            if (rs)
            {
                load();
                txt.Text = "";
            }
            else
            {
                MessageBox.Show("Error al insertar.");
            }
        }
        public void del(string id)
        {
            Mysql sql = new Mysql();
            bool rs = sql.Ejecutar("DELETE FROM `origen` WHERE `id`='" + id + "' limit 1;");
            if (rs)
            {
                load();
            }
            else
            {
                MessageBox.Show("Error al eliminar.");
            }
        }
        public void update(string id)
        {
            Mysql sql = new Mysql();
            bool rs = sql.Ejecutar("UPDATE `origen` SET `origen`='" + txt.Text + "' WHERE `id`='" + id + "' limit 1;");
            if (rs)
            {
                load();
            }
            else
            {
                MessageBox.Show("Error al editar.");
            }
        }
    }
}
