using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace PasswordManager_Winforms
{
    public partial class Form1 : Form
    {
        private byte[] key = new byte[32];
        private string encryptionKey;
        private byte[] iv = new byte[16];
        private string initializationVector;

        public Form1()
        {
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(key);
                encryptionKey = Convert.ToBase64String(key);
                rng.GetBytes(iv);
                initializationVector = Convert.ToBase64String(iv);
            }

            InitializeComponent();
        }

        private string _password;
        private string _encryptedPassword;

        private void encryptButton_Click(object sender, EventArgs e)
        {
            if (_password != null && !string.IsNullOrEmpty(_password))
            {
                _encryptedPassword = EncryptPassword(_password);
                encryptedPasswordTextBox.Text = _encryptedPassword;
            }
            else
            {
                MessageBox.Show("Пожалуйста, сначала сгенерируйте пароль.");
            }
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            _password = GeneratePassword();
            resultTextBox.Text = _password;
        }

        private string GeneratePassword()
        {
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                byte[] randomBytes = new byte[32];
                rng.GetBytes(randomBytes);
                return Convert.ToBase64String(randomBytes);
            }
        }

        private string EncryptPassword(string password)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = Convert.FromBase64String(encryptionKey);
                aes.IV = Convert.FromBase64String(initializationVector);
                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
                byte[] encryptedBytes = encryptor.TransformFinalBlock(Encoding.UTF8.GetBytes(password), 0, password.Length);
                return Convert.ToBase64String(encryptedBytes);
            }
        }
    }
}