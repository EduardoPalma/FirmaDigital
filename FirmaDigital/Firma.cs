using FirmaDigital.signature;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace FirmaDigital;

public partial class Form1 : Form
{
    private DigitalSignature _dg;
    private byte[]  _signature;
    private Clave _claveForm;
    private string _keyPublic;
    private string _keyPrivate;

    public Form1()
    {
        InitializeComponent();
        StartPosition = FormStartPosition.CenterScreen;
        _claveForm = new Clave();
    }


    private void Seleccionar_Archivo_Firmar(object sender, EventArgs e)
    {
        openFileDialog1.InitialDirectory = "C:\\";
        if(openFileDialog1.ShowDialog() == DialogResult.OK)
        {
            var ruta = openFileDialog1.FileName;
            boxSignature.Text = ruta;
        }
    }

    private void Seleccionar_Archivo_Verificar(object sender, EventArgs e)
    {
        openFileDialog1.InitialDirectory = "C:\\";
        if (openFileDialog1.ShowDialog() == DialogResult.OK)
        {
            var ruta = openFileDialog1.FileName;
            boxVerify.Text = ruta;
        }

    }

    private void Firma_Archivo_Click(object sender, EventArgs e)
    {
        _dg = new DigitalSignature();
        _signature = _dg.GenerateSignature(boxSignature.Text);
        hashFirma.Text = BitConverter.ToString(Authentication.Hash512(File.ReadAllBytes(boxSignature.Text)));
        _keyPrivate = key(_dg, true);
        _keyPublic = key(_dg, false);

    }

    private string key(DigitalSignature dg, bool type)
    {
        /*
        string pubKeyString;
        {
            //we need some buffer
            var sw = new System.IO.StringWriter();
            //we need a serializer
            var xs = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
            //serialize the key into the stream
            xs.Serialize(sw, dg.Rsa.ExportParameters(type));
            //get the string from the stream
            pubKeyString = sw.ToString();
        }*/
        if(type) return Convert.ToBase64String(dg.Rsa.ExportPkcs8PrivateKey());
        return Convert.ToBase64String(dg.Rsa.ExportRSAPublicKey());
    }

    private void Verificar_Archivo_Click(object sender, EventArgs e)
    {
        var status = _dg.VerificySignature(boxVerify.Text,_signature);
        hashVerificacion.Text = BitConverter.ToString(Authentication.Hash512(File.ReadAllBytes(boxVerify.Text)));
        if (status)
        {
            MessageBox.Show("Archivo Verificado");
        }
        else
        {
            MessageBox.Show("Archivo no es autentico");
        }
    }

    private void MostrarClavePublica(object sender, EventArgs e)
    {
    
        _claveForm.IngresarVariables(_keyPublic,"LLave Publica");
        _claveForm.ShowDialog();
    }

    private void MostrarClavePrivada(object sender, EventArgs e)
    {
       
        _claveForm.IngresarVariables(_keyPrivate, "LLave Privada");
        _claveForm.ShowDialog();
    }
}