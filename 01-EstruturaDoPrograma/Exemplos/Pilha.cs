using System;

namespace EstruturaDoPrograma.Exemplos
{
    public class Pilha
    {
        Posicao primeiro;

        class Posicao
        {
            public Posicao proximo;
            public object item;
            
            public Posicao(Posicao proximo, object item)
            {
                this.proximo = proximo;
                this.item = item;
            }
        }

        public void Empilha(object item)
        {
            primeiro = new Posicao(primeiro, item);
        }

        public object Desempilha()
        {
            if (primeiro == null)
            {
                throw new ArgumentNullException("A pilha está vazia!"); 
            }
            
            object resultado = primeiro.item;
            primeiro = primeiro.proximo;
            return resultado;   
            
        }    
    }
}