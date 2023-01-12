using System;
using System.Collections.Generic;
using System.Deployment.Application;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TanksGame_V4.Interface;

namespace TanksGame_V4.GameServer
{
    internal class Host
    {
        private TcpListener _listener ;
        private TcpClient communicator;
        public String _gameData { get; set; }
        private Thread _t;
        private bool communicating;
        private NetworkStream _stream;
        //private StreamReader[] _streamrw;
        //private StreamWriter[] _streamwr;
        private StreamReader _streamReader;
        private StreamWriter _streamWriter;
        private int connections;
        private int playerNumber;
        private bool write;
        private bool read;
        private bool start;
        public Host(int _portNr, int _playerNr)
        {
            _listener = TcpListener.Create(_portNr);
            _listener.Start();
            //communicator = new TcpClient[_playerNr];
            //_streamrw = new StreamReader[_playerNr];
            //_streamwr = new StreamWriter[_playerNr];
            _t = new Thread(new ThreadStart(Receive_Send));
            communicating = true;
            start = true;
            write = true;
            read = false;
            connections = 1;
            playerNumber = _playerNr;
            communicator = _listener.AcceptTcpClient();
            _streamReader = new StreamReader(communicator.GetStream());
            _streamWriter = new StreamWriter(communicator.GetStream());
            _t.Start();
            _listener.Stop();
        }

        private void Receive_Send()
        {

            while (communicating)
            {
                //if (connections != playerNumber)
                //{
                //    communicator[connections] = _host.AcceptTcpClient();
                //    _streamrw[connections] = new StreamReader(communicator[connections].GetStream());
                //    _streamwr[connections] = new StreamWriter(communicator[connections].GetStream());
                //    connections++;
                //}
                //else
                //{
                //    GameRender gameRender = new GameRender(_gameForm, playerNumber);
                //}
                if(start)
                {
                    start = false;
                }
                if(write)
                {

                }
                if(read)
                {

                }
            }
        }
    }
}
