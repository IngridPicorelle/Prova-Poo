using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20ingrid3c1.Code.DTO
{
    class OculosDto
    {
        private int _id;
        private string _nome;
        private string _cor;
        private double _preco;

        public int Id { get => _id; set => _id = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public string Cor { get => _cor; set => _cor = value; }
        public double Preco { get => _preco; set => _preco = value; }

    }
}
