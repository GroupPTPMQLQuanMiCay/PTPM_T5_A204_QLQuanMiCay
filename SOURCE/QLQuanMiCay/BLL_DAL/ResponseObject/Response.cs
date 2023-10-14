using System;
using System.Collections.Generic;
using System.Linq;

namespace BLL_DAL.XuLy
{
    public abstract class Response<T>
    {
        private List<T> _data;
        private int _total;
        private int _current;
        public static int SIZE = 12;

        public List<T> Data { get => _data; set => _data = value; }
        public int Total { get => _total; set => _total = value; }
        public int Current { get => _current; set => _current = value; }

        public Response(List<T> data, int current) {
            _total = int.Parse(Math.Ceiling(double.Parse(data.Count + "") / SIZE) + "");
            _data = data.Skip(SIZE * (current - 1)).Take(SIZE).ToList();
            _current = current;
        }
    }
}
