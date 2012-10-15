using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;


namespace Compilador
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            panelPrincipal.Dock = DockStyle.Fill;
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }

        private void Archivo_Click(object sender, EventArgs e)
        {

        }

        private void pestañaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage nt = new TabPage("newTab"+(panelPrincipal.TabCount + 1).ToString());
            RichTextBox rt = new RichTextBox();
            rt.TextChanged += new EventHandler(NuevoTextBox_TextChanged);
            rt.VScroll += new EventHandler(NuevoTextBox_TextChanged);
            rt.SelectionChanged += new EventHandler(NuevoTextBox_TextChanged);
            rt.Dock = DockStyle.Fill;
            rt.Parent = nt;
            panelPrincipal.TabPages.Add(nt);
            panelPrincipal.SelectTab(nt);
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            TabPage nt = new TabPage("newTab" + (panelPrincipal.TabCount + 1).ToString());
            RichTextBox rt = new RichTextBox();
            rt.TextChanged += new EventHandler(NuevoTextBox_TextChanged);
            rt.VScroll += new EventHandler(NuevoTextBox_TextChanged);
            rt.SelectionChanged += new EventHandler(NuevoTextBox_TextChanged);
            rt.Dock = DockStyle.Fill;
            rt.Parent = nt;
            panelPrincipal.TabPages.Add(nt);
            panelPrincipal.SelectTab(nt);
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            //se crea un objeto de openfiledialogo que nos servira para abrir archivos
            OpenFileDialog Open = new OpenFileDialog();
            System.IO.StreamReader myStreamReader = null;
            //se especifica que tipos de archivos se podran abrir y se verifica si existe
            Open.Filter = "Text [*.txt*]|*.txt|All Files [*,*]|*,*";
            Open.CheckFileExists = true;
            Open.Title = "Abrir Archivo";
            Open.ShowDialog(this);
            try
            {
                //este codigo se utiliza para que se pueda pueda mostrar la informacion del archivo que queremos abrir en el rich textbox
                Open.OpenFile();
                String nombre = Open.FileName;
                myStreamReader = System.IO.File.OpenText(Open.FileName);
                RichTextBox rtTemp = (RichTextBox) panelPrincipal.TabPages[0].Controls[0];
                if (rtTemp.Text.Equals(""))
                {
                   rtTemp.Text = myStreamReader.ReadToEnd();
                   rtTemp.TextChanged += new EventHandler(NuevoTextBox_TextChanged);
                   rtTemp.VScroll += new EventHandler(NuevoTextBox_TextChanged);
                   rtTemp.SelectionChanged += new EventHandler(NuevoTextBox_TextChanged);
                   panelPrincipal.TabPages[0].Text = nombre;
                }
                else 
                {
                    TabPage nt = new TabPage(nombre);
                    RichTextBox rt = new RichTextBox();
                    rt.TextChanged += new EventHandler(NuevoTextBox_TextChanged);
                    rt.VScroll += new EventHandler(NuevoTextBox_TextChanged);
                    rt.SelectionChanged += new EventHandler(NuevoTextBox_TextChanged);
                    rt.Dock = DockStyle.Fill;
                    rt.Parent = nt;
                    rt.Text = myStreamReader.ReadToEnd();
                    panelPrincipal.TabPages.Add(nt);
                    panelPrincipal.SelectTab(nt);
                }


                

            }
            catch (Exception) { }
        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            panelPrincipal.SelectedTab.Dispose();
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void NuevoTextBox_TextChanged(object sender, EventArgs e)
        {
            RichTextBox rt = (RichTextBox)panelPrincipal.SelectedTab.Controls[0];
            String linea = rt.GetLineFromCharIndex(rt.SelectionStart).ToString();
            String Columna = rt.GetPositionFromCharIndex(rt.SelectionStart).X.ToString();
            groupBox2.Text = "Estado. Linea: " + linea + " Columna: " + Columna;
            
        }

        private void archivoToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void btCompilar_Click(object sender, EventArgs e)
        {
            /*       RichTextBox rt = (RichTextBox)panelPrincipal.SelectedTab.Controls[0];
                    String name = rt.Name.ToString();
                    */

            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.InitialDirectory = dir;
            saveDialog.DefaultExt = "txt";
            saveDialog.Filter = "Text Files|*.txt|RTF|*.rtf";

            saveDialog.RestoreDirectory = true;

            DialogResult result = saveDialog.ShowDialog();


            if (result == DialogResult.OK)
            {
                string extension = Path.GetExtension(saveDialog.FileName);
                dir = Path.GetDirectoryName(saveDialog.FileName);


                if (extension == ".txt")
                    rtInicial.SaveFile(saveDialog.FileName,
                    RichTextBoxStreamType.PlainText);
                else
                    rtInicial.SaveFile(saveDialog.FileName,
                    RichTextBoxStreamType.RichText);

                StreamReader objReader = new StreamReader(saveDialog.FileName);
              
            }
           
        }

//----------------------------------------READ FILE--------------------------------------------------
        private StreamReader sr;
        private FileStream fs;
        public string read(String ruta)
        {
            ruta = "prueba.txt";
            fs = File.Open(ruta, FileMode.Open);
            sr = new StreamReader(fs);
            string cadena = "";
            cadena = sr.ReadToEnd();
            return cadena;
        }
//---------------------------------------------------------------------------------------------
        private void rtInicial_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            read("C:/Users/fr0609/Desktop");
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            RichTextBox rt = (RichTextBox)panelPrincipal.SelectedTab.Controls[0];
            //se crea un objeto de tipo savefiledialog que nos servira para guardar el archivo
            SaveFileDialog Save = new SaveFileDialog();
            System.IO.StreamWriter myStreamWriter = null;
            //al igual que para abrir el tipo de documentos aqui se especifica en que extenciones se puede guardar el archivo
            Save.Filter = "Text (*.txt)|*.txt|HTML(*.html*)|*.html|All files(*.*)|*.*";
            Save.CheckPathExists = true;
            Save.Title = "Guardar como";
            Save.ShowDialog(this);
            try
            {

                //este codigo se utiliza para guardar el archivo de nuestro editor
                myStreamWriter = System.IO.File.AppendText(Save.FileName);
                myStreamWriter.Write(rt.Text);
                myStreamWriter.Flush();

            }
            catch (Exception) { }
        }
    }
}
