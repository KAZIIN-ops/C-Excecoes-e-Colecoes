using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ExcecoesEmC_.Models
{
    public class Exemplo_Excessão
    {
        public void Metodo1(){
          try{ 
            Metodo2();
        }
        catch(Exception){
            Console.WriteLine("Erro Tratado");

        }}
        public void Metodo2(){
       
            Metodo3();
          
       
        {
           
        }}
        
        public void Metodo3(){
            Metodo4();
        }
        public void Metodo4(){
            throw new Exception("Ocorreu uma excessão");
        }
    }
}