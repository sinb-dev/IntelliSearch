using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;

namespace IntelliSearch
{
    class Client : IIntelliSearchClient
    {
            public TcpClient client = new TcpClient();

        public string Check(string word)
        {
            var ip = "127.0.0.1";
            var port = 1983;
            client.Connect(ip, port);
            return OnConnected(word);
        }

        public string OnConnected(string word)
        {
            if (client.Connected)
            {
                byte[] byteArr = Encoding.UTF8.GetBytes(word);
                NetworkStream stream = client.GetStream();
                StreamWriter writer = new StreamWriter(stream);
                writer.Write(byteArr);

                StreamReader reader = new StreamReader(stream);
                List<byte> bytesRead = new List<byte>();
                while (reader.Peek() >= Byte.MinValue)
                {
                    bytesRead.Add((byte) reader.Read());
                }

                return Encoding.UTF8.GetString(bytesRead.ToArray());
            }
            else
            {
                return null;
            }
        }
    }
}
