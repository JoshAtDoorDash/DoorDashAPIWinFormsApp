using System.Text.Json;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;

namespace DoorDashAPIWinFormsApp
{
    public partial class JwtCreateForm : Form
    {
        readonly Dictionary<string, string> JwtHeaderTemplate;
        readonly Dictionary<string, string> JwtPayloadTemplate;
        readonly JsonSerializerOptions JsonSerializerOptionsDefault; 

        public JwtCreateForm()
        {
            InitializeComponent();

            JwtHeaderTemplate = new Dictionary<string, string>
            {
              {"alg", "HS256"},
              {"typ", "JWT"},
              {"dd-ver", "DD-JWT-V1"}
            };

            JwtPayloadTemplate = new Dictionary<string, string>
            {
              {"aud", "doordash"},
              {"iss", "DEVELOPER_ID"},
              {"kid", "KEY_ID"},
              {"iat", "ISSUE_AT"},
              {"exp", "EXPIRATION"}
            };

            JsonSerializerOptionsDefault = new JsonSerializerOptions
            {
                WriteIndented = true
            };
        }

        private void JwtCreateForm_Load(object sender, EventArgs e)
        {
            SetDefaultValues();
            UpdateJwtButton.Select();
        }

        private void SetDefaultValues()
        {
            JwtHeaderTextBox.Text = JsonSerializer.Serialize(JwtHeaderTemplate, JsonSerializerOptionsDefault);
            JwtPayloadTextBox.Text = JsonSerializer.Serialize(JwtPayloadTemplate, JsonSerializerOptionsDefault);
            JwtTextBox.Text = string.Empty;
        }

        private void UpdateJWT()
        {
            // Do not run update if user provided values are note valid.
            // Note, function doesn't test if values provided are correct size. 
            if (!UserProvidedValuesValid())
            {
                SetDefaultValues();
                return; 
            }                
                
            var decodedSecret = Base64UrlEncoder.DecodeBytes(SigningSecretTextBox.Text.Trim());
            var securityKey = new SymmetricSecurityKey(decodedSecret);
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            var algorithmMap = new Dictionary<string, string> { { "alg", "HS256" } };
            var tokenType = "JWT";
            var doorDashHeader = new Dictionary<string, object> { { "dd-ver", "DD-JWT-V1" } };
            var jwtHeader = new JwtHeader(credentials, algorithmMap, tokenType, doorDashHeader);

            JwtHeaderTextBox.Text = JsonSerializer.Serialize(jwtHeader, JsonSerializerOptionsDefault);

            // creates new JWT Payload that expires in 30 minutes
            var jwtPayload = new JwtPayload(
                issuer: DeveloperIdTextBox.Text.Trim(),
                audience: "doordash",
                claims: new List<Claim> { new Claim("kid", KeyIdTextBox.Text.Trim()) },
                notBefore: null,
                expires: System.DateTime.UtcNow.AddSeconds(1800),
                issuedAt: System.DateTime.UtcNow);

            JwtPayloadTextBox.Text = JsonSerializer.Serialize(jwtPayload, JsonSerializerOptionsDefault);

            // sign and create new token
            var securityToken = new JwtSecurityToken(jwtHeader, jwtPayload);
            var jwt = new JwtSecurityTokenHandler().WriteToken(securityToken);

            JwtSignatureTextBox.Text = JwtSignature(jwt);
            JwtTextBox.Text = jwt;
        }

        private void UpdateJwtButton_Click(object sender, EventArgs e)
        {
            UpdateJWT();
        }

        // Returns true if 3 user provided values are not null, empty or just whitespace chars.
        private bool UserProvidedValuesValid() => 
            !string.IsNullOrWhiteSpace(KeyIdTextBox.Text) &&
            !string.IsNullOrWhiteSpace(DeveloperIdTextBox.Text) &&
            !string.IsNullOrWhiteSpace(SigningSecretTextBox.Text);

        // Returns signauture from JWT string provided.
        // Empty string returned if null, empty, or invalid JWT provided.
        private string JwtSignature(string jwt)
        {
            if (jwt.IsNullOrEmpty()) return string.Empty;

            string[] parts = jwt.Split('.');

            if (parts.Length != 3) return string.Empty;

            return parts[2];
        }

        private void DeveloperIdTextBox_Leave(object sender, EventArgs e)
        {
            UpdateJWT();
        }

        private void KeyIdTextBox_Leave(object sender, EventArgs e)
        {
            UpdateJWT();
        }

        private void SigningSecretTextBox_Leave(object sender, EventArgs e)
        {
            UpdateJWT();
        }
    }
}