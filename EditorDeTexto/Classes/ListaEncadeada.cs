using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorDeTexto.Classes
{
    public class ListaEncadeada
    {
        public No cabeca, cauda;
        public int qtdElementos;
        public ListaEncadeada()
        {
            //this.cabeca.next = cauda;
            //this.cabeca.prev = null;
            //this.cauda.prev = cabeca;
            //this.cauda.next = null;
            //this.qtdElementos = 0;
        }

        public void insereFim(string elemento)
        {
            No novoNo = new No();
            novoNo.elemento = elemento;

            if (cabeca == null)
            {
                cabeca = novoNo;
            }
            else
            {
                cauda.next = novoNo;
            }
            cauda = novoNo;
        }

        //Inserir elemento no inicio da lista
        public void insereInicio(string elemento)
        {
            No novo = new No();
            novo.elemento = elemento;

            if (cabeca == null)
            {
                cabeca = novo;
                cauda = novo;
            }
            else
            {
                novo.next = cabeca;
            }
            cabeca = novo;
        }

        //Retirar elemento do fim da lista
        public void retiraFim()
        {
            if (cabeca == null)
                return;

            if (cabeca.next == null)
            {
                
                cabeca = null;
            }
            else
            {
                No ultimo = cabeca.next;
                No penultimo = cabeca;

                while (ultimo.next != null)
                {
                    penultimo = ultimo;
                    ultimo = ultimo.next;
                }
                penultimo.next = null;
                
            }
            
        }

        //Retirar elemento do inicio da lista
        public void retiraInicio()
        {
            if (cabeca != null)
            {
                
                cabeca = cabeca.next;
            }
            
        }

        public bool buscaElemento(string palavra)
        {
            bool resultado = true;

            if (cabeca != null)
            {
                No temp = cabeca;
                string elemento = temp.elemento;
                while ( palavra != elemento && temp != null)
                {
                    if (palavra != elemento)
                    {

                         resultado = false;
                        
                         temp = temp.next;
                    }

                }                             
            }
            return resultado;
        }

    }
}
