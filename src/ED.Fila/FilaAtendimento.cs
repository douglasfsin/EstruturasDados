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
        private int Proximo = 1;
        
        
        public void ChamarProximaSenha()
        {
            throw new NotImplementedException();
        }

        public int GerarNovaSenha()
        {
            throw new NotImplementedException();
        }

        public void MostrarFila()
        {
            throw new NotImplementedException();
        }

        public void ReiniciarFila()
        {
            throw new NotImplementedException();
        }
    }

}
