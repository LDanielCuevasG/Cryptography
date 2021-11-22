namespace Cryptography.Console
{
    public partial class Start : Form
    {

        private Dictionary<string, CryptographyClient> clients;


        public Start()
        {
            InitializeComponent();

            clients = new Dictionary<string, CryptographyClient>();
            clients.Add("AES", new AESClient());
            clients.Add("RSA", new RSAClient());

            foreach (KeyValuePair<string, CryptographyClient> pair in clients)  {
                AlgorithmCombobox.Items.Add(pair.Key);
            }
            AlgorithmCombobox.SelectedIndex = 0;

            ActionCombobox.Items.Add("Encrypt");
            ActionCombobox.Items.Add("Decrypt");
            ActionCombobox.SelectedIndex = 0;
        }


        private void LoadKeys_Click(object sender, EventArgs e)
        {
            if (ValidateAlgorithm() == false) {
                return;
            }

            FolderBrowserDialog destination = new FolderBrowserDialog();
            if (destination.ShowDialog() == DialogResult.OK)
            {
                string path = destination.SelectedPath;
                string? algorithm = AlgorithmCombobox.SelectedItem.ToString();
                if (algorithm != null)
                {
                    try {
                        CryptographyClient client = clients[algorithm];
                        client.LoadKeys(path);
                        MessageBox.Show("Keys loaded", "Successful");
                    }
                    catch (Exception ex) {
                        MessageBox.Show("An unexpected error has occurred", "Error");
                    }
                }
            }
        }

        private void GenerateKeys_Click(object sender, EventArgs e)
        {
            if (ValidateAlgorithm() == false) {
                return;
            }

            FolderBrowserDialog destination = new FolderBrowserDialog();
            if (destination.ShowDialog() == DialogResult.OK)
            {
                string path = destination.SelectedPath;
                string? algorithm = AlgorithmCombobox.SelectedItem.ToString();
                if (algorithm != null)
                {
                    CryptographyClient client = clients[algorithm];
                    client.GenerateKeys(path);
                    client.LoadKeys(path);

                    MessageBox.Show("Keys generated and loaded", "Successful");
                }
            }
        }

        private void Execute_Click(object sender, EventArgs e)
        {
            string text = TextTextbox.Text;
            if (String.IsNullOrWhiteSpace(text)) {
                MessageBox.Show("Type text to continue", "Error");
                return;
            }

            try 
            {
                string? algorithm = AlgorithmCombobox.SelectedItem.ToString();
                if (algorithm != null)
                {
                    CryptographyClient client = clients[algorithm];
                    string result = String.Empty;

                    string? action = ActionCombobox.SelectedItem.ToString();
                    if (action != null)
                    {
                        if (action.Equals("Encrypt")) {
                            result = client.Encrypt(text);
                        }
                        else if (action.Equals("Decrypt")) {
                            result = client.Decrypt(text);
                        }
                        ResultTextbox.Text = result;
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show("An unexpected error has occurred", "Error");
            }
        }

        private bool ValidateAlgorithm() 
        {
            object algorithmItem = AlgorithmCombobox.SelectedItem;
            object actionItem = ActionCombobox.SelectedItem;

            if (algorithmItem == null || actionItem == null)
            {
                MessageBox.Show("Select an algorithm and action to continue", "Error");
                return false;
            }
            return true;
        }

    }
}