
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TanksGame.GameServer
{
    internal class Client
    {
        private TcpClient communicator;
        public String _gameData { get; set; }
        private Thread _t;
        private bool communicating;
        //private StreamReader[] _streamrw;
        //private StreamWriter[] _streamwr;
        private StreamReader _streamReader;
        private StreamWriter _streamWriter;
        private bool write;
        private bool read;
        private bool start;
        public Client(String host_ip,int _portNr, int _playerNr)
        {
            communicating = true;
            start = true;
            write = true;
            read = false;
            communicator = new TcpClient();
            _streamReader = new StreamReader(communicator.GetStream());
            _streamWriter = new StreamWriter(communicator.GetStream());
            _t = new Thread(new ThreadStart(Receive_Send));
            _t.Start();
        }

        private void Receive_Send()
        {

            while (communicating)
            {
                if (start)
                {
                    start = false;
                }
                if (write)
                {

                }
                if (read)
                {

                }
            }
        }
    }
}
