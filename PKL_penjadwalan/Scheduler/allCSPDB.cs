using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AprioriGA
{
    public class allCSPDB
    {
        public static List<CSP2> hasil;

        public allCSPDB()
        {
            hasil = new List<CSP2>();

            //1
            List<Task<CSP2>> lt = new List<Task<CSP2>>();
            lt.Add(Task.Run<CSP2>(() => new CSP2("X MIA1", 1, 1, 3)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("X MIA1", 1, 4, 7)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("X MIA1", 1, 8, 10)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("X MIA2", 1, 1, 3)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("X MIA2", 1, 4, 7)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("X MIA2", 1, 8, 10)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("X MIA3", 1, 1, 3)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("X MIA3", 1, 4, 7)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("X MIA3", 1, 8, 10)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("X MIA4", 1, 1, 3)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("X MIA4", 1, 4, 7)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("X MIA4", 1, 8, 10)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("X IIS1", 1, 1, 3)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("X IIS1", 1, 4, 7)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("X IIS1", 1, 8, 10)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("X IIS2", 1, 1, 3)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("X IIS2", 1, 4, 7)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("X IIS2", 1, 8, 10)));

            lt.Add(Task.Run<CSP2>(() => new CSP2("XI MIA1", 1, 1, 3)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XI MIA1", 1, 4, 7)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XI MIA1", 1, 8, 10)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XI MIA2", 1, 1, 3)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XI MIA2", 1, 4, 7)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XI MIA2", 1, 8, 10)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XI MIA3", 1, 1, 3)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XI MIA3", 1, 4, 7)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XI MIA3", 1, 8, 10)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XI MIA4", 1, 1, 3)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XI MIA4", 1, 4, 7)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XI MIA4", 1, 8, 10)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XI IIS1", 1, 1, 3)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XI IIS1", 1, 4, 7)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XI IIS1", 1, 8, 10)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XI IIS2", 1, 1, 3)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XI IIS2", 1, 4, 7)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XI IIS2", 1, 8, 10)));

            lt.Add(Task.Run<CSP2>(() => new CSP2("XII MIA1", 1, 1, 3)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XII MIA1", 1, 4, 7)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XII MIA1", 1, 8, 10)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XII MIA2", 1, 1, 3)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XII MIA2", 1, 4, 7)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XII MIA2", 1, 8, 10)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XII MIA3", 1, 1, 3)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XII MIA3", 1, 4, 7)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XII MIA3", 1, 8, 10)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XII MIA4", 1, 1, 3)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XII MIA4", 1, 4, 7)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XII MIA4", 1, 8, 10)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XII IIS1", 1, 1, 3)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XII IIS1", 1, 4, 7)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XII IIS1", 1, 8, 10)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XII IIS2", 1, 1, 3)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XII IIS2", 1, 4, 7)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XII IIS2", 1, 8, 10)));

            //2
            lt.Add(Task.Run<CSP2>(() => new CSP2("X MIA1", 2, 1, 3)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("X MIA1", 2, 4, 7)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("X MIA1", 2, 8, 10)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("X MIA2", 2, 1, 3)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("X MIA2", 2, 4, 7)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("X MIA2", 2, 8, 10)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("X MIA3", 2, 1, 3)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("X MIA3", 2, 4, 7)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("X MIA3", 2, 8, 10)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("X MIA4", 2, 1, 3)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("X MIA4", 2, 4, 7)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("X MIA4", 2, 8, 10)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("X IIS1", 2, 1, 3)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("X IIS1", 2, 4, 7)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("X IIS1", 2, 8, 10)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("X IIS2", 2, 1, 3)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("X IIS2", 2, 4, 7)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("X IIS2", 2, 8, 10)));

            lt.Add(Task.Run<CSP2>(() => new CSP2("XI MIA1", 2, 1, 3)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XI MIA1", 2, 4, 7)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XI MIA1", 2, 8, 10)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XI MIA2", 2, 1, 3)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XI MIA2", 2, 4, 7)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XI MIA2", 2, 8, 10)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XI MIA3", 2, 1, 3)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XI MIA3", 2, 4, 7)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XI MIA3", 2, 8, 10)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XI MIA4", 2, 1, 3)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XI MIA4", 2, 4, 7)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XI MIA4", 2, 8, 10)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XI IIS1", 2, 1, 3)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XI IIS1", 2, 4, 7)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XI IIS1", 2, 8, 10)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XI IIS2", 2, 1, 3)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XI IIS2", 2, 4, 7)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XI IIS2", 2, 8, 10)));

            lt.Add(Task.Run<CSP2>(() => new CSP2("XII MIA1", 2, 1, 3)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XII MIA1", 2, 4, 7)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XII MIA1", 2, 8, 10)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XII MIA2", 2, 1, 3)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XII MIA2", 2, 4, 7)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XII MIA2", 2, 8, 10)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XII MIA3", 2, 1, 3)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XII MIA3", 2, 4, 7)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XII MIA3", 2, 8, 10)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XII MIA4", 2, 1, 3)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XII MIA4", 2, 4, 7)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XII MIA4", 2, 8, 10)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XII IIS1", 2, 1, 3)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XII IIS1", 2, 4, 7)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XII IIS1", 2, 8, 10)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XII IIS2", 2, 1, 3)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XII IIS2", 2, 4, 7)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XII IIS2", 2, 8, 10)));

            //3
            lt.Add(Task.Run<CSP2>(() => new CSP2("X MIA1", 3, 1, 3)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("X MIA1", 3, 4, 7)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("X MIA1", 3, 8, 10)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("X MIA2", 3, 1, 3)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("X MIA2", 3, 4, 7)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("X MIA2", 3, 8, 10)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("X MIA3", 3, 1, 3)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("X MIA3", 3, 4, 7)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("X MIA3", 3, 8, 10)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("X MIA4", 3, 1, 3)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("X MIA4", 3, 4, 7)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("X MIA4", 3, 8, 10)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("X IIS1", 3, 1, 3)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("X IIS1", 3, 4, 7)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("X IIS1", 3, 8, 10)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("X IIS2", 3, 1, 3)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("X IIS2", 3, 4, 7)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("X IIS2", 3, 8, 10)));

            lt.Add(Task.Run<CSP2>(() => new CSP2("XI MIA1", 3, 1, 3)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XI MIA1", 3, 4, 7)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XI MIA1", 3, 8, 10)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XI MIA2", 3, 1, 3)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XI MIA2", 3, 4, 7)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XI MIA2", 3, 8, 10)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XI MIA3", 3, 1, 3)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XI MIA3", 3, 4, 7)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XI MIA3", 3, 8, 10)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XI MIA4", 3, 1, 3)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XI MIA4", 3, 4, 7)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XI MIA4", 3, 8, 10)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XI IIS1", 3, 1, 3)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XI IIS1", 3, 4, 7)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XI IIS1", 3, 8, 10)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XI IIS2", 3, 1, 3)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XI IIS2", 3, 4, 7)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XI IIS2", 3, 8, 10)));

            lt.Add(Task.Run<CSP2>(() => new CSP2("XII MIA1", 3, 1, 3)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XII MIA1", 3, 4, 7)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XII MIA1", 3, 8, 10)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XII MIA2", 3, 1, 3)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XII MIA2", 3, 4, 7)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XII MIA2", 3, 8, 10)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XII MIA3", 3, 1, 3)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XII MIA3", 3, 4, 7)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XII MIA3", 3, 8, 10)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XII MIA4", 3, 1, 3)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XII MIA4", 3, 4, 7)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XII MIA4", 3, 8, 10)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XII IIS1", 3, 1, 3)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XII IIS1", 3, 4, 7)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XII IIS1", 3, 8, 10)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XII IIS2", 3, 1, 3)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XII IIS2", 3, 4, 7)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XII IIS2", 3, 8, 10)));

            //4
            lt.Add(Task.Run<CSP2>(() => new CSP2("X MIA1", 4, 1, 3)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("X MIA1", 4, 4, 7)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("X MIA1", 4, 8, 10)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("X MIA2", 4, 1, 3)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("X MIA2", 4, 4, 7)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("X MIA2", 4, 8, 10)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("X MIA3", 4, 1, 3)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("X MIA3", 4, 4, 7)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("X MIA3", 4, 8, 10)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("X MIA4", 4, 1, 3)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("X MIA4", 4, 4, 7)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("X MIA4", 4, 8, 10)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("X IIS1", 4, 1, 3)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("X IIS1", 4, 4, 7)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("X IIS1", 4, 8, 10)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("X IIS2", 4, 1, 3)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("X IIS2", 4, 4, 7)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("X IIS2", 4, 8, 10)));

            lt.Add(Task.Run<CSP2>(() => new CSP2("XI MIA1", 4, 1, 3)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XI MIA1", 4, 4, 7)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XI MIA1", 4, 8, 10)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XI MIA2", 4, 1, 3)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XI MIA2", 4, 4, 7)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XI MIA2", 4, 8, 10)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XI MIA3", 4, 1, 3)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XI MIA3", 4, 4, 7)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XI MIA3", 4, 8, 10)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XI MIA4", 4, 1, 3)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XI MIA4", 4, 4, 7)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XI MIA4", 4, 8, 10)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XI IIS1", 4, 1, 3)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XI IIS1", 4, 4, 7)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XI IIS1", 4, 8, 10)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XI IIS2", 4, 1, 3)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XI IIS2", 4, 4, 7)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XI IIS2", 4, 8, 10)));

            lt.Add(Task.Run<CSP2>(() => new CSP2("XII MIA1", 4, 1, 3)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XII MIA1", 4, 4, 7)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XII MIA1", 4, 8, 10)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XII MIA2", 4, 1, 3)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XII MIA2", 4, 4, 7)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XII MIA2", 4, 8, 10)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XII MIA3", 4, 1, 3)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XII MIA3", 4, 4, 7)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XII MIA3", 4, 8, 10)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XII MIA4", 4, 1, 3)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XII MIA4", 4, 4, 7)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XII MIA4", 4, 8, 10)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XII IIS1", 4, 1, 3)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XII IIS1", 4, 4, 7)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XII IIS1", 4, 8, 10)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XII IIS2", 4, 1, 3)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XII IIS2", 4, 4, 7)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XII IIS2", 4, 8, 10)));

            //5
            lt.Add(Task.Run<CSP2>(() => new CSP2("X MIA1", 5, 1, 3)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("X MIA1", 5, 7, 8)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("X MIA2", 5, 1, 3)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("X MIA2", 5, 7, 8)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("X MIA3", 5, 1, 3)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("X MIA3", 5, 7, 8)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("X MIA4", 5, 1, 3)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("X MIA4", 5, 7, 8)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("X IIS1", 5, 1, 3)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("X IIS1", 5, 7, 8)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("X IIS2", 5, 1, 3)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("X IIS2", 5, 7, 8)));

            lt.Add(Task.Run<CSP2>(() => new CSP2("XI MIA1", 5, 1, 3)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XI MIA1", 5, 4, 5)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XI MIA2", 5, 1, 3)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XI MIA2", 5, 4, 5)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XI MIA3", 5, 1, 3)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XI MIA3", 5, 4, 5)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XI MIA4", 5, 1, 3)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XI MIA4", 5, 4, 5)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XI IIS1", 5, 1, 3)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XI IIS1", 5, 4, 5)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XI IIS2", 5, 1, 3)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XI IIS2", 5, 4, 5)));

            lt.Add(Task.Run<CSP2>(() => new CSP2("XII MIA1", 5, 1, 3)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XII MIA1", 5, 4, 5)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XII MIA1", 5, 7, 8)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XII MIA2", 5, 1, 3)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XII MIA2", 5, 4, 5)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XII MIA2", 5, 7, 8)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XII MIA3", 5, 1, 3)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XII MIA3", 5, 4, 5)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XII MIA3", 5, 7, 8)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XII MIA4", 5, 1, 3)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XII MIA4", 5, 4, 5)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XII MIA4", 5, 7, 8)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XII IIS1", 5, 1, 3)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XII IIS1", 5, 4, 5)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XII IIS1", 5, 7, 8)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XII IIS2", 5, 1, 3)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XII IIS2", 5, 4, 5)));
            lt.Add(Task.Run<CSP2>(() => new CSP2("XII IIS2", 5, 7, 8)));
            Task.WaitAll(lt.ToArray());
            for (int i = 0; i < lt.Count; i++)
            {
                hasil.Add(lt[i].Result);
            }
        }

        public static void instalkelas()
        {
            hasil = new List<CSP2>();

            List<Task<CSP2>> lt = new List<Task<CSP2>>();
            for (int i = 0; i < ClassRoom.data.Count; i++)
            {
                String nama = ClassRoom.data.ElementAt(i).name;
                Console.WriteLine(ClassRoom.data.ElementAt(i).name);
                if (ClassRoom.data.ElementAt(i).generation == 10)
                {
                    lt.Add(Task.Run<CSP2>(() => new CSP2(nama, 1, 1, 3)));
                    lt.Add(Task.Run<CSP2>(() => new CSP2(nama, 1, 4, 7)));
                    lt.Add(Task.Run<CSP2>(() => new CSP2(nama, 1, 8, 10)));
                    lt.Add(Task.Run<CSP2>(() => new CSP2(nama, 2, 1, 3)));
                    lt.Add(Task.Run<CSP2>(() => new CSP2(nama, 2, 4, 7)));
                    lt.Add(Task.Run<CSP2>(() => new CSP2(nama, 2, 8, 10)));
                    lt.Add(Task.Run<CSP2>(() => new CSP2(nama, 3, 1, 3)));
                    lt.Add(Task.Run<CSP2>(() => new CSP2(nama, 3, 4, 7)));
                    lt.Add(Task.Run<CSP2>(() => new CSP2(nama, 3, 8, 10)));
                    lt.Add(Task.Run<CSP2>(() => new CSP2(nama, 4, 1, 3)));
                    lt.Add(Task.Run<CSP2>(() => new CSP2(nama, 4, 4, 7)));
                    lt.Add(Task.Run<CSP2>(() => new CSP2(nama, 4, 8, 10)));

                    lt.Add(Task.Run<CSP2>(() => new CSP2(nama, 5, 1, 3)));
                    lt.Add(Task.Run<CSP2>(() => new CSP2(nama, 5, 7, 8)));
                }
                else if (ClassRoom.data.ElementAt(i).generation == 11)
                {
                    lt.Add(Task.Run<CSP2>(() => new CSP2(nama, 1, 1, 3)));
                    lt.Add(Task.Run<CSP2>(() => new CSP2(nama, 1, 4, 7)));
                    lt.Add(Task.Run<CSP2>(() => new CSP2(nama, 1, 8, 11)));

                    lt.Add(Task.Run<CSP2>(() => new CSP2(nama, 2, 1, 3)));
                    lt.Add(Task.Run<CSP2>(() => new CSP2(nama, 2, 4, 7)));
                    lt.Add(Task.Run<CSP2>(() => new CSP2(nama, 2, 8, 10)));

                    lt.Add(Task.Run<CSP2>(() => new CSP2(nama, 3, 1, 3)));
                    lt.Add(Task.Run<CSP2>(() => new CSP2(nama, 3, 4, 7)));
                    lt.Add(Task.Run<CSP2>(() => new CSP2(nama, 3, 8, 11)));

                    lt.Add(Task.Run<CSP2>(() => new CSP2(nama, 4, 1, 3)));
                    lt.Add(Task.Run<CSP2>(() => new CSP2(nama, 4, 4, 7)));
                    lt.Add(Task.Run<CSP2>(() => new CSP2(nama, 4, 8, 10)));

                    lt.Add(Task.Run<CSP2>(() => new CSP2(nama, 5, 1, 3)));
                    lt.Add(Task.Run<CSP2>(() => new CSP2(nama, 5, 4, 5)));
                }
                else
                {
                    lt.Add(Task.Run<CSP2>(() => new CSP2(nama, 1, 1, 3)));
                    lt.Add(Task.Run<CSP2>(() => new CSP2(nama, 1, 4, 7)));
                    lt.Add(Task.Run<CSP2>(() => new CSP2(nama, 1, 8, 10)));
                    lt.Add(Task.Run<CSP2>(() => new CSP2(nama, 2, 1, 3)));
                    lt.Add(Task.Run<CSP2>(() => new CSP2(nama, 2, 4, 7)));
                    lt.Add(Task.Run<CSP2>(() => new CSP2(nama, 2, 8, 10)));
                    lt.Add(Task.Run<CSP2>(() => new CSP2(nama, 3, 1, 3)));
                    lt.Add(Task.Run<CSP2>(() => new CSP2(nama, 3, 4, 7)));
                    lt.Add(Task.Run<CSP2>(() => new CSP2(nama, 3, 8, 10)));
                    lt.Add(Task.Run<CSP2>(() => new CSP2(nama, 4, 1, 3)));
                    lt.Add(Task.Run<CSP2>(() => new CSP2(nama, 4, 4, 7)));
                    lt.Add(Task.Run<CSP2>(() => new CSP2(nama, 4, 8, 10)));

                    lt.Add(Task.Run<CSP2>(() => new CSP2(nama, 5, 1, 3)));
                    lt.Add(Task.Run<CSP2>(() => new CSP2(nama, 5, 4, 5)));
                    lt.Add(Task.Run<CSP2>(() => new CSP2(nama, 5, 7, 8)));
                }
            }
            Task.WaitAll(lt.ToArray());
            for (int i = 0; i < lt.Count; i++)
            {
                hasil.Add(lt[i].Result);
            }
        }
        public static void initiate()
        {
            new allCSPDB();
        }
    }
}