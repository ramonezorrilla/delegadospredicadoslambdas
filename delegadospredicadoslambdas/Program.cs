using System;
using System.Text.RegularExpressions;

namespace DelegadosPredicadosLambdas

{
    class Delegados
    {
        static void Main(string[] args)
        {

            ObjetoDelegado ElDelegado = new ObjetoDelegado(MensajeBienvenida.SaludoBienvenida);

            ElDelegado("Hola acabo de llegar. Qué tal");


            ElDelegado= new ObjetoDelegado(MensajeDespedida.SaludoDespedida);

            ElDelegado("Hola ya me marcho.Hasta luego");

        }

        delegate void ObjetoDelegado(string msj);


    }

    class MensajeBienvenida
    {
        public static void SaludoBienvenida(string msj)
        {
            Console.WriteLine("Mensaje Bienvenida: {0}", msj);
        
        }
    
    }

    class MensajeDespedida
    {
        public static void SaludoDespedida(string msj)
        {
            Console.WriteLine("Mensaje Despedida: {0}",msj);

        }

    }



}