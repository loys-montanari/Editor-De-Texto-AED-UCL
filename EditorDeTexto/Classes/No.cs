using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorDeTexto.Classes
{
    public class No
    {
        public String elemento;
        public No next, prev;

        public No()
        {
            this.elemento = "";
            this.next = null;
            this.prev = null;

        }
        public No(String s, No n, No p)
        {
            elemento = s;
            next = n;
            prev = p;
        }
        public String getElemento() { return elemento; }
        public No getNext() { return next; }
        public No getPrev() { return prev; }
        public void setElemento(String e) { elemento = e; }
        public void setNext(No n) { next = n; }
        public void setPrev(No n) { prev = n; }


    }
}
