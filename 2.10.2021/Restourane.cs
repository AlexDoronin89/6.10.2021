using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._10._2021
{
    class Restourane
    {
        private int _tables;
        private int _clearTables;
      
        private int _busyTables;

        public Restourane(int tables, int clearTables, int busyTables)
        {
            _tables = tables;
            _clearTables = clearTables;
            _busyTables = busyTables;
            
        }

        public void CheckTables(Restourane restourane)
        {
            Console.WriteLine($"{ restourane._tables} <-----всего столов ");
            Console.WriteLine($"{restourane._clearTables} <------всего свободно столов");
            Console.WriteLine($"{restourane._busyTables} <----- всего забронировано");
        }

        public void AddReservation(Restourane restourane)
        {
            if (_clearTables == 0)
            {
                Console.WriteLine("ОШИБКА СВОБОДНЫЕ СТОЛЫ ЗАКОНЧИЛИСЬ");
            }
            else if (_clearTables > 0)
            {
                _clearTables = _clearTables - 1;
                _busyTables = _busyTables + 1;
            }
        }

        public void DeleteReservation(Restourane restourane)
        {
            if (_busyTables == 0)
            {
                
                Console.WriteLine("ОШИБКА ЗАНЯТЫХ СТОЛОВ НЕТ");
            }
            else if (_busyTables >= 0)
            {
                _clearTables = _clearTables + 1;
                _busyTables = _busyTables - 1;
            }
        }

        

    }
}
