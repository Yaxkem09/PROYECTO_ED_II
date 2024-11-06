using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using Microsoft.VisualBasic;
using System.Timers;


namespace PROYECTO_ED
{
    public partial class Form1 : Form
    {
        private string key = "5532372-"; 
        private string filePath; 
        private System.Windows.Forms.Timer inactivityTimer;
        private int InactivityLimit = 10000;
        private System.Windows.Forms.Timer clipboardTimer;
        public Form1()
        {
            InitializeComponent();
            ConfigurarInactivityTimer(); 
            ConfigurarClipboardTimer();  

            this.BackColor = Color.FromArgb(32, 32, 32); 
            this.ForeColor = Color.Gray; 

            textBox1.BackColor = Color.FromArgb(50, 50, 50);
            textBox1.ForeColor = Color.White;
            tb_sitename.BackColor = Color.FromArgb(50, 50, 50);
            tb_sitename.ForeColor = Color.White;
            tb_username.BackColor = Color.FromArgb(50, 50, 50);
            tb_username.ForeColor = Color.White;
            tb_password.BackColor = Color.FromArgb(50, 50, 50);
            tb_password.ForeColor = Color.White;
            tb_url.BackColor = Color.FromArgb(50, 50, 50);
            tb_url.ForeColor = Color.White;
            tb_notes.BackColor = Color.FromArgb(50, 50, 50);
            tb_notes.ForeColor = Color.White;
            tb_extra1.BackColor = Color.FromArgb(50, 50, 50);
            tb_extra1.ForeColor = Color.White;
            tb_extra2.BackColor = Color.FromArgb(50, 50, 50);
            tb_extra2.ForeColor = Color.White;
            tb_extra3.BackColor = Color.FromArgb(50, 50, 50);
            tb_extra3.ForeColor = Color.White;
            tb_extra4.BackColor = Color.FromArgb(50, 50, 50);
            tb_extra4.ForeColor = Color.White;
            tb_extra5.BackColor = Color.FromArgb(50, 50, 50);
            tb_extra5.ForeColor = Color.White;
            tb_tags.BackColor = Color.FromArgb(50, 50, 50);
            tb_tags.ForeColor = Color.White;
            tb_icon.BackColor = Color.FromArgb(50, 50, 50);
            tb_icon.ForeColor = Color.White;
            tb_buscar.BackColor = Color.FromArgb(50, 50, 50);
            tb_buscar.ForeColor = Color.White;
            tb_json.BackColor = Color.FromArgb(50, 50, 50);
            tb_json.ForeColor = Color.White;
            btnBuscar.BackColor = Color.DarkGreen;
            btnBuscar.ForeColor = Color.White;
            btnActivarAgregar.BackColor = Color.DarkGreen;
            btnActivarAgregar.ForeColor = Color.White;
            btnActivarModificar.BackColor = Color.DarkGreen;
            btnActivarModificar.ForeColor = Color.White;
            btnAgregar.BackColor = Color.DarkGreen;
            btnAgregar.ForeColor = Color.White;
            btnModificar.BackColor = Color.DarkGreen;
            btnModificar.ForeColor = Color.White;
            btnImportar.BackColor = Color.DarkGreen;
            btnImportar.ForeColor = Color.White;
            btnSalir.BackColor = Color.DarkGreen;
            btnSalir.ForeColor = Color.White;
            btnEncriptar.BackColor = Color.DarkGreen;
            btnEncriptar.ForeColor = Color.White;
            btnActivarAgregar.BackColor = Color.DarkGreen;
            btnActivarAgregar.ForeColor = Color.White;
            btnActivarModificar.BackColor= Color.DarkGreen;
            btnActivarModificar.ForeColor= Color.White;
            btnConfigurarPortapapeles.BackColor = Color.DarkGreen;
            btnConfigurarPortapapeles.ForeColor = Color.White;
            btnInactividad.BackColor = Color.DarkGreen;
            btnInactividad.ForeColor = Color.White;
            btnLlaveMaestra.BackColor = Color.DarkGreen;
            btnLlaveMaestra.ForeColor = Color.White;

            comboBox1.BackColor = Color.DarkGreen;
            comboBox1.ForeColor = Color.White;

            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            label3.ForeColor = Color.White;
            label4.ForeColor = Color.White;
            label5.ForeColor = Color.White;
            label6.ForeColor = Color.White;
            label7.ForeColor = Color.White;
            label8.ForeColor = Color.White;
            label9.ForeColor = Color.White;
            label10.ForeColor = Color.White;
            label11.ForeColor = Color.White;
            label12.ForeColor = Color.White;
            label13.ForeColor = Color.White;

            tb_sitename.Enabled = false;
            tb_username.Enabled = false;
            tb_password.Enabled = false;
            tb_url.Enabled = false;
            tb_notes.Enabled = false;
            tb_extra1.Enabled = false;
            tb_extra2.Enabled = false;
            tb_extra3.Enabled = false;
            tb_extra4.Enabled = false;
            tb_extra5.Enabled = false;
            tb_tags.Enabled = false;
            tb_icon.Enabled = false;
            tb_buscar.Enabled = false;
            comboBox1.Enabled = false;
            btnBuscar.Enabled = false;
            btnActivarAgregar.Enabled = false;
            btnActivarModificar.Enabled = false;
            btnAgregar.Enabled = false;
            btnModificar.Enabled = false;
            btnEncriptar.Enabled = false;

            textBox1.KeyDown += TextBox_KeyDown;
            tb_sitename.KeyDown += TextBox_KeyDown;
            tb_username.KeyDown += TextBox_KeyDown;
            tb_password.KeyDown += TextBox_KeyDown;
            tb_url.KeyDown += TextBox_KeyDown;
            tb_notes.KeyDown += TextBox_KeyDown;
            tb_extra1.KeyDown += TextBox_KeyDown;
            tb_extra2.KeyDown += TextBox_KeyDown;
            tb_extra3.KeyDown += TextBox_KeyDown;
            tb_extra4.KeyDown += TextBox_KeyDown;
            tb_extra5.KeyDown += TextBox_KeyDown;
            tb_tags.KeyDown += TextBox_KeyDown;
            tb_icon.KeyDown += TextBox_KeyDown;
            tb_buscar.KeyDown += TextBox_KeyDown;
            tb_json.KeyDown += TextBox_KeyDown;
        }
        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C)
            {
                clipboardTimer.Stop(); 
                clipboardTimer.Start(); 
            }
        }
        private void ConfigurarClipboardTimer()
        {
            clipboardTimer = new System.Windows.Forms.Timer();
            clipboardTimer.Interval = 5000; 
            clipboardTimer.Tick += ClipboardTimer_Tick;
        }
        private void ClipboardTimer_Tick(object sender, EventArgs e)
        {
            clipboardTimer.Stop(); 
            Clipboard.Clear(); 
        }
        private void ConfigurarInactivityTimer()
        {
            inactivityTimer = new System.Windows.Forms.Timer();
            inactivityTimer.Interval = InactivityLimit;
            inactivityTimer.Tick += InactivityTimer_Tick;

            inactivityTimer.Start();

            this.MouseMove += new MouseEventHandler(ReiniciarInactivityTimer);
            this.KeyDown += new KeyEventHandler(ReiniciarInactivityTimer);
        }
        private void InactivityTimer_Tick(object sender, EventArgs e)
        {
            this.Close();

            inactivityTimer.Stop();
            MessageBox.Show("La sesión ha expirado, Vuelva Pronto");
        }
        private void ReiniciarInactivityTimer(object sender, EventArgs e)
        {
            inactivityTimer.Stop();
            inactivityTimer.Start();
        }
        private void btnImportar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.FilterIndex = 2; 
            openFileDialog.RestoreDirectory = true; 

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
                textBox1.Text = filePath;
            }
            if (string.IsNullOrEmpty(filePath) || !File.Exists(filePath))
            {
                MessageBox.Show("Por favor selecciona un archivo JSON válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            byte[] bytesKey = Encoding.ASCII.GetBytes(key);
            byte[] encryptedData = File.ReadAllBytes(filePath);
            try
            {
                // Desencriptar el archivo con DES
                var decryptedData = DES.Decrypt(encryptedData, bytesKey, removePadding: true);
                string decryptedText = Encoding.UTF8.GetString(decryptedData);

                // Procesar el JSON y desencriptar cada campo "password" con RSA usando RSAHelper
                var jsonObject = JObject.Parse(decryptedText);
                jsonObject = RSAHelper.DecryptPasswords(jsonObject);

                File.WriteAllText(filePath, jsonObject.ToString());

                // Convertir el JObject desencriptado en una lista de objetos Entry para vinculación de datos
                var entries = jsonObject["entries"].ToObject<List<Entry>>();

                // Formatear el texto para el TextBox
                StringBuilder formattedText = new StringBuilder();
                foreach (var entry in entries)
                {
                    formattedText.AppendLine($"Id: {entry.id}");
                    formattedText.AppendLine($"Site Name: {entry.site_name}");
                    formattedText.AppendLine($"Username: {entry.username}");
                    formattedText.AppendLine($"Password: {entry.password}");
                    formattedText.AppendLine($"URL: {entry.url}");
                    formattedText.AppendLine($"Notes: {entry.notes}");

                    foreach (var extra in entry.extra_fields)
                    {
                        formattedText.AppendLine($"{extra.Key}: {extra.Value}");
                    }
                    formattedText.AppendLine("Tags: " + string.Join(", ", entry.tags));
                    formattedText.AppendLine($"Creation Date: {entry.creation_date}");
                    formattedText.AppendLine($"Update Date: {entry.update_date}");
                    formattedText.AppendLine($"Expiration Date: {entry.expiration_date}");
                    formattedText.AppendLine($"Icon: {entry.icon}");
                    formattedText.AppendLine(new string('-', 74));
                }
                tb_json.Text = formattedText.ToString();
                btnActivarAgregar.Enabled = true;
                btnActivarModificar.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error durante la desencriptación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Clear();
            }
        }
        public class Entry
        {
            public int id { get; set; }
            public string site_name { get; set; }
            public string username { get; set; }
            public string password { get; set; }
            public string url { get; set; }
            public string notes { get; set; }
            public Dictionary<string, string> extra_fields { get; set; }
            public List<string> tags { get; set; }
            public DateTime creation_date { get; set; }
            public DateTime update_date { get; set; }
            public DateTime expiration_date { get; set; }
            public string icon { get; set; }
        }
        public class Root
        {
            public List<Entry> entries { get; set; }
        }
        private void btnEncriptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(filePath) || !File.Exists(filePath))
            {
                MessageBox.Show("Por favor selecciona un archivo JSON válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string jsonText = File.ReadAllText(filePath);

                var jsonObject = JObject.Parse(jsonText);
                foreach (var entry in jsonObject["entries"])
                {
                    string plainPassword = entry["password"].ToString();
                    string encryptedPassword = RSAHelper.EncryptPassword(plainPassword);
                    entry["password"] = encryptedPassword;
                }
                string updatedJsonText = jsonObject.ToString();
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Archivos JSON (*.json)|*.json";
                    saveFileDialog.Title = "Guardar archivo JSON encriptado";
                    saveFileDialog.FileName = "archivo_encriptado.json";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(saveFileDialog.FileName, updatedJsonText, Encoding.UTF8);
                        MessageBox.Show("Datos encriptados y guardados en el archivo seleccionado.", "Encriptación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error durante la encriptación: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Leer el archivo JSON existente
                string jsonText = File.ReadAllText(filePath);
                var jsonObject = JObject.Parse(jsonText);

                // Obtener la lista de entradas actuales
                var entries = jsonObject["entries"].ToObject<List<Entry>>();
                int newId = entries.Any() ? entries.Max(e => e.id) + 1 : 0;
                Entry newEntry = new Entry
                {
                    id = newId,  
                    site_name = tb_sitename.Text,
                    username = tb_username.Text,
                    password = tb_password.Text,
                    url = tb_url.Text,
                    notes = tb_notes.Text,
                    extra_fields = new Dictionary<string, string>
            {
                { "extra1", tb_extra1.Text },
                { "extra2", tb_extra2.Text },
                { "extra3", tb_extra3.Text },
                { "extra4", tb_extra4.Text },
                { "extra5", tb_extra5.Text }
            },
                    tags = tb_tags.Text.Split(',').Select(tag => tag.Trim()).ToList(),
                    creation_date = DateTime.Now,
                    update_date = DateTime.Now,
                    expiration_date = DateTime.Now.AddMonths(5), 
                    icon = tb_icon.Text
                };
                entries.Add(newEntry);

                // Actualizar el JSON con la nueva lista de entradas
                jsonObject["entries"] = JToken.FromObject(entries);

                StringBuilder formattedText = new StringBuilder();
                foreach (var entry in entries)
                {
                    formattedText.AppendLine($"Id: {entry.id}");
                    formattedText.AppendLine($"Site Name: {entry.site_name}");
                    formattedText.AppendLine($"Username: {entry.username}");
                    formattedText.AppendLine($"Password: {entry.password}");
                    formattedText.AppendLine($"URL: {entry.url}");
                    formattedText.AppendLine($"Notes: {entry.notes}");

                    foreach (var extra in entry.extra_fields)
                    {
                        formattedText.AppendLine($"{extra.Key}: {extra.Value}");
                    }
                    formattedText.AppendLine("Tags: " + string.Join(", ", entry.tags));
                    formattedText.AppendLine($"Creation Date: {entry.creation_date:dd/MM/yyyy HH:mm:ss}");
                    formattedText.AppendLine($"Update Date: {entry.update_date:dd/MM/yyyy HH:mm:ss}");
                    formattedText.AppendLine($"Expiration Date: {entry.expiration_date:dd/MM/yyyy HH:mm:ss}");
                    formattedText.AppendLine($"Icon: {entry.icon}");
                    formattedText.AppendLine(new string('-', 74)); 
                }

                // Mostrar el texto formateado en tb_json
                tb_json.Text = formattedText.ToString();

                // Guardar el JSON actualizado en el archivo
                File.WriteAllText(filePath, jsonObject.ToString());

                MessageBox.Show("Entrada agregada exitosamente al archivo JSON.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarTextBoxes();
                btnEncriptar.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar la entrada: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnActivarAgregar_Click(object sender, EventArgs e)
        {
            tb_sitename.Enabled = true;
            tb_username.Enabled = true;
            tb_password.Enabled = true;
            tb_url.Enabled = true;
            tb_notes.Enabled = true;
            tb_extra1.Enabled = true;
            tb_extra2.Enabled = true;
            tb_extra3.Enabled = true;
            tb_extra4.Enabled = true;
            tb_extra5.Enabled = true;
            tb_tags.Enabled = true;
            tb_icon.Enabled = true;

            tb_buscar.Enabled = false;
            comboBox1.Enabled = false;
            btnBuscar.Enabled = false;

            btnAgregar.Enabled = true;
            btnModificar.Enabled = false;
        }
        private void btnActivarModificar_Click(object sender, EventArgs e)
        {
            tb_sitename.Enabled = true;
            tb_username.Enabled = true;
            tb_password.Enabled = true;
            tb_url.Enabled = true;
            tb_notes.Enabled = true;
            tb_extra1.Enabled = true;
            tb_extra2.Enabled = true;
            tb_extra3.Enabled = true;
            tb_extra4.Enabled = true;
            tb_extra5.Enabled = true;
            tb_tags.Enabled = true;
            tb_icon.Enabled = true;

            tb_buscar.Enabled = true;
            comboBox1.Enabled = true;
            btnBuscar.Enabled = true;

            btnAgregar.Enabled = false;
            btnModificar.Enabled = true;
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_buscar.Text))
            {
                MessageBox.Show("Por favor, ingrese un término de búsqueda.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un campo de búsqueda.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string searchField = comboBox1.SelectedItem.ToString().ToLower() == "site name" ? "site_name" : "username";
            string searchValue = tb_buscar.Text.ToLower();
            try
            {
                string jsonText = File.ReadAllText(filePath); 
                var jsonObject = JObject.Parse(jsonText);

                JToken matchingEntry = null;
                foreach (var entry in jsonObject["entries"])
                {
                    if (entry[searchField]?.ToString().ToLower() == searchValue)
                    {
                        matchingEntry = entry;
                        break;
                    }
                }
                if (matchingEntry != null)
                {
                    tb_sitename.Text = matchingEntry["site_name"]?.ToString();
                    tb_username.Text = matchingEntry["username"]?.ToString();
                    tb_password.Text = matchingEntry["password"]?.ToString();
                    tb_url.Text = matchingEntry["url"]?.ToString();
                    tb_notes.Text = matchingEntry["notes"]?.ToString();
                    tb_tags.Text = matchingEntry["tags"] != null ? string.Join(", ", matchingEntry["tags"]) : "";
                    tb_icon.Text = matchingEntry["icon"]?.ToString();

                    tb_extra1.Text = matchingEntry["extra_fields"]?["extra1"]?.ToString();
                    tb_extra2.Text = matchingEntry["extra_fields"]?["extra2"]?.ToString();
                    tb_extra3.Text = matchingEntry["extra_fields"]?["extra3"]?.ToString();
                    tb_extra4.Text = matchingEntry["extra_fields"]?["extra4"]?.ToString();
                    tb_extra5.Text = matchingEntry["extra_fields"]?["extra5"]?.ToString();
                }
                else
                {
                    MessageBox.Show("No se encontró ningún registro que coincida con el término de búsqueda.", "Resultado de la búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarTextBoxes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar en el archivo JSON: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimpiarTextBoxes()
        {
            tb_sitename.Clear();
            tb_username.Clear();
            tb_password.Clear();
            tb_url.Clear();
            tb_notes.Clear();
            tb_tags.Clear();
            tb_icon.Clear();
            tb_extra1.Clear();
            tb_extra2.Clear();
            tb_extra3.Clear();
            tb_extra4.Clear();
            tb_extra5.Clear();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(filePath) || !File.Exists(filePath))
            {
                MessageBox.Show("Por favor selecciona un archivo JSON válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(tb_buscar.Text) || comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Por favor ingresa un término de búsqueda y selecciona un campo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Determinar el campo de búsqueda 
            string searchField = comboBox1.SelectedItem.ToString().ToLower() == "site name" ? "site_name" : "username";
            string searchValue = tb_buscar.Text.ToLower();

            try
            {
                // Leer y parsear el JSON desde el archivo
                string jsonText = File.ReadAllText(filePath);
                var jsonObject = JObject.Parse(jsonText);

                // Buscar el registro que coincida con el término de búsqueda
                JToken matchingEntry = null;
                foreach (var entry in jsonObject["entries"])
                {
                    if (entry[searchField]?.ToString().ToLower() == searchValue)
                    {
                        matchingEntry = entry;
                        break;
                    }
                }

                // Si se encontró el registro, actualizar los valores con los datos de los TextBox
                if (matchingEntry != null)
                {
                    matchingEntry["site_name"] = tb_sitename.Text;
                    matchingEntry["username"] = tb_username.Text;
                    matchingEntry["password"] = tb_password.Text;
                    matchingEntry["url"] = tb_url.Text;
                    matchingEntry["notes"] = tb_notes.Text;
                    matchingEntry["tags"] = new JArray(tb_tags.Text.Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries));
                    matchingEntry["icon"] = tb_icon.Text;
                    if (matchingEntry["extra_fields"] == null)
                    {
                        matchingEntry["extra_fields"] = new JObject();
                    }
                    matchingEntry["extra_fields"]["extra1"] = tb_extra1.Text;
                    matchingEntry["extra_fields"]["extra2"] = tb_extra2.Text;
                    matchingEntry["extra_fields"]["extra3"] = tb_extra3.Text;
                    matchingEntry["extra_fields"]["extra4"] = tb_extra4.Text;
                    matchingEntry["extra_fields"]["extra5"] = tb_extra5.Text;

                    DateTime updateDate = DateTime.Now;
                    matchingEntry["update_date"] = updateDate.ToString("dd/MM/yyyy HH:mm:ss");

                    DateTime expirationDate = updateDate.AddMonths(5);
                    matchingEntry["expiration_date"] = expirationDate.ToString("dd/MM/yyyy HH:mm:ss");

                    File.WriteAllText(filePath, jsonObject.ToString());

                    MessageBox.Show("El registro se ha actualizado exitosamente.", "Actualización Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    UpdateTbJson(jsonObject);
                    LimpiarTextBoxes();
                    btnEncriptar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No se encontró ningún registro que coincida con el término de búsqueda.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LimpiarTextBoxes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar el archivo JSON: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateTbJson(JObject jsonObject)
        {
            StringBuilder formattedText = new StringBuilder();
            foreach (var entry in jsonObject["entries"])
            {
                formattedText.AppendLine($"Id: {entry["id"]}");
                formattedText.AppendLine($"Site Name: {entry["site_name"]}");
                formattedText.AppendLine($"Username: {entry["username"]}");
                formattedText.AppendLine($"Password: {entry["password"]}");
                formattedText.AppendLine($"URL: {entry["url"]}");
                formattedText.AppendLine($"Notes: {entry["notes"]}");
                if (entry["extra_fields"] != null)
                {
                    foreach (var extra in entry["extra_fields"])
                    {
                        formattedText.AppendLine($"{extra.Path.Split('.').Last()}: {extra.First}");
                    }
                }
                formattedText.AppendLine("Tags: " + string.Join(", ", entry["tags"]));
                formattedText.AppendLine($"Creation Date: {entry["creation_date"]}");
                formattedText.AppendLine($"Update Date: {entry["update_date"]}");
                formattedText.AppendLine($"Expiration Date: {entry["expiration_date"]}");
                formattedText.AppendLine($"Icon: {entry["icon"]}");
                formattedText.AppendLine(new string('-', 74)); 
            }
            tb_json.Text = formattedText.ToString();
        }
        private void btnLlaveMaestra_Click(object sender, EventArgs e)
        {
            string nuevaLlave = Interaction.InputBox("Ingrese la nueva llave maestra:", "Cambiar Llave Maestra",key);
            if (nuevaLlave.Length == 8)
            {
                key = nuevaLlave; 
                MessageBox.Show("La llave maestra ha sido actualizada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (nuevaLlave.Length > 0) 
            {
                MessageBox.Show("La llave maestra debe tener exactamente 8 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

        }
        private void btnInactividad_Click(object sender, EventArgs e)
        {
            string input = Interaction.InputBox("Ingrese el tiempo de inactividad en segundos:","Configurar Tiempo de Inactividad",
                                                (InactivityLimit / 1000).ToString()); 

            if (int.TryParse(input, out int segundos) && segundos > 0)
            {
                int nuevoIntervalo = segundos * 1000; 
                InactivityLimit = nuevoIntervalo; 

                inactivityTimer.Interval = InactivityLimit;
                inactivityTimer.Stop();
                inactivityTimer.Start();

                MessageBox.Show($"El tiempo de inactividad ha sido configurado a {segundos} segundos.", "Configuración Exitosa",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Por favor ingrese un número válido mayor a 0.","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnConfigurarPortapapeles_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox(
                "Ingrese el tiempo en segundos que los datos deben permanecer en el portapapeles:",
                "Configurar Tiempo del Portapapeles",
                (clipboardTimer.Interval / 1000).ToString()); 

            if (int.TryParse(input, out int seconds))
            {
                if (seconds > 0)
                {
                    clipboardTimer.Interval = seconds * 1000;
                    MessageBox.Show($"El tiempo del portapapeles ha sido configurado a {seconds} segundos.",
                                    "Configuración Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Por favor ingrese un número válido mayor a 0.",
                                    "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (!string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Por favor ingrese un número válido.",
                                "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
