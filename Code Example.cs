using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace DienynasFULL
{
    public partial class VaikuRegistracija : Form
    {
        SqlConnection PoSauleConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\herku\Desktop\Kurybinis\DarzelioDienynas\DienynasFULL\DienynasFULL\dbPoSaule.mdf;Integrated Security=True;Connect Timeout=30");
        static TextBox NameBox = new TextBox();
        static TextBox PavardeBox = new TextBox();
        static TextBox KodasBox = new TextBox();
        static TextBox AdresasBox = new TextBox();
        static TextBox PastabosBox = new TextBox();
        static TextBox mVardas = new TextBox();
        static TextBox mPavarde = new TextBox();
        static TextBox mPastas = new TextBox();
        static TextBox mTelefonas = new TextBox();
        static TextBox tVardas = new TextBox();
        static TextBox tPavarde = new TextBox();
        static TextBox tPastas = new TextBox();
        static TextBox tTelefonas = new TextBox();
        static DateTimePicker GimimoBox = new DateTimePicker();
        static Button VPrideti = new Button();
        static Button VAtnaujinti = new Button();
        static Button VTrinti = new Button();
        static PictureBox pictureBox = new PictureBox();
        static string imgLocation = "";
        static int DeleteID;
        static VaikuRegistracija vaikuRegistracija;
        public static ComboBox comboBox = new ComboBox();
        public static bool ChangeFoto = false;

        public VaikuRegistracija()
        {
            InitializeComponent();
            NameBox = textBox1;
            PavardeBox = textBox2;
            KodasBox = textBox3;
            AdresasBox = textBox4;
            GimimoBox = dateTimePicker1;
            PastabosBox = textBox5;
            mVardas = textBox6;
            mPavarde = textBox7;
            mPastas = textBox8;
            mTelefonas = textBox9;
            tVardas = textBox10;
            tPavarde = textBox11;
            tPastas = textBox12;
            tTelefonas = textBox13;
            VPrideti = button1;
            VAtnaujinti = button2;
            VTrinti = button3;
            pictureBox = pictureBox1;
            vaikuRegistracija = this;
            comboBox = comboBox1;
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.SelectedIndex = 0;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            this.Hide();
            this.Parent = null;
            e.Cancel = true;
        }

        public static void FillRegister(int id)
        {

            SqlConnection PoSauleConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\herku\Desktop\Kurybinis\DarzelioDienynas\DienynasFULL\DienynasFULL\dbPoSaule.mdf;Integrated Security=True;Connect Timeout=30");
            PoSauleConnection.Open();

            if (comboBox.SelectedIndex == 0)
            {
                SqlCommand cmd = new SqlCommand("Select * from tbl_pieva where Id=" + id, PoSauleConnection);
                SqlDataReader da = cmd.ExecuteReader();
                while (da.Read())
                {
                    NameBox.Text = da.GetValue(1).ToString();
                    PavardeBox.Text = da.GetValue(2).ToString();
                    KodasBox.Text = da.GetValue(3).ToString();
                    DateTime dateTime = DateTime.Parse(da.GetValue(4).ToString());
                    GimimoBox.Value = dateTime;
                    AdresasBox.Text = da.GetValue(5).ToString();
                    mVardas.Text = da.GetValue(6).ToString();
                    mPavarde.Text = da.GetValue(7).ToString();
                    mPastas.Text = da.GetValue(8).ToString();
                    mTelefonas.Text = da.GetValue(9).ToString();
                    tVardas.Text = da.GetValue(10).ToString();
                    tPavarde.Text = da.GetValue(11).ToString();
                    tPastas.Text = da.GetValue(12).ToString();
                    tTelefonas.Text = da.GetValue(13).ToString();
                    PastabosBox.Text = da.GetValue(14).ToString();
                }
            }
            if (comboBox.SelectedIndex == 1)
            {
                SqlCommand cmd = new SqlCommand("Select * from tbl_miskas where Id=" + id, PoSauleConnection);
                SqlDataReader da = cmd.ExecuteReader();
                while (da.Read())
                {
                    NameBox.Text = da.GetValue(1).ToString();
                    PavardeBox.Text = da.GetValue(2).ToString();
                    KodasBox.Text = da.GetValue(3).ToString();
                    DateTime dateTime = DateTime.Parse(da.GetValue(4).ToString());
                    GimimoBox.Value = dateTime;
                    AdresasBox.Text = da.GetValue(5).ToString();
                    mVardas.Text = da.GetValue(6).ToString();
                    mPavarde.Text = da.GetValue(7).ToString();
                    mPastas.Text = da.GetValue(8).ToString();
                    mTelefonas.Text = da.GetValue(9).ToString();
                    tVardas.Text = da.GetValue(10).ToString();
                    tPavarde.Text = da.GetValue(11).ToString();
                    tPastas.Text = da.GetValue(12).ToString();
                    tTelefonas.Text = da.GetValue(13).ToString();
                    PastabosBox.Text = da.GetValue(14).ToString();
                }
            }
            if (comboBox.SelectedIndex == 2)
            {
                SqlCommand cmd = new SqlCommand("Select * from tbl_upe where Id=" + id, PoSauleConnection);
                SqlDataReader da = cmd.ExecuteReader();
                while (da.Read())
                {
                    NameBox.Text = da.GetValue(1).ToString();
                    PavardeBox.Text = da.GetValue(2).ToString();
                    KodasBox.Text = da.GetValue(3).ToString();
                    DateTime dateTime = DateTime.Parse(da.GetValue(4).ToString());
                    GimimoBox.Value = dateTime;
                    AdresasBox.Text = da.GetValue(5).ToString();
                    mVardas.Text = da.GetValue(6).ToString();
                    mPavarde.Text = da.GetValue(7).ToString();
                    mPastas.Text = da.GetValue(8).ToString();
                    mTelefonas.Text = da.GetValue(9).ToString();
                    tVardas.Text = da.GetValue(10).ToString();
                    tPavarde.Text = da.GetValue(11).ToString();
                    tPastas.Text = da.GetValue(12).ToString();
                    tTelefonas.Text = da.GetValue(13).ToString();
                    PastabosBox.Text = da.GetValue(14).ToString();
                }
            }
            UpdateOn();
        }

        public static void FillImage(int id)
        {
            SqlConnection PoSauleConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\herku\Desktop\Kurybinis\DarzelioDienynas\DienynasFULL\DienynasFULL\dbPoSaule.mdf;Integrated Security=True;Connect Timeout=30");
            PoSauleConnection.Open();
            SqlCommand cmd2 = new SqlCommand();
            if (comboBox.SelectedIndex == 0)
            {
                cmd2 = new SqlCommand("Select Name,Image from tbl_pButtons where Id=" + id, PoSauleConnection);
                SqlDataReader da2 = cmd2.ExecuteReader();
                while (da2.Read())
                {
                    byte[] imag = ((byte[])da2[1]);

                    if (imag == null)
                    {
                        pictureBox.Image = null;
                    }
                    else
                    {
                        MemoryStream memoryStream = new MemoryStream(imag);
                        pictureBox.Image = Image.FromStream(memoryStream);
                    }
                }
            }
            if (comboBox.SelectedIndex == 1)
            {
                cmd2 = new SqlCommand("Select Name,Image from tbl_mButtons where Id=" + id, PoSauleConnection);
                SqlDataReader da2 = cmd2.ExecuteReader();
                while (da2.Read())
                {
                    byte[] imag = ((byte[])da2[1]);

                    if (imag == null)
                    {
                        pictureBox.Image = null;
                    }
                    else
                    {
                        MemoryStream memoryStream = new MemoryStream(imag);
                        pictureBox.Image = Image.FromStream(memoryStream);
                    }
                }
            }
            if (comboBox.SelectedIndex == 2)
            {
                cmd2 = new SqlCommand("Select Name,Image from tbl_uButtons where Id=" + id, PoSauleConnection);
                SqlDataReader da2 = cmd2.ExecuteReader();
                while (da2.Read())
                {
                    byte[] imag = ((byte[])da2[1]);

                    if (imag == null)
                    {
                        pictureBox.Image = null;
                    }
                    else
                    {
                        MemoryStream memoryStream = new MemoryStream(imag);
                        pictureBox.Image = Image.FromStream(memoryStream);
                    }
                }
            }

        }

        public static void SetID(int id)
        {
            DeleteID = id;
        }

        public static void DeleteData(int id)
        {
            SqlConnection PoSauleConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\herku\Desktop\Kurybinis\DarzelioDienynas\DienynasFULL\DienynasFULL\dbPoSaule.mdf;Integrated Security=True;Connect Timeout=30");
            PoSauleConnection.Open();

            if (comboBox.SelectedIndex == 0)
            {
                SqlCommand cmd = new SqlCommand("Delete  from tbl_pieva where Id= @id", PoSauleConnection);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = DeleteID;
                cmd.ExecuteNonQuery();

                SqlCommand cmd2 = new SqlCommand("Delete  from tbl_pButtons where Id= @id", PoSauleConnection);
                cmd2.Parameters.Add("@id", SqlDbType.Int).Value = DeleteID;
                cmd2.ExecuteNonQuery();
            }
            if (comboBox.SelectedIndex == 1)
            {
                SqlCommand cmd = new SqlCommand("Delete  from tbl_miskas where Id= @id", PoSauleConnection);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = DeleteID;
                cmd.ExecuteNonQuery();

                SqlCommand cmd2 = new SqlCommand("Delete  from tbl_mButtons where Id= @id", PoSauleConnection);
                cmd2.Parameters.Add("@id", SqlDbType.Int).Value = DeleteID;
                cmd2.ExecuteNonQuery();
            }
            if (comboBox.SelectedIndex == 2)
            {
                SqlCommand cmd = new SqlCommand("Delete  from tbl_upe where Id= @id", PoSauleConnection);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = DeleteID;
                cmd.ExecuteNonQuery();

                SqlCommand cmd2 = new SqlCommand("Delete  from tbl_uButtons where Id= @id", PoSauleConnection);
                cmd2.Parameters.Add("@id", SqlDbType.Int).Value = DeleteID;
                cmd2.ExecuteNonQuery();
            }
            PoSauleConnection.Close();
            vaikuRegistracija.Hide();
        }


        public static void UpdateData()
        {
            SqlConnection PoSauleConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\herku\Desktop\Kurybinis\DarzelioDienynas\DienynasFULL\DienynasFULL\dbPoSaule.mdf;Integrated Security=True;Connect Timeout=30");
            PoSauleConnection.Open();

            if (comboBox.SelectedIndex == 0)
            {
                SqlCommand cmd = new SqlCommand("UPDATE tbl_pieva SET Vardas=@Vardas,Pavardė=@Pavardė,AsmensKodas=@AsmensKodas,GimimoData=@GimimoData,Adresas=@Adresas,mVardas=@mVardas,mPavarde=@mPavarde,mPastas=@mPastas,mTelefonas=@mTelefonas,tVardas=@tVardas,tPavarde=@tPavarde,tPastas=@tPastas,tTelefonas=@tTelefonas,Pastabos=@Pastabos WHERE Id= @id", PoSauleConnection);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = DeleteID;
                cmd.Parameters.Add("@Vardas", SqlDbType.VarChar).Value = NameBox.Text;
                cmd.Parameters.Add("@Pavardė", SqlDbType.VarChar).Value = PavardeBox.Text;
                cmd.Parameters.Add("@GimimoData", SqlDbType.VarChar).Value = GimimoBox.Text;
                cmd.Parameters.Add("@AsmensKodas", SqlDbType.VarChar).Value = KodasBox.Text;
                cmd.Parameters.Add("@Adresas", SqlDbType.VarChar).Value = AdresasBox.Text;
                cmd.Parameters.Add("@mVardas", SqlDbType.VarChar).Value = mVardas.Text;
                cmd.Parameters.Add("@mPavarde", SqlDbType.VarChar).Value = mPavarde.Text;
                cmd.Parameters.Add("@mPastas", SqlDbType.VarChar).Value = mPastas.Text;
                cmd.Parameters.Add("@mTelefonas", SqlDbType.VarChar).Value = mTelefonas.Text;
                cmd.Parameters.Add("@tVardas", SqlDbType.VarChar).Value = tVardas.Text;
                cmd.Parameters.Add("@tPavarde", SqlDbType.VarChar).Value = tPavarde.Text;
                cmd.Parameters.Add("@tPastas", SqlDbType.VarChar).Value = tPastas.Text;
                cmd.Parameters.Add("@tTelefonas", SqlDbType.VarChar).Value = tTelefonas.Text;
                cmd.Parameters.Add("@Pastabos", SqlDbType.VarChar).Value = PastabosBox.Text;
                cmd.ExecuteNonQuery();

                if (ChangeFoto)
                {
                    SqlCommand cmd2 = new SqlCommand("UPDATE tbl_pButtons SET Name=@Name,Image=@image where Id= @id", PoSauleConnection);
                    cmd2.Parameters.Add("@id", SqlDbType.Int).Value = DeleteID;
                    cmd2.Parameters.Add("@Name", SqlDbType.VarChar).Value = NameBox.Text;
                    byte[] images = null;

                    if (pictureBox.Image != null)
                    {
                        FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                        BinaryReader brs = new BinaryReader(stream);
                        images = brs.ReadBytes((int)stream.Length);
                        cmd2.Parameters.Add("@Image", SqlDbType.Image).Value = images;
                    }
                    ChangeFoto = false;
                    cmd2.ExecuteNonQuery();
                }
                else
                {
                    SqlCommand cmd2 = new SqlCommand("UPDATE tbl_pButtons SET Name=@Name where Id= @id", PoSauleConnection);
                    cmd2.Parameters.Add("@id", SqlDbType.Int).Value = DeleteID;
                    cmd2.Parameters.Add("@Name", SqlDbType.VarChar).Value = NameBox.Text;
                    cmd2.ExecuteNonQuery();
                }
            }
            if (comboBox.SelectedIndex == 1)
            {
                SqlCommand cmd = new SqlCommand("UPDATE tbl_miskas SET Vardas=@Vardas,Pavardė=@Pavardė,AsmensKodas=@AsmensKodas,GimimoData=@GimimoData,Adresas=@Adresas,mVardas=@mVardas,mPavarde=@mPavarde,mPastas=@mPastas,mTelefonas=@mTelefonas,tVardas=@tVardas,tPavarde=@tPavarde,tPastas=@tPastas,tTelefonas=@tTelefonas,Pastabos=@Pastabos WHERE Id= @id", PoSauleConnection);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = DeleteID;
                cmd.Parameters.Add("@Vardas", SqlDbType.VarChar).Value = NameBox.Text;
                cmd.Parameters.Add("@Pavardė", SqlDbType.VarChar).Value = PavardeBox.Text;
                cmd.Parameters.Add("@GimimoData", SqlDbType.VarChar).Value = GimimoBox.Text;
                cmd.Parameters.Add("@AsmensKodas", SqlDbType.VarChar).Value = KodasBox.Text;
                cmd.Parameters.Add("@Adresas", SqlDbType.VarChar).Value = AdresasBox.Text;
                cmd.Parameters.Add("@mVardas", SqlDbType.VarChar).Value = mVardas.Text;
                cmd.Parameters.Add("@mPavarde", SqlDbType.VarChar).Value = mPavarde.Text;
                cmd.Parameters.Add("@mPastas", SqlDbType.VarChar).Value = mPastas.Text;
                cmd.Parameters.Add("@mTelefonas", SqlDbType.VarChar).Value = mTelefonas.Text;
                cmd.Parameters.Add("@tVardas", SqlDbType.VarChar).Value = tVardas.Text;
                cmd.Parameters.Add("@tPavarde", SqlDbType.VarChar).Value = tPavarde.Text;
                cmd.Parameters.Add("@tPastas", SqlDbType.VarChar).Value = tPastas.Text;
                cmd.Parameters.Add("@tTelefonas", SqlDbType.VarChar).Value = tTelefonas.Text;
                cmd.Parameters.Add("@Pastabos", SqlDbType.VarChar).Value = PastabosBox.Text;
                cmd.ExecuteNonQuery();

                if (ChangeFoto)
                {
                    SqlCommand cmd2 = new SqlCommand("UPDATE tbl_mButtons SET Name=@Name,Image=@image where Id= @id", PoSauleConnection);
                    cmd2.Parameters.Add("@id", SqlDbType.Int).Value = DeleteID;
                    cmd2.Parameters.Add("@Name", SqlDbType.VarChar).Value = NameBox.Text;
                    byte[] images = null;

                    if (pictureBox.Image != null)
                    {
                        FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                        BinaryReader brs = new BinaryReader(stream);
                        images = brs.ReadBytes((int)stream.Length);
                        cmd2.Parameters.Add("@Image", SqlDbType.Image).Value = images;
                    }
                    ChangeFoto = false;
                    cmd2.ExecuteNonQuery();
                }
                else
                {
                    SqlCommand cmd2 = new SqlCommand("UPDATE tbl_mButtons SET Name=@Name where Id= @id", PoSauleConnection);
                    cmd2.Parameters.Add("@id", SqlDbType.Int).Value = DeleteID;
                    cmd2.Parameters.Add("@Name", SqlDbType.VarChar).Value = NameBox.Text;
                    cmd2.ExecuteNonQuery();
                }
            }
            if (comboBox.SelectedIndex == 2)
            {
                SqlCommand cmd = new SqlCommand("UPDATE tbl_upe SET Vardas=@Vardas,Pavardė=@Pavardė,AsmensKodas=@AsmensKodas,GimimoData=@GimimoData,Adresas=@Adresas,mVardas=@mVardas,mPavarde=@mPavarde,mPastas=@mPastas,mTelefonas=@mTelefonas,tVardas=@tVardas,tPavarde=@tPavarde,tPastas=@tPastas,tTelefonas=@tTelefonas,Pastabos=@Pastabos WHERE Id= @id", PoSauleConnection);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = DeleteID;
                cmd.Parameters.Add("@Vardas", SqlDbType.VarChar).Value = NameBox.Text;
                cmd.Parameters.Add("@Pavardė", SqlDbType.VarChar).Value = PavardeBox.Text;
                cmd.Parameters.Add("@GimimoData", SqlDbType.VarChar).Value = GimimoBox.Text;
                cmd.Parameters.Add("@AsmensKodas", SqlDbType.VarChar).Value = KodasBox.Text;
                cmd.Parameters.Add("@Adresas", SqlDbType.VarChar).Value = AdresasBox.Text;
                cmd.Parameters.Add("@mVardas", SqlDbType.VarChar).Value = mVardas.Text;
                cmd.Parameters.Add("@mPavarde", SqlDbType.VarChar).Value = mPavarde.Text;
                cmd.Parameters.Add("@mPastas", SqlDbType.VarChar).Value = mPastas.Text;
                cmd.Parameters.Add("@mTelefonas", SqlDbType.VarChar).Value = mTelefonas.Text;
                cmd.Parameters.Add("@tVardas", SqlDbType.VarChar).Value = tVardas.Text;
                cmd.Parameters.Add("@tPavarde", SqlDbType.VarChar).Value = tPavarde.Text;
                cmd.Parameters.Add("@tPastas", SqlDbType.VarChar).Value = tPastas.Text;
                cmd.Parameters.Add("@tTelefonas", SqlDbType.VarChar).Value = tTelefonas.Text;
                cmd.Parameters.Add("@Pastabos", SqlDbType.VarChar).Value = PastabosBox.Text;
                cmd.ExecuteNonQuery();

                if (ChangeFoto)
                {
                    SqlCommand cmd2 = new SqlCommand("UPDATE tbl_uButtons SET Name=@Name,Image=@image where Id= @id", PoSauleConnection);
                    cmd2.Parameters.Add("@id", SqlDbType.Int).Value = DeleteID;
                    cmd2.Parameters.Add("@Name", SqlDbType.VarChar).Value = NameBox.Text;
                    byte[] images = null;

                    if (pictureBox.Image != null)
                    {
                        FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                        BinaryReader brs = new BinaryReader(stream);
                        images = brs.ReadBytes((int)stream.Length);
                        cmd2.Parameters.Add("@Image", SqlDbType.Image).Value = images;
                    }
                    ChangeFoto = false;
                    cmd2.ExecuteNonQuery();
                }
                else
                {
                    SqlCommand cmd2 = new SqlCommand("UPDATE tbl_uButtons SET Name=@Name where Id= @id", PoSauleConnection);
                    cmd2.Parameters.Add("@id", SqlDbType.Int).Value = DeleteID;
                    cmd2.Parameters.Add("@Name", SqlDbType.VarChar).Value = NameBox.Text;
                    cmd2.ExecuteNonQuery();
                }
            }
            PoSauleConnection.Close();
            vaikuRegistracija.Hide();
            //Lankomumas.TableGeneravimas();
        }

        public static void UpdateOn()
        {
            VPrideti.Visible = false;
            VAtnaujinti.Visible = true;
            VTrinti.Visible = true;
        }

        public static void UpdateOff()
        {
            VPrideti.Visible = true;
            VAtnaujinti.Visible = false;
            VTrinti.Visible = false;
        }

        public static void NewADD()
        {
            NameBox.Text = "";
            PavardeBox.Text = "";
            KodasBox.Text = "";
            PastabosBox.Text = "";
            AdresasBox.Text = "";
            DateTime dateTime = DateTime.Now;
            GimimoBox.Value = dateTime;
            mVardas.Text = "";
            mPavarde.Text = "";
            mPastas.Text = "";
            mTelefonas.Text = "";
            tVardas.Text = "";
            tPavarde.Text = "";
            tPastas.Text = "";
            tTelefonas.Text = "";
        }

        private void VaikuRegistracija_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] images = null;

            if (pictureBox.Image != null)
            {
                FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(stream);
                images = brs.ReadBytes((int)stream.Length);
            }

            PoSauleConnection.Open();

            if (comboBox.SelectedIndex == 0)
            {
                SqlDataAdapter SDA = new SqlDataAdapter("INSERT INTO tbl_pieva (Vardas,Pavardė,AsmensKodas,Adresas,GimimoData,Pastabos,mVardas,mPavarde,mPastas,mTelefonas,tVardas,tPavarde,tPastas,tTelefonas) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + this.dateTimePicker1.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox11.Text + "','" + textBox12.Text + "', '" + textBox13.Text + "')", PoSauleConnection);
                SqlCommand cmd = new SqlCommand("INSERT INTO tbl_pButtons (Name,Image) VALUES ('" + textBox1.Text + "',@images)", PoSauleConnection);
                cmd.Parameters.Add(new SqlParameter("@images", images));
                SDA.SelectCommand.ExecuteNonQuery();
                cmd.ExecuteNonQuery();
                Vaikai.MygtukuGeneravimas();
                pictureBox.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                PoSauleConnection.Close();
                MessageBox.Show("Sėkmingai išsaugota");
            }
            if (comboBox.SelectedIndex == 1)
            {
                SqlDataAdapter SDA = new SqlDataAdapter("INSERT INTO tbl_miskas (Vardas,Pavardė,AsmensKodas,Adresas,GimimoData,Pastabos,mVardas,mPavarde,mPastas,mTelefonas,tVardas,tPavarde,tPastas,tTelefonas) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + this.dateTimePicker1.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox11.Text + "','" + textBox12.Text + "', '" + textBox13.Text + "')", PoSauleConnection);
                SqlCommand cmd = new SqlCommand("INSERT INTO tbl_mButtons (Name,Image) VALUES ('" + textBox1.Text + "',@images)", PoSauleConnection);
                cmd.Parameters.Add(new SqlParameter("@images", images));
                SDA.SelectCommand.ExecuteNonQuery();
                cmd.ExecuteNonQuery();
                Vaikai.MygtukuGeneravimas();
                pictureBox.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                PoSauleConnection.Close();
                MessageBox.Show("Sėkmingai išsaugota");
            }
            if (comboBox.SelectedIndex == 2)
            {
                SqlDataAdapter SDA = new SqlDataAdapter("INSERT INTO tbl_upe (Vardas,Pavardė,AsmensKodas,Adresas,GimimoData,Pastabos,mVardas,mPavarde,mPastas,mTelefonas,tVardas,tPavarde,tPastas,tTelefonas) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + this.dateTimePicker1.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox11.Text + "','" + textBox12.Text + "', '" + textBox13.Text + "')", PoSauleConnection);
                SqlCommand cmd = new SqlCommand("INSERT INTO tbl_uButtons (Name,Image) VALUES ('" + textBox1.Text + "',@images)", PoSauleConnection);
                cmd.Parameters.Add(new SqlParameter("@images", images));
                SDA.SelectCommand.ExecuteNonQuery();
                cmd.ExecuteNonQuery();
                Vaikai.MygtukuGeneravimas();
                pictureBox.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                PoSauleConnection.Close();
                MessageBox.Show("Sėkmingai išsaugota");
            }
            this.Hide();
            ChangeFoto = false;
            //Lankomumas.TableGeneravimas();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateData();
            Vaikai.UpdateButton();
            Vaikai.MygtukuGeneravimas();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Vaikai.DeleteButton();
            DeleteData(DeleteID);
            Vaikai.MygtukuGeneravimas();
            //Lankomumas.TableGeneravimas();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "All files(*.*)|*.*|jpg files(*.jpg)|*.jpg|png files(*.png)|*.png";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                pictureBox.ImageLocation = imgLocation;
                ChangeFoto = true;
            }
        }
    }
}
