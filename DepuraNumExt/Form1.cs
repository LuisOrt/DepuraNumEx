using System;
using System.Windows.Forms;
using System.Data.OleDb;

namespace DepuraNumExt{
    public partial class DepuraNumExt : Form{
        public DepuraNumExt(){
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e){
            string path;
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Archivos de base de datos |*.mdb";
            if (file.ShowDialog() == DialogResult.OK){
                Boton.Visible = false;
                path = file.FileName;
                Etiqueta.Text = path;
                OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;"+"Data Source=" + path);
                conn.Open();
                OleDbCommand cmd =conn.CreateCommand();
                cmd.CommandText = "Select ID, numext from NUMERO";
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read()){
                    String NumExt = reader[1].ToString();
                    string[] words = NumExt.Split(' ');

                    if (words.Length > 1 && words[0].Substring(0,1) !="L" && words[0].Substring(0, 1) != "M"){//Se me hace que no respeta LM
                        OleDbCommand upd = conn.CreateCommand();
                        upd.CommandText = "UPDATE NUMERO SET numext = \"" + words[0]+ "\" WHERE ID = " + reader[0].ToString() + ";";
                        upd.ExecuteNonQuery();
                        TextArea.Text = (reader[0].ToString() + "\t" + reader[1].ToString() + "\n");
                    }
                }
                reader.Close();
                TextArea.AppendText("\nFin");
            }
        }
    }
}
