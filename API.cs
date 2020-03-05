using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace IntelliSearch
{
    class API
    {
        const int PORT_NUM = 1983;
        private TcpListener listener;
        private Socket socket;

        public void Server()
        {
            ///Listen at the specified port num
            listener = new TcpListener(IPAddress.Any, PORT_NUM);
            listener.Start();

            while (true)
            {
                ///Incoming client connected
                TcpClient client = listener.AcceptTcpClient();

                ///Get the incoming data through a network stream
                NetworkStream nwStream = client.GetStream();
                byte[] buffer = new byte[client.ReceiveBufferSize];

                ///Read incoming stream
                int bytesRead = nwStream.Read(buffer, 0, client.ReceiveBufferSize);

                ///Convert the data recieved into a string
                string dataReceived = Encoding.UTF8.GetString(buffer, 0, bytesRead);


                ///Write back to client
                nwStream.Write(buffer, 0, bytesRead);
                client.Close();

            }
            listener.Stop();

        }
    }
}