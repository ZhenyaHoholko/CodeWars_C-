using System;
using System.Collections;

namespace CSharpEssentials
{
    public class Flat
    {
        public int Number { get; set; }
        public int RoomsCount { get; set; }

        public override string ToString()
        {
            return $"Квартира с номером {Number} имеет {RoomsCount} комнат";
        }
    }
    public class Entrance : IEnumerable
    {
        private readonly Flat[] flats;

        public Entrance(Flat[] flats)
        {
            this.flats = flats;
        }
        public IEnumerator GetEnumerator()
        {
            return new EntranceEnumerator(flats);
        }
    }
    public class EntranceEnumerator : IEnumerator
    {
        private readonly Flat[] flats;
        private int index = -1;
        public EntranceEnumerator(Flat[] flats)
        {
            this.flats = flats;
        }
        public object Current
        {
            get
            {
                if (index < 0 || index >= flats.Length)
                    throw new InvalidOperationException("Индекс находится вне диапазона.");
                return flats[index];
            }
        }
        public bool MoveNext()
        {
            index++;
            return index < flats.Length;
        }
        public void Reset()
        {
            index = -1;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var flats = new Flat[]
            {
                new Flat { Number = 1, RoomsCount = 2 },
                new Flat { Number = 2, RoomsCount = 3 },
                new Flat { Number = 3, RoomsCount = 4 }
            };
            var entrance = new Entrance(flats);
            foreach (Flat flat in entrance)
            {
                Console.WriteLine(flat);
            }
        }
    }
}
