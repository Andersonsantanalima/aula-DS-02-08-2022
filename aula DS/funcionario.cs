using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_DS
{
    class funcionario
    {
        public string nome;
        public double quanHora;
        public double valorHora;
        public double salBruto;
        public double valorIr;
        public double valorInss;
        public double salLiquid;

        public double calcSalBruto(){
           this.salBruto = this.quanHora * this.valorHora;
            return this.salBruto;
        }

        public double calcIr(){
            this.valorIr = this.salBruto * 0.1;
            return this.valorIr;
        }

        public double calcInss(){
            this.valorInss = this.salBruto * 0.05;
            return this.valorInss;
        }

        public double calcSalLiquido(){
            this.salLiquid = this.salBruto - (this.valorInss + this.valorIr);
            return this.salLiquid;
        }
    }
}

