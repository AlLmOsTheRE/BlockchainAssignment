using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BlockchainAssignment
{
    internal class Transaction
    {
        string hash;
        string signature;
        string senderAddress;
        string recipientAddress;
        DateTime timestamp;
        double amount;
        double fee;

        public Transaction(string from, string to, double amount, double fee, string privateKey)
        {
            this.senderAddress = from;
            this.recipientAddress = to;
            this.amount = amount;
            this.fee = fee;
            this.timestamp = DateTime.Now;
            this.hash = CreateHash();
            this.signature = Wallet.Wallet.CreateSignature(from, privateKey, this.hash);
        }

        // Same logic used in Block.cs
        public string CreateHash()
        {
            string hash = string.Empty;
            SHA256 hasher = SHA256.Create();

            // Hash all properties
            string input = timestamp.ToString() + senderAddress + recipientAddress + amount.ToString() + fee.ToString();
            byte[] hashByte = hasher.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Convert Hash from Byte array to String
            foreach (byte x in hashByte)
            {
                hash += string.Format("{0:x2}", x);
            }

            return hash;
        }

        public override string ToString()
        {
            return "Transaction Hash: " + hash
                + "\nDigital signature: " + signature
                + "\nTimestamp: " + timestamp.ToString()
                + "\nTransferred: " + amount.ToString() + " ඞ"
                + "\nFees: " + fee.ToString()
                + "\nSender address: " + senderAddress
                + "\nRecipient address: " + recipientAddress
                + "\n";
        }
    }
}
