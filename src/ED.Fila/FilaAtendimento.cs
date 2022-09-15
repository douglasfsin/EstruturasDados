using System;
using System.Collections.Generic;

namespace ED.Fila
{
    public interface IFilaAtendimento
    {
      public int GerarNovaSenha();
      public void ChamarProximaSenha();
      public void MostrarFila();
      public void ReiniciarFila();

    }

    public class FilaAtendimento : IFilaAtendimento
    {
        private Queue<int> _fila;
        private int _proximoNumero = 1;
        
        public FilaAtendimento(){
            _fila = new Queue<int>();
        }

        public void ChamarProximaSenha()
        {
            throw new NotImplementedException();
        }

        public int GerarNovaSenha()
        {
            _fila.Enqueue(_proximoNumero);
            Console.WriteLine("Senha gerada");
            return _proximoNumero++;
        }

        public void MostrarFila()
        {
            Console.Write("Senha na Fila de Atendimento:");
            foreach (var senha in _fila)
            {
                Console.Write($"{senha} ");
            }
            Console.WriteLine();
        }

        public void ReiniciarFila()
        {
            throw new NotImplementedException();
        }
    }

}
