using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSueldos
{
    public class CalcularSueldo
    {
        // Propiedades para los valores de hora y hora extra
        public decimal ValorHora { get; private set; }        
        public decimal ValorHoraExtra { get; private set; }

        public CalcularSueldo(decimal valorHora, decimal valorHoraExtra)
        {
            ValorHora = valorHora;
            ValorHoraExtra = valorHoraExtra;
        }

        public decimal CalcularSueldoBruto(int horasTrabajadas, int horasExtras)
        {
            decimal sueldoBase = (decimal)horasTrabajadas * ValorHora;
            decimal sueldoExtra = (decimal)horasExtras * ValorHoraExtra;
            return sueldoBase + sueldoExtra;
        }

        // Función para calcular el Descuento AFP
        public decimal CalcularDescuentoAFP(decimal sueldoBruto, string afp)
        {
            decimal tasaDescuento = 0M;

            switch (afp)
            {
                case "CUPRUM":
                    tasaDescuento = 0.07M; // 7%
                    break;
                case "MODELO":
                    tasaDescuento = 0.09M; // 9%
                    break;
                case "CAPITAL":
                    tasaDescuento = 0.12M; // 12%
                    break;
                case "PROVIDA":
                    tasaDescuento = 0.13M; // 13%
                    break;
                default:
                    break;
            }

            return sueldoBruto * tasaDescuento;
        }

        // Función para calcular el Descuento de Salud
        public decimal CalcularDescuentoSalud(decimal sueldoBruto, string sistemaSalud)
        {
            decimal tasaDescuento = 0M;

            switch (sistemaSalud)
            {
                case "FONASA":
                    tasaDescuento = 0.12M; // 12%
                    break;
                case "CONSALUD":
                    tasaDescuento = 0.13M; // 13%
                    break;
                case "MASVIDA":
                    tasaDescuento = 0.14M; // 14%
                    break;
                case "BANMEDICA":
                    tasaDescuento = 0.15M; // 15%
                    break;
                default:
                    break;
            }

            return sueldoBruto * tasaDescuento;
        }
    }

}
