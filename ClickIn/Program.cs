﻿using System;
using System.Net.Sockets;
using System.Threading;

public class Program
{

    public static void start(String Option)
    {
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                Connect("192.168.1.147", "Hello I'm Device 1...", Option);
            }).Start();



            Console.ReadLine();
        }

        void Connect(String server, String message, String choice)
        {
            try
            {
                Int32 port = 13000;
                TcpClient client = new TcpClient(server, port);

                NetworkStream stream = client.GetStream();


                message = message + ":" + choice;
                // Translate the Message into ASCII.
                Byte[] data = System.Text.Encoding.ASCII.GetBytes(message);

                // Send the message to the connected TcpServer. 
                stream.Write(data, 0, data.Length);
                Console.WriteLine("Sent: {0}", message);

                // Bytes Array to receive Server Response.
                data = new Byte[256];
                String response = String.Empty;

                // Read the Tcp Server Response Bytes.
                Int32 bytes = stream.Read(data, 0, data.Length);
                response = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
                Console.WriteLine("Received: {0}", response);

                Thread.Sleep(2000);
                

                stream.Close();
                client.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: {0}", e);
            }

            Console.Read();
        }
    }
}