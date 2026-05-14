using System.Security.Cryptography;

namespace BloodBankApp.Services
{
    public class AuthService
    {
        /// <summary>
        /// Hashes a password using PBKDF2 with a random salt.
        /// </summary>
        public string HashPassword(string password)
        {
            // Use the modern RandomNumberGenerator
            byte[] salt = RandomNumberGenerator.GetBytes(16);

            // Create the PBKDF2 hash
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000, HashAlgorithmName.SHA256);
            byte[] hash = pbkdf2.GetBytes(32); // 32-byte hash

            // Combine into a single byte array: 1 byte (version) + 16 bytes (salt) + 32 bytes (hash)
            byte[] hashBytes = new byte[49];
            hashBytes[0] = (byte)0x01; // Version byte
            Buffer.BlockCopy(salt, 0, hashBytes, 1, 16);
            Buffer.BlockCopy(hash, 0, hashBytes, 17, 32);

            // Return as a Base64 string
            return Convert.ToBase64String(hashBytes);
        }

        /// <summary>
        /// Verifies a password against a stored hash.
        /// </summary>
        public bool VerifyPassword(string password, string storedHash)
        {
            try
            {
                // Decode the Base64 string
                var hashBytes = Convert.FromBase64String(storedHash);

                // Check the version byte
                if (hashBytes[0] != 0x01)
                {
                    return false; // Unknown hash version
                }

                // Extract the salt (16 bytes, starting at index 1)
                var salt = new byte[16];
                Buffer.BlockCopy(hashBytes, 1, salt, 0, 16);

                // Extract the stored hash (32 bytes, starting at index 17)
                var storedSubkey = new byte[32];
                Buffer.BlockCopy(hashBytes, 17, storedSubkey, 0, 32);

                // Re-hash the provided password with the same salt and parameters
                var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000, HashAlgorithmName.SHA256);
                byte[] newSubkey = pbkdf2.GetBytes(32);

                // Compare the two hashes securely
                return newSubkey.SequenceEqual(storedSubkey);
            }
            catch
            {
                // Invalid hash format, etc.
                return false;
            }
        }
    }
}

