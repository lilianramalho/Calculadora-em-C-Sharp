using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AtividadeDS
{
   public class Calculadora
    {
       public double Somar(double a, double b)
       {
           return a + b;
       }

       public double Somar(double a, double b, double c) {
           return a + b + c;
       }

       public double Somar(double a, double b, double c, double d) {
           return a + b + c + d;
       }

       public double Subtrair(double a, double b) {
           return a - b;
       }

       public double Subtrair(double a, double b, double c) {
           return a - b - c;       
       }

       public double Subtrair(double a, double b, double c, double d) {
           return a - b - c - d;
       }

       public double Multiplicar(double a, double b) {
           return a * b;
       }

       public double Multiplicar(double a, double b, double c) {
           return a * b * c;
       }

       public double Multiplicar(double a, double b, double c, double d) {
           return a * b * c * d;
       }

       public double Dividir(double a, double b) {
           return a / b;
       }

       public double Dividir(double a, double b, double c){
           return a / b / c;
       }

       public double Dividir(double a, double b, double c, double d) {
           return a / b / c / d;
       }

    }
}
