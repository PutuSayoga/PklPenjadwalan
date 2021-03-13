using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprioriGA
{
    public class Population1
    {
        public float crossoverratio;
        public float mutationratio;
        public Chromosome1[] poparr;

        static Random rnd = new Random();

        public Population1(int size, float cross, float mutationr)
        {
            this.crossoverratio = cross;
            this.mutationratio = mutationr;
            this.poparr = new Chromosome1[size];
            List<Task<Chromosome1>> has = new List<Task<Chromosome1>>();
            for (int i = 0; i < size; i++)
            {
                has.Add(Task.Run<Chromosome1>(() => Chromosome1.generateRandom()));
            }
            Task.WaitAll(has.ToArray());
            for (int i = 0; i < size; i++)
            {
                this.poparr[i] = has[i].Result;
            }
            this.poparr = Sorted(this.poparr);
            //1-2 menit belum selesai
        }

        public Chromosome1[] Sorted(Chromosome1[] data)
        {
            Chromosome1 ch;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = i; j < data.Length; j++)
                {
                    if (data[i].fitness < data[j].fitness)
                    {
                        ch = data[i];
                        data[i] = data[j];
                        data[j] = ch;
                    }
                }
            }
            return data;
        }

        public void evolve()
        {
            List<Chromosome1> buffer = new List<Chromosome1>();
            buffer.AddRange(this.poparr);
            List<Chromosome1> buffer2 = new List<Chromosome1>();
            List<Task<Chromosome1>> t = new List<Task<Chromosome1>>();
            List<Task<Chromosome1[]>> t2 = new List<Task<Chromosome1[]>>();
            Chromosome1 parent1, parent2;

            int cor = (int)Math.Floor((poparr.Length * crossoverratio) / 2);
            int mtr = (int)Math.Floor(this.poparr.Length * mutationratio);

            for (int i = 0; i < (int)Math.Floor((double)cor / 2.0); i++)
            {
                parent1 = this.poparr[rnd.Next(this.poparr.Length)];

                do
                {
                    parent2 = this.poparr.ElementAt(rnd.Next(this.poparr.Length));
                } while (parent1 == parent2);
                t2.Add(Task.Run<Chromosome1[]>(() => parent1.mate(parent2)));
                //t.Add(Task.Run(Chromosome1<>) => parent1.mate(parent2));
                //buffer2.AddRange(parent1.mate(parent2).AsEnumerable());
            }

            for (int i = 0; i < mtr; i++)
            {
                t.Add(Task.Run<Chromosome1>(() => poparr[rnd.Next(this.poparr.Length)].Mutate()));
                //buffer2.Add(this.poparr[rnd.Next(this.poparr.Length)].Mutate());
            }

            Task.WaitAll(t2.ToArray());
            Task.WaitAll(t.ToArray());

            for (int i = 0; i < t2.Count; i++)
            {
                buffer2.AddRange(t2[i].Result);
            }

            for (int i = 0; i < t.Count; i++)
            {
                buffer2.Add(t.ElementAt(i).Result);
            }
            buffer.AddRange(buffer2);
            buffer2.Clear();
            Chromosome1[] has = Sorted(buffer.ToArray());
            this.poparr = has.ToList().GetRange(0, this.poparr.Length).ToArray();
        }

    }
}
